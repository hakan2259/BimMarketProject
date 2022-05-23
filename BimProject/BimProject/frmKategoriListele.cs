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
    public partial class frmKategoriListele : Form
    {
        public frmKategoriListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        DataSet dataset = new DataSet();
        private void frmKategoriListele_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            KategoriListele();
        }
        private void KategoriListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Id, KategoriAd From Kategoriler", conn);
            adapter.Fill(dataset, "Kategori");
            dataGridView1.DataSource = dataset.Tables["Kategori"];
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdı.Text = dataGridView1.CurrentRow.Cells["KategoriAd"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update Kategoriler set KategoriAd=@KategoriAd where Id=@KategoriId", conn);
         
            command.Parameters.AddWithValue("@KategoriId", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
 
            command.Parameters.AddWithValue("@KategoriAd", txtKategoriAdı.Text);
          
            

            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Kategori"].Clear();
            KategoriListele();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("delete from Kategoriler where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Kategori"].Clear();
            KategoriListele();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }
    }
}
