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
    public partial class AddAuthor : Form
    {
        AddBook addBook;
        public AddAuthor(AddBook addBook)
        {
            InitializeComponent();
            this.addBook = addBook;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != null || textBoxName.Text != "") &&
                textBoxSurname.Text != null || textBoxSurname.Text != "")
            {
                Author author = new Author()
                {
                    Firstname = textBoxName.Text,
                    Lastname = textBoxSurname.Text
                };
                addBook.PushAuthor(author);
                MessageBox.Show("Dodano!", "Dodano", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!", "Błąd!");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
