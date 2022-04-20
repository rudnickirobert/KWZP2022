﻿USE KWZP
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [ID czynnosci], Nazwa AS [Nazwa czynnosci]
FROM Czynnosc_produkcyjna;
GO

CREATE VIEW v_Parametry_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], RP.Nazwa_rodzaj_parametr AS [Parametr],
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
SELECT SlwPp.Nazwa AS [Półprodukt], M.Nazwa_material AS [Materiał], RM.Nazwa_rodzaj_material AS [Rodzaj],
SP.Liczba AS [Ilość]
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
SELECT SP.ID_stanowisko_produkcyjne AS [ID Stanowiska], SS.Nazwa_stanowiska, N.Nazwa_narzedzie AS [Narzędzie], Liczba 
FROM Sklad_stanowisko_produkcyjne_narzedzie AS SSPN
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPN.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Narzedzie AS N ON SSPN.ID_narzedzie = N.ID_narzedzie
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], SS.Nazwa_stanowiska AS [Nazwa Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
RM.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Koszt_roboczogodziny_stanowiska
AS
SELECT [ID stanowiska produkcyjnego],SUM([Koszt roboczogodziny {PLN}]) AS [Koszt roboczogodziny stanowiska {PLN}] 
FROM (SELECT SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], SS.Nazwa_stanowiska AS [Nazwa Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
RM.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS) AS v_Sklad_stanowisko_produkcyjne_maszyna
GROUP BY [ID stanowiska produkcyjnego]
GO

CREATE VIEW v_Koszt_procesow_polprodukt
AS
SELECT P.ID_polprodukt AS ID, P.Nazwa AS [Półprodukt], SUM(vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60) AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PWPP.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
GROUP BY P.ID_polprodukt, P.Nazwa
GO

CREATE VIEW v_Koszt_procesow_produkt
AS
SELECT  P.Nazwa_produkt AS [Produkt], SUM(vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60) AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_produkt
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PWPP.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Koszt_produkcji
AS
SELECT SUM(KPP.[Suma kosztu procesów] * SP.Liczba) AS [Koszt wytworzenia produktu {PLN}]
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
INNER JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Półprodukt
INNER JOIN v_Koszt_procesow_produkt AS KP ON P.Nazwa_produkt = KP.Produkt
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Koszt
AS
SELECT P.Nazwa_produkt, SlwPP.Nazwa, SP.Liczba, KPP.[Suma kosztu procesów] * SP.Liczba AS [Koszt półproduktów]
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
INNER JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Półprodukt
GO

CREATE VIEW v_Kontrola_jakosci_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], Rk.Rodzaj_kontrola AS [Rodzaj kontroli], 
PR.Nazwisko AS [Osoba kontrolująca], Rek.Wynik AS [Wynik kontroli], Kjp.Uwagi AS [Uwagi]
FROM Kontrola_jakosci_produkt AS Kjp
INNER JOIN Rezultat_kontrola AS Rek ON Kjp.ID_rezultat = Rek.ID_rezultat
INNER JOIN Produkt AS P ON Kjp.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_kontrola AS Rk ON Kjp.ID_rodzaj_kontrola = Rk.Rodzaj_kontrola
INNER JOIN Pracownik AS PR ON Kjp.ID_pracownik = PR.ID_pracownik
GO

CREATE VIEW v_Rodzaj_kontrola
AS
SELECT ID_rodzaj_kontrola AS ID, Rodzaj_kontrola AS [Rodzaj kontroli], Procedura AS [Procedura kontrolna]
FROM Rodzaj_kontrola
GO

