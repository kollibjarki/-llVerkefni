CREATE TABLE [dbo].[Stadir]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nafn] NVARCHAR(MAX) NOT NULL, 
    [Tegund] NVARCHAR(MAX) NOT NULL, 
    [WMO-Númer] INT NOT NULL, 
    [Skammsstöfun] NVARCHAR(50) NOT NULL, 
    [Spásvæði] INT NOT NULL, 
    [Staðsetning] FLOAT NOT NULL, 
    [Hæð yfir sjó] NVARCHAR(50) NOT NULL, 
    [Upphaf veðurathuguna] INT NOT NULL, 
    [Eigandi stöðvar] NVARCHAR(MAX) NOT NULL, 
    [Stöðvanúmer] INT NOT NULL,
	FOREIGN KEY([Spásvæði]) REFERENCES Landshlutar(Id)
)
