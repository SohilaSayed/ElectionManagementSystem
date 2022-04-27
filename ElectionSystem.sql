
Create table governorate
(
governorateId number(3) ,
governorateName varchar (20) PRIMARY KEY
);

Create table city
(
governorateName varchar (20) references governorate(governorateName),
cityName varchar (20) PRIMARY KEY
);
alter table candidates
add (governorateName varchar (20) references governorate(governorateName));
alter table candidates
add (cityName varchar (20) references city(cityName));
Create table candidates
(
candidateId number(3) PRIMARY KEY ,
candidateName varchar (20),
candidateFamilyName varchar (20),
sex varchar (6),
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
drop table nominating;

Create table candidateVoter
(
candidateId number(3) references candidates(candidateId),
voterId number(14) references voters(voterId)
);

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

INSERT INTO candidates values
(101,'Sohila','Sayed','Female','18-Jun-2001');
INSERT INTO candidates values
(102,'Samira','Yahia','Female','17-Sep-2001');
INSERT INTO candidates values
(103,'Israa','Hassan','Female','20-Oct-2001');
INSERT INTO candidates values
(104,'Israa','Gaber','Female','1-Jul-2001');
INSERT INTO candidates values
(105,'Samar','Nasr','Female','27-Jul-2001');
INSERT INTO candidates values
(106,'Ahmed','Elbeheriy','Male','5-Mar-2002');
INSERT INTO candidates values
(107,'Gabriel','Mark','Male','25-Nov-2000');



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

insert into city values
('Cairo','Misr Elgededa');
insert into city values
('Cairo','Ain Shams');
insert into city values
('Cairo','Abdeen');
insert into city values
('Cairo','Shoubra');
insert into city values
('Cairo','Madient Nasr');

 insert into city values
('Alexandria','Smouha');
insert into city values
('Alexandria','Sidi Beshr');
insert into city values
('Alexandria','Sidi Gaber');
insert into city values
('Alexandria','Montaza');
insert into city values
('Alexandria','Ras Elten');

 insert into city values
('Giza','Imbaba');
insert into city values
('Giza','Dokki');
insert into city values
('Giza','Elagouza');
insert into city values
('Giza','Ben Elsrayat');
insert into city values
('Giza','Haram');

 insert into city values
('Qalyubia','Tokh');
insert into city values
('Qalyubia','Qalyub');
insert into city values
('Qalyubia','Elkhanka');
insert into city values
('Qalyubia','Shubra Elkhema');
insert into city values
('Qalyubia','Shebin Elknater');

 insert into city values
('Qena','Qus');
insert into city values
('Qena','Nage Hmady');
insert into city values
('Qena','Deshna');
insert into city values
('Qena','Armant');
insert into city values
('Qena','Abnud');
Commit;