
namespace HOLD_AND_WRITE
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
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonCancelBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(18, 59);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(301, 22);
            this.textBoxBookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название книги:";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(195, 98);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(124, 49);
            this.buttonAddBook.TabIndex = 2;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // buttonCancelBook
            // 
            this.buttonCancelBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelBook.Location = new System.Drawing.Point(18, 98);
            this.buttonCancelBook.Name = "buttonCancelBook";
            this.buttonCancelBook.Size = new System.Drawing.Size(124, 49);
            this.buttonCancelBook.TabIndex = 3;
            this.buttonCancelBook.Text = "Закрыть";
            this.buttonCancelBook.UseVisualStyleBackColor = true;
            this.buttonCancelBook.Click += new System.EventHandler(this.CancelBook_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 171);
            this.Controls.Add(this.buttonCancelBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBookName);
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.Text = "Добавить книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonCancelBook;
    }
}