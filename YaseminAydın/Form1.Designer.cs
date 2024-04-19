namespace YaseminAydın
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label13 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            label10 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(68, 20);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1499, 674);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkOrange;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dateTimePicker3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1491, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Film";
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 24F);
            button1.ForeColor = Color.PaleVioletRed;
            button1.Location = new Point(316, 512);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(899, 101);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 24F);
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(645, 381);
            dateTimePicker3.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(570, 71);
            dateTimePicker3.TabIndex = 7;
            dateTimePicker3.Value = new DateTime(2024, 4, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Bisque;
            label4.Location = new Point(317, 381);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 56);
            label4.TabIndex = 3;
            label4.Text = "Seans 3:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 24F);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(644, 259);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(570, 71);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.Value = new DateTime(2024, 4, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Bisque;
            label3.Location = new Point(316, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 56);
            label3.TabIndex = 2;
            label3.Text = "Seans 2:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = Color.PaleVioletRed;
            dateTimePicker1.Font = new Font("Segoe UI", 24F);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(644, 141);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(570, 71);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 4, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Bisque;
            label2.Location = new Point(322, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 56);
            label2.TabIndex = 1;
            label2.Text = "Seans 1:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(644, 28);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 71);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(307, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 56);
            label1.TabIndex = 0;
            label1.Text = "Film Ad:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkOrange;
            tabPage2.Controls.Add(maskedTextBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1491, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Salon";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 24F);
            maskedTextBox1.Location = new Point(639, 312);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(570, 71);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.PaleVioletRed;
            button2.Location = new Point(248, 489);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(961, 92);
            button2.TabIndex = 13;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Bisque;
            label7.Location = new Point(248, 312);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(222, 56);
            label7.TabIndex = 10;
            label7.Text = "Kapasite:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(639, 146);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(570, 71);
            textBox2.TabIndex = 11;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Bisque;
            label8.Location = new Point(248, 161);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(230, 56);
            label8.TabIndex = 9;
            label8.Text = "Salon Ad:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Bisque;
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(maskedTextBox2);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(comboBox3);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(dateTimePicker4);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(1491, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Seans";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DarkOrange;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 139);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1389, 450);
            dataGridView1.TabIndex = 29;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Georgia", 8.25F);
            button3.Location = new Point(1203, 68);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(229, 38);
            button3.TabIndex = 28;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 8.25F);
            label13.Location = new Point(1071, 10);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 20;
            label13.Text = "Kimlik No:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(1203, 10);
            maskedTextBox2.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(227, 31);
            maskedTextBox2.TabIndex = 27;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 8.25F);
            label12.Location = new Point(665, 68);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(123, 20);
            label12.TabIndex = 19;
            label12.Text = "Müşteri Soyad:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(817, 68);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 31);
            textBox4.TabIndex = 26;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 8.25F);
            label11.Location = new Point(692, 10);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 18;
            label11.Text = "Müşteri Ad:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(817, 10);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 31);
            textBox3.TabIndex = 25;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(397, 65);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 33);
            comboBox3.TabIndex = 24;
            comboBox3.MouseHover += comboBox3_MouseHover;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 8.25F);
            label10.Location = new Point(329, 62);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 17;
            label10.Text = "Salon:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(90, 58);
            dateTimePicker4.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(227, 31);
            dateTimePicker4.TabIndex = 22;
            dateTimePicker4.Value = new DateTime(2024, 4, 19, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 8.25F);
            label9.Location = new Point(31, 68);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 15;
            label9.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(397, 10);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 33);
            comboBox2.TabIndex = 23;
            comboBox2.MouseHover += comboBox2_MouseHover;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 8.25F);
            label6.Location = new Point(327, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 16;
            label6.Text = "Seans:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 10);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 33);
            comboBox1.TabIndex = 21;
            comboBox1.MouseHover += comboBox1_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 8.25F);
            label5.Location = new Point(9, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 14;
            label5.Text = "Film Ad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1652, 728);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Sinema Bileti Satış Uygulaması";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage2;
        private Button button1;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TabPage tabPage3;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Label label10;
        private DateTimePicker dateTimePicker4;
        private Label label9;
        private Label label11;
        private TextBox textBox3;
        private Button button3;
        private Label label13;
        private MaskedTextBox maskedTextBox2;
        private Label label12;
        private TextBox textBox4;
        private DataGridView dataGridView1;
    }
}
