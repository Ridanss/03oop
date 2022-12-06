namespace p03
{
    partial class Form3
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelVypis1 = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVypis2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "tohle  je moje   věta takže si  ji užij";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(348, 42);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelVypis1
            // 
            this.labelVypis1.AutoSize = true;
            this.labelVypis1.Location = new System.Drawing.Point(47, 132);
            this.labelVypis1.Name = "labelVypis1";
            this.labelVypis1.Size = new System.Drawing.Size(46, 13);
            this.labelVypis1.TabIndex = 2;
            this.labelVypis1.Text = "1. výpis:";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Location = new System.Drawing.Point(47, 193);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(59, 13);
            this.labelWordCount.TabIndex = 3;
            this.labelWordCount.Text = "počet slov:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "smazat:\r\n(znak)";
            // 
            // labelVypis2
            // 
            this.labelVypis2.AutoSize = true;
            this.labelVypis2.Location = new System.Drawing.Point(47, 156);
            this.labelVypis2.Name = "labelVypis2";
            this.labelVypis2.Size = new System.Drawing.Size(46, 13);
            this.labelVypis2.TabIndex = 7;
            this.labelVypis2.Text = "2. výpis:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVypis2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelVypis1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelVypis1;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVypis2;
    }
}

