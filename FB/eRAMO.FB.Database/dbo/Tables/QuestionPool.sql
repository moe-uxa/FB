CREATE TABLE [dbo].[QuestionPool] (
    [QuestionPoolID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (100) NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [Notes]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_QuestionPool] PRIMARY KEY CLUSTERED ([QuestionPoolID] ASC)
);

