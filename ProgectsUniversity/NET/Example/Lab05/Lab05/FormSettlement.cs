using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab05
{
    public partial class FormSettlement : Form
    {
        public Settlement Settlement { get; }
        public FormSettlement(Settlement settlement)
        {
            InitializeComponent();
            Settlement = settlement;
            foreach (var item in Hotel.Clients)
            {
                var client = item.Value;
                comboBoxClient.Items.Add(client);
            }
            foreach (var item in Hotel.Rooms)
            {
                var room = item.Value;
                comboBoxRoom.Items.Add(room);
            }
            comboBoxClient.SelectedItem = settlement.Client;
            comboBoxRoom.SelectedItem = settlement.Room;
            dateTimePickerStartDate.Value = settlement.StartDate;
            dateTimePickerEndDate.Value = settlement.EndDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settlement.Client = comboBoxClient.SelectedItem as Client;
            Settlement.Room = comboBoxRoom.SelectedItem as Room;
            Settlement.StartDate = dateTimePickerStartDate.Value;
            Settlement.EndDate = dateTimePickerEndDate.Value;
        }
    }
}
