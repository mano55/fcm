namespace fcm
{
    partial class FormAdmin
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.button_paymenets = new System.Windows.Forms.Button();
            this.button_AddCTeam = new System.Windows.Forms.Button();
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHome.BackgroundImage = global::fcm.Properties.Resources.home_icon_2;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHome.Location = new System.Drawing.Point(1092, 4);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(264, 655);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "חזור למסך ראשי";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button_paymenets
            // 
            this.button_paymenets.BackColor = System.Drawing.SystemColors.Control;
            this.button_paymenets.BackgroundImage = global::fcm.Properties.Resources.football86;
            this.button_paymenets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_paymenets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_paymenets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_paymenets.Location = new System.Drawing.Point(820, 4);
            this.button_paymenets.Margin = new System.Windows.Forms.Padding(4);
            this.button_paymenets.Name = "button_paymenets";
            this.button_paymenets.Size = new System.Drawing.Size(264, 655);
            this.button_paymenets.TabIndex = 4;
            this.button_paymenets.Text = "תשלומים";
            this.button_paymenets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_paymenets.UseVisualStyleBackColor = false;
            // 
            // button_AddCTeam
            // 
            this.button_AddCTeam.BackColor = System.Drawing.SystemColors.Control;
            this.button_AddCTeam.BackgroundImage = global::fcm.Properties.Resources.inflatable;
            this.button_AddCTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddCTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddCTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddCTeam.Location = new System.Drawing.Point(276, 4);
            this.button_AddCTeam.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddCTeam.Name = "button_AddCTeam";
            this.button_AddCTeam.Size = new System.Drawing.Size(264, 655);
            this.button_AddCTeam.TabIndex = 3;
            this.button_AddCTeam.Text = "הוסף/ערוך קבוצה";
            this.button_AddCTeam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddCTeam.UseVisualStyleBackColor = false;
            this.button_AddCTeam.Click += new System.EventHandler(this.button_AddCTeam_Click);
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.button_AddPlayer.BackgroundImage = global::fcm.Properties.Resources.football54;
            this.button_AddPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddPlayer.Location = new System.Drawing.Point(548, 4);
            this.button_AddPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(264, 655);
            this.button_AddPlayer.TabIndex = 1;
            this.button_AddPlayer.Text = "הוסף שחקן";
            this.button_AddPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddPlayer.UseVisualStyleBackColor = false;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // button_AddUser
            // 
            this.button_AddUser.BackColor = System.Drawing.SystemColors.Control;
            this.button_AddUser.BackgroundImage = global::fcm.Properties.Resources.football50;
            this.button_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddUser.Location = new System.Drawing.Point(4, 4);
            this.button_AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(264, 655);
            this.button_AddUser.TabIndex = 0;
            this.button_AddUser.Text = "הוסף משתמש";
            this.button_AddUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddUser.UseVisualStyleBackColor = false;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button_AddUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHome, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_AddPlayer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_paymenets, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_AddCTeam, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1360, 663);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_AddCTeam;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.Button button_paymenets;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}