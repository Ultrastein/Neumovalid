using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using Neumavalid.Clases;

namespace Neumavalid
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
            IniciarCarga();
        }
        private void IniciarCarga()
        {
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
                numVolumen.Value = Common.getNumericValue(data["Sensor"]["Volumen"]);
                numHumedad.Value = Common.getNumericValue(data["Sensor"]["Humedad"]);
                numPresion.Value = Common.getNumericValue(data["Sensor"]["Presion"]);
                numTemperatura.Value = Common.getNumericValue(data["Sensor"]["Temperatura"]);
                chkEliminar_r.Checked = Convert.ToBoolean(Common.getNumericValue(data["rxtx"]["eliminar_r"]));
                chkEnviar_r.Checked = Convert.ToBoolean(Common.getNumericValue(data["rxtx"]["enviar_r"]));
                chkEliminar_n.Checked = Convert.ToBoolean(Common.getNumericValue(data["rxtx"]["eliminar_n"]));
                chkEnviar_n.Checked = Convert.ToBoolean(Common.getNumericValue(data["rxtx"]["enviar_n"]));
                txtComandoIniciar.Text = data["comandos"]["iniciar"].ToUpper();
                txtComandoDetener.Text = data["comandos"]["detener"].ToUpper();
                cmbComPort.SelectedIndex = cmbComPort.FindStringExact(data["COM"]["Default"]);
                lstMarcas.Text = data["jeringa"]["marca"].ToUpper();
                lstModelos.Text = data["jeringa"]["modelo"].ToUpper();
                lstNºdeserie.Text = data["jeringa"]["nserie"].ToUpper();
                lstReferentes.Text = data["referente"]["personas"].ToUpper();
                
                lstpropi.Text = data["jeringa"]["propietario"].ToUpper();
                
            }
            catch (Exception ex)
            {


            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            IniData data = new IniData();


            data["Sensor"]["Volumen"] = numVolumen.Value.ToString();
            data["Sensor"]["Humedad"] = numHumedad.Value.ToString();
            data["Sensor"]["Presion"] = numPresion.Value.ToString();
            data["Sensor"]["Temperatura"] = numTemperatura.Value.ToString();
            data["rxtx"]["eliminar_r"] = Convert.ToInt16(chkEliminar_r.Checked).ToString();
            data["rxtx"]["enviar_r"] =Convert.ToInt16( chkEnviar_r.Checked).ToString();
            data["rxtx"]["eliminar_n"] = Convert.ToInt16(chkEliminar_n.Checked).ToString();
            data["rxtx"]["enviar_n"] = Convert.ToInt16(chkEnviar_n.Checked).ToString();
            data["comandos"]["iniciar"] = txtComandoIniciar.Text.ToUpper();
            data["comandos"]["detener"] = txtComandoDetener.Text.ToUpper();
            data["COM"]["Default"] = cmbComPort.SelectedItem.ToString();
            data["jeringa"]["marca"] = lstMarcas.Text.ToUpper();
            data["jeringa"]["modelo"] = lstModelos.Text.ToUpper();
            data["jeringa"]["nserie"] = lstNºdeserie.Text.ToUpper();
            data["referente"]["personas"] = lstReferentes.Text.ToUpper();
            data["jeringa"]["propietario"] = lstpropi.Text.ToUpper();

            var parser = new FileIniDataParser();
            parser.WriteFile("settings.ini", data);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstReferentes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
