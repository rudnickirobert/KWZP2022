USE MASTER
GO
DROP DATABASE Firma_komputerowa
GO
CREATE DATABASE Firma_komputerowa
GO
USE Firma_komputerowa

CREATE TABLE Produkty(
SN NVARCHAR(25) NOT NULL PRIMARY KEY,
Producent NVARCHAR (15) NOT NULL,
Typ NVARCHAR (15) NOT NULL
)

CREATE TABLE PC(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Procesor INT NOT NULL,
Pamiec_RAM INT NOT NULL,
Dysk_SSD INT NOT NULL,
Dysk_HDD INT NOT NULL,
Predkosc_CD NVARCHAR(25) NOT NULL,
Cena MONEY NOT NULL
)

CREATE TABLE Laptopy(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Procesor INT NOT NULL,
Pamiec_RAM INT NOT NULL,
Dysk_SSD INT NOT NULL,
Dysk_HDD INT NOT NULL,
Ekran INT NOT NULL,
Cena MONEY NOT NULL
)

CREATE TABLE Drukarki(
SN NVARCHAR(25) FOREIGN KEY REFERENCES Produkty(SN),
Format_papieru NVARCHAR(15) NOT NULL,
Kolor BIT NOT NULL,
Typ NVARCHAR(25) NOT NULL,
Cena MONEY NOT NULL
)

