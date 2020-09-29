namespace ClassLibraryStudy
{
    public class scienceDegree
    {
        public Subject subject { get; set; } = Subject.Math;
        public string degree { get; set; } = "";
        public override string ToString()
        {
            return $"\tПредмет: {subject} Степень: {degree}";
        }
    }
}
