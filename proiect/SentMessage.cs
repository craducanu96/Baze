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
    public partial class SentMessage : Form
    {
        public static string message;
        public static int emitator, receptor;
        public static int ok;
        public SentMessage(string desti,int emi,string tip)
        {
           InitializeComponent();
            emitator = emi;
           

            if (tip.Equals("Client-Client"))
            {
                ok = 0;
                string aux = null;
                string a = null;
                using (var context = new LinkedinEntities5())
                {
                    var results = from item in context.Client
                                  where item.Nume == desti || item.Username==desti
                                  select new
                                  {
                                      item.ID_Client
                                  };
                    foreach(var it in results)
                    {
                        a = it.ID_Client.ToString();
                    }
                }
                receptor = Int32.Parse(a);
            }
            else if (tip.Equals("Companie-Client"))
            {
                ok = 1;
                string aux=null;
                
                    using (var context = new LinkedinEntities5())
                    {
                        var results = from item in context.Client
                                      where item.Username == desti ||item.ID_Client.ToString()==desti
                                      select new
                                      {
                                          item.ID_Client
                                      };
                        foreach (var it in results)
                        {
                            aux = it.ID_Client.ToString();
                        }
                    }
                    receptor = Int32.Parse(aux);
                
            }
            else if (tip.Equals("Client-Companie"))
            {
                ok = 2;
                string aux = null;
                using (var context = new LinkedinEntities5())
                {
                    var results = from item in context.Companie
                                  where item.UsernameC == desti
                                  select new
                                  {
                                      item.ID_Companie
                                  };
                    foreach (var it in results)
                    {
                        aux = it.ID_Companie.ToString();
                    }
                }
                receptor = Int32.Parse(aux);
            }
           
            
        
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            message = txtMessage.Text.ToString();
           
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (message != null)
                {

                    if (ok == 1)
                    {
                        var newmessage = new Mesaj_Companie_Client()
                        {
                            ID_client = receptor,
                            ID_companie = emitator,
                            Mesaj = message

                        };
                        using (var context = new LinkedinEntities5())
                        {
                            context.Mesaj_Companie_Client.Add(newmessage);
                            context.SaveChanges();
                        }
                    }
                    else if (ok == 0)
                    {
                        var newmessage = new Mesaj_Client_Client()
                        {
                            ID_Client_Receive = receptor,
                            ID_Client_Send = emitator,
                            Mesaj = message

                        };
                        using (var context = new LinkedinEntities5())
                        {
                            context.Mesaj_Client_Client.Add(newmessage);
                            context.SaveChanges();
                        }
                    }
                    else if (ok == 2)
                    {
                        var newmessage = new Mesaj_Client_Companie()
                        {
                            ID_Client_send = emitator,
                            ID_Companie_receive = receptor,
                            Mesaj = message

                        };
                        using (var context = new LinkedinEntities5())
                        {
                            context.Mesaj_Client_Companie.Add(newmessage);
                            context.SaveChanges();
                        }
                    }
                    throw new Exception("Message was sent!");
                    message = null;
                    this.Close();
                }
                else
                {
                    throw new Exception("Can't send an emply message!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
