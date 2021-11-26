CREATE TABLE [Season].[Team] (
    [TeamID]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (64) NOT NULL,
    [Abreviation] NVARCHAR (4)  NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamID] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC, [Abreviation] ASC)
);

