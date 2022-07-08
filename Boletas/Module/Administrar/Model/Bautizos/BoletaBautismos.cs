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
using Boletas.Module.Administrar.View.Bautizos;
using Boletas.Model;
using System.Runtime.CompilerServices;

namespace Boletas.Module.Administrar.Model.Bautizos
{
    class BoletaBautismos : INotifyPropertyChanged
    {
        BaseDeDatos bd = new BaseDeDatos();
        Entities context = new Entities();

        public event PropertyChangedEventHandler PropertyChanged;

        private string _nombre;

        public string nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged();

            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _sexo;

        public int sexo
        {
            get => _sexo;
            set
            {
                _sexo = value;
                OnPropertyChanged();
            }
        }

        private string _nombrePadre;

        public string nombrePadre
        {
            get => _nombrePadre;
            set
            {
                _nombrePadre= value;
                OnPropertyChanged();
            }
        }

        private string _nombreMadre;

        public string nombreMadre
        {
            get => _nombreMadre;
            set
            {
                _nombreMadre = value;
                OnPropertyChanged();
            }
        }

        private string _nombrePadrino;

        public string nombrePadrino
        {
            get => _nombrePadrino;
            set
            {
                _nombrePadrino = value;
                OnPropertyChanged();
            }
        }

        private string _nombreMadrina;

        public string nombreMadrina
        {
            get => _nombreMadrina;
            set
            {
                _nombreMadrina = value;
                OnPropertyChanged();
            }
        }

        private string _parroquia;

        public string parroquia
        {
            get => _parroquia;
            set
            {
                _parroquia = value;
                OnPropertyChanged();
            }
        }

        private string _municipio;

        public string municipio
        {
            get => _municipio;
            set
            {
                _municipio = value;
                OnPropertyChanged();
            }
        }

        private string _ciudad;

        public string ciudad
        {
            get => _ciudad;
            set
            {
                _ciudad = value;
                OnPropertyChanged();
            }
        }

        private string _bautizante;

        public string bautizante
        {
            get => _bautizante;
            set
            {
                _bautizante = value;
                OnPropertyChanged();
            }
        }

        private string _estado;

        public string estado
        {
            get => _estado;
            set
            {
                _estado = value;
                OnPropertyChanged();
            }
        }

        private DateTime _fechaBautismo;

        public DateTime fechaBautismo
        {
            get => _fechaBautismo;
            set
            {
                _fechaBautismo = value;
                OnPropertyChanged();
            }
        }

        private DateTime _fechaNacimiento;

        public DateTime fechaNacimiento
        {
            get => _fechaNacimiento;
            set
            {
                _fechaNacimiento = value;
                OnPropertyChanged();
            }
        }

        private string _fBautismoAnio;

        public string fBautismoAnio
        {
            get => _fBautismoAnio;
            set
            {
                _fBautismoAnio = value;
                OnPropertyChanged();
            }
        }
        private string _fBautismoMes;

        public string fBautismoMes
        {
            get => _fBautismoMes;
            set
            {
                _fBautismoMes = value;
                OnPropertyChanged();
            }
        }

        private string _fBautismoDia;

        public string fBautismoDia
        {
            get => _fBautismoDia;
            set
            {
                _fBautismoDia = value;
                OnPropertyChanged();
            }
        }

        private string _fNacimientoAnio;

        public string fNacimientoAnio
        {
            get => _fNacimientoAnio;
            set
            {
                _fNacimientoAnio = value;
                OnPropertyChanged();
            }
        }

        private string _fNacimientoMes;

        public string fNacimientoMes
        {
            get => _fNacimientoMes;
            set
            {
                _fNacimientoMes = value;
                OnPropertyChanged();
            }
        }

        private string _fNacimientoDia;

        public string fNacimientoDia
        {
            get => _fNacimientoDia;
            set
            {
                _fNacimientoDia = value;
                OnPropertyChanged();
            }
        }

        private string bautizado;
        private string infante;
        private string hijo;

