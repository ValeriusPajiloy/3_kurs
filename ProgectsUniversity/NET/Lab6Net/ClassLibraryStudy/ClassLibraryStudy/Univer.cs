using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryStudy.Exception;


namespace ClassLibraryStudy
{
    public class Univer
    {
        private static Univer _instance;
        /// <summary>
        /// Единственный экземпляр класса Универ
        /// </summary>
        public static Univer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Univer();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Univer()
        {

        }
        /// <summary>
        /// Словарь Преподавателей
        /// </summary>
        private Dictionary<int, Teacher> _teachers { get; } = new Dictionary<int, Teacher>();
        /// <summary>
        /// Словарь Предметов
        /// </summary>
        private Dictionary<int, Discipline> _disciplines { get; } = new Dictionary<int, Discipline>();
        /// <summary>
        /// Список Нагрузок
        /// </summary>
        private List<Workload> _workloads { get; } = new List<Workload>();
        /// <summary>
        /// Коллекция Преподавателей
        /// </summary>
        public IEnumerable<Teacher> Teachers
        {
            get
            {
                return _teachers.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция Предметов
        /// </summary>
        public IEnumerable<Discipline> Disciplines
        {
            get
            {
                return _disciplines.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция Назрузок
        /// </summary>
        public IEnumerable<Workload> Workloads
        {
            get
            {
                return _workloads;
            }
        }

        public event EventHandler TeacherAdded;
        public event EventHandler DisciplineAdded;
        public event EventHandler WorkloadAdded;
        public event EventHandler TeacherRemoved;
        public event EventHandler DisciplineRemoved;
        public event EventHandler WorkloadRemoved;

        /// <summary>
        /// Добавление преподавателя
        /// </summary>
        /// <param name="teacher">Информация о преподавателе</param>
        public void AddTeacher(Teacher teacher)
        {
            if (!teacher.IsValid)
            {
                throw new InvalidTeacherException("Информация о преподавателе заполнена некорректно");
            }
            try
            {
                _teachers.Add(teacher.TeacherId, teacher);
                TeacherAdded?.Invoke(teacher, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidTeacherException("При добавлении преподавателя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление предмета
        /// </summary>
        /// <param name="discipline">Информация о преподавателе</param>
        public void AddDiscipline(Discipline discipline)
        {
            if (!discipline.IsValid)
            {
                throw new InvalidDisciplineException("Информация о предмете заполнена некорректно");
            }
            try
            {
                _disciplines.Add(discipline.DisciplineId, discipline);
                DisciplineAdded?.Invoke(discipline, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDisciplineException("При добавлении предмета произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о нагрузке
        /// </summary>
        /// <param name="workload"></param>
        public void AddWorkload(Workload workload)
        {
            if (!workload.IsValid)
            {
                throw new InvalidWorkloadException("Информация о нагрузке заполнена некорректно");
            }
            try
            {
                _workloads.Add(workload);
                WorkloadAdded?.Invoke(workload, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidWorkloadException("При добавлениии нагрузки произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить предмет по идентификатору
        /// </summary>
        /// <param name="disciplineKey">Идентификатор предмета</param>
        public void RemoveDiscipline(int disciplineKey)
        {
            _disciplines.Remove(disciplineKey);
            DisciplineRemoved?.Invoke(disciplineKey, EventArgs.Empty);
            var workloadForDiscipline = Workloads.Where(s => s.discipline.DisciplineId == disciplineKey).ToList();
            for (int i = 0; i < workloadForDiscipline.Count; i++)
            {
                RemoveWorkload(workloadForDiscipline[i]);
            }
        }
        /// <summary>
        /// Удалить преподавателя по идентификатору
        /// </summary>
        /// <param name="teacherKey">Идентификатор преподавателя</param>
        public void RemoveRoom(int teacherKey)
        {
            _teachers.Remove(teacherKey);
            TeacherRemoved?.Invoke(teacherKey, EventArgs.Empty);
            var workloadForTeacher = Workloads.Where(s => s.teacher.TeacherId == teacherKey).ToList();
            for (int i = 0; i < workloadForTeacher.Count; i++)
            {
                RemoveWorkload(workloadForTeacher[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о нагрузке
        /// </summary>
        /// <param name="workload">Информация о нагрузке</param>
        public void RemoveWorkload(Workload workload)
        {
            _workloads.Remove(workload);
            WorkloadRemoved?.Invoke(workload, EventArgs.Empty);
        }
    }
}
