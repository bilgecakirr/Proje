create database OgrenciHakk�nda
use OgrenciHakk�nda

go
create table OgrenciDersHakk�nda
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
insert into OgrenciDersHakk�nda (Ders,Konu,KonuTekrari,Test,SoruSayisi,MolaArasi,Odev,Hedef,Tarih,Puan) values('T�rk�e','Ses Bilgisi','Yapt�',1,20,1,'yok',20,'2019-12-01',100)
select *from OgrenciDersHakk�nda