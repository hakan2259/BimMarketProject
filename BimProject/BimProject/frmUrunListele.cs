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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        DataSet dataset = new DataSet();
        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            UrunListele();
        }
        private void UrunListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select BarkodNo,KategoriAd,MarkaAd,UrunAd,Miktar,Gramaj,AlisFiyat,SatisFiyat,RafOmru,Tarih From Urunler INNER JOIN Kategoriler ON Urunler.KategoriId=Kategoriler.Id INNER JOIN Markalar ON Urunler.MarkaId=Markalar.Id", conn);
            adapter.Fill(dataset, "Urun");
            dataGridView1.DataSource = dataset.Tables["Urun"];
            conn.Close();
        }
        private void GetKategoriAll()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From Kategoriler", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            urunKategoriCBox.ValueMember = "Id";
            urunKategoriCBox.DisplayMember = "KategoriAd";
            urunKategoriCBox.DataSource = dt;
            conn.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update Urunler set KategoriId=@KategoriId,MarkaId=@MarkaId,UrunAd=@UrunAd,Miktar=@Miktar,Gramaj=@Gramaj,AlisFiyat=@AlisFiyat,SatisFiyat=@SatisFiyat,RafOmru=@RafOmru where BarkodNo=@BarkodNo", conn);
            command.Parameters.AddWithValue("@BarkodNo", barkodNoTxt.Text);
            command.Parameters.AddWithValue("@KategoriId", urunKategoriCBox.SelectedValue);
            command.Parameters.AddWithValue("@MarkaId", urunMarkacBox.SelectedValue);
            command.Parameters.AddWithValue("@UrunAd", urunAdiTxt.Text);
            command.Parameters.AddWithValue("@Miktar", int.Parse(miktarTxt.Text));
            command.Parameters.AddWithValue("@Gramaj", gramajTxt.Text);
            command.Parameters.AddWithValue("@AlisFiyat", double.Parse(alisFiyatTxt.Text));
            command.Parameters.AddWithValue("@SatisFiyat", double.Parse(satisFiyatTxt.Text));
            command.Parameters.AddWithValue("@RafOmru", rafOmruTxt.Text);

            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Urun"].Clear();
            UrunListele();

            MessageBox.Show("Güncelleme Başarılı!");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("delete from Urunler where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Urun"].Clear();
            UrunListele();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }

        private void urunKategoriCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Markalar where KategoriId='" + urunKategoriCBox.SelectedValue + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            urunMarkacBox.ValueMember = "Id";
            urunMarkacBox.DisplayMember = "MarkaAd";
            urunMarkacBox.DataSource = dt;
        }

        private void barkodNoTxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select BarkodNo,KategoriAd,MarkaAd,UrunAd,Miktar,Gramaj,AlisFiyat,SatisFiyat,RafOmru,Tarih From Urunler INNER JOIN Kategoriler ON Urunler.KategoriId=Kategoriler.Id INNER JOIN Markalar ON Urunler.MarkaId=Markalar.Id where BarkodNo like '%" + barkodNoTxtSearch.Text + "%'", conn);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetKategoriAll();
            barkodNoTxt.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            urunKategoriCBox.Text = dataGridView1.CurrentRow.Cells["KategoriAd"].Value.ToString();
            urunMarkacBox.Text = dataGridView1.CurrentRow.Cells["MarkaAd"].Value.ToString();
            urunAdiTxt.Text = dataGridView1.CurrentRow.Cells["UrunAd"].Value.ToString();
            miktarTxt.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            gramajTxt.Text = dataGridView1.CurrentRow.Cells["Gramaj"].Value.ToString();
            alisFiyatTxt.Text = dataGridView1.CurrentRow.Cells["AlisFiyat"].Value.ToString();
            satisFiyatTxt.Text = dataGridView1.CurrentRow.Cells["SatisFiyat"].Value.ToString();
            rafOmruTxt.Text = dataGridView1.CurrentRow.Cells["RafOmru"].Value.ToString();
        }
    }
}
