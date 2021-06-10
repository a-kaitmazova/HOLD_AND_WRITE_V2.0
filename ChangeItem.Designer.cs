
namespace HOLD_AND_WRITE
{
    partial class ChangeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeItem));
            this.listItems = new System.Windows.Forms.ListBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelChangeItem = new System.Windows.Forms.Button();
            this.buttonChangeItem = new System.Windows.Forms.Button();
            this.pictureWithoutCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).BeginInit();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 16;
            this.listItems.Location = new System.Drawing.Point(30, 32);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(451, 420);
            this.listItems.TabIndex = 20;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(505, 96);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(498, 22);
            this.textBoxItemName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(503, 197);
            this.textBoxItem.Multiline = true;
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(500, 190);
            this.textBoxItem.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Описание:";
            // 
            // buttonCancelChangeItem
            // 
            this.buttonCancelChangeItem.Location = new System.Drawing.Point(503, 406);
            this.buttonCancelChangeItem.Name = "buttonCancelChangeItem";
            this.buttonCancelChangeItem.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelChangeItem.TabIndex = 15;
            this.buttonCancelChangeItem.Text = "Закрыть";
            this.buttonCancelChangeItem.UseVisualStyleBackColor = true;
            this.buttonCancelChangeItem.Click += new System.EventHandler(this.buttonCancelChangeItem_Click);
            // 
            // buttonChangeItem
            // 
            this.buttonChangeItem.Location = new System.Drawing.Point(870, 406);
            this.buttonChangeItem.Name = "buttonChangeItem";
            this.buttonChangeItem.Size = new System.Drawing.Size(133, 46);
            this.buttonChangeItem.TabIndex = 14;
            this.buttonChangeItem.Text = "Сохранить";
            this.buttonChangeItem.UseVisualStyleBackColor = true;
            this.buttonChangeItem.Click += new System.EventHandler(this.buttonChangeItem_Click);
            // 
            // pictureWithoutCard
            // 
            this.pictureWithoutCard.Location = new System.Drawing.Point(503, 38);
            this.pictureWithoutCard.Name = "pictureWithoutCard";
            this.pictureWithoutCard.Size = new System.Drawing.Size(500, 413);
            this.pictureWithoutCard.TabIndex = 21;
            this.pictureWithoutCard.TabStop = false;
            // 
            // ChangeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1042, 491);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelChangeItem);
            this.Controls.Add(this.buttonChangeItem);
            this.Controls.Add(this.pictureWithoutCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeItem";
            this.Text = "Изменение карточки предмета";
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelChangeItem;
        private System.Windows.Forms.Button buttonChangeItem;
        private System.Windows.Forms.PictureBox pictureWithoutCard;
    }
}