CREATE TABLE [dbo].[PontunarLinur]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Voruheiti] NVARCHAR(50) NOT NULL, 
    [Verd] FLOAT NOT NULL, 
    [Fjoldi] FLOAT NOT NULL, 
    [PontunId] INT NOT NULL,
	FOREIGN KEY ([PontunId]) REFERENCES Pantanir(Id)
)
