create database OgrenciHakkında
use OgrenciHakkında

go
create table OgrenciDersHakkında
(
ID int identity,
Ders Varchar (50),
Konu Varchar (50),
KonuTekrari Varchar (50),
Test Varchar (50),
SoruSayisi Varchar (50),
MolaArasi Varchar (50),
Odev Varchar (50),
Hedef Varchar (50),
Tarih date,
Puan Varchar (50),
)
insert into OgrenciDersHakkında (Ders,Konu,KonuTekrari,Test,SoruSayisi,MolaArasi,Odev,Hedef,Tarih,Puan) values('Türkçe','Ses Bilgisi','Yaptı',1,20,1,'yok',20,'2019-12-01',100)
select *from OgrenciDersHakkında