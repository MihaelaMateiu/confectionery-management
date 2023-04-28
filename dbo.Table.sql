CREATE TABLE [dbo].[comanda]
(
	[Id] INT identity(1, 1) PRIMARY KEY,
	[id_prod] int,
	[date] date default getdate(),
	[state] varchar(10) default 'processing', 
    CONSTRAINT [id_prod] FOREIGN KEY ([id_prod]) REFERENCES [produs]([Id])
)
