using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab05
{
    public partial class FormRoom : Form
    {
        public Room Room { get; }
        public FormRoom(Room room)
        {
            InitializeComponent();
            Room = room;
            comboBoxCategory.Items.Add(CategoryEnum.Econom);
            comboBoxCategory.Items.Add(CategoryEnum.Standart);
            comboBoxCategory.Items.Add(CategoryEnum.Comfort);
            comboBoxCategory.Items.Add(CategoryEnum.Luxe);
            comboBoxCategory.SelectedItem = Room.Category;
            numericUpDownNumber.Value = Room.Number;
            numericUpDownPayByDay.Value = Room.PayByDay;
            numericUpDownPlaceCount.Value = Room.PlaceCount;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Room.Category = (CategoryEnum)comboBoxCategory.SelectedItem;
            Room.Number = (int)numericUpDownNumber.Value;
            Room.PayByDay = numericUpDownPayByDay.Value;
            Room.PlaceCount = (int)numericUpDownPlaceCount.Value;
        }
    }
}
