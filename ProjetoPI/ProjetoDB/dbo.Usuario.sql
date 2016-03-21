CREATE TABLE [dbo].[Table]
(
	[Id_func] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Usuario] VARCHAR(MAX) NOT NULL, 
    [Senha] VARCHAR(MAX) NOT NULL, 
    [Estado] CHAR NOT NULL DEFAULT 'A'
)
