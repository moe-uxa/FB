CREATE TABLE [dbo].[Certificate] (
    [CertificateID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (100) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Notes]         NVARCHAR (MAX) NULL,
    [IsActive]      BIT            NULL,
    [IsFeatured]    BIT            NULL,
    CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED ([CertificateID] ASC)
);

