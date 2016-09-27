IF OBJECT_ID('dbo.Vidskiptavinir', 'U') IS NOT NULL
DROP TABLE Vidskiptavinir;
IF OBJECT_ID('dbo.Pantanir', 'U') IS NOT NULL
DROP TABLE Pantanir;
IF OBJECT_ID('dbo Baekur', 'U') IS NOT NULL
DROP TABLE Baekur
IF OBJECT_ID('dbo Höfundar', 'U') IS NOT NULL
DROP TABLE Höfundar
IF OBJECT_ID('dbo Utgefendur', 'U') IS NOT NULL
DROP TABLE Utgefendur

CREATE TABLE Utgefendur
(
primary key (KTutgefanda),
KTutgefanda varchar(10), 
nafn      nvarchar (50)NOT NULL,
aðsetur   nvarchar (50)NOT NULL,
stofnár   date 
          

);

CREATE TABLE Höfundar
(
KT           bigint ,
Nafn         nvarchar (50)NOT NULL,
             PRIMARY KEY (KT)
);

CREATE TABLE Baekur
(

Khöfundar       bigint foreign key references Höfundar (KT),
KTutgefanda     varchar(10)foreign key references Utgefendur (KTutgefanda),
isbn            nvarchar (100),
Titill          nvarchar(60)NOT NULL,
utgafuar        int NOT NULL ,
flokkur         nvarchar (50)NOT NULL,
verð            int NOT NULL,
innihaldslysing nvarchar (500)NOT NULL,
prentun         nvarchar (100)NOT NULL

                PRIMARY KEY (isbn)

);

CREATE TABLE Pantanir
(
Pöntunarnumer nvarchar(50)NOT NULL,
Dagsetning    DATE,
Greiðslumati  nvarchar (50)NOT NULL,
              primary key (Pöntunarnumer),
ISbnNR        nvarchar(100) foreign key references Baekur (isbn),
);

CREATE TABLE Vidskiptavinir
(
kt           bigint,
nafn         nvarchar(50)NOT NULL,
menntun      nvarchar(100)NOT NULL,
simi         int NOT NULL ,
póstnr       int NOT NULL,
heimilisfang nvarchar(50) NOT NULL,
ahugasvid    nvarchar(200)NOT NULL,
			 Primary key (kt),
PTnr		 nvarchar(50) foreign key references Pantanir (Pöntunarnumer),
);



INSERT INTO Utgefendur VALUES(1612932889, 'Kolbeinn Bjarki Svavarsson','Reykjavík','1997-05-20'),
							 (0903683899, 'Svavar Guðmundsson','Kópavogur','2005-01-04'),
							 (0211693899, 'Guðrún Sigríður Fransdóttir','Hafnarfjörður','1990-12-20');


INSERT INTO Höfundar VALUES  (1910932599, 'Íris hulda ragnarsdóttir'),
						   (1509002710, 'Ágúst Logi Svavarsson'),
						   (2704923599, 'Bríet Una Svavarsdóttir');

INSERT INTO Baekur VALUES(1910932599,1612932889,'123456789','Ljónið á hæðinni', 2005, 'ævintýrasögur', 2999, 'ljónið sem drap alla á hæðinni','Iða Bókaprentun'),
						 (1509002710,0903683899,'987654321','hofið', 2004, 'hrollvekja', 999, 'sannsöguleg saga um raðmorðinga á íslandi','Iða Bókaprentun'),
						 (2704923599,0211693899,'852963741','svarta hóran', 2000, 'heimldarbók', 2569, 'um fyrstu karlkyns hóruna á íslandi','Iða Bókaprentun'),
						 (1910932599,1612932889,'147258369','týndur á hafi', 2015, 'spennusaga', 4000, 'maður sem lendir i sjó slysi og týnist þar á hafi','Iða Bókaprentun'),
						 (2704923599,0903683899,'369258741','Sólarlag', 1991, 'ástarsaga', 1500, 'Par sem finnur hvort annað og annað þeirra deyr','Iða Bókaprentun');



INSERT INTO Pantanir VALUES('15151','2015-05-20', 'millifærsla','147258369'),
						   ('15152','2015-05-21', 'Kort','987654321'),
						   ('15153','2015-05-22', 'Peningur','852963741'),
						   ('15154','2015-05-23', 'Skiptibók','369258741'),
						   ('15155','2015-05-24', 'Kort','123456789'),
						   ('15156','2015-05-25', 'millifærsla','987654321'),
						   ('15157','2015-05-26', 'Kort','369258741'),
						   ('15158','2015-05-27', 'Peningur','147258369'),
						   ('15159','2015-05-28', 'Skiptibók','852963741'),
						   ('15160','2015-05-29', 'Kort','123456789'),
						   ('15161','2015-05-20', 'millifærsla','369258741'),
						   ('15162','2015-05-21', 'Kort','147258369'),
						   ('15163','2015-05-22', 'Peningur','987654321'),
						   ('15164','2015-05-23', 'Skiptibók','123456789'),
						   ('15165','2015-05-24', 'Kort','852963741');
						   

INSERT INTO Vidskiptavinir VALUES(1515152525,'Sigurjón Atlason','Kennari', 7705849, 210, 'hofakur 3', 'bókmentir','15151'),
								 (1525251515,'ásmudnur gíslasson','bílvélavirki', 7784545, 201, 'gullsmári 6', 'bílar','15152'),
								 (1212122323,'Eiður grétarsson','stjörnufræðingur', 8647460, 233, 'álhólfsvegur 85', 'geimflaugar','15153'),
								 (1414142525,'alex heimisson','tölvunafræðingur', 6595920, 105, 'bakkastígur 15', 'Forritun','15154'),
								 (1717178899,'þröstur kristjánsson','hagfræðingur', 7700366, 201, 'lindasmári 41', 'Stærðfræði','15155');

select*
from Pantanir

Select isbn, Titill
from Baekur
where Titill = 'Ljónið á hæðinni'


Select Greiðslumati
from Pantanir
Where ISbnNR = '123456789'


Select  Greiðslumati
from Pantanir
join Baekur on Pantanir.ISbnNR = Baekur.isbn
where Titill = 'Ljónið á hæðinni'
