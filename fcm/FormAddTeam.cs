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
    
    public partial class FormAddTeam : Form
    {
        private CGuiApplicationIntermediate cgai;
        BindingSource itemBindingTeamsList = new BindingSource();
        BindingSource itemBindingChosenTeam = new BindingSource();
        Color backColor { get; set; }
        
        public FormAddTeam()
        {
            InitializeComponent();
            cgai = CGuiApplicationIntermediate.InstanceCreation();

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            tbTeamName.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (cgai.addNemTeam(tbTeamName.Text))
            {
                MessageBox.Show("נוספה למאגר  "+tbTeamName.Text+" " , "הוספת קבוצה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTeamName.Clear();
            }
            else 
            {
                MessageBox.Show(" קיימת קבוצה בעלת שם זהה ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void labelAddTeam_Click(object sender, EventArgs e)
        {
            backColor = labelAddTeam.BackColor;
            labelAddTeam.BackColor = Color.LightSteelBlue;
            leditTeam.BackColor = backColor; ;
            pEditTeam.Visible = false;

        }

        private void leditTeam_Click(object sender, EventArgs e)
        {
            backColor = leditTeam.BackColor;
            leditTeam.BackColor = Color.LightSteelBlue;
            labelAddTeam.BackColor = backColor;
            pEditTeam.Visible = true;

            itemBindingTeamsList.DataSource = cgai.getAllTeams();
            lbTeams.DataSource = itemBindingTeamsList;
            lbTeams.DisplayMember = "Name";
            itemBindingTeamsList.ResetBindings(false);
        
        }

        private void pEditTeam_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormAddTeam_Load(object sender, EventArgs e)
        {
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            tbTeamName.Clear();
            this.Hide();

        }

        private void lbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = (lbTeams.SelectedItem as CTeam);
            tbTeamDetails.Enabled = false;
            tbTeamDetails.Clear();
            tbTeamDetails.AppendText("מנהל : \n");
            tbTeamDetails.AppendText(t.Manager.DisplayName+"\n");
            tbTeamDetails.AppendText("מנהלמאמן : \n");
            tbTeamDetails.AppendText(t.Coach.DisplayName + "\n");
            tbTeamDetails.AppendText("שחקנים : \n");

            foreach (CPlayer p in t.Players)
            {
                tbTeamDetails.AppendText(p.DisplayName + "\n");
            }
    

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
