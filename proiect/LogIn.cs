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
    public partial class Log_page : Form
    {
        string username;
        string password;

        public Log_page()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_page_Load(object sender, EventArgs e)
        {

        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            //verificari de user si pass
            if (password == null || username == null)
            {
                if (password == null && username!=null)
                {
                    MessageBox.Show("Please write the password",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    username = null;
                    password = null;
                }
                else if(username == null && password!=null)
                {
                    MessageBox.Show("Please write the username",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    username = null;
                    password = null;
                }
                else
                {
                    MessageBox.Show("Please write the username and the password",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    username = null;
                    password = null;
                }
            }
            else if(username !=null && password !=null)
            {
                //aici verificati daca parola corespunde userului
                //conditia mea e doar de test
                if (username.Equals(password) == false)
                {
                    MessageBox.Show("Username or password incorect",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    username = null;
                    password = null;
                }
                else
                {
                    //aici porneste pagina principala daca a trecut de log in si e client
                    
                        Form form1 = new Client();
                        form1.Show();
                        this.Hide();
                    
                    //aici daca e companie
                        /*Form form= new Companie();
                        form.Show();
                        this.Hide();*/
                    
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //parola uitata
            Form form2 = new ForgotPassword();
            form2.ShowDialog();
        }

        private void lbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sign in client
            Form form3 = new SignIn();
            form3.ShowDialog();
            
        }


        private void lbNewCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sign in companie
            Form form4 = new SignInCompany();
            form4.ShowDialog();
            

        }

        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.ToString();
        }

        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = txtPassoword.ToString();
        }

    }
}
