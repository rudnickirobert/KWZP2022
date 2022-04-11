USE MASTER
GO
DROP DATABASE KWZP
GO
CREATE DATABASE KWZP
GO
USE KWZP

CREATE TABLE Dane_adresowe_pracownik(
	ID_dane_adresowe_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Miejscowosc VARCHAR(50) NOT NULL,
	Ulica VARCHAR(50),
	Nr_budynku VARCHAR(10)NOT NULL,
	Nr_lokalu VARCHAR(10),
	Kod_pocztowy VARCHAR(5) NOT NULL
)

CREATE TABLE Nr_telefon_pracownik(
	ID_nr_telefon_pracownik int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Numer VARCHAR(20) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
)

CREATE TABLE Email_pracownik(
	ID_email_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
)

CREATE TABLE Stanowisko(
	ID_stanowisko INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa VARCHAR(50) NOT NULL
)

CREATE TABLE Dzial(
	ID_dzial INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa VARCHAR(50) NOT NULL
)

CREATE TABLE Stanowisko_dzial(
	ID_stanowisko_dzial INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko INT FOREIGN KEY 
		REFERENCES Stanowisko(ID_stanowisko) NOT NULL,
	ID_dzial INT FOREIGN KEY 
		REFERENCES Dzial(ID_dzial) NOT NULL
)

CREATE TABLE Pracownicy(
	ID_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko VARCHAR(50) NOT NULL,
	Imie VARCHAR(50) NOT NULL,
	ID_dane_adresowe int FOREIGN KEY 
		REFERENCES Dane_adresowe_pracownik(ID_dane_adresowe_pracownik),
	Nr_dowodu VARCHAR(9) NOT NULL,
	Pesel VARCHAR(10) NOT NULL,
	ID_nr_telefon INT FOREIGN KEY 
		REFERENCES Nr_telefon_pracownik(ID_nr_telefon_pracownik),
	ID_email_pracownik INT FOREIGN KEY 
	REFERENCES Email_pracownik(ID_email_pracownik)
	-- ID_umowa INT FOREIGN KEY REFERENCES Umowa(ID_umowa),
)

CREATE TABLE Rodzaj_kontroli(
ID_rodzaj_kontroli INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Rodzaj_kontroli NVARCHAR(50) NOT NULL,
Procedura NVARCHAR(250) NOT NULL
)

CREATE TABLE Rezultat_kontroli(
ID_rezultat INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Wynik NVARCHAR(50) NOT NULL,
Uwagi NVARCHAR(250)
)

CREATE TABLE Produkt(
ID_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_proces_technologoiczny INT FOREIGN KEY
	REFERENCES Proces_technologiczny(ID_proces_technologiczny) NOT NULL,
Nazwa_produktu NVARCHAR(50) NOT NULL,
Cena_produkt MONEY NOT NULL
)

CREATE TABLE Wytworzony_produkt(
ID_wytworzony_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_produkt INT FOREIGN KEY
	REFERENCES Produkt(ID_produkt) NOT NULL,
Data_ukonczenia DATE NOT NULL
)


CREATE TABLE Kontrola_jakosci_produkt(
ID_wytworzony_produkt INT FOREIGN KEY
	REFERENCES Wytworzony_produkt(ID_wytworzony_produkt) NOT NULL,
ID_pracownik INT FOREIGN KEY 
	REFERENCES Pracownicy(ID_pracownik) NOT NULL,
ID_rodzaj_kontroli INT FOREIGN KEY
	REFERENCES Rodzaj_kontroli(ID_rodzaj_kontroli) NOT NULL,
Data_od DATETIME NOT NULL,
Data_do DATETIME, 
ID_rezultat INT FOREIGN KEY 
	REFERENCES Rezultat_kontroli(ID_rezultat) NOT NULL
)

CREATE TABLE Parametr_produkt(
ID_parametr INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa NVARCHAR(50) NOT NULL,
Wartosc_gorna INT,
Nominal INT NOT NULL,
Wartosc_dolna INT
)

CREATE TABLE Szczegoly_produkt(
ID_produkt INT FOREIGN KEY
	REFERENCES Produkt(ID_produkt) NOT NULL,
ID_parametr INT FOREIGN KEY
	REFERENCES Parametr_produkt(ID_parametr) NOT NULL
)

CREATE TABLE Slownik_polprodukt(
ID_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa NVARCHAR(50) NOT NULL
)

CREATE TABLE Materialy (
ID_material int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa_materialu nvarchar(25) NOT NULL
);


