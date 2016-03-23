/*Criação da Tabela de Usuario*/
CREATE TABLE [dbo].[Table]
(
	[Id_func] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Usuario] VARCHAR(MAX) NOT NULL, 
    [Senha] VARCHAR(MAX) NOT NULL, 
    [Estado] CHAR NOT NULL DEFAULT 'A'
)

/* INsersão dos admins do programa*/
INSERT INTO Usuario(Username,Senha,Permissao) values('stan','gdyb21LQTcIANtvYMT7QVQ==',1)
INSERT INTO Usuario(Username,Senha,Permissao) values('marcio','gdyb21LQTcIANtvYMT7QVQ==',1)
INSERT INTO Usuario(Username,Senha,Permissao) values('vitor','gdyb21LQTcIANtvYMT7QVQ==',1)
INSERT INTO Usuario(Username,Senha,Permissao) values('tales','gdyb21LQTcIANtvYMT7QVQ==',1)
INSERT INTO Usuario(Username,Senha,Permissao) values('adriano','gdyb21LQTcIANtvYMT7QVQ==',1)
