CREATE TABLE [Season].[Game] (
    [GameID]   INT           IDENTITY (1, 1) NOT NULL,
    [Location] NVARCHAR (64) NOT NULL,
    [Date]     DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([GameID] ASC)
);

