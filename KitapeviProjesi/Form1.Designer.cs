namespace KitapeviProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.girisGorsel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.girisGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(12, 250);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(200, 20);
            this.kullaniciAdiTextBox.TabIndex = 0;
            this.kullaniciAdiTextBox.Tag = "Kullanıcı Adı";
            this.kullaniciAdiTextBox.Text = "Kullanıcı Adı";
            this.kullaniciAdiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullaniciAdiTextBox.TextChanged += new System.EventHandler(this.kullaniciAdiTextBox_TextChanged);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(12, 288);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(200, 20);
            this.sifreTextBox.TabIndex = 1;
            this.sifreTextBox.Tag = "Şifre";
            this.sifreTextBox.Text = "Şifre";
            this.sifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifreTextBox.TextChanged += new System.EventHandler(this.sifreTextBox_TextChanged);
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.girisButton.Location = new System.Drawing.Point(76, 333);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(75, 25);
            this.girisButton.TabIndex = 2;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // girisGorsel
            // 
            this.girisGorsel.Image = global::KitapeviProjesi.Properties.Resources.user;
            this.girisGorsel.Location = new System.Drawing.Point(12, 12);
            this.girisGorsel.Name = "girisGorsel";
            this.girisGorsel.Size = new System.Drawing.Size(200, 200);
            this.girisGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girisGorsel.TabIndex = 3;
            this.girisGorsel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(218, 370);
            this.Controls.Add(this.girisGorsel);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitabevi Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.girisGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.PictureBox girisGorsel;
    }
}

