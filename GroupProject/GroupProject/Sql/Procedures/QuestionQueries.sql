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


--Gets basic info about a player from his ID
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




--totals of every player stat on a team
DROP PROCEDURE IF EXISTS Season.usp_TeamTotals
GO
CREATE PROCEDURE Season.usp_TeamTotals @TeamID INT
AS
SELECT SUM(PG.Fumbles) AS Fumbles, 
	SUM(PG.InterceptionsThrown) AS InterceptionsThrown,
	SUM(PG.PassingTouchdowns) AS PassingTouchdowns,
	SUM(PG.PassingYards) AS PassingYards,
	SUM(PG.ReceivingTouchdowns) AS ReceivingTouchdowns,
	SUM(PG.ReceivingYards) AS ReceivingYards,
	SUM(PG.Receptions) AS Receptions,
	SUM(PG.RushAttempts) AS RushAttempts,
	SUM(PG.RushingTouchdowns) AS RushingTouchdowns,
	SUM(PG.RushingYards) AS RushingYards
FROM Season.PlayerGame PG
	INNER JOIN Season.Player P
	ON P.PlayerID = PG.PlayerID
WHERE P.TeamID = @TeamID
GO

EXEC Season.usp_TeamTotals @TeamID = 1
GO


--Gets all games and related info
DROP PROCEDURE IF EXISTS Season.usp_SearchGames;
GO
CREATE PROCEDURE Season.usp_SearchGames @StartDate DATE, @EndDate Date
AS
SELECT TOP 20 G.Date,
	HomeTeams.Name AS Home, VisitingTeams.Name AS Visior, G.GameID
FROM Season.Game G
	INNER JOIN Season.TeamGame TG
	ON G.GameID = TG.GameID
	INNER JOIN (
		SELECT T.Name, TG.GameID
		FROM Season.TeamGame TG
			INNER JOIN Season.TeamType TT
			ON TG.TeamTypeID = TT.TeamTypeID
			INNER JOIN Season.Team T
			ON TG.TeamID = T.TeamID
		WHERE TT.Name = 'Home'
	) AS HomeTeams 
	ON TG.GameID = HomeTeams.GameID
	INNER JOIN (
		SELECT T.Name, TG.GameID
		FROM Season.TeamGame TG
			INNER JOIN Season.TeamType TT
			ON TG.TeamTypeID = TT.TeamTypeID
			INNER JOIN Season.Team T
			ON TG.TeamID = T.TeamID
		WHERE TT.Name = 'Away'
	) AS VisitingTeams 
	ON TG.GameID = VisitingTeams.GameID
WHERE G.Date BETWEEN @StartDate AND @EndDate
GROUP BY G.GameID, HomeTeams.Name, VisitingTeams.Name, G.Date
ORDER BY G.Date ASC
GO

EXEC Season.usp_SearchGames '2020-01-01', '2021-01-01'
GO


