-- criando a banco de dados
create database dbsistema;

-- usando o banco de dados
use dbsistema;

-- criando as tabelas do banco

/*Usuario*/
create table Usuario(
Id int auto_increment primary key,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null
);

-- consultando as tabelas do banco
select * from Usuario;