        private bautismo ConsultarBautismo(int idBautizado)
        {
            try
            {

                using (Entities db = new Entities())
                {
                    bautismo ConsultaBautismo = db.bautismos
                    .Include("ministro")
                    .Include("estado")
                    .Where(x => x.id == idBautizado).FirstOrDefault();

                    return ConsultaBautismo;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("HA OCURRIDO EL SIGUIENTE ERROR: \n" + e.Message, "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }



        public string generarBoletaBautismo(int idBautizado)
        {
            try {
                //bautismo ConsultaBautismo = ConsultarBautismo(idBautizado);

                parroquia = bd.SelectString("Select nombre from parroquia where id = 1").ToString();
                nombre = bd.SelectString("Select CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from bautismos where id = '" + idBautizado + "'").ToString();
                fechaBautismo = Convert.ToDateTime(bd.SelectString("Select fechaBautismo from bautismos where id = '" + idBautizado+ "'").ToString());
                fechaNacimiento = Convert.ToDateTime(bd.SelectString("Select fechaNacimiento from bautismos where id = '" + idBautizado + "'").ToString());
                sexo = int.Parse(bd.SelectString("Select sexo from bautismos where id = '" + idBautizado + "'"));
                nombrePadre = bd.SelectString("Select nombrePadre from bautismos where id = '" + idBautizado + "'").ToString();
                nombreMadre = bd.SelectString("Select nombreMadre from bautismos where id = '" + idBautizado + "'").ToString();
                nombrePadrino = bd.SelectString("Select nombrePadrino from bautismos where id = '" + idBautizado + "'").ToString();
                nombreMadrina = bd.SelectString("Select nombreMadrina from bautismos where id = '" + idBautizado + "'").ToString();
                municipio = bd.SelectString("Select municipio from bautismos where id = '" + idBautizado + "'").ToString();
                ciudad = bd.SelectString("Select ciudad from bautismos where id = '" + idBautizado + "'").ToString();
                bautizante = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from bautismos INNER JOIN ministros ON bautismos.idMinistro = ministros.id where bautismos.id = '" + idBautizado + "'").ToString();

                estado = bd.SelectString("Select estados.nombre from bautismos INNER JOIN estados ON bautismos.idEstado = estados.id where bautismos.id = '" + idBautizado + "'").ToString();

                fBautismoAnio = fechaBautismo.Year.ToString();
                fBautismoMes = mes(fechaBautismo.Month);
                fBautismoDia = fechaBautismo.Day.ToString();
                fNacimientoAnio = fechaNacimiento.Year.ToString();
                fNacimientoMes = mes(fechaNacimiento.Month);
                fNacimientoDia = fechaNacimiento.Day.ToString();


                if (sexo == 1)
                {
                    bautizado = "BAUTIZADO";
                    infante = "UN NIÑO";
                    hijo = "O";
                }
                else
                {
                    bautizado = "BAUTIZADA";
                    infante = "UNA NIÑA";
                    hijo = "A";
                }

                /**
                 *Se puede usar la siguiente función para que se genere un código único para la boleta.
                 *Guid.NewGuid().ToString()
                 **/
                string ruta = System.IO.Path.GetTempPath() + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "_" + "Boleta Bautismo_" + nombre + ".pdf";
                Document doc = new Document(iTextSharp.text.PageSize.HALFLETTER, 35, 35, 50, 50);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                doc.Open(); //Abre el documento para escribir.
                            //Aqui va algún contenido.
                            //Encabezado:
                PdfContentByte cb = wri.DirectContent;
                cb.RoundRectangle(30f, 30f, 335f, 550f, 30f);
                cb.Stroke();

                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 23, 1, BaseColor.BLACK);
                Paragraph prgHeading = new Paragraph("BOLETA DE BAUTISMO", fntHead);
                prgHeading.Alignment = Element.ALIGN_CENTER;
                doc.Add(prgHeading);

                BaseFont bfntSub = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntSub = new Font(bfntSub, 20, 2, BaseColor.BLACK);
                Paragraph subTitle = new Paragraph("ARQUIDIÓCESIS DE ACAPULCO", fntSub);
                subTitle.Alignment = Element.ALIGN_CENTER;
                //doc.Add(subTitle);

                /**Imagen*/
                string archivoImagen = "bautismo.png";
                string imagenPath = Path.Combine(Environment.CurrentDirectory, @"img\", archivoImagen);

                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(imagenPath);
                imagen.Alignment = Element.ALIGN_CENTER;
                imagen.ScaleAbsolute(220f, 40f);
                doc.Add(imagen);

                BaseFont bfntPar = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                /**Fuente para las letras normales*/
                Font fntPar = new Font(bfntPar, 12, 1, BaseColor.BLACK);
                /**Fuente para las letras subrayadas*/
                Font fntVar = new Font(bfntPar, 12, 1, BaseColor.BLACK);
                /*Las variables irán subrayadas**/
                fntVar.SetStyle(Font.UNDERLINE);

                Chunk c1 = new Chunk("\nEL DÍA ", fntPar);
                Chunk c2 = new Chunk(fBautismoDia, fntVar);
                Chunk c3 = new Chunk(" DE ", fntPar);
                Chunk c4 = new Chunk(fBautismoMes.ToUpper(), fntVar);
                Chunk c5 = new Chunk(" DEL AÑO ", fntPar);
                Chunk c6 = new Chunk(fBautismoAnio, fntVar);
                Chunk c7 = new Chunk("\n" + "\n", fntPar);
                Chunk c8 = new Chunk("FUE ", fntPar);
                Chunk c9 = new Chunk(bautizado, fntVar);
                Chunk c10 = new Chunk(" EN ESTA PARROQUIA DE ", fntPar);
                Chunk c11 = new Chunk(parroquia, fntVar);
                Chunk c12 = new Chunk("\n" + "\n", fntPar);
                Chunk c13 = new Chunk(infante, fntVar);
                Chunk c14 = new Chunk(" A QUIEN SE PUSO POR NOMBRE \n", fntPar);
                Chunk c15 = new Chunk(nombre, fntVar);
                Chunk c16 = new Chunk("\n" + "\n", fntPar);
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

                Chunk c17 = new Chunk("NACIÓ EN ", fntPar);
                Chunk c18 = new Chunk(ciudad, fntVar);
                Chunk c19 = new Chunk(", ", fntPar);
                Chunk c20 = new Chunk(municipio, fntVar);
                Chunk c21 = new Chunk(", ", fntPar);
                Chunk c22 = new Chunk(estado, fntVar);
                Chunk c23 = new Chunk("\n" + "\n", fntPar);
                Chunk c24 = new Chunk("EL DÍA ", fntPar);
                Chunk c25 = new Chunk(fNacimientoDia, fntVar);
                Chunk c26 = new Chunk(" DE ", fntPar);
                Chunk c27 = new Chunk(fNacimientoMes.ToUpper(), fntVar);
                Chunk c28 = new Chunk(" DEL AÑO ", fntPar);
                Chunk c29 = new Chunk(fNacimientoAnio, fntVar);
                Chunk c30 = new Chunk("\n" + "\n", fntPar);
                Chunk c31 = new Chunk("HIJ", fntPar);
                Chunk c32 = new Chunk(hijo, fntVar);
                Chunk c33 = new Chunk(" DEL SR: ", fntPar);
                Chunk c34 = new Chunk(nombrePadre, fntVar);
                Chunk c35 = new Chunk("\n", fntPar);
                Chunk c36 = new Chunk("Y DE LA SRA: ", fntPar);
                Chunk c37 = new Chunk(nombreMadre, fntVar);
                Chunk c38 = new Chunk("\n" + "\n", fntPar);
                Chunk c39 = new Chunk("PADRINO ", fntPar);
                Chunk c40 = new Chunk(nombrePadrino, fntVar);
                Chunk c41 = new Chunk("\n", fntPar);
                Chunk c42 = new Chunk("MADRINA ", fntPar);
                Chunk c43 = new Chunk(nombreMadrina, fntVar);
                Chunk c44 = new Chunk("\n" + "\n" + "\n", fntPar);
                Phrase p2 = new Phrase();
                p2.Add(c17); p2.Add(c18); p2.Add(c19); p2.Add(c20); p2.Add(c21); p2.Add(c22); p2.Add(c23);
                p2.Add(c24); p2.Add(c25); p2.Add(c26); p2.Add(c27);
                p2.Add(c28);
                p2.Add(c29);
                p2.Add(c30);
                p2.Add(c31);
                p2.Add(c32);
                p2.Add(c33);
                p2.Add(c34);
                p2.Add(c35);
                p2.Add(c36);
                p2.Add(c37);
                p2.Add(c38);
                p2.Add(c39);
                p2.Add(c40);
                p2.Add(c41);
                p2.Add(c42);
                p2.Add(c43);
                p2.Add(c44);

                Phrase p45 = new Phrase("___________________________" + "\n" + "                  BAUTIZANTE                 " + "\n" + "\n", fntPar);

                PdfPTable table = new PdfPTable(1);
                PdfPCell cell = new PdfPCell();
                cell.Border = 0;
                cell.Colspan = 1;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                table.DefaultCell.Border = Rectangle.NO_BORDER;
                table.AddCell(cell);
                table.AddCell(p45);

                Paragraph paragraph = new Paragraph();
                paragraph.Add(p1);
                paragraph.Add(p2);

                //Ahora añade el texto creado arriba, usando un objeto de la clase para nuestro documento pdf.
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                table.HorizontalAlignment = Element.ALIGN_RIGHT;

                doc.Add(paragraph);
                doc.Add(table);


                MessageBox.Show("Boleta Generada con éxito", "Generación de Boleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doc.Close();

                /**
                 Se obtiene la ruta del pdf y se abre dentro de la ventana modal, con ello ya puede mandarse a imprimir o guardar donde se desee.
                 */
                Process prc = new System.Diagnostics.Process();

                BautismosModal modal = new BautismosModal(ruta);
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
            DateTimeFormatInfo dtinfo = new CultureInfo("es-MX", true).DateTimeFormat;
            return dtinfo.GetMonthName(numerico);
        }

    }
}
