namespace BestOil
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpPaymentOil = new System.Windows.Forms.GroupBox();
            this.tbPaymentOil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSumOil = new System.Windows.Forms.Label();
            this.tbSumPriceOil = new System.Windows.Forms.TextBox();
            this.radSumOil = new System.Windows.Forms.RadioButton();
            this.lbCountOil = new System.Windows.Forms.Label();
            this.tbCountOil = new System.Windows.Forms.TextBox();
            this.radCountOil = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceOil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFuels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbPaymentCafe = new System.Windows.Forms.TextBox();
            this.tbCountGamburger = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbGamburger = new System.Windows.Forms.TextBox();
            this.chkGamburger = new System.Windows.Forms.CheckBox();
            this.tbCountChizburger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbChizburger = new System.Windows.Forms.TextBox();
            this.chkChizburger = new System.Windows.Forms.CheckBox();
            this.tbCountCola = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCola = new System.Windows.Forms.TextBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountHotDog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHotDog = new System.Windows.Forms.TextBox();
            this.chkHotDog = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotalPayment = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpPaymentOil.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpPaymentOil);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPriceOil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFuels);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Топливо";
            // 
            // grpPaymentOil
            // 
            this.grpPaymentOil.Controls.Add(this.tbPaymentOil);
            this.grpPaymentOil.Location = new System.Drawing.Point(15, 185);
            this.grpPaymentOil.Name = "grpPaymentOil";
            this.grpPaymentOil.Size = new System.Drawing.Size(242, 100);
            this.grpPaymentOil.TabIndex = 6;
            this.grpPaymentOil.TabStop = false;
            this.grpPaymentOil.Text = "К оплате";
            // 
            // tbPaymentOil
            // 
            this.tbPaymentOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPaymentOil.Location = new System.Drawing.Point(7, 20);
            this.tbPaymentOil.Name = "tbPaymentOil";
            this.tbPaymentOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPaymentOil.Size = new System.Drawing.Size(229, 53);
            this.tbPaymentOil.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSumOil);
            this.groupBox3.Controls.Add(this.tbSumPriceOil);
            this.groupBox3.Controls.Add(this.radSumOil);
            this.groupBox3.Controls.Add(this.lbCountOil);
            this.groupBox3.Controls.Add(this.tbCountOil);
            this.groupBox3.Controls.Add(this.radCountOil);
            this.groupBox3.Location = new System.Drawing.Point(15, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lbSumOil
            // 
            this.lbSumOil.AutoSize = true;
            this.lbSumOil.Location = new System.Drawing.Point(201, 67);
            this.lbSumOil.Name = "lbSumOil";
            this.lbSumOil.Size = new System.Drawing.Size(27, 13);
            this.lbSumOil.TabIndex = 5;
            this.lbSumOil.Text = "руб.";
            // 
            // tbSumPriceOil
            // 
            this.tbSumPriceOil.Location = new System.Drawing.Point(97, 60);
            this.tbSumPriceOil.Name = "tbSumPriceOil";
            this.tbSumPriceOil.ReadOnly = true;
            this.tbSumPriceOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSumPriceOil.Size = new System.Drawing.Size(100, 20);
            this.tbSumPriceOil.TabIndex = 4;
            this.tbSumPriceOil.Text = "0";
            // 
            // radSumOil
            // 
            this.radSumOil.AutoSize = true;
            this.radSumOil.Location = new System.Drawing.Point(7, 60);
            this.radSumOil.Name = "radSumOil";
            this.radSumOil.Size = new System.Drawing.Size(59, 17);
            this.radSumOil.TabIndex = 3;
            this.radSumOil.TabStop = true;
            this.radSumOil.Text = "Сумма";
            this.radSumOil.UseVisualStyleBackColor = true;
            this.radSumOil.CheckedChanged += new System.EventHandler(this.radSumOil_CheckedChanged);
            // 
            // lbCountOil
            // 
            this.lbCountOil.AutoSize = true;
            this.lbCountOil.Location = new System.Drawing.Point(201, 26);
            this.lbCountOil.Name = "lbCountOil";
            this.lbCountOil.Size = new System.Drawing.Size(16, 13);
            this.lbCountOil.TabIndex = 2;
            this.lbCountOil.Text = "л.";
            // 
            // tbCountOil
            // 
            this.tbCountOil.Location = new System.Drawing.Point(97, 20);
            this.tbCountOil.Name = "tbCountOil";
            this.tbCountOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCountOil.Size = new System.Drawing.Size(100, 20);
            this.tbCountOil.TabIndex = 1;
            this.tbCountOil.TextChanged += new System.EventHandler(this.tbCountOil_TextChanged);
            // 
            // radCountOil
            // 
            this.radCountOil.AutoSize = true;
            this.radCountOil.Location = new System.Drawing.Point(7, 20);
            this.radCountOil.Name = "radCountOil";
            this.radCountOil.Size = new System.Drawing.Size(84, 17);
            this.radCountOil.TabIndex = 0;
            this.radCountOil.TabStop = true;
            this.radCountOil.Text = "Количество";
            this.radCountOil.UseVisualStyleBackColor = true;
            this.radCountOil.CheckedChanged += new System.EventHandler(this.radCountOil_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(224, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "руб.";
            // 
            // tbPriceOil
            // 
            this.tbPriceOil.Location = new System.Drawing.Point(89, 53);
            this.tbPriceOil.Name = "tbPriceOil";
            this.tbPriceOil.ReadOnly = true;
            this.tbPriceOil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPriceOil.Size = new System.Drawing.Size(123, 20);
            this.tbPriceOil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // cbFuels
            // 
            this.cbFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFuels.FormattingEnabled = true;
            this.cbFuels.Location = new System.Drawing.Point(89, 20);
            this.cbFuels.Name = "cbFuels";
            this.cbFuels.Size = new System.Drawing.Size(123, 21);
            this.cbFuels.TabIndex = 1;
            this.cbFuels.SelectedIndexChanged += new System.EventHandler(this.cbFuels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.tbCountGamburger);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbGamburger);
            this.groupBox2.Controls.Add(this.chkGamburger);
            this.groupBox2.Controls.Add(this.tbCountChizburger);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbChizburger);
            this.groupBox2.Controls.Add(this.chkChizburger);
            this.groupBox2.Controls.Add(this.tbCountCola);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCola);
            this.groupBox2.Controls.Add(this.chkCola);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCountHotDog);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbHotDog);
            this.groupBox2.Controls.Add(this.chkHotDog);
            this.groupBox2.Location = new System.Drawing.Point(301, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-кафе";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbPaymentCafe);
            this.groupBox5.Location = new System.Drawing.Point(21, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // tbPaymentCafe
            // 
            this.tbPaymentCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPaymentCafe.Location = new System.Drawing.Point(7, 24);
            this.tbPaymentCafe.Name = "tbPaymentCafe";
            this.tbPaymentCafe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPaymentCafe.Size = new System.Drawing.Size(229, 53);
            this.tbPaymentCafe.TabIndex = 0;
            // 
            // tbCountGamburger
            // 
            this.tbCountGamburger.Location = new System.Drawing.Point(227, 64);
            this.tbCountGamburger.Name = "tbCountGamburger";
            this.tbCountGamburger.ReadOnly = true;
            this.tbCountGamburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCountGamburger.Size = new System.Drawing.Size(83, 20);
            this.tbCountGamburger.TabIndex = 17;
            this.tbCountGamburger.Text = "0";
            this.tbCountGamburger.TextChanged += new System.EventHandler(this.textCountProductsCafe_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(194, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "руб.";
            // 
            // tbGamburger
            // 
            this.tbGamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGamburger.Location = new System.Drawing.Point(107, 64);
            this.tbGamburger.Name = "tbGamburger";
            this.tbGamburger.ReadOnly = true;
            this.tbGamburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGamburger.Size = new System.Drawing.Size(83, 20);
            this.tbGamburger.TabIndex = 15;
            this.tbGamburger.Text = "4";
            // 
            // chkGamburger
            // 
            this.chkGamburger.AutoSize = true;
            this.chkGamburger.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkGamburger.Location = new System.Drawing.Point(21, 64);
            this.chkGamburger.Name = "chkGamburger";
            this.chkGamburger.Size = new System.Drawing.Size(80, 17);
            this.chkGamburger.TabIndex = 14;
            this.chkGamburger.Text = "Гамбургер";
            this.chkGamburger.UseVisualStyleBackColor = false;
            this.chkGamburger.CheckedChanged += new System.EventHandler(this.checkProductsCafe_CheckedChanged);
            // 
            // tbCountChizburger
            // 
            this.tbCountChizburger.Location = new System.Drawing.Point(227, 103);
            this.tbCountChizburger.Name = "tbCountChizburger";
            this.tbCountChizburger.ReadOnly = true;
            this.tbCountChizburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCountChizburger.Size = new System.Drawing.Size(83, 20);
            this.tbCountChizburger.TabIndex = 13;
            this.tbCountChizburger.Text = "0";
            this.tbCountChizburger.TextChanged += new System.EventHandler(this.textCountProductsCafe_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(194, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "руб.";
            // 
            // tbChizburger
            // 
            this.tbChizburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChizburger.Location = new System.Drawing.Point(105, 103);
            this.tbChizburger.Name = "tbChizburger";
            this.tbChizburger.ReadOnly = true;
            this.tbChizburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbChizburger.Size = new System.Drawing.Size(83, 20);
            this.tbChizburger.TabIndex = 11;
            this.tbChizburger.Text = "6";
            // 
            // chkChizburger
            // 
            this.chkChizburger.AutoSize = true;
            this.chkChizburger.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkChizburger.Location = new System.Drawing.Point(21, 105);
            this.chkChizburger.Name = "chkChizburger";
            this.chkChizburger.Size = new System.Drawing.Size(80, 17);
            this.chkChizburger.TabIndex = 10;
            this.chkChizburger.Text = "Чизбургер";
            this.chkChizburger.UseVisualStyleBackColor = false;
            this.chkChizburger.CheckedChanged += new System.EventHandler(this.checkProductsCafe_CheckedChanged);
            // 
            // tbCountCola
            // 
            this.tbCountCola.Location = new System.Drawing.Point(227, 146);
            this.tbCountCola.Name = "tbCountCola";
            this.tbCountCola.ReadOnly = true;
            this.tbCountCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCountCola.Size = new System.Drawing.Size(83, 20);
            this.tbCountCola.TabIndex = 9;
            this.tbCountCola.Text = "0";
            this.tbCountCola.TextChanged += new System.EventHandler(this.textCountProductsCafe_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(194, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "руб.";
            // 
            // tbCola
            // 
            this.tbCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCola.Location = new System.Drawing.Point(105, 146);
            this.tbCola.Name = "tbCola";
            this.tbCola.ReadOnly = true;
            this.tbCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCola.Size = new System.Drawing.Size(83, 20);
            this.tbCola.TabIndex = 7;
            this.tbCola.Text = "4,5";
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkCola.Location = new System.Drawing.Point(21, 148);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(78, 17);
            this.chkCola.TabIndex = 6;
            this.chkCola.Text = "Кока-кола";
            this.chkCola.UseVisualStyleBackColor = false;
            this.chkCola.CheckedChanged += new System.EventHandler(this.checkProductsCafe_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(234, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество";
            // 
            // tbCountHotDog
            // 
            this.tbCountHotDog.Location = new System.Drawing.Point(227, 23);
            this.tbCountHotDog.Name = "tbCountHotDog";
            this.tbCountHotDog.ReadOnly = true;
            this.tbCountHotDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCountHotDog.Size = new System.Drawing.Size(83, 20);
            this.tbCountHotDog.TabIndex = 4;
            this.tbCountHotDog.Text = "0";
            this.tbCountHotDog.TextChanged += new System.EventHandler(this.textCountProductsCafe_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(194, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "руб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(155, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // tbHotDog
            // 
            this.tbHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotDog.Location = new System.Drawing.Point(105, 25);
            this.tbHotDog.Name = "tbHotDog";
            this.tbHotDog.ReadOnly = true;
            this.tbHotDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHotDog.Size = new System.Drawing.Size(83, 20);
            this.tbHotDog.TabIndex = 1;
            this.tbHotDog.Text = "5";
            // 
            // chkHotDog
            // 
            this.chkHotDog.AutoSize = true;
            this.chkHotDog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkHotDog.Location = new System.Drawing.Point(21, 26);
            this.chkHotDog.Name = "chkHotDog";
            this.chkHotDog.Size = new System.Drawing.Size(64, 17);
            this.chkHotDog.TabIndex = 0;
            this.chkHotDog.Text = "Хот-дог";
            this.chkHotDog.UseVisualStyleBackColor = false;
            this.chkHotDog.CheckedChanged += new System.EventHandler(this.checkProductsCafe_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(57, 321);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 69);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnTotalPayment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(260, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 36);
            this.label12.TabIndex = 3;
            this.label12.Text = "ИТОГО:";
            // 
            // tbTotalPayment
            // 
            this.tbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalPayment.Location = new System.Drawing.Point(406, 323);
            this.tbTotalPayment.Name = "tbTotalPayment";
            this.tbTotalPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotalPayment.Size = new System.Drawing.Size(205, 53);
            this.tbTotalPayment.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 411);
            this.Controls.Add(this.tbTotalPayment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автозаправка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPaymentOil.ResumeLayout(false);
            this.grpPaymentOil.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceOil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFuels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbSumOil;
        private System.Windows.Forms.TextBox tbSumPriceOil;
        private System.Windows.Forms.RadioButton radSumOil;
        private System.Windows.Forms.Label lbCountOil;
        private System.Windows.Forms.TextBox tbCountOil;
        private System.Windows.Forms.RadioButton radCountOil;
        private System.Windows.Forms.GroupBox grpPaymentOil;
        private System.Windows.Forms.TextBox tbPaymentOil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountHotDog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHotDog;
        private System.Windows.Forms.CheckBox chkHotDog;
        private System.Windows.Forms.TextBox tbCountGamburger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbGamburger;
        private System.Windows.Forms.CheckBox chkGamburger;
        private System.Windows.Forms.TextBox tbCountChizburger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbChizburger;
        private System.Windows.Forms.CheckBox chkChizburger;
        private System.Windows.Forms.TextBox tbCountCola;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCola;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbPaymentCafe;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTotalPayment;
    }
}

