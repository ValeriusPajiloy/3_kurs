namespace WinForms
{
    partial class WorkLoadForm
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
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.buttonSaveWorkload = new System.Windows.Forms.Button();
            this.textBoxGroupeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(12, 13);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(232, 21);
            this.comboBoxTeacher.TabIndex = 0;
            this.comboBoxTeacher.Enter += new System.EventHandler(this.comboBoxTeacher_Enter);
            this.comboBoxTeacher.Leave += new System.EventHandler(this.comboBoxTeacher_Leave);
            // 
            // comboBoxDiscipline
            // 
            this.comboBoxDiscipline.FormattingEnabled = true;
            this.comboBoxDiscipline.Location = new System.Drawing.Point(12, 40);
            this.comboBoxDiscipline.Name = "comboBoxDiscipline";
            this.comboBoxDiscipline.Size = new System.Drawing.Size(232, 21);
            this.comboBoxDiscipline.TabIndex = 1;
            this.comboBoxDiscipline.Enter += new System.EventHandler(this.comboBoxDiscipline_Enter);
            this.comboBoxDiscipline.Leave += new System.EventHandler(this.comboBoxDiscipline_Leave);
            // 
            // buttonSaveWorkload
            // 
            this.buttonSaveWorkload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveWorkload.Location = new System.Drawing.Point(169, 96);
            this.buttonSaveWorkload.Name = "buttonSaveWorkload";
            this.buttonSaveWorkload.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveWorkload.TabIndex = 2;
            this.buttonSaveWorkload.Text = "Сохранить";
            this.buttonSaveWorkload.UseVisualStyleBackColor = true;
            this.buttonSaveWorkload.Click += new System.EventHandler(this.buttonSaveWorkload_Click);
            // 
            // textBoxGroupeName
            // 
            this.textBoxGroupeName.Location = new System.Drawing.Point(12, 67);
            this.textBoxGroupeName.Name = "textBoxGroupeName";
            this.textBoxGroupeName.Size = new System.Drawing.Size(232, 20);
            this.textBoxGroupeName.TabIndex = 3;
            this.textBoxGroupeName.Enter += new System.EventHandler(this.textBoxGroupeName_Enter);
            this.textBoxGroupeName.Leave += new System.EventHandler(this.textBoxGroupeName_Leave);
            // 
            // WorkLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 125);
            this.Controls.Add(this.textBoxGroupeName);
            this.Controls.Add(this.buttonSaveWorkload);
            this.Controls.Add(this.comboBoxDiscipline);
            this.Controls.Add(this.comboBoxTeacher);
            this.Name = "WorkLoadForm";
            this.Text = "WorkLoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.Button buttonSaveWorkload;
        private System.Windows.Forms.TextBox textBoxGroupeName;
    }
}