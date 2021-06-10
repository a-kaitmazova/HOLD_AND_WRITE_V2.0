
namespace HOLD_AND_WRITE
{
    partial class DeleteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBook));
            this.buttonCancelDeleteBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancelDeleteBook
            // 
            this.buttonCancelDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelDeleteBook.Location = new System.Drawing.Point(29, 442);
            this.buttonCancelDeleteBook.Name = "buttonCancelDeleteBook";
            this.buttonCancelDeleteBook.Size = new System.Drawing.Size(117, 37);
            this.buttonCancelDeleteBook.TabIndex = 0;
            this.buttonCancelDeleteBook.Text = "Закрыть";
            this.buttonCancelDeleteBook.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteBook.Click += new System.EventHandler(this.CancelDeleteBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(304, 442);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(119, 37);
            this.buttonDeleteBook.TabIndex = 1;
            this.buttonDeleteBook.Text = "Удалить";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите книгу для удаления:";
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 16;
            this.listBooks.Location = new System.Drawing.Point(29, 67);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(394, 356);
            this.listBooks.TabIndex = 3;
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 506);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonCancelDeleteBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteBook";
            this.Text = "Удалить книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelDeleteBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBooks;
    }
}