CREATE VIEW v_Proces_polprodukt_czynnosc
AS
SELECT PPPC.ID_polprodukt AS [ID Półproduktu], SP.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_produkt_czynnosc
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność] 
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_polprodukt
AS
SELECT Count(PPPC.ID_polprodukt) AS [Ilosc zabiegow], SP.Nazwa AS [Półprodukt]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY SP.Nazwa
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_produkt
AS
SELECT Count(PPC.ID_produkt) AS [Ilosc zabiegow], P.Nazwa_produkt AS [Produkt]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Wytwarzanie
AS
SELECT W.ID_wytwarzanie AS [ID zabiegu produkcyjnego], W.Czas_od [Data rozpoczęcia], W.Czas_do AS [Data zakończenia],
P.Nazwisko + ' ' + P.Imie AS [Pracownik], OH.Termin_realizacja AS [Termin realizacji oferty]
FROM Wytwarzanie AS W
INNER JOIN Pracownik AS P ON W.ID_pracownik = P.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
INNER JOIN Oferta_handlowa AS OH ON OH.ID_zamowienie = z.ID_zamowienie
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt
AS
SELECT P.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SP.ID_stanowisko_produkcyjne, PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWPP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SP.ID_stanowisko_produkcyjne, PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Stanowiska_w_uzyciu
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa 
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
WHERE W.Czas_do IS NULL
UNION 
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa 
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWPP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
WHERE W.Czas_do IS NULL
GO

CREATE VIEW v_Stanowiska_do_uzycia
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
EXCEPT
SELECT * FROM v_Stanowiska_w_uzyciu
GO



-----RESOURCE DEPARTMENT----

CREATE VIEW v_Sklad_maszyna AS 
SELECT Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Czesc.Nazwa_czesc AS [Nazwa części], Sklad_maszyna.Liczba_czesci AS [Liczba czesci]
FROM Sklad_maszyna 
INNER JOIN Maszyna  
ON Sklad_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN Czesc 
ON Sklad_maszyna.ID_czesc=Czesc.ID_czesc
GROUP BY Maszyna.Nazwa_maszyna, Czesc.Nazwa_czesc, Sklad_maszyna.Liczba_czesci;
GO

CREATE VIEW v_Parametry_maszyna AS
SELECT Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_maszyna
INNER JOIN Maszyna
ON Parametr_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_maszyna.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Maszyna.Nazwa_maszyna, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_material AS
SELECT Material.Nazwa_material AS [Nazwa materiału], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_material
INNER JOIN Material
ON Parametr_material.ID_material=Material.ID_material
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_material.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_czesc AS
SELECT Czesc.Nazwa_czesc AS [Nazwa części], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_czesc
INNER JOIN Czesc
ON Parametr_czesc.ID_czesc=Czesc.ID_czesc
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_czesc.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Czesc.Nazwa_czesc, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_narzedzie AS
SELECT Narzedzie.Nazwa_narzedzie AS [Nazwa narzędzia], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_narzedzie
INNER JOIN Narzedzie
ON Parametr_narzedzie.ID_narzedzie=Narzedzie.ID_narzedzie
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_narzedzie.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Narzedzie.Nazwa_narzedzie, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
GO

CREATE VIEW v_Oblugi_zakonczone
AS
SELECT SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obsługa], Data_od AS [Data rozpoczęcia], Data_do AS [Data zakończenia], P.Imie + ' ' + P.Nazwisko AS [Pracownik]
FROM Obsluga_pracownik AS OP
INNER JOIN Obsluga AS O ON OP.ID_obsluga = O.ID_obsluga
INNER JOIN Pracownik AS P ON OP.ID_pracownik = P.ID_pracownik
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NOT NULL AND GETDATE() > Data_do
GO

CREATE VIEW v_Oblugi_w_trakcie
AS
SELECT SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obsługa], Data_od AS [Data rozpoczęcia], Data_do AS [Data zakończenia], P.Imie + ' ' + P.Nazwisko AS [Pracownik]
FROM Obsluga_pracownik AS OP
INNER JOIN Obsluga AS O ON OP.ID_obsluga = O.ID_obsluga
INNER JOIN Pracownik AS P ON OP.ID_pracownik = P.ID_pracownik
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NULL
GO

