USE [mundoPlay]
GO

INSERT INTO [dbo].[series]
           ([titulo]
           ,[elenco]
           ,[sinopse]
           ,[canal]
           ,[temporadas]
           ,[duracao]
           ,[poster]
           ,[trailer]
           ,[validar])
     VALUES
           (<teste25,>
           ,<elenco, text,>
           ,<sinopse, text,>
           ,<canal, int,>
           ,<temporadas, int,>
           ,<duracao, int,>
           ,<poster, varchar(45),>
           ,<trailer, varchar(45),>
           ,<validar, varchar(3),>)
GO