CREATE TABLE Sklad_polprodukt(
ID_polprodukt INT FOREIGN KEY 
	REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
ID_material INT FOREIGN KEY
	REFERENCES Materialy(ID_material) NOT NULL,
Liczba INT NOT NULL
)


CREATE TABLE Parametr_polprodukt(
ID_parametr INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa NVARCHAR(50) NOT NULL,
Wartosc_gorna INT,
Nominal INT NOT NULL,
Wartosc_dolna INT
)

CREATE TABLE Sklad_produkt(
ID_produkt INT FOREIGN KEY
	REFERENCES Produkt(ID_produkt) NOT NULL,
ID_polprodukt INT FOREIGN KEY
	REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
Liczba INT NOT NULL
)

CREATE TABLE Sklad_produkt_material(
ID_produkt INT FOREIGN KEY
	REFERENCES Produkt(ID_produkt) NOT NULL,
ID_material INT FOREIGN KEY
	REFERENCES Materialy(ID_material) NOT NULL,
Liczba INT NOT NULL
)

CREATE TABLE Czynnosc_produkcyjna(
ID_czynnosc_produkcyjna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa NVARCHAR(50) NOT NULL
)

CREATE TABLE Slownik_stanowisko(
ID_nazwa_stanowiska INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa_stanowiska NVARCHAR(50) NOT NULL
)

CREATE TABLE Rodzaj_maszyny (
ID_rodzaj_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa nvarchar(20) NOT NULL,
Opis nvarchar(50)
);

CREATE TABLE Maszyny(
ID_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa nvarchar(25) NOT NULL,
ID_rodzaj_maszyny int FOREIGN KEY REFERENCES Rodzaj_maszyny(ID_rodzaj_maszyny) NOT NULL,
Nr_seryjny nvarchar(25) NOT NULL
);

CREATE TABLE Stanowisko_produkcyjne(
ID_stanowisko_produkcyjne INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_maszyny INT FOREIGN KEY 
	REFERENCES Maszyny(ID_maszyny) NOT NULL,
ID_nazwa_stanowiska INT FOREIGN KEY
	REFERENCES Slownik_stanowisko(ID_nazwa_stanowiska) NOT NULL
)

CREATE TABLE Etap_produkcji(
ID_etap_produkcji INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_stanowisko_produkcyjne INT FOREIGN KEY
	REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
ID_czynnosc_produkcyjna INT FOREIGN KEY
	REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL
)

CREATE TABLE Wytwarzanie_polprodukt(
ID_polprodukt INT FOREIGN KEY
	REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
ID_pracownik INT FOREIGN KEY 
	REFERENCES Pracownicy(ID_pracownik) NOT NULL,
ID_etap_produkcji INT FOREIGN KEY
	REFERENCES Etap_produkcji(ID_etap_produkcji) NOT NULL,
Czas_od DATETIME NOT NULL,
Czas_do DATETIME
)
CREATE TABLE Narzedzia(
ID_narzedzia INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa NVARCHAR(50) NOT NULL,
Nr_seryjny INT NOT NULL
)

CREATE TABLE Sklad_stanowisko_produkcyjne_maszyny(
ID_stanowisko_produkcyjne INT FOREIGN KEY
	REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
ID_maszyny INT FOREIGN KEY
	REFERENCES Maszyny(ID_maszyny) NOT NULL,
)

CREATE TABLE Sklad_stanowisko_produkcyjne(
ID_stanowisko_produkcyjne INT FOREIGN KEY
	REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
ID_narzedzia INT FOREIGN KEY
	REFERENCES Narzedzia(ID_narzedzia) NOT NULL,
)

CREATE TABLE Rodzaj_czesci (
ID_rodzaj_czesci int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa nvarchar(20) NOT NULL
);

CREATE TABLE Czesci (
ID_czesci int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa_czesci nvarchar(25) NOT NULL,
ID_rodzaj_czesci int FOREIGN KEY REFERENCES Rodzaj_czesci(ID_rodzaj_czesci) NOT NULL
);

CREATE TABLE Wymienione_czesci(
ID_wymienione_czesci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_czesci INT FOREIGN KEY
	REFERENCES Czesci(ID_czesci)
)

CREATE TABLE Posada_pracownik(
	ID_posada INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownicy(ID_pracownik) NOT NULL,
	ID_stanowisko_dzial int FOREIGN KEY 
		REFERENCES Stanowisko_dzial(ID_stanowisko_dzial) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
	)

CREATE TABLE Klient
	(
	ID_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	NIP NVARCHAR(10) NOT NULL
	)

CREATE TABLE Dane_adresowe_klient
	(
	ID_dane_adresowe_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_budynku INT NOT NULL,
	Nr_lokalu INT,
	Kod_pocztowy NVARCHAR(5) NOT NULL
	)

