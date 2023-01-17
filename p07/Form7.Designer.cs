namespace p07
{
    partial class Form7
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
            this.textBoxSpz = new System.Windows.Forms.TextBox();
            this.textBoxNosnost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonNalozit = new System.Windows.Forms.RadioButton();
            this.radioButtonVylozit = new System.Windows.Forms.RadioButton();
            this.buttonVylNal = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSpz
            // 
            this.textBoxSpz.Location = new System.Drawing.Point(86, 45);
            this.textBoxSpz.Name = "textBoxSpz";
            this.textBoxSpz.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpz.TabIndex = 0;
            this.textBoxSpz.Text = "6J5 14A56";
            // 
            // textBoxNosnost
            // 
            this.textBoxNosnost.Location = new System.Drawing.Point(86, 71);
            this.textBoxNosnost.Name = "textBoxNosnost";
            this.textBoxNosnost.Size = new System.Drawing.Size(100, 20);
            this.textBoxNosnost.TabIndex = 1;
            this.textBoxNosnost.Text = "1,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "spz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "nosnost\r\n(tun)";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(208, 48);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButtonNalozit
            // 
            this.radioButtonNalozit.AutoSize = true;
            this.radioButtonNalozit.Checked = true;
            this.radioButtonNalozit.Location = new System.Drawing.Point(86, 182);
            this.radioButtonNalozit.Name = "radioButtonNalozit";
            this.radioButtonNalozit.Size = new System.Drawing.Size(57, 17);
            this.radioButtonNalozit.TabIndex = 6;
            this.radioButtonNalozit.TabStop = true;
            this.radioButtonNalozit.Text = "Naložit";
            this.radioButtonNalozit.UseVisualStyleBackColor = true;
            // 
            // radioButtonVylozit
            // 
            this.radioButtonVylozit.AutoSize = true;
            this.radioButtonVylozit.Location = new System.Drawing.Point(86, 205);
            this.radioButtonVylozit.Name = "radioButtonVylozit";
            this.radioButtonVylozit.Size = new System.Drawing.Size(55, 17);
            this.radioButtonVylozit.TabIndex = 7;
            this.radioButtonVylozit.Text = "Vyložit";
            this.radioButtonVylozit.UseVisualStyleBackColor = true;
            // 
            // buttonVylNal
            // 
            this.buttonVylNal.Location = new System.Drawing.Point(208, 149);
            this.buttonVylNal.Name = "buttonVylNal";
            this.buttonVylNal.Size = new System.Drawing.Size(75, 23);
            this.buttonVylNal.TabIndex = 8;
            this.buttonVylNal.Text = "zadat";
            this.buttonVylNal.UseVisualStyleBackColor = true;
            this.buttonVylNal.Click += new System.EventHandler(this.buttonVylNal_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(360, 93);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "vypsat";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonVylNal);
            this.Controls.Add(this.radioButtonVylozit);
            this.Controls.Add(this.radioButtonNalozit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNosnost);
            this.Controls.Add(this.textBoxSpz);
            this.Name = "Form7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSpz;
        private System.Windows.Forms.TextBox textBoxNosnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonNalozit;
        private System.Windows.Forms.RadioButton radioButtonVylozit;
        private System.Windows.Forms.Button buttonVylNal;
        private System.Windows.Forms.Button buttonShow;
    }
}

