USE KWZP
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [Identyfikator czynnosci], Nazwa AS [Nazwa czynnosci]
FROM dbo.Czynnosc_produkcyjna;

CREATE VIEW	v_Parametry_produkt
AS
SELECT P.Nazwa_produkt AS [Nazwa produktu], Parametr_produkt.Nazwa AS [Nazwa parametru], Parametr_produkt.Nominal AS [Wartosæ nominalna]
FROM Szczegoly_produkt AS SP
INNER JOIN 
Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN
Parametr_produkt AS PP ON SP.ID_parametr = PP.ID_parametr;