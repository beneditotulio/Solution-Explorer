create database sistema_gestao_stock;
use sistema_gestao_stock;
select * FROM TB_fornecedor where nome like 'lourenco'

create table TB_Requisicao 
(Idrequisaicao int primary key,
Produto int foreign key references TB_produto(idproduto),
data varchar(20),
cliente int foreign key references TB_cliente(idcliente),
empresa int foreign key references TB_empresa(idempresa),
categoria varchar(20),
unidade varchar(20),
preco varchar(50),
quantidade varchar(50),
stock_dia varchar(50),
quantidade_atual varchar(50),
sub_total varchar(50),
total varchar(50),
quantidade_total varchar(50));

select * from TB_Requisicao;
select * from TB_categoria

SELECT * FROM TB_fornecedor

create table TB_empresa
(Idempresa int primary key,
descreicao varchar(100),
fax varchar(20),
Tell varchar(20));

CREATE TABLE TB_cliente (
  idcliente int NOT NULL,
 cracha varchar(40) ,
  Nome varchar(40) NOT NULL,
 Sexo int foreign key references TB_Sexo(IdSexo),
    contacto1 varchar(40),
   Contacto varchar(20) ,
   email varchar(40) ,
  PRIMARY KEY (idcliente));
  --CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`idcliente`) REFERENCES `aluguer` (`IDaluguer`)
--) ENGINE=InnoDB DEFAULT CHARSET=latin1;






create table TB_Sexo
(IdSexo int primary key,
Sexo varchar(15));
select * from TB_sexo
Select * from TB_Sexo Where sexo like 'Masculino'
insert into TB_Sexo 
values('','Masculino'),
('','Femenino');
select* from TB_Sexo
select * from TB_encomenda;
select * from TB_produto
create table TB_produto 
(Idproduto int primary key,
produto varchar(50) ,
categoria int foreign key references TB_categoria(Idcategoria),
unidade varchar(10),
Quantidade_desponivel numeric);
drop table TB_produto
select * from TB_produto 
create table TB_categoria 
(Idcategoria int primary key,
categoia varchar(50));
select * from TB_categoria;
delete  from TB_categoria
select unidade from TB_unidade order by unidade asc


create table TB_stock_entrada 
(Id_produto_entarada int primary key,
produto varchar(50) ,
categoria varchar(25),
unidade varchar(10),
Quantidade_entrada numeric,
data_entrada date not null);

create table TB_Funcionario 
(IdFuncionario int primary key,
Tipo_Documento varchar(13) ,
Número_doc varchar(20),
Nome varchar(100),
Apelido varchar(70),
Sexo int foreign key references TB_Sexo(IdSexo),
Contacto Varchar(20),
Telefone_Alternativo Varchar(20),
Email varchar(100));


select * from TB_categoria where categoia  like''

--Delete From Funcionario

--Alter Table Funcionario Drop Column IdFuncionario
--Alter Table Funcionario Add IdFuncionario int
Update Funcionario Set IdFuncionario = 1 Where NumeroCaracha like 1122