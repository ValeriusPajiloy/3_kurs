using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class TeacherForm : Form
    {
        public Teacher teacher = new Teacher();
        public TeacherForm()
        {
            InitializeComponent();
           
            comboBoxSubject.Items.Add(Subject.Lenguages);
            comboBoxSubject.Items.Add(Subject.Math);
            comboBoxSubject.Items.Add(Subject.OOP);
            comboBoxSubject.Items.Add(Subject.Programming);
            comboBoxSubject.Items.Add(Subject.Web);

            textBoxSurname.Text = "Фамилия";
            textBoxSurname.ForeColor = Color.Gray;

            textBoxName.Text = "Имя";
            textBoxName.ForeColor = Color.Gray;

            textBoxMiddleName.Text = "Отчество";
            textBoxMiddleName.ForeColor = Color.Gray;

            textBoxDegree.Text = "Степень";
            textBoxDegree.ForeColor = Color.Gray;

            textBoxPosition.Text = "Должность";
            textBoxPosition.ForeColor = Color.Gray;
        }
        public TeacherForm(Teacher _teacher)
        {
            InitializeComponent();

            if(_teacher.IsValid)
            {
                textBoxSurname.Text = _teacher.LastName;
                textBoxName.Text = _teacher.FirstName;
                textBoxMiddleName.Text = _teacher.MiddleName;
                comboBoxSubject.Items.Add(Subject.Lenguages);
                comboBoxSubject.Items.Add(Subject.Math);
                comboBoxSubject.Items.Add(Subject.OOP);
                comboBoxSubject.Items.Add(Subject.Programming);
                comboBoxSubject.Items.Add(Subject.Web);
                comboBoxSubject.SelectedItem = _teacher.Degree.subject;
                textBoxDegree.Text = _teacher.Degree.degree;
                textBoxPosition.Text = _teacher.position;
                numericExp.Value = _teacher.exp;
            }
            else
            {
                textBoxSurname.Text = "Фамилия";
                textBoxSurname.ForeColor = Color.Gray;

                textBoxName.Text = "Имя";
                textBoxName.ForeColor = Color.Gray;

                textBoxMiddleName.Text = "Отчество";
                textBoxMiddleName.ForeColor = Color.Gray;

                textBoxDegree.Text = "Степень";
                textBoxDegree.ForeColor = Color.Gray;

                textBoxPosition.Text = "Должность";
                textBoxPosition.ForeColor = Color.Gray;
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Фамилия")
            {
                textBoxSurname.Clear();
                textBoxSurname.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Имя")
            {
                textBoxName.Clear();
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxMiddleName_Enter(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == "Отчество")
            {
                textBoxMiddleName.Clear();
                textBoxMiddleName.ForeColor = Color.Black;
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                textBoxSurname.Text = "Фамилия";
                textBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxMiddleName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMiddleName.Text))
            {
                textBoxMiddleName.Text = "Отчество";
                textBoxMiddleName.ForeColor = Color.Gray;
            }
        }


        private void textBoxDegree_Enter(object sender, EventArgs e)
        {
            if (textBoxDegree.Text == "Степень")
            {
                textBoxDegree.Clear();
                textBoxDegree.ForeColor = Color.Black;
            }
        }

        private void textBoxDegree_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDegree.Text))
            {
                textBoxDegree.Text = "Степень";
                textBoxDegree.ForeColor = Color.Gray;
            }
        }

        private void textBoxPosition_Enter(object sender, EventArgs e)
        {
            if (textBoxPosition.Text == "Должность")
            {
                textBoxPosition.Clear();
                textBoxPosition.ForeColor = Color.Black;
            }
        }

        private void textBoxPosition_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                textBoxPosition.Text = "Должность";
                textBoxPosition.ForeColor = Color.Gray;
            }
        }

        private void SaveTeacher_Click(object sender, EventArgs e)
        {
            teacher.LastName = textBoxSurname.Text;
            teacher.FirstName = textBoxName.Text;
            teacher.MiddleName = textBoxMiddleName.Text;
            if (comboBoxSubject.SelectedValue != null) teacher.Degree.subject = (Subject)comboBoxSubject.SelectedItem;
            teacher.Degree.degree = textBoxDegree.Text;
            teacher.position = textBoxPosition.Text;
            teacher.exp = (int)numericExp.Value;
        }

    }
}