CREATE TABLE Nr_telefon_klient
	(
	ID_nr_telefon_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL,
	Numer NVARCHAR(20) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
	)

CREATE TABLE Email_klient
	(
	ID_email_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
	)

CREATE TABLE Typ_zamowienia
	(
	ID_typ_zamowienia INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Typ_zamowienia NVARCHAR(50) NOT NULL
	)

CREATE TABLE Zamowienie
	(
	ID_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_typ_zamowienia INT FOREIGN KEY REFERENCES Typ_zamowienia(ID_typ_zamowienia) NOT NULL 
	)

CREATE TABLE Szczegoly_zamowienia
	(
	ID_szczegoly_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL
	)

CREATE TABLE Status_oferty
	(
	ID_status_oferty INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_status NVARCHAR(20) NOT NULL
	)

CREATE TABLE Gwarancja
	(
	ID_gwarancja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Okres_gwarancja TIME NOT NULL,
	Opis_gwarancja NVARCHAR(100)
	)

CREATE TABLE Oferta_handlowa
	(
	ID_oferta_handlowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
	Termin_realizacja DATE NOT NULL,
	ID_status_oferty INT FOREIGN KEY REFERENCES Status_oferty(ID_status_oferty) NOT NULL,
	ID_gwarancja INT FOREIGN KEY REFERENCES Gwarancja(ID_gwarancja) NOT NULL
	)

CREATE TABLE Forma_platnosci
	(
	ID_forma_platnosci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Forma_platnosc NVARCHAR(100) NOT NULL
	)

CREATE TABLE Podatek
	(
	ID_podatek INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Procent INT NOT NULL,
	)

CREATE TABLE Sprzedaz
	(
	ID_sprzedaz INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nr_sprzadaz INT NOT NULL,
	ID_oferta_handlowa INT FOREIGN KEY REFERENCES Oferta_handlowa(ID_oferta_handlowa) NOT NULL,
	Data_sprzedazy DATE NOT NULL,
	Termin_zaplaty DATE NOT NULL,
	ID_forma_platnosci INT FOREIGN KEY REFERENCES Forma_platnosci(ID_forma_platnosci) NOT NULL,
	)

CREATE TABLE Szczegoly_sprzedaz
	(
	ID_szczegoly_sprzedaz INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz INT FOREIGN KEY REFERENCES Sprzedaz(ID_sprzedaz) NOT NULL,
	Kwota_sprzedazy MONEY NOT NULL,
	ID_podatek INT FOREIGN KEY REFERENCES Podatek(ID_Podatek) NOT NULL
	)

CREATE TABLE Reklamacja
	(
	ID_reklamacja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
	ID_sprzedaz INT FOREIGN KEY REFERENCES Sprzedaz(ID_sprzedaz) NOT NULL,
	Data_reklamacji DATE NOT NULL,
	Opis_reklamacji NVARCHAR(250) NOT NULL,
	Akceptacja BIT NOT NULL
	)

CREATE TABLE Zwrot
	(
	ID_zwrot INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja INT FOREIGN KEY REFERENCES Reklamacja(ID_reklamacja) NOT NULL,
	Utylizacja BIT NOT NULL,
	)

CREATE TABLE Jednostka (
ID_jednostka INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
Nazwa NVARCHAR(20) NOT NULL,
Skrot NVARCHAR(5) NOT NULL
);

CREATE TABLE Rodzaj_obslugi(
ID_rodzaj_obslugi INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa NVARCHAR(50) NOT NULL
);
 
CREATE TABLE Rodzaj_parametr(
ID_rodzaj_parametr INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa NVARCHAR(50) NOT NULL,
ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL
);

CREATE TABLE Dostawcy(
ID_dostawcy INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa_dostawcy NVARCHAR(25) NOT NULL
);
 
CREATE TABLE Producenci (
ID_producent INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nazwa_producenta NVARCHAR(25) NOT NULL,
Opis NVARCHAR(50)
);

CREATE TABLE Statusy (
ID_status INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Status NVARCHAR(20) NOT NULL
);

