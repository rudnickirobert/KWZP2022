USE KWZP
GO


INSERT INTO Czynnosc_produkcyjna (ID_czynnosc_produkcyjna, Nazwa)
VALUES
(1, 'Przygotowanie stanowiska'),
(2, 'Skanowanie'),
(3, 'Drukowanie'),
(4, 'Szlifowanie'),
(5, 'Klejenie'),
(6, 'Skladanie');


INSERT INTO Rodzaj_kontrola (ID_rodzaj_kontrola, Rodzaj_kontrola, Procedura)
VALUES
(1,'Wymiarowa', 'Dokonac pomiaru najwazniejszych wymiarow'),
(2,'Wzrokowa', 'Ogolne ogledziny otrzymanego produktu'),
(3,'Badanie twardosci', 'Dokonac pomiaru twardosci badanego produktu'),
(4,'Badanie chropowatosci', 'Okreslic chropowatosc uzyskanej powierzchni'),
(5,'Wytrzymalosciowa', 'Poddac produkt obciazeniu probnemu');



INSERT INTO Rezultat_kontrola (ID_rezultat, Wynik)
VALUES
(1,'Pozytywny'),
(2,'Negatywny - do porawy'),
(3,'Do utylizacji');


INSERT INTO Parametr_produkt (ID_parametr, Nazwa)
VALUES
(1,'Dlugosc'),
(2,'Wysokosc'),
(3,'Szerokosc'),
(4,'Chropowatosc'),
(5,'Twardosc'),
(6,'Twardosc');

INSERT INTO Slownik_stanowisko (ID_nazwa_stanowiska, Nazwa_stanowiska)
VALUES
(1, 'Stanowisko do skanowania'),
(2, 'Stanowisko do drukowania FDM'),
(3, 'Stanowisko do drukowania SLS'),
(4, 'Stanowisko do drukowania SLA'),
(5, 'Stanowisko do szlifowania');
(6, 'Stanowisko do laczenia polproduktow');