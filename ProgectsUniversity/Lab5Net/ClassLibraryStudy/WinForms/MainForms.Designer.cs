namespace WinForms
{
    partial class MainForms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Degree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.tabPageWorkLoad = new System.Windows.Forms.TabPage();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.нагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listViewSubject = new System.Windows.Forms.ListView();
            this.SubjectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountHoursColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.tabPageDisciplines.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Controls.Add(this.tabPageWorkLoad);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(607, 352);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.listViewTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(599, 326);
            this.tabPageTeachers.TabIndex = 0;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FIO,
            this.Degree,
            this.Exp,
            this.Position});
            this.listViewTeachers.FullRowSelect = true;
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(3, 3);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(596, 320);
            this.listViewTeachers.TabIndex = 0;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО преподавателя";
            this.FIO.Width = 203;
            // 
            // Degree
            // 
            this.Degree.Text = "Научная степень";
            this.Degree.Width = 213;
            // 
            // Exp
            // 
            this.Exp.Text = "Опыт";
            this.Exp.Width = 50;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 126;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.listViewSubject);
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(599, 321);
            this.tabPageDisciplines.TabIndex = 1;
            this.tabPageDisciplines.Text = "Предметы";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkLoad
            // 
            this.tabPageWorkLoad.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkLoad.Name = "tabPageWorkLoad";
            this.tabPageWorkLoad.Size = new System.Drawing.Size(599, 321);
            this.tabPageWorkLoad.TabIndex = 2;
            this.tabPageWorkLoad.Text = "Нагрузка";
            this.tabPageWorkLoad.UseVisualStyleBackColor = true;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.преподавательToolStripMenuItem.Text = "Преподаватель";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1});
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.предметToolStripMenuItem.Text = "Предмет";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // нагрузкаToolStripMenuItem
            // 
            this.нагрузкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2});
            this.нагрузкаToolStripMenuItem.Name = "нагрузкаToolStripMenuItem";
            this.нагрузкаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.нагрузкаToolStripMenuItem.Text = "Нагрузка";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.преподавательToolStripMenuItem,
            this.предметToolStripMenuItem,
            this.нагрузкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listViewSubject
            // 
            this.listViewSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectColumn,
            this.CountHoursColumn});
            this.listViewSubject.FullRowSelect = true;
            this.listViewSubject.GridLines = true;
            this.listViewSubject.HideSelection = false;
            this.listViewSubject.Location = new System.Drawing.Point(3, 3);
            this.listViewSubject.Name = "listViewSubject";
            this.listViewSubject.Size = new System.Drawing.Size(594, 315);
            this.listViewSubject.TabIndex = 1;
            this.listViewSubject.UseCompatibleStateImageBehavior = false;
            this.listViewSubject.View = System.Windows.Forms.View.Details;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.Text = "Предмет";
            this.SubjectColumn.Width = 509;
            // 
            // CountHoursColumn
            // 
            this.CountHoursColumn.Text = "Кол-во часов";
            this.CountHoursColumn.Width = 79;
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 376);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForms";
            this.Text = "Распределение учебной нагрузки";
            this.tabControl.ResumeLayout(false);
            this.tabPageTeachers.ResumeLayout(false);
            this.tabPageDisciplines.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem нагрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.TabPage tabPageWorkLoad;
        private System.Windows.Forms.ColumnHeader Degree;
        private System.Windows.Forms.ColumnHeader Exp;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ListView listViewSubject;
        private System.Windows.Forms.ColumnHeader SubjectColumn;
        private System.Windows.Forms.ColumnHeader CountHoursColumn;
    }
}

