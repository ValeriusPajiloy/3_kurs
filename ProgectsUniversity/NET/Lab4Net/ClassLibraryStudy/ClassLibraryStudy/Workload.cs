namespace ClassLibraryStudy
{
    public class Workload : IValidatable
    {
        /// <summary>
        /// Преподаватель
        /// </summary>
        public Teacher teacher { get; set; } = new Teacher();
        /// <summary>
        /// Предмет
        /// </summary>
        public Discipline discipline { get; set; } = new Discipline();
        /// <summary>
        /// Название Группы
        /// </summary>
        public string groupName { get; set; } = "";
        public bool IsValid
        {
            get
            {
                if (teacher == null) return false;
                if (discipline == null) return false;
                if (groupName == "") return false;
                return true;
            }
        }

        public Workload()
        {

        }

        public Workload(Teacher teacher, Discipline discipline)
        {
            this.teacher = teacher;
            this.discipline = discipline;
        }

    }
}
