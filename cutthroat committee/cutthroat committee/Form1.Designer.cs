namespace cutthroat_committee
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
            this.okButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.yearButton = new System.Windows.Forms.RadioButton();
            this.monthsButton = new System.Windows.Forms.RadioButton();
            this.daysButton = new System.Windows.Forms.RadioButton();
            this.minutesButton = new System.Windows.Forms.RadioButton();
            this.secondsButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Location = new System.Drawing.Point(311, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(392, 219);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(311, 293);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(156, 20);
            this.result.TabIndex = 3;
            // 
            // yearButton
            // 
            this.yearButton.AutoSize = true;
            this.yearButton.Location = new System.Drawing.Point(335, 9);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(62, 17);
            this.yearButton.TabIndex = 4;
            this.yearButton.TabStop = true;
            this.yearButton.Text = "In years";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // monthsButton
            // 
            this.monthsButton.AutoSize = true;
            this.monthsButton.Location = new System.Drawing.Point(335, 44);
            this.monthsButton.Name = "monthsButton";
            this.monthsButton.Size = new System.Drawing.Size(71, 17);
            this.monthsButton.TabIndex = 5;
            this.monthsButton.TabStop = true;
            this.monthsButton.Text = "In months";
            this.monthsButton.UseVisualStyleBackColor = true;
            // 
            // daysButton
            // 
            this.daysButton.AutoSize = true;
            this.daysButton.Location = new System.Drawing.Point(335, 79);
            this.daysButton.Name = "daysButton";
            this.daysButton.Size = new System.Drawing.Size(59, 17);
            this.daysButton.TabIndex = 6;
            this.daysButton.TabStop = true;
            this.daysButton.Text = "In days";
            this.daysButton.UseVisualStyleBackColor = true;
            // 
            // minutesButton
            // 
            this.minutesButton.AutoSize = true;
            this.minutesButton.Location = new System.Drawing.Point(335, 116);
            this.minutesButton.Name = "minutesButton";
            this.minutesButton.Size = new System.Drawing.Size(67, 17);
            this.minutesButton.TabIndex = 7;
            this.minutesButton.TabStop = true;
            this.minutesButton.Text = "In mintes";
            this.minutesButton.UseVisualStyleBackColor = true;
            // 
            // secondsButton
            // 
            this.secondsButton.AutoSize = true;
            this.secondsButton.Location = new System.Drawing.Point(335, 156);
            this.secondsButton.Name = "secondsButton";
            this.secondsButton.Size = new System.Drawing.Size(77, 17);
            this.secondsButton.TabIndex = 8;
            this.secondsButton.TabStop = true;
            this.secondsButton.Text = "In seconds";
            this.secondsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cutthroat_committee.Properties.Resources.skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondsButton);
            this.Controls.Add(this.minutesButton);
            this.Controls.Add(this.daysButton);
            this.Controls.Add(this.monthsButton);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.okButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "time span";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.RadioButton yearButton;
        private System.Windows.Forms.RadioButton monthsButton;
        private System.Windows.Forms.RadioButton daysButton;
        private System.Windows.Forms.RadioButton minutesButton;
        private System.Windows.Forms.RadioButton secondsButton;
    }
}

