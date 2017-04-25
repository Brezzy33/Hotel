USE [Hotel]
GO
/****** Object:  UserDefinedFunction [dbo].[ViewMainForm]    Script Date: 25.04.2017 16:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER function [dbo].[ViewMainForm]() 
RETURNS @VAIX TABLE
(
[Фамилия] varchar(35) not null,
[Settlement] int not null,
[Имя] varchar(35) not null,
[Коммент] varchar(35),
[Дата_заселения] datetime not null,
[Дата_выселения] datetime,
[Статус] varchar(MAX),
[Номер комнаты] int not null
)
AS
BEGIN
INSERT INTO @VAIX
SELECT       Clients.Surname, Settlement.idClient, Clients.Name, Clients.Comments, Settlement.DateSettlement, Settlement.DateRelease, TypeZasel.TypeZas, Settlement.idNumber
FROM            Clients INNER JOIN
                         Settlement ON Clients.idClient = Settlement.idClient INNER JOIN
                         Numbers ON Settlement.idNumber = Numbers.idNumber INNER JOIN
                         TypeZasel ON Numbers.idTypeZasel = TypeZasel.idTypeZasel
						 	RETURN
END