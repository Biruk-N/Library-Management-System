create database library_management_system
use library_management_system
create table Book
( Book_id int,
  Book_title varchar(50),
  Book_Language varchar(20),
  Publication_year int,
  --Binding_id int,
  Author varchar(20),
  --shelf_id int,
  --Category_id int,
  Purchase_date date,
  Book_price int,
  Book_quantity int,
  Primary key (Book_id)
  );
  drop table Book
	insert into Book values(1221,'Fiker Eske Meqaber 14th Edition','Amharic',2018,'Hadis Alemayehu','2022-10-22',50,5);
	insert into Book values(1232,'A Guide to the SQL standard','English',1997,'Addison Wesley','2022-10-22',50,5);
	insert into Book values(1223,'Programming Fundamentals','English',2001,NULL,'2022-02-12',50,10);
	insert into Book values(1224,'An Introdction to Database System','English',1995,'Addison Wesley','2022-01-19',50,15);

  drop table Category

  drop table Borrower
  drop table Shelf
  drop table Book_binding
  drop table Staff
  drop table Shelf
  drop table Customer
  drop table Student
    
create table Category
( Category_id int,
  Category_name varchar(50),
  Primary key (Category_id)
);
--create table Student
--( Student_id int,
--  Student_name varchar(20),
--  Sex char constraint Student_sexchk check(sex in('M','F')),
--  Birth_date date,
--  Borrower_id int,
--  Department varchar(20),
--  Phone_number varchar(10),
--  Primary key (Student_id),
--  foreign key (Borrower_id) references Borrower(Borrower_id) 
--  );
--create table Staff
--( Stuff_id int,
--  Stuff_name varchar(20),
--  Staff_role varchar(20),
--  Password varchar(16),
--  primary key(stuff_id)
--);
--create table Book_binding
--( Binding_id int,
--  Binding_name varchar(50),
--  Primary key (Binding_id)
--);
--create table Shelf
--( Shelf_id int,
--  Floor_no int,
--  Primary key (shelf_id)
--);

create table Customer
(Customer_id int,
 Customer_role varchar(50),
 Customer_contact varchar(50),
 primary key(Customer_id),

);
create table Log_in
(
 username varchar(50),
 pass varchar(40)
);

insert into Log_in values('Biruk','123');

insert into Category values(01,'Fiction');
insert into Category values(02,'Biography');
insert into Category values(03,'Textbook');
insert into Category values(04,'Essay');
insert into Category values(05,'Reference Book');
insert into Category values(06,'Fiction');

--insert into Book_binding values(001,'Case Binding');
--insert into Book_binding values(002,'Perfect Binding');
--insert into Book_binding values(003,'Saddle Stitch Binding');
--insert into Book_binding values(004,'Comb spiral and Thermal Binding');
--insert into Book_binding values(005,'Comb spiral and Thermal Binding');

--insert into Shelf values(11,0);
--insert into Shelf values(12,0);
--insert into Shelf values(13,1);
--insert into Shelf values(14,1);
--insert into Shelf values(15,1);


select * from Book where Book_title = 'The Power Of Now';
select * from Book 

select count(Book_id) from Book

--insert into staff values(921,'Tsehaye Mengestu','Librarian','mengestu1882');
--insert into staff values(920,'Oliad getaneh','Librarian','ethiopiahagere');

--insert into Student values(3077,'Bamlak Molla','M','1999-08-23',2312,'Computer Science',0922329900);
--insert into Student values(1937,'Sahib salih','M','1998-02-20',2344,'Computer Science',0911842048);
--insert into Student values(1938,'Siham Remadan','F','2000-10-07',2313,'Computer Science',0912674047);
--insert into Student values(1946,'Yadeal Million','M','1999-02-11',2341,'Computer Science',0941552848);


insert into Borrower values(2312,1232,'2019-10-23','2019-10-30',null,'Tsehaye Mengestu');
insert into Borrower values(2344,1223,'2019-12-03','2019-12-23','2019-12-23','Tsehaye Mengestu');
insert into Borrower values(2313,1224,'2019-03-24','2019-04-12',null,'Oliad getaneh');
insert into Borrower values(2341,1223,'2019-10-03','2019-10-23','2019-10-21','Tsehaye Mengestu');
