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
    public partial class AddBook : Form
    {
        private DataLibraryDataContext context;
        List<Author> listOfAuthors;
        public AddBook(DataLibraryDataContext context)
        {
            InitializeComponent();
            listOfAuthors= new List<Author>();
            this.context = context;
        }

        public void PushAuthor(Author author)
        {
            listOfAuthors.Add(author);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor(this);
            addAuthor.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // First, we need to create the book, as the author list demands an id of the book
            if (textBoxName.Text.Length > 0 && textBoxISBN.Text.Length > 0 && textBoxGenre.Text.Length > 0 &&
                textBoxName.Text.Length < 63 && textBoxISBN.Text.Length < 15 && textBoxGenre.Text.Length < 31)
            {
                var bookToAdd = new Book();
                bookToAdd.Name = textBoxName.Text;
                bookToAdd.ISBN = textBoxISBN.Text;
                bookToAdd.Genre = textBoxGenre.Text;
                //Jak z tymi kopiami robimy

                context.Books.InsertOnSubmit(bookToAdd);
                context.SubmitChanges();

                //As we have just created the book, we check the id of it
                var bookId = from Book in context.Books
                             where (Book.Name == textBoxName.Text) && (Book.ISBN == textBoxISBN.Text)
                             && (Book.Genre == textBoxGenre.Text)
                             select Book.Id;

                int quantity = int.Parse(textBoxCopies.Text);
                for(int i=0;i<quantity;i++)
                {
                    Copy copyToAdd = new Copy();
                    copyToAdd.BookId = bookId.FirstOrDefault();
                    copyToAdd.Status = "Dostępna";
                    context.Copies.InsertOnSubmit(copyToAdd);
                    context.SubmitChanges();
                }

                List<int> authors = new List<int>();
                //checking if the Athor is already in DB
                foreach (Author element in listOfAuthors)
                {
                    var author = from Author in context.Authors
                                 where (Author.Firstname == element.Firstname) && (Author.Lastname == element.Lastname)
                                 select Author.Id;
                    authors.Add(author.FirstOrDefault());
                }

                foreach (int value in authors)
                {
                    if (value != 0)
                    {
                        var authorList = new AuthorList();
                        authorList.AuthorId = value;
                        authorList.BookId = bookId.FirstOrDefault();
                    }
                    else
                    {
                        //Create Author and then create the author list entity
                        var authorToAdd = new Author();
                        //authorToAdd.Firstname=
                    }
                }
            }
            else
            {
                MessageBox.Show("Zły format danych", "Błąd!");
            }
        }

    }
}
