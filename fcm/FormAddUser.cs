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
    public partial class FormAddUser : Form
    {

        CGuiApplicationIntermediate cgai;

        public FormAddUser()
        {
            InitializeComponent();
            cgai = CGuiApplicationIntermediate.InstanceCreation();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cgai.addNewUer(textBoxUserName.Text,textBoxPassword.Text);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.textBoxUserName.Text = "";
            this.textBoxPassword.Text = "";
            this.checkedListBox_users.ClearSelected();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            
          //  checkedListBox_users.Items.AddRange(cgai.getUsers().ToArray());
              

        }

        private void checkedListBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
