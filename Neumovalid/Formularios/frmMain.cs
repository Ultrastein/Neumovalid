using Neumavalid;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading; 
namespace NeumoValid
{
    public partial class Validador : Form
    {
        System.IO.Ports.SerialPort puerto_serie;
     
        public Validador()
        {
            InitializeComponent();

            



            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            string[] ports = SerialPort.GetPortNames(); 
            foreach (string port in ports) {
            cmbComPort.Items.Add(port); }
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (puerto_serie != null && puerto_serie.IsOpen)
            {
                timer1.Stop();
                puerto_serie.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          if (puerto_serie == null){
                string puerto = cmbComPort.GetItemText(this.cmbComPort.SelectedItem);
                puerto_serie = new SerialPort(puerto, 115200); // colocar COM y baudrate corresp.
                puerto_serie.ReadTimeout = 20;
                puerto_serie.Handshake = Handshake.None;
                puerto_serie.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                puerto_serie.WriteTimeout = 500;
                puerto_serie.Open();

            }
        }


        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data)
        {
            data = data.Replace("\r", "");
            data = data.Replace("\n", "");

            string newValue = data.Substring(data.LastIndexOf(">") + 1);
            //  txtRecived.AppendText(data.Trim() + System.Environment.NewLine);
            txtMensajeSerial.Text = newValue;

            if (data.Substring(0, 2) == "S2")
            {

                chartVolumen.Value = Convert.ToInt32(newValue);
                chartVolumen.Text = newValue;
                

            }
        }
        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            //  Thread.Sleep(500);
            string data = puerto_serie.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
            // ---- The "si_DataReceived" method will be executed on the UI thread, which allows populating the textbox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }


        private void timer1_Tick(object sender, EventArgs e)// seleccion de puerto de comunicaccion
        {
            //try
            //{
            //    string text = puerto_serie.ReadTo("|H");
            //    if (!text.StartsWith("H"))
            //        text = "H" + text;
            //    txtMensajeSerial.Text = text;

            //    if (text.StartsWith("Humo"))
            //    {
            //        string[] valores = text.Split('|');
            //        float altura = float.Parse(valores[0].Substring(5))/100;

            //        //circularProgressBar7.Text = altura.ToString();
            //        //circularProgressBar7.Value = (int) altura;
                    
            //        altura = float.Parse(valores[1].Substring(8));

            //        //circularProgressBar3.Text = altura.ToString();
            //        //circularProgressBar3.Value = (int)altura;

            //        altura = float.Parse(valores[2].Substring(6))/100;

            //        //Temp.Text = altura.ToString();
            //        //Temp.Value = (int)altura;
            //        //chart2.Series[0].Points.AddXY(0, altura);

            //        altura = float.Parse(valores[3].Substring(5))/100;

            //        //circularProgressBar2.Text = altura.ToString();
            //        //circularProgressBar2.Value = (int)altura;
            //        chartLitros.Series[0].Points.AddXY(0, altura);

            //        altura = float.Parse(valores[4].Substring(9)) / 100;

            //        //circularProgressBar1.Text = altura.ToString();
            //        //circularProgressBar1.Value = (int)altura;
            //        //chart3.Series[0].Points.AddXY(0, altura);

            //        if (valores.Length > 5)
            //        {
            //            altura = float.Parse(valores[4].Substring(9)) / 100;
            //          //  if (altura > 0)
            //            //    Prescion.Series[0].Points.AddXY(0,altura);
            //        }
            //        /*
            //        float humo = float.Parse(valores[1].substr(6));
            //        float luzUV = float.Parse(valores[2].substr(8));
            //        float temp = float.Parse(valores[3].substr(6));
            //        float luz = float.Parse(valores[4].substr(5));
            //        float presion = float.Parse(valores[5].substr(9));
            //        */
                
            //    }
            //}
            //catch (TimeoutException) { }
        }

        private void circularProgressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Temp_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtHmedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmulador_Click(object sender, EventArgs e)
        {
            frmEmulador f = new frmEmulador();
            f.Show();
        }

        private void Validador_Load(object sender, EventArgs e)
        {

        }

        private void Validador_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {

        }
    }
}