CREATE TABLE [dbo].[Customers] (
    [CustomerID]   INT            IDENTITY (1, 1) NULL,
    [FirstName]    NVARCHAR (20)  NULL,
    [LastName]     NVARCHAR (MAX) NULL,
    [EmailAddress] NVARCHAR (MAX) NULL,
    [TelephoneNo]  NVARCHAR (MAX) NULL,
    [AddressID]    INT            NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED ([CustomerID] ASC),
    CONSTRAINT [FK_dbo.Customers_dbo.Addresses_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID])
);


GO
CREATE NONCLUSTERED INDEX [IX_AddressID]
    ON [dbo].[Customers]([AddressID] ASC);

