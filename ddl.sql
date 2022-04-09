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

/*
CREATE TABLE Szczegoly_polprodukt(
ID_polprodukt INT FOREIGN KEY
	REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
ID_parametr INT FOREIGN KEY
	REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
)
*/


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

CREATE TABLE Rodzaj_obslugi(
ID_rodzaj_obslugi INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nazwa_czynnosci NVARCHAR(50) NOT NULL
)

CREATE TABLE Wymienione_czesci(
ID_wymienione_czesci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_czesci INT FOREIGN KEY
	REFERENCES Czesci(ID_czesci)
)

CREATE TABLE Obsluga_urzadzen(
ID_obsluga_urzadzen INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_stanowisko_produkcyjne INT FOREIGN KEY
	REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
ID_pracownik INT FOREIGN KEY 
	REFERENCES Pracownicy(ID_pracownik) NOT NULL,
ID_rodzaj_obslugi INT FOREIGN KEY
	REFERENCES Rodzaj_obslugi(ID_rodzaj_obslugi) NOT NULL,
Data_od DATETIME NOT NULL,
Data_do DATETIME,
ID_wymienione_czesci INT FOREIGN KEY
	REFERENCES Wymienione_czesci(ID_wymienione_czesci) NOT NULL,
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



-- KLIENCI 

CREATE TABLE Dane_adresowe_klient(
	ID_dane_adresowe_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Miejscowosc VARCHAR(50) NOT NULL,
	Ulica VARCHAR(50),
	Nr_budynku INT NOT NULL,
	Nr_lokalu INT,
	Kod_pocztowy VARCHAR(5) NOT NULL
	)

CREATE TABLE Nr_telefon_klient(
	ID_nr_telefon_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Numer VARCHAR(20) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
	)

CREATE TABLE Email_klient(
	ID_email_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
	)

CREATE TABLE Klienci(
	ID_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko VARCHAR(50) NOT NULL,
	Imie VARCHAR(50) NOT NULL,
	ID_dane_adresowe INT FOREIGN KEY 
		REFERENCES Dane_adresowe_klient(ID_dane_adresowe_klient) NOT NULL,
	NIP VARCHAR(10),
	ID_nr_telefonu_klient INT FOREIGN KEY 
		REFERENCES Nr_telefon_klient(ID_nr_telefon_klient) NOT NULL ,
	ID_email_klient INT FOREIGN KEY 
		REFERENCES Email_klient(ID_email_klient) NOT NULL
	)