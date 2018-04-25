create database memoryGame

use memoryGame

create table loginInformation (
	username varchar(250) NOT NULL,
	password varchar(250)
)
go

alter table loginInformation
	add constraint pk_username primary key (username)
go

insert into loginInformation
values ('user1', 'password1')

create table highScores (
	scores int
)
go

insert into highScores
values (9000)
go

select * from loginInformation

drop table loginInformation

SELECT scores
	FROM highScores
	ORDER BY scores DESC
go

