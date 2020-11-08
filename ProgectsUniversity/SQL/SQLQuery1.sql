--Создание БД
create database Exams
--Создание таблиц
create table EduEstablishment
(
	ID integer not null identity(1,1) primary key ,
	nameEstablishment nchar(50),
	directorID integer,
	typeEstablishmentID integer
);

create table TypeEstablishment
(
	ID integer not null identity(1,1) primary key ,
	nameType nchar(50)
);

create table Discipline
(
	ID integer not null identity(1,1) primary key ,
	nameDiscipline nchar(50)
);

create table Teacher
(
	ID integer not null identity(1,1) primary key ,
	FIO nchar(50),
	phoneNumber nchar(50)
);

create table Student
(
	ID integer not null identity(1,1) primary key ,
	FIO nchar(50),
	courseNumber integer,
	EduEstablishmentID integer
);

create table Exam
(
	ID integer not null identity(1,1) primary key ,
	disciplineID integer,
	StudentID integer,
	mark integer
);

--Создание связей между таблицами
alter table EduEstablishment
	add constraint FK_Establishment_Director foreign key(directorID)
		references Teacher (ID)
		on delete cascade
		on update cascade
;
alter table EduEstablishment
	add constraint FK_Establishment_Type foreign key(typeEstablishmentID)
		references TypeEstablishment (ID)
		on delete cascade
		on update cascade
;
alter table Student
	add constraint FK_Student_Establishment foreign key(EduEstablishmentID)
		references EduEstablishment (ID)
		on delete cascade
		on update cascade
;
alter table Exam
	add constraint FK_Exam_Discipline foreign key(disciplineID)
		references Discipline (ID)
		on delete cascade
		on update cascade
;
alter table Exam
	add constraint FK_Exam_Student foreign key(StudentID)
		references Student (ID)
		on delete cascade
		on update cascade
;

--Заполнение таблиц



--TypeEstablishment
INSERT INTO TypeEstablishment(nameType)
VALUES ('Школа');
INSERT INTO TypeEstablishment(nameType)
VALUES ('техникум');
INSERT INTO TypeEstablishment(nameType)
VALUES ('колледж');

--Discipline
INSERT INTO Discipline(nameDiscipline)
VALUES ('Математика');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Информатика');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Физика');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Русский язык');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Литература');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Химия');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Биология');
INSERT INTO Discipline(nameDiscipline)
VALUES ('История');
INSERT INTO Discipline(nameDiscipline)
VALUES ('Обществознание');

--Teacher
DECLARE @i int;--для счетчика
SET @i = 1
WHILE @i <= 5
	BEGIN 
		INSERT INTO Teacher(FIO, phoneNumber)
		VALUES ('Фамилия'+CONVERT(varchar, @i,0),CONVERT(varchar, @i*111111,0) )
		SET @i = @i + 1
	END

--EduEstablishment
INSERT INTO EduEstablishment(nameEstablishment,directorID,typeEstablishmentID)
VALUES ('МБОУ1',1,1);
INSERT INTO EduEstablishment(nameEstablishment,directorID,typeEstablishmentID)
VALUES ('МБОУ1',2,1); 
INSERT INTO EduEstablishment(nameEstablishment,directorID,typeEstablishmentID)
VALUES ('Техникум1',3,2); 
INSERT INTO EduEstablishment(nameEstablishment,directorID,typeEstablishmentID)
VALUES ('техникум 2',4,2); 
INSERT INTO EduEstablishment(nameEstablishment,directorID,typeEstablishmentID)
VALUES ('Колледж1',5,3);

--Student
SET @i = 1
WHILE @i <= 5
	BEGIN 
		INSERT INTO Student(FIO, courseNumber, EduEstablishmentID)
		VALUES ('Учащийся'+CONVERT(varchar, @i,0),@i%4+1,@i%5+1 )
		SET @i = @i + 1
	END

--Exam
SET @i = 1
WHILE @i <= 300
	BEGIN 
		INSERT INTO Exam(disciplineID, StudentID, mark)
		VALUES (CONVERT(int,RAND(@i))%9+1,
				CONVERT(int,RAND(@i))%4+1,
				CONVERT(int,RAND(@i))%5+1 )
		SET @i = @i + 1
	END


