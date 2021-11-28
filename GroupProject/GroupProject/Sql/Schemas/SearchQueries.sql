USE PrimaryData;


--Searches players by name
DROP PROCEDURE IF EXISTS Season.usp_SearchPlayers;
GO
CREATE PROCEDURE Season.usp_SearchPlayers @Name NVARCHAR(64)
AS
SELECT P.PlayerID, P.Name, T.Name AS Team, T.TeamID, P.Position
FROM Season.Player P
	INNER JOIN Season.Team T
	ON P.TeamID = T.TeamID
WHERE P.Name Like @Name + '%'
	OR P.Name Like '%' + @Name + '%'
	OR P.Name Like '%' + @Name;
GO

EXEC Season.usp_SearchPlayers @Name = 'pat'
GO

--Ranks players by total number of touchdowns scored
DROP PROCEDURE IF EXISTS Season.usp_Players;
GO
CREATE PROCEDURE Season.usp_Players @OrderBy VARCHAR(64), @Direction VARCHAR(4)
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

SELECT Name, Team, Position, PassingTouchdowns, 
		ReceivingTouchdowns, RushingTouchdowns, TotalTouchdowns
FROM cte_Players P
GROUP BY Name, Team, Position, PassingTouchdowns, ReceivingTouchdowns, 
	RushingTouchdowns, TotalTouchdowns
ORDER BY
	CASE WHEN @Direction = 'asc' THEN
		CASE 
			WHEN @OrderBy = 'Passing Touchdowns' THEN PassingTouchdowns
			WHEN @OrderBy = 'Receiving Touchdowns' THEN ReceivingTouchdowns
			WHEN @OrderBy = 'Rushing Touchdowns' THEN RushingTouchdowns
			WHEN @OrderBy = 'Total Touchdowns' THEN TotalTouchdowns
		END
	END ASC,
	CASE WHEN @Direction = 'desc' THEN
		CASE 
			WHEN @OrderBy = 'passing Touchdowns' THEN PassingTouchdowns
			WHEN @OrderBy = 'Receiving Touchdowns' THEN ReceivingTouchdowns
			WHEN @OrderBy = 'Rushing Touchdowns' THEN RushingTouchdowns
			WHEN @OrderBy = 'Total Touchdowns' THEN TotalTouchdowns
		END
	END DESC
GO

EXEC Season.usp_Players @OrderBy = 'Receiving Touchdowns', @Direction = 'desc'
GO
