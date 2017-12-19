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
            this.label1 = new System.Windows.Forms.Label();
            this.labelObligatoryData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa książki:";
            // 
            // labelObligatoryData
            // 
            this.labelObligatoryData.AutoSize = true;
            this.labelObligatoryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObligatoryData.Location = new System.Drawing.Point(12, 9);
            this.labelObligatoryData.Name = "labelObligatoryData";
            this.labelObligatoryData.Size = new System.Drawing.Size(98, 15);
            this.labelObligatoryData.TabIndex = 1;
            this.labelObligatoryData.Text = "Pola wymagane:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 2;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelObligatoryData);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "Dodaj Książkę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObligatoryData;
        private System.Windows.Forms.TextBox textBox1;
    }
}