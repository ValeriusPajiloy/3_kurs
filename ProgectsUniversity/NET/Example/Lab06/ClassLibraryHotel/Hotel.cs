using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryHotel.Exception;

namespace ClassLibraryHotel
{
    /// <summary>
    /// Отель
    /// </summary>
    public class Hotel
    {
        private static Hotel _instance;
        /// <summary>
        /// Единственный экземпляр класса Отель
        /// </summary>
        public static Hotel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hotel();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Hotel()
        {

        }
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        private Dictionary<int, Client> _clients = new Dictionary<int, Client>();
        /// <summary>
        /// Словарь номеров
        /// </summary>
        private Dictionary<int, Room> _rooms = new Dictionary<int, Room>();
        /// <summary>
        /// Спосок поселений
        /// </summary>
        private List<Settlement> _settlements = new List<Settlement>();

        /// <summary>
        /// Коллекция клиентов
        /// </summary>
        public IEnumerable<Client> Clients
        {
            get { return _clients.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция номеров
        /// </summary>
        public IEnumerable<Room> Rooms
        {
            get
            {
                return _rooms.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция поселений
        /// </summary>
        public IEnumerable<Settlement> Settlements
        {
            get
            {
                return _settlements;
            }
        }

        public event EventHandler ClientAdded;
        public event EventHandler RoomAdded;
        public event EventHandler SettlementAdded;
        public event EventHandler ClientRemoved;
        public event EventHandler RoomRemoved;
        public event EventHandler SettlementRemoved;
        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="client">Информация о клиенте</param>
        public void AddClient(Client client)
        {
            if (!client.IsValid)
            {
                throw new InvalidClientException("Информация о клиент заполнена некорректно");
            }
            try
            {
                _clients.Add(client.ClientId, client);
                //Герерируем событие о том, что клиент добавлен
                ClientAdded?.Invoke(client, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidClientException("При добавлении клиента произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление номера
        /// </summary>
        /// <param name="room">Информация о номере</param>
        public void AddRoom(Room room)
        {
            if (!room.IsValid)
            {
                throw new InvalidRoomException("Информация о номере заполнена некорректно");
            }
            try
            {
                _rooms.Add(room.Number, room);
                //Герерируем событие о том, что номер добавлен
                RoomAdded?.Invoke(room, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidRoomException("При добавлении номера произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о поселении
        /// </summary>
        /// <param name="settlement"></param>
        public void AddSettlement(Settlement settlement)
        {
            if (!settlement.IsValid)
            {
                throw new InvalidSettlementException("Информация о заселении заполнена некорректно"); 
            }
            try
            {
                _settlements.Add(settlement);
                //Герерируем событие о том, что информация о поселении добавлена
                SettlementAdded?.Invoke(settlement, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidSettlementException("При поселении произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить клиента по идентификатору
        /// </summary>
        /// <param name="clientKey">Идентификатор клиента</param>
        public void RemoveClient(int clientKey)
        {
            _clients.Remove(clientKey);
            //Генерируем событие о том, что клиент удалён
            ClientRemoved?.Invoke(clientKey, EventArgs.Empty);
            //Получаем список сведений о поселении клиента
            var settlementsForClient = Settlements.Where(s => s.Client.ClientId == clientKey).ToList();
            for (int i = 0; i < settlementsForClient.Count; i++)
            {
                //Удаляем сведения о поселении клиента
                RemoveSettlement(settlementsForClient[i]);
            }
        }

        /// <summary>
        /// Удалить номер по идентификатору
        /// </summary>
        /// <param name="roomKey"></param>
        public void RemoveRoom(int roomKey)
        {
            _rooms.Remove(roomKey);
            //Генерируем событие о том, что номер удалён
            RoomRemoved?.Invoke(roomKey, EventArgs.Empty);
            //Получаем список сведений о поселении в номер
            var settlementsForRoom = Settlements.Where(s => s.Room.Number == roomKey).ToList();
            for (int i = 0; i < settlementsForRoom.Count; i++)
            {
                //Удаляем сведения о поселении в номер
                RemoveSettlement(settlementsForRoom[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о поселении
        /// </summary>
        /// <param name="settlement">Информация о поселении</param>
        public void RemoveSettlement(Settlement settlement)
        {
            _settlements.Remove(settlement);
            //Генерируем событие о том, что информация о поселении удалена
            SettlementRemoved?.Invoke(settlement, EventArgs.Empty);
        }
    }
}
