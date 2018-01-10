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
        public SearchC(string s, string a, int id_conectat)
        {
            id_cine_e_conectat = id_conectat;
            if (a.Equals("Companie"))
            {
                InitializeComponent1();
            }
            else
                InitializeComponent();
            search = s;
          
            LinkedinEntities5 context = new LinkedinEntities5();

            dataGridView1.DataSource = context.Companie.Where(x =>x.ID_Companie!=id_conectat && x.Nume_companie.Contains(search)).ToList();

           


          
                
        
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string abc = dataGridView1.Rows[e.RowIndex].Cells[ID_Companie.Index].Value.ToString();

            Form form = new SentMessage(abc, id_cine_e_conectat, "Client-Companie");
            form.Show();
        }
    }
}
