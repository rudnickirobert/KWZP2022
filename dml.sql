USE KWZP
GO

INSERT INTO Wyksztalcenie (Nazwa)
VALUES
('Podstawowe'),
('Średnie branżowe'),
('Średnie'),
('Inżynier'), 
('Wyższe')

INSERT INTO Pracownik (Nazwisko, Imie, Nr_dowodu, Pesel, Wyksztalcenie)
VALUES
('Nowak','Jan','AAA00000','550500000',1),
('Marszał','Grzegorz','ABC20000','8809010000',2),
('Gont','Józef','RF004050','9703040000',3),
('Markowska', 'Anna', 'ABC00020','8806360300',1),
('Pawlak','Katarzyna','GDE00900','9004120000',2),
('Kowalczylk','Adam','UJG02033','9905170780', 3),
('Andrzejewski', 'Michał',' DCE986557','7907290003',1),
('Krawczyk', 'Karol', 'GDT80967','9005000450',2),
('Wieczorek', 'Laura', 'HNR23123','8705050000',3),
('Baran', 'Szymon', 'MFN67926','9905006800',1),
('Wilk', 'Zuzanna', 'MDK85609','6805045067',2),
('Sadowski', 'Aleksander', 'NFL48923','9805005680',3),
('Borkowska', 'Zofia', 'LDG57291','7605004500',1),
('Sikora', 'Julia', 'LFB57823','8505008700',2),
('Nowicki', 'Filip', 'LAP46723','9505065700',3),
('Duda', 'Wojciech', 'PKE95123','9805067000',1),
('Grabowski', 'Stanisław', 'LDH65793','9205000890',1)

INSERT INTO Dane_adresowe_pracownik (ID_pracownik, Miejscowosc, Ulica, Nr_budynku, Nr_lokalu, Kod_pocztowy, Data_od)
VALUES
(1, 'Warszawa', 'Jana Pawła II', '21', '37', '02137', '2021-04-14'),
(2, 'Marki', 'Markowa', '23', '11', '12000', '2019-08-14'),
(3, 'Warszawa', 'Kombatantów', '6', '26', '11500', '2020-02-13'),
(4, 'Warszawa', 'Królowej Jadwigi', '11', '20', '02347', '2020-04-19'),
(5, 'Warszawa', 'Kościuszki', '51', '32', '02952', '2018-10-02'),
(6, 'Marki', 'Długa', '1', '1', '12301','2019-03-09'),
(7, 'Warszawa', 'Krótka', '2','2','02022','2021-06-11'),
(8, 'Warszawa', 'Średnia', '3','3','01437','2021-06-11'),
(9, 'Warszawa', 'Kaliskiego', '2', '11', '01534','2020-02-11'),
(10, 'Warszawa', 'Górczewska', '11', '20', '03321','2020-01-13'),
(11, 'Marki', 'Naturalna', '21', '36', '08808', '2018-07-13'), 
(12, 'Pruszków', 'Wiejska', '13', '32', '11111','2017-05-13'),
(13, 'Warszawa',' Połczyńska', '2','33', '01910','2018-01-01'),
(14, 'Warszawa', 'Al. Jerozolimskie', '5','10', '02147', '2017-01-01'),
(15, 'Pruszków', 'Marszałkowska', '1', '1', '03332', '2019-01-01'),
(16, 'Pruszków', 'Prosta', '27', '22', '01712', '2020-01-01'),
(17, 'Pruszków', 'Karolkowa' ,'3', '34', '04543', '2022-01-01')

INSERT INTO Nr_telefon_pracownik (ID_pracownik, Numer, Data_od)
VALUES
(1,'123123123','2022-01-01'),
(2,'321321321','2022-02-01'),
(3,'456456456','2021-12-10'),
(4,'321321321','2020-05-01'),
(5,'321321321','2021-06-01')


INSERT INTO Czynnosc_produkcyjna (Nazwa)
VALUES
('Przygotowanie stanowiska'),
('Skanowanie'),
('Drukowanie'),
('Szlifowanie'),
('Klejenie'),
('Skladanie');

INSERT INTO Rodzaj_kontrola (Rodzaj_kontrola, Procedura)
VALUES
('Wymiarowa', 'Dokonac pomiaru najwazniejszych wymiarow'),
('Wzrokowa', 'Ogolne ogledziny otrzymanego produktu'),
('Badanie twardosci', 'Dokonac pomiaru twardosci badanego produktu'),
('Badanie chropowatosci', 'Okreslic chropowatosc uzyskanej powierzchni'),
('Wytrzymalosciowa', 'Poddac produkt obciazeniu probnemu');

