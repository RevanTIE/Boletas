using System;
using Boletas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;
using Boletas.Module.Administrar.View.PrimerasComuniones;

namespace Boletas.Module.Administrar.Model.Comuniones
{
    class BoletaComuniones
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string generarBoletaComunion(string idComunion)
        {

            string nombre, nombrePadre, nombreMadre, nombrePadrino, nombreMadrina,
                catequista, parroco, parroquia;
            DateTime fechaComunion;
            string fComunionAnio, fComunionMes, fComunionDia;

            parroquia = bd.SelectString("Select nombre from parroquia where id = 1").ToString();
            nombre = bd.SelectString("Select CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from primerasComuniones where id = '" + idComunion + "'").ToString();
            nombrePadre = bd.SelectString("Select nombrePadre from primerasComuniones where id = '" + idComunion + "'").ToString();
            nombreMadre = bd.SelectString("Select nombreMadre from primerasComuniones where id = '" + idComunion + "'").ToString();
            fechaComunion = Convert.ToDateTime(bd.SelectString("Select fechaComunion from primerasComuniones where id = '" + idComunion + "'").ToString());
            nombrePadrino = bd.SelectString("Select nombrePadrino from primerasComuniones where id = '" + idComunion + "'").ToString();
            nombreMadrina = bd.SelectString("Select nombreMadrina from primerasComuniones where id = '" + idComunion + "'").ToString();
            catequista = bd.SelectString("Select CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.id = '" + idComunion + "'").ToString();
            parroco = bd.SelectString("Select CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) from primerasComuniones INNER JOIN parroco ON primerasComuniones.idParroco = parroco.id where primerasComuniones.id = '" + idComunion + "'").ToString();


            fComunionAnio = fechaComunion.ToString().Substring(6, 4);
            fComunionMes = mes(fechaComunion.Month);
            fComunionDia = fechaComunion.ToString().Substring(0, 2);

            /**
             *Se puede usar la siguiente función para que se genere un código único para la boleta.
             *Guid.NewGuid().ToString()
             **/
            string ruta = System.IO.Path.GetTempPath() + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "_" + "Boleta Comuniones_" + nombre + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.HALFLETTER.Rotate(), 80, 80, 10, 10);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open(); //Abre el documento para escribir.
            //Aqui va algún contenido.
            //Encabezado:
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 20, 1, BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph("\n PARROQUIA DE "+ parroquia, fntHead);
            prgHeading.Alignment = Element.ALIGN_CENTER;
            doc.Add(prgHeading);

            BaseFont bfntSub = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntSub = new Font(bfntSub, 14, 2, BaseColor.BLACK);
            fntSub.SetStyle(Font.BOLD);
            Paragraph subTitle = new Paragraph("\"El que come mi carne y bebe mi sangre tiene \n vida eterna y yo lo resucitaré el último día\"", fntSub);
            Paragraph subTitle2 = new Paragraph("(Jn 6.54)", fntSub);
            subTitle.Alignment = Element.ALIGN_LEFT;
            subTitle2.Alignment = Element.ALIGN_CENTER;
            doc.Add(subTitle);
            doc.Add(subTitle2);

