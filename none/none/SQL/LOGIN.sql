CREATE DATABASE [LOGIN]
GO

USE [LOGIN]
GO

CREATE TABLE [ROLE] (
	
		[ID]			NCHAR(1)		NOT NULL,
		[TITLE]			NVARCHAR(30)	NOT NULL,
		CONSTRAINT	PK_ROLE_ID	PRIMARY KEY ([ID])
)
GO

--������ ������ � ������� ROLE 
INSERT [ROLE]([ID], [TITLE]) VALUES ('A', 'admin')
INSERT [ROLE]([ID], [TITLE]) VALUES ('U', 'user')


CREATE TABLE [USER] (
	
		[ID]			INT IDENTITY (0,1),
		[USERNAME]		NVARCHAR(30)	NOT NULL,
		[PASSWORD]		NVARCHAR(30)	NOT NULL,
		[IDROLE]		NCHAR(1)	CONSTRAINT FK_USER_IDROLE_ROLE_ID FOREIGN KEY REFERENCES [ROLE] ([ID]),
		CONSTRAINT	PK_USER_ID	PRIMARY KEY ([ID])
)
GO

--������ ������ � ������� USER 
INSERT INTO [USER]([USERNAME], [PASSWORD], [IDROLE]) VALUES ('none', '1234', 'U')
INSERT INTO [USER]([USERNAME], [PASSWORD], [IDROLE]) VALUES ('nonna', '1234', 'A')

SELECT * FROM [USER]