/* http://pastebin.com/vj7g0xMx */
 
IF OBJECT_ID('dbo.Pantanir', 'U') IS NOT NULL
    DROP TABLE Pantanir;
 
IF OBJECT_ID('dbo.Baekur', 'U') IS NOT NULL
    DROP TABLE Baekur;
 
IF OBJECT_ID('dbo.Simanumer', 'U') IS NOT NULL
    DROP TABLE Simanumer;
 
IF OBJECT_ID('dbo.Vidskiptavinir', 'U') IS NOT NULL
    DROP TABLE Vidskiptavinir;
 
IF OBJECT_ID('dbo.Utgefendur', 'U') IS NOT NULL
    DROP TABLE Utgefendur;
 
IF OBJECT_ID('dbo.Hofundar', 'U') IS NOT NULL
    DROP TABLE Hofundar;
 
 
CREATE TABLE Hofundar
(
    Nafn varchar(50) not null,
    Kennitala varchar(10) primary key
);
CREATE TABLE Utgefendur
(
    Kennitala varchar(10) primary key,
    Nafn varchar(50) not null,
    Gotuheiti varchar(50) not null,
    Husnumer char(5) not null,
    Baearfelag varchar(50) not null,
    ZIP int not null,
    Stofnar int
);
CREATE TABLE Vidskiptavinir
(
    Kennitala varchar(10) primary key,
    Nafn varchar(50) not null,
    Gotuheiti varchar(50) not null,
    Husnumer char(5) not null,
    Baearfelag varchar(50) not null,
    ZIP int not null,
    Email varchar(50),
    Ahugasvid text,
    Menntun text
);
CREATE TABLE Simanumer
(
    Kennitala varchar(10) foreign key
        references Vidskiptavinir(Kennitala),
    Simanumer varchar(15) not null,
    primary key (Kennitala, Simanumer)
);
CREATE TABLE Baekur
(
    ISBN varchar(15) primary key,
    Titill varchar(50) not null,
    Flokkur varchar(50) not null,
    Utgafuar int not null,
    Verd int not null,
    Prentun varchar(50),
    Innihaldslysing text,
    KtHofundar varchar(10) foreign key
        references Hofundar(Kennitala),
    KtUtgefanda varchar(10) foreign key
        references Utgefendur(Kennitala)
);
CREATE TABLE Pantanir
(
    Nr varchar(50) primary key,
    ISBN varchar(15) foreign key
        references Baekur(ISBN),
    Dagsetning date not null,
    Greidslumati varchar(50) not null,
    KtVidskiptavins varchar(10) foreign key
        references Vidskiptavinir(Kennitala)
);
 
INSERT INTO Hofundar VALUES
('Áslákur Mikli', '1307463449'),
('Kristófer Arnarson', '1109773649'),
('Friðrik Froskur', '2206912669'),
('Logi Funi', '1302843219'),
('Lovísa Kristín', '1102233419');
 
INSERT INTO Utgefendur VALUES
('2944678224', 'Bækur og læti', 'Suðurgata', '14', 'Reykjavík', 101, 1988),
('6648912552', 'Betri bækur', 'Strandgata', '21a', 'Hafnarfjörður', 220, 2004),
('1245679984', 'Skruddan', 'Laugarvegur', '44', 'Reykjavík', 101, 1922);
 
INSERT INTO Vidskiptavinir VALUES
('0710923149', 'Kristján Sigurðsson', 'Erluás', '24', 'Hafnarfjörður', 221, 'stjani_legend@smais.is', 'Ævintýri, Sjálfshjálp', 'Næstum því grunnskóli'),
('1408643842', 'Aron Ágústson', 'Kvistaberg', '17c', 'Hafnarfjörður', 220, 'ronnithruma64@msn.com', 'Unglingabókmenntir, Vísindaskáldskapur, Drama', 'Meiraprófið'),
('1212443269', 'Helga Loftsdóttir', 'Hrísateigur', '8', 'Reykjavík', 107, 'helgaloft@hotmail.com', 'Spennubókmenntir, Mannfræði, Miðaldarsaga Þýskalands', 'Stúdentspróf frá Kvennaskólanum');
INSERT INTO Simanumer VALUES
('1212443269', '5885523'),
('1408643842', '8986661'),
('0710923149', '6616141');
INSERT INTO Baekur VALUES
('1239654789525', 'Heimaslóðir', 'Æviminningar', 1969, 1799, '2', 'Leiðinleg gömul kona segir frá sveitinni sinni, og hvað allt var betra í gamladaga', '1102233419', '1245679984'),/*höf // útg*/
('8542963741982', 'Vensl og tengsl', 'Samsæriskenningar', 2003, 2499, '1', 'Tæpur gaur greinir frá brengluðu sýn sinni á heiminn', '1307463449', '2944678224'),
('4005963784195', 'Langur langur gangur', 'Ljóð og kvæði', 1999, 999, '2', 'Nútímaljóð sem tefla við skynjun, sköpun og páfann', '1302843219', '6648912552');
INSERT INTO Pantanir VALUES
('000-023-649', '8542963741982', '2012-01-27', 'Millifærsla', '1408643842'),
('000-023-777', '1239654789525', '2012-01-28', 'Millifærsla', '0710923149'),
('000-023-821', '4005963784195', '2012-08-15', 'Gjaldfært á reikning', '1408643842'),
('000-024-115', '1239654789525', '2012-09-01', 'Millifærsla', '1408643842'),
('000-024-119', '4005963784195', '2013-04-12', 'Millifærsla', '0710923149'),
('000-024-255', '8542963741982', '2013-04-30', 'Greiðslukort', '1212443269'),
('000-024-492', '1239654789525', '2014-11-29', 'Greiðslukort', '1212443269'),
('000-025-641', '1239654789525', '2015-07-19', 'Gjaldfært á reikning', '1408643842'),
('000-025-701', '4005963784195', '2015-12-17', 'Greiðslukort', '1408643842'),
('000-025-786', '4005963784195', '2016-02-15', 'Millifærsla', '1212443269'),
('000-025-866', '8542963741982', '2016-03-04', 'Gjaldfært á reikning', '0710923149');
 
 
 
