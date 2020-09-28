namespace WinForms
{
    partial class DisciplineForm
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
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericCountHours = new System.Windows.Forms.NumericUpDown();
            this.SaveDiscipline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountHours)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(12, 25);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(172, 21);
            this.comboBoxSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во часов";
            // 
            // numericCountHours
            // 
            this.numericCountHours.Location = new System.Drawing.Point(12, 65);
            this.numericCountHours.Name = "numericCountHours";
            this.numericCountHours.Size = new System.Drawing.Size(172, 20);
            this.numericCountHours.TabIndex = 3;
            // 
            // SaveDiscipline
            // 
            this.SaveDiscipline.Location = new System.Drawing.Point(109, 91);
            this.SaveDiscipline.Name = "SaveDiscipline";
            this.SaveDiscipline.Size = new System.Drawing.Size(75, 23);
            this.SaveDiscipline.TabIndex = 4;
            this.SaveDiscipline.Text = "Сохранить";
            this.SaveDiscipline.UseVisualStyleBackColor = true;
            this.SaveDiscipline.Click += new System.EventHandler(this.SaveDiscipline_Click);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 122);
            this.Controls.Add(this.SaveDiscipline);
            this.Controls.Add(this.numericCountHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSubject);
            this.MinimumSize = new System.Drawing.Size(212, 139);
            this.Name = "DisciplineForm";
            this.Text = "Предмет";
            ((System.ComponentModel.ISupportInitialize)(this.numericCountHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericCountHours;
        private System.Windows.Forms.Button SaveDiscipline;
    }
}