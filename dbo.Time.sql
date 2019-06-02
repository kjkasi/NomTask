CREATE TABLE [dbo].[Time]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Article] INT NULL, 
    [Group] INT NULL, 
    [ProcessTime] FLOAT NULL, 
    [ProduceTime] FLOAT NULL, 
    CONSTRAINT [FK_Time_ToArticle] FOREIGN KEY ([Article]) REFERENCES [Article]([Id]), 
    CONSTRAINT [FK_Time_ToGroup] FOREIGN KEY ([Group]) REFERENCES [Group]([id])
	
)
