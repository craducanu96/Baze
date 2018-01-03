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
    public partial class SentMessage : Form
    {
        public static string message;

        public SentMessage(string dest)
        {
            InitializeComponent();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            message = txtMessage.ToString();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (message != null)
            {
                MessageBox.Show("Message was sent",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                message = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't send an emply message",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
