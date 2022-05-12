USE KWZP
GO

INSERT INTO Wyksztalcenie (Nazwa)
VALUES
('Podstawowe'),
('Średnie branżowe'),
('Średnie'),
('Inżynier'), 
('Wyższe');

INSERT INTO Czynnosc_produkcyjna (Nazwa)
VALUES
('Przygotowanie stanowiska'),
('Skanowanie'),
('Projektowanie'),
('Drukowanie'),
('Wygładzanie'),
('Szlifowanie'),
('Lakierowanie'),
('Klejenie'),
('Montaż');

INSERT INTO Pracownik (Nazwisko, Imie, Nr_dowodu, Pesel, ID_wyksztalcenie)
VALUES
('Nowak','Jan','AAA00000',5505000005,1),
('Marszał','Grzegorz','ABC20000',88090100005,2),
('Gont','Józef','RF004050',97030400005,3),
('Markowska', 'Anna', 'ABC00020',88063603005,1),
('Pawlak','Katarzyna','GDE00900',90041200003,2),
('Kowalczylk','Adam','UJG02033',99051707802, 3),
('Andrzejewski', 'Michał','DCE986557',79072900034,1),
('Krawczyk', 'Karol', 'GDT80967',90050004505,2),
('Wieczorek', 'Karolina', 'HNR23123',87050500006,3),
('Baran', 'Szymon', 'MFN67926',99050068003,1),
('Wilk', 'Zuzanna', 'MDK85609',68050450673,2),
('Sadowski', 'Aleksander', 'NFL48923',98050056806,3),
('Borkowska', 'Zofia', 'LDG57291',76050045006,1),
('Sikora', 'Julia', 'LFB57823',85050087096,2),
('Nowicki', 'Filip', 'LAP46723',95050657006,3),
('Duda', 'Wojciech', 'PKE95123',98050670006,1),
('Grabowski', 'Stanisław', 'LDH65793',92050008906,1),
('Dzban', 'Jan', 'LDP65793',98050228905,1),
('Gawron', 'Patrycja', 'LPG69699',82050008902,1),
('Pudzianowski', 'Mariusz', 'XD954821',74010508905,4),
('Mahyz', 'Ednan', 'SNG65602',88092408590,4),
('Nierob', 'Janusz', 'M6565PO1',81123157832,3),
('Knob', 'Daniel', 'M5645P12', 87945645612,3),
('Krolczyk', 'Ernest', 'K457P54', 8765941233,2),
('Grubczyk', 'Marcel', 'S789D56', 8754123695,3);

INSERT INTO Dane_adresowe_pracownik (ID_pracownik, Miejscowosc, Ulica, Nr_budynku, Nr_lokalu, Kod_pocztowy, Data_od)
VALUES
(1, 'Warszawa', 'Jana Pawła II', '21', '37', '02137', '2021-04-14'),
(2, 'Marki', 'Markowa', '23', '11', '12000', '2019-08-14'),
(3, 'Warszawa', 'Kombatantów', '6', '26', '11500', '2020-02-13'),
(4, 'Warszawa', 'Królowej Jadwigi', '11', '20', '02347', '2020-04-19'),
(5, 'Warszawa', 'Kościuszki', '51', '32', '02952', '2018-10-02'),
(6, 'Marki', 'Długa', '1', '1', '12301','2019-03-09'),
(7, 'Warszawa', 'Krótka', '2','2','02022','2021-06-11'),
(8, 'Warszawa', 'Średnia', '3','3','01437','2021-06-11'),
(9, 'Warszawa', 'Kaliskiego', '2', '11', '01534','2020-02-11'),
(10, 'Warszawa', 'Górczewska', '11', '20', '03321','2020-01-13'),
(11, 'Marki', 'Naturalna', '21', '36', '08808', '2018-07-13'), 
(12, 'Pruszków', 'Wiejska', '13', '32', '11111','2017-05-13'),
(13, 'Warszawa',' Połczyńska', '2','33', '01910','2018-01-01'),
(14, 'Warszawa', 'Al. Jerozolimskie', '5','10', '02147', '2017-01-01'),
(15, 'Pruszków', 'Marszałkowska', '1', '1', '03332', '2019-01-01'),
(16, 'Pruszków', 'Prosta', '27', '22', '01712', '2020-01-01'),
(17, 'Pruszków', 'Karolkowa' ,'3', '34', '04543', '2022-01-01'),
(18, 'Warszawa', 'Piertucha' ,'5', '15', '02495', '2022-02-21'),
(19, 'Warszawa', 'Ziemniaczana' ,'13', '13', '00251', '2022-01-12'),
(20, 'Warszawa', 'Marchewkowa' ,'15', '12', '00957', '2021-01-11'),
(21, 'Nadarzyn', 'Porowa' ,'1', '31', '05830', '2022-01-05'),
(22, 'Marki', 'Cebulowa' ,'21', '3', '04543', '2020-01-03'),
(23, 'Warszawa', 'Porowa', '21', '37', '04568', '2021-03-03'),
(24, 'Wronki', 'Marcewkowa', '12', '73', '98765', '2020-04-04'),
(25, 'Warszawa', 'Wrzecieniowa', '1', '1', '12321', '2020-09-09');

INSERT INTO Nr_telefon_pracownik (ID_pracownik, Numer, Data_od)
VALUES
(1,'123123123','2022-01-01'),
(2,'321321321','2022-02-01'),
(3,'456456456','2021-12-10'),
(4,'321321321','2020-05-01'),
(5,'321321321','2021-06-01');

INSERT INTO Email_pracownik (ID_pracownik,Email,Data_od)
VALUES
(1,'jannowak@drukarczyk.pl','2022-01-01'),
(2,'grzegorzmarszal@drukarczyk.pl','2022-02-01'),
(3,'jozefgont@drukarczyk.pl','2021-12-10'),
(4,'annamarkowska@drukarczyk.pl','2020-05-01'),
(5,'katarzynapawlak@drukarczyk.pl','2021-06-01');

INSERT INTO Stanowisko (Nazwa_stanowiska)
VALUES
('Prezes'),
('Dyrektor operacyjny'),
('Specjalista do spraw kadr i płac'),
('Projektant'),
('Project manager'),
('Specjalista do spraw finansów'),
('Kierownik handlu i marketingu'),
('Handlowiec'),
('Marketingowiec'),
('Kierownik produkcji i utrzymania ruchu'),
('Brygadzista'),
('Operator'),
('Kierownik zasobów i dostaw'),
('Zaopatrzeniowiec'),
('Magazynier'),
('Brygadzista utrzymania ruchu'),
('Elektromechanik'),
('Logistyk'),
('Kontroler jakości');

INSERT INTO Dzial (Nazwa_dzial)
VALUES
('Kadr i przygotowania produkcji'),
('Handlowy i marketingu'),
('Produkcji'),
('Zasobów i dostaw'),
('Utrzymania ruchu'),
('Logistyczny'),
('Kontroli jakości');

INSERT INTO Rodzaj_kontrola (Rodzaj_kontrola, Procedura)
VALUES
('Wymiarowa', 'Dokonać pomiaru najważniejszych wymiarów'),
('Wzrokowa', 'Ogólne oględziny otrzymanego produktu'),
('Badanie twardości', 'Dokonać pomiaru twardości badanego produktu'),
('Badanie chropowatości', 'Określić chropowatość uzyskanej powierzchni'),
('Wytrzymałościowa', 'Poddać produkt obciążeniu próbnemu');

INSERT INTO Slownik_stanowisko (Nazwa_stanowiska)
VALUES
('Stanowisko do skanowania'),
('Stanowisko do drukowania FDM'),
('Stanowisko do drukowania SLS'),
('Stanowisko do drukowania SLA'),
('Stanowisko do szlifowania'),
('Stanowisko do łączenia półproduktów'),
('Stanowisko do lakierowania'),
('Stanowisko do projektowania'),
('Stanowisko do wygladzania');

