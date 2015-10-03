CREATE TABLE [idt].[User_UserRole] (
    [UserID]     INT NOT NULL,
    [UserRoleID] INT NOT NULL,
    CONSTRAINT [PK_idt.User_UserRole] PRIMARY KEY CLUSTERED ([UserID] ASC, [UserRoleID] ASC),
    CONSTRAINT [FK_idt.User_UserRole_idt.User_UserID] FOREIGN KEY ([UserID]) REFERENCES [idt].[User] ([UserID]) ON DELETE CASCADE,
    CONSTRAINT [FK_idt.User_UserRole_idt.UserRole_UserRoleID] FOREIGN KEY ([UserRoleID]) REFERENCES [idt].[UserRole] ([UserRoleID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_UserRoleID]
    ON [idt].[User_UserRole]([UserRoleID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserID]
    ON [idt].[User_UserRole]([UserID] ASC);

