CREATE TABLE [admin].[User_UserRole] (
    [User_UserRoleID] INT IDENTITY (1, 1) NOT NULL,
    [UserID]          INT NOT NULL,
    [UserRoleID]      INT NOT NULL,
    CONSTRAINT [PK_User_SystemRole] PRIMARY KEY CLUSTERED ([User_UserRoleID] ASC),
    CONSTRAINT [FK_dbo.UserRole_dbo.IdentityRole_RoleId] FOREIGN KEY ([UserRoleID]) REFERENCES [admin].[UserRole] ([UserRoleID]) ON DELETE CASCADE,
    CONSTRAINT [FK_User_UserRole_User] FOREIGN KEY ([UserID]) REFERENCES [admin].[User] ([UserID])
);

