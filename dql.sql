USE KWZP
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [ID czynnosci], Nazwa AS [Nazwa czynnosci]
FROM Czynnosc_produkcyjna;
GO

CREATE VIEW v_Parametry_produkt
AS
SELECT ID_parametr_produkt, P.Nazwa_produkt AS [Produkt], RP.Nazwa_rodzaj_parametr AS [Parametr],
PP.Zakres_dol AS [Wymiar minimalny], PP.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_produkt AS PP
INNER JOIN Produkt AS P ON PP.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Parametry_polprodukt
AS
SELECT ID_parametr_polprodukt, SP.Nazwa AS [Nazwa półproduktu], RP.Nazwa_rodzaj_parametr AS [Parametr],
PPp.Zakres_dol AS [Wymiar minimalny], PPp.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_polprodukt AS PPp
INNER JOIN Slownik_polprodukt AS SP ON PPp.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Rodzaj_parametr AS RP ON PPp.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Sklad_produkt
AS
SELECT SP.ID_sklad_produkt AS [ID skład], P.Nazwa_produkt AS [Produkt], SlwPP.Nazwa AS [Półprodukt], SP.Liczba
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
ORDER BY P.Nazwa_produkt OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_produkt_ewidencja
AS
SELECT SP.ID_sklad_produkt AS [ID skład], SP.ID_produkt, SP.ID_polprodukt, SlwPP.Nazwa AS [Półprodukt], SP.Liczba
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
ORDER BY P.Nazwa_produkt OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_polprodukt
AS
SELECT SP.ID_sklad_polprodukt AS [ID_skład], SlwPp.Nazwa AS [Półprodukt], M.Nazwa_material AS [Materiał], RM.Nazwa_rodzaj_material AS [Rodzaj],
SP.Liczba AS [Waga {g}]
FROM Sklad_polprodukt AS SP
INNER JOIN Slownik_polprodukt AS SlwPp ON SP.ID_polprodukt = SlwPp.ID_polprodukt
INNER JOIN Material AS M ON SP.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
ORDER BY SlwPp.Nazwa OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_produkt_material
AS
SELECT ID_sklad_produkt_material, P.Nazwa_produkt AS [Produkt], M.Nazwa_material AS [Materiał], RM.Nazwa_rodzaj_material AS [Rodzaj],
SPM.Liczba AS [Waga {g}]
FROM Sklad_produkt_material AS SPM
INNER JOIN Produkt AS P ON SPM.ID_produkt = P.ID_produkt
INNER JOIN Material AS M ON SPM.ID_material = M.ID_material
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
FROM v_Sklad_stanowisko_produkcyjne_maszyna
GROUP BY [ID stanowiska produkcyjnego]
GO

CREATE VIEW v_Koszt_procesow_polprodukt
AS
SELECT SP.ID_produkt, P.ID_polprodukt AS ID, P.Nazwa AS [Półprodukt], PPPC.Czas_trwania AS [Czas trwania], CP.Nazwa AS [Czynność], vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60 AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PWPP.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Sklad_produkt AS SP ON SP.ID_polprodukt = P.ID_polprodukt
GO

CREATE VIEW v_Koszt_procesow_produkt
AS
SELECT P.ID_produkt, P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność], PPPC.Czas_trwania AS [Czas trwania], vK.[Koszt roboczogodziny stanowiska {PLN}], vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60 AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_produkt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PWPP.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
GO

CREATE VIEW v_Koszt_produkcji
AS
SELECT P.Nazwa_produkt, SUM(KPP.[Suma kosztu procesów] * SP.Liczba) + SUM(KP.[Suma kosztu procesów]) AS [Koszt wytworzenia produktu {PLN}]
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
INNER JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Półprodukt
INNER JOIN v_Koszt_procesow_produkt AS KP ON P.Nazwa_produkt = KP.Produkt
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Koszt
AS
SELECT P.Nazwa_produkt, ISNULL(Kp.[Suma kosztu procesów],0) AS [Koszt produktów], SlwPP.Nazwa, SP.Liczba, ISNULL((KPP.[Suma kosztu procesów] * SP.Liczba),0) AS [Koszt półproduktów], Kp.[Suma kosztu procesów] + ISNULL((KPP.[Suma kosztu procesów] * SP.Liczba),0) AS SUMA
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
LEFT JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Półprodukt
LEFT JOIN v_Koszt_procesow_produkt AS KP ON P.Nazwa_produkt = KP.Produkt
GO

