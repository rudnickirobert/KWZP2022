DROP DATABASE KWZP
CREATE DATABASE KWZP

USE KWZP
GO

-- PRACOWNICY 

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