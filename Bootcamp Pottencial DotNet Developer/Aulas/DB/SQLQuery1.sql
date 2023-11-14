







CREATE TABLE [dbo].[Produtos] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nome] NVARCHAR(MAX),
    [Categoria] NVARCHAR(MAX),
    [Preco] FLOAT (53),
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);




















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