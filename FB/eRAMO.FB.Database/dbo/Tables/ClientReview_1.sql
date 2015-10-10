CREATE TABLE [dbo].[ClientReview] (
    [ClientReviewID] INT            IDENTITY (1, 1) NOT NULL,
    [Review]         NVARCHAR (500) NULL,
    [ClientName]     NVARCHAR (50)  NULL,
    [ClientTitle]    NVARCHAR (50)  NULL,
    [ClientPhoto]    NVARCHAR (50)  NULL,
    CONSTRAINT [PK_ClientReview] PRIMARY KEY CLUSTERED ([ClientReviewID] ASC)
);

