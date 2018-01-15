using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace proiect
{
    public partial class SignIn : Form
    {
        static string firstname;
        static string lastname;
        static string username;
        static string pass;
        static string checkpass;
        static string phone;
        static string email;
        static string date;
        static string universiy;
        static string adress;
        static string sex;
        static string status;
        static string nationality;
        static Byte[] result;
        static int sex_id;
        static int status_id;

        public static bool Conditions(string password)
        {
            int ok = 0;
            if (password.Length >= 6 && Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success)
                ok = 1;

            if (ok == 1)
                return true;
            return false;
        }
        public static bool IsPhoneNumber(string number)
        {
            if (Regex.Match(number, @"^(\+407[0-9]{8})$").Success ||
                Regex.Match(number, @"^(\+[1-9][0-9]{9})$").Success ||
                Regex.Match(number, @"^(07[0-9]{8})$").Success ||
                Regex.Match(number, @"^(0[1-9][0-9]{8})$").Success ||
                Regex.Match(number, @"^(\+[1-9][0-9]{10})$").Success)
                return true;
            return false;
        }

        public static bool ValidEmailAddress(string emailAddress)
        {
            if (emailAddress.Length == 0)
                return false;
            
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                    return true;
            }

            return false;
        }

        public static bool IfExistsUsername(string username)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Client
                          select new
                          {
                              c.Username
                          };

            foreach (var item in results)
            {
                if (item.Username.Equals(username))
                    ok = 1;
            }

            var results_companie = from c in context.Companie
                          select new
                          {
                              c.Nume_companie
                          };

            foreach (var item in results_companie)
            {
                if (item.Nume_companie.Equals(username))
                    ok = 1;
            }

            if (ok == 1)
                return true;

            return false;

        }

        public static bool IfExistsEmail(string mail)
        {
            int ok = 0;
            var context = new LinkedinEntities5();
            var results = from c in context.Client
                          select new
                          {
                              c.Email
                          };

            foreach (var item in results)
            {
                if (item.Email.Equals(mail))
                    ok = 1;
            }

            var resultsC = from c in context.Companie
                          select new
                          {
                              c.Email_companie
                          };

            foreach (var item in resultsC)
            {
                if (item.Email_companie.Equals(mail))
                    ok = 1;
            }

            if (ok == 1)
                return true;

            return false;

        }

        public SignIn()
        {
            InitializeComponent();
            //btNextClient.Visible = false;
            pbProfile.Image = Image.FromFile("profile.png");

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstname = txtFirstName.Text.ToString();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastname = txtLastName.Text.ToString();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text.ToString();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pass = txtPass.Text.ToString();
        }
      

        private void txtCheckPass_TextChanged(object sender, EventArgs e)
        {
            checkpass = txtCheckPass.Text.ToString();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text.ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {

                if (username != null && IfExistsUsername(username) == true)
                {
                    throw new Exception("Username already exist!");
                }

                else if (pass != null && Conditions(pass) == false)
                {
                    throw new Exception("Parola nu coresounde conditiilor!");
                }

                else if (pass != null && checkpass != null && pass.Equals(checkpass) == false)
                {
                    throw new Exception("Password dosen't match!");
                }

                else if (email != null && ValidEmailAddress(email) == false)
                {
                    throw new Exception("E-mail address must be valid e-mail address format!");
                }

                else if (IfExistsEmail(email) == true)
                {
                    throw new Exception("Email already exist!");
                }

                else if (IsPhoneNumber(phone) == false)

                {
                    throw new Exception("Number incorect!");
                }

                else if (firstname != null && lastname != null
                    && username != null && phone != null
                    && email != null && status != null
                    && pass != null && checkpass != null
                    && date != null && universiy != null
                    && adress != null && sex != null
                    && nationality != null && Skills.get_skill() != null)
                {
                    throw new Exception("Register successfully!");
                    this.Close();
                    CClient.inregistreaza_client(firstname, lastname, username, pass, phone, email, date, universiy, adress, sex_id, status_id, nationality, result);
                    Form form = new CClient(firstname, lastname, username, phone, email, date, universiy, adress, sex, status, nationality, Skills.get_skill(), pbProfile.Image);
                    form.Show();
                }
                else
                {
                    throw new Exception("Some empty filled!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUniversity_TextChanged(object sender, EventArgs e)
        {
            universiy = txtUniversity.Text.ToString();
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            adress = txtAdress.Text.ToString();
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = cbSex.Text.ToString();
            if (sex.Equals("Male"))
                sex_id = 1;
            else sex_id = 2;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cbStatus.Text.ToString();
            if (status.Equals("Single"))
                status_id = 1;
            else if (status.Equals("In a relationship"))
                status_id = 2;
            else if (status.Equals("It's complicated"))
                status_id = 3;
            else if (status.Equals("Widow"))
                status_id = 4;
            else if (status.Equals("Divorced"))
                status_id = 5;
            else if (status.Equals("Marriage"))
                status_id = 6;
        }

        private void btPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.jpeg *.png *.jpg |All| *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(ofd.FileName);
            }
            result = (Byte[])new ImageConverter().ConvertTo(pbProfile.Image, typeof(Byte[]));
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = cbDay.Text.ToString();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = date + "/" + cbMonth.Text.ToString();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = date + "/" + cbYear.Text.ToString();
        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationality = cbNationality.Text.ToString();
        }

        private void btSkills_Click(object sender, EventArgs e)
        {
            Form forms = new Skills();
            forms.ShowDialog();
        }
    }
}

