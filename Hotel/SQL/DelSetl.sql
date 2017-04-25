create PROCEDURE [dbo].[Delsettl] (@clientid int) AS
DELETE FROM Settlement WHERE idClient=@clientid