CREATE TABLE [idt].[User] (
    [UserID]               INT            IDENTITY (1, 1) NOT NULL,
    [CountryID]            INT            NULL,
    [FirstName]            NVARCHAR (MAX) NULL,
    [LastName]             NVARCHAR (MAX) NULL,
    [MobileNumber]         NVARCHAR (MAX) NULL,
    [UniqueName]           NVARCHAR (MAX) NULL,
    [Email]                NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [SecurityStamp]        NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (MAX) NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [LockoutEndDateUtc]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [IsMobileVerified]     BIT            CONSTRAINT [DF_User_IsMobileVerified] DEFAULT ((0)) NOT NULL,
    [UserImageURL]         NVARCHAR (250) NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

