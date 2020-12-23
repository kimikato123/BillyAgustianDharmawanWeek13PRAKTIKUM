namespace Tugas_week_14
{
    partial class Form1
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
            this.labelMasukanKalimat = new System.Windows.Forms.Label();
            this.labelMasukanHuruf = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.labelTulisanHasil = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.textBoxHurufPertama = new System.Windows.Forms.TextBox();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHurufKedua = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMasukanKalimat
            // 
            this.labelMasukanKalimat.AutoSize = true;
            this.labelMasukanKalimat.Location = new System.Drawing.Point(70, 34);
            this.labelMasukanKalimat.Name = "labelMasukanKalimat";
            this.labelMasukanKalimat.Size = new System.Drawing.Size(115, 17);
            this.labelMasukanKalimat.TabIndex = 0;
            this.labelMasukanKalimat.Text = "Masukan Kalimat";
            this.labelMasukanKalimat.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMasukanHuruf
            // 
            this.labelMasukanHuruf.AutoSize = true;
            this.labelMasukanHuruf.Location = new System.Drawing.Point(70, 71);
            this.labelMasukanHuruf.Name = "labelMasukanHuruf";
            this.labelMasukanHuruf.Size = new System.Drawing.Size(104, 17);
            this.labelMasukanHuruf.TabIndex = 1;
            this.labelMasukanHuruf.Text = "Masukan Huruf";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(348, 72);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(57, 17);
            this.labelMenjadi.TabIndex = 2;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // labelTulisanHasil
            // 
            this.labelTulisanHasil.AutoSize = true;
            this.labelTulisanHasil.Location = new System.Drawing.Point(70, 286);
            this.labelTulisanHasil.Name = "labelTulisanHasil";
            this.labelTulisanHasil.Size = new System.Drawing.Size(39, 17);
            this.labelTulisanHasil.TabIndex = 3;
            this.labelTulisanHasil.Text = "Hasil";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(245, 286);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(0, 17);
            this.labelFinal.TabIndex = 4;
            // 
            // textBoxHurufPertama
            // 
            this.textBoxHurufPertama.Location = new System.Drawing.Point(191, 66);
            this.textBoxHurufPertama.Name = "textBoxHurufPertama";
            this.textBoxHurufPertama.Size = new System.Drawing.Size(100, 22);
            this.textBoxHurufPertama.TabIndex = 5;
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(191, 31);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(226, 22);
            this.textBoxKalimat.TabIndex = 6;
            // 
            // textBoxHurufKedua
            // 
            this.textBoxHurufKedua.Location = new System.Drawing.Point(460, 69);
            this.textBoxHurufKedua.Name = "textBoxHurufKedua";
            this.textBoxHurufKedua.Size = new System.Drawing.Size(100, 22);
            this.textBoxHurufKedua.TabIndex = 7;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(167, 154);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(310, 24);
            this.buttonKonversi.TabIndex = 8;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxHurufKedua);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.textBoxHurufPertama);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.labelTulisanHasil);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelMasukanHuruf);
            this.Controls.Add(this.labelMasukanKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMasukanKalimat;
        private System.Windows.Forms.Label labelMasukanHuruf;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Label labelTulisanHasil;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.TextBox textBoxHurufPertama;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.TextBox textBoxHurufKedua;
        private System.Windows.Forms.Button buttonKonversi;
    }
}

