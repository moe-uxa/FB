CREATE TABLE [dbo].[Partner] (
    [PartnerID] INT            IDENTITY (1, 1) NOT NULL,
    [Imge]      NVARCHAR (50)  NULL,
    [Text]      NVARCHAR (200) NULL,
    CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED ([PartnerID] ASC)
);

