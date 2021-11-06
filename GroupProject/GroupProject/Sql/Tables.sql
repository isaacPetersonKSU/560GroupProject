IF OBJECT_ID(N'Season.Team') IS NULL
BEGIN
   CREATE TABLE Season.Team
   (
      TeamID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
      [Name] NVARCHAR(64) NOT NULL,
	  [Location] NVARCHAR(64) NOT NULL

      UNIQUE([Name])
   );
END;

IF OBJECT_ID(N'Season.Player') IS NULL
BEGIN
   CREATE TABLE Season.Player
   (
      PlayerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  TeamID INT NOT NULL FOREIGN KEY
		REFERENCES Season.Team(TeamID),
      FirstName NVARCHAR(64) NOT NULL,
	  LastName NVARCHAR(64) NOT NULL,
	  Number INT NOT NULL

      UNIQUE(TeamID)
   );
END;

IF OBJECT_ID(N'Season.TeamType') IS NULL
BEGIN
   CREATE TABLE Season.TeamType
   (
      TeamTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  [Name] NVARCHAR(8) NOT NULL,

      UNIQUE([Name])
   );
END;

IF OBJECT_ID(N'Season.Game') IS NULL
BEGIN
   CREATE TABLE Season.Game
   (
      GameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  [Location] NVARCHAR(64) NOT NULL,
	  [Date] DATETIME NOT NULL
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
		TeamTypeID INT NOT NULL FOREIGN KEY
			REFERENCES Season.TeamType(TeamTypeID),
		Score INT NOT NULL
		
		UNIQUE(TeamID, GameID, TeamTypeID)
	
   );
END;

IF OBJECT_ID(N'Season.PlayerGame') IS NULL
BEGIN
   CREATE TABLE Season.PlayerGame
   (
		PlayerGameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		GameID INT NOT NULL FOREIGN KEY
			REFERENCES Season.Game(GameID),
		PlayerID INT NOT NULL FOREIGN KEY
			REFERENCES Season.Player(PlayerID),
		TeamID INT NOT NULL FOREIGN KEY
			REFERENCES Season.Team(TeamID),
		Sacks DECIMAL(3,1) NOT NULL,
		InterceptionsThrown INT NOT NULL,
		InterceptionsCaught INT NOT NULL,
		Fumbles INT NOT NULL,
		ForcedFumbles INT NOT NULL,
		Tackles INT NOT NULL,
		Touchdowns INT NOT NULL,
		RushingYards INT NOT NULL,
		PassingYards INT NOT NULL,
		ReceivingYards INT NOT NULL,
		ReturnYards INT NOT NULL
   );
END;
