
namespace HOLD_AND_WRITE
{
    partial class CreatePlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlace));
            this.buttonCreatePlace = new System.Windows.Forms.Button();
            this.buttonCancelCreatePlace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreatePlace
            // 
            this.buttonCreatePlace.Location = new System.Drawing.Point(392, 387);
            this.buttonCreatePlace.Name = "buttonCreatePlace";
            this.buttonCreatePlace.Size = new System.Drawing.Size(133, 46);
            this.buttonCreatePlace.TabIndex = 0;
            this.buttonCreatePlace.Text = "Сохранить";
            this.buttonCreatePlace.UseVisualStyleBackColor = true;
            this.buttonCreatePlace.Click += new System.EventHandler(this.CreatePlace_Click);
            // 
            // buttonCancelCreatePlace
            // 
            this.buttonCancelCreatePlace.Location = new System.Drawing.Point(25, 387);
            this.buttonCancelCreatePlace.Name = "buttonCancelCreatePlace";
            this.buttonCancelCreatePlace.Size = new System.Drawing.Size(133, 46);
            this.buttonCancelCreatePlace.TabIndex = 1;
            this.buttonCancelCreatePlace.Text = "Закрыть";
            this.buttonCancelCreatePlace.UseVisualStyleBackColor = true;
            this.buttonCancelCreatePlace.Click += new System.EventHandler(this.CancelCreatePlace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите описание места:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(25, 177);
            this.textBoxPlace.Multiline = true;
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(500, 190);
            this.textBoxPlace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите название места:";
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(27, 84);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(498, 22);
            this.textBoxPlaceName.TabIndex = 5;
            // 
            // CreatePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(555, 463);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelCreatePlace);
            this.Controls.Add(this.buttonCreatePlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreatePlace";
            this.Text = "Создать карточку места";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreatePlace;
        private System.Windows.Forms.Button buttonCancelCreatePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlaceName;
    }
}