--CREATE SCHEMA [FootballDB] AUTHORIZATION [dbo];


DROP TABLE IF EXISTS FootballDB.TeamGames;
DROP TABLE IF EXISTS FootballDB.Games;
DROP TABLE IF EXISTS FootballDB.TeamTypes;
DROP TABLE IF EXISTS FootballDB.Players;
DROP TABLE IF EXISTS FootballDB.Teams;

CREATE TABLE FootballDB.Teams
(
	TeamID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Location NVARCHAR(32) NOT NULL,
	--might add a new table for team but IDK
	Name NVARCHAR(32) NOT NULL,
);

CREATE TABLE FootballDB.Players
(
	PlayerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL,
	Number INT NOT NULL,
	TeamID INT NOT NULL,

	CONSTRAINT [UK_FootballDB_Players_TeamID_PlayerID] UNIQUE
	(
		PlayerID, TeamID
	),

	CONSTRAINT [FK_FootballDB_Players_FootballDB_Teams] FOREIGN KEY
	(TeamID)
	REFERENCES FootballDB.Teams(TeamID)
);

CREATE TABLE FootballDB.TeamTypes
(
	TeamTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Type NCHAR(2) NOT NULL 
)

CREATE TABLE FootballDB.Games
(
	GameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Location NVARCHAR(32) NOT NULL,
	Date DATE NOT NULL
)

CREATE TABLE FootballDB.TeamGames 
(
	TeamGameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeamID INT NOT NULL,
	GameID INT NOT NULL, 
	TeamTypeID INT NOT NULL,
	Score INT NOT NULL

	CONSTRAINT [FootballDB_TeamGames_FootballDB_Teams] 
	FOREIGN KEY(TeamID)
	REFERENCES FootballDB.Teams(TeamID),

	CONSTRAINT [FootballDB_TeamGames_FootballDB_Games] 
	FOREIGN KEY(GameID)
	REFERENCES FootballDB.Games(GameID),

	CONSTRAINT [FootballDB_TeamGames_FootballDB_TeamType] 
	FOREIGN KEY(TeamTypeID)
	REFERENCES FootballDB.TeamTypes(TeamTypeID),

	--add unique key constraints here bro
)



INSERT INTO FootballDB.Teams (Location, Name)
VALUES 
	('Kansas City', 'Chiefs'),
	( 'Denver', 'Broncos');


INSERT INTO FootballDB.Players (FirstName, LastName, Number, TeamID)
VALUES 
( N'Patrick', N'Mahomes', 15, 
	(
		SELECT T.TeamID
		FROM FootballDB.Teams T
		WHERE Name = 'Chiefs'
	)
);


SELECT *
FROM FootballDB.Teams T;

SELECT *
FROM FootballDB.Players;