CREATE TABLE Zamowienia_maszyn (
ID_zamowienia_maszyny INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
Data DATE NOT NULL,
ID_dostawcy INT FOREIGN KEY REFERENCES Dostawcy(ID_dostawcy) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienia_maszyny (
ID_zamowienia_maszyny INT FOREIGN KEY REFERENCES Zamowienia_maszyn(ID_zamowienia_maszyny) NOT NULL,
ID_status INT FOREIGN KEY REFERENCES Statusy(ID_status) NOT NULL,
Data SMALLDATETIME NOT NULL,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
CONSTRAINT PK_StanRZM PRIMARY KEY (ID_zamowienia_maszyny, ID_status)
);
 
CREATE TABLE Szczegoly_zamowienia_maszyny (
ID_zamowienia_maszyny INT FOREIGN KEY REFERENCES Zamowienia_maszyn(ID_zamowienia_maszyny) NOT NULL,
ID_maszyny INT FOREIGN KEY REFERENCES Maszyny(ID_maszyny) NOT NULL,
ID_producent INT FOREIGN KEY REFERENCES Producenci(ID_producent) NOT NULL,
Cena DECIMAL(15,2) NOT NULL,
CONSTRAINT PK_SzczegolyZM PRIMARY KEY (ID_zamowienia_maszyny, ID_maszyny, ID_producent)
);
 
CREATE TABLE Zamowienia_narzedzia (
ID_zamowienia_narzedzia int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
Data DATE NOT NULL,
ID_dostawcy INT FOREIGN KEY REFERENCES Dostawcy(ID_dostawcy) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienia_narzedzia (
ID_zamowienia_narzedzia INT FOREIGN KEY REFERENCES Zamowienia_narzedzia(ID_zamowienia_narzedzia) NOT NULL,
ID_status INT FOREIGN KEY REFERENCES Statusy(ID_status) NOT NULL,
Data SMALLDATETIME NOT NULL,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
CONSTRAINT PK_StanRZN PRIMARY KEY (ID_zamowienia_narzedzia, ID_status)
);
 
CREATE TABLE Szczegoly_zamowienia_narzedzia (
ID_zamowienia_narzedzia int FOREIGN KEY REFERENCES Zamowienia_narzedzia(ID_zamowienia_narzedzia) NOT NULL,
ID_narzedzia INT FOREIGN KEY REFERENCES Narzedzia(ID_narzedzia) NOT NULL,
ID_producent INT FOREIGN KEY REFERENCES Producenci(ID_producent) NOT NULL,
Cena decimal(15,2) NOT NULL,
CONSTRAINT PK_SzczegolyZN PRIMARY KEY (ID_zamowienia_narzedzia, ID_narzedzia, ID_producent)
);
 
CREATE TABLE Sklad_maszyny (
ID_sklad_maszyny INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_rodzaj_maszyny INT FOREIGN KEY REFERENCES Rodzaj_maszyny(ID_rodzaj_maszyny) NOT NULL,
ID_czesci INT FOREIGN KEY REFERENCES Czesci(ID_czesci) NOT NULL,
Liczba_czesci INT NOT NULL
);

CREATE TABLE Obslugi(
ID_obslugi INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_pracownik INT FOREIGN KEY 
	REFERENCES Pracownicy(ID_pracownik) NOT NULL,
ID_rodzaj_obslugi INT FOREIGN KEY
	REFERENCES Rodzaj_obslugi(ID_rodzaj_obslugi) NOT NULL,
Data_od DATETIME NOT NULL,
Data_do DATETIME,
Uwagi NVARCHAR(100) NOT NULL
);

CREATE TABLE Wymiana_czesci (
ID_obslugi INT FOREIGN KEY REFERENCES Obslugi(ID_obslugi) NOT NULL,
ID_sklad_maszyny INT FOREIGN KEY REFERENCES Sklad_maszyny(ID_sklad_maszyny) NOT NULL,
ID_czesci INT FOREIGN KEY REFERENCES Czesci(ID_czesci) NOT NULL,
ID_narzedzia INT FOREIGN KEY REFERENCES Narzedzia(ID_narzedzia) NOT NULL,
CONSTRAINT PK_Wymiana_czesci PRIMARY KEY (ID_obslugi, ID_sklad_maszyny, ID_czesci, ID_narzedzia)
);

CREATE TABLE Parametry_material (
ID_material INT FOREIGN KEY REFERENCES Materialy(ID_material) NOT NULL,
ID_rodzaj_parametr INT FOREIGN KEY REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
Zakres_dol INT NOT NULL,
Zakres_gora INT NOT NULL,
CONSTRAINT PK_ParametryMat PRIMARY KEY (ID_material, ID_rodzaj_parametr)
);

CREATE TABLE Parametry_narzedzia (
ID_narzedzia INT FOREIGN KEY REFERENCES Narzedzia(ID_narzedzia) NOT NULL,
ID_rodzaj_parametr INT FOREIGN KEY REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
Zakres_dol INT NOT NULL,
Zakres_gora INT NOT NULL,
CONSTRAINT PK_ParametryNarz PRIMARY KEY (ID_narzedzia, ID_rodzaj_parametr)
);

CREATE TABLE Parametry_maszyny (
ID_maszyny INT FOREIGN KEY REFERENCES Maszyny(ID_maszyny) NOT NULL,
ID_rodzaj_parametr int FOREIGN KEY REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
Zakres_dol INT NOT NULL,
Zakres_gora INT NOT NULL,
CONSTRAINT PK_ParametryMasz PRIMARY KEY (ID_maszyny, ID_rodzaj_parametr)
);

CREATE TABLE Parametry_czesci (
ID_czesci INT FOREIGN KEY REFERENCES Czesci(ID_czesci) NOT NULL,
ID_rodzaj_parametr int FOREIGN KEY REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
Zakres_dol INT NOT NULL,
Zakres_gora INT NOT NULL,
CONSTRAINT PK_ParametryCz PRIMARY KEY (ID_czesci, ID_rodzaj_parametr)
);

CREATE TABLE Dane_adresowe_producent(
ID_dane_adresowe_producent INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_producent INT FOREIGN KEY REFERENCES Producenci(ID_producent) NOT NULL,
Miejscowosc INT NOT NULL,
Ulica INT NOT NULL,
Nr_budynku INT NOT NULL,
Kod_pocztowy INT NOT NULL
);

CREATE TABLE Dane_adresowe_dostawcy(
ID_dane_adresowe_dostawcy INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_dostawcy INT FOREIGN KEY REFERENCES Dostawcy(ID_dostawcy) NOT NULL,
Miejscowosc INT NOT NULL,
Ulica INT NOT NULL,
Nr_budynku INT NOT NULL,
Kod_pocztowy INT NOT NULL
);

CREATE TABLE Zamowienia_materialy (
ID_zamowienia_materialy INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
Data DATE NOT NULL,
ID_dostawcy INT FOREIGN KEY REFERENCES Dostawcy(ID_dostawcy) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienia_materialy (
ID_zamowienia_materialy INT FOREIGN KEY REFERENCES Zamowienia_materialy(ID_zamowienia_materialy) NOT NULL,
ID_status INT FOREIGN KEY REFERENCES Statusy(ID_status) NOT NULL,
Data DATE NOT NULL,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
CONSTRAINT PK_StanRZMAT PRIMARY KEY (ID_zamowienia_materialy, ID_status, ID_pracownik)
);
 
CREATE TABLE Szczegoly_zamowienia_materialy (
ID_zamowienia_materialy INT FOREIGN KEY REFERENCES Zamowienia_materialy(ID_zamowienia_materialy) NOT NULL,
ID_material INT FOREIGN KEY REFERENCES Materialy(ID_material) NOT NULL,
ID_producent INT FOREIGN KEY REFERENCES Producenci(ID_producent) NOT NULL,
Waga_kg INT NOT NULL,
Cena DECIMAL(15,2) NOT NULL,
CONSTRAINT PK_SzczegolyZMAT PRIMARY KEY (ID_zamowienia_materialy, ID_material, ID_producent)
);

CREATE TABLE Zamowienia_czesci (
ID_zamowienia_czesci int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_pracownik int FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
Data DATE NOT NULL,
ID_dostawcy INT FOREIGN KEY REFERENCES Dostawcy(ID_dostawcy) NOT NULL
);

CREATE TABLE Stan_realizacji_zamowienia_czesci (
ID_zamowienia_czesci INT FOREIGN KEY REFERENCES Zamowienia_czesci(ID_zamowienia_czesci) NOT NULL,
ID_status INT FOREIGN KEY REFERENCES Statusy(ID_status) NOT NULL,
Data DATE NOT NULL,
ID_pracownik INT FOREIGN KEY REFERENCES Pracownicy(ID_pracownik) NOT NULL,
CONSTRAINT PK_StanRZCZ PRIMARY KEY (ID_zamowienia_czesci, ID_status, ID_pracownik)
);

CREATE TABLE Szczegoly_zamowienia_czesci (
ID_zamowienia_czesci INT FOREIGN KEY REFERENCES Zamowienia_czesci(ID_zamowienia_czesci) NOT NULL,
ID_czesci INT FOREIGN KEY REFERENCES Czesci(ID_czesci) NOT NULL,
ID_producent INT FOREIGN KEY REFERENCES Producenci(ID_producent) NOT NULL,
Ilosc INT NOT NULL,
Cena DECIMAL(15,2) NOT NULL,
CONSTRAINT PK_SzczegolyZCZ PRIMARY KEY (ID_zamowienia_czesci, ID_czesci, ID_producent)
);