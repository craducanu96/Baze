using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace proiect
{
    public partial class CCompanie : Form
    {
        public static string search;
        public static DataGrid data;
        public static int c_panel_Details = 0;
        public static int open_message = 0;

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

        public static void inregistreaza_companie(string director, string nume, string adresa, string email, string telefon, string parola)
        {

            string hash = SecurePasswordHasher.Hash(parola);

            char[] delimiters = { ',' };
            string skills = SignInCompany.get_skillsC();
            string[] words = skills.Split(delimiters);

            var contextC = new LinkedinEntities3();
            var newCompanie = new Companie()
            {
                Nume_companie = nume,
                Adresa_companie = adresa,
                Email_companie = email,
                Telefon_companie = telefon,
                UsernameC = nume,
                ParolaC = hash,
                Director_companie = director
            };

            foreach (string s in words)
            {
                Aptitudini apt = new Aptitudini { Aptitudine = s };
                newCompanie.Aptitudini.Add(apt);
            }

            using (var context = new LinkedinEntities3())
            {
                context.Companie.Add(newCompanie);
                context.SaveChanges();
            }

        }
        public static int id_companie_logata;
        public CCompanie(string director, string nume, string adresa, string email, string telefon, string SkillsC)
        {
            InitializeComponent();
            picMessaging.Image = Image.FromFile("letter.png");

            panelDetails.Visible = false;

            lbCompanyName.Text = nume;
            txtCEO.Text = director;
            txtAddress.Text = adresa;
            txtEmail.Text = email;
            txtPhone.Text = telefon;


            string[] words = SkillsC.Split(',');
            foreach (string s in words)
            {
                txtSkillsRequest.Text += s + ' ';
            }
            using (var context = new LinkedinEntities3())
            {
                id_companie_logata = (from c in context.Companie
                                   where c.UsernameC.Equals(nume)
                                   select c.ID_Companie).First();

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

        private void picMessaging_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;

            Form form = new Messaging();
            form.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.ToString();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            search = txtSearch.Text.ToString();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (search != null)
            {
                if (search != null)
                {

                    using (var context = new LinkedinEntities3())
                    {
                        var results = from c in context.Client
                                      where c.Nume.Contains(search) || c.Prenume.Contains(search)
                                      select c;
                        if (results.Any())
                        {

                            Form form = new Search(search, "Companie", id_companie_logata);
                           
                            form.Show();

                        }
                        else
                        {
                            var results1 = from c in context.Companie
                                           where c.Nume_companie.Contains(search)
                                           select c;
                            if (results1.Any())
                            {

                                Form form = new SearchC(search, id_companie_logata);
                                form.Show();
                            }
                            else MessageBox.Show("Utilizatorul nu exista!");


                        }



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

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


