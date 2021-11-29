USE PrimaryData;

--Gets all stats for every game a player has played in
DROP PROCEDURE IF EXISTS Season.usp_PlayerStats 
GO
CREATE PROCEDURE Season.usp_PlayerStats @PlayerID INT, @TeamID INT
AS
SELECT PS.Date, Oppoents.Name AS Opponent, PS.Fumbles, PS.InterceptionsThrown,
			PS.PassingYards, PS.ReceivingTouchdowns, PS.PassingTouchdowns, PS.ReceivingYards,
			PS.Receptions, PS.RushAttempts, PS.RushingTouchdowns, PS.RushingYards
FROM (
		SELECT G.GameID, G.Date, PG.Fumbles, PG.InterceptionsThrown, PG.PassingTouchdowns,
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



--List all-purpose Yards for every player from a particular game
DROP PROCEDURE IF EXISTS Season.usp_AllPurposeYards;
GO

CREATE PROCEDURE Season.usp_AllPurposeYards @GameID INT
AS
SELECT P.Name, T.Name AS Team,
	SUM(PG.PassingYards) + SUM(PG.ReceivingYards) 
		+ SUM(PG.RushingYards) AS AllPurposeYards
	
FROM Season.PlayerGame PG
	INNER JOIN Season.Player P
	ON PG.PlayerID = P.PlayerID
	INNER JOIN Season.Game G
	ON PG.GameID = G.GameID
	INNER JOIN Season.Team T
	ON P.TeamID = T.TeamID
WHERE PG.GameID = @GameID 
GROUP BY P.Name, G.Date, T.Name
ORDER BY AllPurposeYards ASC
GO



--Return a team's total stats for a range of dates
DROP PROCEDURE IF EXISTS Season.usp_TeamTotals;
GO

CREATE PROCEDURE Season.usp_TeamTotals @StartDate date, @EndDate date
AS
SELECT T.Name, 
	SUM(PG.Fumbles) AS Fumbles,
	SUM(PG.InterceptionsThrown) AS InterceptionsThrown,
	SUM(PG.PassingTouchdowns) AS PassingTouchdowns,
	SUM(PG.PassingYards) AS PassingYards,
	SUM(PG.Receptions) AS ReceptionsCaught,
	SUM(PG.RushAttempts) AS RushAttempts,
	SUM(PG.RushingTouchdowns) AS RushingTouchdowns,
	SUM(PG.RushingYards) AS RushingYards
FROM Season.Player P
	INNER JOIN Season.PlayerGame PG
	ON P.PlayerID = PG.PlayerID
	INNER JOIN Season.Team T
	ON P.TeamID = T.TeamID
	INNER JOIN Season.Game G
	ON PG.GameID = G.GameID
WHERE G.Date BETWEEN @StartDate and @EndDate
GROUP BY T.Name
ORDER BY Fumbles DESC;
GO