
namespace HOLD_AND_WRITE
{
    partial class RenameBook
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
            this.listBooks = new System.Windows.Forms.ListBox();
            this.buttonRenameBook = new System.Windows.Forms.Button();
            this.buttonCancelRenameBook = new System.Windows.Forms.Button();
            this.textRenameBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBooks
            // 
            this.listBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 16;
            this.listBooks.Location = new System.Drawing.Point(29, 68);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(472, 258);
            this.listBooks.TabIndex = 0;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.SelectedBookName);
            // 
            // buttonRenameBook
            // 
            this.buttonRenameBook.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenameBook.Location = new System.Drawing.Point(324, 428);
            this.buttonRenameBook.Name = "buttonRenameBook";
            this.buttonRenameBook.Size = new System.Drawing.Size(177, 54);
            this.buttonRenameBook.TabIndex = 1;
            this.buttonRenameBook.Text = "Переименовать";
            this.buttonRenameBook.UseVisualStyleBackColor = true;
            this.buttonRenameBook.Click += new System.EventHandler(this.RenameBook_Click);
            // 
            // buttonCancelRenameBook
            // 
            this.buttonCancelRenameBook.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelRenameBook.Location = new System.Drawing.Point(29, 428);
            this.buttonCancelRenameBook.Name = "buttonCancelRenameBook";
            this.buttonCancelRenameBook.Size = new System.Drawing.Size(150, 54);
            this.buttonCancelRenameBook.TabIndex = 2;
            this.buttonCancelRenameBook.Text = "Закрыть";
            this.buttonCancelRenameBook.UseVisualStyleBackColor = true;
            this.buttonCancelRenameBook.Click += new System.EventHandler(this.CancelBook_Click);
            // 
            // textRenameBookName
            // 
            this.textRenameBookName.Location = new System.Drawing.Point(29, 385);
            this.textRenameBookName.Name = "textRenameBookName";
            this.textRenameBookName.Size = new System.Drawing.Size(472, 22);
            this.textRenameBookName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите книгу для переименования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите новое имя:";
            // 
            // RenameBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(537, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRenameBookName);
            this.Controls.Add(this.buttonCancelRenameBook);
            this.Controls.Add(this.buttonRenameBook);
            this.Controls.Add(this.listBooks);
            this.MaximizeBox = false;
            this.Name = "RenameBook";
            this.Text = "Переименовать книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.Button buttonRenameBook;
        private System.Windows.Forms.Button buttonCancelRenameBook;
        private System.Windows.Forms.TextBox textRenameBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}