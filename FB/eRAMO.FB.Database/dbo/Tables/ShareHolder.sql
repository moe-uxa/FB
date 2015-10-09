CREATE TABLE [dbo].[ShareHolder] (
    [ShareHolderID] INT             IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)   NULL,
    [Title]         NVARCHAR (50)   NULL,
    [Summary]       NVARCHAR (4000) NULL,
    [PhotoUrl]      NVARCHAR (4000) NULL,
    [FacebookUrl]   NVARCHAR (4000) NULL,
    [TwitterUrl]    NVARCHAR (4000) NULL,
    [GooglePlusUrl] NVARCHAR (4000) NULL,
    [LinkedInUrl]   NVARCHAR (4000) NULL,
    [IsCEO]         BIT             NULL,
    [Rank]          INT             NULL,
    CONSTRAINT [PK_ShareHolder] PRIMARY KEY CLUSTERED ([ShareHolderID] ASC)
);

