namespace BDProj
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.buttonShowAllBorrows = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRecentlyAdded = new System.Windows.Forms.Button();
            this.textBoxReservation = new System.Windows.Forms.TextBox();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.buttonShowAvailableBooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(185, 12);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.Size = new System.Drawing.Size(431, 239);
            this.dataGridViewShowData.TabIndex = 0;
            // 
            // buttonShowAllBorrows
            // 
            this.buttonShowAllBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAllBorrows.Location = new System.Drawing.Point(519, 257);
            this.buttonShowAllBorrows.Name = "buttonShowAllBorrows";
            this.buttonShowAllBorrows.Size = new System.Drawing.Size(97, 40);
            this.buttonShowAllBorrows.TabIndex = 1;
            this.buttonShowAllBorrows.Text = "Pokaż Wszystkie wypożyczenia";
            this.buttonShowAllBorrows.UseVisualStyleBackColor = true;
            this.buttonShowAllBorrows.Click += new System.EventHandler(this.buttonShowAllBorrows_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 28);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 55);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 97);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook.Location = new System.Drawing.Point(519, 303);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(97, 39);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Dodaj Książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(12, 135);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(97, 39);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Dodaj użytkownika";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.Location = new System.Drawing.Point(247, 268);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 9;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(182, 271);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 13);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Wyszukaj: ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.Location = new System.Drawing.Point(353, 266);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRecentlyAdded
            // 
            this.buttonRecentlyAdded.Location = new System.Drawing.Point(245, 294);
            this.buttonRecentlyAdded.Name = "buttonRecentlyAdded";
            this.buttonRecentlyAdded.Size = new System.Drawing.Size(102, 23);
            this.buttonRecentlyAdded.TabIndex = 12;
            this.buttonRecentlyAdded.Text = "Ostatnio dodane";
            this.buttonRecentlyAdded.UseVisualStyleBackColor = true;
            this.buttonRecentlyAdded.Click += new System.EventHandler(this.buttonRecentlyAdded_Click);
            // 
            // textBoxReservation
            // 
            this.textBoxReservation.Location = new System.Drawing.Point(12, 322);
            this.textBoxReservation.Name = "textBoxReservation";
            this.textBoxReservation.Size = new System.Drawing.Size(100, 20);
            this.textBoxReservation.TabIndex = 13;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(12, 348);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonReservation.TabIndex = 14;
            this.buttonReservation.Text = "Zarezerwuj";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowUsers.Location = new System.Drawing.Point(519, 348);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(97, 40);
            this.buttonShowUsers.TabIndex = 15;
            this.buttonShowUsers.Text = "Pokaż klientów";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // buttonShowAvailableBooks
            // 
            this.buttonShowAvailableBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAvailableBooks.Location = new System.Drawing.Point(416, 348);
            this.buttonShowAvailableBooks.Name = "buttonShowAvailableBooks";
            this.buttonShowAvailableBooks.Size = new System.Drawing.Size(97, 40);
            this.buttonShowAvailableBooks.TabIndex = 16;
            this.buttonShowAvailableBooks.Text = "Pokaż dostępne książki";
            this.buttonShowAvailableBooks.UseVisualStyleBackColor = true;
            this.buttonShowAvailableBooks.Click += new System.EventHandler(this.buttonShowAvailableBooks_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(416, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pokaż spóźnione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonShowAvailableBooks);
            this.Controls.Add(this.buttonShowUsers);
            this.Controls.Add(this.buttonReservation);
            this.Controls.Add(this.textBoxReservation);
            this.Controls.Add(this.buttonRecentlyAdded);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonShowAllBorrows);
            this.Controls.Add(this.dataGridViewShowData);
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.Text = "Okno Główne";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.Button buttonShowAllBorrows;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRecentlyAdded;
        private System.Windows.Forms.TextBox textBoxReservation;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.Button buttonShowAvailableBooks;
        private System.Windows.Forms.Button button1;
    }
}

