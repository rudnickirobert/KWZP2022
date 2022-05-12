USE master
GO
DROP DATABASE KWZP
GO
CREATE DATABASE KWZP
GO
USE KWZP
GO
CREATE TABLE Wyksztalcenie(
ID_wyksztalcenie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa VARCHAR(35) NOT NULL
);

CREATE TABLE Pracownik
	(
	ID_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko VARCHAR(50) NOT NULL,
	Imie VARCHAR(50) NOT NULL,
	Nr_dowodu VARCHAR(9) NOT NULL,
	Pesel BIGINT NOT NULL,
	ID_wyksztalcenie INT FOREIGN KEY 
		REFERENCES Wyksztalcenie(ID_wyksztalcenie) NOT NULL,
);

CREATE TABLE Dane_adresowe_pracownik
	(
	ID_dane_adresowe_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Miejscowosc VARCHAR(50) NOT NULL,
	Ulica VARCHAR(50),
	Nr_budynku VARCHAR(10)NOT NULL,
	Nr_lokalu VARCHAR(10),
	Kod_pocztowy VARCHAR(5) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Nr_telefon_pracownik
	(
	ID_Nr_telefon_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Numer VARCHAR(20) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Email_pracownik(
	ID_email_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Stanowisko
	(
	ID_stanowisko INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_stanowiska VARCHAR(50) NOT NULL
);

CREATE TABLE Dzial
	(
	ID_dzial INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_dzial VARCHAR(50) NOT NULL
);

CREATE TABLE Rodzaj_kontrola
	(
	ID_rodzaj_kontrola INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Rodzaj_kontrola NVARCHAR(50) NOT NULL,
	Procedura NVARCHAR(250) NOT NULL
);

CREATE TABLE Produkt
	(
	ID_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_produkt NVARCHAR(50) NOT NULL
);

CREATE TABLE Jednostka 
	(
	ID_jednostka INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
	Nazwa_jednostka NVARCHAR(100) NOT NULL,
	Skrot NVARCHAR(10) NOT NULL
);

CREATE TABLE Rodzaj_parametr
	(
	ID_rodzaj_parametr INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_parametr NVARCHAR(50) NOT NULL,
	ID_jednostka INT FOREIGN KEY 
		REFERENCES Jednostka(ID_jednostka) NOT NULL
);

CREATE TABLE Parametr_produkt
	(
	ID_parametr_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
);


CREATE TABLE Slownik_polprodukt
	(
	ID_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL
);

CREATE TABLE Rodzaj_material
	(
	ID_rodzaj_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_rodzaj_material nvarchar(50) NOT NULL
);

CREATE TABLE Material 
	(
	ID_material int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_rodzaj_material INT FOREIGN KEY 
		REFERENCES Rodzaj_material(ID_rodzaj_material) NOT NULL,
	Nazwa_material nvarchar(100) NOT NULL

);

CREATE TABLE Sklad_polprodukt
	(
	ID_sklad_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_material INT FOREIGN KEY
		REFERENCES Material(ID_material) NOT NULL,
	Liczba INT NOT NULL
);

CREATE TABLE Parametr_polprodukt
	(
	ID_parametr_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
);

CREATE TABLE Sklad_produkt
	(
	ID_sklad_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_polprodukt INT FOREIGN KEY
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	Liczba INT NOT NULL
);

CREATE TABLE Sklad_produkt_material
	(
	ID_sklad_produkt_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_material INT FOREIGN KEY
		REFERENCES Material(ID_material) NOT NULL,
	Liczba INT NOT NULL
);

CREATE TABLE Czynnosc_produkcyjna
	(
	ID_czynnosc_produkcyjna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL
);

CREATE TABLE Slownik_stanowisko
	(
	ID_nazwa_stanowiska INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_stanowiska NVARCHAR(50) NOT NULL
);

CREATE TABLE Nr_seryjny
	(
	ID_nr_seryjny INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nr_seryjny nvarchar(30) UNIQUE NOT NULL
);

CREATE TABLE Rodzaj_maszyna	
	(
	ID_rodzaj_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_maszyna NVARCHAR(50) NOT NULL,
	Opis NVARCHAR(50)
);

CREATE TABLE Maszyna
	(
	ID_maszyna int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_maszyna nvarchar(50) NOT NULL,
	ID_rodzaj_maszyna int FOREIGN KEY 
		REFERENCES Rodzaj_maszyna(ID_rodzaj_maszyna) NOT NULL,
	Koszt_RBG DECIMAL(15,2) NOT NULL
);

CREATE TABLE Maszyna_nr_seryjny
	(
	ID_maszyna_nr int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_nr_seryjny INT FOREIGN KEY 
		REFERENCES Nr_seryjny(ID_nr_seryjny) NOT NULL
);

CREATE TABLE Stanowisko_produkcyjne
	(
	ID_stanowisko_produkcyjne INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_nazwa_stanowiska INT FOREIGN KEY
		REFERENCES Slownik_stanowisko(ID_nazwa_stanowiska) NOT NULL
);

CREATE TABLE Proces_polprodukt_czynnosc 
	(
	ID_proces_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_czynnosc_produkcyjna INT FOREIGN KEY 
		REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL,
	Czas_trwania INT NOT NULL,
);

CREATE TABLE Proces_produkt_czynnosc 
	(
	ID_proces_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_czynnosc_produkcyjna INT FOREIGN KEY 
		REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL,
	Czas_trwania INT NOT NULL,
);

CREATE TABLE Narzedzie
	(
	ID_narzedzie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_narzedzie NVARCHAR(50) NOT NULL
);

CREATE TABLE Sklad_stanowisko_produkcyjne_maszyna
	(
	ID_sklad_stanowisko_produkcyjne_maszyna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	ID_maszyna_nr INT FOREIGN KEY
		REFERENCES Maszyna_nr_seryjny(ID_maszyna_nr) NOT NULL,
	);

CREATE TABLE Sklad_stanowisko_produkcyjne_narzedzie
	(
	ID_sklad_stanowisko_produkcyjne_narzedzie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	ID_narzedzie INT FOREIGN KEY
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	Liczba INT NOT NULL
);

CREATE TABLE Rodzaj_czesc 
	(
	ID_rodzaj_czesc int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_czesc nvarchar(50) NOT NULL
);

CREATE TABLE Czesc 
	(
	ID_czesc int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_czesc nvarchar(50) NOT NULL,
	ID_rodzaj_czesc int FOREIGN KEY 
		REFERENCES Rodzaj_czesc(ID_rodzaj_czesc) NOT NULL
);

CREATE TABLE Etat	
	(
	ID_etat INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko INT FOREIGN KEY 
		REFERENCES Stanowisko(ID_stanowisko) NOT NULL,
	ID_dzial INT FOREIGN KEY 
		REFERENCES Dzial(ID_dzial) NOT NULL,
	Liczba_miejsc INT NOT NULL,
);

CREATE TABLE Posada_pracownika
	(
	ID_posada_pracownika INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_etat INT FOREIGN KEY
		REFERENCES Etat(ID_etat),
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Rodzaj_umowy
	(
	ID_rodzaj_umowy INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Urlop INT NOT NULL,
);

CREATE TABLE Rodzaj_nieobecnosci
	(
	ID_rodzaj_nieobecnosci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Symbol NVARCHAR(10) NOT NULL,
	Wspolczynnik_wynagrodzenia DECIMAL (2,1) 
);

CREATE TABLE Nieobecnosc
	(
	ID_nieobecnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY
	REFERENCES Pracownik(ID_pracownik),
	ID_rodzaj_nieobecnosci  INT FOREIGN KEY
		REFERENCES Rodzaj_nieobecnosci(ID_rodzaj_nieobecnosci),
	Data_od DATE NOT NULL,
	Data_do DATE NOT NULL,
);

CREATE TABLE Wymiar_pracy
	(
	ID_wymiar_pracy INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Wspolczynnik_wynagrodzenia DECIMAL (2,1)
);

CREATE TABLE Umowa
	(
	ID_umowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wymiar_pracy INT FOREIGN KEY
		REFERENCES Wymiar_pracy(ID_wymiar_pracy),
	ID_rodzaj_umowy INT FOREIGN KEY
		REFERENCES Rodzaj_umowy(ID_rodzaj_umowy),
	ID_pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik),
	ID_posada_pracownika INT FOREIGN KEY
		REFERENCES Posada_pracownika(ID_posada_pracownika),
	Wynagrodzenie INT NOT NULL,
);
CREATE TABLE Klient
	(
	ID_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	NIP NVARCHAR(10)
);

CREATE TABLE Dane_adresowe_klient
	(
	ID_dane_adresowe_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY 
		REFERENCES Klient(ID_klient) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_budynek INT NOT NULL,
	Nr_lokal INT,
	Kod_pocztowy NVARCHAR(10) NOT NULL
);

CREATE TABLE Nr_telefon_klient
	(
	ID_nr_telefon_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY 
		REFERENCES Klient(ID_klient) NOT NULL,
	Numer NVARCHAR(20) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Email_klient
	(
	ID_email_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY 
		REFERENCES Klient(ID_klient) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Typ_zamowienie
	(
	ID_typ_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Rodzaj_zamowienie NVARCHAR(50) NOT NULL
);

CREATE TABLE Zamowienie
	(
	ID_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY 
		REFERENCES Klient(ID_klient) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienie DATE NOT NULL,
	ID_typ_zamowienie INT FOREIGN KEY 
		REFERENCES Typ_zamowienie(ID_typ_zamowienie) NOT NULL 

);

CREATE TABLE Zamowienie_szczegol
	(
	ID_zamowienie_szczegol INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Status_oferta
	(
	ID_status_oferta INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_status_oferta NVARCHAR(20) NOT NULL
);

CREATE TABLE Gwarancja
	(
	ID_gwarancja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Okres_gwarancja INT NOT NULL,
	Opis_gwarancja NVARCHAR(100)
);

CREATE TABLE Oferta_handlowa
	(
	ID_oferta_handlowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY 
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Termin_realizacja DATE NOT NULL,
	ID_gwarancja INT FOREIGN KEY 
		REFERENCES Gwarancja(ID_gwarancja) NOT NULL,
	ID_status_oferta INT FOREIGN KEY 
		REFERENCES Status_oferta(ID_status_oferta) NOT NULL,
	Cena INT,
);

CREATE TABLE Wytwarzanie
	(
	ID_wytwarzanie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie_szczegol INT FOREIGN KEY
		REFERENCES Zamowienie_szczegol(ID_zamowienie_szczegol) NOT NULL,
	Czas_od DATETIME NOT NULL,
	Czas_do DATETIME
);

CREATE TABLE Proces_wytwarzanie_produkt
	(
	ID_proces_wytwarzanie_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_proces_produkt INT FOREIGN KEY
		REFERENCES Proces_produkt_czynnosc(ID_proces_produkt),
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES	Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL
);

CREATE TABLE Proces_wytwarzanie_polprodukt
	(
	ID_proces_wytwarzanie_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_proces_polprodukt INT FOREIGN KEY
		REFERENCES Proces_polprodukt_czynnosc(ID_proces_polprodukt),
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES	Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL
);

CREATE TABLE Kontrola_jakosci_produkt
	(
	ID_kontrola_jakosci_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_rodzaj_kontrola INT FOREIGN KEY
		REFERENCES Rodzaj_kontrola(ID_rodzaj_kontrola) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME, 
	Uwagi NVARCHAR(250)
);

CREATE TABLE Kontrola_parametr
(
	ID_kontrola_parametr INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_kontrola_jakosci_produkt INT FOREIGN KEY 
	REFERENCES Kontrola_jakosci_produkt(ID_kontrola_jakosci_produkt) NOT NULL,
	ID_parametr_produkt INT FOREIGN KEY
	REFERENCES Parametr_produkt (ID_parametr_produkt) NOT NULL,
	Wartosc DECIMAL(15,2) NOT NULL
)

CREATE TABLE Forma_platnosc
	(
	ID_forma_platnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Forma_platnosc NVARCHAR(100) NOT NULL
);

CREATE TABLE Podatek
	(
	ID_podatek INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Procent INT NOT NULL,
);


CREATE TABLE Umowa_sprzedaz
	(
	ID_umowa_sprzedaz INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_oferta_handlowa INT FOREIGN KEY 
		REFERENCES Oferta_handlowa(ID_oferta_handlowa) NOT NULL,
);


CREATE TABLE Sprzedaz
	(
	ID_sprzedaz INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nr_sprzedaz INT NOT NULL,
	Data_sprzedaz_poczatek DATE NOT NULL,
	Data_sprzedaz_koniec DATE NOT NULL,
	Termin_zaplata DATE NOT NULL,
	ID_forma_platnosc INT FOREIGN KEY 
		REFERENCES Forma_platnosc(ID_forma_platnosc) NOT NULL,
	ID_umowa_sprzedaz INT FOREIGN KEY 
		REFERENCES Umowa_sprzedaz(ID_umowa_sprzedaz) NOT NULL
);

CREATE TABLE Szczegoly_sprzedaz
	(
	ID_szczegoly_sprzedaz INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz INT FOREIGN KEY 
		REFERENCES Sprzedaz(ID_sprzedaz) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_Produkt) NOT NULL,
	Kwota_sprzedaz INT NOT NULL,
	ID_podatek INT FOREIGN KEY 
		REFERENCES Podatek(ID_Podatek) NOT NULL,
		Ilosc INT NOT NULL
);

CREATE TABLE Reklamacja
	(
	ID_reklamacja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_sprzedaz INT FOREIGN KEY 
		REFERENCES Sprzedaz(ID_sprzedaz) NOT NULL,
	Data_reklamacja DATE NOT NULL,
	Opis_reklamacja NVARCHAR(250) NOT NULL,
);
	
CREATE TABLE Zwrot
	(
	ID_zwrot INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja INT FOREIGN KEY 
		REFERENCES Reklamacja(ID_reklamacja) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_Produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Akceptacja BIT NOT NULL
);


CREATE TABLE Rodzaj_obsluga
	(
	ID_rodzaj_obsluga INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_obsluga NVARCHAR(50) NOT NULL
);
 

CREATE TABLE Dostawca
	(
	ID_dostawca INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_dostawca NVARCHAR(50) NOT NULL
);
 
CREATE TABLE Producent 
	(
	ID_producent INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_producenta NVARCHAR(50) NOT NULL
);

CREATE TABLE Status_zamowienie 
	(
	ID_status_zamowienie INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_status NVARCHAR(20) NOT NULL

);

CREATE TABLE Zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT FOREIGN KEY 
		REFERENCES Zamowienie_maszyna(ID_zamowienie_maszyna) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZM PRIMARY KEY (ID_zamowienie_maszyna, ID_status_zamowienie)
);
 
CREATE TABLE Szczegoly_zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT FOREIGN KEY
		REFERENCES Zamowienie_maszyna(ID_zamowienie_maszyna) NOT NULL,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Ilosc INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_SzczegolyZM PRIMARY KEY (ID_zamowienie_maszyna, ID_maszyna, ID_producent)
);
 
CREATE TABLE Zamowienie_narzedzie 
	(
	ID_zamowienie_narzedzie int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_narzedzie 
	(
	ID_zamowienie_narzedzie INT FOREIGN KEY 
		REFERENCES Zamowienie_narzedzie(ID_zamowienie_narzedzie) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZN PRIMARY KEY (ID_zamowienie_narzedzie, ID_status_zamowienie)
);
 
CREATE TABLE Szczegoly_zamowienie_narzedzie
	(
	ID_zamowienie_narzedzie int FOREIGN KEY 
		REFERENCES Zamowienie_narzedzie(ID_zamowienie_narzedzie) NOT NULL,
	ID_narzedzie INT FOREIGN KEY 
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Sztuk INT NOT NULL,
	Cena decimal(15,2) NOT NULL,
	CONSTRAINT PK_SzczegolyZN PRIMARY KEY (ID_zamowienie_narzedzie, ID_narzedzie, ID_producent)
);
 
CREATE TABLE Sklad_maszyna 
	(
	ID_sklad_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	Liczba_czesci INT NOT NULL
);

CREATE TABLE Obsluga
	(
	ID_obsluga INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_rodzaj_obsluga INT FOREIGN KEY
		REFERENCES Rodzaj_obsluga(ID_rodzaj_obsluga) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME
);

CREATE TABLE Obsluga_pracownik
	(
	ID_obsluga INT FOREIGN KEY 
		REFERENCES Obsluga(ID_Obsluga) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_Pracownik) NOT NULL,
	CONSTRAINT PK_ObsPrac PRIMARY KEY (ID_obsluga, ID_pracownik)
);

CREATE TABLE Wymiana_czesc
	(
	ID_obsluga INT FOREIGN KEY 
		REFERENCES Obsluga(ID_Obsluga) NOT NULL,
	ID_maszyna_nr INT FOREIGN KEY 
		REFERENCES Maszyna_nr_seryjny(ID_maszyna_nr) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL
	CONSTRAINT PK_WymCZ PRIMARY KEY (ID_obsluga, ID_maszyna_nr, ID_czesc)
);

CREATE TABLE Parametr_material 
	(
	ID_material INT FOREIGN KEY 
		REFERENCES Material(ID_material) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_ParametrMat PRIMARY KEY (ID_material, ID_rodzaj_parametr)
);

CREATE TABLE Parametr_narzedzie
	(
	ID_narzedzie INT FOREIGN KEY 
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_ParametrNarz PRIMARY KEY (ID_narzedzie, ID_rodzaj_parametr)
);

CREATE TABLE Parametr_maszyna 
	(
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_rodzaj_parametr int FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_ParametrMasz PRIMARY KEY (ID_maszyna, ID_rodzaj_parametr)
);

CREATE TABLE Parametr_czesc 
	(
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	ID_rodzaj_parametr int FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_ParametrCz PRIMARY KEY (ID_czesc, ID_rodzaj_parametr)
);

CREATE TABLE Dane_adresowe_producent
	(
	ID_dane_adresowe_producent INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50) NOT NULL,
	Nr_budynku INT NOT NULL,
	Kod_pocztowy NVARCHAR(10)
);

CREATE TABLE Dane_adresowe_dostawca
	(
	ID_dane_adresowe_dostawca INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50) NOT NULL,
	Nr_budynku INT NOT NULL,
	Kod_pocztowy NVARCHAR(10)
);

CREATE TABLE Zamowienie_material 
	(
	ID_zamowienie_material INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
		Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_material 
	(
	ID_zamowienie_material INT FOREIGN KEY 
		REFERENCES Zamowienie_material(ID_zamowienie_material) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
		CONSTRAINT PK_StanRZMAT PRIMARY KEY (ID_zamowienie_material, ID_status_zamowienie, ID_pracownik)
);
 
CREATE TABLE Szczegoly_zamowienie_material
	(
	ID_zamowienie_material INT FOREIGN KEY 
		REFERENCES Zamowienie_material(ID_zamowienie_material) NOT NULL,
	ID_material INT FOREIGN KEY 
		REFERENCES Material(ID_material) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Waga_g INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
		CONSTRAINT PK_SzczegolyZMAT PRIMARY KEY (ID_zamowienie_material, ID_material, ID_producent)
);

CREATE TABLE Zamowienie_czesc 
	(
	ID_zamowienie_czesc int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik int FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);

CREATE TABLE Stan_realizacji_zamowienie_czesc 
	(
	ID_zamowienie_czesc INT FOREIGN KEY 
		REFERENCES Zamowienie_czesc(ID_zamowienie_czesc) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZCZ PRIMARY KEY (ID_zamowienie_czesc, ID_status_zamowienie, ID_pracownik)
);

CREATE TABLE Szczegoly_zamowienie_czesc 
	(
	ID_zamowienie_czesc INT FOREIGN KEY 
		REFERENCES Zamowienie_czesc(ID_zamowienie_czesc) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Ilosc INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
		CONSTRAINT PK_SzczegolyZCZ PRIMARY KEY (ID_zamowienie_czesc, ID_czesc, ID_producent)
);

CREATE TABLE Alert
	(
	ID_alert INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dzial INT FOREIGN KEY
		REFERENCES Dzial(ID_dzial) NOT NULL,
	Tresc NVARCHAR(250) NOT NULL,
	Czy_odczytano BIT NOT NULL
);
CREATE TABLE Nadgodziny 
	(
	ID_nadgodziny INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY
	REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_nadgodziny DATE NOT NULL,
	Czas INT NOT NULL
);

CREATE TABLE Czas_pracy
	(
	ID_czas_pracy  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Data DATE NOT NULL,
	Liczba_godzin INT NOT NULL
);

CREATE TABLE Wyplata
	(
	ID_wyplata INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_Pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_wyplaty DATE NOT NULL
);