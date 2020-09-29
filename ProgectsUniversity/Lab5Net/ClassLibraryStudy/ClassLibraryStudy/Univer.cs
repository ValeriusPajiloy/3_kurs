
using System.Collections.Generic;

namespace ClassLibraryStudy
{
    public class Univer
    {
        public static Dictionary<int, Teacher> Teachers { get; } = new Dictionary<int, Teacher>();

        public static Dictionary<int, Discipline> Disciplines { get; } = new Dictionary<int, Discipline>();

        public static List<Workload> Workloads { get; } = new List<Workload>();
    }
}
