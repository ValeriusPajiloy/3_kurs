using System;

namespace ClassLibraryHotel
{
    /// <summary>
    /// Поселение
    /// </summary>
    public class Settlement : IValidatable
    {
        /// <summary>
        /// Клиент
        /// </summary>
        public Client Client { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public Room Room { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;

        public bool IsValid
        {
            get
            {
                if (Client == null) return false;
                if (Room == null) return false;
                if (EndDate <= StartDate) return false;
                return true;
            }
        }

        public Settlement()
        {

        }

        public Settlement(Client client, Room room, DateTime startDate, DateTime endDate)
        {
            Client = client;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Клиент - {Client}\r\nНомер - {Room}\r\nПериод: {StartDate}-{EndDate}\r\n";
        }
    }
}
