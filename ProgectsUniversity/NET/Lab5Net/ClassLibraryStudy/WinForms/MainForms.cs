using System;
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
            foreach (var item in Univer.Teachers)
            {
                var teacher = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = teacher,
                    Text = teacher.ToString()
                };
                listViewTeachers.Items.Add(listViewItem);
            }
        }
        
        void updateListDiscipline()
        {
            listViewSubject.Items.Clear();

        }

        void updateListWorkLoad()
        {
            listViewWorkload.Items.Clear();

        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm f2 = new TeacherForm();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                this.teacher = f2.teacher;
                if (this.teacher.IsValid)
                {
                    Univer.Teachers.Add(this.teacher.TeacherId, this.teacher);
                }
                updateListTeacher();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.teacher != null)
            {
                TeacherForm f2 = new TeacherForm(this.teacher);
                
                if(f2.ShowDialog() == DialogResult.OK)
                {
                    this.teacher = f2.teacher;
                    if (this.teacher.IsValid)
                    {
                        Univer.Teachers.Remove(this.teacher.TeacherId);
                        Univer.Teachers.Add(this.teacher.TeacherId, this.teacher);
                    }
                    updateListTeacher();
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Сначала добавьте преподователей", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisciplineForm f2 = new DisciplineForm();
            f2.Show();
            this.discipline = f2.discipline;
            if (this.discipline.IsValid)
            {
                Univer.Disciplines.Add(this.discipline.DisciplineId, this.discipline);
            }
            updateListDiscipline();
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(this.discipline != null)
            {
                DisciplineForm f2 = new DisciplineForm(this.discipline);
                f2.Show();
                this.discipline = f2.discipline;
                if (this.discipline.IsValid)
                {
                    Univer.Disciplines.Remove(this.discipline.DisciplineId);
                    Univer.Disciplines.Add(this.discipline.DisciplineId, this.discipline);
                }
                updateListDiscipline();
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

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
