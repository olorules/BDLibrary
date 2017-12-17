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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.Size = new System.Drawing.Size(431, 239);
            this.dataGridViewShowData.TabIndex = 0;
            // 
            // buttonShowAllBorrows
            // 
            this.buttonShowAllBorrows.Location = new System.Drawing.Point(450, 13);
            this.buttonShowAllBorrows.Name = "buttonShowAllBorrows";
            this.buttonShowAllBorrows.Size = new System.Drawing.Size(97, 40);
            this.buttonShowAllBorrows.TabIndex = 1;
            this.buttonShowAllBorrows.Text = "Pokaż Wszystkie wypożyczenia";
            this.buttonShowAllBorrows.UseVisualStyleBackColor = true;
            this.buttonShowAllBorrows.Click += new System.EventHandler(this.buttonShowAllBorrows_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.Controls.Add(this.buttonShowAllBorrows);
            this.Controls.Add(this.dataGridViewShowData);
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.Text = "Okno Główne";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.Button buttonShowAllBorrows;
    }
}

