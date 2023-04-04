namespace BiletCekilisUygulama
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnControl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBiletNoDogrulama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSahipAdi = new System.Windows.Forms.TextBox();
            this.txtSahipSoyadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.Gold;
            this.btnControl.Location = new System.Drawing.Point(111, 81);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(164, 23);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Kontrol Ediniz !";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aldığınız 6 Haneli Numarayı Giriniz :";
            // 
            // txtBiletNoDogrulama
            // 
            this.txtBiletNoDogrulama.Location = new System.Drawing.Point(226, 37);
            this.txtBiletNoDogrulama.Name = "txtBiletNoDogrulama";
            this.txtBiletNoDogrulama.Size = new System.Drawing.Size(100, 20);
            this.txtBiletNoDogrulama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bilet Sahibinin Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bilet Sahibinin Soyadı :";
            // 
            // txtSahipAdi
            // 
            this.txtSahipAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSahipAdi.Location = new System.Drawing.Point(191, 134);
            this.txtSahipAdi.Name = "txtSahipAdi";
            this.txtSahipAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSahipAdi.TabIndex = 4;
            // 
            // txtSahipSoyadi
            // 
            this.txtSahipSoyadi.Location = new System.Drawing.Point(191, 161);
            this.txtSahipSoyadi.Name = "txtSahipSoyadi";
            this.txtSahipSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSahipSoyadi.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 238);
            this.Controls.Add(this.txtSahipSoyadi);
            this.Controls.Add(this.txtSahipAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBiletNoDogrulama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtBiletNoDogrulama;
        public System.Windows.Forms.TextBox txtSahipAdi;
        public System.Windows.Forms.TextBox txtSahipSoyadi;
    }
}