USE KWZP
GO

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

INSERT INTO Wytworzony_produkt (ID_produkt, Data_ukonczenia)
VALUES
(1, '2022-03-22'),
(2, '2022-03-31'),
(2, '2022-04-08'),
(3, '2022-04-01'),
(4, '2022-03-29'),
(4, '2022-03-15'),
(5, '2022-04-04'),
(5, '2022-03-18'),
(5, '2022-04-11');

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


INSERT INTO Narzedzie (Nazwa)
VALUES
('Srubokret plaski'),
('Kombinerki'),
('Noz'),
('Nozyczki'),
('Suwmiarka'),
('Klucz francuski');

INSERT INTO Rodzaj_material (Nazwa)
VALUES
('ABS'),
('PLA'),
('PETG'),
('Proszek stali 316L'),
('Nylon PA12'),
('Zywica termoutwardzalna'),
('Klej')

INSERT INTO Rodzaj_maszyna (Nazwa, Opis)
VALUES
('Drukarka FDM','Drukowanie przy wykorzystaniu technologii FDM'),
('Drukarka SLA','Drukowanie przy wykorzystaniu technologii SLA'),
('Drukarka SLS','Drukowanie przy wykorzystaniu technologii SLS'),
('Skaner 3D',NULL),
('Drukarka laserowa','Laserowa'),
('PC','Komputer stacjonarny');

INSERT INTO Rodzaj_czesc (Nazwa)
VALUES
('Ekstruder'),
('Rama'),
('Platforma robocza'),
('Glowica'),
('Kolo zebate'),
('Silnik krokowy');

INSERT INTO Rodzaj_obslugi(Nazwa)
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

INSERT INTO Jednostka (Nazwa, Skrot)
VALUES
('Milimetr','mm'),
('Kilogram','kg'),
('Megapascal','MPa'),
('Sekunda','s'),
('Gram/cm3','g/cm3'),
('Stopien Celsjusza','oC');

INSERT INTO Rodzaj_parametr (Nazwa, ID_Jednostka)
VALUES
('Gestosc',1),
('Dlugosc',1),
('Szerokosc',1),
('Srednica',1),
('Masa',2),
('Temperatura stolu roboczego',6);

INSERT INTO Parametr_produkt(ID_produkt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,149,151),
(2,2,299,301),
(3,3,99,102),
(3,2,99,100),
(4,5,30,35),
(4,2,99,100),
(5,1,3,4),
(5,5,1,3),
(2,1,1,3),
(1,2,100,105),
(5,4,35,36),
(3,2,48,51);

INSERT INTO Parametr_polprodukt (ID_polprodukt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,3,45,50),
(2,3,40,45),
(2,1,1,4),
(3,2,99,100),
(3,3,50,55),
(4,5,30,35),
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
('Ekstruder Bondtech',1),
('Kolo zebate phi60',5),
('Rama i3 MK3S+',2),
('Glowica i3 MK3S+',4),
('Stol i3 MK3S+',3);

INSERT INTO Maszyna (Nazwa, ID_rodzaj_maszyna, Koszt_RBG)
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

--INSERT INTO Oferta_handlowa (ID_zamowienie, ID_pracownik, ID_produkt, Termin_realizacja, ID_gwarancja, ID_status_oferta, Ilosc)
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


--INSERT INTO Reklamacja (ID_pracownik, ID_sprzedaz, Data_reklamacja, Opis_reklamacja, Akceptacja)
--	VALUES
--	(1, 6, '2022-04-01', 'Uszkodzenie mechaniczne', 1),
--	(3, 7, '2022-04-02', 'Rozklejenie produtku', 1),
--	(2, 8, '2022-04-03', 'Uszkodzenie mechaniczne', 2),
--	(5, 9, '2022-04-04', 'Pękniecie materiału', 1),
--	(4, 10, '2022-04-05', 'Uszkodzenie mechaniczne', 2),
--	(5, 11, '2022-04-01', 'Uszkodzenie mechaniczne', 1),
--	(4, 12, '2022-04-01', 'Uszkodzenie mechaniczne', 1);

--INSERT INTO Zwrot (ID_reklamacja, ID_produkt, Utylizacja)
--	VALUES
--	(1,1,1),
--	(2,2,1),
--	(4,3,0),
--	(6,4,0),
--	(7,5,1);

--INSERT INTO Szczegoly_sprzedaz (ID_sprzedaz, Kwota_sprzedaz, ID_podatek)
--	VALUES
--	(1, 50000.00, 1),
--	(2, 25000.00, 2),
--	(3, 3.50, 1),
--	(4, 785.98, 3),
--	(5, 9870.99, 4);

INSERT INTO Parametr_czesc (ID_czesc, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,5,7,7),
(2,4,59,61),
(3,2,74,76),
(4,4,10,10),
(5,3,60,60);

INSERT INTO Parametr_narzedzie (ID_narzedzie, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,19,21),
(2,5,3.5,3.6),
(3,2,15,15),
(4,2,13,13),
(5,2,20,20);

INSERT INTO Parametr_maszyna (ID_maszyna, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,2,29.9,30.1),
(2,2,35,36),
(3,2,15,15),
(4,2,24,24),
(5,2,20,20);

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


INSERT INTO Obsluga (ID_rodzaj_obslugi, ID_stanowisko_produkcyjne, Data_od, Data_do, Uwagi)
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

