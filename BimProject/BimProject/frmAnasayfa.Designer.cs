
namespace BimProject
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.AdminSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.btnAdminListele = new System.Windows.Forms.Button();
            this.btnAdminYonetimi = new System.Windows.Forms.Button();
            this.KategoriSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnMarkaListele = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriListele = new System.Windows.Forms.Button();
            this.btnKategoriYonetimi = new System.Windows.Forms.Button();
            this.UrunSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.AdminSubMenuPanel.SuspendLayout();
            this.KategoriSubMenuPanel.SuspendLayout();
            this.UrunSubMenuPanel.SuspendLayout();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.AdminSubMenuPanel);
            this.panelSideMenu.Controls.Add(this.btnAdminYonetimi);
            this.panelSideMenu.Controls.Add(this.KategoriSubMenuPanel);
            this.panelSideMenu.Controls.Add(this.btnKategoriYonetimi);
            this.panelSideMenu.Controls.Add(this.UrunSubMenuPanel);
            this.panelSideMenu.Controls.Add(this.btnUrunYonetimi);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(375, 542);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // AdminSubMenuPanel
            // 
            this.AdminSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.AdminSubMenuPanel.Controls.Add(this.btnAdminEkle);
            this.AdminSubMenuPanel.Controls.Add(this.btnAdminListele);
            this.AdminSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminSubMenuPanel.Location = new System.Drawing.Point(0, 643);
            this.AdminSubMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AdminSubMenuPanel.Name = "AdminSubMenuPanel";
            this.AdminSubMenuPanel.Size = new System.Drawing.Size(358, 126);
            this.AdminSubMenuPanel.TabIndex = 5;
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminEkle.FlatAppearance.BorderSize = 0;
            this.btnAdminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdminEkle.Location = new System.Drawing.Point(0, 55);
            this.btnAdminEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnAdminEkle.Size = new System.Drawing.Size(358, 62);
            this.btnAdminEkle.TabIndex = 2;
            this.btnAdminEkle.Text = "Yönetici Ekle";
            this.btnAdminEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEkle.UseVisualStyleBackColor = true;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // btnAdminListele
            // 
            this.btnAdminListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminListele.FlatAppearance.BorderSize = 0;
            this.btnAdminListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminListele.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdminListele.Location = new System.Drawing.Point(0, 0);
            this.btnAdminListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminListele.Name = "btnAdminListele";
            this.btnAdminListele.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnAdminListele.Size = new System.Drawing.Size(358, 55);
            this.btnAdminListele.TabIndex = 1;
            this.btnAdminListele.Text = "Yönetici Listele";
            this.btnAdminListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminListele.UseVisualStyleBackColor = true;
            this.btnAdminListele.Click += new System.EventHandler(this.btnAdminListele_Click);
            // 
            // btnAdminYonetimi
            // 
            this.btnAdminYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminYonetimi.FlatAppearance.BorderSize = 0;
            this.btnAdminYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminYonetimi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminYonetimi.Location = new System.Drawing.Point(0, 588);
            this.btnAdminYonetimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminYonetimi.Name = "btnAdminYonetimi";
            this.btnAdminYonetimi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdminYonetimi.Size = new System.Drawing.Size(358, 55);
            this.btnAdminYonetimi.TabIndex = 4;
            this.btnAdminYonetimi.Text = "Admin Yönetimi";
            this.btnAdminYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminYonetimi.UseVisualStyleBackColor = true;
            this.btnAdminYonetimi.Click += new System.EventHandler(this.btnAdminYonetimi_Click);
            // 
            // KategoriSubMenuPanel
            // 
            this.KategoriSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.KategoriSubMenuPanel.Controls.Add(this.btnMarkaEkle);
            this.KategoriSubMenuPanel.Controls.Add(this.btnMarkaListele);
            this.KategoriSubMenuPanel.Controls.Add(this.btnKategoriEkle);
            this.KategoriSubMenuPanel.Controls.Add(this.btnKategoriListele);
            this.KategoriSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KategoriSubMenuPanel.Location = new System.Drawing.Point(0, 357);
            this.KategoriSubMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.KategoriSubMenuPanel.Name = "KategoriSubMenuPanel";
            this.KategoriSubMenuPanel.Size = new System.Drawing.Size(358, 231);
            this.KategoriSubMenuPanel.TabIndex = 3;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarkaEkle.FlatAppearance.BorderSize = 0;
            this.btnMarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnMarkaEkle.Location = new System.Drawing.Point(0, 168);
            this.btnMarkaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnMarkaEkle.Size = new System.Drawing.Size(358, 55);
            this.btnMarkaEkle.TabIndex = 4;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnMarkaListele
            // 
            this.btnMarkaListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarkaListele.FlatAppearance.BorderSize = 0;
            this.btnMarkaListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaListele.ForeColor = System.Drawing.Color.LightGray;
            this.btnMarkaListele.Location = new System.Drawing.Point(0, 113);
            this.btnMarkaListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkaListele.Name = "btnMarkaListele";
            this.btnMarkaListele.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnMarkaListele.Size = new System.Drawing.Size(358, 55);
            this.btnMarkaListele.TabIndex = 3;
            this.btnMarkaListele.Text = "Marka Listele";
            this.btnMarkaListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkaListele.UseVisualStyleBackColor = true;
            this.btnMarkaListele.Click += new System.EventHandler(this.btnMarkaListele_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategoriEkle.FlatAppearance.BorderSize = 0;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnKategoriEkle.Location = new System.Drawing.Point(0, 55);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnKategoriEkle.Size = new System.Drawing.Size(358, 58);
            this.btnKategoriEkle.TabIndex = 2;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriListele
            // 
            this.btnKategoriListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategoriListele.FlatAppearance.BorderSize = 0;
            this.btnKategoriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriListele.ForeColor = System.Drawing.Color.LightGray;
            this.btnKategoriListele.Location = new System.Drawing.Point(0, 0);
            this.btnKategoriListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriListele.Name = "btnKategoriListele";
            this.btnKategoriListele.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnKategoriListele.Size = new System.Drawing.Size(358, 55);
            this.btnKategoriListele.TabIndex = 1;
            this.btnKategoriListele.Text = "Kategori Listele";
            this.btnKategoriListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriListele.UseVisualStyleBackColor = true;
            this.btnKategoriListele.Click += new System.EventHandler(this.btnKategoriListele_Click);
            // 
            // btnKategoriYonetimi
            // 
            this.btnKategoriYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategoriYonetimi.FlatAppearance.BorderSize = 0;
            this.btnKategoriYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriYonetimi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKategoriYonetimi.Location = new System.Drawing.Point(0, 302);
            this.btnKategoriYonetimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriYonetimi.Name = "btnKategoriYonetimi";
            this.btnKategoriYonetimi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKategoriYonetimi.Size = new System.Drawing.Size(358, 55);
            this.btnKategoriYonetimi.TabIndex = 2;
            this.btnKategoriYonetimi.Text = "Kategori Yönetimi";
            this.btnKategoriYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriYonetimi.UseVisualStyleBackColor = true;
            this.btnKategoriYonetimi.Click += new System.EventHandler(this.btnKategoriYonetimi_Click);
            // 
            // UrunSubMenuPanel
            // 
            this.UrunSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.UrunSubMenuPanel.Controls.Add(this.btnUrunEkle);
            this.UrunSubMenuPanel.Controls.Add(this.btnUrunListele);
            this.UrunSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UrunSubMenuPanel.Location = new System.Drawing.Point(0, 178);
            this.UrunSubMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UrunSubMenuPanel.Name = "UrunSubMenuPanel";
            this.UrunSubMenuPanel.Size = new System.Drawing.Size(358, 124);
            this.UrunSubMenuPanel.TabIndex = 1;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.ForeColor = System.Drawing.Color.LightGray;
            this.btnUrunEkle.Location = new System.Drawing.Point(0, 55);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnUrunEkle.Size = new System.Drawing.Size(358, 62);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunListele.FlatAppearance.BorderSize = 0;
            this.btnUrunListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunListele.ForeColor = System.Drawing.Color.LightGray;
            this.btnUrunListele.Location = new System.Drawing.Point(0, 0);
            this.btnUrunListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnUrunListele.Size = new System.Drawing.Size(358, 55);
            this.btnUrunListele.TabIndex = 1;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrunYonetimi.FlatAppearance.BorderSize = 0;
            this.btnUrunYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunYonetimi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUrunYonetimi.Location = new System.Drawing.Point(0, 123);
            this.btnUrunYonetimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUrunYonetimi.Size = new System.Drawing.Size(358, 55);
            this.btnUrunYonetimi.TabIndex = 1;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 123);
            this.panel1.TabIndex = 1;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChild.Controls.Add(this.pictureBox1);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(375, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(709, 542);
            this.panelChild.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 542);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.AdminSubMenuPanel.ResumeLayout(false);
            this.KategoriSubMenuPanel.ResumeLayout(false);
            this.UrunSubMenuPanel.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel UrunSubMenuPanel;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnKategoriYonetimi;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriListele;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Button btnMarkaListele;
        private System.Windows.Forms.Panel AdminSubMenuPanel;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.Button btnAdminListele;
        private System.Windows.Forms.Button btnAdminYonetimi;
        private System.Windows.Forms.Panel KategoriSubMenuPanel;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}