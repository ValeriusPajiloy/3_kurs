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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm f2 = new TeacherForm();
            f2.Show();
            this.teacher = f2.teacher;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm f2 = new TeacherForm(this.teacher);
            f2.Show();
            this.teacher = f2.teacher;
        }
    }
}
