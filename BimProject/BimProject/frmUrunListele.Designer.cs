
namespace BimProject
{
    partial class frmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.barkodNoTxtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.urunMarkacBox = new System.Windows.Forms.ComboBox();
            this.urunKategoriCBox = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rafOmruTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.satisFiyatTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.alisFiyatTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gramajTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.miktarTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barkodNoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 351);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod numarasına göre ara";
            // 
            // barkodNoTxtSearch
            // 
            this.barkodNoTxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.barkodNoTxtSearch.Location = new System.Drawing.Point(368, 41);
            this.barkodNoTxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barkodNoTxtSearch.Name = "barkodNoTxtSearch";
            this.barkodNoTxtSearch.Size = new System.Drawing.Size(186, 23);
            this.barkodNoTxtSearch.TabIndex = 6;
            this.barkodNoTxtSearch.TextChanged += new System.EventHandler(this.barkodNoTxtSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1101, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 52;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunMarkacBox
            // 
            this.urunMarkacBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.urunMarkacBox.FormattingEnabled = true;
            this.urunMarkacBox.Location = new System.Drawing.Point(1038, 110);
            this.urunMarkacBox.Name = "urunMarkacBox";
            this.urunMarkacBox.Size = new System.Drawing.Size(140, 23);
            this.urunMarkacBox.TabIndex = 51;
            // 
            // urunKategoriCBox
            // 
            this.urunKategoriCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.urunKategoriCBox.FormattingEnabled = true;
            this.urunKategoriCBox.Location = new System.Drawing.Point(1038, 74);
            this.urunKategoriCBox.Name = "urunKategoriCBox";
            this.urunKategoriCBox.Size = new System.Drawing.Size(140, 23);
            this.urunKategoriCBox.TabIndex = 50;
            this.urunKategoriCBox.SelectedIndexChanged += new System.EventHandler(this.urunKategoriCBox_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(970, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 46);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Ürün Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(962, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Raf Ömrü";
            // 
            // rafOmruTxt
            // 
            this.rafOmruTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.rafOmruTxt.Location = new System.Drawing.Point(1038, 338);
            this.rafOmruTxt.Name = "rafOmruTxt";
            this.rafOmruTxt.Size = new System.Drawing.Size(140, 23);
            this.rafOmruTxt.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(958, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Satış Fiyatı";
            // 
            // satisFiyatTxt
            // 
            this.satisFiyatTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.satisFiyatTxt.Location = new System.Drawing.Point(1038, 298);
            this.satisFiyatTxt.Name = "satisFiyatTxt";
            this.satisFiyatTxt.Size = new System.Drawing.Size(140, 23);
            this.satisFiyatTxt.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(967, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Alış Fiyatı";
            // 
            // alisFiyatTxt
            // 
            this.alisFiyatTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.alisFiyatTxt.Location = new System.Drawing.Point(1038, 262);
            this.alisFiyatTxt.Name = "alisFiyatTxt";
            this.alisFiyatTxt.Size = new System.Drawing.Size(140, 23);
            this.alisFiyatTxt.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(974, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Gramaj";
            // 
            // gramajTxt
            // 
            this.gramajTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.gramajTxt.Location = new System.Drawing.Point(1038, 225);
            this.gramajTxt.Name = "gramajTxt";
            this.gramajTxt.Size = new System.Drawing.Size(140, 23);
            this.gramajTxt.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(981, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Miktar";
            // 
            // miktarTxt
            // 
            this.miktarTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.miktarTxt.Location = new System.Drawing.Point(1038, 189);
            this.miktarTxt.Name = "miktarTxt";
            this.miktarTxt.Size = new System.Drawing.Size(140, 23);
            this.miktarTxt.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(967, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ürün Adı";
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.urunAdiTxt.Location = new System.Drawing.Point(1038, 151);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(140, 23);
            this.urunAdiTxt.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(950, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ürün Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ürün Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "BarkodNo";
            // 
            // barkodNoTxt
            // 
            this.barkodNoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.barkodNoTxt.Location = new System.Drawing.Point(1038, 37);
            this.barkodNoTxt.Name = "barkodNoTxt";
            this.barkodNoTxt.Size = new System.Drawing.Size(140, 23);
            this.barkodNoTxt.TabIndex = 33;
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunMarkacBox);
            this.Controls.Add(this.urunKategoriCBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rafOmruTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.satisFiyatTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.alisFiyatTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gramajTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.miktarTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urunAdiTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodNoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barkodNoTxtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUrunListele";
            this.Text = "Ürünler Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodNoTxtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox urunMarkacBox;
        private System.Windows.Forms.ComboBox urunKategoriCBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rafOmruTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox satisFiyatTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox alisFiyatTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gramajTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox miktarTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barkodNoTxt;
    }
}