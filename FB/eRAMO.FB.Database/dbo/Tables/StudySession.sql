CREATE TABLE [dbo].[StudySession] (
    [StudySessionID] INT            IDENTITY (1, 1) NOT NULL,
    [SubjectID]      INT            NULL,
    [Name]           NVARCHAR (100) NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [Notes]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_StudySession] PRIMARY KEY CLUSTERED ([StudySessionID] ASC),
    CONSTRAINT [FK_StudySession_Subject] FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[Subject] ([SubjectID])
);

