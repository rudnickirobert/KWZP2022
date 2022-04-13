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
('1','6',1),
('2','2',1),
('2','3',2),
('2','4',1),
('3','9',4),
('4','7',2),
('4','8',3),
('5','5',5);


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
(2,3,99,102),
(2,5,30,35),
(3,1,3,4),
(3,5,1,3),
(4,2,100,99),
(5,2,49,51);

INSERT INTO Material (ID_rodzaj_material, Nazwa_material)
VALUES
(4,'Proszek S316L DRUTEX'),
(1,'Filament Czarny ABS Black'),
(3,'Filament Zolty PETG Stakchovsky'),
(2,'Filament Czerwony PLA Podraskov'),
(2,'Filament Niebieski PLA POODZIAN');

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

