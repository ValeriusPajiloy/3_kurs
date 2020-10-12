using System.Collections.Generic;

namespace ClassLibraryHotel
{
    /// <summary>
    /// Отель
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        public static Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        public static Dictionary<int, Room> Rooms { get; } = new Dictionary<int, Room>();
        /// <summary>
        /// Спосок поселений
        /// </summary>
        public static List<Settlement> Settlements { get; } = new List<Settlement>();
    }
}
