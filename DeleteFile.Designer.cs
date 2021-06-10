
namespace HOLD_AND_WRITE
{
    partial class DeleteFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonCancelDeleteFile = new System.Windows.Forms.Button();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите файл:";
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFile.Location = new System.Drawing.Point(344, 465);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(178, 49);
            this.buttonDeleteFile.TabIndex = 8;
            this.buttonDeleteFile.Text = "Удалить";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // buttonCancelDeleteFile
            // 
            this.buttonCancelDeleteFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelDeleteFile.Location = new System.Drawing.Point(28, 465);
            this.buttonCancelDeleteFile.Name = "buttonCancelDeleteFile";
            this.buttonCancelDeleteFile.Size = new System.Drawing.Size(154, 49);
            this.buttonCancelDeleteFile.TabIndex = 7;
            this.buttonCancelDeleteFile.Text = "Закрыть";
            this.buttonCancelDeleteFile.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteFile.Click += new System.EventHandler(this.CancelDeleteFale_Click);
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(28, 73);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(496, 366);
            this.treeViewFiles.TabIndex = 6;
            // 
            // DeleteFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonCancelDeleteFile);
            this.Controls.Add(this.treeViewFiles);
            this.Name = "DeleteFile";
            this.Text = "DeleteFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Button buttonCancelDeleteFile;
        private System.Windows.Forms.TreeView treeViewFiles;
    }
}