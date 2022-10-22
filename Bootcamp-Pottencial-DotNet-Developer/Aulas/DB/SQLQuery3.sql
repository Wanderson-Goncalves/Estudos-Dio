/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Nome]
      ,[Telefone]
      ,[Ativo]
  FROM [Agenda].[dbo].[Contatos]


  UPDATE Contatos
  SET Telefone = '111111111'
  WHERE Id = 2;