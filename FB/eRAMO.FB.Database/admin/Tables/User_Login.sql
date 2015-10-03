CREATE TABLE [admin].[User_Login] (
    [User_LoginID]  INT            IDENTITY (1, 1) NOT NULL,
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL,
    [UserId]        INT            NOT NULL,
    CONSTRAINT [PK_dbo.UserLogin] PRIMARY KEY CLUSTERED ([User_LoginID] ASC),
    CONSTRAINT [FK_dbo.UserLogin_dbo.User_UserId] FOREIGN KEY ([UserId]) REFERENCES [admin].[User] ([UserID]) ON DELETE CASCADE
);

