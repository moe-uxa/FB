CREATE TABLE [dbo].[Certificate_Instructor] (
    [CertificateID] INT NOT NULL,
    [InstructorsID] INT NOT NULL,
    CONSTRAINT [PK_Certificate_Instructor] PRIMARY KEY CLUSTERED ([CertificateID] ASC, [InstructorsID] ASC),
    CONSTRAINT [FK_Certificate_Instructor_Certificate] FOREIGN KEY ([CertificateID]) REFERENCES [dbo].[Certificate] ([CertificateID]),
    CONSTRAINT [FK_Certificate_Instructor_Instructor] FOREIGN KEY ([InstructorsID]) REFERENCES [dbo].[Instructor] ([InstructorsID])
);

