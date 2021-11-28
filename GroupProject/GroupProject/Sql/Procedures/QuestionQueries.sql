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

