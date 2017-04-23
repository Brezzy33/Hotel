Create function [dbo].[ViewMainForm]() 
RETURNS @VAIX TABLE
(
[�������] varchar(35) not null,
[���] varchar(35) not null,
[�������] varchar(35),
[����_���������] datetime not null,
[����_���������] datetime,
[������] varchar(MAX),
[����� �������] int not null
)
AS
BEGIN
INSERT INTO @VAIX
SELECT       Clients.Surname, Clients.Name, Clients.Comments, Settlement.DateSettlement, Settlement.DateRelease, TypeZasel.TypeZas, Settlement.idNumber
FROM            Clients INNER JOIN
                         Settlement ON Clients.idClient = Settlement.idClient INNER JOIN
                         Numbers ON Settlement.idNumber = Numbers.idNumber INNER JOIN
                         TypeZasel ON Numbers.idTypeZasel = TypeZasel.idTypeZasel
						 	RETURN
END