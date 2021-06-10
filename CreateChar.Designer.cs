
namespace HOLD_AND_WRITE
{
    partial class CreateChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.radioGenFem = new System.Windows.Forms.RadioButton();
            this.radioGenMale = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.radioMain = new System.Windows.Forms.RadioButton();
            this.radioCameo = new System.Windows.Forms.RadioButton();
            this.radioMent = new System.Windows.Forms.RadioButton();
            this.buttonCancelSaveChar = new System.Windows.Forms.Button();
            this.buttonSaveChar = new System.Windows.Forms.Button();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Роль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(40, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "О персонаже:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxAge.Location = new System.Drawing.Point(115, 142);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 27);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(43, 310);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(363, 173);
            this.textBoxAbout.TabIndex = 7;
            // 
            // radioGenFem
            // 
            this.radioGenFem.AutoSize = true;
            this.radioGenFem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioGenFem.Location = new System.Drawing.Point(115, 89);
            this.radioGenFem.Name = "radioGenFem";
            this.radioGenFem.Size = new System.Drawing.Size(90, 24);
            this.radioGenFem.TabIndex = 8;
            this.radioGenFem.TabStop = true;
            this.radioGenFem.Text = "женский";
            this.radioGenFem.UseVisualStyleBackColor = true;
            this.radioGenFem.CheckedChanged += new System.EventHandler(this.radioGenFem_CheckedChanged);
            // 
            // radioGenMale
            // 
            this.radioGenMale.AutoSize = true;
            this.radioGenMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioGenMale.Location = new System.Drawing.Point(221, 89);
            this.radioGenMale.Name = "radioGenMale";
            this.radioGenMale.Size = new System.Drawing.Size(91, 24);
            this.radioGenMale.TabIndex = 9;
            this.radioGenMale.TabStop = true;
            this.radioGenMale.Text = "мужской";
            this.radioGenMale.UseVisualStyleBackColor = true;
            this.radioGenMale.CheckedChanged += new System.EventHandler(this.radioGenMale_CheckedChanged);
            // 
            // radioSecond
            // 
            this.radioSecond.AutoSize = true;
            this.radioSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioSecond.Location = new System.Drawing.Point(111, 234);
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.Size = new System.Drawing.Size(148, 24);
            this.radioSecond.TabIndex = 10;
            this.radioSecond.TabStop = true;
            this.radioSecond.Text = "Второстепенный";
            this.radioSecond.UseVisualStyleBackColor = true;
            this.radioSecond.CheckedChanged += new System.EventHandler(this.radioSecond_CheckedChanged);
            // 
            // radioMain
            // 
            this.radioMain.AutoSize = true;
            this.radioMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioMain.Location = new System.Drawing.Point(111, 193);
            this.radioMain.Name = "radioMain";
            this.radioMain.Size = new System.Drawing.Size(90, 24);
            this.radioMain.TabIndex = 11;
            this.radioMain.TabStop = true;
            this.radioMain.Text = "Главный";
            this.radioMain.UseVisualStyleBackColor = true;
            this.radioMain.CheckedChanged += new System.EventHandler(this.radioMain_CheckedChanged);
            // 
            // radioCameo
            // 
            this.radioCameo.AutoSize = true;
            this.radioCameo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioCameo.Location = new System.Drawing.Point(268, 193);
            this.radioCameo.Name = "radioCameo";
            this.radioCameo.Size = new System.Drawing.Size(138, 24);
            this.radioCameo.TabIndex = 12;
            this.radioCameo.TabStop = true;
            this.radioCameo.Text = "Эпизодический";
            this.radioCameo.UseVisualStyleBackColor = true;
            this.radioCameo.CheckedChanged += new System.EventHandler(this.radioCameo_CheckedChanged);
            // 
            // radioMent
            // 
            this.radioMent.AutoSize = true;
            this.radioMent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioMent.Location = new System.Drawing.Point(268, 234);
            this.radioMent.Name = "radioMent";
            this.radioMent.Size = new System.Drawing.Size(123, 24);
            this.radioMent.TabIndex = 13;
            this.radioMent.TabStop = true;
            this.radioMent.Text = "Упоминается";
            this.radioMent.UseVisualStyleBackColor = true;
            this.radioMent.CheckedChanged += new System.EventHandler(this.radioMent_CheckedChanged);
            // 
            // buttonCancelSaveChar
            // 
            this.buttonCancelSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancelSaveChar.Location = new System.Drawing.Point(43, 502);
            this.buttonCancelSaveChar.Name = "buttonCancelSaveChar";
            this.buttonCancelSaveChar.Size = new System.Drawing.Size(117, 51);
            this.buttonCancelSaveChar.TabIndex = 14;
            this.buttonCancelSaveChar.Text = "Закрыть";
            this.buttonCancelSaveChar.UseVisualStyleBackColor = true;
            this.buttonCancelSaveChar.Click += new System.EventHandler(this.CancelSaveChar_Click);
            // 
            // buttonSaveChar
            // 
            this.buttonSaveChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSaveChar.Location = new System.Drawing.Point(276, 502);
            this.buttonSaveChar.Name = "buttonSaveChar";
            this.buttonSaveChar.Size = new System.Drawing.Size(130, 51);
            this.buttonSaveChar.TabIndex = 15;
            this.buttonSaveChar.Text = "Сохранить";
            this.buttonSaveChar.UseVisualStyleBackColor = true;
            this.buttonSaveChar.Click += new System.EventHandler(this.SaveChar_Click);
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioOther.Location = new System.Drawing.Point(318, 92);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(77, 24);
            this.radioOther.TabIndex = 16;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "другое";
            this.radioOther.UseVisualStyleBackColor = true;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radioOther_CheckedChanged);
            // 
            // CreateChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(449, 591);
            this.Controls.Add(this.radioOther);
            this.Controls.Add(this.buttonSaveChar);
            this.Controls.Add(this.buttonCancelSaveChar);
            this.Controls.Add(this.radioMent);
            this.Controls.Add(this.radioCameo);
            this.Controls.Add(this.radioMain);
            this.Controls.Add(this.radioSecond);
            this.Controls.Add(this.radioGenMale);
            this.Controls.Add(this.radioGenFem);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateChar";
            this.Text = "Создать карточку персонажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.RadioButton radioGenFem;
        private System.Windows.Forms.RadioButton radioGenMale;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.RadioButton radioMain;
        private System.Windows.Forms.RadioButton radioCameo;
        private System.Windows.Forms.RadioButton radioMent;
        private System.Windows.Forms.Button buttonCancelSaveChar;
        private System.Windows.Forms.Button buttonSaveChar;
        private System.Windows.Forms.RadioButton radioOther;
    }
}