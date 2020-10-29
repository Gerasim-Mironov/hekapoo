namespace first_task
{
    partial class FormingHorns
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
            this.hell_o = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guess.SuspendLayout();
            this.SuspendLayout();
            // 
            // hell_o
            // 
            this.hell_o.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hell_o.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hell_o.Location = new System.Drawing.Point(39, 103);
            this.hell_o.Name = "hell_o";
            this.hell_o.Size = new System.Drawing.Size(121, 52);
            this.hell_o.TabIndex = 0;
            this.hell_o.Text = "hell o";
            this.hell_o.UseVisualStyleBackColor = true;
            this.hell_o.Click += new System.EventHandler(this.hell_o_Click);
            // 
            // guess
            // 
            this.guess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guess.Controls.Add(this.textBox1);
            this.guess.Location = new System.Drawing.Point(533, 103);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(195, 172);
            this.guess.TabIndex = 1;
            this.guess.TabStop = false;
            this.guess.Text = "guess";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormingHorns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::first_task.Properties.Resources.hekapoo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.hell_o);
            this.Name = "FormingHorns";
            this.Text = "Forming Horns";
            this.guess.ResumeLayout(false);
            this.guess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hell_o;
        private System.Windows.Forms.GroupBox guess;
        private System.Windows.Forms.TextBox textBox1;
    }
}

