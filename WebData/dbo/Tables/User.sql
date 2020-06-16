CREATE TABLE [dbo].[User]
(
    [Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [Etunimi] NVARCHAR(50) NOT NULL, 
    [Sukunimi] NVARCHAR(50) NOT NULL, 
    [EmailOsoite] NVARCHAR(256) NOT NULL, 
    [Luontipvm] DATETIME2 NOT NULL DEFAULT getutcdate()
)
