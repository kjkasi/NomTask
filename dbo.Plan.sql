CREATE TABLE [dbo].[Plan]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Article] INT NULL, 
    [Day] INT NULL, 
    [Count] INT NULL, 
    CONSTRAINT [FK_Plan_ToArticle] FOREIGN KEY ([Article]) REFERENCES [Article]([Id])
)
