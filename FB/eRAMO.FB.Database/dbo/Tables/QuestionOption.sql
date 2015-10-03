CREATE TABLE [dbo].[QuestionOption] (
    [QuestionOptionID] INT            IDENTITY (1, 1) NOT NULL,
    [QuestionID]       INT            NULL,
    [Text]             NVARCHAR (100) NULL,
    [Notes]            NVARCHAR (MAX) NULL,
    [IsAnswer]         BIT            NULL,
    CONSTRAINT [PK_QuestionOption] PRIMARY KEY CLUSTERED ([QuestionOptionID] ASC),
    CONSTRAINT [FK_QuestionOption_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([QuestionID])
);