            /**Imagen*/
            string archivoImagen = "comunion.png";
            string imagenPath = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen);

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(imagenPath);
            imagen.Alignment = Element.ALIGN_RIGHT;
            imagen.ScaleAbsolute(120f, 100f);
            imagen.SetAbsolutePosition(470f, 250f);
            doc.Add(imagen);

            /**Imagen Margen Superior Izquierdo*/
            string archivoImagen2 = "comunionEsquinaSuperiorIzquierda.png";
            string imagenPath2 = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen2);

            iTextSharp.text.Image margen1 = iTextSharp.text.Image.GetInstance(imagenPath2);
            margen1.Alignment = Element.ALIGN_LEFT;
            margen1.ScaleAbsolute(80f, 150f);
            margen1.SetAbsolutePosition(30f, 230f);
            doc.Add(margen1);

            /**Imagen Margen Inferior Izquierdo*/
            string archivoImagen3 = "comunionEsquinaInferiorIzquierda.png";
            string imagenPath3 = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen3);

            iTextSharp.text.Image margen2 = iTextSharp.text.Image.GetInstance(imagenPath3);
            margen2.Alignment = Element.ALIGN_LEFT;
            margen2.ScaleAbsolute(80f, 150f);
            margen2.SetAbsolutePosition(30f, 30f);
            doc.Add(margen2);

            /**Imagen Margen Inferior Derecho*/
            string archivoImagen4 = "comunionEsquinaInferiorDerecha.png";
            string imagenPath4 = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen4);

            iTextSharp.text.Image margen3 = iTextSharp.text.Image.GetInstance(imagenPath4);
            margen3.Alignment = Element.ALIGN_LEFT;
            margen3.ScaleAbsolute(80f, 150f);
            margen3.SetAbsolutePosition(500f, 30f);
            doc.Add(margen3);

            BaseFont bfntPar = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            /**Fuente para las letras normales*/
            Font fntPar = new Font(bfntPar, 14, 1, BaseColor.BLACK);
            /**Fuente para las letras subrayadas*/
            Font fntVar = new Font(bfntPar, 14, 1, BaseColor.BLACK);
            /*Las variables irán subrayadas**/
            fntVar.SetStyle(Font.UNDERLINE);

            Chunk c1 = new Chunk("\nYO ", fntPar);
            Chunk c2 = new Chunk(nombre, fntVar);
            Chunk c3 = new Chunk("\n"+ "\n", fntPar);
            Phrase p1 = new Phrase();
            p1.Add(c1);
            p1.Add(c2);
            p1.Add(c3);

            Chunk c4 = new Chunk("HICE MI PRIMERA COMUNIÓN EN MI PARROQUIA DE SAN CRISTÓBAL" + "\n"+ "\n", fntPar);
            Phrase p2 = new Phrase();
            p2.Add(c4);

            Chunk c5 = new Chunk("EL DÍA:", fntPar);
            Chunk c6 = new Chunk(fComunionDia, fntVar);
            Chunk c7 = new Chunk(" DE ", fntPar);
            Chunk c8 = new Chunk(fComunionMes.ToUpper(), fntVar);
            Chunk c9 = new Chunk(" DEL ", fntPar);
            Chunk c10 = new Chunk(fComunionAnio, fntVar);
            Chunk c11 = new Chunk("\n"+ "\n", fntPar);
            Chunk c12 = new Chunk("MI PADRINO: ", fntPar);
            Chunk c13 = new Chunk(nombrePadrino, fntVar);
            Chunk c14 = new Chunk("\n"+ "\n", fntPar);
            Chunk c15 = new Chunk("MI MADRINA: ", fntPar);
            Chunk c16 = new Chunk(nombreMadrina, fntVar);
            Chunk c17 = new Chunk("\n"+ "\n" + "\n", fntPar);
            
            Phrase p3 = new Phrase();
            p3.Add(c5);
            p3.Add(c6);
            p3.Add(c7);
            p3.Add(c8);
            p3.Add(c9);
            p3.Add(c10);
            p3.Add(c11);
            p3.Add(c12);
            p3.Add(c13);
            p3.Add(c14);
            p3.Add(c15);
            p3.Add(c16);
            p3.Add(c17);

            
            //Chunk c18 = new Chunk(catequista, fntVar);
            //Chunk c19 = new Chunk("\n" + "\n", fntPar);
            //Chunk c20 = new Chunk("CATEQUISTA", fntPar);
            Phrase p4 = new Phrase("_________________________" + "\n" + "               CATEQUISTA               " + "\n" + "\n", fntPar);

            //Chunk c21 = new Chunk(parroco, fntVar);
            //Chunk c22 = new Chunk("\n" + "\n", fntPar);
            //Chunk c23 = new Chunk("EL PÁRROCO", fntPar);
            Phrase p5 = new Phrase("_________________________" + "\n" + "               EL PÁRROCO               " + "\n" + "\n", fntPar);

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell();
            cell.Border = 0;
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);
            table.AddCell(p5);
            table.AddCell(p4);

            Paragraph paragraph = new Paragraph();
            paragraph.Add(p1);
            //Ahora añade el texto creado arriba, usando un objeto de la clase para nuestro documento pdf.

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Add(p2);

            Paragraph paragraph3 = new Paragraph();
            paragraph3.Add(p3);

            Paragraph paragraph4 = new Paragraph();
            paragraph4.Add(p4);

            Paragraph paragraph5 = new Paragraph();
            paragraph5.Add(p5);

            paragraph.Alignment = Element.ALIGN_LEFT;
            paragraph2.Alignment = Element.ALIGN_CENTER;
            paragraph3.Alignment = Element.ALIGN_RIGHT;
            table.HorizontalAlignment = Element.ALIGN_CENTER;

            doc.Add(paragraph);
            doc.Add(paragraph2);
            doc.Add(paragraph3);
            doc.Add(table);

            MessageBox.Show("Boleta Generada con éxito", "Generación de Boleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doc.Close();

            /**
             Se obtiene la ruta del pdf y se abre dentro de la ventana modal, con ello ya puede mandarse a imprimir o guardar donde se desee.
             */
            Process prc = new System.Diagnostics.Process();

            ComunionesModal modal = new ComunionesModal(ruta);
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();

            /**
             * Proceso para abrir el archivo generado en Adobe Reader:
            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = ruta;
            prc.Start(); **/

            return ruta;
        }
        static string mes(int numerico)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(numerico);
        }
    }
}
