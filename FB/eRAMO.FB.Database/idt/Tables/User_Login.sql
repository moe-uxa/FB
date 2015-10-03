CREATE TABLE [idt].[User_Login] (
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL,
    [UserID]        INT            NOT NULL,
    CONSTRAINT [PK_idt.User_Login] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC, [UserID] ASC),
    CONSTRAINT [FK_idt.User_Login_idt.User_UserID] FOREIGN KEY ([UserID]) REFERENCES [idt].[User] ([UserID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_UserID]
    ON [idt].[User_Login]([UserID] ASC);

