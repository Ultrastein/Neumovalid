using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Neumavalid
{
    public partial class frmPOC : Form
    {
        SerialPort _serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
       
        public frmPOC()
        {
            InitializeComponent();
        }

        private void frmPOC_Load(object sender, EventArgs e)
        {
          
            btnCOM1.BackColor = Color.Red;
            GetAllPorts();
         
        }
         void frmPOC_Closed(object sender,EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();        
            }
        }
        public List<String> GetAllPorts()
        {
            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
              //  allPorts.Add(portName);
                lstPuertos.Items.Add(portName);
                if(portName.ToUpper()=="COM1")
                {
                    btnCOM1.BackColor = Color.Green;
                    _serialPort.Handshake = Handshake.None;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    _serialPort.WriteTimeout = 500;
                    _serialPort.Open();

                }
            }
            return allPorts;
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0,2500);

            System.IO.Ports.SerialPort puerto_serie;
            puerto_serie = new SerialPort("COM2", 9600); // colocar COM y baudrate corresp.
            puerto_serie.ReadTimeout = 20;
            puerto_serie.Open();
           // puerto_serie.Write("this is sparta");
          
            puerto_serie.Write("S1>23.4\r\n");
            puerto_serie.Write("S2>"+num.ToString()+"\r\n");
            puerto_serie.Close();
        }
        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data) {
            txtRecived.AppendText( data.Trim()+ System.Environment.NewLine);
         

        }

        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


          //  Thread.Sleep(500);
            string data = _serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
            // ---- The "si_DataReceived" method will be executed on the UI thread, which allows populating the textbox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }
    }
}
