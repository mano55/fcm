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
    public partial class FormAdmin : Form
    {
        CGuiApplicationIntermediate cgai;

        public FormAdmin()
        {
            InitializeComponent();
            cgai = CGuiApplicationIntermediate.InstanceCreation();
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

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            cgai.openAddUserDialog();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cgai.showHomePage();
        }

        private void button_AddCTeam_Click(object sender, EventArgs e)
        {
            cgai.openAddTeamDialog();
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            cgai.openPlayerDetailesDialog();
        }
    }
}