CREATE VIEW v_Kontrola_parametr_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], RP.Nazwa_rodzaj_parametr AS [Parametr], KP.Wartosc AS [Wartość],
PP.Zakres_dol AS [Zakres dolny], PP.Zakres_gora AS [Zakres górny], (CASE WHEN KP.Wartosc BETWEEN PP.Zakres_dol AND PP.Zakres_gora THEN 1 ELSE 0 END) AS [Rezultat kontroli]  
FROM Kontrola_parametr AS KP
INNER JOIN Kontrola_jakosci_produkt AS KJP ON KP.ID_kontrola_jakosci_produkt = KJP.ID_kontrola_jakosci_produkt
INNER JOIN Parametr_produkt AS PP ON KP.ID_parametr_produkt = PP.ID_parametr_produkt
INNER JOIN Produkt AS P ON PP.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
GO

CREATE VIEW v_Kontrola_jakosci_kolejka
AS
SELECT W.ID_wytwarzanie, P.Nazwa_produkt
FROM Wytwarzanie AS W
LEFT JOIN Kontrola_jakosci_produkt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_produkt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
WHERE W.Czas_do IS NOT NULL

EXCEPT

SELECT W.ID_wytwarzanie, P.Nazwa_produkt
FROM Wytwarzanie AS W
INNER JOIN Kontrola_jakosci_produkt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_produkt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
WHERE W.Czas_do IS NOT NULL
GO

CREATE VIEW v_Rodzaj_kontrola
AS
SELECT ID_rodzaj_kontrola AS ID, Rodzaj_kontrola AS [Rodzaj kontroli], Procedura AS [Procedura kontrolna]
FROM Rodzaj_kontrola
GO

CREATE VIEW v_Proces_polprodukt_czynnosc
AS
SELECT PPPC.ID_polprodukt AS [ID Półproduktu], SPP.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność], SP.ID_produkt AS [ID Produktu], PPPC.ID_proces_polprodukt
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SPP ON PPPC.ID_polprodukt = SPP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Sklad_produkt AS SP ON SPP.ID_polprodukt = SP.ID_polprodukt
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_produkt_czynnosc
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność] , PPC.ID_proces_produkt
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_polprodukt
AS
SELECT SP.Nazwa AS [Półprodukt], Count(PPPC.ID_polprodukt) AS [Liczba zabiegów]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY SP.Nazwa
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], Count(PPC.ID_produkt) AS [Liczba zabiegów]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Wytwarzanie
AS
SELECT W.ID_wytwarzanie AS [ID], ZS.ID_zamowienie_szczegol AS [ID zamówienie], Pr.Nazwa_produkt AS [Produkt], P.Nazwisko + ' ' + P.Imie AS [Pracownik],
W.Czas_od [Data rozpoczęcia], W.Czas_do AS [Data zakończenia]
FROM Wytwarzanie AS W
INNER JOIN Pracownik AS P ON W.ID_pracownik = P.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Produkt AS Pr ON ZS.ID_produkt = Pr.ID_produkt
GO

CREATE VIEW v_Zamowienie_szczegol_produkcja AS
SELECT Z.ID_zamowienie AS [ID], P.ID_produkt AS [ID produktu], P.Nazwa_produkt AS [Produkt], ZC.Ilosc AS [Ilość], ZC.ID_zamowienie_szczegol AS [ID_zamowienie_szczegol]
FROM Zamowienie_szczegol AS ZC
INNER JOIN Produkt AS P ON P.ID_produkt = ZC.ID_produkt
INNER JOIN Zamowienie AS Z ON Z.ID_zamowienie = ZC.ID_zamowienie
GO

