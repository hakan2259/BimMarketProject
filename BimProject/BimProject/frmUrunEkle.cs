using BimProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimProject
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();


        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From Kategoriler", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "KategoriAd";
            comboBox1.DataSource = dt;
            conn.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Markalar where KategoriId='"+comboBox1.SelectedValue+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "MarkaAd";
            comboBox2.DataSource = dt;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Urunler(BarkodNo,KategoriId,MarkaId,UrunAd,Miktar,Gramaj,AlisFiyat,SatisFiyat,RafOmru,Tarih) values(@BarkodNo,@KategoriId,@MarkaId,@UrunAd,@Miktar,@Gramaj,@AlisFiyat,@SatisFiyat,@RafOmru,@Tarih)", conn);
            command.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            command.Parameters.AddWithValue("@KategoriId", comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@MarkaId", comboBox2.SelectedValue);
            command.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text);
            command.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
            command.Parameters.AddWithValue("@Gramaj", txtGramaj.Text);
            command.Parameters.AddWithValue("@AlisFiyat", double.Parse(txtAlisFiyat.Text));
            command.Parameters.AddWithValue("@SatisFiyat", double.Parse(txtSatisFiyat.Text));
            command.Parameters.AddWithValue("@RafOmru", txtRafOmru.Text);
            command.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün Eklendi!");
            foreach (Control item in yeniUrun.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void barkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
