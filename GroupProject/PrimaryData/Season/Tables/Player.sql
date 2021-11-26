CREATE TABLE [Season].[Player] (
    [PlayerID] INT           IDENTITY (1, 1) NOT NULL,
    [TeamID]   INT           NOT NULL,
    [Name]     NVARCHAR (64) NOT NULL,
    [Position] NVARCHAR (64) NOT NULL,
    [Number]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([PlayerID] ASC),
    FOREIGN KEY ([TeamID]) REFERENCES [Season].[Team] ([TeamID]),
    UNIQUE NONCLUSTERED ([PlayerID] ASC, [TeamID] ASC)
);

