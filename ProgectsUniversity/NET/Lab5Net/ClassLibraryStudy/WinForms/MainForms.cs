using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class MainForms : Form
    {

        private Teacher teacher;    
        private Discipline discipline;
        
        public MainForms()
        {
            InitializeComponent();
        }
        void updateListTeacher()
        {
            listViewTeachers.Items.Clear();
            foreach (KeyValuePair<int, Teacher> temp in Univer.Teachers)
            {
                Teacher tempTeacher = temp.Value;
                string FIO = tempTeacher.LastName + tempTeacher.FirstName + tempTeacher.MiddleName;
                ListViewItem tempItem = new ListViewItem(new string[] {FIO, tempTeacher.Degree.ToString(), tempTeacher.exp.ToString(), tempTeacher.position});
                listViewTeachers.Items.Add(tempItem);
            }
        }
        
        void updateListDiscipline()
        {
            listViewSubject.Items.Clear();
            foreach(KeyValuePair<int, Discipline> temp in Univer.Disciplines)
            {
                Discipline tempDiscipline = temp.Value;
                ListViewItem tempItem = new ListViewItem(new string[] { tempDiscipline.Name.ToString(), tempDiscipline.countHours.ToString() });
                listViewSubject.Items.Add(tempItem);
            }
        }

        void updateListWorkLoad()
        {
            listViewWorkload.Clear();
            foreach(Workload tempWorkload in Univer.Workloads)
            {
                string FIO = tempWorkload.teacher.LastName + tempWorkload.teacher.FirstName + tempWorkload.teacher.MiddleName;
                ListViewItem tempItem = new ListViewItem(new string[] { FIO, tempWorkload.discipline.ToString(), tempWorkload.groupName });
                listViewWorkload.Items.Add(tempItem);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm f2 = new TeacherForm();
            if(f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.teacher.IsValid)
                {
                    Teacher temp = f2.teacher;
                    Univer.Teachers.Add(temp.TeacherId, temp);
                    updateListTeacher();
                }
            }
            
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.teacher != null)
            {
                TeacherForm f2 = new TeacherForm(this.teacher);
                f2.Show();
                this.teacher = f2.teacher;
            }
            else
            {
                MessageBox.Show("Ошибка! Сначала добавьте преподователей", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisciplineForm f2 = new DisciplineForm();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.discipline.IsValid)
                {
                    Discipline temp = f2.discipline;
                    Univer.Disciplines.Add(temp.DisciplineId, temp);
                    updateListTeacher();
                }
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(this.discipline != null)
            {
                DisciplineForm f2 = new DisciplineForm(this.discipline);
                f2.Show();
                this.discipline = f2.discipline;
                
            }
            else
            {
                MessageBox.Show("Ошибка! Сначала добавьте предметы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
