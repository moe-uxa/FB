CREATE TABLE [dbo].[ParentType] (
    [ParentTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NULL,
    CONSTRAINT [PK_ParentType] PRIMARY KEY CLUSTERED ([ParentTypeID] ASC)
);

