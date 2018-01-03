using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{

    public partial class Client : Form
    {
        public static string search;
        public static int c_panel_Details = 0;
        public static int c_panel_Notification = 0;
        public static int open_message = 0;
        public static string rating;
        public static DataGrid grid;

        public Client()
        {
            InitializeComponent();
            picMessaging.Image = Image.FromFile("message.png");
            picRequest.Image = Image.FromFile("notification.png");
            picMe.Image = Image.FromFile("profile.png");

            panelDetails.Visible = false;
            panelNotification.Visible = false;

            lbUsername.Text = "Raducanu Cristian(Kinstown)"; //aici trebuie sa puneti voi nume+prenume
            txtAddress.Text = "acasa";
            txtBirth.Text = "21.12.2017";
            txtEmail.Text = "@gmail.com";
            txtNationality.Text = "roman";
            txtPhone.Text = "0741413131";
            txtSex.Text = "gay";
            txtStatus.Text = "singur";
            txtUniversiy.Text = "ATM";

            //aici zic eu sa puneti skills
            ListViewItem item1 = new ListViewItem("item1");
            ListViewItem item2 = new ListViewItem("item2");
            ListViewItem item3 = new ListViewItem("item3");
            listSkils.Items.Add(item1);
            listSkils.Items.Add(item2);
            listSkils.Items.Add(item3);

        }

        
        private void lbDetails_Click(object sender, EventArgs e)
        {
            c_panel_Details++;
            if (c_panel_Details % 2 == 0)
                panelDetails.Visible = true;
            else
                panelDetails.Visible = false;
        }

        private void picRequest_Click(object sender, EventArgs e)
        {
            c_panel_Notification++;
            if (c_panel_Notification % 2 == 0)
                panelNotification.Visible = true;
            else
                panelNotification.Visible = false;

        }

        private void picMessaging_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
            panelNotification.Visible = false;

                Form form = new Messaging();
                form.Show();


        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            rating = trackBar.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.ToString();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //aici trebuie sa cautati in baza de date si sa afisati in gridView
            if (search != null)
            {
                Form form = new Search(search);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Friend requesst accepted",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
