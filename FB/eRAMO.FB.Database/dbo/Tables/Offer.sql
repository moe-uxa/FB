CREATE TABLE [dbo].[Offer] (
    [OffersID] INT            IDENTITY (1, 1) NOT NULL,
    [Detail]   NVARCHAR (500) NULL,
    [image]    NVARCHAR (50)  NULL,
    [IsActive] BIT            NULL,
    [Date]     DATETIME       NULL,
    [Title]    NCHAR (10)     NULL,
    CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED ([OffersID] ASC)
);