CREATE VIEW v_Zamowienie_produkcja AS
SELECT Z.ID_zamowienie AS [ID], K.Nazwisko + ' ' + K.Imie + ' - ' + CONVERT(NVARCHAR,Z.Data_zamowienie) AS [Klient]
FROM Zamowienie AS Z
INNER JOIN Klient AS K ON K.ID_klient = Z.ID_zamowienie
INNER JOIN Pracownik AS P ON P.ID_pracownik = Z.ID_pracownik
ORDER BY Data_zamowienie DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Pracownik_produkcja
AS
SELECT P.ID_pracownik, P.Nazwisko + ' ' + P.Imie AS [Pracownik]
FROM Posada_pracownika AS PP
INNER JOIN Etat AS E ON PP.ID_etat = E.ID_etat
INNER JOIN Stanowisko AS S ON E.ID_stanowisko = S.ID_stanowisko
INNER JOIN Umowa AS U ON U.ID_posada_pracownika = PP.ID_posada_pracownika
INNER JOIN Pracownik AS P ON U.ID_pracownik = P.ID_pracownik
WHERE Nazwa_stanowiska IN ('Operator', 'Projektant', 'Brygadzista')
ORDER BY [Pracownik] OFFSET 0 ROWS
GO

CREATE VIEW v_Tygodniowe_rozliczenie_pracy_produkcja
AS
SELECT [Pracownik], SUM(DATEDIFF(HOUR, [Data rozpoczęcia],[Data zakończenia])) AS [Czas pracy]
FROM v_Wytwarzanie
GROUP BY [Pracownik]
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWPP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt_ewidencja
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa AS [Półprodukt], CP.Nazwa AS [Czynność produkcyjna], Pr.ID_pracownik, Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia], ISNULL(DATEDIFF(HOUR, W.Czas_od,W.Czas_do),0) AS [Czas pracy]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWPP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Szacowany_czas_wytwarzania_polprodukt
AS
SELECT [Półprodukt], FORMAT(SUM([Szacowany czas {min}])/CAST(60 AS DECIMAL (4,1)),'0.######') AS [Czas wytwarzania {h}] FROM v_Proces_wytwarzanie_polprodukt
GROUP BY [Półprodukt]
GO

CREATE VIEW v_Proces_wytwarzanie_produkt
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_produkt_ewidencja
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynność produkcyjna],Pr.ID_pracownik, Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczęcia], W.Czas_do AS [Data zakończenia], ISNULL(DATEDIFF(HOUR, W.Czas_od,W.Czas_do),0) AS [Czas pracy]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Wytworzone_produkty
AS
SELECT * FROM v_Proces_wytwarzanie_produkt
WHERE [Data zakończenia] <= GETDATE()
GO

CREATE VIEW v_Szacowany_czas_wytwarzania_produkt
AS
SELECT [Produkt], FORMAT(SUM([Szacowany czas {min}])/CAST(60 AS DECIMAL (4,1)),'0.######') AS [Czas wytwarzania {h}] FROM v_Proces_wytwarzanie_produkt
GROUP BY [Produkt]
GO

CREATE VIEW v_Stanowiska_w_uzyciu
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa 
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
WHERE W.Czas_do IS NULL OR W.Czas_do >= GETDATE()
UNION 
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa 
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PWPP.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
WHERE W.Czas_do IS NULL OR W.Czas_do >= GETDATE()
GO

CREATE VIEW v_Stanowiska_do_uzycia
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
EXCEPT
SELECT * FROM v_Stanowiska_w_uzyciu
GO



-----RESOURCE DEPARTMENT----


CREATE VIEW v_Sklad_maszyna 
AS 
SELECT Maszyna.ID_maszyna, Czesc.ID_czesc, Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Czesc.Nazwa_czesc AS [Nazwa części], Sklad_maszyna.Liczba_czesci AS [Liczba czesci]
FROM Sklad_maszyna 
INNER JOIN Maszyna
ON Sklad_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN Czesc 
ON Sklad_maszyna.ID_czesc=Czesc.ID_czesc
GROUP BY Maszyna.ID_maszyna, Czesc.ID_czesc, Maszyna.Nazwa_maszyna, Czesc.Nazwa_czesc, Sklad_maszyna.Liczba_czesci;
GO

CREATE VIEW v_Sklad_SP_maszyna
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], MS.ID_maszyna_nr, M.ID_maszyna, 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
GO

