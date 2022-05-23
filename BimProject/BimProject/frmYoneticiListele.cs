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
    public partial class frmYoneticiListele : Form
    {
        public frmYoneticiListele()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        DataSet dataset = new DataSet();
        private void frmYoneticiListele_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            YoneticiListele();
        }
        private void YoneticiListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Yoneticiler.Id, Username, Password, Yetkiler.Name  From Yoneticiler inner join Yetkiler on Yoneticiler.AuthorityId=Yetkiler.Id", conn);
            adapter.Fill(dataset, "Yonetici");
            dataGridView1.DataSource = dataset.Tables["Yonetici"];
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("delete from Yoneticiler where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            dataset.Tables["Yonetici"].Clear();
            YoneticiListele();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }
    }
}
