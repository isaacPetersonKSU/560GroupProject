USE PrimaryData;


--Searches players by name
DROP PROCEDURE IF EXISTS Season.usp_SearchPlayers;
GO
CREATE PROCEDURE Season.usp_SearchPlayers @Name NVARCHAR(64)
AS
SELECT P.Name, T.Name AS Team, P.Position, P.PlayerID
FROM Season.Player P
	INNER JOIN Season.Team T
	ON P.TeamID = T.TeamID
WHERE P.Name Like @Name + '%'
	OR P.Name Like '%' + @Name + '%'
	OR P.Name Like '%' + @Name
ORDER BY P.Name;
GO

--Searches for teams by name
DROP PROCEDURE IF EXISTS Season.usp_SearchTeams;
GO
CREATE PROCEDURE Season.usp_SearchTeams @Name NVARCHAR(64)
AS
SELECT T.Name, T.Abbreviation, T.TeamID
FROM Season.Team T
WHERE T.Name Like @Name + '%'
	OR T.Name Like '%' + @Name + '%'
	OR T.Name Like '%' + @Name
ORDER BY T.Name;
GO

EXEC Season.usp_SearchTeams @Name = 'Kansas'
GO

DROP PROCEDURE IF EXISTS Season.usp_PlayerByID
GO
CREATE PROCEDURE Season.usp_PlayerByID @PlayerID INT
AS
SELECT P.Name, T.TeamID, T.Name, P.Position
FROM Season.Player P
	INNER JOIN Season.Team T
	ON P.TeamID = T.TeamID
WHERE P.PlayerID = @PlayerID
GO

EXEC Season.usp_PlayerByID @PlayerID = 3
GO

DROP PROCEDURE IF EXISTS Season.usp_PlayerStats 
GO
CREATE PROCEDURE Season.usp_PlayerStats @PlayerID INT, @TeamID INT
AS
SELECT Oppoents.Name AS Oppoent, PS.GameID, PS.Fumbles, PS.InterceptionsThrown,
			PS.PassingTouchdowns, PS.PassingYards, PS.ReceivingTouchdowns, PS.ReceivingYards,
			PS.Receptions, PS.RushAttempts, PS.RushingTouchdowns, PS.RushingYards, PS.GameID
FROM (
		SELECT G.GameID, PG.Fumbles, PG.InterceptionsThrown, PG.PassingTouchdowns,
			PG.PassingYards, PG.ReceivingTouchdowns, PG.ReceivingYards,
			PG.Receptions, PG.RushAttempts, PG.RushingTouchdowns, PG.RushingYards
		FROM Season.PlayerGame PG
			INNER JOIN Season.Game G
			ON PG.GameID = G.GameID
		WHERE PG.PlayerID = @PlayerID
	) AS PS
	INNER JOIN (
		SELECT T.Name, TG.GameID
		FROM Season.Team T
			INNER JOIN Season.TeamGame TG
			ON T.TeamID = TG.TeamID
		WHERE T.TeamID != @TeamID
	) AS Oppoents
	ON PS.GameID = Oppoents.GameID
GO

EXEC Season.usp_PlayerStats @PlayerID = 548, @TeamID = 16
GO