CREATE VIEW v_Pracownik_zasoby
AS
SELECT P.ID_pracownik, P.Nazwisko + ' ' + P.Imie + ', ' + S.Nazwa_stanowiska AS [Pracownik]
FROM Posada_pracownika AS PP
INNER JOIN Etat AS E ON PP.ID_etat = E.ID_etat
INNER JOIN Stanowisko AS S ON E.ID_stanowisko = S.ID_stanowisko
INNER JOIN Dzial ON E.ID_dzial = Dzial.ID_dzial
INNER JOIN Umowa AS U ON U.ID_posada_pracownika = PP.ID_posada_pracownika
INNER JOIN Pracownik AS P ON U.ID_pracownik = P.ID_pracownik
WHERE Dzial.ID_dzial = 4
GO

CREATE VIEW v_Pracownik_obslugi
AS
SELECT P.ID_pracownik, P.Nazwisko + ' ' + P.Imie + ', ' + S.Nazwa_stanowiska AS [Pracownik]
FROM Posada_pracownika AS PP
INNER JOIN Etat AS E ON PP.ID_etat = E.ID_etat
INNER JOIN Stanowisko AS S ON E.ID_stanowisko = S.ID_stanowisko
INNER JOIN Dzial ON E.ID_dzial = Dzial.ID_dzial
INNER JOIN Umowa AS U ON U.ID_posada_pracownika = PP.ID_posada_pracownika
INNER JOIN Pracownik AS P ON U.ID_pracownik = P.ID_pracownik
WHERE Dzial.ID_dzial = 5
GO

CREATE VIEW v_Rodzaj_parametr
AS
SELECT RP.ID_rodzaj_parametr, RP.Nazwa_rodzaj_parametr + ' ' + Jednostka.Skrot AS [Parametr]
FROM Rodzaj_parametr AS RP
INNER JOIN Jednostka ON RP.ID_jednostka = Jednostka.ID_jednostka
GO

CREATE VIEW v_Material
AS
SELECT Material.ID_material, Rodzaj_material.ID_rodzaj_material, Rodzaj_material.Nazwa_rodzaj_material AS [Rodzaj materiału], Nazwa_material AS [Nazwa materiału]
FROM Material
INNER JOIN Rodzaj_material ON Material.ID_rodzaj_material = Rodzaj_material.ID_rodzaj_material
GO

CREATE VIEW v_Czesci
AS
SELECT Czesc.ID_czesc, Rodzaj_czesc.ID_rodzaj_czesc, Rodzaj_czesc.Nazwa_rodzaj_czesc AS [Rodzaj części], Nazwa_czesc AS [Nazwa części]
FROM Czesc
INNER JOIN Rodzaj_czesc ON Czesc.ID_rodzaj_czesc = Rodzaj_czesc.ID_rodzaj_czesc
GO

CREATE VIEW v_Maszyna
AS
SELECT Maszyna.ID_maszyna, Rodzaj_maszyna.ID_rodzaj_maszyna, Rodzaj_maszyna.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny], Nazwa_maszyna AS [Nazwa maszyny], Koszt_RBG AS [Koszt roboczogodziny]
FROM Maszyna
INNER JOIN Rodzaj_maszyna ON Maszyna.ID_rodzaj_maszyna = Rodzaj_maszyna.ID_rodzaj_maszyna
GO

CREATE VIEW v_Dostawcy
AS
SELECT Dostawca.ID_dostawca, Nazwa_dostawca AS [Nazwa], DAD.Miejscowosc AS [Miejscowość], DAD.Ulica, DAD.Nr_budynku AS [Nr budynku], DAD.Kod_pocztowy AS [Kod pocztowy]
FROM Dostawca
INNER JOIN Dane_adresowe_dostawca AS DAD ON Dostawca.ID_dostawca = DAD.ID_dostawca
GO

CREATE VIEW v_Producenci
AS
SELECT Producent.ID_producent, Nazwa_producenta AS [Nazwa], DAP.Miejscowosc AS [Miejscowość], DAP.Ulica, DAP.Nr_budynku AS [Nr budynku], DAP.Kod_pocztowy AS [Kod pocztowy]
FROM Producent
INNER JOIN Dane_adresowe_producent AS DAP ON Producent.ID_producent = DAP.ID_producent
GO

