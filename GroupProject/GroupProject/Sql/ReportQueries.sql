USE PrimaryData;


--Ranks players by total number of touchdowns scored
DROP PROCEDURE IF EXISTS Season.usp_PlayersByTouchdowns;
GO

CREATE PROCEDURE Season.usp_PlayersByTouchdowns
AS
SELECT 
	P.Name, 
	SUM(PG.PassingTouchdowns) + SUM (PG.ReceivingTouchdowns) 
		+ SUM(PG.RushingTouchdowns) AS Touchdowns
FROM Season.Player P
	INNER JOIN Season.PlayerGame PG
	ON P.PlayerID = PG.PlayerID
GROUP BY P.Name
ORDER BY Touchdowns DESC;
GO

EXEC Season.usp_PlayersByTouchdowns;
GO





--Ranks all teams a particular team has played by scores
SELECT T.Name
FROM Season.Team T 
--NOT DONE YET!!!!!!!!!!!




--List all-purpose Yards for every player from a particular game
DROP PROCEDURE IF EXISTS Season.usp_AllPurposeYards;
GO

CREATE PROCEDURE Season.usp_AllPurposeYards @GameID INT
AS
SELECT P.Name, G.Date, T.Name AS Team,
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
ORDER BY AllPurposeYards DESC
GO

EXEC Season.usp_AllPurposeYards @GameID = 66;
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

EXEC Season.usp_TeamTotals '2020-01-01', '2021-01-01';
GO