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
SELECT ID_nazwa_stanowiska AS ID, Nazwa_stanowiska AS [Nazwa stanowiska] 
FROM Slownik_stanowisko
GO

CREATE VIEW v_Stanowisko_produkcyjne
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID], SS.Nazwa_stanowiska AS [Nazwa stanowiska]
FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_narzedzie
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID Stanowiska], SS.Nazwa_stanowiska, N.ID_narzedzie, N.Nazwa_narzedzie 
FROM Sklad_stanowisko_produkcyjne AS SSP
INNER JOIN Stanowisko_produkcyjne AS SP ON SSP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Narzedzie AS N ON SSP.ID_narzedzie = N.ID_narzedzie
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
WHERE SP.ID_stanowisko_produkcyjne = 3
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna
AS
SELECT SSPM.ID_sklad_stanowisko_produkcyjne_maszyna, 
SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska, MS.ID_maszyna, NS.Nr_seryjny,
M.Nazwa_maszyna, RM.Nazwa_rodzaj_maszyna
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
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

--CREATE VIEW v_Obluga_maszyna AS
--SELECT Maszyna.Nazwa_maszyna, Rodzaj_obsluga.Nazwa_rodzaj_obsluga, Data_od, Data_do, Pracownik.Nazwisko, Pracownik.Imie
--FROM Obsluga
--INNER JOIN Rodzaj_obsluga
--ON 

--CREATE VIEW v_Zamowienia_czesci AS
--SELECT Czesc.Nazwa_czesc, Producent.Nazwa_producenta, Szczegoly_zamowienie_czesc.Ilosc, Szczegoly_zamowienie_czesc.Cena, Dostawca.Nazwa_dostawca, Data_zamowienia
--FROM Zamowienie_czesc
--INNER JOIN Czesc
--ON Zamowienie_czesc.ID
--INNER JOIN
--ON
--INNER JOIN
--ON
--GO

--CREATE VIEW v_Zamowienia_maszyn_w_trakcie AS
--SELECT 
--FROM Stan_realizacji_zamowienie_maszyna
--INNER JOIN
--ON
--WHERE NOT ID_status_zamowienie
--GO

