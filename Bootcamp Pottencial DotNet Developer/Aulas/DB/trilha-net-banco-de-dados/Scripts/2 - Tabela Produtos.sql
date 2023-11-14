SELECT * FROM Clientes


CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int	NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,


	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)

)

SELECT * FROM Enderecos

INSERT INTO Enderecos VALUES(4, 'Reua Teste', 'Bairro Teste', 'Cidade Teste', 'MG')


SELECT

	Clientes.Nome,
	Clientes.Sobrenome,
	Clientes.Email,
	Enderecos.Rua,
	Enderecos.Bairro,
	Enderecos.Cidade,
	Enderecos.Estado

FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4

















--SELECT 
--	Tamanho,
--	COUNT(*) Quantidade
--FROM Produtos
--WHERE Tamanho <> ''
--GROUP BY Tamanho
--ORDER BY Quantidade DESC
----MANTER NESSA ORDEM











--ALTER TABLE Produtos
--ADD DataCadastro DATETIME2


----ADICIONA COLUNA
--UPDATE Produtos SET DataCadastro = GETDATE()

----FORMATANDO DATA
--SELECT
--	Nome,
--	Cor,
--	FORMAT(DataCadastro, 'dd-MM-yyyy') DATA
--FROM Produtos






--REMOVE COLUNA
--ALTER TABLE Produtos
--DROP COLUMN DataCadastro 



--SELECT
--	Nome + ' => ' + Cor NomeProduto,
--	UPPER(Nome) Nome,
--	LOWER(Cor)	Cor
--FROM Produtos






--SELECT
--	Nome + ' => ' + Cor NomeProduto
--FROM Produtos






--select count(*) QuantidadeProdutos from Produtos
--SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'
--SELECT COUNT(*) QuantidadeProdutosTamanhoF FROM Produtos WHERE Tamanho = 'F'

--SELECT SUM(Preco) PrecoTotal FROM Produtos 
--SELECT SUM(Preco) PrecoTotalTamanhoM FROM Produtos WHERE Tamanho = 'M'

--SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos
--SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos WHERE Tamanho = 'M'

--SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos
--SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos WHERE Tamanho = 'M'

--SELECT AVG(Preco) MediaProduto FROM Produtos
--SELECT AVG(Preco) MediaProdutoTamanhoM FROM Produtos WHERE Tamanho = 'M'