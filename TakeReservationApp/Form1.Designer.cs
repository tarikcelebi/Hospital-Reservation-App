namespace TakeReservationApp
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
            btnCreateReservation = new Button();
            txtTC = new TextBox();
            txtNameSurname = new TextBox();
            txtPhone = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            cboPoliclinic = new ComboBox();
            dtp1 = new DateTimePicker();
            rbtnTwelve = new RadioButton();
            rbtnOne = new RadioButton();
            rbtnThree = new RadioButton();
            rbtnTwo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labl = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateReservation
            // 
            btnCreateReservation.Location = new Point(115, 396);
            btnCreateReservation.Name = "btnCreateReservation";
            btnCreateReservation.Size = new Size(187, 23);
            btnCreateReservation.TabIndex = 0;
            btnCreateReservation.Text = "Randevu Oluştur";
            btnCreateReservation.UseVisualStyleBackColor = true;
            btnCreateReservation.Click += btnCreateReservation_Click;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(115, 41);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(200, 23);
            txtTC.TabIndex = 1;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(115, 70);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(200, 23);
            txtNameSurname.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(115, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(115, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 76);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(126, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // cboPoliclinic
            // 
            cboPoliclinic.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPoliclinic.FormattingEnabled = true;
            cboPoliclinic.Items.AddRange(new object[] { "Goz Hastaliklari", "Beyin Cerrahi", "Gogus Hastalikleri", "Kadin Dogum", "Cildiye", "Kulak Burun Bogaz" });
            cboPoliclinic.Location = new Point(115, 234);
            cboPoliclinic.Name = "cboPoliclinic";
            cboPoliclinic.Size = new Size(202, 23);
            cboPoliclinic.TabIndex = 5;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(115, 263);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(200, 23);
            dtp1.TabIndex = 6;
            // 
            // rbtnTwelve
            // 
            rbtnTwelve.AutoSize = true;
            rbtnTwelve.Location = new Point(18, 22);
            rbtnTwelve.Name = "rbtnTwelve";
            rbtnTwelve.Size = new Size(52, 19);
            rbtnTwelve.TabIndex = 9;
            rbtnTwelve.TabStop = true;
            rbtnTwelve.Text = "12:00";
            rbtnTwelve.UseVisualStyleBackColor = true;
            // 
            // rbtnOne
            // 
            rbtnOne.AutoSize = true;
            rbtnOne.Location = new Point(126, 22);
            rbtnOne.Name = "rbtnOne";
            rbtnOne.Size = new Size(52, 19);
            rbtnOne.TabIndex = 10;
            rbtnOne.TabStop = true;
            rbtnOne.Text = "13:00";
            rbtnOne.UseVisualStyleBackColor = true;
            // 
            // rbtnThree
            // 
            rbtnThree.AutoSize = true;
            rbtnThree.Location = new Point(126, 58);
            rbtnThree.Name = "rbtnThree";
            rbtnThree.Size = new Size(52, 19);
            rbtnThree.TabIndex = 11;
            rbtnThree.TabStop = true;
            rbtnThree.Text = "15:00";
            rbtnThree.UseVisualStyleBackColor = true;
            // 
            // rbtnTwo
            // 
            rbtnTwo.AutoSize = true;
            rbtnTwo.Location = new Point(18, 58);
            rbtnTwo.Name = "rbtnTwo";
            rbtnTwo.Size = new Size(52, 19);
            rbtnTwo.TabIndex = 12;
            rbtnTwo.TabStop = true;
            rbtnTwo.Text = "14:00";
            rbtnTwo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 216);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 13;
            label1.Text = "Randevu Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 44);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 14;
            label2.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 73);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Ad Soyad";
            // 
            // labl
            // 
            labl.AutoSize = true;
            labl.Location = new Point(41, 102);
            labl.Name = "labl";
            labl.Size = new Size(45, 15);
            labl.TabIndex = 16;
            labl.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 237);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "Poliklinik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 281);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 18;
            label6.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 9);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 19;
            label7.Text = "Hasta Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnTwelve);
            groupBox2.Controls.Add(rbtnTwo);
            groupBox2.Controls.Add(rbtnOne);
            groupBox2.Controls.Add(rbtnThree);
            groupBox2.Location = new Point(115, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Saati";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 431);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp1);
            Controls.Add(cboPoliclinic);
            Controls.Add(groupBox1);
            Controls.Add(txtPhone);
            Controls.Add(txtNameSurname);
            Controls.Add(txtTC);
            Controls.Add(btnCreateReservation);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateReservation;
        private TextBox txtTC;
        private TextBox txtNameSurname;
        private TextBox txtPhone;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox cboPoliclinic;
        private DateTimePicker dtp1;
        private RadioButton rbtnTwelve;
        private RadioButton rbtnOne;
        private RadioButton rbtnThree;
        private RadioButton rbtnTwo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labl;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
    }
}