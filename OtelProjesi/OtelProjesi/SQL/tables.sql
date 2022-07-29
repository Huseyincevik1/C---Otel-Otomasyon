create database OTEL 

use OTEL

GO

create table tblOda
(
odaNO int primary key,
bosMu bit ,
tabanFiyat money
)

GO

create table tblRezervasyonTipi 
(
 rezervasyonTipiID int Primary Key,
 rezervasyonTipiAd nvarchar(30),
 indirimYuzdesi float
)
GO
--Müşteri Tablosu
create table tblMusteri
(
musteriID int identity(1,1) primary key,
musteriAd nvarchar(50),
musteriSoyad nvarchar(50),
Adres nvarchar(500),
TCkimlikNO nvarchar(11),
ePostaAdersi nvarchar(150)
)

GO

create table tblKrediKart
(
kartNO nvarchar(16) primary key,
sonkullanimTarih date,
guvenlikKod int,
musteriID int
CONSTRAINT FK_KrediKart FOREIGN KEY (musteriID) REFERENCES tblMusteri (musteriID)
)


GO
--Fatura Tablosu
create table tblFatura
(
faturaID int  identity(1,1) primary key,
basimTarih datetime,
musteriID int,
CONSTRAINT FK_Fatura FOREIGN KEY (musteriID) REFERENCES tblMusteri (musteriID)
)

GO
--Rezervasyon tablosu
create table tblRezervasyon
(
rezervasyonID int identity(1,1) primary key,
rezervasyonTarih datetime,
gelisTarih datetime,
gidisTarih datetime,
iptalMi bit,
ertelemeTarih datetime,
tabanFiyat money,
kalmaFiyat money,
musteriID int,
rezervasyonTipiID int,
odaNO int,
CONSTRAINT FK_MusteriRezervasyon FOREIGN KEY (musteriID) REFERENCES tblMusteri (musteriID),
CONSTRAINT FK_rezervasyontipi FOREIGN KEY (rezervasyonTipiID) REFERENCES tblRezervasyonTipi (rezervasyonTipiID),
CONSTRAINT FK_Oda FOREIGN KEY (odaNO) REFERENCES tblOda (odaNO)
)

GO
create table tblCalisanTipiID
(
calisanTipiID int primary key,
calisanTipiAd nvarchar(20)
)

GO
create table tblCalisan
(
calisanID int identity(1,1) primary key,
calisanAd nvarchar(20),
calisanSoyad nvarchar(20),
calisanTipiID int,
CONSTRAINT FK_Calisan FOREIGN KEY (calisanTipiID) REFERENCES tblCalisanTipiID (calisanTipiID)
)



GO
--Odatablosununa kayıt eklemek için

DECLARE @Sayac INT = 0;
WHILE @Sayac < 20 BEGIN 
insert into tblOda (odaNO,bosMu) values (@sayac+500,1)
SET @Sayac += 1;
END;


select * from tblOda

--Rezervasyontipine kayıt eklemek için
INSERT INTO tblRezervasyonTipi (rezervasyonTipiID,rezervasyonTipiAd) VALUES

(1,'Ön ödemeli rezervasyon'),
(2,'60 gün önceden rezervasyon'),
(3,'Standart(klasik) rezervasyon'),
(4,'Teşvik rezervasyonları')

select * from tblRezervasyonTipi

select * from tblOda
select * from tblRezervasyon
select * from tblFatura
select * from tblKrediKart
select * from tblMusteri