INSERT INTO Produkty(SN, Producent, Typ)
VALUES
('ASD-ASD-ASF','DELL','PC'),
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
('216-000-264', 'MSI', 'PC'),
('985-000-125', 'MSI', 'PC'),
('741-000-565', 'LENOVO', 'PC'),
('895-000-675', 'LENOVO', 'PC'),
('984-000-777', 'AOC', 'PC'),
('959-001-974', 'MSI', 'PC'),
('745-001-771', 'RAZER', 'PC'),
('656-123-048', 'LENOVO', 'Laptop'),
('158-123-242', 'HP', 'Laptop'),
('644-123-467', 'APPLE', 'Laptop'),
('143-123-145', 'SAMSUNG', 'Laptop'),
('345-123-148', 'HP', 'Laptop'),
('242-124-658', 'DELL', 'Laptop'),
('543-124-678', 'HP', 'Laptop'),
('ABC-456-SWG', 'EPSON', 'Drukarka'),
('ABC-456-JTF', 'HP', 'Drukarka'),
('ABC-456-RAA', 'CANON', 'Drukarka'),
('ABC-456-LUJ', 'SHARP', 'Drukarka'),
('ABC-456-EHW', 'BROTHER', 'Drukarka'),
('BCD-456-ULE', 'HP', 'Drukarka'),
('BCD-456-QWE', 'EPSON', 'Drukarka'),
('21398HRF2983H','DELL','PC'),
('G20893J239UEE','LLED','PC'),
('HBGJM548490JF','ELDL','PC'),
('GM3459034JNF4','LIP','PC'),
('GM3490F32N2U4','LAP','PC'),
('GM349324GF34F','LAP','PC'),
('GM54GF45F344T','LAP','PC'),
('GMN34099FJ493','HP','Laptop'),
('GM3940394JF43','HiP','Laptop'),
('GM34290JF4394','HoP','Laptop'),
('543RNF34N9834','HaP','Laptop'),
('NFMGI90FG9434','Asus','Drukarka'),
('12SDBN2173YUD','DELL','Drukarka'),
('VG4983HF938F4','ROG','Drukarka'),
('132RF17N2SH23','ZEN','Drukarka'),
('5PM-A05-NUN','HP','PC'),
('W4I-TFL-BC3','DELL','PC'),
('T9T-9FX-885','Apple','PC'),
('A13-XJ2-XKP','Lenovo','PC'),
('K64-K1M-9JR','Acer','PC'),
('C8E-M96-MXH','Lenovo','PC'),
('OTS-RMB-O5J','Dell','PC'),
('I8U-Z6D-Z9P','HP','Laptop'),
('46J-H27-BWD','Apple','Laptop'),
('HZ2-N7T-SZC','Samsung','Laptop'),
('GTK-K41-0R9','Huawei','Laptop'),
('GR2-IXA-G5O','Samsung','Laptop'),
('8DB-0Y0-ZZD','Asus','Laptop'),
('PJS-UE7-HZ2','Dell','Laptop'),
('XP4-09P-JOC','HP','Drukarka'),
('3B3-5MB-WMU','HP','Drukarka'),
('BYP-WZI-8F3','Samsung','Drukarka'),
('H30-XAT-36G','HP','Drukarka'),
('TYT-968-N4T','Epson','Drukarka'),
('H0J-MUA-FB2','HP','Drukarka'),
('68F-N88-82B','Epson','Drukarka'),
('AAA-BBB-CCC','DELL','PC'),
('CCC-BBB-AAA','NDELL','PC'),
('111-222-333','RRELL','PC'),
('444-555-666','DRELL','PC'),
('555-666-777','SRELL','PC'),
('QAZ-XSW-EDC','ACERA','PC'),
('QWE-ASD-ZXC','PACER','PC'),
('ZXC-ASD-QWE','HPP','Laptop'),
('WSX-EDC-RFV','HIP','Laptop'),
('XSW-CDE-RFV','HRP','Laptop'),
('SXW-EDC-VFR','HSP','Laptop'),
('SDF-XCV-WER','HBP','Laptop'),
('ERT-DFG-CVB','HNP','Laptop'),
('RTY-FGH-VBN','HMP','Laptop'),
('TYU-GHJ-BNM','Asus','Drukarka'),
('UIO-JKL-IOP','Acer','Drukarka'),
('KLA-NMZ-OPQ','Nacer','Drukarka'),
('ASD-SSF-FDF','Asus','Drukarka'),
('DAS-FDS-HJG','Nacer','Drukarka'),
('RWE-HFG-CXZ','Nicer','Drukarka'),
('POI-JGH-VCX','Asusus','Drukarka'),
('AWD-QWE-EWF','MSI','Laptop'),
('CXZ-F23-XCV','PSI','Laptop'),
('BFD-324-SDF','MERCI','PC'),
('MKK-WET-RRE','DM','PC'),
('OHJ-VUR-K9F','SUPERKAKUTER','PC'),
('FJ3-VN9-QWE','AMUS','PC'),
('GPZ-VJ6-GJ2','Lelovo','PC'),
('JGR-45T-3RS','HP','Drukarka'),
('FE4-FRH-5YH','HD','Drukarka'),
('FDG-H5H-DVB','HT','Drukarka'),
('DFB-5GD-BGY','HP','Drukarka'),
('000-000-001', 'DELL', 'PC'),
('000-000-002', 'DELL', 'PC'),
('000-000-003', 'DELL', 'PC'),
('000-000-004', 'DELL', 'PC'),
('000-000-005', 'SAMSUNG', 'PC'),
('000-000-006', 'SAMSUNG', 'PC'),
('000-000-007', 'SAMSUNG', 'PC'),
('123-123-123', 'ASUS', 'Laptop'),
('123-123-001', 'ASUS', 'Laptop'),
('123-123-002', 'HP', 'Laptop'),
('123-123-003', 'SAMSUNG', 'Laptop'),
('123-123-004', 'SAMSUNG', 'Laptop'),
('123-123-005', 'DELL', 'Laptop'),
('123-123-006', 'APPLE', 'Laptop'),
('ABC-456-XYZ', 'HP', 'Drukarka'),
('ABC-456-001', 'HP', 'Drukarka'),
('ABC-456-002', 'HP', 'Drukarka'),
('ABC-456-003', 'Brother', 'Drukarka'),
('ABC-456-004', 'Brother', 'Drukarka'),
('ABC-456-005', 'Canon', 'Drukarka'),
('ABC-456-006', 'Canon', 'Drukarka'),
('001-001-001','Dell','PC'),
('012-040-666','Acer','PC'),
('100-080-609','Lenovo','PC'),
('010-800-609','Lenovo','PC'),
('001-008-609','Acer','PC'),
('010-800-619','Dell','PC'),
('001-008-650','Acer','PC'),
('123-123-456','ASUS','Laptop'),
('321-321-321','MSI','Laptop'),
('321-321-320','MSI','Laptop'),
('321-321-319','Lenovo','Laptop'),
('321-321-318','Acer','Laptop'),
('321-321-317','Dell','Laptop'),
('321-321-316','Acer','Laptop'),
('ABC-456-XXX','HP','Drukarka'),
('CCC-690-0B1','Canon','Drukarka'),
('ABC-456-XYW','HP','Drukarka'),
('CCC-690-0B2','Canon','Drukarka'),
('ABC-456-XYT','HP','Drukarka'),
('CCC-690-0B3','Canon','Drukarka'),
('ABC-456-XYU','HP','Drukarka'),
('568-247-874','EPSON','Drukarka'),
('321-841-958','HP','Drukarka'),
('945-328-740','Canon','Drukarka'),
('548-650-010','Brother','Drukarka'),
('405-700-001','Canon','Drukarka'),
('198-840-395','EPSON','Drukarka'),
('874-611-009','HP','Drukarka'),
('148-123-483', 'HUAWEI','Laptop'),
('640-873-991','Apple','Laptop'),
('830-558-733','Envy','Laptop'),
('750-354-950','ASUS','Laptop'),
('147-548-366','LENOVO','Laptop'),
('777-953-117','HP','Laptop'),
('746-591-050','ASUS','Laptop'),
('619-761-007','MSI','PC'),
('907-880-111','ACTINA','PC'),
('777-921-003','ACER','PC'),
('913-006-549','Apple','PC'),
('846-999-107','AOC','PC'),
('611-216-947','Samsung','PC'),
('031-103-640','XPG','PC'),
('D7H-D3K-2J8','Lenovo','PC'),
('L67-D45-1JJ','DELL','PC'),
('LOP-DAY-876','Fujitsu','PC'),
('777-JHG-BFG','Acer','PC'),
('LAP-PAL-WAL','Lenovol','PC'),
('098-HFG-ASD','DELLO','PC'),
('QMP-PMQ-ERT','APPLE','PC'),
('MMM-NVB-000','HPE','Drukarka'),
('ABC-III-JHG','Xerox','Drukarka'),
('FAA-ICA-OSP','Brother','Drukarka'),
('PQK-888-760','Canon','Drukarka'),
('VVA-09J-SAS','Pixma','Drukarka'),
('LEA-PGE-NXG','Samsung','Drukarka'),
('AQA-909-BBB','Epson','Drukarka'),
('MNM-POP-IUI','ABM','Laptop'),
('865-093-487','Lexar','Laptop'),
('FEL-341-0IB','Daewoo','Laptop'),
('ALC-5GB-8JK','Toshiba','Laptop'),
('JW1-098-WIS','Zhaoxin','Laptop'),
('AWS-PLL-SPA','Sony','Laptop'),
('EEE-XCV-999','BenQ','Laptop'),
('001-000-001','DELL','PC'),
('001-000-002','DELL','PC'),
('001-000-003','DELL','PC'),
('001-000-004','DELL','PC'),
('001-000-005','DELL','PC'),
('001-000-006','DELL','PC'),
('001-000-007','DELL','PC'),
('002-000-001','HP','Laptop'),
('002-000-002','HP','Laptop'),
('002-000-003','HP','Laptop'),
('002-000-004','HP','Laptop'),
('002-000-005','HP','Laptop'),
('002-000-006','HP','Laptop'),
('002-000-007','HP','Laptop'),
('003-000-001','Asus','Drukarka'),
('003-000-002','Asus','Drukarka'),
('003-000-003','Asus','Drukarka'),
('003-000-004','Asus','Drukarka'),
('003-000-005','Asus','Drukarka'),
('003-000-006','Asus','Drukarka'),
('003-000-007','Asus','Drukarka'),
('123-456-789','DELL','PC'),
('125-356-759','DELLL','PC'),
('133-446-789','DEOLL','PC'),
('523-556-589','SONY','PC'),
('525-555-589','SONO','PC'),
('625-755-289','SEAT','PC'),
('425-655-689','ASSU','PC'),
('AVC-SAD-TAK','WUHU','LAPTOP'),
('AVC-SAD-NIE','WUU','LAPTOP'),
('RTY-HRA-BUE','SMASUNG','LAPTOP'),
('FGH-VDE-BGT','SONY','LAPTOP'),
('FGR-SWD-TRH','YNOS','LAPTOP'),
('TWG-TSK-ZKS','HP','LAPTOP'),
('RPK-WDP-BGC','PANASONUC','LAPTOP'),
('123-SAD-456','HP','DRUKARKA'),
('123-FDG-456','HD','DRUKARKA'),
('168-SQD-416','TRIN','DRUKARKA'),
('567-XXX-578','SONO','DRUKARKA'),
('875-GTH-321','TUTEGO','DRUKARKA'),
('347-HGY-897','BABEN','DRUKARKA'),
('890-HDD-567','PH','DRUKARKA'),
('CFS-WER-YER','HP','PC'),
('HSD-ACA-GFD','ACER','PC'),
('KJH-QWE-VCX','MSI','PC'),
('SAA-FWE-OIW','SAMSUNG','PC'),
('GAD-GSA-JDF','DELL','PC'),
('ZVZ-DFG-RUR','TOSHIBA','PC'),
('GDF-OYT-FHG','LENOVO','PC'),
('GDF-BCV-GFD','DELL','Laptop'),
('BCV-FGD-WRE','ACER','Laptop'),
('HFG-FDS-WER','ACER','Laptop'),
('MNB-KHJ-FDS','HP','Laptop'),
('GHJ-MBN-BVC','LENOVO','Laptop'),
('NBV-VXC-TRE','SAMSUNG','Laptop'),
('IUY-GHJ-BCV','ASUS','Laptop'),
('ERE-HFF-NBV','CANON','Drukarka'),
('HDF-SGD-MNB','HP','Drukarka'),
('QRQ-DFG-RTY','BROTHER','Drukarka'),
('BCV-GSD-UTT','HP','Drukarka'),
('VZX-MVB-HGF','SAMSUNG','Drukarka'),
('BCV-GDF-JHG','BROTHER','Drukarka'),
('CZX-SDF-CVN','CANON','Drukarka'),
('AB1-AB1-AB1','ASUS','PC'),
('QWE-QWE-QWE','ASUS','PC'),
('12E-WER-FR4','HP','PC'),
('AW1-12D-R3F','HP','PC'),
('RE3-GR4-BBE','ACER','PC'),
('12D-VFR-445','ACER','PC'),
('2SD-12S-35H','TOSCHIBA','PC'),
('48F-IK5-P6G','ASUS','Laptop'),
('EK4-KFM-59G','ASUS','Laptop'),
('KEK-45O-PL5','LENOVO','Laptop'),
('SK4-97K-KTM','LENOVO','Laptop'),
('57H-LRJ-87H','DELL','Laptop'),
('58H-94M-PDL','DELL','Laptop'),
('4K5-9R8-LFK','DELL','Laptop'),
('TY5-RN5-K5N','HP','Drukarka'),
('MDN-5KF-M5N','HP','Drukarka'),
('NDM-MEK-45M','EPSON','Drukarka'),
('AK4-LFK-5OG','EPSON','Drukarka'),
('RK5-LTP-6OT','EPSON','Drukarka'),
('DN5-RK6-5OT','CANON','Drukarka'),
('AN4-6OG-68H','CANON','Drukarka')



