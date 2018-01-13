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


namespace proiect
{
    public partial class Search : Form
    {
        //argumentul e ce cauta el in baza de date;
        public static int id_cel_care_e_conectat; 
        public static List<string> skill;
        public static List<string> skillC;
        public Search(string search,string a, int id_conectat)
        {
            id_cel_care_e_conectat = id_conectat;
            if(a.Equals("Companie"))
            {
                InitializeComponent1();
            }
            else
            InitializeComponent();
          

                LinkedinEntities5 context = new LinkedinEntities5();

                dataGridView1.DataSource = context.Client.Where(x =>x.ID_Client!=id_conectat && (x.Nume.Contains(search)||x.Prenume.Contains(search))).ToList();
                
        }
        public static List<string> skills(int id_client)
        {
            skill = new List<string>();
           // skill = null;
            using (var context = new LinkedinEntities5())
            {
                var results = context.Client.Include("Aptitudini").Where(s => s.ID_Client == id_client).FirstOrDefault<Client>();

                foreach (var item in results.Aptitudini)
                {
                    string aux = item.Aptitudine.ToString();
                    skill.Add(aux);
                   
                }
            }
            return skill;
        }

        public static List<string> skillsC(int id_companie)
        {
            skillC = new List<string>();
           // skillC = null;
            using (var context = new LinkedinEntities5())
            {
                var results = context.Companie.Include("Aptitudini").Where(s => s.ID_Companie == id_companie).FirstOrDefault<Companie>();

                foreach (var item in results.Aptitudini)
                {
                    string aux = item.Aptitudine.ToString();
                    skillC.Add(aux);
                   
                    
                }
            }
            return skillC;
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            string abc = null;
            if (dataGridView1.Columns.Contains("Match") && dataGridView1.Columns["Match"].Visible)
            {
               
                abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Client.Index].Value.ToString();
                int b = Int32.Parse(abc);
               using (var context = new LinkedinEntities5())
                  {

                      List<string> apt_client = skills(b);
                      List<string> apt_companie = skillsC(id_cel_care_e_conectat);
                      var message = string.Join(Environment.NewLine, apt_companie);
                    
                      var message1 = string.Join(Environment.NewLine, apt_client);
                     
                      var matches = apt_client.Intersect(apt_companie).Count();
                      int count = apt_companie.Count();
                      
                     
                      int procent = (int)Math.Round((double)(100 * matches) / count);

                      dataGridView1.Rows[e.RowIndex].Cells["Match"].Value = procent.ToString()+'%';

                  }
            }
            if (dataGridView1.Columns.Contains("Message") && dataGridView1.Columns["Message"].Visible)
            {
                
                    abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Client.Index].Value.ToString();

                    Form form = new SentMessage(abc, id_cel_care_e_conectat,"Companie-Client");
                    form.Show();
                
            }
            else if (dataGridView1.Columns.Contains("SendMessage") && dataGridView1.Columns["SendMessage"].Visible && e.ColumnIndex == dataGridView1.Columns["SendMessage"].Index)
            {

                abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Client.Index].Value.ToString();