CREATE VIEW v_Parametry_maszyna AS
SELECT Maszyna.ID_maszyna, Rodzaj_parametr.ID_rodzaj_parametr, Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_maszyna
INNER JOIN Maszyna
ON Parametr_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_maszyna.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Maszyna.ID_maszyna, Rodzaj_parametr.ID_rodzaj_parametr, Maszyna.Nazwa_maszyna, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_material AS
SELECT Material.ID_material, Rodzaj_parametr.ID_rodzaj_parametr, Material.Nazwa_material AS [Nazwa materiału], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_material
INNER JOIN Material
ON Parametr_material.ID_material=Material.ID_material
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_material.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Material.ID_material, Rodzaj_parametr.ID_rodzaj_parametr, Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_czesc AS
SELECT Czesc.ID_czesc, Rodzaj_parametr.ID_rodzaj_parametr, Czesc.Nazwa_czesc AS [Nazwa części], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_czesc
INNER JOIN Czesc
ON Parametr_czesc.ID_czesc=Czesc.ID_czesc
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_czesc.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Czesc.ID_czesc, Rodzaj_parametr.ID_rodzaj_parametr, Czesc.Nazwa_czesc, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_narzedzie AS
SELECT Narzedzie.ID_narzedzie, Rodzaj_parametr.ID_rodzaj_parametr, Narzedzie.Nazwa_narzedzie AS [Nazwa narzędzia], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_narzedzie
INNER JOIN Narzedzie
ON Parametr_narzedzie.ID_narzedzie=Narzedzie.ID_narzedzie
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_narzedzie.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Narzedzie.ID_narzedzie, Rodzaj_parametr.ID_rodzaj_parametr, Narzedzie.Nazwa_narzedzie, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
GO

CREATE VIEW v_Obslugi_zakonczone
AS
SELECT SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obsługa], Data_od AS [Data rozpoczęcia], Data_do AS [Data zakończenia], P.Imie + ' ' + P.Nazwisko AS [Pracownik]
FROM Obsluga_pracownik AS OP
INNER JOIN Obsluga AS O ON OP.ID_obsluga = O.ID_obsluga
INNER JOIN Pracownik AS P ON OP.ID_pracownik = P.ID_pracownik
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NOT NULL AND GETDATE() > Data_do
GO

CREATE VIEW v_Obslugi_w_trakcie
AS
SELECT ID_obsluga AS [ID], SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obsługa], Data_od AS [Data rozpoczęcia], Data_do AS [Data zakończenia]
FROM Obsluga AS O
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NULL
GO

CREATE VIEW v_Obslugi_w_trakcie_wymiana
AS
SELECT ID_obsluga AS [ID], SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obsługa], Data_od AS [Data rozpoczęcia], Data_do AS [Data zakończenia]
FROM Obsluga AS O
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NULL AND RO.Nazwa_rodzaj_obsluga = 'Wymiana czesci'
GO

CREATE VIEW v_Obsluga_cmb
AS
SELECT [ID], CONVERT(nvarchar,[ID]) + ': ' + [Obsługa] + ' - ' + CONVERT(nvarchar,[Data rozpoczęcia]) AS [ComboObsluga]
FROM v_Obslugi_w_trakcie
GO

CREATE VIEW v_Obsluga_pracownik
AS
SELECT Obsluga.ID_obsluga, Rodzaj_obsluga.Nazwa_rodzaj_obsluga AS [Obsługa], Pracownik.Nazwisko + ' ' + Pracownik.Imie AS [Pracownik]
FROM Obsluga_pracownik
INNER JOIN Obsluga ON Obsluga_pracownik.ID_obsluga = Obsluga.ID_obsluga
INNER JOIN Pracownik ON Obsluga_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Rodzaj_obsluga ON Obsluga.ID_rodzaj_obsluga = Rodzaj_obsluga.ID_rodzaj_obsluga
GROUP BY Obsluga.ID_obsluga, Rodzaj_obsluga.Nazwa_rodzaj_obsluga, Pracownik.Nazwisko + ' ' + Pracownik.Imie
GO

