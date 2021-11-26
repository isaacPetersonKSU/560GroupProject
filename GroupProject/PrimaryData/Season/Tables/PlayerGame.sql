CREATE TABLE [Season].[PlayerGame] (
    [PlayerGameID]        INT IDENTITY (1, 1) NOT NULL,
    [GameID]              INT NOT NULL,
    [PlayerID]            INT NOT NULL,
    [TeamID]              INT NOT NULL,
    [InterceptionsThrown] INT NOT NULL,
    [Fumbles]             INT NOT NULL,
    [RushingTouchdowns]   INT NOT NULL,
    [PassingTouchdowns]   INT NOT NULL,
    [ReceivingTouchdowns] INT NOT NULL,
    [RushAttempts]        INT NOT NULL,
    [Receptions]          INT NOT NULL,
    [RushingYards]        INT NOT NULL,
    [PassingYards]        INT NOT NULL,
    [ReceivingYards]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PlayerGameID] ASC),
    FOREIGN KEY ([GameID], [TeamID]) REFERENCES [Season].[TeamGame] ([GameID], [TeamID]),
    FOREIGN KEY ([PlayerID], [TeamID]) REFERENCES [Season].[Player] ([PlayerID], [TeamID])
);

