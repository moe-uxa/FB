CREATE TABLE [dbo].[QuestionInforamtion] (
    [QuestionInformationID] INT            IDENTITY (1, 1) NOT NULL,
    [CertificateID]         INT            NULL,
    [Text]                  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_QuestionInforamtion] PRIMARY KEY CLUSTERED ([QuestionInformationID] ASC),
    CONSTRAINT [FK_QuestionInforamtion_Certificate] FOREIGN KEY ([CertificateID]) REFERENCES [dbo].[Certificate] ([CertificateID])
);



