
Create table governorate
(
governorateId number(3) PRIMARY KEY,
governorateName varchar (20)
);

Create table city
(
governorateId number(3) references governorate(governorateId),
cityId number(3) PRIMARY KEY,
cityName varchar (20),
numberOfMember number(3)
);

Create table candidates
(
candidateId number(3) PRIMARY KEY ,
candidateName varchar (20),
candidateFamilyName varchar (20),
sex varchar (6),
governorateId number(3) references governorate(governorateId),
birthDate Date,
numberOfVoters number(3)
);

Create table voters
(
candidateId number(3) references candidates(candidateId),
voterId number(14) PRIMARY KEY,
voterName varchar (20),
voterFamilyName varchar (20),
sex varchar (6)
);

Create table nominating
(
candidateId number(3) references candidates(candidateId),
nominateDate Date,
numberOfVotes number(3)
);

Create table candidateVoter
(
candidateId number(3) references candidates(candidateId),
voterId number(14) references voters(voterId)
);
Insert into governorate values
(1,'Cairo');
Insert into governorate values
(2,'Alexandria');
Insert into governorate values
(3,'Giza');
Insert into governorate values
(4,'Qalyubia');
Insert into governorate values
(5,'Qena');


INSERT INTO candidates (candidateId, candidatename, candidatefamilyname, sex, governorateid, birthdate, numberofvoters)
values
(101,'Sohila','Sayed','Female',1,'18-Jun-2001',0);
INSERT INTO candidates values
(102,'Samira','Yahia','Female',1,'17-Sep-2001',0);
INSERT INTO candidates values
(103,'Israa','Hassan','Female',2,'20-Oct-2001',0);
INSERT INTO candidates values
(104,'Israa','Gaber','Female',3,'1-Jul-2001',0);
INSERT INTO candidates values
(105,'Samar','Nasr','Female',4,'27-Jul-2001',0);
INSERT INTO candidates values
(106,'Ahmed','Elbeheriy','Male',2,'5-Mar-2002',0);
INSERT INTO candidates values
(107,'Gabriel','Mark','Male',5,'25-Nov-2000',0);


insert into nominating values
(101,'1-Jun-2022',0);
insert into nominating values
(102,'12-Jan-2022',0);
insert into nominating values
(101,'28-Oct-2022',0);
insert into nominating values
(102,'1-Jun-2022',0);
insert into nominating values
(107,'12-Jan-2022',0);
insert into nominating values
(103,'28-Oct-2022',0);
insert into nominating values
(105,'12-Jan-2022',0);
insert into nominating values
(104,'28-Oct-2022',0);
insert into nominating values
(103,'12-Jan-2022',0);







insert into city values
(1,11,'Misr Elgededa',5);
insert into city values
(1,21,'Ain Shams',3);
insert into city values
(1,31,'Abdeen',7);
insert into city values
(1,41,'Shoubra',8);
insert into city values
(1,51,'Madient Nasr',6);

 insert into city values
(2,12,'Smouha',7);
insert into city values
(2,22,'Sidi Beshr',5);
insert into city values
(2,32,'Sidi Gaber',3);
insert into city values
(2,42,'Montaza',4);
insert into city values
(2,52,'Ras Elten',6);

 insert into city values
(3,13,'Imbaba',4);
insert into city values
(3,23,'Dokki',5);
insert into city values
(3,33,'Elagouza',3);
insert into city values
(3,43,'Ben Elsrayat',2);
insert into city values
(3,53,'Haram',6);

 insert into city values
(4,14,'Tokh',3);
insert into city values
(4,24,'Qalyub',2);
insert into city values
(4,34,'Elkhanka',4);
insert into city values
(4,44,'Shubra Elkhema',6);
insert into city values
(4,54,'Shebin Elknater',5);

 insert into city values
(5,15,'Qus',3);
insert into city values
(5,25,'Nage Hmady',2);
insert into city values
(5,35,'Deshna',5);
insert into city values
(5,45,'Armant',4);
insert into city values
(5,55,'Abnud',6);

Commit;