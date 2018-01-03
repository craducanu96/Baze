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
            emailForgot = txtEmailForgot.ToString();
        }

        //txtPhoneForgot
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            phoneForgot = txtPhoneForgot.ToString();
        }

        private void txtNewForgotPass_TextChanged(object sender, EventArgs e)
        {
            newPass = txtNewForgotPass.ToString();
        }

        private void txtConfirmForgotPass_TextChanged(object sender, EventArgs e)
        {
            checkPass = txtConfirmForgotPass.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //aici verificati daca mailul si telefonul corespund, daca da intra in if
            if (emailForgot.Equals(phoneForgot)){

                //astea de jos sunt doar design
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
                //aici modificati voi in baza de date;
                MessageBox.Show("New password was set",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                this.Close();
            } else
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
