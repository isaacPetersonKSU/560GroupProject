USE PrimaryData

--Ranks players by total number of touchdowns scored
SELECT 
	P.Name, 
	COUNT(DISTINCT PG.PassingTouchdowns) + COUNT (DISTINCT PG.ReceivingTouchdowns) AS Touchdowns
FROM Season.Player P
	LEFT JOIN Season.PlayerGame PG
	ON P.PlayerID = PG.PlayerID
GROUP BY P.Name
ORDER BY Touchdowns;

