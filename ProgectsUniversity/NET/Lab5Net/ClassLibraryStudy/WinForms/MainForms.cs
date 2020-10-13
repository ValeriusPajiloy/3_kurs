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

        }
        
        void updateListDiscipline()
        {

        }

        void updateListWorkLoad()
        {

        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm f2 = new TeacherForm();
            f2.Show();
            this.teacher = f2.teacher;
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
            f2.Show();
            this.discipline = f2.discipline;
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