CREATE VIEW v_Zamowienia_czesci_w_trakcie_wszystko 
AS 
SELECT ZC.ID_zamowienie_czesc AS [Nr zamówienia], C.Nazwa_czesc AS [Nazwa części], SRZC.Data_stan [Data zmiany stanu], Ilosc, Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_czesc AS SZC 
INNER JOIN Zamowienie_czesc AS ZC ON SZC.ID_zamowienie_czesc = ZC.ID_zamowienie_czesc 
INNER JOIN Czesc AS C ON SZC.ID_czesc = C.ID_czesc 
INNER JOIN Stan_realizacji_zamowienie_czesc AS SRZC ON ZC.ID_zamowienie_czesc = SRZC.ID_zamowienie_czesc 
INNER JOIN Status_zamowienie AS SZ ON SRZC.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZC.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_czesci_w_trakcie_bez_odebranych 
AS 
SELECT ZCWTW.[Nr zamówienia], ZCWTW.[Nazwa części], ZCWTW.[Data zmiany stanu], ZCWTW.Ilosc, ZCWTW.Cena, ZCWTW.[Status], ZCWTW.[StatusID] 
FROM v_Zamowienia_czesci_w_trakcie_wszystko AS ZCWTW 
LEFT JOIN v_Zamowienia_czesci_w_trakcie_wszystko AS ZCWTWA ON ZCWTW.[Nr zamówienia] = ZCWTWA.[Nr zamówienia] AND ZCWTWA.[Status] = 'Odebrano' 
WHERE ZCWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_czesci_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_czesci_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_czesci_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie_wszystko 
AS 
SELECT ZM.ID_zamowienie_material AS [Nr zamówienia], M.Nazwa_material AS [Nazwa materiału], SRZM.Data_stan [Data zmiany stanu], Waga_g AS [Waga (g)], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_material AS SZM 
INNER JOIN Zamowienie_material AS ZM ON SZM.ID_zamowienie_material = ZM.ID_zamowienie_material 
INNER JOIN Material AS M ON SZM.ID_material = M.ID_material 
INNER JOIN Stan_realizacji_zamowienie_material AS SRZM ON ZM.ID_zamowienie_material = SRZM.ID_zamowienie_material 
INNER JOIN Status_zamowienie AS SZ ON SRZM.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZM.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie_bez_odebranych 
AS 
SELECT ZMWTW.[Nr zamówienia], ZMWTW.[Nazwa materiału], ZMWTW.[Data zmiany stanu], ZMWTW.[Waga (g)], ZMWTW.Cena, ZMWTW.[Status], ZMWTW.[StatusID] 
FROM v_Zamowienia_materialy_w_trakcie_wszystko AS ZMWTW 
LEFT JOIN v_Zamowienia_materialy_w_trakcie_wszystko AS ZMWTWA ON ZMWTW.[Nr zamówienia] = ZMWTWA.[Nr zamówienia] AND ZMWTWA.[Status] = 'Odebrano' 
WHERE ZMWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_materialy_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_materialy_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie_wszystko 
AS 
SELECT ZN.ID_zamowienie_narzedzie AS [Nr zamówienia], N.Nazwa_narzedzie AS [Nazwa narzędzia], SRZN.Data_stan [Data zmiany stanu], Sztuk, Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_narzedzie AS SZN 
INNER JOIN Zamowienie_narzedzie AS ZN ON SZN.ID_zamowienie_narzedzie = ZN.ID_zamowienie_narzedzie 
INNER JOIN Narzedzie AS N ON SZN.ID_narzedzie = N.ID_narzedzie
INNER JOIN Stan_realizacji_zamowienie_narzedzie AS SRZN ON ZN.ID_zamowienie_narzedzie = SRZN.ID_zamowienie_narzedzie 
INNER JOIN Status_zamowienie AS SZ ON SRZN.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZN.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie_bez_odebranych 
AS 
SELECT ZNWTW.[Nr zamówienia], ZNWTW.[Nazwa narzędzia], ZNWTW.[Data zmiany stanu], ZNWTW.Sztuk, ZNWTW.Cena, ZNWTW.[Status], ZNWTW.[StatusID] 
FROM v_Zamowienia_narzedzia_w_trakcie_wszystko AS ZNWTW 
LEFT JOIN v_Zamowienia_materialy_w_trakcie_wszystko AS ZNWTWA ON ZNWTW.[Nr zamówienia] = ZNWTWA.[Nr zamówienia] AND ZNWTWA.[Status] = 'Odebrano' 
WHERE ZNWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_narzedzia_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_narzedzia_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Zamowienia_maszyny_w_trakcie_wszystko 
AS 
SELECT ZM.ID_zamowienie_maszyna AS [Nr zamówienia], M.Nazwa_maszyna AS [Nazwa maszyny], SRZM.Data_stan AS [Data zmiany stanu], Ilosc AS [Ilość], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_maszyna AS SZM 
INNER JOIN Zamowienie_maszyna AS ZM ON SZM.ID_zamowienie_maszyna = ZM.ID_zamowienie_maszyna
INNER JOIN Maszyna AS M ON SZM.ID_maszyna = M.ID_maszyna
INNER JOIN Stan_realizacji_zamowienie_maszyna AS SRZM ON ZM.ID_zamowienie_maszyna = SRZM.ID_zamowienie_maszyna
INNER JOIN Status_zamowienie AS SZ ON SRZM.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZM.ID_dostawca = D.ID_dostawca
GROUP BY M.Nazwa_maszyna, ZM.ID_zamowienie_maszyna, SRZM.Data_stan, Ilosc, Cena, D.Nazwa_dostawca, SZ.Nazwa_status, SZ.ID_status_zamowienie
GO

