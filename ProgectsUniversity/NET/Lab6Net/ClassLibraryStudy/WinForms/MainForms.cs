using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class MainForms : Form
    {
        private readonly Univer _univer = Univer.Instance;
        readonly DisciplineForm _disciplineForm = new DisciplineForm();
        readonly TeacherForm _teacherForm = new TeacherForm();
        readonly WorkLoadForm _workLoadForm = new WorkLoadForm();

        public MainForms()
        {
            InitializeComponent();
            _univer.TeacherAdded += _univer_TeacherAdded;
            _univer.DisciplineAdded += _univer_DisciplineAdded;
            _univer.WorkloadAdded += _univer_WorkloadAdded;
            _univer.TeacherRemoved += _univer_TeacherRemoved;
            _univer.DisciplineRemoved += _univer_DisciplineRemoved;
            _univer.WorkloadRemoved += _univer_WorkloadRemoved;
        }

        private void _univer_TeacherAdded(object sender, EventArgs e)
        {
            var teacher = sender as Teacher;
            if (teacher != null)
            {
                var listViewItem = new ListViewItem(teacher.ToString())
                {
                    Tag = teacher                   
                };
                listViewTeachers.Items.Add(listViewItem);
            }
        }
        private void _univer_DisciplineAdded(object sender, EventArgs e)
        {
            var discipline = sender as Discipline;
            if (discipline != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = discipline,
                    Text = discipline.ToString()
                };
                listViewSubject.Items.Add(listViewItem);
            }
        }
        private void _univer_WorkloadAdded(object sender, EventArgs e)
        {
            var workload = sender as Workload;
            if (workload != null)
            {
                var listViewItem = new ListViewItem(workload.ToString())
                {
                    Tag = workload,
                };
                listViewWorkload.Items.Add(listViewItem);
            }
        }

        private void _univer_TeacherRemoved(object sender, EventArgs e)
        {
            var key = (int)sender;
            for (int i = 0; i < listViewTeachers.Items.Count; i++)
            {
                if (((Teacher)listViewTeachers.Items[i].Tag).TeacherId == key)
                {
                    listViewTeachers.Items.RemoveAt(i);
                    break;
                }
            }

        }
        private void _univer_DisciplineRemoved(object sender, EventArgs e)
        {
            var key = (int)sender;
            for (int i = 0; i < listViewSubject.Items.Count; i++)
            {
                if (((Discipline)listViewSubject.Items[i].Tag).DisciplineId == key)
                {
                    listViewSubject.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _univer_WorkloadRemoved(object sender, EventArgs e)
        {
            var workload = sender as Workload;
            for (int i = 0; i < listViewWorkload.Items.Count; i++)
            {
                if ((Workload)listViewWorkload.Items[i].Tag == workload)
                {
                    listViewWorkload.Items.RemoveAt(i);
                    break;
                }
            }

        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            _teacherForm.teacher = teacher;
            if (_teacherForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _univer.AddTeacher(teacher);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = listViewTeachers.SelectedItems[0].Tag as Teacher;
                _teacherForm.teacher = teacher;
                if (_teacherForm.ShowDialog() == DialogResult.OK)
                {
                    listViewTeachers.SelectedItems[0].Text = _teacherForm.teacher.ToString()[0];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с преподавателем");
            }

        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var discipline = new Discipline();
            _disciplineForm.discipline = discipline;
            if (_disciplineForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _univer.AddDiscipline(discipline);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var discipline = listViewSubject.SelectedItems[0].Tag as Discipline;
                _disciplineForm.discipline = discipline;
                if (_disciplineForm.ShowDialog() == DialogResult.OK)
                {
                    listViewSubject.SelectedItems[0].Text = _disciplineForm.discipline.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с предметом");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var workload = new Workload();
            _workLoadForm.workload = workload;
            if (_workLoadForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _univer.AddWorkload(workload);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var workload = listViewWorkload.SelectedItems[0].Tag as Workload;
                _workLoadForm.workload = workload;
                if (_workLoadForm.ShowDialog() == DialogResult.OK)
                {
                    workload = _workLoadForm.workload;
                    var listViewItem = listViewWorkload.SelectedItems[0];
                    listViewItem.Text = workload.teacher.ToString()[0];
                    listViewItem.SubItems[1].Text = workload.discipline.ToString();
                    listViewItem.SubItems[2].Text = workload.groupName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с нагрузкой");
            }

        }
    }
}
