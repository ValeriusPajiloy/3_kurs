use Exams
--1. Вывести все предметы, по которым не сдаются экзамены
select
Discipline.nameDiscipline as 'Name'
--Exam.disciplineID
from Discipline
left join Exam on (Discipline.ID = Exam.disciplineID)
where Exam.disciplineID is NULL

--2. Список всех учебных заведений, учащиеся которых набрали менее 50(<3) баллов хотя бы по одному предмету.
select distinct
EduEstablishment.nameEstablishment as 'Name'
from EduEstablishment
join Student on (EduEstablishment.ID = Student.EduEstablishmentID)
join Exam on (Student.ID = Exam.StudentID and Exam.mark<3)

--3. Телефоны директоров, ученики из учебных заведений которых по всем предметам набрали меньше 60(<4) баллов.
with Student_CTE as(
select distinct
Student.ID, FIO, courseNumber, EduEstablishmentID
from Student
join Exam on (Student.ID = Exam.StudentID and mark>3)
)

select distinct 
	(
		select
			(select Teacher.phoneNumber from Teacher where Teacher.ID = EduEstablishment.directorID)
		from EduEstablishment
		where EduEstablishment.ID = Student.EduEstablishmentID
	)as 'Phone Number' 
from Student
join Exam on (Student.ID = Exam.StudentID)
left join Student_CTE on (Student.ID = Student_CTE.ID)
where Student_CTE.ID is null


--4. Директоров техникумов, учащиеся которых сдавали информатику.
with Student_CTE as(
select distinct
Student.ID, FIO, courseNumber, EduEstablishmentID
from Student
join Exam on (Student.ID = Exam.StudentID and Exam.disciplineID = 2)
)

select distinct 
	(select Teacher.FIO from Teacher where Teacher.ID = EduEstablishment.directorID) as 'Name'
from Student_CTE
join EduEstablishment on (Student_CTE.EduEstablishmentID = EduEstablishment.ID)
join Exam on (Student_CTE.ID = Exam.StudentID)
where EduEstablishment.typeEstablishmentID = 2

--5. Учащихся, набравших больше 60(>3) баллов по всем экзаменам из учебных заведений, в которых меньше 20 учеников.
;with 
	EduEducutation_CTE as(
		select distinct
		EduEstablishmentID, 
		COUNT(*) as 'count'
		from Student
		group by Student.EduEstablishmentID
	),
	Student_CTE as(
		select distinct
		Student.ID, FIO, courseNumber, EduEstablishmentID
		from Student
		join Exam on (Student.ID = Exam.StudentID and Exam.mark>3)
	)

select 
	Student_CTE.FIO as 'Student'
from Student_CTE
join EduEducutation_CTE on (EduEducutation_CTE.EduEstablishmentID = Student_CTE.EduEstablishmentID and EduEducutation_CTE.count<20)

--6. Список учебных заведений, их директоров и количество учеников для каждого.
select distinct
	(select EduEstablishment.nameEstablishment from EduEstablishment where EduEstablishment.ID = Student.EduEstablishmentID) as 'EduEstablishment',
	(select
		(select Teacher.FIO from Teacher where Teacher.ID = EduEstablishment.directorID)	
	from EduEstablishment where EduEstablishment.ID = Student.EduEstablishmentID
	) as 'director',
	COUNT(*) as 'count student'
from Student
group by Student.EduEstablishmentID

--7. Максимальный и минимальный баллы по каждому предмету, а также учащихся их учебное заведение с ФИО директора.
select
	Discipline.nameDiscipline as 'discipline',
	(select MIN(mark)from Exam where disciplineID=Discipline.ID) as 'min',
	(select MAX(mark)from Exam where disciplineID=Discipline.ID) as 'max'
from Discipline

select
	Student.FIO as 'name',
	(select EduEstablishment.nameEstablishment from EduEstablishment where EduEstablishment.ID = Student.EduEstablishmentID) as 'EduEstablishment',
	(select
		(select Teacher.FIO from Teacher where Teacher.ID = EduEstablishment.directorID)	
	from EduEstablishment where EduEstablishment.ID = Student.EduEstablishmentID
	) as 'director'
from Student

--8. Средний балл по каждому предмету.
select
	Discipline.nameDiscipline as 'discipline',
	(select avg(mark)from Exam where disciplineID=Discipline.ID) as 'middle'
from Discipline

--9. Количество учащихся из школ (МБОУ), набравших баллы ниже среднего. 
;with 
	MiddleMark as(
		select avg(mark) as 'avg' from Exam
	)

select distinct COUNT(*) as 'count'
from Student
cross join MiddleMark
join Exam on (Exam.StudentID = Student.ID and Exam.mark < MiddleMark.avg)
join EduEstablishment on (EduEstablishment.ID = Student.EduEstablishmentID)
where EduEstablishment.typeEstablishmentID = 1


--10. Учебные заведения, в которых больше всего учеников набрали баллы ниже среднего для каждого из предметов. 
;with
	MiddleMarkDiscipline as (
		select
			Discipline.ID as 'ID',
			Discipline.nameDiscipline as 'nameDiscipline',
			(select avg(mark)from Exam where disciplineID=Discipline.ID) as 'middle'
		from Discipline
	),
	Temp_Table as(
		select 
		EduEstablishment.nameEstablishment as 'Establishment',
		MiddleMarkDiscipline.nameDiscipline as 'Discipl',
		count(*) as 'CountStud'
		from EduEstablishment
		join Student on (EduEstablishment.ID = Student.EduEstablishmentID)
		join Exam on (Student.ID = Exam.StudentID)
		join MiddleMarkDiscipline on (MiddleMarkDiscipline.ID = Exam.disciplineID)
		where Exam.mark<MiddleMarkDiscipline.middle
		group by EduEstablishment.nameEstablishment, MiddleMarkDiscipline.nameDiscipline
	)

select Establishment, Discipl, Max(CountStud)
from Temp_Table
group by Establishment, Discipl
--group by Discipl

