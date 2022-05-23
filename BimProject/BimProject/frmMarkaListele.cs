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
    public partial class frmMarkaListele : Form
    {
        public frmMarkaListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        DataSet dataset = new DataSet();
        private void frmMarkaListele_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            MarkaListele();
        }
        private void MarkaListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Markalar.Id,KategoriAd,MarkaAd From Markalar INNER JOIN Kategoriler on Markalar.KategoriId=Kategoriler.Id", conn);
            adapter.Fill(dataset, "Marka");
            dataGridView1.DataSource = dataset.Tables["Marka"];
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarkaAdı.Text = dataGridView1.CurrentRow.Cells["MarkaAd"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update Markalar set MarkaAd=@MarkaAd where Id=@MarkaId", conn);

            command.Parameters.AddWithValue("@MarkaId", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

            command.Parameters.AddWithValue("@MarkaAd", txtMarkaAdı.Text);



            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Marka"].Clear();
            MarkaListele();

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
            SqlCommand command = new SqlCommand("delete from Markalar where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Marka"].Clear();
            MarkaListele();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }
    }
}