INSERT INTO Rezultat_kontrola (Wynik)
VALUES
('Pozytywny'),
('Negatywny - do porawy'),
('Do utylizacji');

INSERT INTO Slownik_stanowisko (Nazwa_stanowiska)
VALUES
('Stanowisko do skanowania'),
('Stanowisko do drukowania FDM'),
('Stanowisko do drukowania SLS'),
('Stanowisko do drukowania SLA'),
('Stanowisko do szlifowania'),
('Stanowisko do laczenia polproduktow');

INSERT INTO Produkt (Nazwa_produkt)
VALUES
('Litofanowy klosz do lampy'),
('Przekladnia zebata'),
('Tapicerka samochodowa'),
('Obudowa PC'),
('Kostka rubika');

INSERT INTO Slownik_polprodukt (Nazwa)
VALUES
('Obudowa PC'),
('Wal czynny'),
('Wal bierny'),
('Obudowa przkladnia'),
('Elementy montazowe - kostka'),
('Klosz fi150'),
('Mocowanie chlodzenia'),
('Maskownica do kabli'),
('Elementy powierzchniowe');

INSERT INTO Sklad_produkt (ID_produkt, ID_polprodukt, Liczba)
VALUES
(1,6,1),
(2,2,1),
(2,3,2),
(2,4,1),
(3,9,4),
(4,7,2),
(4,8,3),
(5,5,5);


INSERT INTO Narzedzie (Nazwa_narzedzie)
VALUES
('Srubokret plaski'),
('Kombinerki'),
('Noz'),
('Nozyczki'),
('Suwmiarka'),
('Klucz francuski');

INSERT INTO Rodzaj_material (Nazwa_rodzaj_material)
VALUES
('ABS'),
('PLA'),
('PETG'),
('Proszek stali 316L'),
('Nylon PA12'),
('Zywica termoutwardzalna'),
('Klej')

INSERT INTO Rodzaj_maszyna (Nazwa_rodzaj_maszyna, Opis)
VALUES
('Drukarka FDM','Drukowanie przy wykorzystaniu technologii FDM'),
('Drukarka SLA','Drukowanie przy wykorzystaniu technologii SLA'),
('Drukarka SLS','Drukowanie przy wykorzystaniu technologii SLS'),
('Skaner 3D',NULL),
('Drukarka laserowa','Laserowa'),
('PC','Komputer stacjonarny');

INSERT INTO Rodzaj_czesc (Nazwa_rodzaj_czesc)
VALUES
('Ekstruder'),
('Rama'),
('Platforma robocza'),
('Glowica drukarki'),
('Kolo zebate'),
('Silnik krokowy'),
('Stolik obrotowy'),
('Glowica optyczna'),
('Obiektyw'),
('Glowica lasera'),
('Ekran LCD'),
('Wentylator'),
('Zgarniacz');

INSERT INTO Rodzaj_obsluga(Nazwa_rodzaj_obsluga)
VALUES
('Wymiana czesci'),
('Czyszczenie'),
('Kontrola stanu'),
('Kalibracja'),
('Smarowanie');

INSERT INTO Status_zamowienie(Nazwa_status)
VALUES
('Zamowiono'),
('W trakcie realizacji'),
('Dostarczono'),
('Odebrano');

INSERT INTO Jednostka (Nazwa_jednostka, Skrot)
VALUES
('Milimetr','mm'),
('Gram','g'),
('Megapascal','MPa'),
('Sekunda','s'),
('Gram na centymetr szescienny','g/cm3'),
('Stopien Celsjusza','oC'),
('Decybel','dB'),
('Metr na sekunde do kwadratu','m/s2'),
('Wat','W');



INSERT INTO Rodzaj_parametr (Nazwa_rodzaj_parametr, ID_Jednostka)
VALUES
('Gestosc',5),
('Dlugosc',1),
('Szerokosc',1),
('Srednica',1),
('Masa',2),
('Temperatura stolu roboczego',6),
('Glosnosc pracy',7),
('Predkosc druku', 8),
('Predkosc przejazdow jalowych', 8),
('Temperatura przechowywania',6),
('Maksymalny pobór mocy',9);


