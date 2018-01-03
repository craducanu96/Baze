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

        public SignInCompany()
        {
            skillsC = null;
            InitializeComponent();
            panelSkills.Visible = false;

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            companyname = txtCompanyName.ToString();
            //aici bagati un if sa vedeti daca exita deja compania
            /* if (companyname.Equals(cineva))
             {
                 MessageBox.Show("Company already exist!",
                      "ERROR",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
             }*/
        }

        private void txtCEO_TextChanged(object sender, EventArgs e)
        {
            CEO = txtCEO.ToString();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            addressC = txtAddress.ToString();
        }

        private void txtPassCompany_TextChanged(object sender, EventArgs e)
        {
            passC = txtPassCompany.ToString();
        }

        private void txtCheckPassCompany_TextChanged(object sender, EventArgs e)
        {
            checkpassC = txtCheckPassCompany.ToString();
            if (passC.Equals(checkpassC)==false)
            {
                MessageBox.Show("Password dosen't match",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void txtEmailCompany_TextChanged(object sender, EventArgs e)
        {
            emailC = txtEmailCompany.ToString();
        }

        private void txtPhoneCompany_TextChanged(object sender, EventArgs e)
        {
            phoneC = txtPassCompany.ToString();
        }

        private void btNextCompany_Click(object sender, EventArgs e)
        {
            if (companyname != null && CEO != null
                && addressC != null && phoneC != null
                && emailC != null && skillsC != null
                && passC != null && checkpassC != null)
            {
                MessageBox.Show("Register successfully",
                     "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                this.Close();
                Form form = new Companie();
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
            skillsC += "," + checkBox45.ToString();
        }

        private void checkBox42_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox42.ToString();
        }

        private void checkBox47_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox47.ToString();
        }

        private void checkBox41_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox41.ToString();
        }

        private void sk25_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk25.ToString();
        }

        private void checkBox40_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox40.ToString();
        }

        private void checkBox46_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox46.ToString();
        }

        private void sk22_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk22.ToString();
        }

        private void sk30_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk30.ToString();
        }

        private void sk23_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk23.ToString();
        }

        private void sk26_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk26.ToString();
        }

        private void checkBox43_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox43.ToString();
        }

        private void sk31_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk32.ToString();
        }

        private void sk32_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk32.ToString();
        }

        private void sk21_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk21.ToString();
        }

        private void sk20_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk20.ToString();
        }

        private void sk24_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk24.ToString();
        }

        private void checkBox44_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox44.ToString();
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            skillsC += "," + checkBox39.ToString();
        }

        private void sk19_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk19.ToString();
        }

        private void sk18_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk18.ToString();
        }

        private void sk17_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk17.ToString();
        }

        private void sk28_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk28.ToString();
        }

        private void sk27_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk27.ToString();
        }

        private void checkBox48_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + checkBox48.ToString();
        }

        private void sk29_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk29.ToString();
        }

        private void sk16_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk16.ToString();
        }

        private void sk14_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk14.ToString();
        }

        private void sk13_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk13.ToString();
        }

        private void sk12_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk12.ToString();
        }

        private void sk11_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk11.ToString();
        }

        private void sk10_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk10.ToString();
        }

        private void sk9_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk9.ToString();
        }

        private void sk8_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk8.ToString();
        }

        private void sk7_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk7.ToString();
        }

        private void sk6_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk6.ToString();
        }

        private void sk5_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk5.ToString();
        }

        private void sk4_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk4.ToString();
        }

        private void sk3_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk3.ToString();
        }

        private void sk2_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk2.ToString();
        }

        private void sk1_CheckedChanged_1(object sender, EventArgs e)
        {
            skillsC += "," + sk1.ToString();
        }
    }
}
