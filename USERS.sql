CREATE TABLE [dbo].[Table]
(
	[Id] INT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [Fullname] NVARCHAR(50) NULL, 
    [Picture] NVARCHAR(500) NULL
)
