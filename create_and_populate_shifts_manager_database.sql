create database ShiftsManagerDB
go
use ShiftsManagerDB
go
create table USER_TYPE (
	user_type_id integer primary key,
	user_type_desc varchar(20) not null
);
insert into USER_TYPE(user_type_id, user_type_desc) values (1, 'REG_USER')
insert into USER_TYPE(user_type_id, user_type_desc) values (2, 'ADMIN')
create table USERS(
	user_id integer identity(1, 1) primary key,
	user_type_id integer FOREIGN KEY REFERENCES USER_TYPE(USER_TYPE_ID),
	username varchar(45) not null,
	password varchar(45) not null
);
insert into USERS(user_type_id, username, password) values(1, 'John Doe', '12345')
insert into USERS(user_type_id, username, password) values(1, 'Ploni Almoni', '11111')
insert into USERS(user_type_id, username, password) values(1, 'Jane Smith', '00000')
insert into USERS(user_type_id, username, password) values(2, 'Admin', '613')

create table CLOCK_IN_OUT(
	clock_id integer identity(1, 1) primary key,
	user_id integer foreign key references users(user_id),
	day_time_in datetime not null,
	day_time_out datetime null
);
create table PAYMENTS(
	payment_id integer identity(1, 1) primary key,
	user_id integer foreign key references users(user_id),
	payment_amount decimal not null,
	payment_date date not null
);
create table RATE(
	rate_id integer identity(1, 1) primary key,
	user_id integer foreign key references users(user_id),
	rate_amt decimal not null
);

insert into rate(user_id, rate_amt) values(1, 50)
insert into rate(user_id, rate_amt) values(2, 75)
insert into rate(user_id, rate_amt) values(3, 100)

select * from rate;
select * from CLOCK_IN_OUT
select * from USERS
select * from USER_TYPE
select * from payments