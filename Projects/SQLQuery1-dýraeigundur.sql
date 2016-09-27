drop table dyr
drop table simanumer
drop table Eigandi

Create table Eigandi
(

kennitala int,
 nafn nvarchar (32) NOT NULL,
 götuheiti nvarchar (50) NOT NULL,
 húsanúmer nvarchar (50) NOT NULL,
 póstnumer int NOT NULL ,
 Sveitarfelag nvarchar (50) NOT NULL,
 primary key(kennitala)
);


Create table dyr
(
	nafn	nvarchar (32)NOT NULL,
	skraningarnumer nvarchar (30) primary key NOT NULL,
	litur nvarchar (50),
	faedingarDagur date NOT NULL, 
	tegund nvarchar (50)NOT NULL,
    kennitalaEiganda int foreign key references Eigandi(kennitala)


);



Create table simanumer 
(
kennitala int foreign key references Eigandi(kennitala),
simanr int, 

primary key (kennitala, simanr)
);


insert into Eigandi values (1212851159,'pétur jónsson', 'hlíðasmára', '12', 201, 'kópavogur'),
						   (1015992509,'biggi lögga', 'hofakur', '3', 210, 'garðabær'),
						   (1612932889,'guðrún ormadóttir', 'skaftafell', '55', 108, 'reykjavik');

insert into simanumer values(1612932889, 6595920),
							(1015992509, 7750366),
							(1212851059, 7705849);
insert into dyr (skraningarnumer, nafn, litur, tegund, faedingarDagur,kennitalaEiganda)
values ('AB0123','snati','gulur', 'fiskur', ' 2015-08-27', 1612932889),
	   ('CDE123','mjása','´grænn', 'köttur', ' 2012-01-15', 1015992509),
	   ('EF4567','patti','rauður', 'hundur', ' 2016-01-31', 1015992509),
	   ('GHIJ89','hörður','svartur', 'köttur', ' 2014-05-06', 1612932889),
	   ('KL0001','siggi','grár', 'köttur', ' 2010-03-06', 1015992509);







	   select * from Eigandi
	   where nafn = 'pétur jónsson'

	   select * from Eigandi
	   where póstnumer > 200


	   select * from simanumer
	   select * from dyr
	   select * from Eigandi
	   
	   select * from dyr
	   delete from dyr
	   where kennitalaEiganda = 1212851159
	   select * from dyr
	   
	   

	   select * from Eigandi
	   delete from Eigandi
	   where nafn = 'pétur jónsson'

	   select * from Eigandi

	    select * from Eigandi
	   where póstnumer < 200
update Eigandi
	  set póstnumer = 107,
	   sveitarfelag = 'hafnarfjörður'


	  where kennitala = 1612932889
	  
	   
	  