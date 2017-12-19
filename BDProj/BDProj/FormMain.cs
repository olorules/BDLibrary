using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BDProj
{
    public partial class FormMain : Form
    {
        private DataLibraryDataContext context = new DataLibraryDataContext();

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
            var hashedValue = CalculateMD5Hash(textBoxPassword.Text);
            var user = (from usr in context.Users
                where usr.Email == textBoxLogin.Text && usr.Password == hashedValue
                select usr).FirstOrDefault();

            if (user != null)
            {
                if (user.Status == 'a')
                {
                    MessageBox.Show("Witaj użytkowniku Admin", "OK!");
                }
                else
                {
                    MessageBox.Show($"Witaj użytkowniku {user.Email}", "OK!");
                }
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło.", "Błąd!");
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var hashedValue = CalculateMD5Hash("usr3324");
            MessageBox.Show($"Witaj użytkowniku Admin "+hashedValue, "OK!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchValue = textBoxSearch.Text.ToLower();
            var searchedBooks = from books in context.Books
                join authorList in context.AuthorLists on books.Id equals authorList.BookId
                join authors in context.Authors on authorList.AuthorId equals authors.Id
                where books.Name.ToLower().Contains(searchValue) || books.Genre.ToLower().Contains(searchValue) ||
                      authors.Lastname.ToLower().Contains(searchValue)
                select new {books.Name, books.Genre, authors.Firstname, authors.Lastname};

            dataGridViewShowData.DataSource = searchedBooks;
        }

        private void buttonRecentlyAdded_Click(object sender, EventArgs e)
        {
            var recentlyAdded = from books in context.Books
                join authorList in context.AuthorLists on books.Id equals authorList.BookId
                join authors in context.Authors on authorList.AuthorId equals authors.Id
                where books.DateOfAdd > DateTime.Now.AddDays(-30)
                select new {books.Name, books.Genre, authors.Firstname, authors.Lastname};

            var recentlyAddedList = recentlyAdded.ToList();

            if (recentlyAddedList.Count == 0)
                MessageBox.Show("Brak ostatnio dodanych książek");
            else
            {
                dataGridViewShowData.DataSource = recentlyAddedList;
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            var titleToReserve = textBoxReservation.Text;

            if (titleToReserve == "")
            {
                MessageBox.Show("Podaj tytuł książki do rezerwacji.");
                return;
            }

            var bookToReserve = (from books in context.Books
                join copies in context.Copies on books.Id equals copies.BookId
                where copies.Status == "Dostępna" && books.Name == titleToReserve
                select copies).FirstOrDefault();

            if (bookToReserve == null)
            {
                MessageBox.Show("Brak dostępnej książki do rezerwacji");
                return;
            }
            
            bookToReserve.Status = "Zarezerwowana";
            context.SubmitChanges();
        }
    }
}
