namespace ClassLibraryHotel
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client : IValidatable
    {
        /// <summary>
        /// Уникальный идентификатор нового клиента (аналог автоинкремента)
        /// </summary>
        private static int _newClientId;

        private static int NewClientId
        {
            get
            {
                _newClientId++;
                return _newClientId;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int ClientId { get; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";
        /// <summary>
        /// Паспортные данные
        /// </summary>
        public PassportInfo Passport { get; set; } = new PassportInfo();

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (Passport == null) return false;
                return true;
            }
        }

        public Client()
        {
            ClientId = NewClientId;
        }

        public Client(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            ClientId = NewClientId;
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\nПаспортные данные: {Passport}\r\n";
        }
    }
}
