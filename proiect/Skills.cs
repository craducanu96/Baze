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

    public partial class Skills : Form
    {
        public static string skills;
        public static string skills_id;

        public static string get_skill()
        {
            return skills;
        }

        public static string get_skills_id()
        {
            return skills_id;
        }

        public Skills()
        {
            skills = null;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (skills == null)
                {
                    throw new Exception("No skill checked!");
                }
                else
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sk1_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk1.Text.ToString();
                skills_id = "1";
            }
            else
            {
                skills += "," + sk1.Text.ToString();
                skills_id += " " + "1";
            }
        }


        private void sk2_CheckedChanged(object sender, EventArgs e)
        {

            if (skills == null)
            {
                skills = sk2.Text.ToString();
                skills_id = "2";
            }
            else
            {
                skills += "," + sk2.Text.ToString();
                skills_id += " " + "2";
            }
        }

        private void sk3_CheckedChanged(object sender, EventArgs e)
        {

            if (skills == null)
            {
                skills = sk3.Text.ToString();
                skills_id = "3";
            }
            else
            {
                skills += "," + sk3.Text.ToString();
                skills_id += " " + "3";
            }
        }

        private void sk4_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk4.Text.ToString();
                skills_id = "4";
            }
            else
            {
                skills += "," + sk4.Text.ToString();
                skills_id += " " + "4";
            }
        }

        private void sk5_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk5.Text.ToString();
                skills_id = "5";
            }
            else
            {
                skills += "," + sk5.Text.ToString();
                skills_id += " " + "5";
            }
        }

        private void sk6_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk6.Text.ToString();
                skills_id = "6";
            }
            else
            {
                skills += "," + sk6.Text.ToString();
                skills_id += " " + "6";
            }
        }

        private void sk7_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk7.Text.ToString();
                skills_id = "7";
            }
            else
            {
                skills += "," + sk7.Text.ToString();
                skills_id += " " + "7";
            }
        }

        private void sk8_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk8.Text.ToString();
                skills_id = "8";
            }
            else
            {
                skills += "," + sk8.Text.ToString();
                skills_id += " " + "8";
            }

        }

        private void sk9_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk9.Text.ToString();
                skills_id = "9";
            }
            else
            {
                skills += "," + sk9.Text.ToString();
                skills_id += " " + "9";
            }

        }

        private void sk10_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk10.Text.ToString();
                skills_id = "10";
            }
            else
            {
                skills += "," + sk10.Text.ToString();
                skills_id += " " + "10";
            }

        }

        private void sk11_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk11.Text.ToString();
                skills_id = "11";
            }
            else
            {
                skills += "," + sk11.Text.ToString();
                skills_id += " " + "11";
            }
        }

        private void sk12_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk12.Text.ToString();
                skills_id = "12";
            }
            else
            {
                skills += "," + sk12.Text.ToString();
                skills_id += " " + "12";
            }

        }

        private void sk13_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk13.Text.ToString();
                skills_id = "13";
            }
            else
            {
                skills += "," + sk13.Text.ToString();
                skills_id += " " + "13";
            }

        }

        private void sk14_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk14.Text.ToString();
                skills_id = "14";
            }
            else
            {
                skills += "," + sk14.Text.ToString();
                skills_id += " " + "14";
            }

        }

        private void sk15_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk15.Text.ToString();
                skills_id = "15";
            }
            else
            {
                skills += "," + sk15.Text.ToString();
                skills_id += " " + "15";
            }

        }

        private void sk16_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk16.Text.ToString();
                skills_id = "16";
            }
            else
            {
                skills += "," + sk16.Text.ToString();
                skills_id += " " + "16";
            }

        }

        private void sk29_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk29.Text.ToString();
                skills_id = "17";
            }
            else
            {
                skills += "," + sk29.Text.ToString();
                skills_id += " " + "17";
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox48.Text.ToString();
                skills_id = "18";
            }
            else
            {
                skills += "," + checkBox48.Text.ToString();
                skills_id += " " + "18";
            }

        }

        private void sk27_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk27.Text.ToString();
                skills_id = "19";
            }
            else
            {
                skills += "," + sk27.Text.ToString();
                skills_id += " " + "19";
            }

        }

        private void sk28_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk28.Text.ToString();
                skills_id = "20";
            }
            else
            {
                skills += "," + sk28.Text.ToString();
                skills_id += " " + "20";
            }

        }

        private void sk17_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk17.Text.ToString();
                skills_id = "21";
            }
            else
            {
                skills += "," + sk17.Text.ToString();
                skills_id += " " + "21";
            }

        }

        private void sk18_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk18.Text.ToString();
                skills_id = "22";
            }
            else
            {
                skills += "," + sk18.Text.ToString();
                skills_id += " " + "22";
            }

        }

        private void sk19_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk19.Text.ToString();
                skills_id = "23";
            }
            else
            {
                skills += "," + sk19.Text.ToString();
                skills_id += " " + "23";
            }

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox44.Text.ToString();
                skills_id = "25";
            }
            else
            {
                skills += "," + checkBox44.Text.ToString();
                skills_id += " " + "25";
            }

        }

        private void sk24_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk24.Text.ToString();
                skills_id = "26";
            }
            else
            {
                skills += "," + sk24.Text.ToString();
                skills_id += " " + "26";
            }
        }

        private void sk20_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk20.Text.ToString();
                skills_id = "27";
            }
            else
            {
                skills += "," + sk20.Text.ToString();
                skills_id += " " + "27";
            }

        }

        private void sk21_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk21.Text.ToString();
                skills_id = "28";
            }
            else
            {
                skills += "," + sk21.Text.ToString();
                skills_id += " " + "28";
            }

        }

        private void sk32_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk32.Text.ToString();
                skills_id = "29";
            }
            else
            {
                skills += "," + sk32.Text.ToString();
                skills_id += " " + "29";
            }

        }

        private void sk31_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk3.Text.ToString();
                skills_id = "30";
            }
            else
            {
                skills += "," + sk3.Text.ToString();
                skills_id += " " + "30";
            }

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox43.Text.ToString();
                skills_id = "31";
            }
            else
            {
                skills += "," + checkBox43.Text.ToString();
                skills_id += " " + "31";
            }

        }

        private void sk26_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk26.Text.ToString();
                skills_id = "32";
            }
            else
            {
                skills += "," + sk26.Text.ToString();
                skills_id += " " + "32";
            }

        }

        private void sk23_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk23.Text.ToString();
                skills_id = "33";
            }
            else
            {
                skills += "," + sk23.Text.ToString();
                skills_id += " " + "33";
            }

        }

        private void sk30_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk30.Text.ToString();
                skills_id = "34";
            }
            else
            {
                skills += "," + sk30.Text.ToString();
                skills_id += " " + "34";
            }

        }

        private void sk22_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk22.Text.ToString();
                skills_id = "35";
            }
            else
            {
                skills += "," + sk22.Text.ToString();
                skills_id += " " + "35";
            }

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox46.Text.ToString();
                skills_id = "36";
            }
            else
            {
                skills += "," + checkBox46.Text.ToString();
                skills_id += " " + "36";
            }

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox40.Text.ToString();
                skills_id = "37";
            }
            else
            {
                skills += "," + checkBox40.Text.ToString();
                skills_id += " " + "37";
            }

        }

        private void sk25_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = sk25.Text.ToString();
                skills_id = "38";
            }
            else
            {
                skills += "," + sk25.Text.ToString();
                skills_id += " " + "38";
            }

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox45.Text.ToString();
                skills_id = "39";
            }
            else
            {
                skills += "," + checkBox45.Text.ToString();
                skills_id += " " + "39";
            }

        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox41.Text.ToString();
                skills_id = "40";
            }
            else
            {
                skills += "," + checkBox41.Text.ToString();
                skills_id += " " + "40";
            }

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox47.Text.ToString();
                skills_id = "41";
            }
            else
            {
                skills += "," + checkBox47.Text.ToString();
                skills_id += " " + "41";
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox42.Text.ToString();
                skills_id = "42";
            }
            else
            {
                skills += "," + checkBox42.Text.ToString();
                skills_id += " " + "42";
            }

        }
        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (skills == null)
            {
                skills = checkBox39.Text.ToString();
                skills_id = "24";
            }
            else
            {
                skills += "," + checkBox39.Text.ToString();
                skills_id += " " + "24";
            }
        }
    }
}




