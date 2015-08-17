namespace fcm
{
    partial class FormAddTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_clean = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbTeamManage = new System.Windows.Forms.GroupBox();
            this.leditTeam = new System.Windows.Forms.Label();
            this.labelAddTeam = new System.Windows.Forms.Label();
            this.lAddTeam = new System.Windows.Forms.Label();
            this.pEditTeam = new System.Windows.Forms.Panel();
            this.tbTeamDetails = new System.Windows.Forms.TextBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbTeamManage.SuspendLayout();
            this.pEditTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(407, 162);
            this.button_clean.Margin = new System.Windows.Forms.Padding(4);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(106, 28);
            this.button_clean.TabIndex = 0;
            this.button_clean.Text = "נקה";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(92, 370);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(60, 36);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "סיים";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(407, 120);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(106, 28);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "הוסף";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(352, 67);
            this.tbTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(161, 22);
            this.tbTeamName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "שם הקבוצה";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbTeamManage);
            this.splitContainer1.Panel1.Controls.Add(this.button_close);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pEditTeam);
            this.splitContainer1.Panel2.Controls.Add(this.tbTeamName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button_add);
            this.splitContainer1.Panel2.Controls.Add(this.button_clean);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(860, 420);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 6;
            // 
            // gbTeamManage
            // 
            this.gbTeamManage.Controls.Add(this.leditTeam);
            this.gbTeamManage.Controls.Add(this.labelAddTeam);
            this.gbTeamManage.Controls.Add(this.lAddTeam);
            this.gbTeamManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gbTeamManage.Location = new System.Drawing.Point(23, 32);
            this.gbTeamManage.Name = "gbTeamManage";
            this.gbTeamManage.Size = new System.Drawing.Size(210, 314);
            this.gbTeamManage.TabIndex = 0;
            this.gbTeamManage.TabStop = false;
            this.gbTeamManage.Text = "ניהול קבוצה";
            // 
            // leditTeam
            // 
            this.leditTeam.AutoSize = true;
            this.leditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.leditTeam.Location = new System.Drawing.Point(90, 59);
            this.leditTeam.Name = "leditTeam";
            this.leditTeam.Size = new System.Drawing.Size(101, 18);
            this.leditTeam.TabIndex = 10;
            this.leditTeam.Text = "עריכת קבוצה";
            this.leditTeam.Click += new System.EventHandler(this.leditTeam_Click);
            // 
            // labelAddTeam
            // 
            this.labelAddTeam.AutoSize = true;
            this.labelAddTeam.BackColor = System.Drawing.SystemColors.Control;
            this.labelAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAddTeam.Location = new System.Drawing.Point(90, 32);
            this.labelAddTeam.Name = "labelAddTeam";
            this.labelAddTeam.Size = new System.Drawing.Size(102, 18);
            this.labelAddTeam.TabIndex = 9;
            this.labelAddTeam.Text = "הוספת קבוצה";
            this.labelAddTeam.Click += new System.EventHandler(this.labelAddTeam_Click);
            // 
            // lAddTeam
            // 
            this.lAddTeam.AutoSize = true;
            this.lAddTeam.Location = new System.Drawing.Point(84, 34);
            this.lAddTeam.Name = "lAddTeam";
            this.lAddTeam.Size = new System.Drawing.Size(0, 17);
            this.lAddTeam.TabIndex = 2;
            // 
            // pEditTeam
            // 
            this.pEditTeam.Controls.Add(this.tbTeamDetails);
            this.pEditTeam.Controls.Add(this.lbTeams);
            this.pEditTeam.Controls.Add(this.button3);
            this.pEditTeam.Controls.Add(this.button2);
            this.pEditTeam.Controls.Add(this.button1);
            this.pEditTeam.Controls.Add(this.label2);
            this.pEditTeam.Controls.Add(this.label3);
            this.pEditTeam.Controls.Add(this.comboBox2);
            this.pEditTeam.Controls.Add(this.comboBox1);
            this.pEditTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEditTeam.Location = new System.Drawing.Point(0, 0);
            this.pEditTeam.Name = "pEditTeam";
            this.pEditTeam.Size = new System.Drawing.Size(621, 420);
            this.pEditTeam.TabIndex = 5;
            this.pEditTeam.Visible = false;
            this.pEditTeam.Paint += new System.Windows.Forms.PaintEventHandler(this.pEditTeam_Paint);
            // 
            // tbTeamDetails
            // 
            this.tbTeamDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTeamDetails.BackColor = System.Drawing.SystemColors.Info;
            this.tbTeamDetails.Location = new System.Drawing.Point(54, 32);
            this.tbTeamDetails.Multiline = true;
            this.tbTeamDetails.Name = "tbTeamDetails";
            this.tbTeamDetails.Size = new System.Drawing.Size(138, 292);
            this.tbTeamDetails.TabIndex = 15;
            this.tbTeamDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTeams
            // 
            this.lbTeams.BackColor = System.Drawing.SystemColors.Info;
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(455, 32);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(138, 292);
            this.lbTeams.TabIndex = 14;
            this.lbTeams.SelectedIndexChanged += new System.EventHandler(this.lbTeams_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 366);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "ביטול";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "אישור";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "רשימת שחקנים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "בחר מאמן";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "בחר מנהל";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(271, 102);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 420);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddTeam";
            this.Text = "הוסף/ערוך קבוצה";
            this.Load += new System.EventHandler(this.FormAddTeam_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbTeamManage.ResumeLayout(false);
            this.gbTeamManage.PerformLayout();
            this.pEditTeam.ResumeLayout(false);
            this.pEditTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbTeamManage;
        private System.Windows.Forms.Label lAddTeam;
        private System.Windows.Forms.Panel pEditTeam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label leditTeam;
        private System.Windows.Forms.Label labelAddTeam;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.TextBox tbTeamDetails;


    }
}