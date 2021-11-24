USE PrimaryData;

--TeamType Table
INSERT Season.TeamType(TeamTypeID, [Name])
VALUES 
	(1, 'Home'),
	(2, 'Away');

 --Team Table
 INSERT Season.Team([Name], Abbreviation)
 SELECT DISTINCT(GS.WinnerName), GS.WinnerAbrv
 FROM Season.GamesStaging GS;

 --Game Table
 INSERT Season.Game(SourceGameID, [Date])
 SELECT GS.SourceGameID, GS.[Date]
 FROM Season.GamesStaging GS;

 --Player Table
 INSERT Season.Player([Name], TeamID, Position)
 SELECT DISTINCT(PSS.PlayerName), T.TeamID, PSS.Position
 FROM Season.PlayerStatsStaging PSS
 INNER JOIN Season.Team T ON T.Abbreviation = PSS.TeamAbrv;

--TeamGame Table
INSERT Season.TeamGame(TeamID, GameID, TeamTypeID, Score)
SELECT T.TeamID, GS.SourceGameID, IIF(GS.WinnerAway = '@', 2, 1) AS TeamTypeID, GS.WinnerScore
FROM Season.GamesStaging GS
	INNER JOIN Season.Team T ON T.Abbreviation = GS.WinnerAbrv

INSERT Season.TeamGame(TeamID, GameID, TeamTypeID, Score)
SELECT T.TeamID, GS.SourceGameID, IIF(GS.WinnerAway = '@', 1, 2) AS TeamTypeID, GS.LoserScore
FROM Season.GamesStaging GS
	INNER JOIN Season.Team T ON T.Abbreviation = GS.LoserAbrv

--PlayerGame Table
WITH SourceCTE(TeamAbbr,TeamID, PlayerID, InterceptionsThrown, Fumbles, RushingTouchdowns, PassingTouchdowns,
		ReceivingTouchdowns, RushAttempts,Receptions, RushingYards,PassingYards,ReceivingYards) AS
(
	SELECT T.Abbreviation,T.TeamID, P.PlayerID, PSS.InterceptionsThrown, PSS.Fumbles, PSS.RushingTouchdowns, PSS.PassingTouchdowns,
		PSS.ReceivingTouchdowns, PSS.RushAttempts, PSS.Receptions, PSS.RushingYards, PSS.PassingYards, PSS.ReceivingYards
	FROM Season.PlayerStatsStaging PSS
	INNER JOIN Season.Player P ON P.[Name] = PSS.PlayerName
	INNER JOIN Season.Team T ON T.TeamID = P.TeamID
)

SELECT G.GameID, S.TeamID, S.PlayerID, S.InterceptionsThrown, S.Fumbles, S.RushingTouchdowns, S.PassingTouchdowns,
		S.ReceivingTouchdowns, S.RushAttempts,S.Receptions, S.RushingYards,S.PassingYards,S.ReceivingYards
FROM SourceCTE S
	INNER JOIN Season.GamesStaging GS ON GS.LoserAbrv = S.TeamAbbr
	INNER JOIN Season.Game G ON G.SourceGameID = GS.SourceGameID

INSERT Season.PlayerGame(GameID, PlayerID, TeamID, InterceptionsThrown, Fumbles, RushingTouchdowns, PassingTouchdowns,
		ReceivingTouchdowns, RushAttempts,Receptions, RushingYards,PassingYards,ReceivingYards)
SELECT GS.SourceGameID, S.TeamID, S.PlayerID, S.InterceptionsThrown, S.Fumbles, S.RushingTouchdowns, S.PassingTouchdowns,
		S.ReceivingTouchdowns, S.RushAttempts,S.Receptions, S.RushingYards,S.PassingYards,S.ReceivingYards
FROM SourceCTE S
	INNER JOIN Season.GamesStaging GS ON GS.WinnerAbrv = S.TeamAbrv