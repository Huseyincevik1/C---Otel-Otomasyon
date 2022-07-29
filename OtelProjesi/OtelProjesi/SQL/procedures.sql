use OTEL
go

create proc sp_RezervasyonEkle
(
@rezervasyonTarih datetime,
@gelisTarih datetime,
@gidisTarih datetime,
@musteriID int,
@rezervasyonTipiID int
)
as
begin
declare @tabanFiyat money, @kalmaFiyat money

set @tabanFiyat = (select tabanFiyat from tblOda where odaNO=100)
set @kalmaFiyat = @tabanFiyat*(select indirimYuzdesi from tblRezervasyonTipi where rezervasyonTipiID = @rezervasyonTipiID)

insert into tblRezervasyon (rezervasyonTarih,gelisTarih,gidisTarih,tabanFiyat,kalmaFiyat,musteriID,rezervasyonTipiID)
values 
(

@rezervasyonTarih,
@gelisTarih,
@gidisTarih,
@tabanFiyat ,
@kalmaFiyat ,
@musteriID,
@rezervasyonTipiID
)
end

GO

create proc sp_MusteriEkle
(
@musteriAd nvarchar(50),
@musteriSoyad nvarchar(50),
@Adres nvarchar(500),
@TCkimlikNO nvarchar(11),
@ePostaAdersi nvarchar(150)
)
as
begin
insert into tblMusteri (musteriAd,musteriSoyad,Adres,TCkimlikNO,ePostaAdersi)
values 
(
@musteriAd,
@musteriSoyad,
@Adres,
@TCkimlikNO,
@ePostaAdersi
)
end

GO
create proc sp_MusteriKayitGuncelle
(
@musteriID int,
@musteriAd nvarchar(50),
@musteriSoyad nvarchar(50),
@Adres nvarchar(500),
@Telefon nvarchar(11),
@ePostaAdersi nvarchar(150)
)
as
begin
update tblMusteri 
set musteriAd = @musteriAd,
musteriSoyad = @musteriSoyad,
Adres= @Adres,
Telefon=@Telefon,
ePostaAdersi = @ePostaAdersi

where musteriID = @musteriID
end

GO

create proc sp_faturabilgisi
as
begin
select * from faturabilgisi
end
