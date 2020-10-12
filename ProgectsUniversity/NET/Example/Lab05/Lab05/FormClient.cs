using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab05
{
    public partial class FormClient : Form
    {
        public Client Client { get; }

        public FormClient(Client client)
        {
            InitializeComponent();
            Client = client;
            textBoxFirstName.Text = Client.FirstName;
            textBoxMiddleName.Text = Client.MiddleName;
            textBoxLastName.Text = Client.LastName;

            textBoxIssuer.Text = Client.Passport.Issuer;
            textBoxSeria.Text = Client.Passport.Seria;
            textBoxNumber.Text = Client.Passport.Number;
            dateTimePickerDate.Value = Client.Passport.Date;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client.FirstName = textBoxFirstName.Text;
            Client.MiddleName = textBoxMiddleName.Text;
            Client.LastName = textBoxLastName.Text;

            Client.Passport.Issuer = textBoxIssuer.Text;
            Client.Passport.Seria = textBoxSeria.Text;
            Client.Passport.Number = textBoxNumber.Text;
            Client.Passport.Date = dateTimePickerDate.Value;
        }
    }
}
