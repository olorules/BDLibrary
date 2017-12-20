using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProj
{

    public partial class AddUser : Form
    {
        DataLibraryDataContext context;
        public AddUser(DataLibraryDataContext context)
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.context = context;
            this.Focus();
        }

        public string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Length<63 && textBoxSurname.Text.Length < 63 && textBoxEMail.Text.Length < 63 &&
                textBoxPhoneNumber.Text.Length < 15 && textBoxAddress.Text.Length < 63 && textBoxCity.Text.Length < 63 &&
                textBoxCountry.Text.Length < 31 && textBoxZipCode.Text.Length < 7 &&
                textBoxName.Text.Length > 0 && textBoxSurname.Text.Length > 0 && textBoxEMail.Text.Length > 0 &&
                textBoxPhoneNumber.Text.Length > 0 && textBoxAddress.Text.Length > 0 && textBoxCity.Text.Length > 0 &&
                textBoxCountry.Text.Length > 0 && textBoxZipCode.Text.Length > 0)
            {
                var user = (from usr in context.Users
                where usr.Email == textBoxEMail.Text select usr).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Klient ma już konto w bazie danych!", "Klient w bazie!");
                }
                else
                {
                    var userToAdd = new User();
                    userToAdd.Firstname = textBoxName.Text;
                    userToAdd.Lastname = textBoxSurname.Text;
                    userToAdd.Email = textBoxEMail.Text;
                    userToAdd.Phone = textBoxPhoneNumber.Text;
                    userToAdd.Address = textBoxAddress.Text;
                    userToAdd.City = textBoxCity.Text;
                    userToAdd.Country = textBoxCountry.Text;
                    userToAdd.ZipCode = textBoxZipCode.Text;
                    var passwordToDataBase = CalculateMD5Hash(textBoxPassword.Text);
                    userToAdd.Password = passwordToDataBase;

                    context.Users.InsertOnSubmit(userToAdd);
                    context.SubmitChanges();
                    var userToCheck = (from usr in context.Users
                                where usr.Email == textBoxEMail.Text
                                select usr).FirstOrDefault();

                    if (userToCheck != null)
                    {
                        MessageBox.Show("Dodano!", "Dodano", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nieoczekiwany błąd!", "Błąd!", MessageBoxButtons.OK);
                    }
                }

            }
            MessageBox.Show("Nieprawidłowy format danych!", "Błąd!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anulowano");
            this.Close();
        }
    }
}
