using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class DisciplineForm : Form
    {
        public Discipline discipline;
        public DisciplineForm()
        {
            InitializeComponent();
            comboBoxSubject.Items.Add(Subject.Lenguages);
            comboBoxSubject.Items.Add(Subject.Math);
            comboBoxSubject.Items.Add(Subject.OOP);
            comboBoxSubject.Items.Add(Subject.Programming);
            comboBoxSubject.Items.Add(Subject.Web);
            discipline = new Discipline();
        }
        public DisciplineForm(Discipline _discipline)
        {
            InitializeComponent();
            comboBoxSubject.Items.Add(Subject.Lenguages);
            comboBoxSubject.Items.Add(Subject.Math);
            comboBoxSubject.Items.Add(Subject.OOP);
            comboBoxSubject.Items.Add(Subject.Programming);
            comboBoxSubject.Items.Add(Subject.Web);
            discipline = new Discipline(_discipline);

            if (_discipline.IsValid)
            {
                comboBoxSubject.SelectedItem = _discipline.Name;
                numericCountHours.Value = _discipline.countHours;
            }
        }

        private void SaveDiscipline_Click(object sender, System.EventArgs e)
        {
            discipline.Name = (Subject)comboBoxSubject.SelectedItem;
            discipline.countHours = (int)numericCountHours.Value;
            Close();
        }
    }
}
