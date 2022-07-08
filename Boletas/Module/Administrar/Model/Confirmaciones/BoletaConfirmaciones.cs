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
using Boletas.Module.Administrar.View.Confirmaciones;

namespace Boletas.Module.Administrar.Model.Confirmaciones
{
    class BoletaConfirmaciones
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string generarBoletaConfirmacion(string idConfirmado)
        {

            string nombre, nombrePadre, nombreMadre, nombrePadrino, nombreMadrina,
                lugarBautismo, lugarConfirmacion, municipio, ciudad, estado, ministro;
            DateTime fechaBautismo, fechaConfirmacion;
            string fBautismoAnio, fBautismoMes, fBautismoDia, fConfirmacionAnio, fConfirmacionMes, fConfirmacionDia;

            try {
                nombre = bd.SelectString("Select CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from confirmaciones where id = '" + idConfirmado + "'").ToString();
                nombrePadre = bd.SelectString("Select nombrePadre from confirmaciones where id = '" + idConfirmado + "'").ToString();
                nombreMadre = bd.SelectString("Select nombreMadre from confirmaciones where id = '" + idConfirmado + "'").ToString();
                nombrePadrino = bd.SelectString("Select nombrePadrino from confirmaciones where id = '" + idConfirmado + "'").ToString();
                nombreMadrina = bd.SelectString("Select nombreMadrina from confirmaciones where id = '" + idConfirmado + "'").ToString();
                lugarBautismo = bd.SelectString("Select lugarBautismo from confirmaciones where id = '" + idConfirmado + "'").ToString();
                fechaBautismo = Convert.ToDateTime(bd.SelectString("Select fechaBautismo from confirmaciones where id = '" + idConfirmado + "'").ToString());
                lugarConfirmacion = bd.SelectString("Select lugarConfirmacion from confirmaciones where id = '" + idConfirmado + "'").ToString();
                fechaConfirmacion = Convert.ToDateTime(bd.SelectString("Select fechaConfirmacion from confirmaciones where id = '" + idConfirmado + "'").ToString());
                municipio = bd.SelectString("Select municipio from confirmaciones where id = '" + idConfirmado + "'").ToString();
                ciudad = bd.SelectString("Select ciudad from confirmaciones where id = '" + idConfirmado + "'").ToString();
                estado = bd.SelectString("Select estados.nombre from confirmaciones INNER JOIN estados ON confirmaciones.idEstado = estados.id where confirmaciones.id = '" + idConfirmado + "'").ToString();
                ministro = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from confirmaciones INNER JOIN ministros ON confirmaciones.idMinistro = ministros.id where confirmaciones.id = '" + idConfirmado + "'").ToString();


                fBautismoAnio = fechaBautismo.ToString().Substring(6, 4);
                fBautismoMes = mes(fechaBautismo.Month);
                fBautismoDia = fechaBautismo.ToString().Substring(0, 2);
                fConfirmacionAnio = fechaConfirmacion.ToString().Substring(6, 4);
                fConfirmacionMes = mes(fechaConfirmacion.Month);
                fConfirmacionDia = fechaConfirmacion.ToString().Substring(0, 2);

                /**
                 *Se puede usar la siguiente función para que se genere un código único para la boleta.
                 *Guid.NewGuid().ToString()
                 **/
                string ruta = System.IO.Path.GetTempPath() + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "_" + "Boleta Confirmacion_" + nombre + ".pdf";
                Document doc = new Document(iTextSharp.text.PageSize.HALFLETTER, 30, 30, 30, 30);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                doc.Open(); //Abre el documento para escribir.
                PdfContentByte cb = wri.DirectContent;
                cb.RoundRectangle(25f, 25f, 342f, 557f, 25f);
                cb.Stroke();
                //Aqui va algún contenido.
                //Encabezado:
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 25, 1, BaseColor.BLACK);
                Paragraph prgHeading = new Paragraph("BOLETA DE CONFIRMACIÓN", fntHead);
                prgHeading.Alignment = Element.ALIGN_CENTER;
                // doc.Add(prgHeading);

                /**Imagen*/
                string archivoImagen = "confirmacion.png";
                string imagenPath = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen);

                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(imagenPath);
                imagen.Alignment = Element.ALIGN_CENTER;
                imagen.ScaleAbsolute(240f, 300f);
                doc.Add(imagen);

                BaseFont bfntSub = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntSub = new Font(bfntSub, 22, 2, BaseColor.BLACK);
                Paragraph subTitle = new Paragraph("ARQUIDIÓCESIS DE ACAPULCO", fntSub);
                subTitle.Alignment = Element.ALIGN_CENTER;
                //doc.Add(subTitle);

                BaseFont bfntPar = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                /**Fuente para las letras normales*/
                Font fntPar = new Font(bfntPar, 12, 1);
                /**Fuente para las letras subrayadas*/
                Font fntVar = new Font(bfntPar, 12, 1);
                /*Las variables irán subrayadas**/
                fntVar.SetStyle(Font.UNDERLINE);

