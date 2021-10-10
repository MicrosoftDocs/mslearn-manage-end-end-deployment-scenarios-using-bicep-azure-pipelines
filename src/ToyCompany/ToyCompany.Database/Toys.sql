CREATE TABLE [dbo].[Toys]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(1000) NOT NULL, 
    [Description] NVARCHAR(1000) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [ImageId] NVARCHAR(30) NOT NULL
)
