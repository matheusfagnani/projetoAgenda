create database db_agenda;

use db_agenda;

create table tb_usuarios(

nome varchar(60) not null,
usuario varchar(50) not null primary key,
telefone varchar (15),
senha varchar (15) not null
);
create table tb_categoria(
cod int auto_increment primary KEY,
nome_categoria varchar (60) not null
);

