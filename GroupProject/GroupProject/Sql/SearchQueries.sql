USE PrimaryData;


--Ranks players by total number of touchdowns scored
DROP PROCEDURE IF EXISTS Season.usp_Players;
GO
CREATE PROCEDURE Season.usp_Players @OrderBy VARCHAR(16), @Direction VARCHAR(4)
AS
	WITH cte_Players (Name, Team, PassingTDs, ReceivingTDs, RushingTDs, TotalTDs)
	AS 
	(
		SELECT P.Name, T.Name AS Team,
		SUM(PG.PassingTouchdowns) AS PassingTDs,
		SUM(PG.ReceivingTouchdowns) AS ReceivingTDs,
		SUM(PG.RushingTouchdowns) AS RushingTDs,
		SUM(PG.PassingTouchdowns) + SUM(PG.ReceivingTouchdowns)
			+ SUM(PG.RushingTouchdowns) AS TotalTDs
		FROM Season.Player P
			INNER JOIN Season.PlayerGame PG
			ON P.PlayerID = PG.PlayerID
			INNER JOIN Season.Team T
			ON P.TeamID = T.TeamID
		GROUP BY P.Name, T.Name
	)

SELECT *
FROM cte_Players P
GROUP BY P.Name, P.Team, PassingTDs, P.ReceivingTDs, P.RushingTDs, P.TotalTDs
ORDER BY 
	CASE WHEN @Direction = 'asc' THEN
		CASE 
			WHEN @OrderBy = 'team' THEN Team
			WHEN @OrderBy = 'ef' THEN P.PassingTDs
			WHEN @OrderBy = 'passingTDs' THEN PassingTDs
			WHEN @OrderBy = 'ReceivingTDs' THEN ReceivingTDs
			WHEN @OrderBy = 'RushingTDs' THEN RushingTDs
			WHEN @OrderBy = 'TotalTDs' THEN TotalTDs
			ELSE Name
		END
	END ASC,
	CASE WHEN @Direction = 'desc' THEN
		CASE 
			WHEN @OrderBy = 'team' THEN Team
			WHEN @OrderBy = 'passingTDs' THEN PassingTDs
			WHEN @OrderBy = 'ReceivingTDs' THEN ReceivingTDs
			WHEN @OrderBy = 'RushingTDs' THEN RushingTDs
			WHEN @OrderBy = 'TotalTDs' THEN TotalTDs
			ELSE Name
		END
	END DESC

GO
EXEC Season.usp_Players @OrderBy = N'rushingTDs', @Direction = 'desc'
