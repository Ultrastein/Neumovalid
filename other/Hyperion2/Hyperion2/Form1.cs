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

namespace Hyperion2
{
    public partial class Hyperion : Form
    {
        System.IO.Ports.SerialPort puerto_serie;
        public Hyperion()
        {
            InitializeComponent();
            
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            string[] ports = SerialPort.GetPortNames(); 
            foreach (string port in ports) {
            comboBox1.Items.Add(port); }
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (puerto_serie != null && puerto_serie.IsOpen)
            {
                timer1.Stop();
                puerto_serie.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (puerto_serie == null){
                string puerto = comboBox1.GetItemText(this.comboBox1.SelectedItem);
                puerto_serie = new SerialPort(puerto, 115200); // colocar COM y baudrate corresp.
                                                              puerto_serie.ReadTimeout = 20;
                                                              puerto_serie.Open();
                                                              timer1.Start();            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while(serialPort1.IsOpen && serialPort1.BytesToRead  > 0)
            {
                string serialData = serialPort1.ReadLine();
                int value = Convert.ToInt32(serialData);

                circularProgressBar1.Text = serialData;
                circularProgressBar1.Value = value;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string text = puerto_serie.ReadTo("|H");
                if (!text.StartsWith("H"))
                    text = "H" + text;
                textBox1.Text = text;

                if (text.StartsWith("Humo"))
                {
                    string[] valores = text.Split('|');
                    float altura = float.Parse(valores[0].Substring(5))/100;

                    circularProgressBar7.Text = altura.ToString();
                    circularProgressBar7.Value = (int) altura;
                    
                    altura = float.Parse(valores[1].Substring(8));

                    circularProgressBar3.Text = altura.ToString();
                    circularProgressBar3.Value = (int)altura;

                    altura = float.Parse(valores[2].Substring(6))/100;

                    Temp.Text = altura.ToString();
                    Temp.Value = (int)altura;
                    chart2.Series[0].Points.AddXY(0, altura);

                    altura = float.Parse(valores[3].Substring(5))/100;

                    circularProgressBar2.Text = altura.ToString();
                    circularProgressBar2.Value = (int)altura;
                    chart4.Series[0].Points.AddXY(0, altura);

                    altura = float.Parse(valores[4].Substring(9)) / 100;

                    circularProgressBar1.Text = altura.ToString();
                    circularProgressBar1.Value = (int)altura;
                    chart3.Series[0].Points.AddXY(0, altura);

                    if (valores.Length > 5)
                    {
                        altura = float.Parse(valores[4].Substring(9)) / 100;
                        if (altura > 0)
                            chart1.Series[0].Points.AddXY(0,altura);
                    }
                    /*
                    float humo = float.Parse(valores[1].substr(6));
                    float luzUV = float.Parse(valores[2].substr(8));
                    float temp = float.Parse(valores[3].substr(6));
                    float luz = float.Parse(valores[4].substr(5));
                    float presion = float.Parse(valores[5].substr(9));
                    */
                
                }
            }
            catch (TimeoutException) { }
        }

        private void circularProgressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}