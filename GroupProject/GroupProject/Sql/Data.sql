--Staging table for games
DECLARE @GameStagingTable TABLE
(
	[Date] DATE NOT NULL,
	WinnerName NVARCHAR(64) NOT NULL,
	LoserName NVARCHAR(64) NOT NULL,
	WinnerAway NVARCHAR(2) NOT NULL,
	WinnerScore INT NOT NULL,
	LoserScore INT NOT NULL
);

INSERT @GameStagingTable
VALUES
	

--TeamType Table
INSERT Season.TeamType(TeamTypeID, [Name])
VALUES 
	(1, 'Home'),
	(2, 'Away');

