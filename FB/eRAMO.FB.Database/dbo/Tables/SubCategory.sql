CREATE TABLE [dbo].[SubCategory] (
    [SubCategoryID] INT            IDENTITY (1, 1) NOT NULL,
    [ReadingID]     INT            NULL,
    [Name]          NVARCHAR (100) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Notes]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED ([SubCategoryID] ASC),
    CONSTRAINT [FK_SubCategory_Reading] FOREIGN KEY ([ReadingID]) REFERENCES [dbo].[Reading] ([ReadingID])
);

