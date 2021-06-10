
namespace HOLD_AND_WRITE
{
    partial class DeletePlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePlace));
            this.buttonDeletePlace = new System.Windows.Forms.Button();
            this.buttonCancelDeletePlace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listPlaces = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDeletePlace
            // 
            this.buttonDeletePlace.Location = new System.Drawing.Point(324, 447);
            this.buttonDeletePlace.Name = "buttonDeletePlace";
            this.buttonDeletePlace.Size = new System.Drawing.Size(141, 48);
            this.buttonDeletePlace.TabIndex = 7;
            this.buttonDeletePlace.Text = "Удалить";
            this.buttonDeletePlace.UseVisualStyleBackColor = true;
            this.buttonDeletePlace.Click += new System.EventHandler(this.buttonDeletePlace_Click);
            // 
            // buttonCancelDeletePlace
            // 
            this.buttonCancelDeletePlace.Location = new System.Drawing.Point(34, 447);
            this.buttonCancelDeletePlace.Name = "buttonCancelDeletePlace";
            this.buttonCancelDeletePlace.Size = new System.Drawing.Size(141, 48);
            this.buttonCancelDeletePlace.TabIndex = 6;
            this.buttonCancelDeletePlace.Text = "Закрыть";
            this.buttonCancelDeletePlace.UseVisualStyleBackColor = true;
            this.buttonCancelDeletePlace.Click += new System.EventHandler(this.buttonCancelDeletePlace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите место для удаления:";
            // 
            // listPlaces
            // 
            this.listPlaces.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listPlaces.FormattingEnabled = true;
            this.listPlaces.ItemHeight = 17;
            this.listPlaces.Location = new System.Drawing.Point(34, 76);
            this.listPlaces.Name = "listPlaces";
            this.listPlaces.Size = new System.Drawing.Size(431, 344);
            this.listPlaces.TabIndex = 4;
            // 
            // DeletePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 526);
            this.Controls.Add(this.buttonDeletePlace);
            this.Controls.Add(this.buttonCancelDeletePlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPlaces);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeletePlace";
            this.Text = "Удалить карточку места";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePlace;
        private System.Windows.Forms.Button buttonCancelDeletePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPlaces;
    }
}