CREATE VIEW v_Maszyna_nr_seryjny
AS
SELECT Maszyna_nr_seryjny.ID_maszyna_nr, Nazwa_maszyna + ' ' + Nr_seryjny.Nr_seryjny AS [Maszyna nr]
FROM Maszyna
INNER JOIN Maszyna_nr_seryjny ON Maszyna.ID_maszyna = Maszyna_nr_seryjny.ID_maszyna
INNER JOIN Nr_seryjny ON Maszyna_nr_seryjny.ID_nr_seryjny = Nr_seryjny.ID_nr_seryjny
GO

CREATE VIEW v_Wymiana_czesc
AS
SELECT Obsluga.ID_obsluga, Maszyna_nr_seryjny.ID_maszyna_nr, Czesc.ID_czesc, Obsluga.Data_od, Obsluga.Data_do, Maszyna.Nazwa_maszyna, Nr_seryjny.Nr_seryjny, Czesc.Nazwa_czesc
FROM Wymiana_czesc
INNER JOIN Obsluga ON Wymiana_czesc.ID_obsluga = Obsluga.ID_obsluga
INNER JOIN Czesc ON Wymiana_czesc.ID_czesc = Czesc.ID_czesc
INNER JOIN Maszyna_nr_seryjny ON Wymiana_czesc.ID_maszyna_nr = Maszyna_nr_seryjny.ID_maszyna_nr
INNER JOIN Maszyna ON Maszyna_nr_seryjny.ID_maszyna = Maszyna.ID_maszyna
INNER JOIN Nr_seryjny ON Maszyna_nr_seryjny.ID_nr_seryjny = Nr_seryjny.ID_nr_seryjny
GROUP BY Obsluga.ID_obsluga, Maszyna_nr_seryjny.ID_maszyna_nr, Czesc.ID_czesc, Obsluga.Data_od, Obsluga.Data_do, Maszyna.Nazwa_maszyna, Nr_seryjny.Nr_seryjny, Czesc.Nazwa_czesc
GO

CREATE VIEW v_Wymiana_czesc_w_trakcie
AS
SELECT *
FROM v_Wymiana_czesc
WHERE Data_do IS NULL
GO

CREATE VIEW v_Zamowienia_czesci_w_trakcie_wszystko 
AS 
SELECT ZC.ID_zamowienie_czesc AS [Nr zamówienia], C.Nazwa_czesc AS [Nazwa części], SRZC.Data_stan [Data zmiany stanu], Ilosc AS [Ilość], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_czesc AS SZC 
INNER JOIN Zamowienie_czesc AS ZC ON SZC.ID_zamowienie_czesc = ZC.ID_zamowienie_czesc 
INNER JOIN Czesc AS C ON SZC.ID_czesc = C.ID_czesc 
INNER JOIN Stan_realizacji_zamowienie_czesc AS SRZC ON ZC.ID_zamowienie_czesc = SRZC.ID_zamowienie_czesc 
INNER JOIN Status_zamowienie AS SZ ON SRZC.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZC.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_czesci_w_trakcie_bez_odebranych 
AS 
SELECT ZCWTW.[Nr zamówienia], ZCWTW.[Nazwa części], ZCWTW.[Data zmiany stanu], ZCWTW.[Ilość], ZCWTW.Cena, ZCWTW.[Status], ZCWTW.[StatusID] 
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

CREATE VIEW v_Magazyn_maszyn_uzywane
AS
SELECT Maszyna, COUNT(Maszyna) AS [Liczba]
FROM v_Sklad_stanowisko_produkcyjne_maszyna AS SSPM
GROUP BY Maszyna
GO

CREATE VIEW v_Magazyn_maszyn_stan
AS
SELECT [Nazwa maszyny], [Liczba sztuk], IsNull(Liczba,0) as Używane
FROM v_Magazyn_maszyn_wszystko AS MMW
LEFT JOIN v_Magazyn_maszyn_uzywane AS MMU ON MMW.[Nazwa maszyny]=MMU.Maszyna
GO

