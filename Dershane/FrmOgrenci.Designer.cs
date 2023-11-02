namespace Dershane
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciID = new System.Windows.Forms.TextBox();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Şifre :";
            // 
            // TxtOgrenciID
            // 
            this.TxtOgrenciID.Location = new System.Drawing.Point(361, 151);
            this.TxtOgrenciID.Name = "TxtOgrenciID";
            this.TxtOgrenciID.Size = new System.Drawing.Size(186, 36);
            this.TxtOgrenciID.TabIndex = 2;
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(361, 213);
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(186, 36);
            this.TxtOgrenciSifre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 79);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Giriş Sayfası";
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGiriş.Location = new System.Drawing.Point(361, 283);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(186, 53);
            this.BtnGiriş.TabIndex = 5;
            this.BtnGiriş.Text = "Giriş";
            this.BtnGiriş.UseVisualStyleBackColor = false;
            this.BtnGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrenciSifre);
            this.Controls.Add(this.TxtOgrenciID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenci";
            this.Text = "Öğrenci Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciID;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}