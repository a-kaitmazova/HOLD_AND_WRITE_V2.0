
namespace HOLD_AND_WRITE
{
    partial class ChangePlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePlace));
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelChangePlace = new System.Windows.Forms.Button();
            this.buttonChangePlace = new System.Windows.Forms.Button();
            this.listPlaces = new System.Windows.Forms.ListBox();
            this.pictureWithoutCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(497, 89);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(498, 22);
            this.textBoxPlaceName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(492, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(495, 190);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(500, 190);
            this.textBoxPlace.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(492, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Описание:";
            // 
            // buttonCancelChangePlace
            // 
            this.buttonCancelChangePlace.Location = new System.Drawing.Point(495, 399);
            this.buttonCancelChangePlace.Name = "buttonCancelChangePlace";
            this.buttonCancelChangePlace.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelChangePlace.TabIndex = 7;
            this.buttonCancelChangePlace.Text = "Закрыть";
            this.buttonCancelChangePlace.UseVisualStyleBackColor = true;
            this.buttonCancelChangePlace.Click += new System.EventHandler(this.CancelChangePlace_Click);
            // 
            // buttonChangePlace
            // 
            this.buttonChangePlace.Location = new System.Drawing.Point(862, 399);
            this.buttonChangePlace.Name = "buttonChangePlace";
            this.buttonChangePlace.Size = new System.Drawing.Size(133, 46);
            this.buttonChangePlace.TabIndex = 6;
            this.buttonChangePlace.Text = "Сохранить";
            this.buttonChangePlace.UseVisualStyleBackColor = true;
            this.buttonChangePlace.Click += new System.EventHandler(this.ChangePlace_Click);
            // 
            // listPlaces
            // 
            this.listPlaces.FormattingEnabled = true;
            this.listPlaces.ItemHeight = 16;
            this.listPlaces.Location = new System.Drawing.Point(22, 25);
            this.listPlaces.Name = "listPlaces";
            this.listPlaces.Size = new System.Drawing.Size(451, 420);
            this.listPlaces.TabIndex = 12;
            this.listPlaces.SelectedIndexChanged += new System.EventHandler(this.listPlaces_SelectedIndexChanged);
            // 
            // pictureWithoutCard
            // 
            this.pictureWithoutCard.Location = new System.Drawing.Point(495, 31);
            this.pictureWithoutCard.Name = "pictureWithoutCard";
            this.pictureWithoutCard.Size = new System.Drawing.Size(500, 413);
            this.pictureWithoutCard.TabIndex = 13;
            this.pictureWithoutCard.TabStop = false;
            // 
            // ChangePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1019, 473);
            this.Controls.Add(this.listPlaces);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelChangePlace);
            this.Controls.Add(this.buttonChangePlace);
            this.Controls.Add(this.pictureWithoutCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePlace";
            this.Text = "Изменить карточку места";
            ((System.ComponentModel.ISupportInitialize)(this.pictureWithoutCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelChangePlace;
        private System.Windows.Forms.Button buttonChangePlace;
        private System.Windows.Forms.ListBox listPlaces;
        private System.Windows.Forms.PictureBox pictureWithoutCard;
    }
}