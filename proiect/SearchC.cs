using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
namespace proiect
{
    public partial class SearchC : Form
    {
        public static string search;
        public static int id_cine_e_conectat;
        public SearchC(string s, int id_conectat)
        {
            InitializeComponent();
            search = s;
            id_cine_e_conectat = id_conectat;
            LinkedinEntities3 context = new LinkedinEntities3();

            dataGridView1.DataSource = context.Companie.Where(x =>x.ID_Companie!=id_conectat && x.Nume_companie.Contains(search)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aici trbuie sa luati usernamul din datagridview si sa-l dati parametru la form
            //Form form = new SentMessage(search);
            //form.Show();
        }
    }
}
