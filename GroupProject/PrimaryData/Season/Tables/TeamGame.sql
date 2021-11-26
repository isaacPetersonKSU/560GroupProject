CREATE TABLE [Season].[TeamGame] (
    [TeamGameID] INT     IDENTITY (1, 1) NOT NULL,
    [TeamID]     INT     NOT NULL,
    [GameID]     INT     NOT NULL,
    [TeamTypeID] TINYINT NOT NULL,
    [Score]      INT     NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamGameID] ASC),
    FOREIGN KEY ([GameID]) REFERENCES [Season].[Game] ([GameID]),
    FOREIGN KEY ([TeamID]) REFERENCES [Season].[Team] ([TeamID]),
    FOREIGN KEY ([TeamTypeID]) REFERENCES [Season].[TeamType] ([TeamTypeID]),
    UNIQUE NONCLUSTERED ([GameID] ASC, [TeamID] ASC),
    UNIQUE NONCLUSTERED ([GameID] ASC, [TeamTypeID] ASC)
);

