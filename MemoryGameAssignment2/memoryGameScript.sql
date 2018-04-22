create database memoryGame

use memoryGame

create table loginInformation (
	username varchar(250),
	password varchar(250)
)
go

alter table loginInformation
	add constraint pk_username primary key (username)
go

insert into loginInformation
values ('user1', 'password1')