INSERT INTO Parametr_produkt(ID_produkt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,149,151),
(2,2,299,301),
(3,3,99,102),
(3,2,99,100),
(4,5,30000,35000),
(4,2,99,100),
(5,1,3,4),
(5,5,1000,3000),
(2,1,1,3),
(1,2,100,105),
(5,4,35,36),
(3,1,48,51);

INSERT INTO Parametr_polprodukt (ID_polprodukt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,3,45,50),
(2,3,40,45),
(2,1,1,4),
(3,2,99,100),
(3,3,50,55),
(4,5,30000,35000),
(4,2,99,100),
(5,2,39,45),
(5,4,30,35),
(1,4,80,90),
(4,3,40,45),
(5,3,120,121);

INSERT INTO Material (ID_rodzaj_material, Nazwa_material)
VALUES
(4,'Proszek S316L DRUTEX'),
(1,'Filament Czarny ABS Black'),
(3,'Filament Zolty PETG Stakchovsky'),
(2,'Filament Czerwony PLA Podraskov'),
(2,'Filament Niebieski PLA POODZIAN');

INSERT INTO Sklad_polprodukt (ID_polprodukt, ID_material, Liczba)
VALUES
(1,5,2),
(2,2,1),
(3,3,4),
(2,4,1),
(3,2,1),
(4,1,3),
(4,3,2),
(5,5,4);

INSERT INTO Czesc (Nazwa_czesc, ID_rodzaj_czesc)
VALUES
('Ekstruder Bondtech phi0.4',1),
('Kolo zebate phi60',5),
('Rama i3 MK3S+',2),
('Glowica i3 MK3S+',4),
('Stol i3 MK3S+',3),
('Stolik Shining', 6),
('Glowica skanera Shining',7),
('Obiektyw Canon',8),
('Rama Ender5',2),
('Glowica Ender5',4),
('Stol Ender5',3),
('Zgarniacz b0bll',12),
('Ekran LG',10),
('Ekran HP',10),
('Wentylator IDZ',11),
('Ekstruder Bondtech phi0.1',1),
('Ekstruder Bondtech phi0.2',1),
('Silnik krokowy KROK',6),
('Glowica lasera LG', 9);


INSERT INTO Maszyna (Nazwa_maszyna, ID_rodzaj_maszyna, Koszt_RBG)
VALUES
('PRUSA i3 MK3S+',1,200),
('Shining 3D EinScan SE',4,150),
('Sinterit Lisa 2 Pro',3,500),
('Anycubic Photon Mono X',2,250),
('Creality Ender-5 Pro',1,200);

INSERT INTO Nr_seryjny (Nr_seryjny)
VALUES
('000-001'),
('000-002'),
('000-003'),
('000-004'),
('000-005');

INSERT INTO Maszyna_nr_seryjny (ID_maszyna, ID_nr_seryjny)
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5);

INSERT INTO Stanowisko_produkcyjne (ID_nazwa_stanowiska)
VALUES
(2),
(3),
(1),
(4),
(5);

INSERT INTO Sklad_stanowisko_produkcyjne_maszyna (ID_stanowisko_produkcyjne, ID_maszyna_nr)
VALUES
(2,1),
(3,2),
(1,5),
(4,3),
(5,4);

INSERT INTO Sklad_stanowisko_produkcyjne (ID_stanowisko_produkcyjne, ID_narzedzie)
VALUES
(3,1),
(3,3),
(2,5),
(4,2),
(5,2);

INSERT INTO Dostawca (Nazwa_dostawca)
VALUES
('Marinex'),
('Druczex'),
('Polex'),
('Brexus'),
('Blablin');

INSERT INTO Dane_adresowe_dostawca (ID_dostawca, Miejscowosc, Ulica, Nr_budynku, Kod_pocztowy)
VALUES
(1,'Warszawa','Dzwigowa',12,01-376),
(2,'Warszawa','Swietlikow',5,01-358),
(3,'Warszawa','Gorna',3,04-413),
(4,'Skierniewice','Dluga',4,96-100),
(5,'Nadarzyn','Blonska',1,05-830);

INSERT INTO Producent (Nazwa_producenta, Opis)
VALUES
('PRUSA',NULL),
('Shining3D',NULL),
('Sinterit',NULL),
('Anycubic',NULL),
('CREALITY ',NULL);

