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
('¯ywica termoutwardzalna');

INSERT INTO Rodzaj_maszyna (Nazwa, Opis)
VALUES
('Drukarka FDM','Drukowanie przy wykorzystaniu technologii FDM'),
('Drukarka SLA','Drukowanie przy wykorzystaniu technologii SLA'),
('Drukarka SLS','Drukowanie przy wykorzystaniu technologii SLS'),
('Skaner 3D',NULL),
('Drukarka laserowa','Laserowa'),
('PC','Komputer stacjonarny');

INSERT INTO Rodzaj_czesci (Nazwa)
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

INSERT INTO Status_zamowienie(Status)
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

INSERT INTO Material (ID_rodzaj_material, Nazwa_material)
VALUES
(4,'Proszek S316L DRUTEX'),
(1,'Filament Czarny ABS Black'),
(3,'Filament Zolty PETG Stakchovsky'),
(2,'Filament Czerwony PLA Podraskov'),
(2,'Filament Niebieski PLA POODZIAN');


