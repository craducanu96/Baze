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
    public partial class ForgotPassword : Form
    {
        string emailForgot;
        string phoneForgot;
        string newPass;
        string checkPass;

        static string client_companie;

        public static bool IfExists(string mail, string phone)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Client
                          select new
                          {
                              c.Telefon,
                              c.Email
                          };

            foreach (var item in results)
            {
                if (item.Telefon.Equals(phone) && item.Email.Equals(mail))
                {
                    ok = 1;
                    client_companie = "client";
                }
            }

            var results1 = from c in context.Companie
                           select new
                           {
                               c.Telefon_companie,
                               c.Email_companie
                           };

            foreach (var item in results1)
            {
                if (item.Telefon_companie.Equals(phone) && item.Email_companie.Equals(mail))
                {
                    ok = 1;
                    client_companie = "companie";
                }
            }

            if (ok == 1)
                return true;
            return false;

        }



        public ForgotPassword()
        {
            InitializeComponent();

            panelForgot.Visible = true;
            panelPassword.Visible = false;
            btOk1.Visible = true;
            btOk2.Visible = false;
        }

        //txtEmailForgot
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            emailForgot = txtEmailForgot.Text.ToString();
        }

        //txtPhoneForgot
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            phoneForgot = txtPhoneForgot.Text.ToString();
        }

        private void txtNewForgotPass_TextChanged(object sender, EventArgs e)
        {
            newPass = txtNewForgotPass.Text.ToString();
        }

        private void txtConfirmForgotPass_TextChanged(object sender, EventArgs e)
        {
            checkPass = txtConfirmForgotPass.Text.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            if (IfExists(emailForgot, phoneForgot) == true)
            {
                panelForgot.Visible = false;
                panelPassword.Visible = true;
                btOk1.Visible = false;
                btOk2.Visible = true;
            }
            else
            {
                MessageBox.Show("Email or phone not corresponding",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        private void btOk2_Click(object sender, EventArgs e)
        {
            if (newPass.Equals(checkPass))
            {
                string hash = CClient.SecurePasswordHasher.Hash(newPass);
                if (client_companie == "client")
                {
                    var context = new LinkedinEntities5();
                    var emailClient = (from c in context.Client
                                       where c.Email.Equals(emailForgot)
                                       select c).First();
                    emailClient.Parola = hash;
                    context.SaveChanges();

                }
                else if (client_companie == "comapanie")
                {
                    var context1 = new LinkedinEntities5();
                    var emailCompanie = (from c in context1.Companie
                                         where c.Email_companie.Equals(emailForgot)
                                         select c).First();
                    if (emailCompanie != null)
                    {
                        emailCompanie.ParolaC = hash;
                        context1.SaveChanges();
                    }
                }

                MessageBox.Show("New password was set",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                this.Close();
            }
            else
            {
                MessageBox.Show("Password doesn't match",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
