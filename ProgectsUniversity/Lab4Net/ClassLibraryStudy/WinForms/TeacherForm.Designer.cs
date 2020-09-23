namespace WinForms
{
    partial class TeacherForm
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericExp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.SaveTeacher = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericExp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 30);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(174, 20);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 82);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(174, 20);
            this.textBoxMiddleName.TabIndex = 3;
            this.textBoxMiddleName.Enter += new System.EventHandler(this.textBoxMiddleName_Enter);
            this.textBoxMiddleName.Leave += new System.EventHandler(this.textBoxMiddleName_Leave);
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(28, 14);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(34, 13);
            this.FIO.TabIndex = 4;
            this.FIO.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ученая степень";
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Location = new System.Drawing.Point(218, 56);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(174, 20);
            this.textBoxDegree.TabIndex = 6;
            this.textBoxDegree.Enter += new System.EventHandler(this.textBoxDegree_Enter);
            this.textBoxDegree.Leave += new System.EventHandler(this.textBoxDegree_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стаж";
            // 
            // numericExp
            // 
            this.numericExp.Location = new System.Drawing.Point(12, 139);
            this.numericExp.Name = "numericExp";
            this.numericExp.Size = new System.Drawing.Size(120, 20);
            this.numericExp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Должность";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(218, 139);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(174, 20);
            this.textBoxPosition.TabIndex = 11;
            this.textBoxPosition.Enter += new System.EventHandler(this.textBoxPosition_Enter);
            this.textBoxPosition.Leave += new System.EventHandler(this.textBoxPosition_Leave);
            // 
            // SaveTeacher
            // 
            this.SaveTeacher.Location = new System.Drawing.Point(267, 170);
            this.SaveTeacher.Name = "SaveTeacher";
            this.SaveTeacher.Size = new System.Drawing.Size(125, 25);
            this.SaveTeacher.TabIndex = 13;
            this.SaveTeacher.Text = "Сохранить";
            this.SaveTeacher.UseVisualStyleBackColor = true;
            this.SaveTeacher.Click += new System.EventHandler(this.SaveTeacher_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(218, 30);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(174, 21);
            this.comboBoxSubject.TabIndex = 14;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 207);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.SaveTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.numericExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDegree);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Button SaveTeacher;
        private System.Windows.Forms.ComboBox comboBoxSubject;
    }
}