INSERT INTO Produkt (Nazwa_produkt)
VALUES
('Litofanowy klosz do lampy'),
('Przekładnia zębata'),
('Tapicerka samochodowa'),
('Obudowa PC'),
('Kostka rubika');

INSERT INTO Slownik_polprodukt (Nazwa)
VALUES
('Uchwyt zasilacza'),
('Wał czynny'),
('Wał bierny'),
('Obudowa przekładni'),
('Elementy montażowe - kostka'),
('Klosz fi150'),
('Mocowanie chłodzenia'),
('Maskownica do kabli'),
('Elementy powierzchniowe');

INSERT INTO Sklad_produkt (ID_produkt, ID_polprodukt, Liczba)
VALUES
(1,6,1),
(2,2,1),
(2,3,2),
(2,4,1),
(3,9,4),
(4,1,1),
(4,7,2),
(4,8,3),
(5,5,5);

INSERT INTO Narzedzie (Nazwa_narzedzie)
VALUES
('Śrubokręt płaski'),
('Kombinerki'),
('Nóż'),
('Nożyczki'),
('Suwmiarka'),
('Klucz francuski');

INSERT INTO Rodzaj_material (Nazwa_rodzaj_material)
VALUES
('ABS'),
('PLA'),
('PETG'),
('Proszek stali 316L'),
('Nylon PA12'),
('Żywica termoutwardzalna'),
('Klej')

INSERT INTO Rodzaj_maszyna (Nazwa_rodzaj_maszyna, Opis)
VALUES
('Drukarka FDM','Drukowanie przy wykorzystaniu technologii FDM'),
('Drukarka SLA','Drukowanie przy wykorzystaniu technologii SLA'),
('Drukarka SLS','Drukowanie przy wykorzystaniu technologii SLS'),
('Skaner 3D',NULL),
('Drukarka laserowa','Laserowa'),
('PC','Komputer stacjonarny'),
('Szlifierka', NULL);

INSERT INTO Rodzaj_czesc (Nazwa_rodzaj_czesc)
VALUES
('Ekstruder'),
('Rama'),
('Platforma robocza'),
('Glowica drukarki'),
('Kolo zebate'),
('Silnik krokowy'),
('Stolik obrotowy'),
('Glowica optyczna'),
('Obiektyw'),
('Glowica lasera'),
('Ekran LCD'),
('Wentylator'),
('Zgarniacz');

INSERT INTO Rodzaj_obsluga(Nazwa_rodzaj_obsluga)
VALUES
('Wymiana czesci'),
('Czyszczenie'),
('Kontrola stanu'),
('Kalibracja'),
('Smarowanie');

INSERT INTO Status_zamowienie(Nazwa_status)
VALUES
('Zamowiono'),
('W trakcie realizacji'),
('Dostarczono'),
('Odebrano');

INSERT INTO Jednostka (Nazwa_jednostka, Skrot)
VALUES
('Milimetr','mm'),
('Gram','g'),
('Megapascal','MPa'),
('Sekunda','s'),
('Gram na centymetr szescienny','g/cm3'),
('Stopien Celsjusza','oC'),
('Decybel','dB'),
('Metr na sekunde do kwadratu','m/s2'),
('Wat','W');

INSERT INTO Rodzaj_parametr (Nazwa_rodzaj_parametr, ID_Jednostka)
VALUES
('Gęstość',5),
('Długość',1),
('Szerokość',1),
('Średnica',1),
('Masa',2),
('Wytrzymałość na rozciąganie', 3),
('Wytrzymałość na skręcanie', 3),
('Moduł Younga',3),
('Temperatura stołu roboczego',6),
('Głośność pracy',7),
('Prędkość druku', 8),
('Prędkość przejazdów jałowych', 8),
('Temperatura przechowywania',6),
('Maksymalny pobór mocy',9);

INSERT INTO Parametr_produkt(ID_produkt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,149,151),
(1,5,100,105),
(2,2,299,301),
(2,3,100,104),
(2,7,80,85),
(2,5,45,50),
(3,3,99,102),
(3,2,99,100),
(3,1,48,51),
(3,5,10,11),
(4,5,30000,35000),
(4,2,99,100),
(4,3,40,42),
(5,1,3,4),
(5,5,1000,3000),
(5,4,35,36);


INSERT INTO Parametr_polprodukt (ID_polprodukt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,3,45,50),
(1,2,60,63),
(1,4,80,90),
(2,3,40,45),
(2,1,1,4),
(2,6,80,90),
(2,7,100,105),
(2,8,120,130),
(3,3,120,121),
(3,1,20,22),
(3,6,45,50),
(3,7,80,85),
(3,8,100,110),
(4,5,30000,35000),
(4,3,40,45),
(4,2,99,100),
(5,2,39,45),
(5,4,30,35),
(5,3,120,121),
(6,4,150,151),
(6,5,250,270),
(7,2,30,31),
(7,3,30,31),
(7,5,120,125),
(8,2,150,155),
(8,3,30,31),
(9,2,3500,3505),
(9,3,1200,1201);


INSERT INTO Material (ID_rodzaj_material, Nazwa_material)
VALUES
(4,'Proszek S316L DRUTEX'),
(1,'Filament Czarny ABS Black'),
(3,'Filament Zolty PETG Stakchovsky'),
(2,'Filament Czerwony PLA Podraskov'),
(2,'Filament Niebieski PLA POODZIAN'),
(5,'Nylon PA12 Marka Jarka'),
(6,'Zywica Biala STRONG'),
(7,'Klej GIGADZIECIACZEK');

INSERT INTO Sklad_polprodukt (ID_polprodukt, ID_material, Liczba)
VALUES
(1,5,20),
(2,2,15),
(3,3,40),
(2,4,10),
(3,2,10),
(4,1,30),
(4,3,20),
(5,5,40),
(6,2,50),
(7,5,30),
(8,4,20),
(9,2,45);

INSERT INTO Sklad_produkt_material (ID_produkt, ID_material, Liczba)
VALUES
(1,7,20),
(2,7,25),
(2,8,10),
(3,8,15),
(4,8,10),
(5,7,12),
(5,8,10);

INSERT INTO Czesc (Nazwa_czesc, ID_rodzaj_czesc)
VALUES
('Ekstruder Bondtech phi0.4',1),
('Kolo zebate phi60',5),
('Rama i3 MK3S+',2),
('Glowica i3 MK3S+',4),
('Stol i3 MK3S+',3),
('Stolik Shining', 6),
('Glowica skanera Shining',7),
('Obiektyw Canon',8),
('Rama Ender5',2),
('Glowica Ender5',4),
('Stol Ender5',3),
('Zgarniacz b0bll',12),
('Ekran LG',10),
('Ekran HP',10),
('Wentylator IDZ',11),
('Ekstruder Bondtech phi0.1',1),
('Ekstruder Bondtech phi0.2',1),
('Silnik krokowy KROK',6),
('Glowica lasera LG', 9);

INSERT INTO Etat (ID_stanowisko, ID_dzial, Liczba_miejsc)
VALUES
(1,2,1),
(2,2,1),
(3,1,1),
(4,1,2),
(5,1,1),
(6,2,2),
(7,2,1),
(8,2,2),
(9,2,1),
(10,5,1),
(11,5,1),
(12,3,4),
(13,4,1),
(14,4,1),
(15,4,3),
(16,5,1),
(17,5,3),
(18,7,1),
(19,3,3);

