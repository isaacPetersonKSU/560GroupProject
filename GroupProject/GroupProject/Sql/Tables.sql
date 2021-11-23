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
	  Number INT NOT NULL

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
		InterceptionsThrown INT NOT NULL,
		Fumbles INT NOT NULL,
		RushingTouchdowns INT NOT NULL,
		PassingTouchdowns INT NOT NULL,
		ReceivingTouchdowns INT NOT NULL,
		Receptions INT NOT NULL,
		RushingYards INT NOT NULL,
		PassingYards INT NOT NULL,
		ReceivingYards INT NOT NULL,
   );
END;
