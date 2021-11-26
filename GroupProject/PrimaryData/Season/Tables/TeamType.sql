CREATE TABLE [Season].[TeamType] (
    [TeamTypeID] TINYINT      NOT NULL,
    [Name]       NVARCHAR (8) NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamTypeID] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

