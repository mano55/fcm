namespace fcm
{
    partial class FormAddUser
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox_users = new System.Windows.Forms.CheckedListBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(255, 53);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxUserName.Size = new System.Drawing.Size(207, 22);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(255, 100);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPassword.Size = new System.Drawing.Size(207, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "שם משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "סיסמא";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListBox_users
            // 
            this.checkedListBox_users.FormattingEnabled = true;
            this.checkedListBox_users.Location = new System.Drawing.Point(13, 53);
            this.checkedListBox_users.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox_users.Name = "checkedListBox_users";
            this.checkedListBox_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox_users.Size = new System.Drawing.Size(163, 276);
            this.checkedListBox_users.TabIndex = 4;
            this.checkedListBox_users.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_users_SelectedIndexChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(363, 235);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 28);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "הוסף";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(363, 271);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 28);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "בטל";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(363, 306);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 28);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "נקה";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "מנהל",
            "מאמן",
            "הנה\"ח\t\t"});
            this.comboBox1.Location = new System.Drawing.Point(255, 147);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(207, 32);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "תפקיד";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "הרשאות";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 359);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.checkedListBox_users);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddUser";
            this.Text = "הוספת משתמש";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox_users;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}