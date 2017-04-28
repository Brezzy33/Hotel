create PROCEDURE [dbo].[DelClient] (@clientid int) AS
DELETE FROM Clients WHERE idClient=@clientid