                Form form = new SentMessage(abc, id_cel_care_e_conectat,"Client-Client");
                form.Show();

            }
            else
                if (dataGridView1.Columns.Contains("SendRelation") && dataGridView1.Columns["SendRelation"].Visible && e.ColumnIndex == dataGridView1.Columns["SendRelation"].Index)
            {
              
                    abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Client.Index].Value.ToString();
                 
                
                if (dataGridView1.Rows[e.RowIndex].Cells["Friendship"].FormattedValue.ToString().Equals("Add friend"))
               {
                    
                 var newrelatie=new Relatie()
                   {
                       ID_client_send=id_cel_care_e_conectat,
                       ID_client_receive=Int32.Parse(abc),
                       ID_status=1
                       
                   };
                 int a = Int32.Parse(abc);
                   using (var context = new LinkedinEntities5())
                   {var results=(from c in context.Relatie
                                 where c.ID_client_receive==a && c.ID_client_send==id_cel_care_e_conectat && c.ID_status==1
                                 select c).FirstOrDefault();
                   if (results == null)
                   {
                       context.Relatie.Add(newrelatie);
                       context.SaveChanges();
                       MessageBox.Show("Request was sent",
                  "Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                      
                   }
                   else
                   {
                       MessageBox.Show("There was another request sent",
                 "Information",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                   }
                   }

               }
                else  
                    if (dataGridView1.Rows[e.RowIndex].Cells["Friendship"].FormattedValue.ToString().Equals("Block"))
                {
                    var newrelatie = new Relatie()
                    {
                        ID_client_send = id_cel_care_e_conectat,
                        ID_client_receive = Int32.Parse(abc),
                        ID_status = 4

                    };
                    int a = Int32.Parse(abc);
                    using (var context = new LinkedinEntities5())
                    {
                        var results = (from c in context.Relatie
                                       where c.ID_client_receive == a && c.ID_client_send == id_cel_care_e_conectat && c.ID_status == 4
                                       select c).FirstOrDefault();
                        if (results == null)
                        {
                            context.Relatie.Add(newrelatie);
                            context.SaveChanges();
                            MessageBox.Show("Request was sent",
                       "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("There was another request sent",
                      "Information",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                        }
                    }

               }
            }
              else
                    if (dataGridView1.Columns.Contains("SendRating") && dataGridView1.Columns["SendRating"].Visible && e.ColumnIndex == dataGridView1.Columns["SendRating"].Index)
                    {
                      
                       abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Client.Index].Value.ToString();
                        int a = Int32.Parse(abc);
                        int ok = 0;
                        using (var context = new LinkedinEntities5())
                            {
                                var results = (from c in context.Rating
                                               where c.ID_client_receive == a && c.ID_client_send == id_cel_care_e_conectat
                                               select c).FirstOrDefault();
                                if (results == null)
                                    ok = 1;
                        
                        }
                            
                          if(ok==1)
                          { if (dataGridView1.Rows[e.RowIndex].Cells["Rating"].FormattedValue.Equals("5"))
                        {
                            var newrating = new Rating()
                            {
                                ID_client_send = id_cel_care_e_conectat,
                                ID_client_receive = Int32.Parse(abc),
                                Nota = 5
                            };

                            using (var context = new LinkedinEntities5())
                            {
                                context.Rating.Add(newrating);
                                context.SaveChanges();
                                MessageBox.Show("Rating was sent",
                 "Information",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                            }

                        }
                        else

                            if (dataGridView1.Rows[e.RowIndex].Cells["Rating"].FormattedValue.Equals("1"))
                            {
                                var newrating = new Rating()
                                {
                                    ID_client_send = id_cel_care_e_conectat,
                                    ID_client_receive = Int32.Parse(abc),
                                    Nota = 1
                                };

                                using (var context = new LinkedinEntities5())
                                {
                                    context.Rating.Add(newrating);
                                    context.SaveChanges();
                                    MessageBox.Show("Rating was sent",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                                }

                            }
                            else

                                if (dataGridView1.Rows[e.RowIndex].Cells["Rating"].FormattedValue.Equals("2"))
                                {
                                    var newrating = new Rating()
                                    {
                                        ID_client_send = id_cel_care_e_conectat,
                                        ID_client_receive = Int32.Parse(abc),
                                        Nota = 2
                                    };

                                    using (var context = new LinkedinEntities5())
                                    {
                                        context.Rating.Add(newrating);
                                        context.SaveChanges();
                                        MessageBox.Show("Rating was sent",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                                    }

                                }
                                else

                                    if (dataGridView1.Rows[e.RowIndex].Cells["Rating"].FormattedValue.Equals("3"))
                                    {
                                        var newrating = new Rating()
                                        {
                                            ID_client_send = id_cel_care_e_conectat,
                                            ID_client_receive = Int32.Parse(abc),
                                            Nota = 3
                                        };

                                        using (var context = new LinkedinEntities5())
                                        {
                                            context.Rating.Add(newrating);
                                            context.SaveChanges();
                                            MessageBox.Show("Rating was sent",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                                        }

                                    }
                                    else

                                        if (dataGridView1.Rows[e.RowIndex].Cells["Rating"].FormattedValue.Equals("4"))
                                        {
                                            var newrating = new Rating()
                                            {
                                                ID_client_send = id_cel_care_e_conectat,
                                                ID_client_receive = Int32.Parse(abc),
                                                Nota = 4
                                            };

                                            using (var context = new LinkedinEntities5())
                                            {
                                                context.Rating.Add(newrating);
                                                context.SaveChanges();
                                                MessageBox.Show("Rating was sent",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                                            }

                                        }
                          }
                          else
                          {
                              MessageBox.Show("You have already rated this person!",
                                  "Information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                          }
                    }
        }
        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Search_Load_1(object sender, EventArgs e)
        {

        }
    }
}
