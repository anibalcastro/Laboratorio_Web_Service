using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Objetos;



namespace Presentacion
{
    public partial class Clima : Form
    {
        cr.ac.imn.www.WSMeteorologicoService ws = new cr.ac.imn.www.WSMeteorologicoService();
    
        public Clima()
        {
            InitializeComponent();
            cargarRegiones();
            
        }

        public void cargarRegiones()
        {
            
            string reg = ws.pronosticoRegional(new cr.ac.imn.www.pronosticoRegion());

            
            List<regiones> lista = leerZonas(reg);
            cbZona.ValueMember = "idRegion";
            cbZona.DisplayMember = "nombre";


            cbZona.DataSource = lista;

            string nombre = this.retornarNombreRegion(1);
            this.cargarImagenesRegion(reg, nombre);
        }

        private List<regiones> leerZonas(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList lista = doc.GetElementsByTagName("REGION");
            List<regiones> listaRegiones = new List<regiones>();
            for (int c = 0; c < lista.Count; c++)
            {
                regiones objetoRegion = new Objetos.regiones()
                {
                    idRegion = Convert.ToInt32(lista[c].Attributes[0].InnerText),
                    nombre = lista[c].Attributes[1].InnerText,

                };
                listaRegiones.Add(objetoRegion);
            }
               
            return listaRegiones;
        }

        private List<ciudades> leerCiudades(string xml, int region)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            
            XmlNodeList listaCiudad = doc.GetElementsByTagName("CIUDAD");
            
            List<ciudades> listaCiudades = new List<ciudades>();

                for (int c = 0; c < listaCiudad.Count; c++)
                {
                    if (Convert.ToInt32(listaCiudad[c].Attributes["idRegion"].InnerText) == region)
                    {
                        Objetos.ciudades ciudades = new ciudades()
                        {
                            nombre = (listaCiudad[c].Attributes[1].InnerText),
                            idCiudad = Convert.ToInt32((listaCiudad[c].Attributes[2].InnerText))
                        };
                        listaCiudades.Add(ciudades);
                    }

                }
                   
            return listaCiudades;
        }

        private void InfoRegion(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList listaMañana = doc.GetElementsByTagName("COMENTARIOMANANA");
            XmlNodeList listaTarde = doc.GetElementsByTagName("COMENTARIOTARDE");
            XmlNodeList listaNoche = doc.GetElementsByTagName("COMENTARIONOCHE");

            string comentarioTarde;
            string comentarioNoche;
            string comentarioMañana = "";

            if (listaMañana.Count == 0)
            {
                 comentarioTarde = listaTarde[0].InnerText;
                 comentarioNoche = listaNoche[0].InnerText;
                this.imgMañana1.Visible = false;
                this.imgMañana2.Visible = false;
                this.lblDia1.Visible = false;
                this.lblDia2.Visible = false;
                this.txtDescripcionMañana.Visible = false;
                this.txtComentarioMañana1.Visible = false;
            } 
            else
            {
                this.imgMañana1.Visible = true;
                this.imgMañana2.Visible = true;
                this.lblDia1.Visible = true;
                this.lblDia2.Visible = true;
                this.txtDescripcionMañana.Visible = true;
                this.txtComentarioMañana1.Visible = true;
                comentarioMañana = listaMañana[0].InnerText;
                 comentarioTarde = listaTarde[0].InnerText;
                 comentarioNoche = listaNoche[0].InnerText;
            }

            this.txtDescripcionMañana.Text = comentarioMañana;
            this.txtComentarioTarde.Text = comentarioTarde;
            this.txtComentarioNoche.Text = comentarioNoche;
   
        }

        private void cargarImagenesRegion(string xml, string nombreRegion)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList listaregion = doc.GetElementsByTagName("REGION");
            XmlNodeList estadoTarde = doc.GetElementsByTagName("ESTADOTARDE");
            XmlNodeList estadoMañana = doc.GetElementsByTagName("ESTADOMANANA");
            XmlNodeList estadoNoche = doc.GetElementsByTagName("ESTADONOCHE");


