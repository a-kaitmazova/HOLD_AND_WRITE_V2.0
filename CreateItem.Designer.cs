
namespace HOLD_AND_WRITE
{
    partial class CreateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateItem));
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelCreateItem = new System.Windows.Forms.Button();
            this.buttonCreateItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(28, 76);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(498, 22);
            this.textBoxItemName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите название предмета:";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(26, 169);
            this.textBoxItem.Multiline = true;
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(500, 190);
            this.textBoxItem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите описание предмета:";
            // 
            // buttonCancelCreateItem
            // 
            this.buttonCancelCreateItem.Location = new System.Drawing.Point(26, 379);
            this.buttonCancelCreateItem.Name = "buttonCancelCreateItem";
            this.buttonCancelCreateItem.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelCreateItem.TabIndex = 7;
            this.buttonCancelCreateItem.Text = "Закрыть";
            this.buttonCancelCreateItem.UseVisualStyleBackColor = true;
            this.buttonCancelCreateItem.Click += new System.EventHandler(this.buttonCancelCreateItem_Click);
            // 
            // buttonCreateItem
            // 
            this.buttonCreateItem.Location = new System.Drawing.Point(393, 379);
            this.buttonCreateItem.Name = "buttonCreateItem";
            this.buttonCreateItem.Size = new System.Drawing.Size(133, 46);
            this.buttonCreateItem.TabIndex = 6;
            this.buttonCreateItem.Text = "Сохранить";
            this.buttonCreateItem.UseVisualStyleBackColor = true;
            this.buttonCreateItem.Click += new System.EventHandler(this.buttonCreateItem_Click);
            // 
            // CreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 455);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelCreateItem);
            this.Controls.Add(this.buttonCreateItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateItem";
            this.Text = "Создать карточку предмета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelCreateItem;
        private System.Windows.Forms.Button buttonCreateItem;
    }
}