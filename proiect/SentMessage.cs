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
            receptor = Int32.Parse(desti);

            if (tip.Equals("Client-Client"))
            {
                ok = 0;

            }
            else if (tip.Equals("Companie-Client"))
            {
                ok = 1;

            }
            else if (tip.Equals("Client-Companie"))
            {
                ok = 2;

            }
           
            
        
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            message = txtMessage.Text.ToString();
           
        }

        private void btSend_Click(object sender, EventArgs e)
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
                    using (var context = new LinkedinEntities3())
                    {
                        context.Mesaj_Companie_Client.Add(newmessage);
                        context.SaveChanges();
                    }
                }
                else if (ok==0)
                {
                    var newmessage = new Mesaj_Client_Client()
                    {
                        ID_Client_Receive=receptor,
                        ID_Client_Send=emitator,
                        Mesaj = message

                    };
                    using (var context = new LinkedinEntities3())
                    {
                        context.Mesaj_Client_Client.Add(newmessage);
                        context.SaveChanges();
                    }
                }
                else if(ok==2)
                {
                    var newmessage = new Mesaj_Client_Companie()
                    {
                       ID_Client_send=emitator,
                       ID_Companie_receive=receptor,
                        Mesaj = message

                    };
                    using (var context = new LinkedinEntities3())
                    {
                        context.Mesaj_Client_Companie.Add(newmessage);
                        context.SaveChanges();
                    }
                }
              
                

               
                

                MessageBox.Show("Message was sent",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                message = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't send an emply message",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
