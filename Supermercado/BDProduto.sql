
create database BDProduto
go
use BDProduto
go

create table Produto
(
  Id          int           primary key   identity,
  Nome        varchar(60)   not null,
  Categoria   varchar(100)  not null,
  Marca       varchar(100)  not null,
  Preco       varchar(100)  not null

)

insert into Produto values ('Desinfetante', 'Limpeza', 'VEJA','R$5.00')
insert into Produto values ('Sab�o em P�', 'Limpeza', 'OMO','R$18.90')
insert into Produto values ('Saco de lixo', 'Limpeza', 'Casa','R$3.50')
insert into Produto values ('Pano de ch�o', 'Limpeza', 'Casa','R$2.00')
insert into Produto values ('Vassoura', 'Utilidades', 'Casa','R$7.00')
insert into Produto values ('Lixeira', 'Utilidades', 'Casa','R$11.00')
insert into Produto values ('Picanha', 'Carne', 'Seara','R$16.89')
insert into Produto values ('Peito de Frango', 'Carne', 'Sadia','R$9.99')
insert into Produto values ('Bacalhau', 'Carne', 'Frutos do Mar','R$26.90')
insert into Produto values ('Atum', 'Carne', 'Frutos do Mar','R$7.89')
insert into Produto values ('Banana Prata', 'Frutas', 'Horta','R$2.99')
insert into Produto values ('Banana Caturra', 'Frutas', 'Horta','R$3.99')
insert into Produto values ('Uva', 'Frutas', 'Horta','R$6.00')
insert into Produto values ('Morango', 'Frutas', 'Horta','R$3.00')
insert into Produto values ('P�ssego', 'Frutas', 'Horta','R$8.00')
insert into Produto values ('Ma��', 'Frutas', 'Horta','R$7.68')
insert into Produto values ('Cenoura', 'Hortali�as', 'Produtos Org�nicos','R$1.00')
insert into Produto values ('Tomate', 'Hortali�as', 'Produtos Org�nicos','R$3.00')
insert into Produto values ('Couve', 'Hortali�as', 'Produtos Org�nicos','R$1.00')
insert into Produto values ('Alface', 'Hortali�as', 'Produtos Org�nicos','R$1.00')
insert into Produto values ('Espinafre', 'Hortali�as', 'Produtos Org�nicos','R$2.00')
insert into Produto values ('Beterraba', 'Hortali�as', 'Produtos Org�nicos','R$2.00')
insert into Produto values ('Batata', 'Hortali�as', 'Produtos Org�nicos','R$2.50')
insert into Produto values ('Macarr�o Penne', 'Massas', 'Vilma','R$2.50')
insert into Produto values ('Lasanha', 'Massas', 'Galo','R$3.00')
insert into Produto values ('Macarr�o Espaguete', 'Massas', 'santa Am�lia','R$3.20')
insert into Produto values ('P�o Franc�s', 'Padaria', '1001 P�es','R$5.00')
insert into Produto values ('Panetone', 'Padaria', '1001 P�es','R$7.00')
insert into Produto values ('Pastel de Frango', 'Padaria', '1001 P�es','R$2.50')
insert into Produto values ('Coxinha', 'Padaria', '1001 P�es','R$1.50')
insert into Produto values ('Cookies', 'Padaria', '1001 P�es','R$3.00')
insert into Produto values ('Broa de Milho', 'Padaria', '1001 P�es','R$4.00')