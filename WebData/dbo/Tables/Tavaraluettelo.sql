CREATE TABLE [dbo].[Tavaraluettelo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TuoteId] INT NOT NULL, 
    [Maara] INT NOT NULL DEFAULT 1, 
    [Ostohinta] MONEY NOT NULL, 
    [Ostopäivä] DATETIME2 NOT NULL DEFAULT getutcdate()
)
