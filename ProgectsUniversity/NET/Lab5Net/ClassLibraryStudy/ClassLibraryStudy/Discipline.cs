namespace ClassLibraryStudy
{
    public class Discipline : IValidatable
    {
        /// <summary>
        /// Уникальный идентификатор нового предметы (аналог автоинкремента)
        /// </summary>
        private static int _newDisciplineId;

        private static int NewDisciplineId
        {
            get
            {
                _newDisciplineId++;
                return _newDisciplineId;
            }
        }


        /// <summary>
        /// Уникальный идентификатор предмета
        /// </summary>
        public int DisciplineId { get; }
        /// <summary>
        /// Название
        /// </summary>
        public Subject Name { get; set; } = Subject.Math;
        
        /// <summary>
        /// Кол-во часов
        /// </summary>
        public int countHours { get; set; } = 0;
        
        public bool IsValid
        {
            get
            {
                if (countHours == 0) return false;
                return true;
            }
        }

        public Discipline()
        {
            DisciplineId = NewDisciplineId;
        }
        public Discipline(Subject Name, int countHours)
        {
            this.Name = Name;
            this.countHours = countHours;
            DisciplineId = NewDisciplineId;
        }

        public override string ToString()
        {
            return $"\tНазвание: {Name}\tКол-во часов: {countHours}";
        }

    }
}
