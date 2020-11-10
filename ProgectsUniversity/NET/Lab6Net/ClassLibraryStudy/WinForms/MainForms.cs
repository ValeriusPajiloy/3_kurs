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
                var listViewItem = new ListViewItem
                {
                    Tag = teacher,
                    Text = teacher.ToString()
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
                listViewTeachers.Items.Add(listViewItem);
            }
        }
        private void _univer_WorkloadAdded(object sender, EventArgs e)
        {
            var workload = sender as Workload;
            if (workload != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = workload,
                    Text = workload.ToString()
                };
                listViewTeachers.Items.Add(listViewItem);
            }
        }

        private void
        void updateListTeacher()
        {
            listViewTeachers.Items.Clear();
            foreach (KeyValuePair<int, Teacher> temp in Univer.Teachers)
            {
                Teacher tempTeacher = temp.Value;
                string FIO = tempTeacher.LastName + " " + tempTeacher.FirstName + " " + tempTeacher.MiddleName;
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
            listViewWorkload.Items.Clear();
            foreach(Workload tempWorkload in Univer.Workloads)
            {
                string FIO = tempWorkload.teacher.LastName + " " + tempWorkload.teacher.FirstName + " " + tempWorkload.teacher.MiddleName;
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
            if (Univer.Teachers.Count != 0)
            {
                if (listViewTeachers.SelectedItems.Count == 1)
                {
                    Teacher tempTeacher = Univer.Teachers[listViewTeachers.SelectedIndices[0]+1];
                    TeacherForm f2 = new TeacherForm(tempTeacher);
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        if (f2.teacher.IsValid)
                        {
                            Teacher temp = f2.teacher;
                            Univer.Teachers.Remove(temp.TeacherId);
                            Univer.Teachers.Add(temp.TeacherId, temp);
                        }
                    }
                }
                updateListTeacher();
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
                    updateListDiscipline();
                }
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Univer.Disciplines.Count != 0)
            {
                if (listViewSubject.SelectedItems.Count == 1)
                {
                    Discipline tempDiscipline = Univer.Disciplines[listViewSubject.SelectedIndices[0]+1];
                    DisciplineForm f2 = new DisciplineForm(tempDiscipline);
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        if (f2.discipline.IsValid)
                        {
                            Discipline temp = f2.discipline;
                            Univer.Disciplines.Remove(temp.DisciplineId);
                            Univer.Disciplines.Add(temp.DisciplineId, temp);
                        }
                    }
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
            WorkLoadForm f2 = new WorkLoadForm();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.workload.IsValid)
                {
                    Workload temp = f2.workload;
                    Univer.Workloads.Add(temp);
                    updateListWorkLoad();
                }
            }
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Univer.Workloads.Count != 0)
            {
                if (listViewWorkload.SelectedItems.Count == 1)
                {
                    Workload tempWorkload = Univer.Workloads[listViewWorkload.SelectedIndices[0]];
                    WorkLoadForm f2 = new WorkLoadForm(tempWorkload);
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        if (f2.workload.IsValid)
                        {
                            Workload temp = f2.workload;
                            Univer.Workloads[listViewWorkload.SelectedIndices[0]] = temp;
                        }
                    }
                }
                updateListWorkLoad();
            }
            else
            {
                MessageBox.Show("Ошибка! Сначала добавьте нагрузку", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
