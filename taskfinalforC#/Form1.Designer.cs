namespace taskfinalforC_
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttontoshowdata = new Button();
            buttontodelete = new Button();
            buttontoedit = new Button();
            buttontoaddproduct = new Button();
            dataGridViewtoshowproduct = new DataGridView();
            comboBoxforchooseproductcategoryfromcategorytable = new ComboBox();
            comboBox1 = new ComboBox();
            toinputproductprice = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBoxforcategorynameinfut = new TextBox();
            label6 = new Label();
            toshowcategory = new Button();
            dataGridViewforshowcategory = new DataGridView();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtoshowproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toinputproductprice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewforshowcategory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 455);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Thistle;
            tabPage1.Controls.Add(buttontoshowdata);
            tabPage1.Controls.Add(buttontodelete);
            tabPage1.Controls.Add(buttontoedit);
            tabPage1.Controls.Add(buttontoaddproduct);
            tabPage1.Controls.Add(dataGridViewtoshowproduct);
            tabPage1.Controls.Add(comboBoxforchooseproductcategoryfromcategorytable);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(toinputproductprice);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // buttontoshowdata
            // 
            buttontoshowdata.BackColor = Color.MediumOrchid;
            buttontoshowdata.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontoshowdata.ForeColor = SystemColors.ButtonHighlight;
            buttontoshowdata.Location = new Point(497, 33);
            buttontoshowdata.Name = "buttontoshowdata";
            buttontoshowdata.Size = new Size(101, 42);
            buttontoshowdata.TabIndex = 7;
            buttontoshowdata.Text = "Show";
            buttontoshowdata.UseVisualStyleBackColor = false;
            buttontoshowdata.Click += button3_Click;
            // 
            // buttontodelete
            // 
            buttontodelete.BackColor = Color.MediumOrchid;
            buttontodelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontodelete.ForeColor = SystemColors.ButtonHighlight;
            buttontodelete.Location = new Point(556, 358);
            buttontodelete.Name = "buttontodelete";
            buttontodelete.Size = new Size(101, 42);
            buttontodelete.TabIndex = 7;
            buttontodelete.Text = "Delete";
            buttontodelete.UseVisualStyleBackColor = false;
            buttontodelete.Click += buttontodelete_Click;
            // 
            // buttontoedit
            // 
            buttontoedit.BackColor = Color.MediumOrchid;
            buttontoedit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontoedit.ForeColor = SystemColors.ButtonHighlight;
            buttontoedit.Location = new Point(331, 358);
            buttontoedit.Name = "buttontoedit";
            buttontoedit.Size = new Size(101, 42);
            buttontoedit.TabIndex = 7;
            buttontoedit.Text = "Edit";
            buttontoedit.UseVisualStyleBackColor = false;
            buttontoedit.Click += buttontoedit_Click;
            // 
            // buttontoaddproduct
            // 
            buttontoaddproduct.BackColor = Color.MediumOrchid;
            buttontoaddproduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttontoaddproduct.ForeColor = SystemColors.ButtonHighlight;
            buttontoaddproduct.Location = new Point(84, 358);
            buttontoaddproduct.Name = "buttontoaddproduct";
            buttontoaddproduct.Size = new Size(101, 42);
            buttontoaddproduct.TabIndex = 7;
            buttontoaddproduct.Text = "add";
            buttontoaddproduct.UseVisualStyleBackColor = false;
            buttontoaddproduct.Click += buttontoaddproduct_Click;
            // 
            // dataGridViewtoshowproduct
            // 
            dataGridViewtoshowproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtoshowproduct.Location = new Point(349, 88);
            dataGridViewtoshowproduct.Name = "dataGridViewtoshowproduct";
            dataGridViewtoshowproduct.RowTemplate.Height = 25;
            dataGridViewtoshowproduct.Size = new Size(394, 223);
            dataGridViewtoshowproduct.TabIndex = 6;
            dataGridViewtoshowproduct.CellContentClick += dataGridViewtoshowproduct_CellContentClick;
            // 
            // comboBoxforchooseproductcategoryfromcategorytable
            // 
            comboBoxforchooseproductcategoryfromcategorytable.FormattingEnabled = true;
            comboBoxforchooseproductcategoryfromcategorytable.Location = new Point(84, 279);
            comboBoxforchooseproductcategoryfromcategorytable.Name = "comboBoxforchooseproductcategoryfromcategorytable";
            comboBoxforchooseproductcategoryfromcategorytable.Size = new Size(187, 23);
            comboBoxforchooseproductcategoryfromcategorytable.TabIndex = 5;
            comboBoxforchooseproductcategoryfromcategorytable.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // toinputproductprice
            // 
            toinputproductprice.Location = new Point(110, 183);
            toinputproductprice.Name = "toinputproductprice";
            toinputproductprice.Size = new Size(145, 23);
            toinputproductprice.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(110, 183);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(145, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 241);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Product categories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 149);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 2;
            label5.Text = "Product price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 149);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Product price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 3;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 60);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Thistle;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBoxforcategorynameinfut);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(toshowcategory);
            tabPage2.Controls.Add(dataGridViewforshowcategory);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // textBoxforcategorynameinfut
            // 
            textBoxforcategorynameinfut.Location = new Point(90, 112);
            textBoxforcategorynameinfut.Name = "textBoxforcategorynameinfut";
            textBoxforcategorynameinfut.Size = new Size(205, 23);
            textBoxforcategorynameinfut.TabIndex = 5;
            //textBoxforcategorynameinfut.TextChanged += textBoxforcategorynameinfut_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 67);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 4;
            label6.Text = "Categori Name";
            // 
            // toshowcategory
            // 
            toshowcategory.BackColor = Color.MediumOrchid;
            toshowcategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toshowcategory.Location = new Point(195, 206);
            toshowcategory.Name = "toshowcategory";
            toshowcategory.Size = new Size(145, 64);
            toshowcategory.TabIndex = 2;
            toshowcategory.Text = "Show";
            toshowcategory.UseVisualStyleBackColor = false;
            toshowcategory.Click += button5_Click;
            // 
            // dataGridViewforshowcategory
            // 
            dataGridViewforshowcategory.BackgroundColor = Color.DarkOrchid;
            dataGridViewforshowcategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewforshowcategory.Location = new Point(382, 48);
            dataGridViewforshowcategory.Name = "dataGridViewforshowcategory";
            dataGridViewforshowcategory.RowTemplate.Height = 25;
            dataGridViewforshowcategory.Size = new Size(375, 272);
            dataGridViewforshowcategory.TabIndex = 1;
            dataGridViewforshowcategory.CellContentClick += dataGridViewforshowcategory_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumOrchid;
            button1.Location = new Point(49, 206);
            button1.Name = "button1";
            button1.Size = new Size(140, 64);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtoshowproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)toinputproductprice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewforshowcategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewtoshowproduct;
        private Button button4;
        private Button buttontoshowdata;
        private Button buttontodelete;
        private Button toaddproduct;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBoxforchooseproductcategoryfromcategorytable;
        private NumericUpDown toinputproductprice;
        private Label label5;
        private DataGridView dataGridViewforshowcategory;
        private TextBox textBoxforcategorynameinfut;
        private Label label6;
        private Button toshowcategory;
        private Button buttontoedit;
        private Button buttontoaddproduct;
        private Button button1;
    }
}