using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BimProject.Helpers;

namespace BimProject
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Kategoriler(KategoriAd) values('" + txtKategoriAdı.Text + "')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            txtKategoriAdı.Text = "";
            MessageBox.Show("Kategori Eklendi!");
        }
    }
}
