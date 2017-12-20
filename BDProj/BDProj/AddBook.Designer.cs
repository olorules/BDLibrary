namespace BDProj
{
    partial class AddBook
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelCopies = new System.Windows.Forms.Label();
            this.textBoxCopies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 18);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nazwa książki:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 15);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(236, 315);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(127, 43);
            this.buttonAddAuthor.TabIndex = 3;
            this.buttonAddAuthor.Text = "Dodaj Autora";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 379);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(263, 379);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(143, 47);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(196, 22);
            this.textBoxISBN.TabIndex = 7;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(16, 50);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(43, 17);
            this.labelISBN.TabIndex = 6;
            this.labelISBN.Text = "ISBN:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(143, 79);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(196, 22);
            this.textBoxGenre.TabIndex = 9;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(16, 82);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(66, 17);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Gatunek:";
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(16, 111);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(73, 17);
            this.labelCopies.TabIndex = 10;
            this.labelCopies.Text = "Ilość kopii:";
            // 
            // textBoxCopies
            // 
            this.textBoxCopies.Location = new System.Drawing.Point(143, 108);
            this.textBoxCopies.Name = "textBoxCopies";
            this.textBoxCopies.Size = new System.Drawing.Size(196, 22);
            this.textBoxCopies.TabIndex = 11;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 422);
            this.Controls.Add(this.textBoxCopies);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBook";
            this.Text = "Dodaj Książkę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.TextBox textBoxCopies;
    }
}