namespace ClassLibraryStudy
{
    public class Teacher : IValidatable
    {
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
        /// Ученая степень
        /// </summary>
        public scienceDegree Degree { get; set; } = new scienceDegree();

        /// <summary>
        /// Стаж(лет)
        /// </summary>
        public int exp { get; set; } = 0;

        /// <summary>
        /// Должность
        /// </summary>
        public string position { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (string.IsNullOrWhiteSpace(position)) return false;
                if (exp < 0) return false;
                if (Degree == null) return false;
                return true;
            }
        }

        public Teacher()
        {

        }

        public Teacher(string FirstName, string MiddleName, string LastName, scienceDegree Degree, int exp, string position)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Degree = Degree;
            this.exp = exp;
            this.position = position;
        }
        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\nУченая степень:\r\n{Degree}\r\nСтаж: {exp}\r\nДолжность: {position}\r\n";
        }
    }
}
