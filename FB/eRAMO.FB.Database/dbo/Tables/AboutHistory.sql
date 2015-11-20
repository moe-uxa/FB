CREATE TABLE [dbo].[AboutHistory] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50)  NULL,
    [Description] NVARCHAR (500) NULL,
    [Image]       NVARCHAR (50)  NULL,
    [Date]        DATE           NULL,
    CONSTRAINT [PK_AboutHistory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

