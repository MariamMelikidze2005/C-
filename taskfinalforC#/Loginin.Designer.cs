namespace taskfinalforC_
{
    partial class Loginin
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
            label1 = new Label();
            textBoxforusername = new TextBox();
            buttontocheckuser = new Button();
            label2 = new Label();
            textBoxforpassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(365, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // textBoxforusername
            // 
            textBoxforusername.Location = new Point(307, 94);
            textBoxforusername.Name = "textBoxforusername";
            textBoxforusername.Size = new Size(211, 23);
            textBoxforusername.TabIndex = 1;
            // 
            // buttontocheckuser
            // 
            buttontocheckuser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontocheckuser.ForeColor = SystemColors.HotTrack;
            buttontocheckuser.Location = new Point(337, 277);
            buttontocheckuser.Name = "buttontocheckuser";
            buttontocheckuser.Size = new Size(145, 46);
            buttontocheckuser.TabIndex = 2;
            buttontocheckuser.Text = "submit";
            buttontocheckuser.UseVisualStyleBackColor = true;
            buttontocheckuser.Click += buttontocheckuser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(365, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // textBoxforpassword
            // 
            textBoxforpassword.Location = new Point(307, 194);
            textBoxforpassword.Name = "textBoxforpassword";
            textBoxforpassword.Size = new Size(211, 23);
            textBoxforpassword.TabIndex = 1;
            // 
            // Loginin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(buttontocheckuser);
            Controls.Add(textBoxforpassword);
            Controls.Add(label2);
            Controls.Add(textBoxforusername);
            Controls.Add(label1);
            Name = "Loginin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxforusername;
        private Button buttontocheckuser;
        private Label label2;
        private TextBox textBoxforpassword;
    }
}