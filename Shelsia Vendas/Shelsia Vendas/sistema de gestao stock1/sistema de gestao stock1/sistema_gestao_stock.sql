create database sistema_gestao_stock;
use sistema_gestao_stock;
Select * From TB_encomenda

Select top 1 Idencomenda, TB_produto.produto,TB_encomenda.categoria , data, TB_fornecedoR.Nome, TB_encomenda.unidade, p_compra, p_venda, q_existente, q_introduzir, q_atual 
From TB_produto, TB_encomenda, TB_fornecedor
Where TB_produto.Idproduto like TB_encomenda.produto
and TB_fornecedor.Idfornecedor like TB_encomenda.fornecedor
and TB_produto.produto like 'arroz'
Order by Idencomenda Desc

select Idproduto,TB_produto.categoria,quandide_atual,TB_produto.unidade,TB_encomenda.p_venda 
from TB_encomenda, TB_produto 
Where TB_produto.Idproduto like TB_encomenda.produto
and  TB_produto.Idproduto  like '1'
Order by Idencomenda Desc

Select * From TB_produto
select * from TB_unidade

delete from TB_encomenda where categoria like '1';

select * from TB_produto where quandide_atual >'80' and quandide_atual<'10'

create table TB_Sexo
(IdSexo int primary key,
Sexo varchar(15));
select * from TB_sexo
Select * from TB_Sexo Where sexo like 'Masculino'
insert into TB_Sexo 
values('','Masculino'),
('','Femenino');
select * from TB_encomenda
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

create view consulta_produto as
(
select Idproduto,produto,TB_unidade.unidade,quandide_atual,TB_categoria.categoia from TB_produto,TB_unidade,TB_categoria 
where (TB_categoria.Idcategoria=TB_produto.categoria) and(TB_unidade.id_unidade=TB_produto.unidade) 
)

create view consulta_fornecedor as
(
select Idfornecedor,nome,Apelido,TB_Sexo.Sexo,Contacto,Telefone_Alternativo,Email from TB_fornecedor,TB_sexo 
where ((TB_sexo.idsexo=TB_fornecedor.sexo)) 
)
drop view consulta_fornecedor 
select * FROM consulta_cliente 
create view consulta_cliente as
(
select Idcliente,Cracha,Nome,TB_Sexo.Sexo,Contacto1,Contacto,email from TB_cliente,TB_sexo 
where ((TB_sexo.idsexo=TB_cliente.sexo)) 
)

create view  consulta_funcionario as
(
select Idfuncionario,TipoDoc.descricaoDoc,Número_doc,nome,Apelido,
TB_sexo.sexo,contacto,telefone_Alternativo,email from TB_funcionario,TB_sexo,TipoDoc 
where (TB_sexo.idsexo=TB_funcionario.sexo)
and(TipoDoc.tipo_documento=TB_funcionario.tipo_doc) 
)
use  sistema_gestao_stock
create view  consulta_encomenda as
(
select TB_encomenda.Idencomenda,TB_produto.produto ,TB_encomenda.categoria,TB_encomenda.data,
TB_fornecedor.nome,TB_encomenda.unidade,TB_encomenda.p_compra,p_venda,TB_encomenda.q_existente,
 TB_encomenda.q_introduzir,TB_encomenda.q_atual from TB_encomenda,TB_produto,TB_fornecedor
where (TB_produto.idproduto=TB_encomenda.produto)and(TB_fornecedor.Idfornecedor=TB_encomenda.fornecedor) 
)


select * from TB_categoria where categoia  like''

--Delete From Funcionario

--Alter Table Funcionario Drop Column IdFuncionario
--Alter Table Funcionario Add IdFuncionario int
Update Funcionario Set IdFuncionario = 1 Where NumeroCaracha like 1122