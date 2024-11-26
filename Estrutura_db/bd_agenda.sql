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

delimiter $$

create trigger tb_categoria
before
insert
on tb_categoria 
for each row
begin
	set new.usuario = current_user();
    end;
    
    
    delimiter$$
    
    create table tb_log(
    id_log  varchar(40) primary key,
    usuario varchar (40) not null,
	data_hora datetime not null,
	decricao varchar (70)
    );
    


delimiter ;

delimiter $$


    create trigger trlogDeletCategoria  
    before 
    delete 
    on tb_categoria 
    FOR EACH ROW
    begin 
    
    
     insert into tb_log
     (usuario,
     data, 
     descricao)
     values(user(),
     current_timestamp(),
     concat('a categoria',old.tb_categoria,'foi excluida')
     );
     end;
     $$
delimiter ;

delimiter $$
create trigger trlogCategoria  
    after
	insert
    on tb_categoria
    for each row 
    begin 
    
    
     insert into tb_log
     (usuario,
     data, 
     descricao)
     values(user(),
     current_timestamp(),
     concat('a categoria',new.tb_categoria,'foi adicionada ')
     );
     end;
     $$
     
     

 delimiter ;
     

delimiter $$

create trigger trlogCategoria  
    after
	insert
    on tb_categoria
    for each row 
    begin 
    
    
     insert into tb_log
     (usuario,
     data, 
     descricao)
     values(user(),
     current_timestamp(),
     concat('a categoria',new.tb_categoria,'foi alterada  ')
     );
     end;
     $$

     update tb_categoria
	set nome_categoria = "fornecedoreas" 
    where  