namespace Dershane
{
    partial class FrmAdvisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdvisorId = new System.Windows.Forms.TextBox();
            this.TxtAdvisorSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advisor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advisor Şifre : ";
            // 
            // TxtAdvisorId
            // 
            this.TxtAdvisorId.Location = new System.Drawing.Point(353, 128);
            this.TxtAdvisorId.Name = "TxtAdvisorId";
            this.TxtAdvisorId.Size = new System.Drawing.Size(177, 36);
            this.TxtAdvisorId.TabIndex = 2;
            // 
            // TxtAdvisorSifre
            // 
            this.TxtAdvisorSifre.Location = new System.Drawing.Point(353, 195);
            this.TxtAdvisorSifre.Name = "TxtAdvisorSifre";
            this.TxtAdvisorSifre.Size = new System.Drawing.Size(177, 36);
            this.TxtAdvisorSifre.TabIndex = 3;
            this.TxtAdvisorSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Advisor Giriş Sayfası";
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGiriş.Location = new System.Drawing.Point(353, 258);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(177, 47);
            this.BtnGiriş.TabIndex = 5;
            this.BtnGiriş.Text = "Giriş";
            this.BtnGiriş.UseVisualStyleBackColor = false;
            this.BtnGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(694, 344);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdvisorSifre);
            this.Controls.Add(this.TxtAdvisorId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdvisor";
            this.Text = "Advisor Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdvisorId;
        private System.Windows.Forms.TextBox TxtAdvisorSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiriş;
    }
}