CREATE VIEW v_Zamowienia_maszyny_w_trakcie_bez_odebranych 
AS 
SELECT ZMWTW.[Nr zamówienia], ZMWTW.[Nazwa maszyny], ZMWTW.[Data zmiany stanu], ZMWTW.Ilość, ZMWTW.Cena, ZMWTW.[Status], ZMWTW.[StatusID] 
FROM v_Zamowienia_maszyny_w_trakcie_wszystko  AS ZMWTW 
LEFT JOIN v_Zamowienia_maszyny_w_trakcie_wszystko AS ZMWTWA ON ZMWTW.[Nr zamówienia] = ZMWTWA.[Nr zamówienia] AND ZMWTWA.[Status] = 'Odebrano' 
WHERE ZMWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_maszyny_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_maszyny_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_maszyny_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Magazyn_maszyn_wszystko 
AS
SELECT [Nazwa maszyny], SUM([Ilość]) AS [Liczba sztuk]
FROM v_Zamowienia_maszyny_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa maszyny]
GO

CREATE VIEW v_Magazyn_narzedzia_wszystko
AS
SELECT [Nazwa narzędzia], Sztuk
FROM v_Zamowienia_narzedzia_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa narzędzia], Sztuk
GO

CREATE VIEW v_Magazyn_narzedzia_uzywane
AS
SELECT Narzędzie, SUM (Liczba) AS Liczba
FROM v_Sklad_stanowisko_produkcyjne_narzedzie AS SSPN
GROUP BY Narzędzie
GO

CREATE VIEW v_Magazyn_narzedzia_stan
AS
SELECT [Nazwa narzędzia], Sztuk, IsNull(Liczba,0) as Używane
FROM v_Magazyn_narzedzia_wszystko AS MNW
LEFT JOIN v_Magazyn_narzedzia_uzywane AS MNU ON MNW.[Nazwa narzędzia]=MNU.[Narzędzie]
GO

CREATE VIEW v_Magazyn_narzedzia_nieuzywane
AS
SELECT [Nazwa narzędzia], Sztuk-Używane AS [Ilość w magazynie]
FROM v_Magazyn_narzedzia_stan
GO

CREATE VIEW v_Magazyn_material_wszystko
AS
SELECT [Nazwa materiału], [Waga (g)]
FROM v_Zamowienia_materialy_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa materiału], [Waga (g)]
GO

--SALES AND MARKETING DEPARTMENT --
CREATE VIEW v_Szczegoly_sprzedaz AS
SELECT Szczegoly_sprzedaz.ID_sprzedaz AS [Numer sprzedaży], Produkt.Nazwa_produkt AS [Produkt], 
Szczegoly_sprzedaz.Ilosc AS [Ilość], Szczegoly_sprzedaz.Kwota_sprzedaz AS [Cena za sztukę], Podatek.Procent AS [Podatek %],
Forma_platnosc.Forma_platnosc AS [Forma płatności]
FROM Szczegoly_sprzedaz
INNER JOIN Podatek ON Szczegoly_sprzedaz.ID_podatek = Podatek.ID_podatek
INNER JOIN (Sprzedaz INNER JOIN Forma_platnosc ON Sprzedaz.ID_forma_platnosc = Forma_platnosc.ID_Forma_platnosc) 
ON Szczegoly_sprzedaz.ID_sprzedaz = Sprzedaz.ID_sprzedaz
INNER JOIN Produkt ON Produkt.ID_produkt = Szczegoly_sprzedaz.ID_produkt
GO

