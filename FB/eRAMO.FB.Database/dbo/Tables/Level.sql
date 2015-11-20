CREATE TABLE [dbo].[Level] (
    [LevelID]       INT            IDENTITY (1, 1) NOT NULL,
    [CertificateID] INT            NULL,
    [Name]          NVARCHAR (100) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Notes]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED ([LevelID] ASC),
    CONSTRAINT [FK_Level_Certificate] FOREIGN KEY ([CertificateID]) REFERENCES [dbo].[Certificate] ([CertificateID])
);



