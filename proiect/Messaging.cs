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
    public partial class Messaging : Form
    {
        int id_cl_log;
        public Messaging(int id_client_logat)
        {
            id_cl_log = id_client_logat;
            InitializeComponent();
            using (var context = new LinkedinEntities5())
            {

                var results = from item in context.Mesaj_Companie_Client
                              where item.ID_client == id_client_logat
                              select new
                              {
                                  item.Companie.Nume_companie,
                                  item.Mesaj
                              };
                // dataGridView1.DataSource = results.ToList();
                DataTable aux = new DataTable();
                DataColumn c0 = new DataColumn("Username");
                DataColumn c1 = new DataColumn("Content");
                DataColumn c2 = new DataColumn("Respond");
                aux.Columns.Add(c0);
                aux.Columns.Add(c1);
                foreach (var it in results)
                {
                    DataRow row = aux.NewRow();
                    row["Username"] = it.Nume_companie;
                    row["Content"] = it.Mesaj;
                    aux.Rows.Add(row);
                }

                var result = from item in context.Mesaj_Client_Client
                             where item.ID_Client_Receive == id_client_logat
                             select new
                             {
                                 item.Client.Username,
                                 item.Mesaj
                             };
                foreach (var it in result)
                {

                    DataRow row = aux.NewRow();
                    row["Username"] = it.Username;
                    row["Content"] = it.Mesaj;
                    aux.Rows.Add(row);
                }
                
                dataGridView1.DataSource = aux;
                DataGridViewButtonColumn Respond = new DataGridViewButtonColumn();
                Respond.Name = "Respond";
                Respond.Text = "Respond";
                dataGridView1.Columns.Insert(2, Respond);
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string click="";

            if (dataGridView1.Columns.Contains("Respond") && dataGridView1.Columns["Respond"].Visible && e.ColumnIndex == dataGridView1.Columns["Respond"].Index)
            {
                click = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                Form form = new SentMessage(click, id_cl_log, "Client-Client");
                form.Show();
            }
        }
    }
}