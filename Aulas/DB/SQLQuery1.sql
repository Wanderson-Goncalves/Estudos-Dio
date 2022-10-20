SELECT 
	Nome,
	Preco,
	dbo.CalcularDesconto(Preco, 60) PrecoComDesconto
From Produtos WHERE TAmanho = 'M'



CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13, 2), @Porcentagem INT)
RETURNS DECIMAL(13, 2)

BEGIN
	RETURN	@Preco - @Preco / 100 * @Porcentagem
END



































--SELECT * FROM Produtos
--ALTER TABLE Produtos
--ADD CONSTRAINT CHK_ColunaGenero CHECK ( Genero ='U' OR Genero = 'M' OR Genero = 'F')

--ALTER TABLE	Produtos
--ADD DEFAULT GETDATE()FOR	DataCadastro




--CREATE PROCEDURE InserirNovoProduto
--@Nome varchar(255),
--@Cor varchar(50),
--@Preco decimal,
--@Tamanho varchar(5),
--@Genero char(1)

--As

--INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
--VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)



--EXEC InserirNovoProduto
--	'Novo Produto Procedure',
--	'Colorido',
--	50,
--	'GG',
--	'U'