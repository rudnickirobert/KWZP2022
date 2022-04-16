USE KWZP
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [Identyfikator czynnosci], Nazwa AS [Nazwa czynnosci]
FROM Czynnosc_produkcyjna;
GO

CREATE VIEW v_Parametry_produkt
AS
SELECT P.Nazwa_produkt AS [Nazwa produktu], RP.Nazwa_rodzaj_parametr AS [Parametr],
PP.Zakres_dol AS [Wymiar minimalny], PP.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_produkt AS PP
INNER JOIN Produkt AS P ON PP.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Parametry_polprodukt
AS
SELECT SP.Nazwa AS [Nazwa półproduktu], RP.Nazwa_rodzaj_parametr AS [Parametr],
PPp.Zakres_dol AS [Wymiar minimalny], PPp.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_polprodukt AS PPp
INNER JOIN Slownik_polprodukt AS SP ON PPp.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Rodzaj_parametr AS RP ON PPp.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Sklad_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], SlwPP.Nazwa AS [Półprodukt], SP.Liczba
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
GO

CREATE VIEW v_Sklad_polprodukt
AS
SELECT SlwPp.Nazwa AS [Półprodukt], M.Nazwa_material AS [Materiał], RM.Nazwa_rodzaj_material AS [Rodzaj materiału]
FROM Sklad_polprodukt AS SP
INNER JOIN Slownik_polprodukt AS SlwPp ON SP.ID_polprodukt = SlwPp.ID_polprodukt
INNER JOIN Material AS M ON SP.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
GO

CREATE VIEW v_Slownik_stanowisko
AS
SELECT * FROM Slownik_stanowisko
GO

CREATE VIEW v_Stanowisko_produkcyjne
AS
SELECT * FROM Stanowisko_produkcyjne
GO

-----RESOURCE DEPARTMENT----

CREATE VIEW v_Sklad_maszyna AS 
SELECT Maszyna.Nazwa_maszyna, Czesc.Nazwa_czesc, Sklad_maszyna.Liczba_czesci AS [Liczba czesci]
FROM Sklad_maszyna 
INNER JOIN Maszyna  
ON Sklad_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN Czesc 
ON Sklad_maszyna.ID_czesc=Czesc.ID_czesc
GROUP BY Maszyna.Nazwa_maszyna, Czesc.Nazwa_czesc, Sklad_maszyna.Liczba_czesci;
GO

CREATE VIEW v_Parametry_maszyna AS
SELECT Maszyna.Nazwa_maszyna, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
FROM Parametr_maszyna
INNER JOIN Maszyna
ON Parametr_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_maszyna.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Maszyna.Nazwa_maszyna, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_material AS
SELECT Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
FROM Parametr_material
INNER JOIN Material
ON Parametr_material.ID_material=Material.ID_material
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_material.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_czesc AS
SELECT Czesc.Nazwa_czesc, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
FROM Parametr_czesc
INNER JOIN Czesc
ON Parametr_czesc.ID_czesc=Czesc.ID_czesc
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_czesc.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Czesc.Nazwa_czesc, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_narzedzie AS
SELECT Narzedzie.Nazwa_narzedzie, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
FROM Parametr_narzedzie
INNER JOIN Narzedzie
ON Parametr_narzedzie.ID_narzedzie=Narzedzie.ID_narzedzie
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_narzedzie.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Narzedzie.Nazwa_narzedzie, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
GO

--CREATE VIEW v_Zamowienia_maszyn_w_trakcie AS
--SELECT 
--FROM Stan_realizacji_zamowienie_maszyna
--INNER JOIN
--ON
--WHERE NOT ID_status_zamowienie
--GO

