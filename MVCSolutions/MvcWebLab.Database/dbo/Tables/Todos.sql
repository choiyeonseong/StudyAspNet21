CREATE TABLE [dbo].[Todos]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY, 
    [Title] NVARCHAR(150) NOT NULL, 
    [IsDone] BIT NULL, 
    [CreationDate] DATETIME NULL DEFAULT (GetDate()),

)