INSERT INTO Posada_pracownika (ID_etat, Data_od)
VALUES
(1,'2022-04-10'),
(2,'2022-04-10'),
(3,'2022-04-10'),
(4,'2022-04-10'),
(5,'2022-04-10'),
(6,'2022-04-10'),
(7,'2022-04-10'),
(8,'2022-04-10'),
(9,'2022-04-10'),
(10,'2022-04-10'),
(11,'2022-04-10'),
(12,'2022-04-10'),
(13,'2022-04-10'),
(14,'2022-04-10'),
(15,'2022-04-10'),
(16,'2022-04-10'),
(17,'2022-04-10'),
(18,'2022-04-10'),
(15,'2022-04-11'),
(15,'2022-04-11'),
(16,'2022-04-11'),
(17,'2022-04-11'),
(18,'2022-04-11'),
(19,'2022-04-11');

INSERT INTO Rodzaj_umowy (Nazwa, Urlop)
VALUES
('Umowa o pracę',26),
('Umowa zlecenie',0),
('Umowa o dzieło',0);

INSERT INTO Rodzaj_nieobecnosci (Symbol, Wspolczynnik_wynagrodzenia)
VALUES
('UW',0),
('CH',-0.2),
('NB',-1.0);

INSERT INTO Nieobecnosc (ID_pracownik, ID_rodzaj_nieobecnosci, Data_od, Data_do)
VALUES
(1,1,'2022-04-11','2022-04-24'),
(2,2,'2022-04-12','2022-04-16'),
(3,2,'2022-04-18','2022-04-19'),
(4,2,'2022-04-13','2022-04-14'),
(5,3,'2022-04-13','2022-04-19'),
(6,2,'2022-04-13','2022-04-15'),
(7,1,'2022-04-13','2022-04-15'),
(8,1,'2022-04-13','2022-04-15'),
(9,1,'2022-04-13','2022-04-15'),
(10,1,'2022-04-13','2022-04-15');

INSERT INTO Wymiar_pracy (Nazwa, Wspolczynnik_wynagrodzenia)
VALUES
('Pełny etat',1.0),
('Pół etatu',0.5);

INSERT INTO Umowa (ID_wymiar_pracy, ID_rodzaj_umowy, ID_pracownik, ID_posada_pracownika, Wynagrodzenie)
VALUES
(1,1,1,1,5000),
(1,1,2,12,4000),
(1,1,3,12,3600),
(2,2,4,12,5500),
(2,1,5,2,5500),
(2,2,06,3,4500),
(1,1,07,4,4500),
(1,2,8,4,3500),
(1,2,9,8,5500),
(1,1,10,9,6000),
(2,1,11,10,7000),
(2,1,12,11,5000),
(1,1,13,13,3600),
(1,1,14,14,3600),
(1,1,15,15,2500),
(1,1,16,16,6000),
(1,1,17,18,5000),
(1,1,18,15,1800),
(1,1,19,15,1200),
(1,1,20,21,3600),
(1,1,21,22,3400),
(1,1,22,22,3350),
(1,1,23,24,3800),
(1,1,24,24,3800),
(1,1,25,24,3800);

INSERT INTO Maszyna (Nazwa_maszyna, ID_rodzaj_maszyna, Koszt_RBG)
VALUES
('PRUSA i3 MK3S+',1,25),
('Shining 3D EinScan SE',4,20),
('Sinterit Lisa 2 Pro',3,27),
('Anycubic Photon Mono X',2,35),
('Creality Ender-5 Pro',1,32),
('Macbook PRO M1',6,5),
('Szlifierka Fiberfox',7,30);

INSERT INTO Nr_seryjny (Nr_seryjny)
VALUES
('000-001'),
('000-002'),
('000-003'),
('000-004'),
('000-005'),
('000-006'),
('000-007'),
('000-008'),
('000-009'),
('000-010'),
('000-011'),
('000-012'),
('000-013'),
('000-014'),
('000-015'),
('000-016'),
('000-017'),
('000-018'),
('000-019'),
('000-020'),
('000-021'),
('000-022'),
('000-023'),
('000-024'),
('000-025'),
('000-026'),
('000-027'),
('000-028'),
('000-029');

INSERT INTO Maszyna_nr_seryjny (ID_maszyna, ID_nr_seryjny)
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(1,8),
(1,9),
(1,10),
(2,11),
(2,12),
(2,13),
(3,14),
(3,15),
(3,16),
(4,17),
(4,18),
(4,19),
(5,20),
(5,21),
(5,22),
(6,23),
(6,24),
(6,25),
(7,26),
(7,27),
(7,28),
(6,29);

INSERT INTO Stanowisko_produkcyjne (ID_nazwa_stanowiska)
VALUES
(3),
(1),
(4),
(5),
(6),
(7),
(8),
(1),
(2);


INSERT INTO Sklad_stanowisko_produkcyjne_maszyna (ID_stanowisko_produkcyjne, ID_maszyna_nr)
VALUES
(1,6),
(1,1),
(2,3),
(2,23),
(3,24),
(3,2),
(4,4),
(4,25),
(5,7),
(9,10),
(9,29);


INSERT INTO Sklad_stanowisko_produkcyjne_narzedzie (ID_stanowisko_produkcyjne, ID_narzedzie, Liczba)
VALUES
(3,1,5),
(3,3,2),
(2,5,1),
(1,4,1),
(4,3,3),
(2,1,5),
(3,4,1),
(4,2,1),
(5,2,2),
(9,2,3),
(9,5,2),
(9,6,1);

INSERT INTO Proces_polprodukt_czynnosc (ID_polprodukt, ID_czynnosc_produkcyjna, Czas_trwania)
VALUES
(1,2,60),	--Skanowanie				--1.Stanowisko do skanowania
(1,1,15), 	--Przygotowanie stanowiska	--2.Stanowisko do drukowania FDM
(1,4,360),	--Drukowanie				--2.Stanowisko do drukowania FDM
(1,5,30),	--Wygladzanie				--9.Stanowisko do wygladzania
(2,3,120),	--Projektowanie				--8.Stanowisko do projektowania
(2,1,15),	--Przygotowanie stanowiska	--3.Stanowisko do drukowania SLS	
(2,4,300),	--Drukowanie				--3.Stanowisko do drukowania SLS
(2,6,30),	--Szlifowanie				--5.Stanowisko do szlifowania
(3,3,120),	--Projektowanie				--8.Stanowisko do projektowania
(3,1,15),	--Przygotowanie stanowiska	--3.Stanowisko do drukowania
(3,4,360),	--Drukowanie				--3.Stanowisko do drukowania
(3,6,30),	--Szlifowanie				--5.Stanowisko do szlifowania
(4,3,120),	--Projektowanie				--8.Stanowisko do projektowania
(4,1,15),	--Przygotowanie Stanowiska	--4.Stanowisko do drukowania SLA
(4,4,300),	--Drukowanie				--4.Stanowisko do drukowania SLA
(4,5,30),	--Wygladzanie				--9.Stanowisko do wygladzania
(4,7,15),	--Lakierowanie				--7.Stanowisko do lakierowania
(5,3,60),	--Projektowanie				--8.Stanowisko do projektowania
(5,1,15),	--Przygotowanie stanowiska	--2.Stanowisko do drukowania FDM
(5,4,150),	--Drukowanie				--2.Stanowisko do drukowania FDM
(5,6,30),	--Szlifowanie				--5.Stanowisko do szlifowania
(6,3,90),	--Projektowanie				--8.Stanowisko do projektowania
(6,1,15),	--Przygotowanie stanowiska	--4.Stanowisko do drukowania SLA
(6,4,300),	--Drukowanie				--4.Stanowisko do drukowania SLA
(7,3,30),	--Projektowanie				--8.Stanowisko do projektowania
(7,1,15),	--Przygotowanie stanowiska	--2.Stanowisko do drukowania FDM
(7,4,90),	--Drukowanie				--2.Stanowisko do drukowania FDM
(8,3,90),	--Projektowanie				--8.Stanowisko do projektowania
(8,1,15),	--Przygotowanie stanowiska	--2.Stanowisko do drukowania FDM
(8,4,300),	--Drukowanie				--2.Stanowisko do drukowania FDM
(8,5,120),	--Wygladzanie				--9.Stanowisko do wygladzania
(8,7,120),	--Lakierowanie				--7.Stanowisko do lakierownaia
(9,3,120),	--Projektowanie				--8.Stanowisko do projektowania
(9,1,15),	--Przygotowanie stanowiska	--4.Stanowisko do drukowania SLA
(9,4,240),	--Drukowanie				--4.Stanowisko do drukowania SLA
(9,5,60);	--Wygladzanie				--9.Stanowisko do wygladzania

