--1) Вывести все данные из каждой таблицы.
select*
from Discipline
select*
from EduEstablishment
select*
from TypeEstablishment
select*
from Teacher
select*
from Student
select*
from Exam


--2) Вывести первые 5 записей из таблицы Учащийся.
select top(5)*
from Student

--3) Вывести список учащихся, экзамены и набранные ими балы, использовать переименование столбцов.
select
	(select FIO from Student where ID = StudentID) as Student,
	(select nameDiscipline from Discipline where ID=disciplineID) as Discipline,
	mark as Оценка
from Exam

--4) Вывести всех участников, набравших больше 50 баллов хотя бы по 1 предмету.(сделал >3 потому что в бд оценки от 1 до 5)
select distinct
	(select FIO from Student where ID = StudentID)as Student
	--(select nameDiscipline from Discipline where ID=disciplineID)as Discipline,
	--mark as Оценка
from Exam
where mark>3

--5) Вывести всех школьников, в фамилии которых есть цифра 5.
select 
	FIO	as Student
from Student
where CHARINDEX('5', FIO)>0
--6) Вывести всех девятиклассников из школы с индексом 1.(вместо девятикласников - третьекурсники)
select *
from Student
where courseNumber=3 and EduEstablishmentID=1

--7) Вывести все предметы, которые сдавали учащиеся.
select distinct
	(select nameDiscipline from Discipline where ID=disciplineID)as Discipline
from Exam

--8) Вывести список учащихся, отсортированный по количеству набранных балов, сдававших предмет с индексом 5.
select distinct 
	(select FIO from Student where ID = StudentID)as Student,
	mark as Оценка
from Exam
where disciplineID=5
order by mark desc

--9) Вывести все учебные заведения, в которых учащиеся сдавали экзамены.
select distinct
	(select 
		(select nameEstablishment from EduEstablishment where ID=EduEstablishmentID)
	from Student
	where ID = StudentID) as Establishment,
	
	(select 
		(select directorID from EduEstablishment where ID=EduEstablishmentID)
	from Student
	where ID = StudentID) as directorID
from Exam

--10) Подсчитать средний балл для каждого учащегося.
select
	(select FIO from Student where ID = StudentID)as Student, 
	avg(mark) as MiddleMark
from Exam
where disciplineID=5
group by StudentID
order by StudentID

--11) Подсчитать количество учеников, набравших меньше 50 баллов.
select COUNT(distinct StudentID)
from Exam
where mark<3

--12) Подсчитать количество школьников, набравших 100 баллов по предмету с индексом 1.
select COUNT(distinct StudentID)
from Exam
where mark=5 and disciplineID=1

--13) Подсчитать количество учащихся в 11 классе в школе с индексом 1.
select COUNT(*)
from Student
where EduEstablishmentID=1

--14) Найти минимальный балл по предмету с индексом 1.
select MIN(mark)
from Exam
where disciplineID=1

--15) Найти средний балл по предмету с индексом 5 для каждого учебного заведения.
select
	EduEstablishment.nameEstablishment as 'Name',
	avg(Exam.mark) as MiddleMark
from Exam
	join Student on Student.ID=Exam.StudentID
	join EduEstablishment on EduEstablishment.ID=Student.EduEstablishmentID
where Exam.disciplineID=5
group by EduEstablishment.nameEstablishment
