﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class TeacherForm : Form
    {
        private Teacher _teacher;
        public Teacher teacher 
        {
            get { return _teacher; }
            set
            {
                _teacher = value;
                textBoxSurname.Text = teacher.LastName;
                textBoxName.Text = teacher.FirstName;
                textBoxMiddleName.Text = teacher.MiddleName;
                comboBoxSubject.SelectedItem = teacher.Degree.subject;
                textBoxDegree.Text = teacher.Degree.degree;
                textBoxPosition.Text = teacher.position;
                numericExp.Value = teacher.exp;
            }
        }
        public TeacherForm()
        {
            InitializeComponent();
           
            teacher = new Teacher();

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

            comboBoxSubject.Text = "Предмет";
            comboBoxSubject.ForeColor = Color.Gray;
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
            _teacher.LastName = textBoxSurname.Text;
            _teacher.FirstName = textBoxName.Text;
            _teacher.MiddleName = textBoxMiddleName.Text;
            if (comboBoxSubject.SelectedValue != null) _teacher.Degree.subject = (Subject)comboBoxSubject.SelectedItem;
            _teacher.Degree.degree = textBoxDegree.Text;
            _teacher.position = textBoxPosition.Text;
            _teacher.exp = (int)numericExp.Value;
        }

        private void comboBoxSubject_DropDown(object sender, EventArgs e)
        {
            comboBoxSubject.ForeColor = Color.Black;
        }

        private void comboBoxSubject_Leave(object sender, EventArgs e)
        {
           if(comboBoxSubject.Text == "Предмет") comboBoxSubject.ForeColor = Color.Gray;
        }
    }
}
