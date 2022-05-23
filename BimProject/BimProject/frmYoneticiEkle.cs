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
    public partial class frmYoneticiEkle : Form
    {
        public frmYoneticiEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = MsSQLMarketDal.GetMsSQLConnection();

        private void frmYoneticiEkle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From Yetkiler", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboxYetki.ValueMember = "Id";
            cboxYetki.DisplayMember = "Name";
            cboxYetki.DataSource = dt;
            conn.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == txtComPassword.Text)
            {
                conn.Open();
                string register = "INSERT INTO Yoneticiler VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "', '"+cboxYetki.SelectedValue+"')";
                SqlCommand command = new SqlCommand(register, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your account has been Successfully Created", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                // txtComPassword = "2";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtComPassword.Text = "";
            txtPassword.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
