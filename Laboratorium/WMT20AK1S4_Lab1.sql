--drop database firma_komputerowa
use master
go
CREATE DATABASE Firma_komputerowa
GO
USE Firma_komputerowa
go

Create table Produkty(
SN nvarchar(25) not null Primary key,
Producent nvarchar (15) not null,
Typ nvarchar (15) not null
)

Create table PC(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Procesor int NOT NULL,
Pamiec_RAM int NOT NULL,
Dysk_SSD int NOT NULL,
Dysk_HDD int NOT NULL,
Predkosc_CD NVARCHAR(25) NOT NULL,
Cena MONEY NOT NULL
)

Create table Laptopy(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Procesor int NOT NULL,
Pamiec_RAM int NOT NULL,
Dysk_SSD int NOT NULL,
Dysk_HDD int NOT NULL,
Ekran int NOT NULL,
Cena MONEY NOT NULL
)

Create table Drukarki(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Format_papieru NVARCHAR(15) NOT NULL,
Kolor BIT NOT NULL,
Typ NVARCHAR(25) NOT NULL,
Cena MONEY NOT NULL
)

insert into Produkty(SN, Producent, Typ)
values

('ASD-ASDF-ASF','DELL','PC'),
('AWE-GAW-GAW','VDELL','PC'),
('GAW-24T-FZA','SRELL','PC'),
('234-WER-RWE','KRELL','PC'),
('WER-WER-324','FULLE','PC'),
('314-124-QWE','DELS','PC'),
('QEF-ASD-QRQ','PAP','PC'),
('QR3-WFW-FWF','HP','Drukarka'),
('WEF-ASF-GWG','HYP','Drukarka'),
('FQE-ASF-4RF','HTP','Drukarka'),
('CAF-FAE-4FS','HRP','Drukarka'),
('VAE-VRR-3RF','HBP','Drukarka'),
('GSD-DFE-GAG','HNP','Drukarka'),
('ZVX-VSV-ADF','HMP','Drukarka'),
('WEA-32R-FS4','Asus','Laptop'),
('AWF-4TR-GGD','Nasus','Laptop'),
('FAF-4FV-WVS','Bosus','Laptop'),
('SAD-FSD-BBB','Asus','Laptop'),
('190-ASD-VDV','Nasus','Laptop'),
('FFD-VSC-425','Bosus','Laptop'),
('SDF-SCS-BG4','Bosus','Laptop'),
('21398HRF2983H','DELL','PC'),
('G20893J239UEE','LLED','PC'),
('HBGJM548490JF','ELDL','PC'),
('GM3459034JNF4','LIP','PC'),
('GM3490F32N2U4','LAP','PC'),
('GM349324GF34F','LAP','PC'),
('GM54GF45F344T','LAP','PC'),
('GMN34099FJ493','HP','Drukarka'),
('GM3940394JF43','HiP','Drukarka'),
('GM34290JF4394','HoP','Drukarka'),
('543RNF34N9834','HaP','Drukarka'),
('NFMGI90FG9434','Asus','Laptop'),
('12SDBN2173YUD','DELL','Laptop'),
('VG4983HF938F4','ROG','Laptop'),
('132RF17N2SH23','ZEN','Laptop')

insert into PC(SN, Procesor, Pamiec_RAM, Dysk_SSD, Dysk_HDD, Predkosc_CD, Cena)
values
('234-WER-RWE',1800, 4, 1500, 4, '32x', 1450),
('314-124-QWE',4600, 8, 1000, 1, '32x', 2500),
('ASD-ASDF-ASF',3600, 16, 1500, 3, '48x', 4500),
('AWE-GAW-GAW',5500, 32, 2000, 8, '48x', 6500),
('GAW-24T-FZA',1500, 64, 1500, 4, '32x', 2450),
('QEF-ASD-QRQ',1400, 8, 1000, 1, '48x', 3500),
('WER-WER-324',900, 16, 1000, 2, '32x', 1000),
('21398HRF2983H',1500, 16, 1000, 4, '32x', 1450),
('G20893J239UEE',4500, 8, 500, 1, '32x', 2500),
('HBGJM548490JF',3000, 32, 2000, 3, '48x', 4500),
('GM3459034JNF4',5000, 64, 1500, 8, '48x', 6500),
('GM3490F32N2U4',2500, 16, 1000, 4, '32x', 2450),
('GM349324GF34F',3500, 4, 500, 1, '48x', 3500),
('GM54GF45F344T',500, 4, 500, 2, '32x', 1000)


insert into Laptopy(SN, Procesor, Pamiec_RAM, Dysk_SSD, Dysk_HDD, Ekran, Cena)
values
('190-ASD-VDV',2500, 32, 1500, 3, 16, 2900),
('AWF-4TR-GGD',3500, 16, 1000, 2, 18, 3500),
('FAF-4FV-WVS',3500, 16, 3500, 4, 24, 4800),
('FFD-VSC-425',4500, 32, 4500, 5, 26, 4900),
('SAD-FSD-BBB',3500, 8, 1500, 6, 16, 3450),
('SDF-SCS-BG4',5500, 16, 1500, 2, 18, 4500),
('WEA-32R-FS4',1500, 64, 2500, 4, 24, 4250),
('GMN34099FJ493',1500, 16, 1000, 4, 16, 1450),
('GM3940394JF43',4500, 8, 500, 1, 18, 2500),
('GM34290JF4394',3000, 32, 4000, 3, 24, 5500),
('GM3940394JF43',5000, 64, 5000, 8, 26, 7500),
('543RNF34N9834',2500, 16, 1000, 4, 16, 2450),
('GMN34099FJ493',3500, 8, 500, 1, 18, 1500),
('GM34290JF4394',1000, 32, 4000, 3, 24, 3250)


insert into Drukarki(SN, Format_papieru, Kolor, Typ, Cena)
values
('CAF-FAE-4FS', 'A3', 0, 'atrament', 1000),
('FQE-ASF-4RF', 'A2', 1, 'laser', 2000),
('GSD-DFE-GAG', 'A4', 1, 'laser', 3000),
('QR3-WFW-FWF', 'A1', 0, 'laser', 4000),
('VAE-VRR-3RF', 'A4', 1, 'laser', 4500),
('WEF-ASF-GWG', 'A2', 1, 'atrament', 3500),
('ZVX-VSV-ADF', 'A4', 1, 'atrament', 3900),
('NFMGI90FG9434', 'A4', 1, 'laser', 5000),
('12SDBN2173YUD', 'A3', 0, 'atrament', 3000),
('132RF17N2SH23', 'A1', 0, 'laser', 2000),
('12SDBN2173YUD', 'A2', 1, 'atrament', 1000),
('NFMGI90FG9434', 'A5', 0, 'atrament', 7000),
('132RF17N2SH23', 'A3', 1, 'laser', 8000),
('VG4983HF938F4', 'A2', 0, 'laser', 9000)