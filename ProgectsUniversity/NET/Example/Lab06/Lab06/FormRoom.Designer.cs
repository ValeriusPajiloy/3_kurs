namespace Lab06
{
    partial class FormRoom
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.numericUpDownPayByDay = new System.Windows.Forms.NumericUpDown();
            this.labelPayByDay = new System.Windows.Forms.Label();
            this.numericUpDownPlaceCount = new System.Windows.Forms.NumericUpDown();
            this.labelPlaceCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(147, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 16);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Идентификатор: ";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(126, 14);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownNumber.TabIndex = 2;
            this.numericUpDownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownNumber.ThousandsSeparator = true;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 43);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 13);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категория:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(126, 40);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(106, 21);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // numericUpDownPayByDay
            // 
            this.numericUpDownPayByDay.DecimalPlaces = 2;
            this.numericUpDownPayByDay.Location = new System.Drawing.Point(126, 67);
            this.numericUpDownPayByDay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPayByDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPayByDay.Name = "numericUpDownPayByDay";
            this.numericUpDownPayByDay.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownPayByDay.TabIndex = 6;
            this.numericUpDownPayByDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPayByDay.ThousandsSeparator = true;
            this.numericUpDownPayByDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPayByDay
            // 
            this.labelPayByDay.AutoSize = true;
            this.labelPayByDay.Location = new System.Drawing.Point(12, 69);
            this.labelPayByDay.Name = "labelPayByDay";
            this.labelPayByDay.Size = new System.Drawing.Size(108, 13);
            this.labelPayByDay.TabIndex = 5;
            this.labelPayByDay.Text = "Стоимость в сутки: ";
            // 
            // numericUpDownPlaceCount
            // 
            this.numericUpDownPlaceCount.Location = new System.Drawing.Point(126, 93);
            this.numericUpDownPlaceCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPlaceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlaceCount.Name = "numericUpDownPlaceCount";
            this.numericUpDownPlaceCount.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownPlaceCount.TabIndex = 8;
            this.numericUpDownPlaceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPlaceCount.ThousandsSeparator = true;
            this.numericUpDownPlaceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPlaceCount
            // 
            this.labelPlaceCount.AutoSize = true;
            this.labelPlaceCount.Location = new System.Drawing.Point(12, 95);
            this.labelPlaceCount.Name = "labelPlaceCount";
            this.labelPlaceCount.Size = new System.Drawing.Size(97, 13);
            this.labelPlaceCount.TabIndex = 7;
            this.labelPlaceCount.Text = "Количество мест:";
            // 
            // FormRoom
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 177);
            this.Controls.Add(this.numericUpDownPlaceCount);
            this.Controls.Add(this.labelPlaceCount);
            this.Controls.Add(this.numericUpDownPayByDay);
            this.Controls.Add(this.labelPayByDay);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Номер";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayByDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownPayByDay;
        private System.Windows.Forms.Label labelPayByDay;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaceCount;
        private System.Windows.Forms.Label labelPlaceCount;
    }
}