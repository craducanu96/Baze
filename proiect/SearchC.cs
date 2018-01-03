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
    public partial class SearchC : Form
    {
        public static string search;

        public SearchC(string s)
        {
            InitializeComponent();
            search = s;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aici trbuie sa luati usernamul din datagridview si sa-l dati parametru la form
            Form form = new SentMessage(search);
            form.Show();
        }
    }
}
