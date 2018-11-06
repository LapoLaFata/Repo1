namespace EsGitLapo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbMax = new System.Windows.Forms.TextBox();
            this.txtbMin = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbArray = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.bCreaArray = new System.Windows.Forms.Button();
            this.bCalcolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbMax
            // 
            this.txtbMax.Location = new System.Drawing.Point(118, 97);
            this.txtbMax.Name = "txtbMax";
            this.txtbMax.Size = new System.Drawing.Size(100, 20);
            this.txtbMax.TabIndex = 0;
            // 
            // txtbMin
            // 
            this.txtbMin.Location = new System.Drawing.Point(118, 144);
            this.txtbMin.Name = "txtbMin";
            this.txtbMin.Size = new System.Drawing.Size(100, 20);
            this.txtbMin.TabIndex = 1;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(85, 100);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(27, 13);
            this.lbMax.TabIndex = 2;
            this.lbMax.Text = "Max";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(85, 147);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(24, 13);
            this.lbMin.TabIndex = 3;
            this.lbMin.Text = "Min";
            this.lbMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbArray
            // 
            this.lbArray.AutoSize = true;
            this.lbArray.Location = new System.Drawing.Point(3, 29);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(31, 13);
            this.lbArray.TabIndex = 5;
            this.lbArray.Text = "Array";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(170, 26);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(196, 26);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(222, 26);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(20, 20);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(248, 26);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(20, 20);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(274, 26);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(20, 20);
            this.textBox10.TabIndex = 15;
            // 
            // bCreaArray
            // 
            this.bCreaArray.Location = new System.Drawing.Point(66, 189);
            this.bCreaArray.Name = "bCreaArray";
            this.bCreaArray.Size = new System.Drawing.Size(75, 23);
            this.bCreaArray.TabIndex = 16;
            this.bCreaArray.Text = "Crea Array";
            this.bCreaArray.UseVisualStyleBackColor = true;
            this.bCreaArray.Click += new System.EventHandler(this.bCreaArray_Click);
            // 
            // bCalcolo
            // 
            this.bCalcolo.Location = new System.Drawing.Point(167, 189);
            this.bCalcolo.Name = "bCalcolo";
            this.bCalcolo.Size = new System.Drawing.Size(75, 23);
            this.bCalcolo.TabIndex = 17;
            this.bCalcolo.Text = "Calcolo";
            this.bCalcolo.UseVisualStyleBackColor = true;
            this.bCalcolo.Click += new System.EventHandler(this.bCalcolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.bCalcolo);
            this.Controls.Add(this.bCreaArray);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.txtbMin);
            this.Controls.Add(this.txtbMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbMax;
        private System.Windows.Forms.TextBox txtbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbArray;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button bCreaArray;
        private System.Windows.Forms.Button bCalcolo;
    }
}

