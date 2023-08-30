﻿using FontAwesome.Sharp;
using IniParser.Model;
using IniParser;
using Neumavalid.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Neumavalid.Clases.Common;
using System.IO.Ports;
using System.IO;
using System.Windows.Markup;
using System.Globalization;

namespace Neumavalid
{
    public partial class frmMedidores : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        System.IO.Ports.SerialPort puerto_serie;
        private string SensorHumedad;
        private string SensorPresion;
        private string SensorTemperatura;
        private string SensorVolumen;

        private string cmdStart;
        private string cmdStop;
        private Boolean chkEliminar_r = true;
        private Boolean chkEliminar_n = true;
        private Boolean chkEnviar_r = true;
        private Boolean chkEnviar_n = true;
        private List<Tuple<int, string>> ListaMediciones =  new List<Tuple<int, string>>() ;
        public frmMedidores()
        {
            InitializeComponent();
            InicializarValores();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlDerecho.Controls.Add(leftBorderBtn);
            ActivateButton(btnDetener, RGBColors.color3);
        }
        private void InicializarValores()
        {
            lblFecha.Text=DateTime.Now.ToShortDateString();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbComPort.Items.Add(port);
            }
            if (cmbComPort.Items.Count > 0)
            {
                cmbComPort.SelectedIndex = 1;
            }
            Common.checkIniFileExistAndFill();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("settings.ini");
            try
            {
                SensorVolumen = "S" + data["Sensor"]["Volumen"];
                SensorHumedad = "S" +(data["Sensor"]["Humedad"]);
                SensorPresion = "S" + (data["Sensor"]["Presion"]);
                SensorTemperatura = "S" + (data["Sensor"]["Temperatura"]);
                chkEliminar_r  = Convert.ToBoolean(getNumericValue(data["rxtx"]["eliminar_r"]));
                chkEliminar_n= Convert.ToBoolean(getNumericValue(data["rxtx"]["eliminar_n"]));
                chkEnviar_r = Convert.ToBoolean(getNumericValue(data["rxtx"]["enviar_r"]));
                chkEnviar_n = Convert.ToBoolean(getNumericValue(data["rxtx"]["enviar_n"]));
                cmdStart = data["comandos"]["iniciar"].ToUpper();
                cmdStop = data["comandos"]["detener"].ToUpper();

                string Marcas = data["jeringa"]["marca"].ToUpper();
                string Modelos  = data["jeringa"]["modelo"].ToUpper();
                string Operador = data["referente"]["personas"].ToUpper();
                string Propietario = data["jeringa"]["propietario"].ToUpper();
                string Ndeserie = data["jeringa"]["nserie"].ToUpper();
                cmbComPort.SelectedIndex = cmbComPort.FindStringExact(data["COM"]["Default"]);

                List<string> list = new List<string>();
                list = Marcas.Split(';').ToList();
                cmbmarca.Items.Clear();
                cmbmarca.Items.AddRange( list.ToArray());
                if(cmbmarca.Items.Count>0) cmbmarca.SelectedIndex = 0;

                list = new List<string>();
                list = Modelos.Split(';').ToList();
                cmbmodelo.Items.Clear();
                cmbmodelo.Items.AddRange(list.ToArray());
                if (cmbmodelo.Items.Count > 0) cmbmodelo.SelectedIndex = 0;

                list = new List<string>();
                list = Operador.Split(';').ToList();
                cmboperador.Items.Clear();
                cmboperador.Items.AddRange(list.ToArray());
                if (cmboperador.Items.Count > 0) cmboperador.SelectedIndex = 0;

                //cosas nuevas//
                list = new List<string>();
                list = Propietario.Split(';').ToList();
                cmbpropieterio.Items.Clear();
                cmbpropieterio.Items.AddRange(list.ToArray());
                if (cmbpropieterio.Items.Count > 0) cmbpropieterio.SelectedIndex = 0;

                list = new List<string>();
                list = Ndeserie.Split(';').ToList();
                cmbNdeserie.Items.Clear();
                cmbNdeserie.Items.AddRange(list.ToArray());
                if (cmbNdeserie.Items.Count > 0) cmbNdeserie.SelectedIndex = 0;

            }
            catch (Exception ex)
            {


            }

        }
        private void btnMediciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorGreen);

            if (puerto_serie == null)
            {
                string puerto = cmbComPort.GetItemText(this.cmbComPort.SelectedItem);
                puerto_serie = new SerialPort(puerto, 115200); // colocar COM y baudrate corresp.
                puerto_serie.ReadTimeout = 20;
                puerto_serie.Handshake = Handshake.None;
                puerto_serie.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                puerto_serie.WriteTimeout = 500;
                puerto_serie.Open();

            }

        }
        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            //  Thread.Sleep(500);
            string data = puerto_serie.ReadLine();
 
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data)
        {
            if (chkEliminar_r)   data = data.Replace("\r", "");
            if (chkEliminar_n) data = data.Replace("\n", "");

            string newValue = data.Substring(data.LastIndexOf(">") + 1);

            string sensor = data.Substring(0, 2);
             
            if (sensor == SensorHumedad)
            {
                gaugeHumedad.Value = Convert.ToInt32(newValue);
            }
            else if (sensor == SensorPresion)
            {

                gaugePresion.Value = Convert.ToInt32(newValue);
            }
            else if(sensor == SensorTemperatura)
            {

                gaugeTemperatura.Value = Convert.ToInt32(newValue);
            }
            else if (sensor == SensorVolumen)
            {
                chartLitros.Series[chartLitros.Series.Count - 1].Points.AddXY(DateTime.Now.ToLongTimeString(), Convert.ToInt32(newValue));
                ListaMediciones.Add(new Tuple<int, string>(Convert.ToInt32(newValue), DateTime.Now.ToLongDateString() + "::" + DateTime.Now.ToLongTimeString()));

            }


        }

      

        private void btnDetener_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (puerto_serie != null && puerto_serie.IsOpen)
            {
                puerto_serie.Close();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);


            string contents = "";
            contents += "Fecha::" + DateTime.Now.ToShortDateString()+ "\n";//imprime solo la fecha
            contents += "Nº de ensayo::" + numensayo.Value.ToString() + "\n";
            contents += "Operador::" + cmboperador.SelectedItem.ToString() + "\n";
            contents += "propietario::" + cmbpropieterio.SelectedItem.ToString() + "\n";
            contents += "Marca Jeringa::" + cmbmarca.SelectedItem.ToString() + "\n";
            contents += "Modelo Jeringa::" + cmbmodelo.SelectedItem.ToString() + "\n";
            contents += "Nº de serie::" + cmbNdeserie.SelectedItem.ToString() + "\n";
            contents += "Puerto::" + cmbComPort.SelectedItem.ToString() + "\n";
            contents += "Humedad::" + gaugeHumedad.Value.ToString() + "\n";
            contents += "Presion::" + gaugePresion.Value.ToString() + "\n";
            contents += "Temperatura::" + gaugeTemperatura.Value.ToString() + "\n";

            if (ListaMediciones.Count > 0) {
                contents += "Volumen::" + ListaMediciones[ListaMediciones.Count - 1].Item1.ToString() + "\n";
                
            }
            else {
                contents += "Volumen::Sin Datos\n";

            }

            //contents += "Mediciones de Volumen\n";

            //if (ListaMediciones.Count>0)
            //{
            //    foreach(var item in ListaMediciones)
            //    {

            //        contents +=item.Item2.ToString() + ">" + item.Item1.ToString() + "\n";

            //    }

            //}

            contents += "\n";
            contents += "\n";


            byte[] bytes = Encoding.UTF8.GetBytes(contents);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "word files (*.docx)|*.docx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Write(bytes, 0, bytes.Length);

                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }


        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                 
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnEmulador_Click(object sender, EventArgs e)
        {


        }

        private void pnlDerecho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMedidores_Load(object sender, EventArgs e)
        {

        }

         void frmMedidores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (puerto_serie != null && puerto_serie.IsOpen)
            {
                 puerto_serie.Close();
            }
        }

        private void btnStartEmulador_Click(object sender, EventArgs e)
        {
            frmEmulador frmPOC = new frmEmulador();
            frmPOC.ShowDialog();

        }

        private void gaugeTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void btnStartManual_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (puerto_serie == null)
            {
                string puerto = cmbComPort.GetItemText(this.cmbComPort.SelectedItem);
                puerto_serie = new SerialPort(puerto, 115200); // colocar COM y baudrate corresp.
                puerto_serie.ReadTimeout = 20;
                puerto_serie.Handshake = Handshake.None;
                puerto_serie.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                puerto_serie.WriteTimeout = 500;
             
            }

            if(puerto_serie != null && puerto_serie.IsOpen)
            {
                puerto_serie.Close();
            }
            if (puerto_serie != null )
            {
                puerto_serie.Open();
                puerto_serie.Write(cmdStart + "\r\n");
                puerto_serie.Close();
            }

        }

        private void btnEndManual_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (puerto_serie == null)
            {
                string puerto = cmbComPort.GetItemText(this.cmbComPort.SelectedItem);
                puerto_serie = new SerialPort(puerto, 115200); // colocar COM y baudrate corresp.
                puerto_serie.ReadTimeout = 20;
                puerto_serie.Handshake = Handshake.None;
                puerto_serie.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                puerto_serie.WriteTimeout = 500;

            }

            if (puerto_serie != null && puerto_serie.IsOpen)
            {
                puerto_serie.Close();
            }
            if (puerto_serie != null)
            {
                puerto_serie.Open();
                puerto_serie.Write(cmdStop + "\r\n");
                puerto_serie.Close();
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartLitros_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
