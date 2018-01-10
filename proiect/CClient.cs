using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;

namespace proiect
{

    public partial class CClient : Form
    {
        public static string search;
        public static int c_panel_Details = 0;
        public static int c_panel_Notification = 0;
        public static int open_message = 0;
        public static string rating;
        public static DataGrid grid;


        //private string PasswordSalt
        //{
        //    get
        //    {
        //        var rng = new RNGCryptoServiceProvider();
        //        var buff = new byte[32];
        //        rng.GetBytes(buff);
        //        return Convert.ToBase64String(buff);
        //    }
        //}

        //private string EncodePassword(string password, string salt)
        //{
        //    byte[] bytes = Encoding.Unicode.GetBytes(password);
        //    byte[] src = Encoding.Unicode.GetBytes(salt);
        //    byte[] dst = new byte[src.Length + bytes.Length];
        //    Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        //    Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
        //    HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
        //    byte[] inarray = algorithm.ComputeHash(dst);
        //    return Convert.ToBase64String(inarray);
        //}

        public sealed class SecurePasswordHasher
        {
            private const int SaltSize = 16;

            private const int HashSize = 20;

            public static string Hash(string password, int iterations)
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                var hash = pbkdf2.GetBytes(HashSize);

                var hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                var base64Hash = Convert.ToBase64String(hashBytes);

                return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
            }
            public static string Hash(string password)
            {
                return Hash(password, 10000);
            }
            public static bool IsHashSupported(string hashString)
            {
                return hashString.Contains("$MYHASH$V1$");
            }

            public static bool Verify(string password, string hashedPassword)
            {
                if (!IsHashSupported(hashedPassword))
                {
                    throw new NotSupportedException("The hashtype is not supported");
                }
                var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
                var iterations = int.Parse(splittedHashString[0]);
                var base64Hash = splittedHashString[1];

                var hashBytes = Convert.FromBase64String(base64Hash);

                var salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                for (var i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static void inregistreaza_client(string firstname, string lastname, string username, string pass, string phone, string email, string date, string university, string address, int sex_id, int status_id, string nationality, Byte[] result)
        {

           
            string format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime myDate = DateTime.ParseExact(date, format, provider);

            string hash = SecurePasswordHasher.Hash(pass);
            var verifica = SecurePasswordHasher.Verify(pass, hash);

            char[] delimiters = { ',' };
            string skills = Skills.get_skill();
            string[] words = skills.Split(delimiters);


            var newClient = new Client()
            {
                Nume = firstname,
                Prenume = lastname,
                Data_Nasterii = myDate,
                Email = email,
                Poza = result,
                Facultate_absolvita = university,
                ID_sex = sex_id,
                ID_statut_social = status_id,
                Adresa = address,
                Telefon = phone,
                Nationalitate = nationality,
                Limbi_straine = "engleza",
                Username = username,
                Parola = hash
            };

            foreach (string s in words)
            {
                Aptitudini apt = new Aptitudini { Aptitudine = s };
                newClient.Aptitudini.Add(apt);
            }

            using (var context = new LinkedinEntities3())
            {
                context.Client.Add(newClient);
                context.SaveChanges();
            }

        }
        int id_client_logat;
        public CClient(string firstname, string lastname, string username, string phone, string email, string date, string university, string address, string sex, string status, string nationality, string skills)
        {
            InitializeComponent();
            picMessaging.Image = Image.FromFile("message.png");
            picRequest.Image = Image.FromFile("notification.png");
            picMe.Image = Image.FromFile("profile.png");

            panelDetails.Visible = false;
            panelNotification.Visible = false;

            lbUsername.Text = firstname + ' ' + lastname + ' ' + username;
            txtAddress.Text = address;
            txtBirth.Text = date;
            txtEmail.Text = email;
            txtNationality.Text = nationality;
            txtPhone.Text = phone;
            txtSex.Text = sex;
            txtStatus.Text = status;
            txtUniversiy.Text = university;
           
            char[] delimiters = { ',' };
            string[] words = skills.Split(delimiters);

            foreach (string s in words)
            {
                listSkils.Items.Add(s);
            }
            using (var context = new LinkedinEntities3())
            {
                id_client_logat = (from c in context.Client
                                   where c.Username.Equals(username)
                                   select c.ID_Client).First();

            }
            using (var context = new LinkedinEntities3())
            {
                int count = (from o in context.Rating
                             where o.ID_client_receive == id_client_logat
                             select o).Count();
                var note = from o in context.Rating
                           where o.ID_client_receive == id_client_logat
                           select o.Nota;
                int suma = 0;

                foreach (int nota in note)
                {
                    suma += nota;
                }
                if (count != 0)
                {
                    float medie = suma / count;
                    listBox1.Items.Add(medie.ToString());
                }
                else
                {
                    listBox1.Items.Add(suma.ToString());
                }
            }

        }


        private void lbDetails_Click(object sender, EventArgs e)
        {
            c_panel_Details++;
            if (c_panel_Details % 2 == 0)
                panelDetails.Visible = true;
            else
                panelDetails.Visible = false;
        }

        private void picRequest_Click(object sender, EventArgs e)
        {
            c_panel_Notification++;
            if (c_panel_Notification % 2 == 0)
                panelNotification.Visible = true;
            else
                panelNotification.Visible = false;

        }

        private void picMessaging_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
            panelNotification.Visible = false;

            Form form = new Messaging();
            form.Show();


        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Text.ToString();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //aici trebuie sa cautati in baza de date si sa afisati in gridView
            if (search != null)
            {

                using (var context = new LinkedinEntities3())
                {
                    var results = from c in context.Client
                                  where c.Nume.Contains(search) || c.Prenume.Contains(search)
                                  select c;
                    if (results.Any())
                    {

                        Form form = new Search(search, "Client", id_client_logat);
                        form.Show();

                    }
                    else
                    {
                        var results1 = from c in context.Companie
                                       where c.Nume_companie.Contains(search)
                                       select c;
                        if (results1.Any())
                        {

                            Form form = new SearchC(search,"Client", id_client_logat);
                            form.Show();
                        }
                        else MessageBox.Show("Utilizatorul nu exista!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Search box is empty, can't search",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Friend requesst accepted",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
        }

        private void picMe_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
