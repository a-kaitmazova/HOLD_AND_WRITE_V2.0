
namespace HOLD_AND_WRITE
{
    partial class RenameFilecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameFilecs));
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.buttonCancelRenameFile = new System.Windows.Forms.Button();
            this.buttonRenameFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRenameFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(20, 65);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(496, 366);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectFile);
            // 
            // buttonCancelRenameFile
            // 
            this.buttonCancelRenameFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelRenameFile.Location = new System.Drawing.Point(22, 529);
            this.buttonCancelRenameFile.Name = "buttonCancelRenameFile";
            this.buttonCancelRenameFile.Size = new System.Drawing.Size(154, 49);
            this.buttonCancelRenameFile.TabIndex = 1;
            this.buttonCancelRenameFile.Text = "Закрыть";
            this.buttonCancelRenameFile.UseVisualStyleBackColor = true;
            this.buttonCancelRenameFile.Click += new System.EventHandler(this.CancelRenameFile_Click);
            // 
            // buttonRenameFile
            // 
            this.buttonRenameFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRenameFile.Location = new System.Drawing.Point(338, 529);
            this.buttonRenameFile.Name = "buttonRenameFile";
            this.buttonRenameFile.Size = new System.Drawing.Size(178, 49);
            this.buttonRenameFile.TabIndex = 2;
            this.buttonRenameFile.Text = "Переименовать";
            this.buttonRenameFile.UseVisualStyleBackColor = true;
            this.buttonRenameFile.Click += new System.EventHandler(this.RenameFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите файл:";
            // 
            // textBoxRenameFile
            // 
            this.textBoxRenameFile.Location = new System.Drawing.Point(20, 490);
            this.textBoxRenameFile.Name = "textBoxRenameFile";
            this.textBoxRenameFile.Size = new System.Drawing.Size(496, 22);
            this.textBoxRenameFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label2.Location = new System.Drawing.Point(17, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите новое имя файла:";
            // 
            // RenameFilecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRenameFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRenameFile);
            this.Controls.Add(this.buttonCancelRenameFile);
            this.Controls.Add(this.treeViewFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RenameFilecs";
            this.Text = "Переименовать файлы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.Button buttonCancelRenameFile;
        private System.Windows.Forms.Button buttonRenameFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRenameFile;
        private System.Windows.Forms.Label label2;
    }
}