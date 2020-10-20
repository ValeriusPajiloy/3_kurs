using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab06
{
    public partial class FormRoom : Form
    {
        private Room _room;
        public Room Room
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
                comboBoxCategory.SelectedItem = _room.Category;
                numericUpDownNumber.Value = _room.Number;
                numericUpDownPayByDay.Value = _room.PayByDay;
                numericUpDownPlaceCount.Value = _room.PlaceCount;
            }
        }

        public FormRoom()
        {
            InitializeComponent();
            comboBoxCategory.Items.Add(CategoryEnum.Econom);
            comboBoxCategory.Items.Add(CategoryEnum.Standart);
            comboBoxCategory.Items.Add(CategoryEnum.Comfort);
            comboBoxCategory.Items.Add(CategoryEnum.Luxe);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _room.Category = (CategoryEnum)comboBoxCategory.SelectedItem;
            _room.Number = (int)numericUpDownNumber.Value;
            _room.PayByDay = numericUpDownPayByDay.Value;
            _room.PlaceCount = (int)numericUpDownPlaceCount.Value;
        }
    }
}