/*
SELECT * FROM Hofundar
SELECT * FROM Utgefendur
SELECT * FROM Vidskiptavinir
SELECT * FROM Simanumer
SELECT * FROM Baekur
SELECT * FROM Pantanir
*/
 
/*
SELECT V.Nafn as 'Nafnið', V.Kennitala as 'Kennit. viðskiptav.', S.Kennitala, S.Simanumer as 'Símanúmer'
    FROM Vidskiptavinir as V, Simanumer as S
    WHERE V.Kennitala = S.Kennitala
*/
 
/*SELECT B.Titill as 'Bókartitill', B.ISBN, B.Utgafuar as 'Útgáfuár bókar',
       U.Nafn as 'Nafn útgefanda', U.Kennitala as 'Kennitala útgefanda', H.Nafn as 'Nafn höfundar'
    FROM Baekur as B, Utgefendur as U, Hofundar as H
    WHERE B.KtUtgefanda = U.Kennitala
      AND B.KtHofundar = H.Kennitala
*/
 
/*
SELECT P.Nr, B.Titill, B.Verd
FROM Pantanir as P, Baekur as B
WHERE B.ISBN = P.ISBN
*/
 
SELECT *
FROM Pantanir
 
SELECT ISBN, Titill
FROM Baekur
WHERE Titill = 'Vensl og tengsl'
 
SELECT Greidslumati
FROM Pantanir
WHERE ISBN = '8542963741982'
 
 
SELECT Titill, Greidslumati
FROM Pantanir
JOIN Baekur on Pantanir.ISBN = Baekur.ISBN
WHERE Baekur.Titill = 'Vensl og tengsl'
 
 
SELECT Greidslumati, COUNT(Greidslumati) as 'Fjöldi'
FROM Pantanir
GROUP BY Greidslumati
 
/* Ykkar verkefni!
   Finnið meðalverð allra pantana í kerfinu.
   Í fyrstu tilraun má sleppa því að reikna fjölda bóka.
   En svo má taka tillit til fjölda bóka (advanced)
   Byrjið með einfaldar skipanir og reynið að splæsa þeim saman,
   #svipað# og við gerðum með Bækur og Pantanir í sitthvoru
   lagi þar sem annað skilaði ISBN númeri en hitt notaði
   svo það ISBN númer.
*/
 
SELECT AVG(Verd), SUM(Verd) as 'Heildarverð', COUNT(P.Nr) as 'Heildar fjöldi bóka'
FROM Pantanir P
JOIN Baekur B on P.ISBN = B.ISBN
 
SELECT V.Nafn, P.KtVidskiptavins, COUNT(P.KtVidskiptavins) as 'Fjöldi pantana á viðskiptavin'
FROM Pantanir P
JOIN Vidskiptavinir V on V.Kennitala = P.KtVidskiptavins
GROUP BY P.KtVidskiptavins, V.Nafn
ORDER BY V.Nafn DESC
 
 
 
 
 select Simanumer
 from Simanumer
 group by Baekur.Verd 
 
 
 
 
 
 
 
 
 
SELECT Greidslumati, COUNT(Greidslumati)
FROM Pantanir
JOIN Baekur on Pantanir.ISBN = Baekur.ISBN
/*WHERE Baekur.Titill = 'Vensl og tengsl'*/
GROUP BY Greidslumati
 
 
/*
 
 
 
 
 
 
/*
SELECT ISBN, Titill
FROM Baekur
WHERE Titill = 'Vensl og tengsl').ISBN .... '8542963741982' */
 
 
/* http://pastebin.com/WnTZBd4D */