CREATE TABLE [dbo].[Myyntitiedot]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [MyyntiId] INT NOT NULL, 
    [TuoteId] INT NOT NULL, 
    [Maara] INT NOT NULL DEFAULT 1,
    [Ostohinta] MONEY NOT NULL, 
    [Vero] MONEY NOT NULL DEFAULT 0   
)
