CREATE TABLE [dbo].[Question] (
    [QuestionID]            INT            IDENTITY (1, 1) NOT NULL,
    [QuestionInformationID] INT            NULL,
    [Text]                  NVARCHAR (500) NULL,
    [Justification]         NVARCHAR (MAX) NULL,
    [ExpectedDuration]      FLOAT (53)     NULL,
    [Weight]                INT            NULL,
    [Notes]                 NVARCHAR (MAX) NULL,
    [ParentID]              INT            NULL,
    [ParentTypeID]          INT            NULL,
    [QuestionPoolID]        INT            NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([QuestionID] ASC),
    CONSTRAINT [FK_Question_ParentType] FOREIGN KEY ([ParentTypeID]) REFERENCES [dbo].[ParentType] ([ParentTypeID]),
    CONSTRAINT [FK_Question_QuestionInforamtion] FOREIGN KEY ([QuestionInformationID]) REFERENCES [dbo].[QuestionInforamtion] ([QuestionInformationID]),
    CONSTRAINT [FK_Question_QuestionPool] FOREIGN KEY ([QuestionPoolID]) REFERENCES [dbo].[QuestionPool] ([QuestionPoolID])
);