INSERT INTO Dane_adresowe_producent (ID_producent, Miejscowosc, Ulica, Nr_budynku, Kod_pocztowy)
VALUES
(1,'Praga','Partyzanska',7,NULL),
(2,'Stuttgart','Breitwiesenstrasse',28,70565),
(3,'Krakow','Nad Drwina',10,30-741),
(4,'Hongkong','Chatham Road South',45,NULL),
(5,'Shenzhen','Meilong Blvd.', 18,518131);

INSERT INTO Parametr_material (ID_material, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,1,4,4),
(2,4,1.75,1.75),
(3,4,1.75,1.75),
(4,4,2.25,2.25),
(5,4,1.75,1.75);

INSERT INTO Klient (Nazwisko, Imie, NIP)
	VALUES 
	('Marczak', 'Marek', NULL),
	('Adamiak', 'Adam', NULL),
	('Nowak', 'Karol', NULL),
	('Kowalski', 'Jan', NULL),
	('Lewandowski', 'Robert', NULL);

INSERT INTO Email_klient (ID_klient, Email, Data_od, Data_do)
	VALUES
	(1, 'marczak.marek@drukarczyk.com', '2022-01-01', NULL),
	(2, 'adamiak.adam@drukarczyk.com', '2022-01-01', NULL),
	(3, 'nowak.karol@drukarczyk.com', '2022-01-01', NULL),
	(4, 'kowalski.jan@drukarczyk.com', '2022-01-01', NULL),
	(5, 'lewandowski.robert@drukarczyk.com', '2022-01-01', NULL);

INSERT INTO Nr_telefon_klient (ID_klient, Numer, Data_od, Data_do)
	VALUES
	(1, 508553123, '2022-01-01', NULL),
	(2, 508553456, '2022-01-01', NULL),
	(3, 508553789, '2022-01-01', NULL),
	(4, 508553987, '2022-01-01', NULL),
	(5, 508553654, '2022-01-01', NULL);

INSERT INTO Dane_adresowe_klient (ID_klient, Miejscowosc, Ulica, Nr_budynek, Nr_lokal, Kod_pocztowy)
	VALUES
	(1, 'Warszawa', 'Warszawska', 1, NULL, '12-345'),
	(2, 'Bydgoszcz', 'Bydgoska', 1, 2, '54-321'),
	(3, 'Grójec', NULL, 1, NULL, '98-765'),
	(4, 'Żyrardów', '3 Maja', 3, 5, '32-654'),
	(5, 'Warszawa', 'Warszawska', 53, 24, '12-345');

INSERT INTO Typ_zamowienie (Typ_zamowienie)
	VALUES
	('Indywidualne'),
	('Standardowe');

--INSERT INTO Zamowienie (ID_klient, ID_pracownik, Data_zamowienie, ID_typ_zamowienie)
--	VALUES
--	(1, 1, '2022-04-04', 2),
--	(2, 2, '2022-04-05', 2),
--	(3, 2, '2022-04-06', 1),
--	(4, 3, '2022-04-07', 1),
--	(5, 4, '2022-04-08', 2);

--INSERT INTO Zamowienie_szczegol (ID_zamowienie, ID_produkt, Ilosc)
--	VALUES
--	(1, 2, 50),
--	(1, 1, 30),
--	(2, 3, 100),
--	(3, 3, 150),
--	(3, 5, 120);