            for (int i = 0; i < listaregion.Count; i++)
            {
                if (listaregion[i].Attributes[1].InnerText == nombreRegion)
                {
                    if (estadoMañana.Count == 0)
                    {
                        imgTarde1.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoTarde[i].Attributes[0].InnerText);
                        imgNoche1.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoNoche[i].Attributes[0].InnerText);
                        break;
                    }
                    else
                    {
                        imgTarde1.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoTarde[i].Attributes[0].InnerText);
                        imgMañana1.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoMañana[i].Attributes[0].InnerText);
                        imgNoche1.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoNoche[i].Attributes[0].InnerText);
                        break;
                    }
                    
                }
            }


        }

        private void cargarCiudades(int idRegion)
        {
            string ciudades = ws.pronosticoPorCiudad(new cr.ac.imn.www.pronosticoCiudad());

            this.cbCiudad.Items.Clear();

            List<ciudades> lista = leerCiudades(ciudades, idRegion);
            
            for (int x = 0; x < lista.Count; x++)
            {
                cbCiudad.Items.Add(lista[x].nombre);
            }

        }
        
        public string retornarNombreRegion(int id)
        {
            List<string> regiones = new List<string>
            {   
                "Valle Central",
                "Pacifico Norte",
                "Pacifico Central",
                "Pacifico Sur",
                "Caribe Norte",
                "Caribe Sur",
                "Zona Norte"
            };

            string nombre = "";

            for (int i = 0; i < regiones.Count; i++)
            {
                int indice = i + 1;

                if (indice == id)
                {
                    nombre = regiones[i];
                    break;
                }
            }

            return nombre;
        }
        
        private void cbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int region_Solicitada = Convert.ToInt32(cbZona.SelectedValue.ToString());
            string nombre = this.retornarNombreRegion(region_Solicitada);
            
            this.cargarCiudades(region_Solicitada);

            string informacion = ws.pronosticoRegionalxID(region_Solicitada);
            this.InfoRegion(informacion);

            string reg = ws.pronosticoRegional(new cr.ac.imn.www.pronosticoRegion());
            this.cargarImagenesRegion(reg, nombre);


        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ciudad = cbCiudad.SelectedItem.ToString();

            string xmlCiudad = ws.pronosticoPorCiudad(new cr.ac.imn.www.pronosticoCiudad());
            this.Infociudad(xmlCiudad, ciudad);
        }

        private void Infociudad(string xml, string ciudad)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList listaCiudad = doc.GetElementsByTagName("CIUDAD");
            XmlNodeList listaMañana = doc.GetElementsByTagName("COMENTARIOMANANA");
            XmlNodeList listaTarde = doc.GetElementsByTagName("COMENTARIOTARDE");
            XmlNodeList listaNoche = doc.GetElementsByTagName("COMENTARIONOCHE");
            XmlNodeList listaTempMax = doc.GetElementsByTagName("TEMPMAX");
            XmlNodeList listaTempoMin = doc.GetElementsByTagName("TEMPMIN");
            XmlNodeList estadoTarde = doc.GetElementsByTagName("ESTADOTARDE");
            XmlNodeList estadoMañana = doc.GetElementsByTagName("ESTADOMANANA");
            XmlNodeList estadoNoche = doc.GetElementsByTagName("ESTADONOCHE");



            string comentarioTarde= "";
            string comentarioNoche = "";
            string comentarioMañana = "";
            string temperuturaMax = "";
            string temperaturaMin = "";

            for (int x = 0; x < listaCiudad.Count; x++)
            {
                if (listaCiudad[x].Attributes[1].InnerText == ciudad)
                {
                    if (listaMañana.Count == 0)
                    {
                        comentarioTarde = listaTarde[x].InnerText;
                        comentarioNoche = listaNoche[x].InnerText;
                        temperuturaMax = listaTempMax[x].InnerText;
                        temperaturaMin = listaTempoMin[x].InnerText;
                        imgTarde2.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoTarde[x].Attributes[0].InnerText);
                        imgNoche2.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoNoche[x].Attributes[0].InnerText);
                        this.imgMañana1.Visible = false;
                        this.imgMañana2.Visible = false;
                        this.lblDia1.Visible = false;
                        this.lblDia2.Visible = false;
                        this.txtDescripcionMañana.Visible = false;
                        this.txtComentarioMañana1.Visible = false;
                        break;
                    }
                    else
                    {
                        this.imgMañana1.Visible = true;
                        this.imgMañana2.Visible = true;
                        this.lblDia1.Visible = true;
                        this.lblDia2.Visible = true;
                        this.txtDescripcionMañana.Visible = true;
                        this.txtComentarioMañana1.Visible = true;
                        comentarioMañana = listaMañana[x].InnerText;
                        comentarioTarde = listaTarde[x].InnerText;
                        comentarioNoche = listaNoche[x].InnerText;
                        temperuturaMax = listaTempMax[x].InnerText;
                        temperaturaMin = listaTempoMin[x].InnerText;
                        imgTarde2.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoTarde[x].Attributes[0].InnerText);
                        imgMañana2.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoMañana[x].Attributes[0].InnerText);
                        imgNoche2.ImageLocation = string.Format("https://www.imn.ac.cr{0}", estadoNoche[x].Attributes[0].InnerText);
                        break;
                    }
                }
            }

           

            this.txtComentarioMañana1.Text = comentarioMañana;
            this.txtComentarioTarde1.Text = comentarioTarde;
            this.txtComentarioNoche1.Text = comentarioNoche;
            this.lblMinima.Text = temperaturaMin;
            this.lblMaxima.Text = temperuturaMax;


            
        }

        private void cbSol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSol.Checked == false)
            {
                this.gbSol.Visible = false;
            }
            else
            {
                this.gbSol.Visible = true;
                string servico = ws.efemerides(new cr.ac.imn.www.efemerides());
                this.leerEfemerideSol(servico);
            }
        }

        private void leerEfemerideSol(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList listaSol = doc.GetElementsByTagName("SALE");
            XmlNodeList listaSePone = doc.GetElementsByTagName("SEPONE");

            

            string sale = (listaSol[0].InnerText);
            string pone = listaSePone[0].InnerText;

            this.lblSaleSol.Text = sale;
            this.lblSePoneSol.Text = pone;
           
        }

        private void leerEfemerideLuna(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList listaSol = doc.GetElementsByTagName("SALE");
            XmlNodeList listaSePone = doc.GetElementsByTagName("SEPONE");



            string sale = (listaSol[1].InnerText);
            string pone = listaSePone[1].InnerText;

            this.lblSaleLuna.Text = sale;
            this.lblSePoneLuna.Text = pone;

        }

        private void leerFaseLunar(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList listaSol = doc.GetElementsByTagName("FASELUNAR");
            



            string fase = (listaSol[0].InnerText);
          

            this.lblFaseLunar.Text = fase;
        

        }

        private void cbEfemeridadLuna_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEfemeridadLuna.Checked == false)
            {
                this.gbEfemerideLunar.Visible = false;
            }
            else
            {
                this.gbEfemerideLunar.Visible = true;
                string servico = ws.efemerides(new cr.ac.imn.www.efemerides());
                this.leerEfemerideLuna(servico);
            }
        }

        private void cbFaseLunar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFaseLunar.Checked == false)
            {
                this.gbFaseLunar.Visible = false;
            }
            else
            {
                this.gbFaseLunar.Visible = true;
                string servico = ws.efemerides(new cr.ac.imn.www.efemerides());
                this.leerFaseLunar(servico);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
