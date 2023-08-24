using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using FontAwesome.Sharp;
using IniParser.Model;
using IniParser;
using Color = System.Drawing.Color;
using Neumavalid.Clases;
using static Neumavalid.Clases.Common;

namespace Neumavalid
{
    public partial class frmMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

 

        public frmMainMenu()
        {
           InitializeComponent();
            IniciarConfiguracion();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }
        //estructurea
       
        //metodos
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
                //Current Child Form Icon
                 iconCurrentChildForm.IconChar = currentBtn.IconChar;
                 iconCurrentChildForm.IconColor = color;
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
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        
     

      
           
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
      
        
        
     
       
   

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmConfiguracion());
        }

        private void btnMediciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmMedidores());
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmAcerca());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void IniciarConfiguracion()
        {


            Common.checkIniFileExistAndFill();




        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
