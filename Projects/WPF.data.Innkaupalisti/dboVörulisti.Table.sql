CREATE TABLE [dbo].[Vörulisti]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Vöruheiti] NVARCHAR(MAX) NOT NULL, 
    [Fjöldi] INT NOT NULL, 
    [Verð] INT NOT NULL, 
    [Samtals] INT NOT NULL
)
