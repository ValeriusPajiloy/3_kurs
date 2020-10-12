namespace ClassLibraryHotel
{
    /// <summary>
    /// Номер
    /// </summary>
    public class Room : IValidatable
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Number { get; set; } = 1;

        /// <summary>
        /// Категория
        /// </summary>
        public CategoryEnum Category { get; set; } = CategoryEnum.Econom;

        /// <summary>
        /// Стоимость в сутки
        /// </summary>
        public decimal PayByDay { get; set; } = 100;

        /// <summary>
        /// Количество мест
        /// </summary>
        public int PlaceCount { get; set; } = 2;

        public bool IsValid
        {
            get
            {
                if (Number < 1) return false;
                if (PayByDay <= 0) return false;
                if (PlaceCount < 1) return false;
                return true;
            }
        }

        public Room()
        {

        }

        public Room(int number, CategoryEnum category, decimal payByDay, int placeCount)
        {
            Number = number;
            Category = category;
            PayByDay = payByDay;
            PlaceCount = placeCount;
        }

        public override string ToString()
        {
            return
                $"Идентификатор: {Number}\r\nКатегория: {Category}\r\nСтоимость в сутки:{PayByDay}\r\nКоличество мест:{PlaceCount}\r\n";
        }
    }
}
