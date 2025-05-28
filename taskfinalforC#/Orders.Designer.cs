namespace taskfinalforC_
{
    partial class Orders
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
            forshoworders = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)forshoworders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(338, 33);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Show orders:";
            // 
            // forshoworders
            // 
            forshoworders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            forshoworders.Location = new Point(168, 87);
            forshoworders.Name = "forshoworders";
            forshoworders.RowTemplate.Height = 25;
            forshoworders.Size = new Size(471, 237);
            forshoworders.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(547, 395);
            button1.Name = "button1";
            button1.Size = new Size(131, 35);
            button1.TabIndex = 2;
            button1.Text = "Your order";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(126, 405);
            label2.Name = "label2";
            label2.Size = new Size(385, 25);
            label2.TabIndex = 0;
            label2.Text = "if you want to create your order click here";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(271, 343);
            button2.Name = "button2";
            button2.Size = new Size(131, 35);
            button2.TabIndex = 2;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(408, 343);
            button3.Name = "button3";
            button3.Size = new Size(131, 35);
            button3.TabIndex = 2;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = false;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(forshoworders);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)forshoworders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView forshoworders;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}