INSERT INTO PC(SN, Procesor, Pamiec_RAM, Dysk_SSD, Dysk_HDD, Predkosc_CD, Cena)
VALUES
('ASD-ASD-ASF',900, 16, 1000, 2, '32x', 1000),
('AWE-GAW-GAW',1800, 4, 1500, 4, '32x', 1450),
('GAW-24T-FZA',4600, 8, 1000, 1, '32x', 2500),
('234-WER-RWE',3600, 16, 1500, 3, '48x', 4500),
('WER-WER-324',5500, 32, 2000, 8, '48x', 6500),
('314-124-QWE',1500, 64, 1500, 4, '32x', 2450),
('QEF-ASD-QRQ',1400, 8, 1000, 1, '48x', 3500),
('216-000-264', 4000, 8, 128, 2, '16x', 3500.00),
('985-000-125', 3800, 12, 400, 1, '8x', 3900.00),
('741-000-565', 2000, 8, 256, 1, '4x', 1499.99),
('895-000-675', 5000, 32, 128, 1, '32x', 800.00),
('984-000-777', 4200, 8, 1000, 2, '48x', 5200.00),
('959-001-974', 2500, 16, 512, 2, '48x', 3999.99),
('745-001-771', 3000, 4, 128, 1, '32x', 2000.00),
('21398HRF2983H',1500, 16, 1000, 4, '32x', 1450),
('G20893J239UEE',4500, 8, 500, 1, '32x', 2500),
('HBGJM548490JF',3000, 32, 2000, 3, '48x', 4500),
('GM3459034JNF4',5000, 64, 1500, 8, '48x', 6500),
('GM3490F32N2U4',2500, 16, 1000, 4, '32x', 2450),
('GM349324GF34F',3500, 4, 500, 1, '48x', 3500),
('GM54GF45F344T',500, 4, 500, 2, '32x', 1000),
('5PM-A05-NUN',4900, 8, 1500, 3, '32x', 4499),
('W4I-TFL-BC3',4400, 16, 2000, 4, '32x', 4299),
('T9T-9FX-885',4500, 4, 1500, 4, '48x', 3999),
('A13-XJ2-XKP',2900, 16, 1000, 2, '48x', 2499),
('K64-K1M-9JR',2300, 32, 500, 2, '32x', 2499),
('C8E-M96-MXH',1800, 16, 1500, 2, '48x', 3999),
('OTS-RMB-O5J',2200, 32, 500, 1, '32x', 2000),
('AAA-BBB-CCC',1700, 4, 1500, 4, '32x', 1400),
('CCC-BBB-AAA',4800, 8, 1000, 1, '32x', 2700),
('111-222-333',4200, 16, 1500, 3, '48x', 4700),
('444-555-666',5500, 32, 2000, 8, '48x', 6500),
('555-666-777',1500, 64, 1500, 4, '32x', 2450),
('QAZ-XSW-EDC',1400, 8, 1000, 1, '48x', 3500),
('QWE-ASD-ZXC',1000, 16, 1000, 2, '32x', 1100),
('BFD-324-SDF',1800, 4, 2000, 2, '32x', 2200),
('MKK-WET-RRE',3000, 12, 1200, 1, '32x', 3750),
('OHJ-VUR-K9F',3800, 8, 1000, 4, '48x', 1200),
('FJ3-VN9-QWE',3100, 32, 1500, 4, '48x', 2360),
('GPZ-VJ6-GJ2',4200, 24, 1400, 5, '32x', 2345),
('BFD-324-SDF',1200, 8, 1000, 2, '48x', 2455),
('MKK-WET-RRE',500, 32, 1000, 3, '32x', 3250),
('001-001-001',1200,4,1000,6,'16x',1400),
('012-040-666',4200,8,500,4,'32x',5600),
('100-080-609',3200,4,1600,8,'16x',4200),
('010-800-609',4800,16,1000,6,'24x',6200),
('001-008-609',3200,8,1400,6,'8x',4500),
('010-800-619',5000,32,250,4,'48x',7400),
('001-008-650',3600,8,120,6,'64x',4750),
('619-761-007',2500,4,1024,4,'48x',7000),
('907-880-111',3200,64,512,8,'32x',2300),
('777-921-003',2000,32,128,1,'32x',800),
('913-006-549',4200,16,256,1,'32x',1000),
('846-999-107',4500,8,512,4,'32x',4500),
('611-216-947',1750,32,64,2,'32x',1200),
('031-103-640',4000,8,512,8,'48x',6000),
('D7H-D3K-2J8',1900, 2, 1500, 1, '32x', 1480),
('L67-D45-1JJ',4700, 8, 1000, 2, '32x', 2550),
('LOP-DAY-876',3500, 16, 1500, 3, '32x', 4550),
('777-JHG-BFG',5400, 32, 2000, 5, '48x', 6550),
('LAP-PAL-WAL',1400, 4, 1500, 2, '32x', 2480),
('098-HFG-ASD',1300, 8, 1000, 3, '48x', 3535),
('QMP-PMQ-ERT',1000, 2, 1000, 1, '32x', 1200),
('001-000-001',1700, 4, 1500, 4, '32x', 1450),
('001-000-002',4500, 16, 1500, 1, '32x', 4500),
('001-000-003',3000, 16, 1500, 3, '48x', 3900),
('001-000-004',5500, 32, 2000, 8, '48x', 6600),
('001-000-005',2000, 64, 1500, 4, '32x', 3450),
('001-000-006',1300, 8, 1000, 1, '48x', 3500),
('001-000-007',1000, 16, 1000, 1, '32x', 1000),
('123-456-789',2137,8,125,1,'20x', 2100),
('125-356-759',2133,16,250,2,'30x', 4100),
('133-446-789',4000,32,500,3,'50x', 5000),
('523-556-589',2100,8,125,1,'40x', 2999),
('525-555-589',4200,16,500,3,'40x', 4789),
('625-755-289',3600,32,250,1,'30x', 5549),
('425-655-689',6000,64,1000,4,'60x', 12000),
('CFS-WER-YER',2600, 12, 2000, 2, '48x', 2000),
('HSD-ACA-GFD',4500, 6, 1500, 1, '32x', 5500),
('KJH-QWE-VCX',4400, 32, 4000, 4, '32x', 4500),
('SAA-FWE-OIW',3500, 16, 1000, 6, '32x', 3500),
('GAD-GSA-JDF',2100, 8, 3500, 2, '48x', 2500),
('ZVZ-DFG-RUR',3200, 4, 2000, 4, '48x', 1200),
('GDF-OYT-FHG',3000, 12, 1000, 3, '32x', 3000),
('AB1-AB1-AB1',3200, 4, 128, 1, '32x', 4500),
('QWE-QWE-QWE',3200, 4, 320, 4, '32x', 5000),
('12E-WER-FR4',8400, 6, 256, 8, '32x', 4000),
('AW1-12D-R3F',8400, 6, 256, 4, '48x', 1000),
('RE3-GR4-BBE',3200, 8, 512, 2, '48x', 1500),
('12D-VFR-445',3200, 8, 1024, 2, '48x', 3000),
('2SD-12S-35H',4000, 16, 1024, 2, '48x', 3500)


