using ClassLibraryStudy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class WorkLoadForm : Form
    {
        private Workload _workload;
        public Workload workload
        {
            get { return _workload; }
            set
            {
                _workload = value;
                comboBoxTeacher.SelectedItem = _workload.teacher;
                comboBoxDiscipline.SelectedItem = _workload.discipline;
                textBoxGroupeName.Text = _workload.groupName;
            }
        }
        private readonly Univer _univer = Univer.Instance;
        public WorkLoadForm()
        {
            InitializeComponent();

            textBoxGroupeName.Text = "Название группы";
            textBoxGroupeName.ForeColor = Color.Gray;

            comboBoxTeacher.Text = "Преподаватель";
            comboBoxTeacher.ForeColor = Color.Gray;

            comboBoxDiscipline.Text = "Предмет";
            comboBoxDiscipline.ForeColor = Color.Gray;
            _univer.DisciplineAdded += _univer_DisciplineAdded;
            _univer.DisciplineRemoved += _univer_DisciplineRemoved;
            _univer.TeacherAdded += _univer_TeacherAdded;
            _univer.TeacherRemoved += _univer_TeacherRemoved;

            foreach (var item in _univer.Teachers)
             {
                comboBoxTeacher.Items.Add(item);
             }

           foreach (var item in _univer.Disciplines)
             {
                comboBoxDiscipline.Items.Add(item);
             }
           
        }
        private void _univer_DisciplineAdded(object sender, EventArgs e)
        {
            comboBoxDiscipline.Items.Add(sender);
        }
        private void _univer_DisciplineRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxDiscipline.Items.Count; i++)
            {
                var discipline = comboBoxDiscipline.Items[i] as Discipline;
                if (discipline?.DisciplineId == key)
                {
                    comboBoxDiscipline.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void _univer_TeacherAdded(object sender, EventArgs e)
        {
            comboBoxTeacher.Items.Add(sender);
        }
        private void _univer_TeacherRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxTeacher.Items.Count; i++)
            {
                var teacher = comboBoxTeacher.Items[i] as Teacher;
                if (teacher?.TeacherId == key)
                {
                    comboBoxTeacher.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void comboBoxTeacher_Enter(object sender, EventArgs e)
        {
            comboBoxTeacher.ForeColor = Color.Black;
        }

        private void comboBoxTeacher_Leave(object sender, EventArgs e)
        {
            if (comboBoxTeacher.Text == "Преподаватель") comboBoxTeacher.ForeColor = Color.Gray;
        }

        private void comboBoxDiscipline_Enter(object sender, EventArgs e)
        {
            comboBoxDiscipline.ForeColor = Color.Black;
        }

        private void comboBoxDiscipline_Leave(object sender, EventArgs e)
        {
            if (comboBoxDiscipline.Text == "Предмет") comboBoxDiscipline.ForeColor = Color.Gray;

        }

        private void textBoxGroupeName_Enter(object sender, EventArgs e)
        {
            if (textBoxGroupeName.Text == "Название группы")
            {
                textBoxGroupeName.Clear();
                textBoxGroupeName.ForeColor = Color.Black;
            }
        }

        private void textBoxGroupeName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGroupeName.Text))
            {
                textBoxGroupeName.Text = "Название группы";
                textBoxGroupeName.ForeColor = Color.Gray;
            }
        }

        private void buttonSaveWorkload_Click(object sender, EventArgs e)
        {
            _workload.teacher = comboBoxTeacher.SelectedItem as Teacher;
            _workload.discipline = comboBoxDiscipline.SelectedItem as Discipline;
            _workload.groupName = textBoxGroupeName.Text;
        }
    }
}
