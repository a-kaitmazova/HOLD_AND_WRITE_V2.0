
namespace HOLD_AND_WRITE
{
    partial class CreateFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFile));
            this.buttonCancelFIileCreate = new System.Windows.Forms.Button();
            this.buttonFileCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonCancelFIileCreate
            // 
            this.buttonCancelFIileCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelFIileCreate.Location = new System.Drawing.Point(29, 483);
            this.buttonCancelFIileCreate.Name = "buttonCancelFIileCreate";
            this.buttonCancelFIileCreate.Size = new System.Drawing.Size(124, 49);
            this.buttonCancelFIileCreate.TabIndex = 7;
            this.buttonCancelFIileCreate.Text = "Закрыть";
            this.buttonCancelFIileCreate.UseVisualStyleBackColor = true;
            this.buttonCancelFIileCreate.Click += new System.EventHandler(this.CancelFileCreate_Click);
            // 
            // buttonFileCreate
            // 
            this.buttonFileCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileCreate.Location = new System.Drawing.Point(378, 483);
            this.buttonFileCreate.Name = "buttonFileCreate";
            this.buttonFileCreate.Size = new System.Drawing.Size(124, 49);
            this.buttonFileCreate.TabIndex = 6;
            this.buttonFileCreate.Text = "Добавить";
            this.buttonFileCreate.UseVisualStyleBackColor = true;
            this.buttonFileCreate.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите название файла:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(29, 444);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(473, 22);
            this.textBoxFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите книгу (место создания файла):";
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(27, 73);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(475, 304);
            this.treeViewFiles.TabIndex = 9;
            // 
            // CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 565);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelFIileCreate);
            this.Controls.Add(this.buttonFileCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateFile";
            this.Text = "Создать файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelFIileCreate;
        private System.Windows.Forms.Button buttonFileCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewFiles;
    }
}