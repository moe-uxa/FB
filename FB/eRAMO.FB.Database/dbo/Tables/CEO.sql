CREATE TABLE [dbo].[CEO] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50)  NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Description] NVARCHAR (500) NULL,
    [imge]        NVARCHAR (50)  NULL,
    CONSTRAINT [PK_CEO] PRIMARY KEY CLUSTERED ([ID] ASC)
);