CREATE VIEW v_Sprzedaz AS
SELECT Sprzedaz.Nr_sprzedaz AS [Numer sprzedaży], Klient.Nazwisko AS [Nazwisko klienta], Klient.Imie AS [Imię klienta], Klient.NIP,
		Sprzedaz.Data_sprzedaz_poczatek AS [Data początku sprzedaży], Sprzedaz.Data_sprzedaz_koniec AS [Data końca sprzedaży],
		Umowa_sprzedaz.ID_umowa_sprzedaz AS [Umowa], (Szczegoly_sprzedaz.Ilosc * Szczegoly_sprzedaz.Kwota_sprzedaz) AS [Koszt]
FROM Sprzedaz
INNER JOIN 
(Umowa_sprzedaz INNER JOIN 
(Oferta_handlowa INNER JOIN 
(Klient INNER JOIN Zamowienie ON Klient.ID_klient = Zamowienie.ID_klient) 
ON Oferta_handlowa.ID_zamowienie = Zamowienie.ID_zamowienie) 
ON Umowa_sprzedaz.ID_oferta_handlowa = Oferta_handlowa.ID_oferta_handlowa) ON Umowa_sprzedaz.ID_umowa_sprzedaz = Sprzedaz.ID_umowa_sprzedaz
INNER JOIN Szczegoly_sprzedaz ON Szczegoly_sprzedaz.ID_sprzedaz = Sprzedaz.ID_sprzedaz
GO

CREATE VIEW v_Oferta_handlowa AS
SELECT Oferta_handlowa.ID_zamowienie AS [Numer zamówienia], 
Oferta_handlowa.ID_Oferta_handlowa AS [Numer oferty], 
Status_oferta.Nazwa_status_oferta AS [Status oferty],
Gwarancja.Okres_gwarancja AS [Okres gwarancji], 
Gwarancja.Opis_gwarancja AS [Opis gwarancji],
Oferta_handlowa.Cena, Oferta_handlowa.Termin_realizacja AS [Termin realizacji],
Pracownik.Nazwisko AS [Nazwisko pracownika], Pracownik.Imie AS [Imię pracownika]
FROM Oferta_handlowa
INNER JOIN Status_oferta ON Status_oferta.ID_status_oferta = Oferta_handlowa.ID_status_oferta
INNER JOIN Gwarancja ON Gwarancja.ID_gwarancja = Oferta_handlowa.ID_gwarancja
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Oferta_Handlowa.ID_pracownik
ORDER BY [Numer zamówienia] OFFSET 0 ROWS
GO

CREATE VIEW v_Produkty_na_gwarancji
AS
SELECT Produkt.Nazwa_produkt AS [Nazwa produktu],
Szczegoly_sprzedaz.ID_sprzedaz AS [Numer sprzedaży],
Sprzedaz.Data_sprzedaz_koniec AS [Data sprzedaży]
FROM Szczegoly_sprzedaz
INNER JOIN Sprzedaz ON Sprzedaz.ID_sprzedaz = Szczegoly_sprzedaz.ID_sprzedaz
INNER JOIN Produkt ON Szczegoly_sprzedaz.ID_produkt = Produkt.ID_produkt
GO



CREATE VIEW v_Reklamacja
AS
SELECT Reklamacja.ID_sprzedaz AS [Numer sprzedaży],
Reklamacja.ID_reklamacja AS [Numer reklamacji],
Reklamacja.Data_reklamacja AS [Data reklamacji],
Reklamacja.Opis_reklamacja AS [Opis reklamacji],
Produkt.Nazwa_produkt AS [Nazwa produktu],
Zwrot.Ilosc AS [Ilość],
Zwrot.Akceptacja AS [Akceptacja] 
FROM Zwrot
INNER JOIN Reklamacja ON Reklamacja.ID_reklamacja = Zwrot.ID_reklamacja
INNER JOIN Produkt ON Produkt.ID_produkt = Zwrot.ID_produkt 
GO