INSERT INTO Laptopy(SN, Procesor, Pamiec_RAM, Dysk_SSD, Dysk_HDD, Ekran, Cena)
VALUES
('WEA-32R-FS4',2500, 32, 1500, 3, 16, 2900),
('AWF-4TR-GGD',3500, 16, 1000, 2, 18, 3500),
('FAF-4FV-WVS',3500, 16, 3500, 4, 24, 4800),
('SAD-FSD-BBB',4500, 32, 4500, 5, 26, 4900),
('190-ASD-VDV',3500, 8, 1500, 6, 16, 3450),
('FFD-VSC-425',5500, 16, 1500, 2, 18, 4500),
('SDF-SCS-BG4',1500, 64, 2500, 4, 24, 4250),
('656-123-048', 4000, 12, 128, 2, 15.6, 4000.00),
('158-123-242', 4500, 8, 256, 2, 17, 4800.00),
('644-123-467', 2500, 4, 64, 1, 13, 1300.00),
('143-123-145', 3200, 6, 128, 2, 14, 3500.00),
('345-123-148', 3000, 8, 256, 1, 15.6, 3800.00),
('242-124-658', 4200, 16, 512, 2, 17, 4999.99),
('543-124-678', 5000, 6, 1000, 2, 17, 5999.00),
('GMN34099FJ493',1500, 16, 1000, 4, 16, 1450),
('GM3940394JF43',4500, 8, 500, 1, 18, 2500),
('GM34290JF4394',3000, 32, 4000, 3, 24, 5500),
('GM3940394JF43',5000, 64, 5000, 8, 26, 7500),
('543RNF34N9834',2500, 16, 1000, 4, 16, 2450),
('GMN34099FJ493',3500, 8, 500, 1, 18, 1500),
('GM34290JF4394',1000, 32, 4000, 3, 24, 3250),
('I8U-Z6D-Z9P',4200, 64, 4000, 5, 24, 5199),
('46J-H27-BWD',4300, 32, 2000, 3, 24, 3500),
('HZ2-N7T-SZC',3500, 8, 1000, 1, 24, 2599),
('GTK-K41-0R9',4500, 32, 1500, 2, 26, 4999),
('GR2-IXA-G5O',3500, 16, 2500, 3, 28, 3449),
('8DB-0Y0-ZZD',5500, 32, 3500, 4, 18, 4499),
('PJS-UE7-HZ2',1500, 64, 4000, 5, 24, 5299),
('ZXC-ASD-QWE',2500, 32, 1500, 3, 16, 2900),
('WSX-EDC-RFV',3500, 16, 1000, 2, 18, 3500),
('XSW-CDE-RFV',3500, 16, 3500, 4, 24, 4800),
('SXW-EDC-VFR',4800, 32, 4500, 6, 26, 5200),
('SDF-XCV-WER',3500, 8, 1500, 6, 16, 3450),
('ERT-DFG-CVB',5500, 16, 1500, 2, 18, 4500),
('RTY-FGH-VBN',1500, 64, 2500, 4, 24, 4250),
('AWD-QWE-EWF',3000, 8, 1000, 2, 15, 2999),
('CXZ-F23-XCV',2500, 12, 500, 3, 17, 4200),
('AWD-QWE-EWF',4500, 4, 2000, 4, 20, 2230),
('CXZ-F23-XCV',3000, 32, 1500, 5, 32, 7500),
('AWD-QWE-EWF',1200, 24, 2500, 1, 15, 3555),
('CXZ-F23-XCV',5000, 6, 500, 2, 17, 3500),
('AWD-QWE-EWF',1500, 12, 1000, 3, 24, 5000),
('123-123-456',2600,4,1300,6,15.6,3500),
('321-321-321',3000,6,1200,8,14,3949.99),
('321-321-320',3200,8,1500,4,15.6,4100),
('321-321-319',3600,16,500,8,15.6,3900),
('321-321-318',4000,4,250,2,14,4400),
('321-321-317',3200,8,2000,8,15.6,3700),
('321-321-316',3600,16,1000,6,15.6,4500),
('148-123-483',3500,16,128,4,15,2500),
('640-873-991',4800,4,256,1,18,1600),
('830-558-733',2800,8,512,1,18,3700),
('750-354-950',4200,4,256,10,16,5100),
('147-548-366',4500,8,512,2,16,4500),
('777-953-117',1750,32,64,8,32,1200),
('746-591-050',4000,64,512,10,8,6000),
('MNM-POP-IUI',2600, 8, 256, 1, 17, 2900),
('865-093-487',3200, 16, 256, 2, 15, 3500),
('FEL-341-0IB',2500, 32, 500, 4, 22, 5550),
('ALC-5GB-8JK',4500, 32, 500, 5, 25, 5250),
('JW1-098-WIS',3500, 8, 128, 2, 13, 3250),
('AWS-PLL-SPA',5500, 16, 128, 2, 17, 4520),
('EEE-XCV-999',1500, 12, 256, 1, 18, 4250),
('002-000-001',2000, 32, 1500, 3, 16, 2500),
('002-000-001',4000, 16, 2000, 2, 18, 4500),
('002-000-001',2500, 8, 3500, 4, 16, 4500),
('002-000-001',4500, 32, 4500, 5, 26, 4800),
('002-000-001',3000, 16, 2000, 6, 16, 4200),
('002-000-001',5000, 16, 1500, 2, 18, 4800),
('002-000-001',2000, 64, 2500, 4, 24, 4100),
('AVC-SAD-TAK',2467,8,125,1,13, 3000),
('AVC-SAD-NIE',2137,4,125,1,13, 2900),
('RTY-HRA-BUE',5894,8,250,1,15, 3000),
('FGH-VDE-BGT',2345,16,250,1,15, 3500),
('FGR-SWD-TRH',4568,16,500,1,15, 4500),
('TWG-TSK-ZKS',5000,16,500,2,17, 5000),
('RPK-WDP-BGC',6500,32,500,2,17, 10000),
('GDF-BCV-GFD',4400, 8, 2000, 4, 22, 3000),
('BCV-FGD-WRE',2800, 12, 3000, 3, 24, 4500),
('HFG-FDS-WER',3600, 16, 2500, 2, 28, 4000),
('MNB-KHJ-FDS',5000, 32, 4000, 6, 19, 2800),
('GHJ-MBN-BVC',3200, 64, 2000, 3, 23, 3500),
('NBV-VXC-TRE',2600, 32, 1000, 4, 21, 3800),
('IUY-GHJ-BCV',1800, 8, 4500, 1, 26, 3200),
('48F-IK5-P6G',3200, 8, 1024, 2, 15.6, 3000),
('EK4-KFM-59G',3200, 8, 1024, 2, 15.6, 4000),
('KEK-45O-PL5',3200, 8, 1024, 8, 17.1, 5000),
('SK4-97K-KTM',2500, 16, 512, 1, 17.1, 2000),
('57H-LRJ-87H',2500, 16, 512, 4, 14, 5000),
('58H-94M-PDL',4200, 32, 512, 4, 14, 2000),
('4K5-9R8-LFK',4200, 32, 512, 4, 14, 4000)

