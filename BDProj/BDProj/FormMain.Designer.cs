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
            this.buttonShowLate = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(247, 15);
            this.dataGridViewShowData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.Size = new System.Drawing.Size(575, 294);
            this.dataGridViewShowData.TabIndex = 0;
            // 
            // buttonShowAllBorrows
            // 
            this.buttonShowAllBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAllBorrows.Location = new System.Drawing.Point(692, 316);
            this.buttonShowAllBorrows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowAllBorrows.Name = "buttonShowAllBorrows";
            this.buttonShowAllBorrows.Size = new System.Drawing.Size(129, 49);
            this.buttonShowAllBorrows.TabIndex = 1;
            this.buttonShowAllBorrows.Text = "Pokaż Wszystkie wypożyczenia";
            this.buttonShowAllBorrows.UseVisualStyleBackColor = true;
            this.buttonShowAllBorrows.Click += new System.EventHandler(this.buttonShowAllBorrows_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(16, 34);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 22);
            this.textBoxLogin.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(16, 15);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(16, 68);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(16, 87);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 119);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook.Location = new System.Drawing.Point(692, 373);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(129, 48);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Dodaj Książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(16, 166);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(129, 48);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Dodaj użytkownika";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearch.Location = new System.Drawing.Point(329, 330);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(132, 22);
            this.textBoxSearch.TabIndex = 9;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(243, 334);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(76, 17);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Wyszukaj: ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.Location = new System.Drawing.Point(471, 327);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRecentlyAdded
            // 
            this.buttonRecentlyAdded.Location = new System.Drawing.Point(327, 362);
            this.buttonRecentlyAdded.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRecentlyAdded.Name = "buttonRecentlyAdded";
            this.buttonRecentlyAdded.Size = new System.Drawing.Size(136, 28);
            this.buttonRecentlyAdded.TabIndex = 12;
            this.buttonRecentlyAdded.Text = "Ostatnio dodane";
            this.buttonRecentlyAdded.UseVisualStyleBackColor = true;
            this.buttonRecentlyAdded.Click += new System.EventHandler(this.buttonRecentlyAdded_Click);
            // 
            // textBoxReservation
            // 
            this.textBoxReservation.Location = new System.Drawing.Point(16, 396);
            this.textBoxReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReservation.Name = "textBoxReservation";
            this.textBoxReservation.Size = new System.Drawing.Size(132, 22);
            this.textBoxReservation.TabIndex = 13;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(16, 428);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(100, 28);
            this.buttonReservation.TabIndex = 14;
            this.buttonReservation.Text = "Zarezerwuj";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowUsers.Location = new System.Drawing.Point(692, 428);
            this.buttonShowUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(129, 49);
            this.buttonShowUsers.TabIndex = 15;
            this.buttonShowUsers.Text = "Pokaż klientów";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // buttonShowAvailableBooks
            // 
            this.buttonShowAvailableBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAvailableBooks.Location = new System.Drawing.Point(555, 428);
            this.buttonShowAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowAvailableBooks.Name = "buttonShowAvailableBooks";
            this.buttonShowAvailableBooks.Size = new System.Drawing.Size(129, 49);
            this.buttonShowAvailableBooks.TabIndex = 16;
            this.buttonShowAvailableBooks.Text = "Pokaż dostępne książki";
            this.buttonShowAvailableBooks.UseVisualStyleBackColor = true;
            this.buttonShowAvailableBooks.Click += new System.EventHandler(this.buttonShowAvailableBooks_Click);
            // 
            // buttonShowLate
            // 
            this.buttonShowLate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowLate.Location = new System.Drawing.Point(555, 373);
            this.buttonShowLate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowLate.Name = "buttonShowLate";
            this.buttonShowLate.Size = new System.Drawing.Size(129, 49);
            this.buttonShowLate.TabIndex = 17;
            this.buttonShowLate.Text = "Pokaż spóźnione";
            this.buttonShowLate.UseVisualStyleBackColor = true;
            this.buttonShowLate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(148, 428);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(100, 28);
            this.buttonBorrow.TabIndex = 18;
            this.buttonBorrow.Text = "Wypożycz";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 503);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonShowLate);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button buttonShowLate;
        private System.Windows.Forms.Button buttonBorrow;
    }
}

