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
    public partial class SignInCompany : Form
    {
        public static string companyname;
        public static string CEO;
        public static string addressC;
        public static string passC;
        public static string checkpassC;
        public static string phoneC;
        public static string emailC;
        public static string skillsC;
        public static int c_panel_skillsC = 0;

        public static string get_skillsC()
        {
            return skillsC;
        }

        public SignInCompany()
        {
            skillsC = null;
            InitializeComponent();
            panelSkills.Visible = false;

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            companyname = txtCompanyName.Text.ToString();
        }

        private void txtCEO_TextChanged(object sender, EventArgs e)
        {
            CEO = txtCEO.Text.ToString();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            addressC = txtAddress.Text.ToString();
        }

        private void txtPassCompany_TextChanged(object sender, EventArgs e)
        {
            passC = txtPassCompany.Text.ToString();
        }

        private void txtCheckPassCompany_TextChanged(object sender, EventArgs e)
        {
            checkpassC = txtCheckPassCompany.Text.ToString();
        }


        private void txtEmailCompany_TextChanged(object sender, EventArgs e)
        {
            emailC = txtEmailCompany.Text.ToString();
        }


        private void txtPhoneCompany_TextChanged(object sender, EventArgs e)
        {
            phoneC = txtPhoneCompany.Text.ToString();
        }

        private void btNextCompany_Click(object sender, EventArgs e)
        {

            if (companyname != null && SignIn.IfExistsUsername(companyname) == true)
            {
                MessageBox.Show("Company already exist!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else if (passC != null && SignIn.Conditions(passC) == false)
            {
                MessageBox.Show("Aruncati voi o exceptie ca nu contine anumite caractere",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else if (passC != null && checkpassC != null && passC.Equals(checkpassC) == false)
            {
                MessageBox.Show("Password dosen't match",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
            else if (emailC != null && SignIn.ValidEmailAddress(emailC) == false)
            {
                MessageBox.Show("E-mail address must be valid e-mail address format!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            else if (SignIn.IfExistsEmail(emailC) == true)
            {
                MessageBox.Show("Email already exist!",
                "ERROR",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else if (companyname != null && CEO != null
                        && addressC != null && phoneC != null
                        && emailC != null && skillsC != null
                        && passC != null && checkpassC != null)
            {
                MessageBox.Show("Register successfully",
                     "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                this.Close();
                CCompanie.inregistreaza_companie(CEO, companyname, addressC, emailC, phoneC, passC);
                Form form = new CCompanie(CEO, companyname, addressC, emailC, phoneC, get_skillsC());
                form.Show();
            }
            else
            {
                MessageBox.Show("Some empty filled!",
                     "ERROR",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btSkillsC_Click(object sender, EventArgs e)
        {
            if (c_panel_skillsC % 2 == 0)
                panelSkills.Visible = true;
            else
                panelSkills.Visible = false;
            c_panel_skillsC++;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                MessageBox.Show("No skill checked!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                panelSkills.Visible = false;
        }

        private void checkBox45_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox45.Text.ToString();
            }
            else
                skillsC += "," + checkBox45.Text.ToString();
        }

        private void checkBox42_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox42.Text.ToString();
            }
            else
                skillsC += "," + checkBox42.Text.ToString();
        }

        private void checkBox47_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox47.Text.ToString();
            }
            else
                skillsC += "," + checkBox47.Text.ToString();
        }

        private void checkBox41_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox41.Text.ToString();
            }
            else
                skillsC += "," + checkBox41.Text.ToString();
        }

        private void sk25_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk25.Text.ToString();
            }
            else
                skillsC += "," + sk25.Text.ToString();
        }

        private void checkBox40_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox40.Text.ToString();
            }
            else
                skillsC += "," + checkBox40.Text.ToString();
        }

        private void checkBox46_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox46.Text.ToString();
            }
            else
                skillsC += "," + checkBox46.Text.ToString();
        }

        private void sk22_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk22.Text.ToString();
            }
            else
                skillsC += "," + sk22.Text.ToString();
        }

        private void sk30_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk30.Text.ToString();
            }
            else
                skillsC += "," + sk30.Text.ToString();
        }

        private void sk23_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk23.Text.ToString();
            }
            else
                skillsC += "," + sk23.Text.ToString();
        }

        private void sk26_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk26.Text.ToString();
            }
            else
                skillsC += "," + sk26.Text.ToString();
        }

        private void checkBox43_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox43.Text.ToString();
            }
            else
                skillsC += "," + checkBox43.Text.ToString();
        }

        private void sk31_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk31.Text.ToString();
            }
            else
                skillsC += "," + sk31.Text.ToString();
        }

        private void sk32_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk32.Text.ToString();
            }
            else
                skillsC += "," + sk32.Text.ToString();
        }

        private void sk21_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk21.Text.ToString();
            }
            else
                skillsC += "," + sk21.Text.ToString();
        }

        private void sk20_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk20.Text.ToString();
            }
            else
                skillsC += "," + sk20.Text.ToString();
        }

        private void sk24_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk24.Text.ToString();
            }
            else
                skillsC += "," + sk24.Text.ToString();
        }

        private void checkBox44_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox44.Text.ToString();
            }
            else
                skillsC += "," + checkBox44.Text.ToString();
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox39.Text.ToString();
            }
            else
                skillsC += "," + checkBox39.Text.ToString();
        }

        private void sk19_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk19.Text.ToString();
            }
            else
                skillsC += "," + sk19.Text.ToString();
        }

        private void sk18_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk18.Text.ToString();
            }
            else
                skillsC += "," + sk18.Text.ToString();
        }

        private void sk17_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk17.Text.ToString();
            }
            else
                skillsC += "," + sk17.Text.ToString();
        }

        private void sk28_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk28.Text.ToString();
            }
            else
                skillsC += "," + sk28.Text.ToString();
        }

        private void sk27_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk27.Text.ToString();
            }
            else
                skillsC += "," + sk27.Text.ToString();
        }

        private void checkBox48_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = checkBox48.Text.ToString();
            }
            else
                skillsC += "," + checkBox48.Text.ToString();
        }

        private void sk29_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk29.Text.ToString();
            }
            else
                skillsC += "," + sk29.Text.ToString();
        }

        private void sk16_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk16.Text.ToString();
            }
            else
                skillsC += "," + sk16.Text.ToString();
        }

        private void sk14_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk14.Text.ToString();
            }
            else
                skillsC += "," + sk14.Text.ToString();
        }


        private void sk13_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk13.Text.ToString();
            }
            else
                skillsC += "," + sk13.Text.ToString();
        }


        private void sk12_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk12.Text.ToString();
            }
            else
                skillsC += "," + sk12.Text.ToString();
        }


        private void sk11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk11.Text.ToString();
            }
            else
                skillsC += "," + sk11.Text.ToString();
        }

        private void sk10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk10.Text.ToString();
            }
            else
                skillsC += "," + sk10.Text.ToString();
        }

        private void sk9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk9.Text.ToString();
            }
            else
                skillsC += "," + sk9.Text.ToString();
        }

        private void sk8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk8.Text.ToString();
            }
            else
                skillsC += "," + sk8.Text.ToString();
        }
        private void sk7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk7.Text.ToString();
            }
            else
                skillsC += "," + sk7.Text.ToString();
        }

        private void sk6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk6.Text.ToString();
            }
            else
                skillsC += "," + sk6.Text.ToString();
        }

        private void sk5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk5.Text.ToString();
            }
            else
                skillsC += "," + sk5.Text.ToString();
        }

        private void sk4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk4.Text.ToString();
            }
            else
                skillsC += "," + sk4.Text.ToString();
        }

        private void sk3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk3.Text.ToString();
            }
            else
                skillsC += "," + sk3.Text.ToString();
        }

        private void sk2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk2.Text.ToString();
            }
            else
                skillsC += "," + sk2.Text.ToString();
        }

        private void sk1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (skillsC == null)
            {
                skillsC = sk1.Text.ToString();
            }
            else
                skillsC += "," + sk1.Text.ToString();

        }
    }
}

