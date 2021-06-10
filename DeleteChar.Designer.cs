
namespace HOLD_AND_WRITE
{
    partial class DeleteChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteChar));
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelDeleteChar = new System.Windows.Forms.Button();
            this.buttonDeleteChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCharacters
            // 
            this.listCharacters.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.ItemHeight = 17;
            this.listCharacters.Location = new System.Drawing.Point(34, 66);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(431, 344);
            this.listCharacters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите карточку для удаления:";
            // 
            // buttonCancelDeleteChar
            // 
            this.buttonCancelDeleteChar.Location = new System.Drawing.Point(34, 437);
            this.buttonCancelDeleteChar.Name = "buttonCancelDeleteChar";
            this.buttonCancelDeleteChar.Size = new System.Drawing.Size(141, 48);
            this.buttonCancelDeleteChar.TabIndex = 2;
            this.buttonCancelDeleteChar.Text = "Закрыть";
            this.buttonCancelDeleteChar.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteChar.Click += new System.EventHandler(this.CancelDeleteChar_Click);
            // 
            // buttonDeleteChar
            // 
            this.buttonDeleteChar.Location = new System.Drawing.Point(324, 437);
            this.buttonDeleteChar.Name = "buttonDeleteChar";
            this.buttonDeleteChar.Size = new System.Drawing.Size(141, 48);
            this.buttonDeleteChar.TabIndex = 3;
            this.buttonDeleteChar.Text = "Удалить";
            this.buttonDeleteChar.UseVisualStyleBackColor = true;
            this.buttonDeleteChar.Click += new System.EventHandler(this.DeletChar_Click);
            // 
            // DeleteChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 515);
            this.Controls.Add(this.buttonDeleteChar);
            this.Controls.Add(this.buttonCancelDeleteChar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCharacters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteChar";
            this.Text = "Удалить карточку персонажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCharacters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelDeleteChar;
        private System.Windows.Forms.Button buttonDeleteChar;
    }
}