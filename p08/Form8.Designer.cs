namespace p08
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRealShit = new System.Windows.Forms.Button();
            this.buttonISleep = new System.Windows.Forms.Button();
            this.buttonKowalskiAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "karel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "zadat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRealShit
            // 
            this.buttonRealShit.Location = new System.Drawing.Point(163, 87);
            this.buttonRealShit.Name = "buttonRealShit";
            this.buttonRealShit.Size = new System.Drawing.Size(75, 23);
            this.buttonRealShit.TabIndex = 2;
            this.buttonRealShit.Text = "běhej";
            this.buttonRealShit.UseVisualStyleBackColor = true;
            this.buttonRealShit.Click += new System.EventHandler(this.buttonRealShit_Click);
            // 
            // buttonISleep
            // 
            this.buttonISleep.Location = new System.Drawing.Point(163, 116);
            this.buttonISleep.Name = "buttonISleep";
            this.buttonISleep.Size = new System.Drawing.Size(75, 23);
            this.buttonISleep.TabIndex = 3;
            this.buttonISleep.Text = "spi";
            this.buttonISleep.UseVisualStyleBackColor = true;
            this.buttonISleep.Click += new System.EventHandler(this.buttonISleep_Click);
            // 
            // buttonKowalskiAnalysis
            // 
            this.buttonKowalskiAnalysis.Location = new System.Drawing.Point(163, 145);
            this.buttonKowalskiAnalysis.Name = "buttonKowalskiAnalysis";
            this.buttonKowalskiAnalysis.Size = new System.Drawing.Size(75, 23);
            this.buttonKowalskiAnalysis.TabIndex = 4;
            this.buttonKowalskiAnalysis.Text = "stav";
            this.buttonKowalskiAnalysis.UseVisualStyleBackColor = true;
            this.buttonKowalskiAnalysis.Click += new System.EventHandler(this.buttonKowalskiAnalysis_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKowalskiAnalysis);
            this.Controls.Add(this.buttonISleep);
            this.Controls.Add(this.buttonRealShit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form8";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRealShit;
        private System.Windows.Forms.Button buttonISleep;
        private System.Windows.Forms.Button buttonKowalskiAnalysis;
    }
}

