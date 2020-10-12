using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab05
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new Client();
            FormClient formClient = new FormClient(client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Hotel.Clients.Add(client.ClientId, client);
                UpdateClientsList();
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = listViewClients.SelectedItems[0].Tag as Client;
            FormClient formClient = new FormClient(client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsList();
            }
        }

        private void UpdateClientsList()
        {
            listViewClients.Items.Clear();
            foreach (var item in Hotel.Clients)
            {
                var client = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.ToString()
                };
                listViewClients.Items.Add(listViewItem);
            }
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var room = new Room();
            FormRoom formRoom = new FormRoom(room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                Hotel.Rooms.Add(room.Number, room);
                UpdateRoomsList();
            }
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var room = listViewRooms.SelectedItems[0].Tag as Room;
            FormRoom formRoom = new FormRoom(room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                UpdateRoomsList();
            }
        }

        private void UpdateRoomsList()
        {
            listViewRooms.Items.Clear();
            foreach (var item in Hotel.Rooms)
            {
                var room = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = room,
                    Text = room.ToString()
                };
                listViewRooms.Items.Add(listViewItem);
            }
        }

        private void addSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settlement = new Settlement();
            FormSettlement formSettlement = new FormSettlement(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                Hotel.Settlements.Add(settlement);
                UpdateSettlementList();
            }
        }

        private void editSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settlement = listViewSettlement.SelectedItems[0].Tag as Settlement;
            FormSettlement formSettlement = new FormSettlement(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateSettlementList();
            }
        }

        private void UpdateSettlementList()
        {
            listViewSettlement.Items.Clear();
            foreach (var settlement in Hotel.Settlements)
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

    }
}
