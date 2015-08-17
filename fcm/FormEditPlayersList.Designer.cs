namespace fcm
{
    partial class FormEditPlayersList
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbCurrentTeamPlayers = new System.Windows.Forms.ListBox();
            this.lbAllPlayers = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "שחקן חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCurrentTeamPlayers
            // 
            this.lbCurrentTeamPlayers.FormattingEnabled = true;
            this.lbCurrentTeamPlayers.ItemHeight = 16;
            this.lbCurrentTeamPlayers.Location = new System.Drawing.Point(28, 63);
            this.lbCurrentTeamPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCurrentTeamPlayers.Name = "lbCurrentTeamPlayers";
            this.lbCurrentTeamPlayers.Size = new System.Drawing.Size(235, 388);
            this.lbCurrentTeamPlayers.TabIndex = 1;
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.FormattingEnabled = true;
            this.lbAllPlayers.ItemHeight = 16;
            this.lbAllPlayers.Location = new System.Drawing.Point(368, 63);
            this.lbAllPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.Size = new System.Drawing.Size(235, 388);
            this.lbAllPlayers.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = " הסר\r\n>>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "הוסף\r\n<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormEditPlayersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 617);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbAllPlayers);
            this.Controls.Add(this.lbCurrentTeamPlayers);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditPlayersList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbCurrentTeamPlayers;
        private System.Windows.Forms.ListBox lbAllPlayers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}