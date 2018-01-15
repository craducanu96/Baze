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
        int id_cel_logat;

        public static bool IfCompany(int id_comp)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Companie
                          select new
                          {
                              c.ID_Companie
                          };

            foreach (var item in results)
            {
                if (item.ID_Companie==id_comp)
                {
                        ok = 1;
                }
            }

            if (ok == 1)
                return true;
            return false;
        }

        public static bool IfClient(int id_client)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Client
                          select new
                          {
                              c.ID_Client
                          };

            foreach (var item in results)
            {
                if (item.ID_Client==id_client)
                {
                        ok = 1;
                }
            }

            if (ok == 1)
                return true;
            return false;

        }

        public static bool IsClient(string usrname)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Client
                          select new
                          {
                              c.Username
                          };

            foreach (var item in results)
            {
                if (item.Username == usrname)
                {
                    ok = 1;
                }
            }

            if (ok == 1)
                return true;
            return false;
        }
        int WhaAmI;
        public Messaging(int id_logat,int client_sau_companie)
        {
            WhaAmI = client_sau_companie;
            id_cel_logat = id_logat;
            InitializeComponent();
            if (IfClient(id_cel_logat))
            {
                using (var context = new LinkedinEntities5())
                {

                    var results = from item in context.Mesaj_Companie_Client
                                  where item.ID_client == id_cel_logat
                                  select new
                                  {
                                      item.Companie.Nume_companie,
                                      item.Mesaj
                                  };
                    DataTable aux = new DataTable();
                    DataColumn c0 = new DataColumn("Username");
                    DataColumn c1 = new DataColumn("Content");
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
                                 where item.ID_Client_Receive == id_cel_logat
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
                   

                }
            }
            if (IfCompany(id_cel_logat))
            {
                using (var context = new LinkedinEntities5())
                {

                    var results = from item in context.Mesaj_Client_Companie
                                  where item.ID_Companie_receive == id_cel_logat
                                  select new
                                  {
                                      item.Client.Username,
                                      item.Mesaj
                                  };
                    DataTable aux = new DataTable();
                    DataColumn c0 = new DataColumn("Username");
                    DataColumn c1 = new DataColumn("Content");
                    aux.Columns.Add(c0);
                    aux.Columns.Add(c1);
                    foreach (var it in results)
                    {
                        DataRow row = aux.NewRow();
                        row["Username"] = it.Username;
                        row["Content"] = it.Mesaj;
                        aux.Rows.Add(row);
                    }
                    
                    dataGridView1.DataSource = aux;
                    
                }
            }
            DataGridViewButtonColumn Respond = new DataGridViewButtonColumn();
            Respond.Name = "Respond";
            Respond.Text = "Respond";
            dataGridView1.Columns.Insert(2, Respond);
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string click = "";
                string ids = null;
                int id;
                int ok = 0;   //    =>   to a Client
                if (dataGridView1.Columns.Contains("Respond") && dataGridView1.Columns["Respond"].Visible && e.ColumnIndex == dataGridView1.Columns["Respond"].Index)
                {
                    click = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    using (var context = new LinkedinEntities5())
                    {
                        var results = from item in context.Client
                                      where item.Username == click
                                      select new
                                      {
                                          item.ID_Client
                                      };
                        foreach (var it in results)
                        {
                            ids = it.ID_Client.ToString();
                        }
                        if (ids == null)
                        {
                            ok = 1;   //    =>  to a Company
                            var rez = from itt in context.Companie
                                      where itt.UsernameC == click
                                      select new
                                      {
                                          itt.ID_Companie
                                      };
                            foreach (var it in rez)
                            {
                                ids = it.ID_Companie.ToString();
                            }
                        }
                    }
                    id = Int32.Parse(ids);

                    if (ids != null)
                    {
                        if (WhaAmI == 1)     //from Client
                        {
                            if (ok == 0)     //  to Client
                            {
                                Form form = new SentMessage(click, id_cel_logat, "Client-Client");
                                form.Show();
                            }
                            else    //  to Company
                            {
                                Form form = new SentMessage(click, id_cel_logat, "Client-Companie");
                                form.Show();
                            }
                        }
                        else
                            if (WhaAmI == 2)     ///from Company
                        {
                            Form form = new SentMessage(click, id_cel_logat, "Companie-Client");
                            form.Show();
                        }
                    }
                    else
                        throw new Exception("NULL Destination");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}