INSERT INTO Proces_produkt_czynnosc (ID_produkt, ID_czynnosc_produkcyjna, Czas_trwania)
VALUES
(1,9,15),	--Montaż		--6.Stanowisko do łączenia półproduktów
(2,9,20),	--Montaż		--6.
(2,8,30),	--Klejenie		--6.
(3,9,20),	--Montaż		--6.
(4,9,30),	--Montaż		--6.
(5,9,15);	--Montaż		--6.

INSERT INTO Dostawca (Nazwa_dostawca)
VALUES
('Marinex'),
('Druczex'),
('Polex'),
('Brexus'),
('Blablin');

INSERT INTO Dane_adresowe_dostawca (ID_dostawca, Miejscowosc, Ulica, Nr_budynku, Kod_pocztowy)
VALUES
(1,'Warszawa','Dzwigowa',12,'01-376'),
(2,'Warszawa','Swietlikow',5,'01-358'),
(3,'Warszawa','Gorna',3,'04-413'),
(4,'Skierniewice','Dluga',4,'96-100'),
(5,'Nadarzyn','Blonska',1,'05-830');

INSERT INTO Producent (Nazwa_producenta)
VALUES
('PRUSA'),
('Shining3D'),
('Sinterit'),
('Anycubic'),
('CREALITY'),
('Apple'),
('Fiberfox');

INSERT INTO Dane_adresowe_producent (ID_producent, Miejscowosc, Ulica, Nr_budynku, Kod_pocztowy)
VALUES
(1,'Praga','Partyzanska',7,NULL),
(2,'Stuttgart','Breitwiesenstrasse',28,'70565'),
(3,'Krakow','Nad Drwina',10,'30-741'),
(4,'Hongkong','Chatham Road South',45,NULL),
(5,'Shenzhen','Meilong Blvd.', 18,'518131'),
(6,'Cupertino','Apple Park Way',1,NULL),
(7,'Dae Jeon','Deogmyeong-dong',171,NULL);


INSERT INTO Parametr_material (ID_material, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,1,4,4),
(2,4,1.75,1.75),
(3,4,1.75,1.75),
(4,4,2.25,2.25),
(5,4,1.75,1.75);

INSERT INTO Klient (Nazwisko, Imie, NIP)
	VALUES 
	('Marczak', 'Marek', NULL),
	('Adamiak', 'Adam', NULL),
	('Nowak', 'Karol', NULL),
	('Kowalski', 'Jan', NULL),
	('Lewandowski', 'Robert', NULL);

INSERT INTO Email_klient (ID_klient, Email, Data_od, Data_do)
	VALUES
	(1, 'marczak.marek@drukarczyk.com', '2022-01-01', NULL),
	(2, 'adamiak.adam@drukarczyk.com', '2022-01-01', NULL),
	(3, 'nowak.karol@drukarczyk.com', '2022-01-01', NULL),
	(4, 'kowalski.jan@drukarczyk.com', '2022-01-01', NULL),
	(5, 'lewandowski.robert@drukarczyk.com', '2022-01-01', NULL);

INSERT INTO Nr_telefon_klient (ID_klient, Numer, Data_od, Data_do)
	VALUES
	(1, 508553123, '2022-01-01', NULL),
	(2, 508553456, '2022-01-01', NULL),
	(3, 508553789, '2022-01-01', NULL),
	(4, 508553987, '2022-01-01', NULL),
	(5, 508553654, '2022-01-01', NULL);

INSERT INTO Dane_adresowe_klient (ID_klient, Miejscowosc, Ulica, Nr_budynek, Nr_lokal, Kod_pocztowy)
	VALUES
	(1, 'Warszawa', 'Warszawska', 1, NULL, '12-345'),
	(2, 'Bydgoszcz', 'Bydgoska', 1, 2, '54-321'),
	(3, 'Grójec', NULL, 1, NULL, '98-765'),
	(4, 'Żyrardów', '3 Maja', 3, 5, '32-654'),
	(5, 'Warszawa', 'Warszawska', 53, 24, '12-345');

INSERT INTO Typ_zamowienie (Rodzaj_zamowienie)
	VALUES
	('Indywidualne'),
	('Standardowe');

INSERT INTO Zamowienie (ID_klient, ID_pracownik, Data_zamowienie, ID_typ_zamowienie)
	VALUES
	(1, 1, '2022-04-04', 2),
	(2, 2, '2022-04-05', 2),
	(3, 2, '2022-04-06', 1),
	(4, 3, '2022-04-07', 1),
	(5, 4, '2022-04-08', 2);

INSERT INTO Zamowienie_szczegol (ID_zamowienie, ID_produkt, Ilosc)
	VALUES
	(1, 2, 50),
	(1, 1, 30),
	(2, 3, 100),
	(3, 3, 150),
	(3, 5, 120),
	(4, 3, 150),
	(5, 5, 120);

