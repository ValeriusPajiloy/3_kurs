using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab06
{
    public partial class FormSettlement : Form
    {
        private Settlement _settlement;
        public Settlement Settlement
        {
            get { return _settlement; }
            set
            {
                _settlement = value;
                comboBoxClient.SelectedItem = _settlement.Client;
                comboBoxRoom.SelectedItem = _settlement.Room;
                dateTimePickerStartDate.Value = _settlement.StartDate;
                dateTimePickerEndDate.Value = _settlement.EndDate;
            }
        }
        private readonly Hotel _hotel = Hotel.Instance;
        public FormSettlement()
        {
            InitializeComponent();
            _hotel.ClientAdded += _hotel_ClientAdded;
            _hotel.ClientRemoved += _hotel_ClientRemoved;
            _hotel.RoomAdded += _hotel_RoomAdded;
            _hotel.RoomRemoved += _hotel_RoomRemoved;
            foreach (var client in _hotel.Clients)
            {
                comboBoxClient.Items.Add(client);
            }
            foreach (var room in _hotel.Rooms)
            {
                comboBoxRoom.Items.Add(room);
            }
        }

        private void _hotel_RoomRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxRoom.Items.Count; i++)
            {
                var room = comboBoxRoom.Items[i] as Room;
                if (room?.Number == key)
                {
                    comboBoxRoom.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_RoomAdded(object sender, EventArgs e)
        {
            comboBoxRoom.Items.Add(sender);
        }

        private void _hotel_ClientRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxClient.Items.Count; i++)
            {
                var client = comboBoxClient.Items[i] as Client;
                if (client?.ClientId == key)
                {
                    comboBoxClient.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_ClientAdded(object sender, EventArgs e)
        {
            comboBoxClient.Items.Add(sender);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _settlement.Client = comboBoxClient.SelectedItem as Client;
            _settlement.Room = comboBoxRoom.SelectedItem as Room;
            _settlement.StartDate = dateTimePickerStartDate.Value;
            _settlement.EndDate = dateTimePickerEndDate.Value;
        }
    }
}
