using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fcm
{

    public partial class FormLogIn : Form
    {
        

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            Boolean fullscreen = false;

            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            CGuiApplicationIntermediate cgai = CGuiApplicationIntermediate.InstanceCreation();
           if(cgai.logIn(textBoxUser.Text, textBoxPassword.Text))
           {
               this.Hide();
               cgai.showHomePage();
           }
        }
    }
}