CREATE TABLE [dbo].[MachineByGroup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine] INT NULL, 
    [Group] INT NULL, 
    CONSTRAINT [FK_MachineByGroup_Machine] FOREIGN KEY ([Machine]) REFERENCES [Machine]([Id]), 
    CONSTRAINT [FK_MachineByGroup_ToGroup] FOREIGN KEY ([Group]) REFERENCES [Group]([Id])

)
