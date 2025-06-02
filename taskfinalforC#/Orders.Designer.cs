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
            buttonfornavigeitotherpage = new Button();
            buttonshowprevious = new Button();
            buttontoshownext = new Button();
            label3 = new Label();
            label4 = new Label();
            toeditorders = new Button();
            todeleteorders = new Button();
            numericUpDownforinputquantityofproduct = new NumericUpDown();
            comboBoxforchoosdesiredCAtegory = new ComboBox();
            comboBoxforchooseproduct = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            buttontoshoworders = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxforshowsum = new TextBox();
            label2 = new Label();
            label13 = new Label();
            label14 = new Label();
            dateTimePickerfrom = new DateTimePicker();
            dateTimePickertosomedate = new DateTimePicker();
            comboBoxforshowproducts = new ComboBox();
            textBoxtoentercustomername = new TextBox();
            buttontosumproductprice = new Button();
            labelPageInfo = new Label();
            buttonforfilterbydate = new Button();
            label15 = new Label();
            dateTimePickerforneworders = new DateTimePicker();
            buttonforaddorders = new Button();
            textBoxforquantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)forshoworders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownforinputquantityofproduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(506, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Show orders:";
            // 
            // forshoworders
            // 
            forshoworders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            forshoworders.Location = new Point(378, 86);
            forshoworders.Name = "forshoworders";
            forshoworders.RowTemplate.Height = 25;
            forshoworders.Size = new Size(396, 237);
            forshoworders.TabIndex = 1;
            forshoworders.CellContentClick += forshoworders_CellContentClick;
            // 
            // buttonfornavigeitotherpage
            // 
            buttonfornavigeitotherpage.BackColor = SystemColors.GradientActiveCaption;
            buttonfornavigeitotherpage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonfornavigeitotherpage.ForeColor = SystemColors.HotTrack;
            buttonfornavigeitotherpage.Location = new Point(999, 445);
            buttonfornavigeitotherpage.Name = "buttonfornavigeitotherpage";
            buttonfornavigeitotherpage.Size = new Size(131, 35);
            buttonfornavigeitotherpage.TabIndex = 2;
            buttonfornavigeitotherpage.Text = "Back";
            buttonfornavigeitotherpage.UseVisualStyleBackColor = false;
            buttonfornavigeitotherpage.Click += buttonfornavigeitotherpage_Click;
            // 
            // buttonshowprevious
            // 
            buttonshowprevious.BackColor = SystemColors.GradientActiveCaption;
            buttonshowprevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonshowprevious.ForeColor = SystemColors.HotTrack;
            buttonshowprevious.Location = new Point(447, 343);
            buttonshowprevious.Name = "buttonshowprevious";
            buttonshowprevious.Size = new Size(131, 35);
            buttonshowprevious.TabIndex = 2;
            buttonshowprevious.Text = "Previous";
            buttonshowprevious.UseVisualStyleBackColor = false;
            buttonshowprevious.Click += buttonshowprevious_Click;
            // 
            // buttontoshownext
            // 
            buttontoshownext.BackColor = SystemColors.GradientActiveCaption;
            buttontoshownext.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontoshownext.ForeColor = SystemColors.HotTrack;
            buttontoshownext.Location = new Point(584, 343);
            buttontoshownext.Name = "buttontoshownext";
            buttontoshownext.Size = new Size(131, 35);
            buttontoshownext.TabIndex = 2;
            buttontoshownext.Text = "Next";
            buttontoshownext.UseVisualStyleBackColor = false;
            buttontoshownext.Click += buttontoshownext_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(44, 33);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Edit orders:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(22, 76);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 0;
            label4.Text = "Delete orders:";
            // 
            // toeditorders
            // 
            toeditorders.BackColor = SystemColors.ActiveCaption;
            toeditorders.Location = new Point(175, 37);
            toeditorders.Name = "toeditorders";
            toeditorders.Size = new Size(75, 23);
            toeditorders.TabIndex = 3;
            toeditorders.Text = "edit";
            toeditorders.UseVisualStyleBackColor = false;
            toeditorders.Click += toeditorders_Click;
            // 
            // todeleteorders
            // 
            todeleteorders.BackColor = SystemColors.ActiveCaption;
            todeleteorders.Location = new Point(175, 80);
            todeleteorders.Name = "todeleteorders";
            todeleteorders.Size = new Size(75, 23);
            todeleteorders.TabIndex = 3;
            todeleteorders.Text = "Delete";
            todeleteorders.UseVisualStyleBackColor = false;
            todeleteorders.Click += todeleteorders_Click;
            // 
            // numericUpDownforinputquantityofproduct
            // 
            numericUpDownforinputquantityofproduct.Location = new Point(229, 177);
            numericUpDownforinputquantityofproduct.Name = "numericUpDownforinputquantityofproduct";
            numericUpDownforinputquantityofproduct.Size = new Size(125, 23);
            numericUpDownforinputquantityofproduct.TabIndex = 11;
            numericUpDownforinputquantityofproduct.ValueChanged += numericUpDownforinputquantityofproduct_ValueChanged;
            // 
            // comboBoxforchoosdesiredCAtegory
            // 
            comboBoxforchoosdesiredCAtegory.FormattingEnabled = true;
            comboBoxforchoosdesiredCAtegory.Location = new Point(56, 279);
            comboBoxforchoosdesiredCAtegory.Name = "comboBoxforchoosdesiredCAtegory";
            comboBoxforchoosdesiredCAtegory.Size = new Size(121, 23);
            comboBoxforchoosdesiredCAtegory.TabIndex = 9;
            comboBoxforchoosdesiredCAtegory.SelectedIndexChanged += comboBoxforchoosdesiredCAtegory_SelectedIndexChanged;
            // 
            // comboBoxforchooseproduct
            // 
            comboBoxforchooseproduct.FormattingEnabled = true;
            comboBoxforchooseproduct.Location = new Point(56, 176);
            comboBoxforchooseproduct.Name = "comboBoxforchooseproduct";
            comboBoxforchooseproduct.Size = new Size(121, 23);
            comboBoxforchooseproduct.TabIndex = 10;
            comboBoxforchooseproduct.SelectedIndexChanged += comboBoxforchooseproduct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(240, 140);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 6;
            label5.Text = "Enter quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(22, 235);
            label7.Name = "label7";
            label7.Size = new Size(208, 20);
            label7.TabIndex = 7;
            label7.Text = "choose the desired Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(12, 140);
            label6.Name = "label6";
            label6.Size = new Size(199, 20);
            label6.TabIndex = 8;
            label6.Text = "choose the desired product";
            // 
            // buttontoshoworders
            // 
            buttontoshoworders.BackColor = SystemColors.ActiveCaption;
            buttontoshoworders.Location = new Point(536, 57);
            buttontoshoworders.Name = "buttontoshoworders";
            buttontoshoworders.Size = new Size(75, 23);
            buttontoshoworders.TabIndex = 3;
            buttontoshoworders.Text = "show";
            buttontoshoworders.UseVisualStyleBackColor = false;
            buttontoshoworders.Click += buttontoshoworders_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(834, 33);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 0;
            label8.Text = "Add orders:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(780, 127);
            label9.Name = "label9";
            label9.Size = new Size(199, 20);
            label9.TabIndex = 8;
            label9.Text = "choose the desired product";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(1010, 127);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 6;
            label10.Text = "Enter quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(792, 218);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 8;
            label11.Text = "enter customer name";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(794, 315);
            label12.Name = "label12";
            label12.Size = new Size(200, 25);
            label12.TabIndex = 0;
            label12.Text = "Sum of your product";
            // 
            // textBoxforshowsum
            // 
            textBoxforshowsum.Location = new Point(1010, 320);
            textBoxforshowsum.Name = "textBoxforshowsum";
            textBoxforshowsum.Size = new Size(121, 23);
            textBoxforshowsum.TabIndex = 12;
            textBoxforshowsum.TextChanged += textBoxforshowsum_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(57, 358);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 8;
            label2.Text = "Filter by date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(31, 404);
            label13.Name = "label13";
            label13.Size = new Size(50, 20);
            label13.TabIndex = 8;
            label13.Text = "from-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(31, 445);
            label14.Name = "label14";
            label14.Size = new Size(30, 20);
            label14.TabIndex = 8;
            label14.Text = "to-";
            // 
            // dateTimePickerfrom
            // 
            dateTimePickerfrom.Location = new Point(100, 404);
            dateTimePickerfrom.Name = "dateTimePickerfrom";
            dateTimePickerfrom.Size = new Size(200, 23);
            dateTimePickerfrom.TabIndex = 13;
            dateTimePickerfrom.ValueChanged += dateTimePickerfrom_ValueChanged;
            // 
            // dateTimePickertosomedate
            // 
            dateTimePickertosomedate.Location = new Point(100, 445);
            dateTimePickertosomedate.Name = "dateTimePickertosomedate";
            dateTimePickertosomedate.Size = new Size(200, 23);
            dateTimePickertosomedate.TabIndex = 13;
            dateTimePickertosomedate.ValueChanged += dateTimePickertosomedate_ValueChanged;
            // 
            // comboBoxforshowproducts
            // 
            comboBoxforshowproducts.FormattingEnabled = true;
            comboBoxforshowproducts.Location = new Point(826, 176);
            comboBoxforshowproducts.Name = "comboBoxforshowproducts";
            comboBoxforshowproducts.Size = new Size(121, 23);
            comboBoxforshowproducts.TabIndex = 14;
            comboBoxforshowproducts.SelectedIndexChanged += comboBoxforshowproducts_SelectedIndexChanged;
            // 
            // textBoxtoentercustomername
            // 
            textBoxtoentercustomername.Location = new Point(834, 264);
            textBoxtoentercustomername.Name = "textBoxtoentercustomername";
            textBoxtoentercustomername.Size = new Size(100, 23);
            textBoxtoentercustomername.TabIndex = 16;
            textBoxtoentercustomername.TextChanged += textBoxtoentercustomername_TextChanged;
            // 
            // buttontosumproductprice
            // 
            buttontosumproductprice.BackColor = SystemColors.ActiveCaption;
            buttontosumproductprice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontosumproductprice.Location = new Point(854, 350);
            buttontosumproductprice.Name = "buttontosumproductprice";
            buttontosumproductprice.Size = new Size(75, 28);
            buttontosumproductprice.TabIndex = 17;
            buttontosumproductprice.Text = "sum";
            buttontosumproductprice.UseVisualStyleBackColor = false;
            buttontosumproductprice.Click += buttontosumproductprice_Click;
            // 
            // labelPageInfo
            // 
            labelPageInfo.AutoSize = true;
            labelPageInfo.Location = new Point(551, 394);
            labelPageInfo.Name = "labelPageInfo";
            labelPageInfo.Size = new Size(0, 15);
            labelPageInfo.TabIndex = 18;
            // 
            // buttonforfilterbydate
            // 
            buttonforfilterbydate.BackColor = SystemColors.ActiveCaption;
            buttonforfilterbydate.Location = new Point(327, 420);
            buttonforfilterbydate.Name = "buttonforfilterbydate";
            buttonforfilterbydate.Size = new Size(75, 23);
            buttonforfilterbydate.TabIndex = 19;
            buttonforfilterbydate.Text = "Fillter";
            buttonforfilterbydate.UseVisualStyleBackColor = false;
            buttonforfilterbydate.Click += buttonforfilterbydate_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(1028, 218);
            label15.Name = "label15";
            label15.Size = new Size(70, 20);
            label15.TabIndex = 8;
            label15.Text = "add date";
            label15.Click += label11_Click;
            // 
            // dateTimePickerforneworders
            // 
            dateTimePickerforneworders.Location = new Point(974, 261);
            dateTimePickerforneworders.Name = "dateTimePickerforneworders";
            dateTimePickerforneworders.Size = new Size(200, 23);
            dateTimePickerforneworders.TabIndex = 20;
            dateTimePickerforneworders.ValueChanged += dateTimePickerforneworders_ValueChanged;
            // 
            // buttonforaddorders
            // 
            buttonforaddorders.BackColor = SystemColors.ActiveCaption;
            buttonforaddorders.Location = new Point(974, 37);
            buttonforaddorders.Name = "buttonforaddorders";
            buttonforaddorders.Size = new Size(75, 23);
            buttonforaddorders.TabIndex = 21;
            buttonforaddorders.Text = "add";
            buttonforaddorders.UseVisualStyleBackColor = false;
            buttonforaddorders.Click += buttonforaddorders_Click;
            // 
            // textBoxforquantity
            // 
            textBoxforquantity.Location = new Point(1008, 176);
            textBoxforquantity.Name = "textBoxforquantity";
            textBoxforquantity.Size = new Size(100, 23);
            textBoxforquantity.TabIndex = 22;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 511);
            Controls.Add(textBoxforquantity);
            Controls.Add(buttonforaddorders);
            Controls.Add(dateTimePickerforneworders);
            Controls.Add(buttonforfilterbydate);
            Controls.Add(labelPageInfo);
            Controls.Add(buttontosumproductprice);
            Controls.Add(textBoxtoentercustomername);
            Controls.Add(comboBoxforshowproducts);
            Controls.Add(dateTimePickertosomedate);
            Controls.Add(dateTimePickerfrom);
            Controls.Add(textBoxforshowsum);
            Controls.Add(numericUpDownforinputquantityofproduct);
            Controls.Add(comboBoxforchoosdesiredCAtegory);
            Controls.Add(label10);
            Controls.Add(comboBoxforchooseproduct);
            Controls.Add(label5);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(todeleteorders);
            Controls.Add(buttontoshoworders);
            Controls.Add(toeditorders);
            Controls.Add(buttontoshownext);
            Controls.Add(buttonshowprevious);
            Controls.Add(buttonfornavigeitotherpage);
            Controls.Add(forshoworders);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Orders";
            Text = "e";
            ((System.ComponentModel.ISupportInitialize)forshoworders).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownforinputquantityofproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label label1;
        //private DataGridView forshoworders;
        //private Button buttonfornavigeitotherpage;
        //private Button buttonshowprevious;
        //private Button buttontoshownext;
        //private Label label3;
        //private Label label4;
        //private Button toeditorders;
        //private Button todeleteorders;
        //private NumericUpDown numericUpDownforinputquantityofproduct;
        //private ComboBox comboBoxforchoosdesiredCAtegory;
        //private ComboBox comboBoxforchooseproduct;
        //private Label label5;
        //private Label label7;
        //private Label label6;
        //private Button buttontoshoworders;
        //private Label label8;
        //private Button buttontoaddorders;
        //private Label label9;
        //private Label label10;
        //private ComboBox comboBox1;
        //private NumericUpDown numericUpDown1;
        //private Label label11;
        //private TextBox textBoxtoentercustomername;
        //private Label label12;
        //private Button buttonforproductsum;
        //private TextBox textBoxforshowsum;
        //private Label label2;
        //private Label label13;
        //private Label label14;
        //private DateTimePicker dateTimePickerfrom;
        //private DateTimePicker dateTimePickertosomedate;


        // Added missing fields
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView forshoworders;
        private System.Windows.Forms.Button buttonfornavigeitotherpage;
        private System.Windows.Forms.Button buttonshowprevious;
        private System.Windows.Forms.Button buttontoshownext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button toeditorders;
        private System.Windows.Forms.Button todeleteorders;
        private System.Windows.Forms.NumericUpDown numericUpDownforinputquantityofproduct;
        private System.Windows.Forms.ComboBox comboBoxforchoosdesiredCAtegory;
        private System.Windows.Forms.ComboBox comboBoxforchooseproduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttontoshoworders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxforshowsum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerfrom;
        private System.Windows.Forms.DateTimePicker dateTimePickertosomedate;
        private ComboBox comboBoxforshowproducts;
        private TextBox textBoxtoentercustomername;
        private Button buttontosumproductprice;
        private Label labelPageInfo;
        private Button buttonforfilterbydate;
        private Label label15;
        private DateTimePicker dateTimePickerforneworders;
        private Button buttonforaddorders;
        private TextBox textBoxforquantity;
    }
}