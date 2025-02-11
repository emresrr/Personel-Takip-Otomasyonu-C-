CREATE DATABASE personel_takip;
USE personel_takip;

CREATE TABLE personel (
    tcno CHAR(11) NOT NULL PRIMARY KEY,
    adi VARCHAR(50) NOT NULL,
    soyadi VARCHAR(50) NOT NULL,
    cinsiyet VARCHAR(6) NOT NULL,
    mezuniyet varchar(50) NOT NULL,
    dogum DATE NOT NULL,
	gorev VARCHAR(50) NOT NULL,
    gorevYeri VARCHAR(50) NOT NULL,
    maas VARCHAR(10) NOT NULL
);

CREATE TABLE kullanici (
    tcno CHAR(11) NOT NULL PRIMARY KEY,
    adi VARCHAR(50) NOT NULL,
    soyadi VARCHAR(50) NOT NULL,
    rol VARCHAR(15) NOT NULL,
    kulAdi VARCHAR(50) NOT NULL,
    parola VARCHAR(50) NOT NULL
    
);
INSERT INTO kullanici (tcno, adi, soyadi, kulAdi, parola, rol)
VALUES
('12345678901', 'EMRE', 'SARI', 'emre', 'emre', 'Yönetici');


