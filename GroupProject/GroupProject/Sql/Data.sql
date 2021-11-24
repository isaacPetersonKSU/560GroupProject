--TeamType Table
INSERT Season.TeamType(TeamTypeID, [Name])
VALUES 
	(1, 'Home'),
	(2, 'Away');

 --Team Table
 INSERT Season.Team([Name], Abbreviation)
 SELECT DISTINCT(GST.WinnerName), GST.WinnerAbrv
 FROM Season.GamesStaging GST;

 --Game Table
 INSERT Season.Game(SourceGameID, [Date])
 SELECT GST.SourceGameID, GST.[Date]
 FROM Season.GamesStaging GST;

 --Player Table
 INSERT Season.Player([Name],TeamID, Position)
 SELECT DISTINCT(PSST.PlayerName),T.TeamID, PSST.Position
 FROM Season.PlayerStatsStaging PSST
 INNER JOIN Season.Team T ON T.Abbreviation = PSST.TeamAbrv

 --TeamGame Table

SELECT *
FROM Season.Player

SELECT *
FROM Season.Team

 --Dummy Values
 INSERT Season.Team([Name], Abbreviation)
 VALUES
	(N'Kansas City Chiefs',N'KC');

 INSERT Season.Player([Name], Position, Number, TeamID)
 VALUES
	(N'Patrick Mahomes', 'QB', 7, 1);

 INSERT Season.Game([Date])
 VALUES
	('10-11-2020');

 INSERT Season.TeamType(TeamTypeID,[Name])
 VALUES
	(1, 'Home');

 INSERT Season.TeamGame(TeamID, GameID, TeamTypeID, Score)
 VALUES
	(1, 1, 1, 20);

INSERT Season.PlayerGame(GameID, PlayerID, TeamID, InterceptionsThrown, Fumbles, PassingTouchdowns, RushingTouchdowns, ReceivingTouchdowns, PassingYards, ReceivingYards, RushingYards, Receptions, RushAttempts)
VALUES
	(1,1,1,2,1,5,1,0,432,0,18, 0, 4);
