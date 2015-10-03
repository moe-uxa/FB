CREATE TABLE [idt].[UserRole] (
    [UserRoleID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_idt.UserRole] PRIMARY KEY CLUSTERED ([UserRoleID] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [idt].[UserRole]([Name] ASC);

