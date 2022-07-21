use R6_product;

create table characters(
	name varchar (40) primary key,
	country varchar (40) not null,
	attdef varchar (10) not null,
	armor varchar (10) not null,
	unity varchar (40) not null,
	speed varchar (10) not null
)

create table introduction(
	Intro_name varchar(40) primary key,
	style Text not null,
	back Text not null,
	foreign key(Intro_name) references characters(name)
)

drop table introduction;