CREATE VIEW v_Klient AS
	SELECT Klient.Nazwisko AS [Nazwisko], Klient.Imie AS [Imię], Klient.NIP, Dane_adresowe_klient.Miejscowosc AS [Miejscowość], 
	Dane_adresowe_klient.Ulica, Dane_adresowe_klient.Nr_budynek AS [Numer budynku], 
	Dane_adresowe_klient.Nr_lokal AS [Numer lokalu], Dane_adresowe_klient.Kod_pocztowy AS [Kod pocztowy]
	FROM Klient 
	INNER JOIN Dane_adresowe_klient ON Klient.ID_klient = Dane_adresowe_klient.ID_klient
	GO

CREATE VIEW v_Klient_telefon_aktualny AS 
	SELECT Klient.Nazwisko, Klient.Imie AS [Imię], Nr_telefon_klient.Numer AS [Numer telefonu]
	FROM Klient 
	INNER JOIN Nr_telefon_klient ON Klient.ID_klient = Nr_telefon_klient.ID_klient
	WHERE Data_do IS NULL
	GO

CREATE VIEW v_Klient_telefon_Historia AS
	SELECT Klient.Nazwisko, Klient.Imie AS [Imię], Nr_telefon_klient.Numer AS [Numer telefonu]
	FROM Klient 
	INNER JOIN Nr_telefon_klient ON Klient.ID_klient = Nr_telefon_klient.ID_klient
	ORDER BY Data_do DESC OFFSET 0 ROWS
	GO

CREATE VIEW	v_Szczegoly_oferta AS
	SELECT Zamowienie.ID_zamowienie, Oferta_handlowa.ID_oferta_handlowa AS [Nr oferty], Produkt.Nazwa_produkt AS [Produkt], Szczegoly_oferta.Ilosc AS [Ilość]
	FROM Szczegoly_oferta
	INNER JOIN Oferta_handlowa ON Oferta_handlowa.ID_oferta_handlowa = Szczegoly_oferta.ID_oferta_handlowa
	INNER JOIN Produkt ON Produkt.ID_produkt = Szczegoly_oferta.ID_produkt
	INNER JOIN Zamowienie ON Zamowienie.ID_zamowienie = Oferta_handlowa.ID_zamowienie
	ORDER BY ID_zamowienie OFFSET 0 ROWS
	GO

	--HR DEPARTMENT --
CREATE VIEW v_Pracownik
AS
SELECT P.ID_pracownik AS [ID], P.Nazwisko AS [Nazwisko], P.Imie AS [Imię], P.Nr_dowodu AS [Nr dowodu], P.Pesel AS [Pesel], W.Nazwa AS [Wykształcenie], NTP.Numer AS [Numer telefonu], EP.Email AS [Email] FROM Pracownik AS P
INNER JOIN Wyksztalcenie AS W ON P.ID_wyksztalcenie = W.ID_wyksztalcenie
INNER JOIN Nr_telefon_pracownik AS NTP ON P.ID_pracownik = NTP.ID_pracownik
INNER JOIN Email_pracownik AS EP ON P.ID_pracownik = EP.ID_pracownik
GO

CREATE VIEW v_Dane_adresowe_pracownik
AS
SELECT ID_pracownik AS [ID], Miejscowosc AS [Miejscowość zamieszkania], Ulica AS [Ulica], Nr_budynku AS [Nr budynku], Nr_lokalu AS [Nr_lokalu], Kod_pocztowy AS [Kod pocztowy], Data_od AS [Data od:], Data_do AS [Data do:]
FROM Dane_adresowe_pracownik;
GO

CREATE VIEW v_Nieobecnosc
AS
SELECT P.Nazwisko AS [Nazwisko], P.Imie AS [Imię], RN.Symbol AS [Rodzaj nieobecności], N.Data_od AS [Data od:], N.Data_do AS [Data do:] FROM Nieobecnosc AS N
INNER JOIN Pracownik AS P ON N.ID_pracownik = P.ID_pracownik
INNER JOIN Rodzaj_nieobecnosci AS RN ON N.ID_rodzaj_nieobecnosci = RN. ID_rodzaj_nieobecnosci
GO

