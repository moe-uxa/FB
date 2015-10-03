CREATE TABLE [idt].[User_Claim] (
    [User_ClaimID] INT            IDENTITY (1, 1) NOT NULL,
    [UserID]       INT            NOT NULL,
    [ClaimType]    NVARCHAR (MAX) NULL,
    [ClaimValue]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_idt.User_Claim] PRIMARY KEY CLUSTERED ([User_ClaimID] ASC),
    CONSTRAINT [FK_idt.User_Claim_idt.User_UserID] FOREIGN KEY ([UserID]) REFERENCES [idt].[User] ([UserID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_UserID]
    ON [idt].[User_Claim]([UserID] ASC);

