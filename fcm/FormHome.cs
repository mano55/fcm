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
    public partial class FormHome : Form
    {
        CGuiApplicationIntermediate cgai;
        int displayWidth = 0;
        
        public FormHome()
        {
            InitializeComponent();
            cgai = CGuiApplicationIntermediate.InstanceCreation();
            Boolean fullscreen = false;

            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                // for determining the width of each button TBD
                displayWidth = this.Bounds.Width;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            cgai.enterAdminSection(this);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            cgai.saveTeamsDb();
            cgai.exitAppliction();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
