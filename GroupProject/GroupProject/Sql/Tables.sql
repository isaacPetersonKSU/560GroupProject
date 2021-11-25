USE PrimaryData;

IF OBJECT_ID(N'Season.Team') IS NULL
BEGIN
   CREATE TABLE Season.Team
   (
      TeamID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
      [Name] NVARCHAR(64) NOT NULL,
	  Abbreviation NVARCHAR(4) NOT NULL

      UNIQUE([Name], Abbreviation)
   );
END;

IF OBJECT_ID(N'Season.Player') IS NULL
BEGIN
   CREATE TABLE Season.Player
   (
      PlayerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  TeamID INT NOT NULL FOREIGN KEY
		REFERENCES Season.Team(TeamID),
      [Name] NVARCHAR(64) NOT NULL,
	  Position NVARCHAR(8) NOT NULL

      UNIQUE(PlayerID, TeamID)
   );
END;

IF OBJECT_ID(N'Season.TeamType') IS NULL
BEGIN
   CREATE TABLE Season.TeamType
   (
      TeamTypeID TINYINT NOT NULL PRIMARY KEY,
	  [Name] NVARCHAR(8) NOT NULL,

      UNIQUE([Name])
   );
END;

IF OBJECT_ID(N'Season.Game') IS NULL
BEGIN
   CREATE TABLE Season.Game
   (
      GameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  SourceGameID INT NOT NULL,
	  [Date] DATE NOT NULL
   );
END;

IF OBJECT_ID(N'Season.TeamGame') IS NULL
BEGIN
   CREATE TABLE Season.TeamGame
   (
		TeamGameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		TeamID INT NOT NULL FOREIGN KEY 
			REFERENCES Season.Team(TeamID),
		GameID INT NOT NULL FOREIGN KEY
			REFERENCES Season.Game(GameID),
		TeamTypeID TINYINT NOT NULL FOREIGN KEY
			REFERENCES Season.TeamType(TeamTypeID),
		Score INT NOT NULL
		
		UNIQUE(GameID, TeamTypeID),
		UNIQUE(GameID, TeamID)
   );
END;

IF OBJECT_ID(N'Season.PlayerGame') IS NULL
BEGIN
   CREATE TABLE Season.PlayerGame
   (
		PlayerGameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		GameID INT NOT NULL,
		PlayerID INT NOT NULL,
		TeamID INT NOT NULL,
		FOREIGN KEY
		(
         GameID,
         TeamID
		)
		REFERENCES Season.TeamGame
		(
         GameID,
         TeamID
		 ),
		 FOREIGN KEY
		(
         PlayerID,
		 TeamID
		)
		REFERENCES Season.Player
		(
         PlayerID,
		 TeamID
		 ),
		PassingYards INT NOT NULL,
		PassingTouchdowns INT NOT NULL,
		InterceptionsThrown INT NOT NULL,
		RushAttempts INT NOT NULL,
		RushingYards INT NOT NULL,
		RushingTouchdowns INT NOT NULL,
		Receptions INT NOT NULL,
		ReceivingYards INT NOT NULL,
		ReceivingTouchdowns INT NOT NULL,
		Fumbles INT NOT NULL,
   );
END;

IF OBJECT_ID(N'Season.GamesStaging') IS NULL
BEGIN
CREATE TABLE Season.GamesStaging
(
	[Date] DATE NOT NULL,
	WinnerName NVARCHAR(64) NOT NULL,
	LoserName NVARCHAR(64) NOT NULL,
	WinnerAway NVARCHAR(2) NOT NULL,
	WinnerScore INT NOT NULL,
	LoserScore INT NOT NULL,
	WinnerAbrv NVARCHAR(8) NOT NULL,
	LoserAbrv NVARCHAR(8) NOT NULL,
	SourceGameID INT NOT NULL
);
END;

IF OBJECT_ID(N'Season.PlayerStatsStaging') IS NULL
BEGIN
CREATE TABLE Season.PlayerStatsStaging
(
	Position NVARCHAR(8) NOT NULL,
	PlayerName NVARCHAR(64) NOT NULL,
	TeamAbrv NVARCHAR(8) NOT NULL,
	GameDate DATE NOT NULL,
	PassingYards INT NOT NULL,
	PassingTouchdowns INT NOT NULL,
	InterceptionsThrown INT NOT NULL,
	RushingYards INT NOT NULL,
	RushingTouchdowns INT NOT NULL,
	Receptions INT NOT NULL,
	ReceivingYards INT NOT NULL,
	ReceivingTouchdowns INT NOT NULL,
	Fumbles INT NOT NULL,
	RushAttempts INT NOT NULL
);
END;
