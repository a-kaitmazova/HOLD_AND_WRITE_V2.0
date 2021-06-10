
namespace HOLD_AND_WRITE
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            this.listItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCanselDeleteUtem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 16;
            this.listItems.Location = new System.Drawing.Point(25, 70);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(451, 420);
            this.listItems.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Выберите предмет для удаления:";
            // 
            // buttonCanselDeleteUtem
            // 
            this.buttonCanselDeleteUtem.Location = new System.Drawing.Point(25, 513);
            this.buttonCanselDeleteUtem.Name = "buttonCanselDeleteUtem";
            this.buttonCanselDeleteUtem.Size = new System.Drawing.Size(125, 45);
            this.buttonCanselDeleteUtem.TabIndex = 23;
            this.buttonCanselDeleteUtem.Text = "Закрыть";
            this.buttonCanselDeleteUtem.UseVisualStyleBackColor = true;
            this.buttonCanselDeleteUtem.Click += new System.EventHandler(this.buttonCanselDeleteUtem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(351, 513);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(125, 45);
            this.buttonDeleteItem.TabIndex = 24;
            this.buttonDeleteItem.Text = "Удалить";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(506, 587);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonCanselDeleteUtem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteItem";
            this.Text = "Удаление карточки предмета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCanselDeleteUtem;
        private System.Windows.Forms.Button buttonDeleteItem;
    }
}