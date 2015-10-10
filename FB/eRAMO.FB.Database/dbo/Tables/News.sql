CREATE TABLE [dbo].[News] (
    [NewsID]      INT            IDENTITY (1, 1) NOT NULL,
    [Text]        NVARCHAR (500) NULL,
    [BannarPhoto] NVARCHAR (50)  NULL,
    [Icon]        NVARCHAR (50)  NULL,
    [Title]       NVARCHAR (50)  NULL,
    [date]        DATETIME       NULL,
    CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED ([NewsID] ASC)
);

