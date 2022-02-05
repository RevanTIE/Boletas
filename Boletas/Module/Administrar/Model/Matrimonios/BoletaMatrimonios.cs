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
using Boletas.Module.Administrar.View.Matrimonios;

namespace Boletas.Module.Administrar.Model.Matrimonios
{
    class BoletaMatrimonios
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string generarBoletaMatrimonio(string idMatrimonio)
        {

            string nombreEsposo, nombreEsposa, parroquiaProcedencia, parroquia, padrinoVelacion, madrinaVelacion,
                padrinoAnillos, madrinaAnillos, padrinoArras, madrinaArras, parroco, ministro;
            DateTime fechaMatrimonio;
            string fMatrimonioAnio, fMatrimonioMes, fMatrimonioDia;

            parroquia = bd.SelectString("Select nombre from parroquia where id = 1").ToString();
            fechaMatrimonio = Convert.ToDateTime(bd.SelectString("Select fechaMatrimonio from matrimonios where id = '" + idMatrimonio + "'").ToString());
            nombreEsposo = bd.SelectString("Select CONCAT(nombreEsposo,' ',apellidoPaternoEsposo,' ',apellidoMaternoEsposo) as NombreEsposo from matrimonios where id = '" + idMatrimonio + "'").ToString();
            nombreEsposa = bd.SelectString("Select CONCAT(nombreEsposa,' ',apellidoPaternoEsposa,' ',apellidoMaternoEsposa) as NombreEsposa from matrimonios where id = '" + idMatrimonio + "'").ToString();
            parroquiaProcedencia = bd.SelectString("Select parroquiaProcedencia from matrimonios where id = '" + idMatrimonio + "'").ToString();
            padrinoVelacion = bd.SelectString("Select padrinoVelacion from matrimonios where id = '" + idMatrimonio + "'").ToString();
            madrinaVelacion = bd.SelectString("Select madrinaVelacion from matrimonios where id = '" + idMatrimonio + "'").ToString();
            padrinoAnillos = bd.SelectString("Select padrinoAnillos from matrimonios where id = '" + idMatrimonio + "'").ToString();
            madrinaAnillos = bd.SelectString("Select madrinaAnillos from matrimonios where id = '" + idMatrimonio + "'").ToString();
            padrinoArras = bd.SelectString("Select padrinoArras from matrimonios where id = '" + idMatrimonio + "'").ToString();
            madrinaArras = bd.SelectString("Select madrinaArras from matrimonios where id = '" + idMatrimonio + "'").ToString();
            parroco = bd.SelectString("Select CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) from matrimonios INNER JOIN parroco ON matrimonios.idParroco = parroco.id where matrimonios.id = '" + idMatrimonio + "'").ToString();
            ministro = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from matrimonios INNER JOIN ministros ON matrimonios.idMinistro = ministros.id where matrimonios.id = '" + idMatrimonio + "'").ToString();

            fMatrimonioAnio = fechaMatrimonio.ToString().Substring(6, 4);
            fMatrimonioMes = mes(fechaMatrimonio.Month);
            fMatrimonioDia = fechaMatrimonio.ToString().Substring(0, 2);

            /**
             *Se puede usar la siguiente función para que se genere un código único para la boleta.
             *Guid.NewGuid().ToString()
             **/
            string ruta = System.IO.Path.GetTempPath() + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "_" + "Boleta Matrimonios_" + nombreEsposo + "-" + nombreEsposa + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 30, 30);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open(); //Abre el documento para escribir.
            PdfContentByte cb = wri.DirectContent;
            cb.RoundRectangle(30f, 30f, 550f, 730f, 30f);
            cb.Stroke();

            PdfContentByte cb2 = wri.DirectContent;
            cb2.RoundRectangle(35f, 35f, 540f, 720f, 33f);
            cb2.Stroke();
            //Aqui va algún contenido.
            //Encabezado:
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 30, 1, BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph("CERTIFICO", fntHead);
            prgHeading.Alignment = Element.ALIGN_CENTER;
            doc.Add(prgHeading);

            BaseFont bfntPar = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            /**Fuente para las letras normales*/
            Font fntPar = new Font(bfntPar, 13, 1, BaseColor.BLACK);
            /**Fuente para las letras subrayadas*/
            Font fntVar = new Font(bfntPar, 13, 1, BaseColor.BLACK);
            /*Las variables irán subrayadas**/
            fntVar.SetStyle(Font.UNDERLINE);
            /**Fuente para la leyenda de contrayentes*/
            Font fntLeyenda = new Font(bfntPar, 12, 1, BaseColor.BLACK);

            Chunk c1 = new Chunk("\nQUE EN EL TEMPLO PARROQUIAL DE ", fntPar);
            Chunk c2 = new Chunk(parroquia, fntVar);
            Chunk c3 = new Chunk("\n" + "\n", fntPar);
            Chunk c4 = new Chunk("ARQUIDIÓCESIS DE ACAPULCO, GUERRERO, MEXICO." + "\n" + "\n", fntPar);
            Chunk c5 = new Chunk("EL DIA ", fntPar);
            Chunk c6 = new Chunk(fMatrimonioDia, fntVar);
            Chunk c7 = new Chunk(" DE ", fntPar);
            Chunk c8 = new Chunk(fMatrimonioMes.ToUpper(), fntVar);
            Chunk c9 = new Chunk(" DE ", fntPar);
            Chunk c10 = new Chunk(fMatrimonioAnio, fntVar);
            Chunk c11 = new Chunk("\n" + "\n", fntPar);
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