INSERT INTO Drukarki(SN, Format_papieru, Kolor, Typ, Cena)
VALUES
('QR3-WFW-FWF', 'A3', 0, 'atrament', 1000),
('WEF-ASF-GWG', 'A2', 1, 'laser', 2000),
('FQE-ASF-4RF', 'A4', 1, 'laser', 3000),
('CAF-FAE-4FS', 'A1', 0, 'laser', 4000),
('VAE-VRR-3RF', 'A4', 1, 'laser', 4500),
('GSD-DFE-GAG', 'A2', 1, 'atrament', 3500),
('ZVX-VSV-ADF', 'A4', 1, 'atrament', 3900),
('ABC-456-SWG', 'A3', 1, 'laser', 1000.00),
('ABC-456-JTF', 'A4', 1, 'atramentowa', 850.00),
('ABC-456-RAA', 'A4', 0, 'atramentowa', 400.00),
('ABC-456-LUJ', 'A3', 0, 'termiczna', 999.99),
('ABC-456-EHW', 'A2', 1, 'laser', 1799.00),
('BCD-456-ULE', 'A0', 1, 'laser', 8500.00),
('BCD-456-QWE', 'A3', 0, 'ig�owa', 2400.00),
('NFMGI90FG9434', 'A4', 1, 'laser', 5000),
('12SDBN2173YUD', 'A3', 0, 'atrament', 3000),
('132RF17N2SH23', 'A1', 0, 'laser', 2000),
('12SDBN2173YUD', 'A2', 1, 'atrament', 1000),
('NFMGI90FG9434', 'A5', 0, 'atrament', 7000),
('132RF17N2SH23', 'A3', 1, 'laser', 8000),
('VG4983HF938F4', 'A2', 0, 'laser', 9000),
('XP4-09P-JOC', 'A4', 0, 'atrament', 999),
('3B3-5MB-WMU', 'A4', 0, 'laser', 1999),
('BYP-WZI-8F3', 'A3', 1, 'atrament', 2999),
('H30-XAT-36G', 'A3', 1, 'atrament', 2999),
('TYT-968-N4T', 'A1', 1, 'laser', 4999),
('H0J-MUA-FB2', 'A3', 0, 'laser', 1999),
('68F-N88-82B', 'A2', 1, 'atrament', 3199),
('TYU-GHJ-BNM', 'A3', 0, 'atrament', 1000),
('UIO-JKL-IOP', 'A2', 1, 'laser', 2000),
('KLA-NMZ-OPQ', 'A4', 1, 'laser', 3000),
('ASD-SSF-FDF', 'A1', 0, 'laser', 4000),
('DAS-FDS-HJG', 'A4', 1, 'laser', 4500),
('RWE-HFG-CXZ', 'A2', 1, 'atrament', 3500),
('POI-JGH-VCX', 'A4', 1, 'atrament', 3900),
('JGR-45T-3RS', 'A2', 1, 'atrament', 1500),
('FE4-FRH-5YH', 'A4', 0, 'laser', 900),
('FDG-H5H-DVB', 'A2', 1, 'atrament', 1200),
('DFB-5GD-BGY', 'A3', 0, 'laser', 2000),
('JGR-45T-3RS', 'A1', 1, 'laser', 2450),
('FE4-FRH-5YH', 'A2', 1, 'atrament', 1250),
('DFB-5GD-BGY', 'A4', 0, 'laser', 1000),
('ABC-456-XXX','A4',0,'Laser',699.99),
('CCC-690-0B1','A4',1,'Atrament',889),
('ABC-456-XYW','A4',1,'Atrament',950),
('CCC-690-0B2','A4',1,'Atrament',849),
('ABC-456-XYT','A4',0,'Laser',650),
('CCC-690-0B3','A4',1,'Atrament',789.9),
('ABC-456-XYU','A4',1,'Laser',995),
('568-247-874','A3',1,'laserowa',1400),
('321-841-958','A4',0,'atramentowa',300),
('945-328-740','A4',1,'atramentowa',1500),
('548-650-010','A4',1,'laserowa',800),
('405-700-001','A6',1,'atramentowa',1900),
('198-840-395','A1',0,'atramentowa',5800),
('874-611-009','C6',0,'laserowa',700),
('MMM-NVB-000', 'A4', 1, 'laser', 2500),
('ABC-III-JHG', 'A4', 0, 'atrament', 1000),
('FAA-ICA-OSP', 'A3', 1, 'atrament', 3500),
('PQK-888-760', 'A2', 0, 'laser', 4200),
('VVA-09J-SAS', 'A1', 1, 'laser', 4300),
('LEA-PGE-NXG', 'A4', 0, 'atrament', 3400),
('AQA-909-BBB', 'A3', 1, 'atrament', 3850),
('003-000-001', 'A4', 1, 'atrament', 1200),
('003-000-002', 'A3', 1, 'laser', 2200),
('003-000-003', 'A3', 0, 'laser', 2500),
('003-000-004', 'A2', 1, 'atrament', 4100),
('003-000-005', 'A1', 1, 'laser', 4600),
('003-000-006', 'A4', 0, 'atrament', 1000),
('003-000-007', 'A3', 1, 'laser', 3500),
('123-SAD-456','A4',1,'laser',2000),
('123-FDG-456','A5',1,'laser',900),
('168-SQD-416','A4',0,'atrament',1500),
('567-XXX-578','A2',0,'laser',3000),
('875-GTH-321','A4',1,'atrament',1800),
('347-HGY-897','A3',0,'atrament',2500),
('890-HDD-567','A4',1,'laser',2100),
('ERE-HFF-NBV', 'A4', 1, 'laser', 1200),
('HDF-SGD-MNB', 'A3', 1, 'atrament', 800),
('QRQ-DFG-RTY', 'A2', 0, 'atrament', 1000),
('BCV-GSD-UTT', 'A4', 1, 'laser', 2000),
('VZX-MVB-HGF', 'A3', 0, 'laser', 900),
('BCV-GDF-JHG', 'A4', 1, 'laser', 1500),
('CZX-SDF-CVN', 'A4', 1, 'atrament', 3000),
('TY5-RN5-K5N', 'A2', 1, 'atramentowa', 600),
('MDN-5KF-M5N', 'A2', 0, 'atramentowa', 600),
('NDM-MEK-45M', 'A3', 1, 'atramentowa', 1000),
('AK4-LFK-5OG', 'A3', 1, 'atramentowa', 1000),
('RK5-LTP-6OT', 'A1', 1, 'laserowa', 1500),
('DN5-RK6-5OT', 'A1', 1, 'laserowa', 3000),
('AN4-6OG-68H', 'A0', 1, 'laserowa', 3200)