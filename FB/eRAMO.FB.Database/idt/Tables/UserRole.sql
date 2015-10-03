CREATE TABLE [idt].[UserRole] (
    [UserRoleID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_dbo.IdentityRole] PRIMARY KEY CLUSTERED ([UserRoleID] ASC)
);

