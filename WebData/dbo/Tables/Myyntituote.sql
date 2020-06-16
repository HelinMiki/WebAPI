CREATE TABLE [dbo].[Myyntituote]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Tuotenimi] NVARCHAR(50) NOT NULL, 
    [Kuvaus] NVARCHAR(MAX) NOT NULL, 
    [Ohjehinta] MONEY NOT NULL, 
    [Lisayspvm] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ViimeksiMuokattu] DATETIME2 NOT NULL DEFAULT getutcdate()
)
