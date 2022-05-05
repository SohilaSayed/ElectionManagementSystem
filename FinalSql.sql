drop table candidateVoter;
drop table voters;
drop table candidates;
drop table city;
drop table governorate;



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

Create table candidates
(
candidateId number(3) PRIMARY KEY ,
candidateName varchar (20),
candidateFamilyName varchar (20),
sex varchar (6),
birthDate Date,
numberOfVoters number(3),
governorateName varchar (20) references governorate(governorateName),
cityName varchar (20) references city(cityName)
);

Create table voters
(
candidateId number(3) references candidates(candidateId),
voterId number(14) PRIMARY KEY,
voterName varchar (20),
voterFamilyName varchar (20),
sex varchar (6)
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

INSERT INTO candidates values
(101,'Sohila','Sayed','Female','18-Jun-2001' , 0 ,'Cairo','Misr Elgededa');
INSERT INTO candidates values
(102,'Samira','Yahia','Female','17-Sep-2001' , 0 ,'Qena','Nage Hmady');
INSERT INTO candidates values
(103,'Israa','Hassan','Female','20-Oct-2001', 0 ,'Giza','Imbaba');
INSERT INTO candidates values
(104,'Israa','Gaber','Female','24-May-2001', 0 ,'Qalyubia','Shubra Elkhema');
INSERT INTO candidates values
(105,'Samar','Nasr','Female','27-Jul-2001', 0 ,'Qalyubia','Qalyub');
INSERT INTO candidates values
(106,'Ahmed','Elbeheriy','Male','5-Mar-2002', 0 ,'Giza','Elagouza');
INSERT INTO candidates values
(107,'Gabriel','Mark','Male','25-Nov-2000', 0 ,'Alexandria','Smouha');
INSERT INTO candidates values
(108,'Hassan','Elbana','Male','28-Aug-2001' , 0 ,'Cairo','Shoubra');
INSERT INTO candidates values
(109,'Khadeja','Mohsen','Female','17-Jan-2001' , 0 ,'Alexandria','Sidi Gaber');
INSERT INTO candidates values
(110,'John','Youssef','Male','1-Sep-2001' , 0 ,'Qena','Qus');

Commit;


