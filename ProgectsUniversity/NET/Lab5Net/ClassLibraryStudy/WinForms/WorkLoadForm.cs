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
        public Workload workload;
        public WorkLoadForm()
        {
            InitializeComponent();
            workload = new Workload();

            textBoxGroupeName.Text = "Название группы";
            textBoxGroupeName.ForeColor = Color.Gray;

            comboBoxTeacher.Text = "Преподаватель";
            comboBoxTeacher.ForeColor = Color.Gray;

            comboBoxDiscipline.Text = "Предмет";
            comboBoxDiscipline.ForeColor = Color.Gray;

           foreach (var item in Univer.Teachers)
             {
                string FIO = item.Value.LastName + " " + item.Value.FirstName[0] + ". " + item.Value.MiddleName[0] + ".";
                comboBoxTeacher.Items.Add(FIO);
             }

           foreach (var item in Univer.Disciplines)
             {
                comboBoxDiscipline.Items.Add(item.Value.Name);
             }
           
        }
        public WorkLoadForm(Workload _workload)
        {
            this.workload = _workload;


            foreach (var item in Univer.Teachers)
            {
                string fio = item.Value.LastName + " " + item.Value.FirstName[0] + ". " + item.Value.MiddleName[0] + ".";
                comboBoxTeacher.Items.Add(fio);
            }

            foreach (var item in Univer.Disciplines)
            {
                comboBoxDiscipline.Items.Add(item.Value.Name);
            }

            string FIO = workload.teacher.LastName + " " + workload.teacher.FirstName[0] + ". " + workload.teacher.MiddleName[0] + ".";
            comboBoxTeacher.SelectedItem = FIO;

            comboBoxDiscipline.SelectedItem = workload.discipline.Name;
            
            textBoxGroupeName.Text = workload.groupName;

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
            workload.teacher = Univer.Teachers[comboBoxTeacher.SelectedIndex + 1];
            workload.discipline = Univer.Disciplines[comboBoxDiscipline.SelectedIndex + 1];
            workload.groupName = textBoxGroupeName.Text;
        }
    }
}
