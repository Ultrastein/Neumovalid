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
    public partial class frmClave : Form
    {
       
        public frmClave()
        {
            InitializeComponent();
        }

        private void frmPOC_Load(object sender, EventArgs e)
        {
          
         
          //  GetAllPorts();
         
        }
         void frmPOC_Closed(object sender,EventArgs e)
        {
         
        }
       

        private void txtSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMediciones_Click(object sender, EventArgs e)
        {
            try
            {

                Random rnd = new Random();
                int num = rnd.Next(0, 2500);

                System.IO.Ports.SerialPort puerto_serie;
                puerto_serie = new SerialPort("COM2", 9600); // colocar COM y baudrate corresp.
                puerto_serie.ReadTimeout = 20;
                puerto_serie.Open();

                puerto_serie.Write("S1>" + rnd.Next(0, 150).ToString() + "\r\n"); ;
                puerto_serie.Write("S2>" + rnd.Next(0, 150).ToString() + "\r\n");
                puerto_serie.Write("S3>" + rnd.Next(0, 150).ToString() + "\r\n");
                puerto_serie.Write("S4>" + rnd.Next(0, 150).ToString() + "\r\n");

                puerto_serie.Close();

            }
            catch( Exception ex)
            {

            } 
            
            }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