INSERT INTO Gwarancja (Okres_gwarancja, Opis_gwarancja)
	VALUES 
	(2, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 2 LAT'),
	(1, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 1 ROKU'),
	(3, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 3 LAT'),
	(4, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 4 LAT'),
	(5, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 5 LAT');

INSERT INTO Status_oferta (Nazwa_status_oferta)
	VALUES
	('Zaakceptowana'),
	('Odrzucona'),
	('Do rozpatrzenia'),
	('W trakcie realizacji');

INSERT INTO Oferta_handlowa (ID_zamowienie, ID_pracownik, Termin_realizacja, ID_gwarancja, ID_status_oferta, Cena)
	VALUES
	(1, 1, '2022-04-28', 1, 1, 5000),
	(2, 2, '2022-04-29', 1, 1, 4000),
	(3, 3, '2022-04-30', 1, 1, 3900),
	(4, 4, '2022-04-27', 1, 1, 6000),
	(5, 5, '2022-05-04', 1, 1, 2400),
	(1, 1, '2022-05-30', 1, 2, 7500);

INSERT INTO Podatek (Procent)
	VALUES
	(0),
	(8),
	(23),
	(11),
	(28);

INSERT INTO Forma_platnosc (Forma_platnosc)
	VALUES
	('Przelew'),
	('Karta płatnicza'),
	('Gotówka'),
	('BLIK'),
	('Przelew pocztowy');

INSERT INTO Umowa_sprzedaz (ID_oferta_handlowa)
	VALUES
	(1),
	(2),
	(3),
	(4),
	(5);

INSERT INTO Sprzedaz (Nr_sprzedaz, Data_sprzedaz_poczatek, Data_sprzedaz_koniec, Termin_zaplata, ID_forma_platnosc, ID_umowa_sprzedaz)
	VALUES
	(1, '2022-03-01', '2022-03-15', '2022-03-22', 1, 1),
	(2, '2022-03-02', '2022-03-16', '2022-03-23', 2, 2),
	(3, '2022-03-03', '2022-03-17', '2022-03-24', 3, 3),
	(4, '2022-03-03', '2022-03-17', '2022-03-24', 2, 4),
	(5, '2022-03-04', '2022-03-18', '2022-03-25', 1, 5)

INSERT INTO Reklamacja (ID_pracownik, ID_sprzedaz, Data_reklamacja, Opis_reklamacja)
	VALUES
	(1, 1, '2022-04-01', 'Uszkodzenie mechaniczne'),
	(3, 1, '2022-04-02', 'Rozklejenie produtku'),
	(2, 2, '2022-04-03', 'Uszkodzenie mechaniczne'),
	(5, 3, '2022-04-04', 'Pękniecie materiału'),
	(4, 3, '2022-04-05', 'Uszkodzenie mechaniczne'),
	(5, 4, '2022-04-01', 'Uszkodzenie mechaniczne'),
	(4, 5, '2022-04-01', 'Uszkodzenie mechaniczne');

INSERT INTO Zwrot (ID_reklamacja, ID_produkt, Ilosc, Akceptacja)
	VALUES
	(1,1,1,1),
	(2,2,2,1),
	(4,3,4,0),
	(6,3,3,0),
	(7,5,1,1),
	(3,3,20,1),
	(5,5,40,1);

INSERT INTO Szczegoly_sprzedaz (ID_sprzedaz, ID_produkt, Kwota_sprzedaz, ID_podatek, Ilosc)
	VALUES
	(1, 2, 40, 1, 50),
	(1, 1, 100, 2, 30),
	(2, 3, 40, 1, 100),
	(3, 3, 10, 3, 150),
	(3, 5, 20, 4, 120),
	(4, 3, 40, 3, 150),
	(5, 5, 20, 4, 120);

INSERT INTO Parametr_czesc (ID_czesc, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,5,50,60),
(1,4,0.36,0.44),
(2,4,59,61), 
(2,5,540,580),
(3,2,350,350), 
(3,3,35,40),
(4,5,200,200), 
(4,10,10,30),
(5,2,300,300),
(5,3,290,290),
(6,7,30,40),
(6,11,450,450),
(7,5,400,400),
(7,4,60,60),
(8,4,60,60),
(8,5,300,300),
(9,2,400,400), 
(9,3,50,50),
(10,5,300,300), 
(10,10,10,30),
(11,2,330,330),
(11,3,300,300),
(12,2,200,2000),
(12,3,50,50),
(13,2,60,60), 
(13,3,60,60),
(14,2,80,80), 
(14,3,60,60),
(15,7,10,50), 
(15,5,0.2,0.2),
(16,5,40,40),
(16,4,0.08,0.12),
(17,5,40,50),
(17,4,0.18,0.22),
(18,7,10,35),
(18,5,100,100),
(19,5,500,500),
(19,10,15,24);

INSERT INTO Parametr_narzedzie (ID_narzedzie, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,4,19,21),
(2,5,3500,3600),
(3,2,15,15),
(4,2,13,13),
(5,2,20,20);

INSERT INTO Parametr_maszyna (ID_maszyna, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
VALUES
(1,7,30,40),
(1,8,10,100),
(1,9,200,200),
(1,10,10,40),
(2,5,20000,20000),
(2,7,20,25),
(2,10,15,25),
(2,11,1000,1000),
(3,5,150000,150000),
(3,7,10,15),
(3,10,10,40),
(3,11,2000,2000),
(4,5,15000,15000),
(4,7,10,20),
(4,10,15,25),
(4,11,700,700),
(5,7,50,60),
(5,8,10,100),
(5,9,200,200),
(5,10,10,30);

INSERT INTO Zamowienie_material(ID_pracownik, Data_zamowienia, ID_dostawca)
VALUES
(14,'2022-04-16',1),
(14,'2022-04-16',2),
(14,'2022-04-16',3),
(14,'2022-04-16',4),
(14,'2022-04-16',5),
(14,'2022-04-19',1),
(14,'2022-04-20',4),
(14,'2022-04-20',1),
(14,'2022-04-20',2);

INSERT INTO Stan_realizacji_zamowienie_material(ID_zamowienie_material, ID_status_zamowienie, Data_stan, ID_pracownik)
VALUES
(1,1,'2022-04-16 09:10:00',14),
(2,1,'2022-04-16 09:20:00',14),
(3,1,'2022-04-16 09:30:00',14),
(4,1,'2022-04-16 09:40:00',14),
(5,1,'2022-04-16 09:50:00',14),
(1,2,'2022-04-17 08:40:00',14),
(2,2,'2022-04-17 09:10:00',14),
(3,2,'2022-04-17 09:30:00',14),
(4,2,'2022-04-17 10:10:00',14),
(5,2,'2022-04-17 11:10:00',14),
(1,3,'2022-04-18 08:30:00',15),
(2,3,'2022-04-18 12:10:00',18),
(3,3,'2022-04-18 12:30:00',19),
(4,3,'2022-04-18 13:10:00',15),
(5,3,'2022-04-18 13:40:00',19),
(1,4,'2022-04-19 08:30:00',18),
(2,4,'2022-04-19 09:10:00',19),
(3,4,'2022-04-19 10:10:00',18),
(4,4,'2022-04-19 11:40:00',15),
(5,4,'2022-04-19 12:10:00',19),
(6,1,'2022-04-19 12:48:51',14),
(6,2,'2022-04-19 13:21:21',14),
(6,3,'2022-04-19 14:21:21',19),
(6,4,'2022-04-19 15:21:21',18),
(7,1,'2022-04-20 08:48:51',14),
(7,2,'2022-04-20 10:21:21',14),
(7,3,'2022-04-20 11:21:21',19),
(7,4,'2022-04-20 12:21:21',18),
(8,1,'2022-04-21 09:48:51',14),
(8,2,'2022-04-21 10:21:21',14),
(9,1,'2022-04-21 11:45:33',14),
(9,2,'2022-04-21 12:12:14',14),
(9,3,'2022-04-21 13:37:35',15),
(9,4,'2022-04-21 14:15:28',18);

INSERT INTO Szczegoly_zamowienie_material(ID_zamowienie_material, ID_material, ID_producent, Waga_g, Cena)
VALUES
(1,1,3,15000,3400),
(2,2,2,20000,1650),
(3,3,2,15000,1000),
(4,4,5,25000,2000),
(5,5,5,45000,3200),
(6,6,1,20500,2500),
(7,7,2,10000,1100),
(8,3,1,28000,1700),
(9,8,4,7000,310);

INSERT INTO Zamowienie_czesc(ID_pracownik, Data_zamowienia, ID_dostawca)
VALUES
(14,'2022-04-17',4),
(14,'2022-04-17',2),
(14,'2022-04-17',1),
(14,'2022-04-17',3),
(14,'2022-04-17',5),
(14,'2022-04-20',1);

INSERT INTO Stan_realizacji_zamowienie_czesc(ID_zamowienie_czesc, ID_status_zamowienie, Data_stan, ID_pracownik)
VALUES
(1,1,'2022-04-17 08:10:00',14),
(2,1,'2022-04-17 09:11:00',14),
(3,1,'2022-04-17 09:45:00',14),
(4,1,'2022-04-17 10:40:00',14),
(5,1,'2022-04-17 10:50:00',14),
(1,2,'2022-04-18 09:40:00',14),
(2,2,'2022-04-18 09:50:00',14),
(3,2,'2022-04-18 10:30:00',14),
(4,2,'2022-04-18 11:10:00',14),
(5,2,'2022-04-18 11:30:00',14),
(1,3,'2022-04-19 08:30:00',18),
(2,3,'2022-04-19 09:10:00',15),
(3,3,'2022-04-19 09:30:00',19),
(4,3,'2022-04-19 10:10:00',19),
(5,3,'2022-04-19 10:40:00',15),
(1,4,'2022-04-20 08:30:00',18),
(2,4,'2022-04-20 09:10:00',18),
(3,4,'2022-04-20 09:16:00',19),
(4,4,'2022-04-20 10:14:00',15),
(5,4,'2022-04-20 11:10:00',18),
(6,1,'2022-04-20 12:43:51',14);

INSERT INTO Szczegoly_zamowienie_czesc(ID_zamowienie_czesc, ID_czesc, ID_producent, Ilosc, Cena)
VALUES
(1,1,1,1,500),
(2,5,4,2,50),
(3,7,5,1,7000),
(4,8,2,1,1700),
(5,10,3,3,1300),
(6,3,1,5,1200);


INSERT INTO Zamowienie_narzedzie(ID_pracownik, Data_zamowienia, ID_dostawca)
VALUES
(14,'2022-04-17',1),
(14,'2022-04-17',3),
(14,'2022-04-17',5),
(14,'2022-04-17',4),
(14,'2022-04-17',2),
(14,'2022-04-17',3),
(14,'2022-04-20',1);

INSERT INTO Stan_realizacji_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_status_zamowienie, Data_stan, ID_pracownik)
VALUES
(1,1,'2022-04-17 08:17:00',14),
(2,1,'2022-04-17 09:25:00',14),
(3,1,'2022-04-17 10:15:00',14),
(4,1,'2022-04-17 10:40:00',14),
(5,1,'2022-04-17 10:48:00',14),
(6,1,'2022-04-17 10:57:00',14),
(1,2,'2022-04-18 09:12:00',14),
(2,2,'2022-04-18 09:15:00',14),
(3,2,'2022-04-18 09:37:00',14),
(4,2,'2022-04-18 10:04:00',14),
(5,2,'2022-04-18 10:21:00',14),
(6,2,'2022-04-18 10:45:00',14),
(1,3,'2022-04-19 08:22:00',18),
(2,3,'2022-04-19 08:55:00',15),
(3,3,'2022-04-19 09:29:00',19),
(4,3,'2022-04-19 10:01:00',19),
(5,3,'2022-04-19 10:23:00',15),
(6,3,'2022-04-19 10:55:00',18),
(1,4,'2022-04-20 08:38:00',19),
(2,4,'2022-04-20 09:17:00',18),
(3,4,'2022-04-20 09:48:00',19),
(4,4,'2022-04-20 10:18:00',15),
(5,4,'2022-04-20 11:14:00',18),
(6,4,'2022-04-20 11:58:00',15),
(7,1,'2022-04-20 12:17:00',14),
(7,2,'2022-04-20 13:51:00',14),
(7,3,'2022-04-21 14:11:00',18);

INSERT INTO Szczegoly_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_narzedzie, ID_producent, Sztuk, Cena)
VALUES
(1,1,1,15,65),
(2,2,4,15,150),
(3,3,5,11,240),
(4,4,2,13,520),
(5,5,3,18,450),
(6,6,1,14,420),
(7,1,3,2,10);

INSERT INTO Zamowienie_maszyna(ID_pracownik, Data_zamowienia, ID_dostawca)
VALUES
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-18',4),
(14,'2022-04-18',2),
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-18',4),
(14,'2022-04-18',2),
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-18',4),
(14,'2022-04-18',2),
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-18',4),
(14,'2022-04-18',2),
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-18',4),
(14,'2022-04-18',2),
(14,'2022-04-18',1),
(14,'2022-04-18',3),
(14,'2022-04-18',5),
(14,'2022-04-21',2);

INSERT INTO Stan_realizacji_zamowienie_maszyna(ID_zamowienie_maszyna, ID_status_zamowienie, Data_stan, ID_pracownik)
VALUES
(1,1,'2022-04-18 08:17:00',14),
(2,1,'2022-04-18 09:03:00',14),
(3,1,'2022-04-18 09:15:00',14),
(4,1,'2022-04-18 09:31:00',14),
(5,1,'2022-04-18 09:43:00',14),
(6,1,'2022-04-18 09:51:00',14),
(7,1,'2022-04-18 10:01:00',14),
(8,1,'2022-04-18 10:13:00',14),
(9,1,'2022-04-18 10:21:00',14),
(10,1,'2022-04-18 10:34:00',14),
(11,1,'2022-04-18 10:39:00',14),
(12,1,'2022-04-18 10:51:00',14),
(13,1,'2022-04-18 11:02:00',14),
(14,1,'2022-04-18 10:13:00',14),
(15,1,'2022-04-18 10:20:00',14),
(16,1,'2022-04-18 10:24:00',14),
(17,1,'2022-04-18 10:29:00',14),
(18,1,'2022-04-18 10:37:00',14),
(19,1,'2022-04-18 10:48:00',14),
(20,1,'2022-04-18 10:56:00',14),
(21,1,'2022-04-18 11:04:00',14),
(22,1,'2022-04-18 11:16:00',14),
(23,1,'2022-04-18 11:21:00',14),
(24,1,'2022-04-18 11:32:00',14),
(25,1,'2022-04-18 11:44:00',14),
(26,1,'2022-04-18 12:01:00',14),
(27,1,'2022-04-18 12:09:00',14),
(28,1,'2022-04-18 12:18:00',14),
(1,2,'2022-04-19 08:17:00',14),
(2,2,'2022-04-19 09:03:00',14),
(3,2,'2022-04-19 09:15:00',14),
(4,2,'2022-04-19 09:31:00',14),
(5,2,'2022-04-19 09:43:00',14),
(6,2,'2022-04-19 09:51:00',14),
(7,2,'2022-04-19 10:02:00',14),
(8,2,'2022-04-19 10:14:00',14),
(9,2,'2022-04-19 10:22:00',14),
(10,2,'2022-04-19 10:35:00',14),
(11,2,'2022-04-19 10:42:00',14),
(12,2,'2022-04-19 10:53:00',14),
(13,2,'2022-04-19 11:01:00',14),
(14,2,'2022-04-19 10:15:00',14),
(15,2,'2022-04-19 10:26:00',14),
(16,2,'2022-04-19 10:28:00',14),
(17,2,'2022-04-19 10:31:00',14),
(18,2,'2022-04-19 10:38:00',14),
(19,2,'2022-04-19 10:43:00',14),
(20,2,'2022-04-19 10:51:00',14),
(21,2,'2022-04-19 11:02:00',14),
(22,2,'2022-04-19 11:11:00',14),
(23,2,'2022-04-19 11:23:00',14),
(24,2,'2022-04-19 11:37:00',14),
(25,2,'2022-04-19 11:44:00',14),
(26,2,'2022-04-19 12:51:00',14),
(27,2,'2022-04-19 12:58:00',14),
(28,2,'2022-04-19 13:03:00',14),
(1,3,'2022-04-20 08:17:00',15),
(2,3,'2022-04-20 09:03:00',18),
(3,3,'2022-04-20 09:15:00',19),
(4,3,'2022-04-20 09:31:00',19),
(5,3,'2022-04-20 09:43:00',18),
(6,3,'2022-04-20 09:51:00',15),
(7,3,'2022-04-20 10:01:00',15),
(8,3,'2022-04-18 10:13:00',18),
(9,3,'2022-04-20 10:21:00',19),
(10,3,'2022-04-20 10:34:00',15),
(11,3,'2022-04-20 10:39:00',19),
(12,3,'2022-04-20 10:51:00',18),
(13,3,'2022-04-20 11:02:00',18),
(14,3,'2022-04-20 10:13:00',15),
(15,3,'2022-04-20 10:20:00',19),
(16,3,'2022-04-20 10:24:00',15),
(17,3,'2022-04-20 10:29:00',19),
(18,3,'2022-04-20 10:37:00',18),
(19,3,'2022-04-20 10:48:00',18),
(20,3,'2022-04-20 10:56:00',19),
(21,3,'2022-04-20 11:04:00',15),
(22,3,'2022-04-20 11:16:00',18),
(23,3,'2022-04-20 11:21:00',18),
(24,3,'2022-04-20 11:32:00',19),
(25,3,'2022-04-20 11:44:00',19),
(26,3,'2022-04-20 12:01:00',15),
(27,3,'2022-04-20 12:09:00',15),
(28,3,'2022-04-20 12:18:00',15),
(1,4,'2022-04-21 08:17:00',15),
(2,4,'2022-04-21 09:03:00',18),
(3,4,'2022-04-21 09:15:00',19),
(4,4,'2022-04-21 09:31:00',19),
(5,4,'2022-04-21 09:43:00',18),
(6,4,'2022-04-21 09:51:00',15),
(7,4,'2022-04-21 10:01:00',15),
(8,4,'2022-04-21 10:13:00',18),
(9,4,'2022-04-21 10:21:00',19),
(10,4,'2022-04-21 10:34:00',15),
(11,4,'2022-04-21 10:39:00',19),
(12,4,'2022-04-21 10:51:00',18),
(13,4,'2022-04-21 11:02:00',18),
(14,4,'2022-04-21 10:13:00',15),
(15,4,'2022-04-21 10:20:00',19),
(16,4,'2022-04-21 10:24:00',15),
(17,4,'2022-04-21 10:29:00',19),
(18,4,'2022-04-21 10:37:00',18),
(19,4,'2022-04-21 10:48:00',18),
(20,4,'2022-04-21 10:56:00',19),
(21,4,'2022-04-21 11:04:00',15),
(22,4,'2022-04-21 11:16:00',18),
(23,4,'2022-04-21 11:21:00',18),
(24,4,'2022-04-21 11:32:00',19),
(25,4,'2022-04-21 11:44:00',19),
(26,4,'2022-04-21 12:01:00',15),
(27,4,'2022-04-21 12:09:00',15),
(28,4,'2022-04-21 12:18:00',15),
(29,1,'2022-04-21 12:20:00',15),
(29,2,'2022-04-21 12:52:00',15);

INSERT INTO Szczegoly_zamowienie_maszyna(ID_zamowienie_maszyna, ID_maszyna, ID_producent, Ilosc,Cena)
VALUES
(1,1,1,4,14000),
(2,2,2,1,7000),
(3,3,3,1,65000),
(4,4,4,1,2700),
(5,5,5,1,1649),
(6,6,6,1,5700),
(7,7,7,1,2100),
(8,1,1,1,3500),
(9,1,1,1,3500),
(10,1,1,1,3500),
(11,2,2,1,7000),
(12,2,2,1,7000),
(13,2,2,1,7000),
(14,3,3,1,65000),
(15,3,3,1,65000),
(16,3,3,1,65000),
(17,4,4,1,2700),
(18,4,4,1,2700),
(19,4,4,1,2700),
(20,5,5,1,1649),
(21,5,5,1,1649),
(22,5,5,1,1649),
(23,6,6,1,5700),
(24,6,6,1,5700),
(25,6,6,2,11000),
(26,7,7,1,2100),
(27,7,7,1,2100),
(28,7,7,1,2100),
(29,6,6,2,10600);

INSERT INTO Obsluga(ID_rodzaj_obsluga, ID_stanowisko_produkcyjne, Data_od, Data_do)
VALUES
(3,1,'2022-04-20 08:52:31','2022-04-21 12:26:45'),
(1,2,'2022-04-20 10:01:41',NULL),
(1,3,'2022-04-21 13:21:15','2021-04-21 14:56:11'),
(2,5,'2022-04-22 09:08:37','2021-04-23 10:21:57'),
(3,2,'2022-04-22 11:00:01','2021-04-24 10:33:15'),
(4,1,'2022-04-22 13:21:15','2022-04-22 14:56:11'),
(3,1,'2022-04-23 09:08:37','2022-04-23 10:21:57'),
(2,1,'2022-04-25 13:21:15','2022-04-26 14:56:11'),
(2,1,'2022-04-30 09:08:37','2021-04-30 10:21:57');

INSERT Obsluga_pracownik (ID_obsluga, ID_pracownik)
VALUES
(1,22),
(2,22),
(2,21),
(3,21),
(4,22),
(5,21),
(6,22),
(7,21),
(8,22),
(9,22);

INSERT INTO Wymiana_czesc(ID_obsluga, ID_maszyna_nr, ID_czesc)
VALUES
(2,1,3),
(2,1,4),
(2,1,5),
(3,2,7),
(3,2,8);

INSERT INTO Sklad_maszyna ( ID_maszyna, ID_czesc, Liczba_czesci)
VALUES
(1,3,3),
(1,4,1),
(1,5,1),
(2,6,1),
(2,7,1),
(2,8,1),
(3,19,1),
(3,15,4),
(3,18,4),
(3,12,1),
(4,15,4),
(4,14,1),
(4,18,4),
(5,9,3),
(5,10,1),
(5,11,1),
(5,13,1),
(5,17,1);

INSERT INTO Wytwarzanie (Id_pracownik, Id_zamowienie_szczegol, Czas_od, Czas_do)
VALUES
(7,1,'2022-04-04 08:00:00','2022-04-05 13:00:00'), 		--Wał czynny, projektowanie, 300
(2,1,'2022-04-05 08:00:00','2022-04-05 09:15:00'),		--Wał czynny, przygotowanie stanowiska, 15
(2,1,'2022-04-05 13:30:00','2022-04-25 01:30:00'),		--Wał czynny, drukowanie, 720
(2,1,'2022-04-25 08:00:00','2022-04-26 12:00:00'),		--Wał czynny, szlifowanie, 60
(8,1,'2022-04-04 08:00:00','2022-04-04 13:00:00'),		--Wał bierny, projektowanie,300
(2,1,'2022-04-05 08:00:00','2022-04-05 10:15:00'),		--Wał bierny, przygotowanie stanowiska, 15
(2,1,'2022-04-05 11:15:00','2022-04-20 21:00:00'),		--Wał bierny, drukowanie, 720
(2,1,'2022-04-21 08:00:00','2022-04-21 13:00:00'),		--Wał bierny, szlifowanie, 60
(7,1,'2022-04-05 11:00:00','2022-04-05 16:00:00'),		--Obudowa przekładni, projektowanie, 180
(2,1,'2022-04-06 09:15:00','2022-04-06 10:30:00'),		--Obudowa przekładni,przygotowanie stanow.,15
(2,1,'2022-04-06 11:30:00','2022-04-10 21:30:00'),		--Obudowa przekładni, drukowanie, 720
(2,1,'2022-04-11 08:00:00','2022-04-11 12:00:00'),		--Obudowa przekładni, wygładzanie, 60
(2,1,'2022-04-11 13:00:00','2022-04-11 20:00:00'),		--Obudowa przekładni, lakierowanie, 120
(2,1,'2022-04-26 15:00:00','2022-04-27 12:00:00'),		--Przekladnia zebata, montaz, 60
(2,1,'2022-04-27 12:00:00', NULL),						--Przekladnia zebata, klejenie, 60
(2,2,'2022-04-07 13:00:00','2022-04-07 16:00:00'), 		--Litofanowy klosz, skanowanie, 180
(2,2,'2022-04-08 13:00:00','2022-04-09 16:00:00'),		--Litofanowy klosz, projektowanie, 90
(2,2,'2022-04-10 08:00:00','2022-04-10 09:15:00'),  	--Litofanowy klosz, przygotowanie stanow., 15
(2,2,'2022-04-10 10:15:00','2022-04-18 16:15:00'),		--Litofanowy klosz, drukowanie, 480
(2,2,'2022-04-19 08:00:00','2022-04-20 08:30:00'),		--Litofanowy klosz, montaz, 30
(7,3,'2022-04-05 08:00:00','2022-04-07 10:00:00'),		--Tapicerka samochodowa, projektowanie, 120
(3,3,'2022-04-08 02:00:00','2022-04-08 03:15:00'),		--Tapicerka samochodowa, przygotowanie stano, 15
(3,3,'2022-04-08 03:35:00','2022-04-15 12:15:00'), 		--Tapicerka samochodowa, drukowanie, 240
(3,3,'2022-04-15 13:15:00','2022-04-15 17:15:00'),		--Tapicerka samochodowa, wygladzanie, 60
(3,3,'2022-04-15 18:00:00','2022-04-16 01:15:00'),		--Tapicerka samochodowa, montaz, 120
(7,4,'2022-04-10 08:00:00','2022-04-11 10:00:00'),		--Tapicerka samochodowa, projektowanie, 120
(3,4,'2022-04-06 15:15:00', NULL),						--Tapicerka samochodowa, przygotowanie stano, 15
(3,4,'2022-04-06 15:30:00', NULL),						--Tapicerka samochodowa, drukowanie, 240
(3,4,'2022-04-07 08:00:00', NULL),						--Tapicerka samochodowa, wygladzanie, 60
(3,4,'2022-04-07 09:00:00', NULL),						--Tapicerka samochodowa, montaz, 120
(7,5,'2022-04-06 10:00:00','2022-04-07 12:00:00'), 		--Kostka rubika, projektowanie, 120
(3,5,'2022-04-07 13:00:00','2022-04-07 14:15:00'),		--Kostka rubika, przygotowanie stanowiska, 15
(3,5,'2022-04-07 14:30:00','2022-04-14 15:15:00'), 		--Kostka rubika, drukowanie, 240
(3,5,'2022-04-08 08:00:00', NULL),						--Kostka rubika, szlifowanie, 60
(3,5,'2022-04-08 09:00:00', NULL),						--Kostka rubika, montaz, 60
(7,6,'2022-04-07 08:00:00','2022-04-07 10:00:00'),		--Tapicerka samochodowa, projektowanie, 120
(4,6,'2022-04-07 08:00:00','2022-04-07 08:15:00'),		--Tapicerka samochodowa, przygotowanie stano, 15
(4,6,'2022-04-07 10:00:00', NULL),						--Tapicerka samochodowa, drukowanie, 240
(4,6,'2022-04-07 14:00:00', NULL),						--Tapicerka samochodowa, wygladzanie, 60
(4,6,'2022-04-08 08:00:00', NULL),						--Tapicerka samochodowa, montaz, 120
(7,7,'2022-04-11 08:00:00','2022-04-11 10:00:00'),		--Kostka rubika, projektowanie, 120
(4,7,'2022-04-11 10:30:00','2022-04-11 11:15:00'),		--Kostka rubika, przygotowanie stanowiska, 15
(4,7,'2022-04-11 11:30:00','2022-04-17 12:15:00'),		--Kostka rubika, drukowanie, 240
(4,7,'2022-04-17 16:00:00','2022-04-17 18:00:00'),		--Kostka rubika, szlifowanie, 60
(4,7,'2022-04-17 19:00:00','2022-04-17 23:00:00');		--Kostka rubika, montaz, 60


INSERT INTO Proces_wytwarzanie_produkt (Id_wytwarzanie, Id_proces_produkt, Id_stanowisko_produkcyjne)
VALUES
(14,2,6),
(15,3,6),
(20,1,6),
(25,4,6),
(30,4,6),
(35,6,6),
(40,4,6),
(45,6,6);


INSERT INTO Proces_wytwarzanie_polprodukt (Id_wytwarzanie, Id_proces_polprodukt, Id_stanowisko_produkcyjne)
VALUES
(1,5,8),
(2,6,3),
(3,7,3),
(4,8,5),
(5,9,8),
(6,10,3),
(7,11,3),
(8,12,5),
(9,13,8),
(10,14,4),
(11,15,4),
(12,16,9),
(13,17,7),
(16,1,1),
(17,22,2),
(18,23,2),
(19,24,9),
(21,33,8),
(22,34,4),
(23,35,4),
(24,36,9),
(26,33,8),
(27,34,4),
(28,35,4),
(29,36,9),
(31,18,8),
(32,19,2),
(33,20,2),
(34,21,5),
(36,33,8),
(37,34,4),
(38,35,4),
(39,36,9),
(41,18,8),
(42,19,2),
(43,20,2),
(44,21,5);

INSERT INTO Kontrola_jakosci_produkt (Id_pracownik, Id_rodzaj_kontrola, ID_wytwarzanie, Data_od, Data_do, Uwagi)
VALUES
(2,2,15,'2022-04-07 13:00:00','2022-04-07 14:00:00','BRAK'),
(2,1,15,'2022-04-07 14:00:00','2022-04-07 15:00:00','BRAK'),
(2,2,20,'2022-04-09 08:30:00','2022-04-09 09:00:00','BRAK'),
(3,2,25,'2022-04-05 15:15:00','2022-04-05 15:30:00','BRAK'),
(3,5,25,'2022-04-05 15:30:00','2022-04-05 16:00:00','BRAK'),
(3,2,30,'2022-04-09 09:00:00','2022-04-09 09:30:00','BRAK'),
(3,5,30,'2022-04-09 09:30:00','2022-04-09 10:00:00','BRAK'),
(3,2,35,'2022-04-09 10:00:00','2022-04-09 10:30:00','BRAK'),
(3,3,35,'2022-04-09 10:30:00','2022-04-09 11:00:00','BRAK'),
(3,4,35,'2022-04-09 11:00:00','2022-04-09 11:30:00','BRAK'),
(4,2,40,'2022-04-09 08:00:00','2022-04-09 08:30:00','BRAK'),
(4,5,40,'2022-04-09 08:30:00','2022-04-09 09:00:00','BRAK'),
(4,2,45,'2022-04-09 09:00:00','2022-04-09 09:30:00','BRAK'),
(4,3,45,'2022-04-09 09:30:00','2022-04-09 10:00:00','BRAK');


INSERT INTO Nadgodziny (ID_pracownik, Data_nadgodziny,Czas)
Values
(1,'2022-04-02','2'),
(1,'2022-04-05','3'),
(2,'2022-04-05','4'),
(4,'2022-04-08','1'),
(4,'2022-04-02','2'),
(4,'2022-04-06','3'),
(5,'2022-04-02','1'),
(6,'2022-04-07','1'),
(6,'2022-04-09','2'),
(7,'2022-04-09','2'),
(7,'2022-04-09','2'),
(8,'2022-04-09','2'),
(8,'2022-04-09','2'),
(9,'2022-04-09','2'),
(9,'2022-04-09','2'),
(10,'2022-04-09','2');

INSERT INTO Czas_pracy (Data, Liczba_godzin)
VALUES
('2022-04-01', '154'),
('2022-03-01', '180');

INSERT INTO Kontrola_parametr (ID_kontrola_jakosci_produkt, ID_parametr_produkt, Wartosc)
VALUES
(2,3,300),
(2,4,105),
(2,6,51),
(3,5,83),
(5,1,150),
(5,2,98),
(7,7,99),
(7,8,102),
(7,9,50),
(7,10,12),
(9,7,98),
(9,8,99),
(9,9,48),
(9,10,9),
(11,14,5),
(11,15,2500),
(11,16,34),
(13,7,97),
(13,8,100),
(13,9,49),
(13,10,11),
(14,14,4),
(14,15,1500),
(14,16,37);

INSERT INTO Alert ( ID_dzial, Tresc, Czy_odczytano)
VALUES
(4, 'Zamów filament ABS', 1),
(4, 'Zamów filament PLA', 0),
(4, 'Proszek stali 316L', 1),
(4, 'Proszek stali PETG', 1),
(5, 'Wyczyść stanowisko nr 2', 0);

INSERT INTO Wyplata (ID_Pracownik,Data_wyplaty)
VALUES
(1,'2022-04-10'),
(2,'2022-04-10'),
(3,'2022-04-10'),
(4,'2022-04-10'),
(5,'2022-04-10'),
(6,'2022-04-10'),
(7,'2022-04-10'),
(8,'2022-04-10'),
(9,'2022-04-10'),
(10,'2022-04-10'),
(11,'2022-04-10'),
(12,'2022-04-10')