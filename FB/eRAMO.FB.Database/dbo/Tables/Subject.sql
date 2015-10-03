CREATE TABLE [dbo].[Subject] (
    [SubjectID]   INT            IDENTITY (1, 1) NOT NULL,
    [LevelID]     INT            NULL,
    [Name]        NVARCHAR (100) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Notes]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED ([SubjectID] ASC),
    CONSTRAINT [FK_Subject_Level] FOREIGN KEY ([LevelID]) REFERENCES [dbo].[Level] ([LevelID])
);

