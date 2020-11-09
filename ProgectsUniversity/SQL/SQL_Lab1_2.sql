--1) ������� ��� ������ �� ������ �������.
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


--2) ������� ������ 5 ������� �� ������� ��������.
select top(5)*
from Student

--3) ������� ������ ��������, �������� � ��������� ��� ����, ������������ �������������� ��������.
select
	(select FIO from Student where ID = StudentID) as Student,
	(select nameDiscipline from Discipline where ID=disciplineID) as Discipline,
	mark as ������
from Exam

--4) ������� ���� ����������, ��������� ������ 50 ������ ���� �� �� 1 ��������.(������ >3 ������ ��� � �� ������ �� 1 �� 5)
select distinct
	(select FIO from Student where ID = StudentID)as Student
	--(select nameDiscipline from Discipline where ID=disciplineID)as Discipline,
	--mark as ������
from Exam
where mark>3

--5) ������� ���� ����������, � ������� ������� ���� ����� 5.
select 
	FIO	as Student
from Student
where CHARINDEX('5', FIO)>0
--6) ������� ���� ���������������� �� ����� � �������� 1.(������ ��������������� - ��������������)
select *
from Student
where courseNumber=3 and EduEstablishmentID=1

--7) ������� ��� ��������, ������� ������� ��������.
select distinct
	(select nameDiscipline from Discipline where ID=disciplineID)as Discipline
from Exam

--8) ������� ������ ��������, ��������������� �� ���������� ��������� �����, ��������� ������� � �������� 5.
select distinct 
	(select FIO from Student where ID = StudentID)as Student,
	mark as ������
from Exam
where disciplineID=5
order by mark desc

--9) ������� ��� ������� ���������, � ������� �������� ������� ��������.
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

--10) ���������� ������� ���� ��� ������� ���������.
select
	(select FIO from Student where ID = StudentID)as Student, 
	avg(mark) as MiddleMark
from Exam
where disciplineID=5
group by StudentID
order by StudentID

--11) ���������� ���������� ��������, ��������� ������ 50 ������.
select COUNT(distinct StudentID)
from Exam
where mark<3

--12) ���������� ���������� ����������, ��������� 100 ������ �� �������� � �������� 1.
select COUNT(distinct StudentID)
from Exam
where mark=5 and disciplineID=1

--13) ���������� ���������� �������� � 11 ������ � ����� � �������� 1.
select COUNT(*)
from Student
where EduEstablishmentID=1

--14) ����� ����������� ���� �� �������� � �������� 1.
select MIN(mark)
from Exam
where disciplineID=1

--15) ����� ������� ���� �� �������� � �������� 5 ��� ������� �������� ���������.
select
	EduEstablishment.nameEstablishment as 'Name',
	avg(Exam.mark) as MiddleMark
from Exam
	join Student on Student.ID=Exam.StudentID
	join EduEstablishment on EduEstablishment.ID=Student.EduEstablishmentID
where Exam.disciplineID=5
group by EduEstablishment.nameEstablishment
