using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab06
{
    public partial class FormMain : Form
    {
        private readonly Hotel _hotel = Hotel.Instance;
        readonly FormRoom _formRoom = new FormRoom();
        readonly FormClient _formClient = new FormClient();
        readonly FormSettlement _formSettlement = new FormSettlement();

        public FormMain()
        {
            InitializeComponent();
            _hotel.ClientAdded += _hotel_ClientAdded;
            _hotel.RoomAdded += _hotel_RoomAdded;
            _hotel.SettlementAdded += _hotel_SettlementAdded;
            _hotel.ClientRemoved += _hotel_ClientRemoved;
            _hotel.RoomRemoved += _hotel_RoomRemoved;
            _hotel.SettlementRemoved += _hotel_SettlementRemoved;
        }

        private void _hotel_SettlementRemoved(object sender, EventArgs e)
        {
            var settlement = sender as Settlement;
            for (int i = 0; i < listViewSettlement.Items.Count; i++)
            {
                if ((Settlement)listViewSettlement.Items[i].Tag == settlement)
                {
                    listViewSettlement.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_RoomRemoved(object sender, EventArgs e)
        {
            var roomNumber = (int)sender;
            for (int i = 0; i < listViewRooms.Items.Count; i++)
            {
                if (((Room)listViewRooms.Items[i].Tag).Number == roomNumber)
                {
                    listViewRooms.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_ClientRemoved(object sender, EventArgs e)
        {
            var clientId = (int)sender;
            for (int i = 0; i < listViewClients.Items.Count; i++)
            {
                if (((Client)listViewClients.Items[i].Tag).ClientId == clientId)
                {
                    listViewClients.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _hotel_SettlementAdded(object sender, EventArgs e)
        {
            var settlement = sender as Settlement;
            if (settlement != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = settlement,
                    Text = settlement.Client.ToString()
                };
                listViewItem.SubItems.Add(settlement.Room.ToString());
                listViewItem.SubItems.Add(settlement.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(settlement.EndDate.ToShortDateString());
                listViewSettlement.Items.Add(listViewItem);
            }
        }

        private void _hotel_RoomAdded(object sender, EventArgs e)
        {
            var room = sender as Room;
            if (room != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = room,
                    Text = room.ToString()
                };
                listViewRooms.Items.Add(listViewItem);
            }
        }

        private void _hotel_ClientAdded(object sender, EventArgs e)
        {
            var client = sender as Client;
            if (client != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.ToString()
                };
                listViewClients.Items.Add(listViewItem);
            }
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new Client();
            _formClient.Client = client;
            if (_formClient.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _hotel.AddClient(client);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var client = listViewClients.SelectedItems[0].Tag as Client;
                _formClient.Client = client;
                if (_formClient.ShowDialog() == DialogResult.OK)
                {
                    listViewClients.SelectedItems[0].Text = _formClient.Client.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с клиентом");
            }
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var room = new Room();
            _formRoom.Room = room;
            if (_formRoom.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _hotel.AddRoom(room);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var room = listViewRooms.SelectedItems[0].Tag as Room;
                _formRoom.Room = room;
                if (_formRoom.ShowDialog() == DialogResult.OK)
                {
                    listViewRooms.SelectedItems[0].Text = _formRoom.Room.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с номером");
            }
        }
        private void addSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settlement = new Settlement();
            _formSettlement.Settlement = settlement;
            if (_formSettlement.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _hotel.AddSettlement(settlement);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var settlement = listViewSettlement.SelectedItems[0].Tag as Settlement;
                _formSettlement.Settlement = settlement;
                if (_formSettlement.ShowDialog() == DialogResult.OK)
                {
                    settlement = _formSettlement.Settlement;
                    var listViewItem = listViewSettlement.SelectedItems[0];
                    listViewItem.Text = settlement.Client.ToString();
                    listViewItem.SubItems[1].Text = settlement.Room.ToString();
                    listViewItem.SubItems[2].Text = settlement.StartDate.ToShortDateString();
                    listViewItem.SubItems[3].Text = settlement.EndDate.ToShortDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с поселением");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewClients_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var client = listViewClients.SelectedItems[0].Tag as Client;
                    if (client != null)
                    {
                        _hotel.RemoveClient(client.ClientId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с клиентом");
                }
            }
        }

        private void listViewRooms_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var room = listViewRooms.SelectedItems[0].Tag as Room;
                    if (room != null)
                    {
                        _hotel.RemoveRoom(room.Number);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с номером");
                }
            }

        }

        private void listViewSettlement_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var settlement = listViewSettlement.SelectedItems[0].Tag as Settlement;
                    if (settlement != null)
                    {
                        _hotel.RemoveSettlement(settlement);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с поселением");
                }
            }
        }
    }
}
