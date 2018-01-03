using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Companie : Form
    {
        public static string search;
        public static DataGrid data;
        public static int c_panel_Details = 0;
        public static int open_message=0;

        public Companie()
        {
            InitializeComponent();
            picMessaging.Image = Image.FromFile("letter.png");

            panelDetails.Visible = false;

            lbCompanyName.Text = "companie"; //aici trebuie sa puneti voi nume+prenume
            txtCEO.Text = "eu";
            txtAddress.Text = "acasa";
            txtEmail.Text = "@gmail.com";
            txtPhone.Text = "0741413131";
            txtSkillsRequest.Text = "toate\n mere\n pere";
        }

        private void lbDetails_Click(object sender, EventArgs e)
        {
            c_panel_Details++;
            if (c_panel_Details % 2 == 0)
                panelDetails.Visible = true;
            else
                panelDetails.Visible = false;
        }

        private void picMessaging_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;

                Form form = new Messaging();
                form.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.ToString();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            search = txtSearch.ToString();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (search != null)
            {
                Form form = new SearchC(search);
                form.Show();
            }
            else
            {
                MessageBox.Show("Search box is empty, can't search",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
