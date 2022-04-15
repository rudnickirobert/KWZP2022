USE KWZP
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [Identyfikator czynnosci], Nazwa AS [Nazwa czynnosci]
FROM Czynnosc_produkcyjna;
GO

--CREATE VIEW	v_Parametry_produkt
--AS
--SELECT P.Nazwa_produkt AS [Nazwa produktu], Parametr_produkt.Nazwa AS [Nazwa parametru], Parametr_produkt.Nominal AS [Wartosæ nominalna]
--FROM Szczegoly_produkt AS SP
--INNER JOIN 
--Produkt AS P ON SP.ID_produkt = P.ID_produkt
--INNER JOIN
--Parametr_produkt AS PP ON SP.ID_parametr = PP.ID_parametr;

--NIE DZIA£A/ CO TO JEST??--


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

CREATE VIEW v_Parametry_materialy AS
SELECT Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
FROM Parametr_material
INNER JOIN Material
ON Parametr_material.ID_material=Material.ID_material
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_material.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

--CREATE VIEW v_Zamowienia_maszyn_w_trakcie AS
--SELECT 
--FROM Stan_realizacji_zamowienie_maszyna
--INNER JOIN
--ON
--WHERE NOT ID_status_zamowienie
--GO

