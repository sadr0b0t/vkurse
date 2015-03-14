# Схема базы данных #
![http://vkurse.googlecode.com/svn/doc/DB/DBscheme.png](http://vkurse.googlecode.com/svn/doc/DB/DBscheme.png)

Все внешние ссылки указывают на поле ID, сама ссылка производится с соответсвующего поля. Например, examTypeID -> ExamTypes.ID

# Текстовое описание #

```
= Schedule =		//  Каждая запись - элемент расписания. Представляет собой список занятий на неделе с указанием
					//  предмета группы, преподавателя, аудитории, днем недели, началом, длительностью и т.д.
int		ID
int		groupID		-> Groups.ID
byte	day
time	startTime
time	length
int		lectureID	-> Lectures.ID
int		roomID		-> Rooms.ID
int		teacherID	-> Teachers.ID
int           lectureTypeID   -> LectureTypes.ID
string	comment



= ScheduleChanges =	//  Изменения в расписании. Если какое-то из полей ...ID = null, значит оно не изменено.
int		ID
int		scheduleID	-> Schedule.ID		//  Какой элемент расписания изменяем. Если null, значит просто дополниельная пара
int		week							//  Изменения касаются только элемента расписания на конкретной неделе, указанной в week
int		groupID		-> Groups.ID		//  Занятия будут проходить у другой группы
byte	day								//  Эти три поля связаны с изменением дня/времени занятия
time	startTime
time	length
int		lectureID	-> Lectures.ID		//  Изменен предмет. На практике бывает редко, но бывает
int		roomID		-> Rooms.ID			//  Изменена аудитория
int		teacherID	-> Teachers.ID		//  Замена преподавателя
int           lectureTypeID   -> LectureTypes.ID      //  изменен тип занятия (лекция вместо семинара)
int           cancel                                  //  Отмена занятия
string	comment							//  У изменений в расписании комментарии будут наверняка



= Lectures = 		//  Список возможных предметов (название предмета, тип отчетности)
int		ID
string 	name
int		examTypeID	-> ExamTypes.ID
string	comment



= Groups =			//  Список групп
int		ID
string	name
string	course



= Teachers =		//  Список преподавателей
int		ID
string	name
string	degree



= ExamTypes =		//  Список типов отчетности (т.к. будут не только экзамен/зачет, но и диф.зачет, письменный+устный, и т.д.)
int		ID
string 	name



= Rooms =			//  Список аудиторий
int		ID
string	name



= LectureTypes =           //  Список видов занятий
int             ID
string  name
```


# SQL-запрос создания таблиц в базе данных #

```
CREATE TABLE teachers
(
  id serial NOT NULL,
  "name" character varying(255),
  degree character varying(255),
  CONSTRAINT teachers_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);


CREATE TABLE examtypes
(
  id serial NOT NULL,
  "name" character varying(255),
  CONSTRAINT examtypes_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);


CREATE TABLE groups
(
  id serial NOT NULL,
  "name" character varying(255),
  course character varying(255),
  CONSTRAINT groups_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);


CREATE TABLE lectures
(
  id serial NOT NULL,
  "name" character varying(255),
  examtypeid integer NOT NULL,
  "comment" character varying(255),
  CONSTRAINT lectures_pkey PRIMARY KEY (id),
  CONSTRAINT lectures_examtypeid_fkey FOREIGN KEY (examtypeid)
      REFERENCES examtypes (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT
)
WITH (
  OIDS=FALSE
);


CREATE TABLE lecturetypes
(
  id serial NOT NULL,
  "name" character varying(255),
  CONSTRAINT lecturetypes_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);


CREATE TABLE rooms
(
  id serial NOT NULL,
  "name" character varying(255),
  CONSTRAINT rooms_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);


CREATE TABLE schedule
(
  id serial NOT NULL,
  groupid integer NOT NULL,
  "day" integer NOT NULL,
  starttime integer NOT NULL,
  length integer NOT NULL,
  lectureid integer NOT NULL,
  roomid integer NOT NULL,
  teacherid integer NOT NULL,
  lecturetypeid integer NOT NULL,
  "comment" character varying(255),
  CONSTRAINT schedule_pkey PRIMARY KEY (id),
  CONSTRAINT "schedule_groupID_fkey" FOREIGN KEY (groupid)
      REFERENCES groups (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedule_lectureID_fkey" FOREIGN KEY (lectureid)
      REFERENCES lectures (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedule_lectureTypeID_fkey" FOREIGN KEY (lecturetypeid)
      REFERENCES lecturetypes (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedule_roomID_fkey" FOREIGN KEY (roomid)
      REFERENCES rooms (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedule_teacherID_fkey" FOREIGN KEY (teacherid)
      REFERENCES teachers (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT
)
WITH (
  OIDS=FALSE
);


CREATE TABLE schedulechanges
(
  id serial NOT NULL,
  scheduleid integer NOT NULL,
  week integer NOT NULL,
  groupid integer NOT NULL,
  "day" integer NOT NULL,
  starttime integer NOT NULL,
  length integer NOT NULL,
  lectureid integer NOT NULL,
  roomid integer NOT NULL,
  teacherid integer NOT NULL,
  lecturetypeid integer NOT NULL,
  cancel integer NOT NULL,
  "comment" character varying(255),
  CONSTRAINT schedulechanges_pkey PRIMARY KEY (id),
  CONSTRAINT "schedulechanges_groupID_fkey" FOREIGN KEY (groupid)
      REFERENCES groups (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedulechanges_lectureID_fkey" FOREIGN KEY (lectureid)
      REFERENCES lectures (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedulechanges_lectureTypeID_fkey" FOREIGN KEY (lecturetypeid)
      REFERENCES lecturetypes (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedulechanges_roomID_fkey" FOREIGN KEY (roomid)
      REFERENCES rooms (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedulechanges_scheduleID_fkey" FOREIGN KEY (scheduleid)
      REFERENCES schedule (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT,
  CONSTRAINT "schedulechanges_teacherID_fkey" FOREIGN KEY (teacherid)
      REFERENCES teachers (id) MATCH SIMPLE
      ON UPDATE RESTRICT ON DELETE RESTRICT
)
WITH (
  OIDS=FALSE
);
```