                Chunk c1 = new Chunk("\nCONFIRMACIÓN DE: ", fntPar);
                Chunk c2 = new Chunk(nombre, fntVar);
                Chunk c3 = new Chunk("\n", fntPar);
                Chunk c4 = new Chunk("MINISTRO: ", fntPar);
                Chunk c5 = new Chunk(ministro, fntVar);
                Chunk c6 = new Chunk("\n", fntPar);
                Chunk c7 = new Chunk("PADRE: ", fntPar);
                Chunk c8 = new Chunk(nombrePadre, fntVar);
                Chunk c9 = new Chunk("\n", fntPar);
                Chunk c10 = new Chunk("MADRE: ", fntPar);
                Chunk c11 = new Chunk(nombreMadre, fntVar);
                Chunk c12 = new Chunk("\n", fntPar);
                Chunk c13 = new Chunk("PADRINO: ", fntPar);
                Chunk c14 = new Chunk(nombrePadrino, fntVar);
                Chunk c15 = new Chunk("\n", fntPar);
                Chunk c16 = new Chunk("MADRINA: ", fntPar);
                Chunk c17 = new Chunk(nombreMadrina, fntVar);
                Chunk c18 = new Chunk("\n", fntPar);
                Chunk c19 = new Chunk("LUGAR Y FECHA DE BAUTISMO: ", fntPar);
                Chunk c20 = new Chunk(lugarBautismo, fntVar);
                Chunk c21 = new Chunk("\n", fntPar);
                Chunk c22 = new Chunk(fBautismoDia, fntVar);
                Chunk c23 = new Chunk(" DE ", fntPar);
                Chunk c24 = new Chunk(fBautismoMes.ToUpper(), fntVar);
                Chunk c25 = new Chunk(" DEL AÑO ", fntPar);
                Chunk c26 = new Chunk(fBautismoAnio, fntVar);
                Chunk c27 = new Chunk("\n", fntPar);
                Chunk c28 = new Chunk("LUGAR Y FECHA DE CONFIRMACIÓN: ", fntPar);
                Chunk c29 = new Chunk(ciudad, fntVar);
                Chunk c30 = new Chunk(", ", fntPar);
                Chunk c31 = new Chunk(municipio, fntVar);
                Chunk c32 = new Chunk(", ", fntPar);
                Chunk c33 = new Chunk(estado, fntVar);
                Chunk c34 = new Chunk("\n", fntPar);
                Chunk c35 = new Chunk(fConfirmacionDia, fntVar);
                Chunk c36 = new Chunk(" DE ", fntPar);
                Chunk c37 = new Chunk(fConfirmacionMes.ToUpper(), fntVar);
                Chunk c38 = new Chunk(" DEL AÑO ", fntPar);
                Chunk c39 = new Chunk(fConfirmacionAnio, fntVar);
                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                p1.Add(c3);
                p1.Add(c4);
                p1.Add(c5);
                p1.Add(c6);
                p1.Add(c7);
                p1.Add(c8);
                p1.Add(c9);
                p1.Add(c10);
                p1.Add(c11);
                p1.Add(c12);
                p1.Add(c13);
                p1.Add(c14);
                p1.Add(c15);
                p1.Add(c16);
                p1.Add(c17);
                p1.Add(c18);
                p1.Add(c19);
                p1.Add(c20);
                p1.Add(c21);
                p1.Add(c22);
                p1.Add(c23);
                p1.Add(c24);
                p1.Add(c25);
                p1.Add(c26);
                p1.Add(c27);
                p1.Add(c28);
                p1.Add(c29);
                p1.Add(c30);
                p1.Add(c31);
                p1.Add(c32);
                p1.Add(c33);
                p1.Add(c34);
                p1.Add(c35);
                p1.Add(c36);
                p1.Add(c37);
                p1.Add(c38);
                p1.Add(c39);

                Paragraph paragraph = new Paragraph();
                paragraph.Add(p1);
                //Ahora añade el texto creado arriba, usando un objeto de la clase para nuestro documento pdf.
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(paragraph);

                MessageBox.Show("Boleta Generada con éxito", "Generación de Boleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doc.Close();

                /**
                 Se obtiene la ruta del pdf y se abre dentro de la ventana modal, con ello ya puede mandarse a imprimir o guardar donde se desee.
                 */
                Process prc = new System.Diagnostics.Process();

                ConfirmacionesModal modal = new ConfirmacionesModal(ruta);
                modal.StartPosition = FormStartPosition.CenterScreen;
                modal.ShowDialog();

                /**
                 * Proceso para abrir el archivo generado en Adobe Reader:
                Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = ruta;
                prc.Start(); **/

                return ruta;
            }

            catch (Exception e)
            {
                MessageBox.Show("HA OCURRIDO EL SIGUIENTE ERROR: \n" + e.Message, "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        static string mes(int numerico)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(numerico);
        }
    }
}
