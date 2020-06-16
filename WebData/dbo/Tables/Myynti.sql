CREATE TABLE [dbo].[Myynti]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [KasittelijaId] NVARCHAR(128) NOT NULL, 
    [Myyntipaiva] DATETIME2 NOT NULL, 
    [Valisumma] MONEY NOT NULL, 
    [Vero] MONEY NOT NULL, 
    [Yhteensa] MONEY NOT NULL
)