CREATE VIEW v_Magazyn_maszyn_nieuzywane
AS
SELECT [Nazwa maszyny], [Liczba sztuk]-Używane AS [Ilość w magazynie]
FROM v_Magazyn_maszyn_stan
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

CREATE VIEW v_Magazyn_czesci_wszystko
AS
SELECT [Nazwa części], [Ilość]
FROM v_Zamowienia_czesci_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa części], [Ilość]
GO

CREATE VIEW v_Magazyn_czesci_wymienione
AS
SELECT C.Nazwa_czesc AS [Nazwa części], COUNT([Nazwa_czesc]) AS [Wymieniono]
FROM Wymiana_czesc AS WC
INNER JOIN Czesc AS C ON WC.ID_czesc = C.ID_czesc 
GROUP BY C.Nazwa_czesc
GO

CREATE VIEW v_Magazyn_czesci_stan
AS
SELECT MCW.[Nazwa części], MCW.[Ilość], ISNULL([Wymieniono],0) AS [Wymienione części]
FROM v_Magazyn_czesci_wszystko AS MCW
LEFT JOIN v_Magazyn_czesci_wymienione AS MCWy ON MCW.[Nazwa części]=MCWy.[Nazwa części]
GO

CREATE VIEW v_Magazyn_czesci_aktualny
AS
SELECT [Nazwa części], [Ilość]-[Wymienione części] AS [Ilość w magazynie]
FROM v_Magazyn_czesci_stan
GO

CREATE VIEW v_Magazyn_Produkty_Wytworzone
AS
SELECT KPP.Produkt AS [Nazwa Produktu], KPP.[Rezultat kontroli]
FROM v_Kontrola_parametr_produkt AS KPP
GO

CREATE VIEW v_Maszyny_numery_przypisane
AS
SELECT Maszyna.ID_maszyna AS [ID], Maszyna.Nazwa_maszyna AS [Nazwa maszyny], COUNT(Maszyna.Nazwa_maszyna) AS [Ile przypisano]
FROM Maszyna_nr_seryjny AS MNS
INNER JOIN Maszyna ON MNS.ID_maszyna = Maszyna.ID_maszyna
INNER JOIN Nr_seryjny ON MNS.ID_nr_seryjny = Nr_seryjny.ID_nr_seryjny
GROUP BY Maszyna.ID_maszyna, Maszyna.Nazwa_maszyna
GO

CREATE VIEW v_Maszyny_numery_porownanie
AS
SELECT [ID], MMW.[Nazwa maszyny], MMW.[Liczba sztuk], MNP.[Ile przypisano]
FROM v_Magazyn_maszyn_wszystko AS MMW
LEFT JOIN v_Maszyny_numery_przypisane AS MNP ON MMW.[Nazwa maszyny] = MNP.[Nazwa maszyny]
GO

CREATE VIEW v_Maszyny_numery_nieprzypisane
AS
SELECT [ID], [Nazwa maszyny], [Liczba sztuk]-[Ile przypisano] AS [Nieprzypisanych]
FROM v_Maszyny_numery_porownanie
GO

CREATE VIEW v_Maszyny_numery_nieprzypisane_zero
AS
SELECT * FROM v_Maszyny_numery_nieprzypisane
WHERE [Nieprzypisanych]>0
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
	SELECT Klient.ID_klient AS [ID], Klient.Nazwisko AS [Nazwisko], Klient.Imie AS [Imię], Klient.NIP, Dane_adresowe_klient.Miejscowosc AS [Miejscowość], 
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

CREATE VIEW v_Koszt_godziny_pracy
AS
SELECT dbo.Pracownik.ID_pracownik, dbo.Pracownik.Nazwisko, dbo.Pracownik.Imie, dbo.Umowa.Wynagrodzenie, dbo.Czas_pracy.Liczba_godzin, dbo.Umowa.Wynagrodzenie / dbo.Czas_pracy.Liczba_godzin AS [Koszt godziny pracy], 
MONTH(dbo.Czas_pracy.Data) AS Miesiąc
FROM     dbo.Umowa INNER JOIN
dbo.Pracownik ON dbo.Umowa.ID_pracownik = dbo.Pracownik.ID_pracownik CROSS JOIN
dbo.Czas_pracy
GO