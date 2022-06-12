<<<<<<< HEAD
use assignment

create table client_normal
(
clientNo varchar(15) primary key,
cname varchar(15) not null,
propertyNo1 varchar(20),
propertyNo2 varchar(20),
propertyNo3 varchar(20),
Paddress1 varchar(35),
Paddress2 varchar(35),
Paddress3 varchar(35),
RentStart1 date,
RentStart2 date,
RentStart3 date,
Rentstart4 date,
RentStart5 date,
RentFinish1 date,
RentFinish2 date,
RentFinish3 date,
RentFinish4 date,
RentFinish5 date,
Rent1 int,
Rent2 int,
rent3 int,
OwnerNo1 varchar(15),
OwnerNo2 varchar(15),
OwnerName1 varchar(20),
OwnerName2 varchar(20)
)

Insert into client_normal values('CR76','JOHNKAY','PG4','PG16',null,'6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW',null,'1-JUL-00','1-SEP-02',null,null,null,'31-AUG-01','1-SEP-02',null,null,null,350,450,null,'C040','CO93','TINAMURPHY','TONYSHAW')
insert into client_normal values('CR56','ALINESTEWART','PG4','PG16','PG36','6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW','2 MONOR RD GLASGOW',null,null,'1-SEP-99','10-OCT-00','1-NOV-02',null,null,'10-JAN-00','1-DEC-01','1-AUG-03',350,450,370,'C040','CO93','TINAMURPHY','TONYSHAW')

=======
use assignment

create table client_normal
(
clientNo varchar(15) primary key,
cname varchar(15) not null,
propertyNo1 varchar(20),
propertyNo2 varchar(20),
propertyNo3 varchar(20),
Paddress1 varchar(35),
Paddress2 varchar(35),
Paddress3 varchar(35),
RentStart1 date,
RentStart2 date,
RentStart3 date,
Rentstart4 date,
RentStart5 date,
RentFinish1 date,
RentFinish2 date,
RentFinish3 date,
RentFinish4 date,
RentFinish5 date,
Rent1 int,
Rent2 int,
rent3 int,
OwnerNo1 varchar(15),
OwnerNo2 varchar(15),
OwnerName1 varchar(20),
OwnerName2 varchar(20)
)

Insert into client_normal values('CR76','JOHNKAY','PG4','PG16',null,'6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW',null,'1-JUL-00','1-SEP-02',null,null,null,'31-AUG-01','1-SEP-02',null,null,null,350,450,null,'C040','CO93','TINAMURPHY','TONYSHAW')
insert into client_normal values('CR56','ALINESTEWART','PG4','PG16','PG36','6LAWRENCEST.GLASGOW','5NOVARDR.GLASGOW','2 MONOR RD GLASGOW',null,null,'1-SEP-99','10-OCT-00','1-NOV-02',null,null,'10-JAN-00','1-DEC-01','1-AUG-03',350,450,370,'C040','CO93','TINAMURPHY','TONYSHAW')

>>>>>>> 96ffd256c7a5cd6aa08a817f19cfaa91ab2c3d80
select * from client_normal