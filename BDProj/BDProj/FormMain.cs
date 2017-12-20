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
        private User userLoggedIn;
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
                userLoggedIn = user;
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
            AddUser addUser = new AddUser(context);
            addUser.ShowDialog();
            //addUser.Fo
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
            bookToReserve.UserId = userLoggedIn.Id;
            context.SubmitChanges();
            MessageBox.Show("Zarezerwowano");

        }

        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            var users = from userss in context.Users
                select new
                {
                    userss.Firstname,
                    userss.Lastname,
                    userss.Email,
                    userss.Phone,
                    userss.Address,
                    userss.City,
                    userss.ZipCode,
                    userss.Country
                };

            dataGridViewShowData.DataSource = users;
        }

        private void buttonShowAvailableBooks_Click(object sender, EventArgs e)
        {
            var availableBooks = from books in context.Books
                join copies in context.Copies on books.Id equals copies.BookId
                where copies.Status == "Dostępna"
                select copies.Book;

            dataGridViewShowData.DataSource = availableBooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lateBorrowings = from late in context.Spoznienis select late;

            dataGridViewShowData.DataSource = lateBorrowings;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(context);
            addBook.ShowDialog();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            var titleToReserve = textBoxReservation.Text;

            if (titleToReserve == "")
            {
                MessageBox.Show("Podaj tytuł książki do wypożyczenia.");
                return;
            }

            var bookToBorrow = (from books in context.Books
                                 join copies in context.Copies on books.Id equals copies.BookId
                                 where ((copies.Status == "Dostępna") || (copies.Status == "Zarezerwowana")) && books.Name == titleToReserve
                                 select copies).FirstOrDefault();

            if (bookToBorrow == null)
            {
                MessageBox.Show("Brak dostępnej książki do wypożyczenia");
                return;
            }

            if(bookToBorrow.Status == "Dostępna")
            {
                bookToBorrow.Status = "Wypożyczona";
            }
            else if(bookToBorrow.Status == "Zarezerwowana")
            {
                if(bookToBorrow.UserId==userLoggedIn.Id)
                    bookToBorrow.Status = "Wypożyczona";
                else
                {
                    MessageBox.Show("Brak dostępnej książki do wypożyczenia");
                    return;
                }
            }
            var borrowingToAdd = new Borrowing();
            borrowingToAdd.CopyId = bookToBorrow.Id;
            //borrowingToAdd.UserId = 
            context.SubmitChanges();
            MessageBox.Show("Wypożyczono");
        }
    }
}
