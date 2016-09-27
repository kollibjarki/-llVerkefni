CREATE TABLE [dbo].[Pantanir]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VvNafn] NVARCHAR(MAX) NOT NULL, 
    [VvKT] NVARCHAR(50) NOT NULL, 
    [Afhending.dags] DATE NOT NULL, 
    [Afhendingarmáti] NVARCHAR(MAX) NOT NULL
)
