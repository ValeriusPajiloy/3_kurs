using System.Windows.Forms;
using ClassLibraryStudy;

namespace WinForms
{
    public partial class DisciplineForm : Form
    {
        private Discipline _discipline;
        public Discipline discipline
        {
            get { return _discipline; }
            set
            {
                _discipline = value;
                comboBoxSubject.SelectedItem = _discipline.Name;
                numericCountHours.Value = _discipline.countHours;
            }
        }

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

        private void SaveDiscipline_Click(object sender, System.EventArgs e)
        {
            _discipline.Name = (Subject)comboBoxSubject.SelectedItem;
            _discipline.countHours = (int)numericCountHours.Value;
            Close();
        }
    }
}
