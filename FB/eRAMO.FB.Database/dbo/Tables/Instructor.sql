CREATE TABLE [dbo].[Instructor] (
    [InstructorsID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (150) NULL,
    [Position]      NVARCHAR (150) NULL,
    [PhotoUrl]      NVARCHAR (MAX) NULL,
    [Summary]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED ([InstructorsID] ASC)
);

