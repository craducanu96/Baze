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

        public Skills()
        {
            skills = null;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (skills == null)
            {
                MessageBox.Show("No skill checked!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                this.Close();
        }

        private void sk1_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk1.ToString();
            skills_id += " " + "1";
        }

        private void sk2_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk2.ToString();
            skills_id += " " + "2";
        }

        private void sk3_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk3.ToString();
            skills_id += " " + "3";
        }

        private void sk4_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk4.ToString();
            skills_id += " " + "4";
        }

        private void sk5_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk5.ToString();
            skills_id += " " + "5";
        }

        private void sk6_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk6.ToString();
            skills_id += " " + "6";
        }

        private void sk7_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk7.ToString();
            skills_id += " " + "7";
        }

        private void sk8_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk8.ToString();
            skills_id += " " + "8";
        }

        private void sk9_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk9.ToString();
            skills_id += " " + "9";
        }

        private void sk10_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk10.ToString();
            skills_id += " " + "10";
        }

        private void sk11_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk11.ToString();
            skills_id += " " + "11";
        }

        private void sk12_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk12.ToString();
            skills_id += " " + "12";
        }

        private void sk13_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk13.ToString();
            skills_id += " " + "13";
        }

        private void sk14_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk14.ToString();
            skills_id += " " + "14";
        }

        private void sk15_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk15.ToString();
            skills_id += " " + "15";
        }

        private void sk16_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk16.ToString();
            skills_id += " " + "16";
        }

        private void sk29_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk29.ToString();
            skills_id += " " + "17";
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox48.ToString();
            skills_id += " " + "18";
        }

        private void sk27_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk27.ToString();
            skills_id += " " + "19";
        }

        private void sk28_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk28.ToString();
            skills_id += " " + "20";
        }

        private void sk17_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk17.ToString();
            skills_id += " " + "21";
        }

        private void sk18_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk18.ToString();
            skills_id += " " + "22";
        }

        private void sk19_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk19.ToString();
            skills_id += " " + "23";
        }

        /* private void checkBox44_CheckedChanged(object sender, EventArgs e)
         {
             skills += "," + checkBox44.ToString();
             skills_id += " " + "1";
         }*/

        private void sk24_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk24.ToString();
            skills_id += " " + "26";
        }

        private void sk20_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk20.ToString();
            skills_id += " " + "27";
        }

        private void sk21_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk21.ToString();
            skills_id += " " + "28";
        }

        private void sk32_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk32.ToString();
            skills_id += " " + "29";
        }

        private void sk31_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk31.ToString();
            skills_id += " " + "30";
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox43.ToString();
            skills_id += " " + "31";
        }

        private void sk26_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk26.ToString();
            skills_id += " " + "32";
        }

        private void sk23_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk23.ToString();
            skills_id += " " + "33";
        }

        private void sk30_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk30.ToString();
            skills_id += " " + "34";
        }

        private void sk22_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk22.ToString();
            skills_id += " " + "35";
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox46.ToString();
            skills_id += " " + "36";
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox40.ToString();
            skills_id += " " + "37";
        }

        private void sk25_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + sk25.ToString();
            skills_id += " " + "38";
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox45.ToString();
            skills_id += " " + "39";
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox41.ToString();
            skills_id += " " + "40";
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox47.ToString();
            skills_id += " " + "41";
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox42.ToString();
            skills_id += " " + "42";
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            skills += "," + checkBox39.ToString();
            skills_id += " " + "24";
        }

        private void checkBox44_CheckedChanged_1(object sender, EventArgs e)
        {
            skills += "," + checkBox44.ToString();
            skills_id += " " + "25";
        }
    }
}