CREATE VIEW v_Nr_telefon_pracownik
AS
SELECT P.Nazwisko AS [Nazwisko], P.Imie AS [Imię], NTP.Numer AS [Numer telefonu], NTP.Data_od AS [Data od:], NTP.Data_do AS [Data do:] From Nr_telefon_pracownik AS NTP
INNER JOIN Pracownik AS P ON NTP.ID_pracownik = P.ID_pracownik
GO

CREATE VIEW v_Email_pracownik
AS
SELECT P.Nazwisko AS [Nazwisko], P.Imie AS [Imię], EP.Email AS [Email], EP.Data_od AS [Data od:], EP.Data_do AS [Data do:] From Email_pracownik AS EP
INNER JOIN Pracownik AS P ON EP.ID_pracownik = P.ID_pracownik
GO

CREATE VIEW v_Etat
AS
SELECT E.ID_etat AS [ID], ST.Nazwa_stanowiska AS [Stanowisko], DZ.Nazwa_dzial AS [Dzial], E.Liczba_miejsc AS [Liczba stanowisk] FROM Etat AS E
INNER JOIN Stanowisko AS ST ON E.ID_stanowisko = ST.ID_stanowisko
INNER JOIN Dzial AS DZ ON E.ID_dzial = DZ.ID_dzial
GO

CREATE VIEW v_Umowa
AS
SELECT UM.ID_umowa AS [ID], P.Nazwisko AS [Nazwisko], P.Imie AS [Imię], WP.Nazwa AS [Wymiar pracy], ST.Nazwa_stanowiska AS [Nazwa stanowiska], UM.Wynagrodzenie AS [Podstawa wynagrodzenia]  
FROM Umowa AS UM
INNER JOIN
(Posada_pracownika AS PO INNER JOIN
(Etat AS ET INNER JOIN Stanowisko AS ST ON ET.ID_stanowisko = ST.ID_stanowisko)
ON ET.ID_etat = PO.ID_etat) ON UM.ID_posada_pracownika = PO.ID_posada_pracownika
INNER JOIN Pracownik AS P ON UM.ID_pracownik = P.ID_pracownik
INNER JOIN Wymiar_pracy AS WP ON UM.ID_wymiar_pracy = WP.ID_wymiar_pracy
GO

CREATE VIEW v_Sz_czas_proces_polprodukt_czynnosc
AS
SELECT PPPC.ID_polprodukt AS [ID Półproduktu], SP.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność], PPPC.Czas_trwania AS [Szacowany czas w min]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt AS SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO
 
CREATE VIEW v_Sz_czas_proces_produkt_czynnosc
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność], PPC.Czas_trwania AS [Szacowany czas w min]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS
GO
 
CREATE VIEW v_Nadgodziny
AS
SELECT NG.ID_pracownik AS [ID_Pracownik], NG.Data_nadgodziny AS [Data nadgodziny], NG.Czas AS [Czas]
FROM Nadgodziny AS NG
INNER JOIN Pracownik AS P ON NG.ID_pracownik = P.ID_pracownik
ORDER BY NG.ID_pracownik DESC OFFSET 0 ROWS 
GO

CREATE VIEW v_Nadgodziny_miesiac
AS
SELECT DISTINCT NG.ID_pracownik AS [ID_Pracownik], MONTH(NG.Data_nadgodziny) AS [Miesiąc], NG.Czas AS [Czas]
FROM Nadgodziny AS NG
INNER JOIN Pracownik AS P ON NG.ID_pracownik = P.ID_pracownik
ORDER BY NG.ID_pracownik DESC OFFSET 0 ROWS 
GO

CREATE VIEW v_Nadgodziny_suma_miesiac
AS
SELECT ID_Pracownik, Miesiąc, SUM(Czas) AS [Łączny czas]
FROM  dbo.v_Nadgodziny_miesiac
GROUP BY ID_Pracownik, Miesiąc
GO