INSERT INTO Gwarancja (Okres_gwarancja, Opis_gwarancja)
	VALUES 
	(2, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 2 LAT'),
	(1, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 1 ROKU'),
	(3, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 3 LAT'),
	(4, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 4 LAT'),
	(5, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 5 LAT');

INSERT INTO Status_oferta (Nazwa_status_oferta)
	VALUES
	('Zaakceptowana'),
	('Odrzucona'),
	('Do rozpatrzenia'),
	('W trakcie realizacji');

--INSERT INTO Oferta_handlowa (ID_zamowienie, ID_pracownik, Termin_realizacja, ID_gwarancja, ID_status_oferta, Cena)
--	VALUES 
--	(1, 1, 1, '2022-04-28', 1, 1, 50),
--	(2, 3, 2, '2022-04-29', 1, 1, 40),
--	(3, 2, 3, '2022-04-30', 1, 1, 30),
--	(4, 4, 4, '2022-04-27', 1, 1, 20),
--	(5, 5, 5, '2022-05-04', 1, 1, 10),
--	(1, 1, 1, '2022-05-30', 1, 2, 51);

INSERT INTO Podatek (Procent)
	VALUES
	(0),
	(8),
	(23),
	(11),
	(28);

INSERT INTO Forma_platnosc (Forma_platnosc)
	VALUES
	('Przelew'),
	('Karta płatnicza'),
	('Gotówka'),
	('BLIK'),
	('Przelew pocztowy');

--INSERT INTO Umowa_sprzedaz (ID_oferta_handlowa)
--	VALUES
--	(1),
--	(2),
--	(3),
--	(4),
--	(5);

--INSERT INTO Sprzedaz (Nr_sprzadaz, Data_sprzedaz_poczatek, Data_sprzedaz_koniec, Termin_zaplata, ID_forma_platnosc, ID_umowa_sprzedaz, Ilosc)
--	VALUES
--	(1, '2022-03-01', '2022-03-15', '2022-03-22', 1, 1, 50),
--	(2, '2022-03-02', '2022-03-16', '2022-03-23', 2, 2, 40),
--	(3, '2022-03-03', '2022-03-17', '2022-03-24', 3, 3, 31),
--	(4, '2022-03-03', '2022-03-17', '2022-03-24', 2, 4, 20),
--	(5, '2022-03-04', '2022-03-18', '2022-03-25', 1, 5, 15),
--	(6, '2022-03-01', '2022-03-15', '2022-03-22', 1, 1, 50),
--	(7, '2022-03-02', '2022-03-16', '2022-03-23', 2, 2, 40),
--	(8, '2022-03-03', '2022-03-17', '2022-03-24', 3, 3, 31),
--	(9, '2022-03-03', '2022-03-17', '2022-03-24', 2, 4, 20),
--	(10, '2022-03-04', '2022-03-18', '2022-03-25', 1, 5, 15),
--	(11, '2022-03-03', '2022-03-17', '2022-03-24', 2, 4, 20),
--	(12, '2022-03-04', '2022-03-18', '2022-03-25', 1, 5, 15);


--INSERT INTO Reklamacja (ID_pracownik, ID_sprzedaz, Data_reklamacja, Opis_reklamacja)
--	VALUES
--	(1, 6, '2022-04-01', 'Uszkodzenie mechaniczne'),
--	(3, 7, '2022-04-02', 'Rozklejenie produtku'),
--	(2, 8, '2022-04-03', 'Uszkodzenie mechaniczne'),
--	(5, 9, '2022-04-04', 'Pękniecie materiału', 1),
--	(4, 10, '2022-04-05', 'Uszkodzenie mechaniczne'),
--	(5, 11, '2022-04-01', 'Uszkodzenie mechaniczne'),
--	(4, 12, '2022-04-01', 'Uszkodzenie mechaniczne');

--INSERT INTO Zwrot (ID_reklamacja, ID_produkt, Ilosc, Akceptacja)
--	VALUES
--	(1,1,1,1),
--	(2,2,2,1),
--	(4,3,4,0),
--	(6,4,3,0),
--	(7,5,1,1);

--INSERT INTO Szczegoly_sprzedaz (ID_sprzedaz, ID_produkt, Kwota_sprzedaz, ID_podatek)
--	VALUES
--	(1, 1, 50000.00, 1),
--	(2, 2, 25000.00, 2),
--	(3, 3, 3.50, 1),
--	(4, 4, 785.98, 3),
--	(5, 5, 9870.99, 4);

INSERT INTO Parametr_czesc (ID_czesc, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,5,50,60),
(1,4,0.36,0.44),
(2,4,59,61), 
(2,5,540,580),
(3,2,350,350), 
(3,3,35,40),
(4,5,200,200), 
(4,10,10,30),
(5,2,300,300),
(5,3,290,290),
(6,7,30,40),
(6,11,450,450),
(7,5,400,400),
(7,4,60,60),
(8,4,60,60),
(8,5,300,300),
(9,2,400,400), 
(9,3,50,50),
(10,5,300,300), 
(10,10,10,30),
(11,2,330,330),
(11,3,300,300),
(12,2,200,2000),
(12,3,50,50),
(13,2,60,60), 
(13,3,60,60),
(14,2,80,80), 
(14,3,60,60),
(15,7,10,50), 
(15,5,0.2,0.2),
(16,5,40,40),
(16,4,0.08,0.12),
(17,5,40,50),
(17,4,0.18,0.22),
(18,7,10,35),
(18,5,100,100),
(19,5,500,500),
(19,10,15,24);

INSERT INTO Parametr_narzedzie (ID_narzedzie, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,19,21),
(2,5,3500,3600),
(3,2,15,15),
(4,2,13,13),
(5,2,20,20);

INSERT INTO Parametr_maszyna (ID_maszyna, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,7,30,40),
(1,8,10,100),
(1,9,200,200),
(1,10,10,40),
(2,5,20000,20000),
(2,7,20,25),
(2,10,15,25),
(2,11,1000,1000),
(3,5,150000,150000),
(3,7,10,15),
(3,10,10,40),
(3,11,2000,2000),
(4,5,15000,15000),
(4,7,10,20),
(4,10,15,25),
(4,11,700,700),
(5,7,50,60),
(5,8,10,100),
(5,9,200,200),
(5,10,10,30);

--INSERT INTO Zamowienie_material(ID_pracownik, Data, ID_dostawca)
--VALUES
--(1,13.04.2022,1),


--INSERT INTO Stan_realizacji_zamowienie_material(ID_zamowienie_material, ID_status_zamowienie, Data, ID_pracownik)
--VALUES
--(1,1,13.04.2022,1),

--INSERT INTO Szczegoly_zamowienie_material(ID_zamowienie_material, ID_material, ID_producent, Masa_kg, Cena)
--VALUES
--(1,1,1,25,4500),



--INSERT INTO Zamowienie_czesc(ID_pracownik, Data, ID_dostawca)
--VALUES
--(1,13.04.2022,1),

--INSERT INTO Stan_realizacji_zamowienie_czesc(ID_zamowienie_czesc, ID_status_zamowienie, Data, ID_pracownik)
--VALUES
--(1,1,13.04.2022,1),

--INSERT INTO Szczegoly_zamowienie_czesc(ID_zamowienie_czesc, ID_czesc, ID_producent, Sztuk, Cena)
--VALUES
--(1,1,1,5,500),



--INSERT INTO Zamowienie_narzedzie(ID_pracownik, Data, ID_dostawca)
--VALUES
--(1,13.04.2022,1),

--INSERT INTO Stan_realizacji_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_status_zamowienie, Data, ID_pracownik)
--VALUES
--(1,1,13.04.2022,1),

--INSERT INTO Szczegoly_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_narzedzie, ID_producent, Sztuk, Cena)
--VALUES
--(1,1,1,2,400),



--INSERT INTO Zamowienie_maszyna(ID_pracownik, Data, ID_dostawca)
--VALUES
--(1,13.04.2022,1),

--INSERT INTO Stan_realizacji_zamowienie_maszyna(ID_zamowienie_maszyna, ID_status_zamowienie, Data, ID_pracownik)
--VALUES
--(1,1,13.04.2022,1),

--INSERT INTO Szczegoly_zamowienie_maszyna(ID_zamowienie_maszyna, ID_maszyna_nr, ID_producent, Cena)
--VALUES
--(1,1,1,2400),


INSERT INTO Obsluga (ID_rodzaj_obsluga, ID_stanowisko_produkcyjne, Data_od, Data_do, Uwagi)
VALUES
(3,1,'2022-02-12','2022-02-14', 'Brak'),
(1,2,'2022-01-15','2022-01-22', 'Brak'),
(1,3,'2021-12-22','2021-12-31', 'Nowa czesc'),
(2,5,'2022-03-02','2022-03-22', 'Gotowe do pracy'),
(3,2,'2022-04-12','2022-04-14', 'Brak');


--INSERT Obsluga_pracownik (ID_obsluga, ID_pracownik)
--VALUES
--(1,1),

--INSERT INTO Wymiana_czesc(ID_obsluga, ID_maszyna_nr, ID_czesc)
--VALUE
--(1,1,1);


--INSERT INTO Wymiana_narzedzie(ID_obsluga, ID_maszyna_nr, ID_narzedzie)
--VALUE
--(2,2,1);

INSERT INTO Sklad_maszyna ( ID_maszyna, ID_czesc, Liczba_czesci)
VALUES
(1,3,3),
(1,4,1),
(1,5,1),
(2,6,1),
(2,7,1),
(2,8,1),
(3,19,1),
(3,15,4),
(3,18,4),
(3,12,1),
(4,15,4),
(4,14,1),
(4,18,4),
(5,9,3),
(5,10,1),
(5,11,1),
(5,13,1),
(5,17,1);
