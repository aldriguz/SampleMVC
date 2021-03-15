CREATE TABLE [dbo].[Properties] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Address]     NVARCHAR (MAX) NULL,
    [YearBuilt]   NVARCHAR (MAX) NULL,
    [ListPrice]   FLOAT (53)     NULL,
    [MonthlyRent] FLOAT (53)     NULL,
    [GrossYield]  FLOAT (53)     NULL,
    CONSTRAINT [PK_dbo.Properties] PRIMARY KEY CLUSTERED ([Id] ASC)
);