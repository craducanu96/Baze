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
    public partial class Search : Form
    {
        //argumentul e ce cauta el in baza de date
        public Search(string search)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Friend request was sent",
                "Infomation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
