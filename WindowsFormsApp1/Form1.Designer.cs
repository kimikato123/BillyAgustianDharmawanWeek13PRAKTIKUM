namespace WindowsFormsApp1
{
    partial class FormPWarna
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
            this.labelInputData = new System.Windows.Forms.Label();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(74, 19);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(81, 17);
            this.labelInputData.TabIndex = 0;
            this.labelInputData.Text = "Input Data :";
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(77, 39);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(292, 22);
            this.textBoxnama.TabIndex = 1;
            this.textBoxnama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(77, 80);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(75, 23);
            this.buttonProses.TabIndex = 2;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(74, 118);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(63, 17);
            this.labelHasil.TabIndex = 3;
            this.labelHasil.Text = "[EMPTY]";
            // 
            // FormPWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.labelInputData);
            this.Name = "FormPWarna";
            this.Text = "Form Pengaturan Warna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelHasil;
    }
}

