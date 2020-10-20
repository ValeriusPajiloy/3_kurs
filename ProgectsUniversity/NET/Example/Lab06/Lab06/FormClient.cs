using System;
using System.Windows.Forms;
using ClassLibraryHotel;

namespace Lab06
{
    public partial class FormClient : Form
    {
        private Client _client;

        public Client Client
        {
            get { return _client; }
            set
            {
                _client = value;
                textBoxFirstName.Text = Client.FirstName;
                textBoxMiddleName.Text = Client.MiddleName;
                textBoxLastName.Text = Client.LastName;

                textBoxIssuer.Text = Client.Passport.Issuer;
                textBoxSeria.Text = Client.Passport.Seria;
                textBoxNumber.Text = Client.Passport.Number;
                dateTimePickerDate.Value = Client.Passport.Date;
            }
        }

        public FormClient()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _client.FirstName = textBoxFirstName.Text;
            _client.MiddleName = textBoxMiddleName.Text;
            _client.LastName = textBoxLastName.Text;

            _client.Passport.Issuer = textBoxIssuer.Text;
            _client.Passport.Seria = textBoxSeria.Text;
            _client.Passport.Number = textBoxNumber.Text;
            _client.Passport.Date = dateTimePickerDate.Value;
        }
    }
}
