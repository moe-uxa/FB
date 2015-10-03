CREATE TABLE [dbo].[Reading] (
    [ReadingID]      INT            IDENTITY (1, 1) NOT NULL,
    [StudySessionID] INT            NULL,
    [Name]           NVARCHAR (100) NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [Notes]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Reading] PRIMARY KEY CLUSTERED ([ReadingID] ASC),
    CONSTRAINT [FK_Reading_StudySession] FOREIGN KEY ([StudySessionID]) REFERENCES [dbo].[StudySession] ([StudySessionID])
);

