using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProj
{
    public partial class FormMain : Form
    {
        private DataLibraryDataContext context = new DataLibraryDataContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonShowAllBorrows_Click(object sender, EventArgs e)
        {
            var borrows = from wypozyczenia in context.wypozyczenias select wypozyczenia;
            dataGridViewShowData.DataSource = borrows;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = (from usr in context.Users
                where usr.Email == textBoxLogin.Text && usr.Password == textBoxPassword.Text
                select usr.Email).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show($"Witaj użytkowniku {user}", "OK!");
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło.", "Błąd!");
            }
        }
    }
}