            //Ahora añade el texto creado arriba, usando un objeto de la clase para nuestro documento pdf.
            Font fntLnd = new Font(bfntPar, 18, 1, BaseColor.BLACK);
            fntLnd.SetStyle(Font.BOLD);
            Chunk c12 = new Chunk("CONTRAJERON MATRIMONIO ECLESIASTICO"+"\n" + "\n", fntLnd);
            Phrase p2 = new Phrase();
            p2.Add(c12);

            Chunk c13 = new Chunk("EL SEÑOR ", fntPar);
            Chunk c14 = new Chunk(nombreEsposo, fntVar);
            Chunk c15 = new Chunk("\n" + "\n", fntPar);
            Chunk c16 = new Chunk("CON LA SEÑORITA ", fntPar);
            Chunk c17 = new Chunk(nombreEsposa, fntVar);
            Chunk c18 = new Chunk("\n" + "\n", fntPar);
            Chunk c19 = new Chunk("FELIGRESES DE ", fntPar);
            Chunk c20 = new Chunk(parroquiaProcedencia, fntVar);
            Chunk c21 = new Chunk("\n" + "\n", fntPar);
            Chunk c22 = new Chunk("ASISTIENDO AL MATRIMONIO EL PBRO. ", fntPar);
            Chunk c23 = new Chunk(parroco, fntVar);
            Chunk c24 = new Chunk("\n" + "\n", fntPar);
            Chunk c25 = new Chunk("CELEBRO LA MISA DE VELACION EL MINISTRO ", fntPar);
            Chunk c26 = new Chunk(ministro, fntVar);
            Chunk c27 = new Chunk("\n" + "\n", fntPar);
            Phrase p3 = new Phrase();
            p3.Add(c13);
            p3.Add(c14);
            p3.Add(c15);
            p3.Add(c16);
            p3.Add(c17);
            p3.Add(c18);
            p3.Add(c19);
            p3.Add(c20);
            p3.Add(c21);
            p3.Add(c22);
            p3.Add(c23);
            p3.Add(c24);
            p3.Add(c25);
            p3.Add(c26);
            p3.Add(c27);

            Chunk c28 = new Chunk("A ESTE ACTO LO MISMO QUE LA BENDICIÓN NUPCIAL QUE RECIBIERON LOS CONTRAYENTES ASISTIERON COMO PADRINOS O TESTIGOS LOS QUE ABAJO FIRMAN." + "\n" + "\n" + "\n", fntLeyenda);
            Phrase p4 = new Phrase();
            p4.Add(c28);

            Paragraph paragraph1 = new Paragraph();
            paragraph1.Add(p1);
            Paragraph paragraph2 = new Paragraph();
            paragraph2.Add(p2);
            Paragraph paragraph3 = new Paragraph();
            paragraph3.Add(p3);
            Paragraph paragraph4 = new Paragraph();
            paragraph4.Add(p4);

            Phrase p5 = new Phrase("___________________________" + "\n" + "                   ESPOSO                 " + "\n" + "\n" + "\n", fntPar);
            Phrase p6 = new Phrase("___________________________" + "\n" + "                   ESPOSA                 " + "\n" + "\n" + "\n", fntPar);
            Phrase p7 = new Phrase("___________________________" + "\n" + "       PADRINO DE VELACIÓN      " + "\n" + "\n" + "\n", fntPar);
            Phrase p8 = new Phrase("___________________________" + "\n" + "       MADRINA DE VELACIÓN      " + "\n" + "\n" + "\n", fntPar);
            Phrase p9 = new Phrase("___________________________" + "\n" + "        PADRINO DE ANILLOS        " + "\n" + "\n" + "\n", fntPar);
            Phrase p10 = new Phrase("___________________________" + "\n" + "        MADRINA DE ANILLOS        " + "\n" + "\n" + "\n", fntPar);
            Phrase p11 = new Phrase("___________________________" + "\n" + "         PADRINO DE ARRAS         " + "\n" + "\n" + "\n", fntPar);
            Phrase p12 = new Phrase("___________________________" + "\n" + "         MADRINA DE ARRAS         " + "\n" + "\n" + "\n", fntPar);
            Phrase p13 = new Phrase("___________________________" + "\n" + "                  PARROCO                 " + "\n" + "\n", fntPar);
            Phrase p14 = new Phrase("___________________________" + "\n" + "        MINISTRO ASISTENTE       " + "\n" + "\n" + "\n", fntPar);

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell();
            cell.Border = 0;
            cell.Colspan = 2;
            //cell.UseVariableBorders = true;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.DefaultCell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);
            table.AddCell(p5);
            table.AddCell(p6);
            table.AddCell(p7);
            table.AddCell(p8);
            table.AddCell(p9);
            table.AddCell(p10);
            table.AddCell(p11);
            table.AddCell(p12);
            table.AddCell(p13);
            table.AddCell(p14);

            paragraph1.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph2.Alignment = Element.ALIGN_CENTER;
            paragraph3.Alignment = Element.ALIGN_JUSTIFIED;
            paragraph4.Alignment = Element.ALIGN_CENTER;
            table.HorizontalAlignment = Element.ALIGN_CENTER;

            doc.Add(paragraph1);
            doc.Add(paragraph2);
            doc.Add(paragraph3);
            doc.Add(paragraph4);
            doc.Add(table);

            MessageBox.Show("Boleta Generada con éxito", "Generación de Boleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doc.Close();

            /**
             Se obtiene la ruta del pdf y se abre dentro de la ventana modal, con ello ya puede mandarse a imprimir o guardar donde se desee.
             */
            Process prc = new System.Diagnostics.Process();

            MatrimoniosModal modal = new MatrimoniosModal(ruta);
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
