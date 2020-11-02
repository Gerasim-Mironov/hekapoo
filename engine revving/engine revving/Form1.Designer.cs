namespace engine_revving
{
    partial class Form1
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
            this.gasStation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.costButton = new System.Windows.Forms.RadioButton();
            this.amountButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priceForGas = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gasType = new System.Windows.Forms.Label();
            this.cafeteria = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.summary = new System.Windows.Forms.GroupBox();
            this.totalPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getCheck = new System.Windows.Forms.Button();
            this.gasStation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cafeteria.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gasStation
            // 
            this.gasStation.Controls.Add(this.groupBox1);
            this.gasStation.Controls.Add(this.textBox3);
            this.gasStation.Controls.Add(this.textBox2);
            this.gasStation.Controls.Add(this.panel1);
            this.gasStation.Controls.Add(this.textBox1);
            this.gasStation.Controls.Add(this.priceForGas);
            this.gasStation.Controls.Add(this.comboBox1);
            this.gasStation.Controls.Add(this.gasType);
            this.gasStation.Location = new System.Drawing.Point(12, 27);
            this.gasStation.Name = "gasStation";
            this.gasStation.Size = new System.Drawing.Size(293, 337);
            this.gasStation.TabIndex = 0;
            this.gasStation.TabStop = false;
            this.gasStation.Text = "Gas Station";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.costButton);
            this.panel1.Controls.Add(this.amountButton);
            this.panel1.Location = new System.Drawing.Point(21, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 100);
            this.panel1.TabIndex = 4;
            // 
            // costButton
            // 
            this.costButton.AutoSize = true;
            this.costButton.Location = new System.Drawing.Point(12, 66);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(45, 17);
            this.costButton.TabIndex = 1;
            this.costButton.TabStop = true;
            this.costButton.Text = "cost";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.CheckedChanged += new System.EventHandler(this.costButton_CheckedChanged);
            // 
            // amountButton
            // 
            this.amountButton.AutoSize = true;
            this.amountButton.Location = new System.Drawing.Point(12, 13);
            this.amountButton.Name = "amountButton";
            this.amountButton.Size = new System.Drawing.Size(60, 17);
            this.amountButton.TabIndex = 0;
            this.amountButton.TabStop = true;
            this.amountButton.Text = "amount";
            this.amountButton.UseVisualStyleBackColor = true;
            this.amountButton.CheckedChanged += new System.EventHandler(this.amountButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // priceForGas
            // 
            this.priceForGas.AutoSize = true;
            this.priceForGas.Location = new System.Drawing.Point(21, 106);
            this.priceForGas.Name = "priceForGas";
            this.priceForGas.Size = new System.Drawing.Size(31, 13);
            this.priceForGas.TabIndex = 2;
            this.priceForGas.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gasType
            // 
            this.gasType.AutoSize = true;
            this.gasType.Location = new System.Drawing.Point(21, 43);
            this.gasType.Name = "gasType";
            this.gasType.Size = new System.Drawing.Size(53, 13);
            this.gasType.TabIndex = 0;
            this.gasType.Text = "Gas Type";
            // 
            // cafeteria
            // 
            this.cafeteria.Controls.Add(this.label2);
            this.cafeteria.Controls.Add(this.label1);
            this.cafeteria.Controls.Add(this.groupBox2);
            this.cafeteria.Controls.Add(this.textBox10);
            this.cafeteria.Controls.Add(this.textBox11);
            this.cafeteria.Controls.Add(this.textBox8);
            this.cafeteria.Controls.Add(this.textBox9);
            this.cafeteria.Controls.Add(this.textBox6);
            this.cafeteria.Controls.Add(this.textBox7);
            this.cafeteria.Controls.Add(this.textBox5);
            this.cafeteria.Controls.Add(this.textBox4);
            this.cafeteria.Controls.Add(this.checkBox4);
            this.cafeteria.Controls.Add(this.checkBox3);
            this.cafeteria.Controls.Add(this.checkBox2);
            this.cafeteria.Controls.Add(this.checkBox1);
            this.cafeteria.Location = new System.Drawing.Point(405, 27);
            this.cafeteria.Name = "cafeteria";
            this.cafeteria.Size = new System.Drawing.Size(294, 337);
            this.cafeteria.TabIndex = 1;
            this.cafeteria.TabStop = false;
            this.cafeteria.Text = "Cafeteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 68);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(219, 155);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(69, 20);
            this.textBox10.TabIndex = 11;
            this.textBox10.Text = "0";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(130, 154);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(69, 20);
            this.textBox11.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(219, 123);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(69, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(130, 122);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(69, 20);
            this.textBox9.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(219, 85);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(69, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(130, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(69, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(219, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(69, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(69, 20);
            this.textBox4.TabIndex = 4;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 122);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // summary
            // 
            this.summary.Controls.Add(this.totalPrice);
            this.summary.Controls.Add(this.pictureBox1);
            this.summary.Controls.Add(this.getCheck);
            this.summary.Location = new System.Drawing.Point(12, 391);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(687, 115);
            this.summary.TabIndex = 3;
            this.summary.TabStop = false;
            this.summary.Text = "Summary";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(520, 57);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(51, 13);
            this.totalPrice.TabIndex = 2;
            this.totalPrice.Text = "/0/0/0/0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::engine_revving.Properties.Resources.punk;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // getCheck
            // 
            this.getCheck.Location = new System.Drawing.Point(166, 35);
            this.getCheck.Name = "getCheck";
            this.getCheck.Size = new System.Drawing.Size(167, 57);
            this.getCheck.TabIndex = 0;
            this.getCheck.Text = "get check";
            this.getCheck.UseVisualStyleBackColor = true;
            this.getCheck.Click += new System.EventHandler(this.getCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 529);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.cafeteria);
            this.Controls.Add(this.gasStation);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.gasStation.ResumeLayout(false);
            this.gasStation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cafeteria.ResumeLayout(false);
            this.cafeteria.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gasStation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label priceForGas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label gasType;
        private System.Windows.Forms.GroupBox cafeteria;
        private System.Windows.Forms.GroupBox summary;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button getCheck;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton costButton;
        private System.Windows.Forms.RadioButton amountButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

