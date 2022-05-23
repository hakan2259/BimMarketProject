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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Markalar(KategoriId,MarkaAd) values('" + comboBox2.SelectedValue + "', '"+textBox1.Text+"')", conn);
            command.ExecuteNonQuery();
            conn.Close();
            comboBox2.Text = "";
            textBox1.Text = "";
            MessageBox.Show("Marka Eklendi!");
        }


        private void frmMarka_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From Kategoriler", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "KategoriAd";
            comboBox2.DataSource = dt;
            conn.Close();
        }
    }
}
