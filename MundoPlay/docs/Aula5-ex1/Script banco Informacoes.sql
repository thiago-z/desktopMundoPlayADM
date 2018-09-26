create database Informacoes
use Informacoes

create table clientes (
id smallint identity primary key,
nome varchar(80) not null,
endereco varchar(80) not null,
cep varchar(9),
bairro varchar(50),
cidade varchar(50),
uf varchar(2),
telefone varchar(15),
cpf varchar(14),
img varchar(200))

insert into clientes (nome,endereco,cep,bairro,cidade,uf,telefone,cpf) 
values
('João dps Santos', 'Rua Tito,45', '02205-001','lapa', 'São Paulo', 'SP', '(11) 99876-9923', '123.456.789-00');
 