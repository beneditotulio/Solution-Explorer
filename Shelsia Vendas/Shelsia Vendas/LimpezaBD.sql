use sistema_gestao_stock;
---------------------------------------
select * from TB_encomenda;
select * from TB_produto;
select * from TB_fornecedor;
select * from TB_produto;
---------------------------------------
--Limpando Tabela Categoria--
select * from TB_categoria;
Delete from TB_categoria
where Idcategoria >= 1;
----------------------------------------
--Limpando Tabela Unidade--
select * from TB_unidade;
Delete from TB_unidade
where Id_unidade >= 1;
------------------------------------------
--Limpando Tabela Productos--
select * from TB_produto;
Delete from TB_produto
where Idproduto >= 1;
-------------------------------------------
--Limpeza Tabela Encomenda--
select * from TB_encomenda;
Delete from TB_encomenda
where Idencomenda >= 1;
--------------------------------------------
--Limpeza na Tabela Fornecedor--
select * from TB_fornecedor;
Delete from TB_fornecedor
where Idfornecedor >= 1;
--Nao foi possivel operar o comando Delete porque alguns dados estao ligados a Tabela_Encomenda
----------------------------------------------
--Limpeza na Tabela Cliente--
select * from TB_cliente;
Delete from TB_cliente
where idcliente = 3

-----------------------------------------------
select * from TB_Funcionario;
--Comando Delete na Tabela Funcionario--
Delete from TB_Funcionario
where Tipo_Doc = 1

Delete from TB_Funcionario
where Tipo_Doc = 4

Delete from TB_Funcionario
where Tipo_Doc = 3
--------------------------------------------------
select * from TipoDoc;
--Inserindo dados na Tabela TipoDoc
Insert into TipoDoc
Values ('1','BILHETE DE IDENTIDADE'),
       ('2','PASSAPORTE'),
	   ('3','NUIT'),
	   ('4','CARTA DE CONDUÇÃO'); 
--Comando Delete na Tabela Tipo Documento--
Delete from TipoDoc
where Tipo_Documento >= 2