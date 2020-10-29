create database BDPessoa
go
use BDPessoa
go

create table Pessoa
(
  IdContato   int           primary key   identity,
  Nome        varchar(60)   not null,
  Idade       int           not null,
  Email       varchar(100)  not null,
  Login       varchar(20)   not null

)

insert into Pessoa values ('Fulano',20, 'fulano@email.com','Fulano')
insert into Pessoa values ('Ciclano',30, 'ciclano@email.com','Ciclano')
insert into Pessoa values ('Beltrano',40, 'beltrano@email.com','Beltrano')