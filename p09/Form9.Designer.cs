namespace p09
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonJed = new System.Windows.Forms.Button();
            this.buttonZast = new System.Windows.Forms.Button();
            this.buttonState = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Renault";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Značka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spotřeba";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6,2";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(204, 37);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonJed
            // 
            this.buttonJed.Location = new System.Drawing.Point(204, 90);
            this.buttonJed.Name = "buttonJed";
            this.buttonJed.Size = new System.Drawing.Size(75, 23);
            this.buttonJed.TabIndex = 5;
            this.buttonJed.Text = "Jeď";
            this.buttonJed.UseVisualStyleBackColor = true;
            this.buttonJed.Click += new System.EventHandler(this.buttonJed_Click);
            // 
            // buttonZast
            // 
            this.buttonZast.Location = new System.Drawing.Point(204, 119);
            this.buttonZast.Name = "buttonZast";
            this.buttonZast.Size = new System.Drawing.Size(75, 23);
            this.buttonZast.TabIndex = 6;
            this.buttonZast.Text = "Zastav";
            this.buttonZast.UseVisualStyleBackColor = true;
            this.buttonZast.Click += new System.EventHandler(this.buttonZast_Click);
            // 
            // buttonState
            // 
            this.buttonState.Location = new System.Drawing.Point(204, 148);
            this.buttonState.Name = "buttonState";
            this.buttonState.Size = new System.Drawing.Size(75, 23);
            this.buttonState.TabIndex = 7;
            this.buttonState.Text = "Stav";
            this.buttonState.UseVisualStyleBackColor = true;
            this.buttonState.Click += new System.EventHandler(this.buttonState_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Najel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonState);
            this.Controls.Add(this.buttonZast);
            this.Controls.Add(this.buttonJed);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonJed;
        private System.Windows.Forms.Button buttonZast;
        private System.Windows.Forms.Button buttonState;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

