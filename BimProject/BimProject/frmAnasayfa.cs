using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimProject
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            KategoriSubMenuPanel.Visible = false;
            UrunSubMenuPanel.Visible = false;
            AdminSubMenuPanel.Visible = false;

        }
        private void hideSubMenu()
        {
            if(UrunSubMenuPanel.Visible == true)
                UrunSubMenuPanel.Visible = false;
            if (KategoriSubMenuPanel.Visible == true)
                KategoriSubMenuPanel.Visible = false;
            if (AdminSubMenuPanel.Visible == true)
                AdminSubMenuPanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            showSubMenu(UrunSubMenuPanel);

        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            frmUrunListele urunListele = new frmUrunListele();
            urunListele.ShowDialog();
            hideSubMenu();
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUrunEkle());
            hideSubMenu();
        }

        private void btnKategoriYonetimi_Click(object sender, EventArgs e)
        {
            showSubMenu(KategoriSubMenuPanel);
        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKategoriListele());
            hideSubMenu();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKategori());
            hideSubMenu();
        }

        private void btnMarkaListele_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMarkaListele());
            hideSubMenu();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMarka());
            hideSubMenu();
        }

        private void btnAdminYonetimi_Click(object sender, EventArgs e)
        {
            showSubMenu(AdminSubMenuPanel);
        }

        private void btnAdminListele_Click(object sender, EventArgs e)
        {
            openChildForm(new frmYoneticiListele());
            hideSubMenu();
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            frmYoneticiEkle yöneticiEkle = new frmYoneticiEkle();
            yöneticiEkle.ShowDialog();
            hideSubMenu();
            
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
