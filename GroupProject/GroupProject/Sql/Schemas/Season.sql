USE PrimaryData

IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Season'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Season] AUTHORIZATION [dbo]');
END;