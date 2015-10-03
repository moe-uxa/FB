CREATE TABLE [admin].[User_Claim] (
    [User_ClaimID] INT            IDENTITY (1, 1) NOT NULL,
    [UserID]       INT            NOT NULL,
    [ClaimType]    NVARCHAR (MAX) NULL,
    [ClaimValue]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.UserClaim] PRIMARY KEY CLUSTERED ([User_ClaimID] ASC),
    CONSTRAINT [FK_User_Claim_User] FOREIGN KEY ([UserID]) REFERENCES [admin].[User] ([UserID])
);

