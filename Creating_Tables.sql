CREATE TABLE [users]
(
	[Id] int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(MAX) NOT NULL,
	[Login] NVARCHAR(MAX) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	[RegistrationDate] DateTime NOT NULL
)

CREATE TABLE [games]
(
	[Id] int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[PlayingDate] DateTime,
	[UserId] int,
	[Score] int NOT NULL DEFAULT 0
	
)

ALTER TABLE [dbo].[games]  WITH CHECK ADD  CONSTRAINT [FK_Games_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO