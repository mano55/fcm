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
    public partial class FormPlayer : Form
    {
        CGuiApplicationIntermediate cgai;
        BindingSource itemBindingTeamList = new BindingSource();
        BindingSource itemBindingChoosenTeam = new BindingSource();

        public FormPlayer()
        {
            InitializeComponent();
            cgai = CGuiApplicationIntermediate.InstanceCreation();
        }

        private void clearFormText()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbID.Clear();
            tbCity.Clear();
            tbStreet.Clear();
            tbHouseNo.Clear();
            tbPhone1.Clear();
            tbPhone2.Clear();
            tbEmail.Clear();
        }

        private string checkFormFilling() 
        {
            string error = ":חובה למלא את השדות הבאים";
            error += "\n";
            int errorLen = error.Length;

            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
                error += "שם פרטי \n";
            }
            if (String.IsNullOrEmpty(tbLastName.Text))
            {
                error += "שם משפחה \n";
            }

            if (String.IsNullOrEmpty(tbID.Text))
            {
                error += "תעודת זהות \n";
            }
            if (String.IsNullOrEmpty(tbCity.Text))
            {
                error += "עיר \n";
            }
            if (String.IsNullOrEmpty(tbStreet.Text))
            {
                error += "רחוב \n";
            }
            if (string.IsNullOrEmpty(tbHouseNo.Text))
            {
                error += "מספר בית \n";
            }
            if (string.IsNullOrEmpty(tbPhone1.Text) && string.IsNullOrEmpty(tbPhone2.Text))
            {

                error += "מספר טלפון \n";
            }
            if (errorLen == error.Length)
            {
                error = "";
            }

            return error;
        }

        private string checkFormFillingValidity(CCommunicationDetails commDet, out UInt32 id) 
        {
            UInt32 num = 0;
            const UInt32 idMaxNum = 999999999;
            string res = "";
            id = 0;

            if (UInt32.TryParse(tbID.Text, out num))
            {
                if (num > idMaxNum)
                {
                    res += "מספר ת.ז אינו חוקי \n";
                }
                else
                {
                    id = num;
                }
            }
            else 
            {
                res += "מספר ת.ז אינו חוקי \n";
            }

            if (UInt32.TryParse(tbHouseNo.Text, out num))
            {
                commDet.houseNo = num;
            }
            else
            {
                res += "מספר בית אינו חוקי \n";
            }

            if (UInt32.TryParse(tbPhone1.Text, out num))
            {
                commDet.phoneNo1 = num;
            }
            else
            {
                res += "טלפון 1 אינו חוקי \n";
            }
            if (UInt32.TryParse(tbPhone2.Text, out num))
            {
                commDet.phoneNo2 = num;
            }
            else
            {
                res += "טלפון  2 אינו חוקי \n";
            }

            return res;
        }

        private void resetForm() 
        {
            this.pPersonalDetails.Dock = DockStyle.Fill;
            this.pPersonalDetails.Visible = true;
            this.pChooseTeam.Dock = DockStyle.Fill;
            this.pChooseTeam.Visible = false;
            this.pPaymentDetails.Dock = DockStyle.Fill;
            this.pPaymentDetails.Visible = false;
            this.pAdditionalForms.Dock = DockStyle.Fill;
            this.pAdditionalForms.Visible = false;
            this.bPersonalDetCheck.Visible = false;
            this.bAdditionalCheck.Visible = false;
            this.bAddToTeamCheck.Visible = false;
            this.bPaymentCheck.Visible = false;
            this.bAddToTeam.Enabled = true;
        }

        private void newPlayerRegDone() 
        {
            var result = MessageBox.Show("?הוסף שחקן חדש", "שחקן נוסף בהצלחה", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            clearFormText();

            if (result == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            resetForm();  
            itemBindingTeamList.DataSource = cgai.getAllTeams();//.Where(x => x.Name != "").ToList();
            lbTeamsList.DataSource = itemBindingTeamList;   
            lbTeamsList.DisplayMember = "Name";      
        }

        private void buttOk_Click(object sender, EventArgs e)
        {
            UInt32 id = 0;
            CCommunicationDetails commDet = new CCommunicationDetails();

            string error = checkFormFilling();
            error = ""; //debug have to remove
            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                error = checkFormFillingValidity(commDet,out id); //debug have to restore
                if (error != "")
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    commDet.city = tbCity.Text;
                    commDet.street = tbStreet.Text;
                    commDet.email = tbEmail.Text;

                    error = cgai.addNewPlayer( tbFirstName.Text, tbLastName.Text, id, commDet);
                    if (error == "")
                    {
                        this.pChooseTeam.Visible = true;                     
                        this.lplayerName.Text = tbFirstName.Text + " " + tbLastName.Text;
                        this.bPersonalDetCheck.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }              
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            clearFormText();
            this.Hide();
        }

        private void bOk_Click(object sender, EventArgs e)
        {

        }

        private void pChooseTeam_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bAddToTeam_Click(object sender, EventArgs e)
        {
            UInt32 id = 0;
            UInt32.TryParse(tbID.Text, out id);
            CPlayer player = cgai.getDefultTeam().getPlayer(id);
            bAddToTeam.Enabled = false;
            if (player != null)
            {
                cgai.getDefultTeam().removePlayer(player);
                (lbTeamsList.SelectedItem as CTeam).addPlayer(player);
                lbChoosenTeam.DisplayMember = "DisplayName";
                itemBindingChoosenTeam.ResetBindings(false);
                
            }
            else 
            {
                MessageBox.Show("לא קיים שחקן עם ת.ז זו במערכת", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                
        }

        private void bRemoveFromTeam_Click(object sender, EventArgs e)
        {

        }

        private void bAddToTeamOk_Click(object sender, EventArgs e)
        {
            this.bAddToTeamCheck.Visible = true;
            this.pPaymentDetails.Dock = DockStyle.Fill;
            this.pPaymentDetails.Visible = true;

        }

        private void lbTeamsList_Click(object sender, EventArgs e)
        {
            
            CTeam selected = lbTeamsList.SelectedItem as CTeam;
            itemBindingChoosenTeam.DataSource = selected.Players;
            lbChoosenTeam.DataSource = itemBindingChoosenTeam; 
            lbTeamsList.DisplayMember = "DisplayName";
            itemBindingChoosenTeam.ResetBindings(false);
        }

        private void bPaymentOk_Click(object sender, EventArgs e)
        {
            this.bPaymentCheck.Visible = true;
            this.pAdditionalForms.Dock = DockStyle.Fill;
            this.pAdditionalForms.Visible = true;

        }

        private void bAadditionalOk_Click(object sender, EventArgs e)
        {
            // send additional forms to printer
            this.bAdditionalCheck.Visible = true;
            this.pPersonalDetails.Visible = false;

            var result = MessageBox.Show("רישום שחקן נוסף", "סיום רישום שחקן", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            FormClearing.CHelper.ClearFormControls(this);

            if (result == DialogResult.No)
            {
                this.Hide();
            }
            else 
            {
                resetForm();           
            }

        }
    }











}
