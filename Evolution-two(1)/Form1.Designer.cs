namespace Evolution_two_1_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.TotalExpenseButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.FilterByDateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomFilterButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.datePicker2 = new Evolution_two_1_.DatePicker();
            this.datePicker3 = new Evolution_two_1_.DatePicker();
            this.datePicker1 = new Evolution_two_1_.DatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryRichTextBox
            // 
            this.CategoryRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryRichTextBox.Location = new System.Drawing.Point(86, 4);
            this.CategoryRichTextBox.Name = "CategoryRichTextBox";
            this.CategoryRichTextBox.Size = new System.Drawing.Size(176, 25);
            this.CategoryRichTextBox.TabIndex = 1;
            this.CategoryRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category     : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount       : ";
            // 
            // AmountRichTextBox
            // 
            this.AmountRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountRichTextBox.Location = new System.Drawing.Point(625, 155);
            this.AmountRichTextBox.Name = "AmountRichTextBox";
            this.AmountRichTextBox.Size = new System.Drawing.Size(230, 36);
            this.AmountRichTextBox.TabIndex = 3;
            this.AmountRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date           : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(438, 303);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(456, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expenses";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(557, 419);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 36);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove By Id";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(668, 419);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(105, 36);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditClicked);
            // 
            // TotalExpenseButton
            // 
            this.TotalExpenseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TotalExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalExpenseButton.ForeColor = System.Drawing.Color.White;
            this.TotalExpenseButton.Location = new System.Drawing.Point(779, 419);
            this.TotalExpenseButton.Name = "TotalExpenseButton";
            this.TotalExpenseButton.Size = new System.Drawing.Size(108, 36);
            this.TotalExpenseButton.TabIndex = 12;
            this.TotalExpenseButton.Text = "TotalExpense";
            this.TotalExpenseButton.UseVisualStyleBackColor = false;
            this.TotalExpenseButton.Click += new System.EventHandler(this.TotalExpense);
            // 
            // FilterButton
            // 
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(625, 50);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(230, 26);
            this.FilterButton.TabIndex = 13;
            this.FilterButton.Text = "FilterByCatogry";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterClicked);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(343, 54);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(112, 42);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshClicked);
            // 
            // FilterByDateButton
            // 
            this.FilterByDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterByDateButton.Location = new System.Drawing.Point(624, 252);
            this.FilterByDateButton.Name = "FilterByDateButton";
            this.FilterByDateButton.Size = new System.Drawing.Size(231, 27);
            this.FilterByDateButton.TabIndex = 15;
            this.FilterByDateButton.Text = "FilterByDate";
            this.FilterByDateButton.UseVisualStyleBackColor = true;
            this.FilterByDateButton.Click += new System.EventHandler(this.FilterByDateButtonClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Enter from Date  from  filter  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Enter from Date  to filter ";
            // 
            // CustomFilterButton
            // 
            this.CustomFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFilterButton.Location = new System.Drawing.Point(18, 511);
            this.CustomFilterButton.Name = "CustomFilterButton";
            this.CustomFilterButton.Size = new System.Drawing.Size(424, 31);
            this.CustomFilterButton.TabIndex = 26;
            this.CustomFilterButton.Text = "Custom Filter";
            this.CustomFilterButton.UseVisualStyleBackColor = true;
            this.CustomFilterButton.Click += new System.EventHandler(this.CustomButtonClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Travel",
            "Food",
            "Gaming"});
            this.comboBox1.Location = new System.Drawing.Point(625, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 32);
            this.comboBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Expense Id  : ";
            // 
            // IdBox
            // 
            this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(624, 95);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(231, 35);
            this.IdBox.TabIndex = 29;
            this.IdBox.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 25);
            this.button3.TabIndex = 30;
            this.button3.Text = "AddCatgory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(85, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 28);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 32;
            this.button4.Text = "RemoveCatgory";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CategoryRichTextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(511, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 84);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datePicker1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.IdBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AmountRichTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FilterByDateButton);
            this.panel2.Controls.Add(this.FilterButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 305);
            this.panel2.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Edit Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Set Monthly Limit";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(456, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(593, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 28);
            this.button5.TabIndex = 40;
            this.button5.Text = "View Limits";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(741, 511);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 28);
            this.button6.TabIndex = 41;
            this.button6.Text = "Truncate Limits";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // datePicker2
            // 
            this.datePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker2.BorderSize = 0;
            this.datePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker2.Location = new System.Drawing.Point(299, 421);
            this.datePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(143, 35);
            this.datePicker2.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker2.TabIndex = 31;
            this.datePicker2.TextColor = System.Drawing.Color.Black;
            // 
            // datePicker3
            // 
            this.datePicker3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker3.BorderSize = 0;
            this.datePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker3.Location = new System.Drawing.Point(299, 468);
            this.datePicker3.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker3.Name = "datePicker3";
            this.datePicker3.Size = new System.Drawing.Size(143, 35);
            this.datePicker3.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker3.TabIndex = 32;
            this.datePicker3.TextColor = System.Drawing.Color.Black;
            // 
            // datePicker1
            // 
            this.datePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker1.BorderSize = 0;
            this.datePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker1.Location = new System.Drawing.Point(624, 214);
            this.datePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(231, 35);
            this.datePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker1.TabIndex = 30;
            this.datePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 557);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker2);
            this.Controls.Add(this.datePicker3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomFilterButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TotalExpenseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CategoryRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox AmountRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button TotalExpenseButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button FilterByDateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CustomFilterButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox IdBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private DatePicker datePicker1;
        private DatePicker datePicker2;
        private DatePicker datePicker3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

