CREATE TABLE [dbo].[Pantanir]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VvNafn] NVARCHAR(MAX) NOT NULL, 
    [VvKt] NVARCHAR(MAX) NOT NULL, 
    [AfhDags] DATE NULL, 
    [Afhendingarmati] NVARCHAR(50) NULL
)
