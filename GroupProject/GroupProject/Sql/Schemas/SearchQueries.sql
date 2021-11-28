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

--Searches for players by team name
DROP PROCEDURE IF EXISTS Season.usp_SearchTeams;
GO
CREATE PROCEDURE Season.usp_SearchTeams @Name NVARCHAR(64)
AS
SELECT T.Name AS Team, T.TeamID, T.Abbreviation
FROM Season.Team T
WHERE T.Name Like @Name + '%'
	OR T.Name Like '%' + @Name + '%'
	OR T.Name Like '%' + @Name
ORDER BY T.Name;
GO

EXEC Season.usp_SearchTeams @Name = 'Kansas'
GO

--Ranks players by total number of touchdowns scored
DROP PROCEDURE IF EXISTS Season.usp_TouchdownLeaders;
GO
CREATE PROCEDURE Season.usp_TouchdownLeaders @OrderBy VARCHAR(64)
AS
	WITH cte_Players (Name, Team, Position, PassingTouchdowns, 
		ReceivingTouchdowns, RushingTouchdowns, TotalTouchdowns)
	AS 
	(
		SELECT P.Name, T.Name AS Team, P.Position,
		SUM(PG.PassingTouchdowns) AS PassingTouchdowns,
		SUM(PG.ReceivingTouchdowns) AS ReceivingTouchdowns,
		SUM(PG.RushingTouchdowns) AS RushingTouchdowns,
		SUM(PG.PassingTouchdowns) + SUM(PG.ReceivingTouchdowns)
			+ SUM(PG.RushingTouchdowns) AS TotalTouchdowns
		FROM Season.Player P
			INNER JOIN Season.PlayerGame PG
			ON P.PlayerID = PG.PlayerID
			INNER JOIN Season.Team T
			ON P.TeamID = T.TeamID
		GROUP BY P.Name, T.Name, P.Position
	)

SELECT TOP 50  Name, Team, Position, PassingTouchdowns, 
		ReceivingTouchdowns, RushingTouchdowns, TotalTouchdowns
FROM cte_Players P
WHERE TotalTouchdowns >= 1
GROUP BY Name, Team, Position, PassingTouchdowns, ReceivingTouchdowns, 
	RushingTouchdowns, TotalTouchdowns
ORDER BY
	CASE 
		WHEN @OrderBy = 'Passing Touchdowns' THEN PassingTouchdowns
		WHEN @OrderBy = 'Receiving Touchdowns' THEN ReceivingTouchdowns
		WHEN @OrderBy = 'Rushing Touchdowns' THEN RushingTouchdowns
		WHEN @OrderBy = 'All Touchdowns' THEN TotalTouchdowns
	END DESC
GO

EXEC Season.usp_TouchdownLeaders @OrderBy = 'Receiving Touchdowns'
GO
