﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KWZPEntities : DbContext
    {
        public KWZPEntities()
            : base("name=KWZPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<Czas_pracy> Czas_pracy { get; set; }
        public virtual DbSet<Czesc> Czesc { get; set; }
        public virtual DbSet<Czynnosc_produkcyjna> Czynnosc_produkcyjna { get; set; }
        public virtual DbSet<Dane_adresowe_dostawca> Dane_adresowe_dostawca { get; set; }
        public virtual DbSet<Dane_adresowe_klient> Dane_adresowe_klient { get; set; }
        public virtual DbSet<Dane_adresowe_pracownik> Dane_adresowe_pracownik { get; set; }
        public virtual DbSet<Dane_adresowe_producent> Dane_adresowe_producent { get; set; }
        public virtual DbSet<Dostawca> Dostawca { get; set; }
        public virtual DbSet<Dzial> Dzial { get; set; }
        public virtual DbSet<Email_klient> Email_klient { get; set; }
        public virtual DbSet<Email_pracownik> Email_pracownik { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Forma_platnosc> Forma_platnosc { get; set; }
        public virtual DbSet<Gwarancja> Gwarancja { get; set; }
        public virtual DbSet<Jednostka> Jednostka { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Kontrola_jakosci_produkt> Kontrola_jakosci_produkt { get; set; }
        public virtual DbSet<Kontrola_parametr> Kontrola_parametr { get; set; }
        public virtual DbSet<Maszyna> Maszyna { get; set; }
        public virtual DbSet<Maszyna_nr_seryjny> Maszyna_nr_seryjny { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Nadgodziny> Nadgodziny { get; set; }
        public virtual DbSet<Narzedzie> Narzedzie { get; set; }
        public virtual DbSet<Nieobecnosc> Nieobecnosc { get; set; }
        public virtual DbSet<Nr_seryjny> Nr_seryjny { get; set; }
        public virtual DbSet<Nr_telefon_klient> Nr_telefon_klient { get; set; }
        public virtual DbSet<Nr_telefon_pracownik> Nr_telefon_pracownik { get; set; }
        public virtual DbSet<Obsluga> Obsluga { get; set; }
        public virtual DbSet<Oferta_handlowa> Oferta_handlowa { get; set; }
        public virtual DbSet<Parametr_czesc> Parametr_czesc { get; set; }
        public virtual DbSet<Parametr_maszyna> Parametr_maszyna { get; set; }
        public virtual DbSet<Parametr_material> Parametr_material { get; set; }
        public virtual DbSet<Parametr_narzedzie> Parametr_narzedzie { get; set; }
        public virtual DbSet<Parametr_polprodukt> Parametr_polprodukt { get; set; }
        public virtual DbSet<Parametr_produkt> Parametr_produkt { get; set; }
        public virtual DbSet<Podatek> Podatek { get; set; }
        public virtual DbSet<Posada_pracownika> Posada_pracownika { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Proces_polprodukt_czynnosc> Proces_polprodukt_czynnosc { get; set; }
        public virtual DbSet<Proces_produkt_czynnosc> Proces_produkt_czynnosc { get; set; }
        public virtual DbSet<Proces_wytwarzanie_polprodukt> Proces_wytwarzanie_polprodukt { get; set; }
        public virtual DbSet<Proces_wytwarzanie_produkt> Proces_wytwarzanie_produkt { get; set; }
        public virtual DbSet<Producent> Producent { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Reklamacja> Reklamacja { get; set; }
        public virtual DbSet<Rodzaj_czesc> Rodzaj_czesc { get; set; }
        public virtual DbSet<Rodzaj_kontrola> Rodzaj_kontrola { get; set; }
        public virtual DbSet<Rodzaj_maszyna> Rodzaj_maszyna { get; set; }
        public virtual DbSet<Rodzaj_material> Rodzaj_material { get; set; }
        public virtual DbSet<Rodzaj_nieobecnosci> Rodzaj_nieobecnosci { get; set; }
        public virtual DbSet<Rodzaj_obsluga> Rodzaj_obsluga { get; set; }
        public virtual DbSet<Rodzaj_parametr> Rodzaj_parametr { get; set; }
        public virtual DbSet<Rodzaj_umowy> Rodzaj_umowy { get; set; }
        public virtual DbSet<Sklad_maszyna> Sklad_maszyna { get; set; }
        public virtual DbSet<Sklad_polprodukt> Sklad_polprodukt { get; set; }
        public virtual DbSet<Sklad_produkt> Sklad_produkt { get; set; }
        public virtual DbSet<Sklad_produkt_material> Sklad_produkt_material { get; set; }
        public virtual DbSet<Sklad_stanowisko_produkcyjne_maszyna> Sklad_stanowisko_produkcyjne_maszyna { get; set; }
        public virtual DbSet<Sklad_stanowisko_produkcyjne_narzedzie> Sklad_stanowisko_produkcyjne_narzedzie { get; set; }
        public virtual DbSet<Slownik_polprodukt> Slownik_polprodukt { get; set; }
        public virtual DbSet<Slownik_stanowisko> Slownik_stanowisko { get; set; }
        public virtual DbSet<Sprzedaz> Sprzedaz { get; set; }
        public virtual DbSet<Stan_realizacji_zamowienie_czesc> Stan_realizacji_zamowienie_czesc { get; set; }
        public virtual DbSet<Stan_realizacji_zamowienie_maszyna> Stan_realizacji_zamowienie_maszyna { get; set; }
        public virtual DbSet<Stan_realizacji_zamowienie_material> Stan_realizacji_zamowienie_material { get; set; }
        public virtual DbSet<Stan_realizacji_zamowienie_narzedzie> Stan_realizacji_zamowienie_narzedzie { get; set; }
        public virtual DbSet<Stanowisko> Stanowisko { get; set; }
        public virtual DbSet<Stanowisko_produkcyjne> Stanowisko_produkcyjne { get; set; }
        public virtual DbSet<Status_oferta> Status_oferta { get; set; }
        public virtual DbSet<Status_zamowienie> Status_zamowienie { get; set; }
        public virtual DbSet<Szczegoly_sprzedaz> Szczegoly_sprzedaz { get; set; }
        public virtual DbSet<Szczegoly_zamowienie_czesc> Szczegoly_zamowienie_czesc { get; set; }
        public virtual DbSet<Szczegoly_zamowienie_maszyna> Szczegoly_zamowienie_maszyna { get; set; }
        public virtual DbSet<Szczegoly_zamowienie_material> Szczegoly_zamowienie_material { get; set; }
        public virtual DbSet<Szczegoly_zamowienie_narzedzie> Szczegoly_zamowienie_narzedzie { get; set; }
        public virtual DbSet<Typ_zamowienie> Typ_zamowienie { get; set; }
        public virtual DbSet<Umowa> Umowa { get; set; }
        public virtual DbSet<Umowa_sprzedaz> Umowa_sprzedaz { get; set; }
        public virtual DbSet<Wyksztalcenie> Wyksztalcenie { get; set; }
        public virtual DbSet<Wymiana_czesc> Wymiana_czesc { get; set; }
        public virtual DbSet<Wymiar_pracy> Wymiar_pracy { get; set; }
        public virtual DbSet<Wytwarzanie> Wytwarzanie { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<Zamowienie_czesc> Zamowienie_czesc { get; set; }
        public virtual DbSet<Zamowienie_maszyna> Zamowienie_maszyna { get; set; }
        public virtual DbSet<Zamowienie_material> Zamowienie_material { get; set; }
        public virtual DbSet<Zamowienie_narzedzie> Zamowienie_narzedzie { get; set; }
        public virtual DbSet<Zamowienie_szczegol> Zamowienie_szczegol { get; set; }
        public virtual DbSet<Zwrot> Zwrot { get; set; }
        public virtual DbSet<v_Alerty_ResorceDepartment_nieodczytane> v_Alerty_ResorceDepartment_nieodczytane { get; set; }
        public virtual DbSet<v_Alerty_ResourceDepartment> v_Alerty_ResourceDepartment { get; set; }
        public virtual DbSet<v_Czesci> v_Czesci { get; set; }
        public virtual DbSet<v_Czynnosc_produkcyjna> v_Czynnosc_produkcyjna { get; set; }
        public virtual DbSet<v_Dane_adresowe_pracownik> v_Dane_adresowe_pracownik { get; set; }
        public virtual DbSet<v_Dodaj_szczegol_sprzedaz> v_Dodaj_szczegol_sprzedaz { get; set; }
        public virtual DbSet<v_Dostawcy> v_Dostawcy { get; set; }
        public virtual DbSet<v_Email_pracownik> v_Email_pracownik { get; set; }
        public virtual DbSet<v_Etat> v_Etat { get; set; }
        public virtual DbSet<v_Klient> v_Klient { get; set; }
        public virtual DbSet<v_Klient_telefon_aktualny> v_Klient_telefon_aktualny { get; set; }
        public virtual DbSet<v_Klient_telefon_Historia> v_Klient_telefon_Historia { get; set; }
        public virtual DbSet<v_Kontrola_jakosci_kolejka> v_Kontrola_jakosci_kolejka { get; set; }
        public virtual DbSet<v_Kontrola_jakosci_produkt> v_Kontrola_jakosci_produkt { get; set; }
        public virtual DbSet<v_Kontrola_negatywna> v_Kontrola_negatywna { get; set; }
        public virtual DbSet<v_Kontrola_parametr_produkt> v_Kontrola_parametr_produkt { get; set; }
        public virtual DbSet<v_Kontrola_pozytywna> v_Kontrola_pozytywna { get; set; }
        public virtual DbSet<v_Koszt> v_Koszt { get; set; }
        public virtual DbSet<v_Koszt_godziny_pracy> v_Koszt_godziny_pracy { get; set; }
        public virtual DbSet<v_Koszt_procesow_polprodukt> v_Koszt_procesow_polprodukt { get; set; }
        public virtual DbSet<v_Koszt_procesow_produkt> v_Koszt_procesow_produkt { get; set; }
        public virtual DbSet<v_Koszt_produkcji> v_Koszt_produkcji { get; set; }
        public virtual DbSet<v_Koszt_roboczogodziny_stanowiska> v_Koszt_roboczogodziny_stanowiska { get; set; }
        public virtual DbSet<v_Liczba_zabiegow_wytworczych_polprodukt> v_Liczba_zabiegow_wytworczych_polprodukt { get; set; }
        public virtual DbSet<v_Liczba_zabiegow_wytworczych_produkt> v_Liczba_zabiegow_wytworczych_produkt { get; set; }
        public virtual DbSet<v_Magazyn_czesci_aktualny> v_Magazyn_czesci_aktualny { get; set; }
        public virtual DbSet<v_Magazyn_czesci_stan> v_Magazyn_czesci_stan { get; set; }
        public virtual DbSet<v_Magazyn_czesci_wszystko> v_Magazyn_czesci_wszystko { get; set; }
        public virtual DbSet<v_Magazyn_czesci_wymienione> v_Magazyn_czesci_wymienione { get; set; }
        public virtual DbSet<v_Magazyn_maszyn_nieuzywane> v_Magazyn_maszyn_nieuzywane { get; set; }
        public virtual DbSet<v_Magazyn_maszyn_stan> v_Magazyn_maszyn_stan { get; set; }
        public virtual DbSet<v_Magazyn_maszyn_uzywane> v_Magazyn_maszyn_uzywane { get; set; }
        public virtual DbSet<v_Magazyn_maszyn_wszystko> v_Magazyn_maszyn_wszystko { get; set; }
        public virtual DbSet<v_Magazyn_material_aktualny> v_Magazyn_material_aktualny { get; set; }
        public virtual DbSet<v_Magazyn_material_aktualny_dodanie> v_Magazyn_material_aktualny_dodanie { get; set; }
        public virtual DbSet<v_Magazyn_material_przejsciowy> v_Magazyn_material_przejsciowy { get; set; }
        public virtual DbSet<v_Magazyn_material_wszystko> v_Magazyn_material_wszystko { get; set; }
        public virtual DbSet<v_Magazyn_narzedzia_nieuzywane> v_Magazyn_narzedzia_nieuzywane { get; set; }
        public virtual DbSet<v_Magazyn_narzedzia_nieuzywane_ID> v_Magazyn_narzedzia_nieuzywane_ID { get; set; }
        public virtual DbSet<v_Magazyn_narzedzia_stan> v_Magazyn_narzedzia_stan { get; set; }
        public virtual DbSet<v_Magazyn_narzedzia_uzywane> v_Magazyn_narzedzia_uzywane { get; set; }
        public virtual DbSet<v_Magazyn_narzedzia_wszystko> v_Magazyn_narzedzia_wszystko { get; set; }
        public virtual DbSet<v_Magazyn_Produkty_Wytworzone> v_Magazyn_Produkty_Wytworzone { get; set; }
        public virtual DbSet<v_Maszyna> v_Maszyna { get; set; }
        public virtual DbSet<v_Maszyna_nr_seryjny> v_Maszyna_nr_seryjny { get; set; }
        public virtual DbSet<v_Maszyny_numery_nieprzypisane> v_Maszyny_numery_nieprzypisane { get; set; }
        public virtual DbSet<v_Maszyny_numery_nieprzypisane_zero> v_Maszyny_numery_nieprzypisane_zero { get; set; }
        public virtual DbSet<v_Maszyny_numery_porownanie> v_Maszyny_numery_porownanie { get; set; }
        public virtual DbSet<v_Maszyny_numery_przypisane> v_Maszyny_numery_przypisane { get; set; }
        public virtual DbSet<v_Material> v_Material { get; set; }
        public virtual DbSet<v_Nadgodziny> v_Nadgodziny { get; set; }
        public virtual DbSet<v_Nadgodziny_miesiac> v_Nadgodziny_miesiac { get; set; }
        public virtual DbSet<v_Nadgodziny_suma_miesiac> v_Nadgodziny_suma_miesiac { get; set; }
        public virtual DbSet<v_Nieobecnosc> v_Nieobecnosc { get; set; }
        public virtual DbSet<v_Nr_seryjny_maszyna> v_Nr_seryjny_maszyna { get; set; }
        public virtual DbSet<v_Nr_telefon_pracownik> v_Nr_telefon_pracownik { get; set; }
        public virtual DbSet<v_Obsluga_cmb> v_Obsluga_cmb { get; set; }
        public virtual DbSet<v_Obsluga_cmb_wymiana> v_Obsluga_cmb_wymiana { get; set; }
        public virtual DbSet<v_Obsluga_pracownik> v_Obsluga_pracownik { get; set; }
        public virtual DbSet<v_Obslugi_w_trakcie> v_Obslugi_w_trakcie { get; set; }
        public virtual DbSet<v_Obslugi_w_trakcie_wymiana> v_Obslugi_w_trakcie_wymiana { get; set; }
        public virtual DbSet<v_Obslugi_zakonczone> v_Obslugi_zakonczone { get; set; }
        public virtual DbSet<v_Oferta_handlowa> v_Oferta_handlowa { get; set; }
        public virtual DbSet<v_Oferta_handlowa_do_rozpatrzenia> v_Oferta_handlowa_do_rozpatrzenia { get; set; }
        public virtual DbSet<v_Parametry_czesc> v_Parametry_czesc { get; set; }
        public virtual DbSet<v_Parametry_maszyna> v_Parametry_maszyna { get; set; }
        public virtual DbSet<v_Parametry_material> v_Parametry_material { get; set; }
        public virtual DbSet<v_Parametry_narzedzie> v_Parametry_narzedzie { get; set; }
        public virtual DbSet<v_Parametry_polprodukt> v_Parametry_polprodukt { get; set; }
        public virtual DbSet<v_Parametry_produkt> v_Parametry_produkt { get; set; }
        public virtual DbSet<v_Polprodukt_material> v_Polprodukt_material { get; set; }
        public virtual DbSet<v_Pracownik> v_Pracownik { get; set; }
        public virtual DbSet<v_Pracownik_dzial> v_Pracownik_dzial { get; set; }
        public virtual DbSet<v_Pracownik_obslugi> v_Pracownik_obslugi { get; set; }
        public virtual DbSet<v_Pracownik_produkcja> v_Pracownik_produkcja { get; set; }
        public virtual DbSet<v_Pracownik_zasoby> v_Pracownik_zasoby { get; set; }
        public virtual DbSet<v_Proces_polprodukt_czynnosc> v_Proces_polprodukt_czynnosc { get; set; }
        public virtual DbSet<v_Proces_polprodukt_czynnosc_projekt> v_Proces_polprodukt_czynnosc_projekt { get; set; }
        public virtual DbSet<v_Proces_produkt_czynnosc> v_Proces_produkt_czynnosc { get; set; }
        public virtual DbSet<v_Proces_produkt_czynnosc_projekt> v_Proces_produkt_czynnosc_projekt { get; set; }
        public virtual DbSet<v_Proces_wytwarzanie_polprodukt> v_Proces_wytwarzanie_polprodukt { get; set; }
        public virtual DbSet<v_Proces_wytwarzanie_polprodukt_ewidencja> v_Proces_wytwarzanie_polprodukt_ewidencja { get; set; }
        public virtual DbSet<v_Proces_wytwarzanie_produkt> v_Proces_wytwarzanie_produkt { get; set; }
        public virtual DbSet<v_Proces_wytwarzanie_produkt_ewidencja> v_Proces_wytwarzanie_produkt_ewidencja { get; set; }
        public virtual DbSet<v_Producenci> v_Producenci { get; set; }
        public virtual DbSet<v_Produkt_material> v_Produkt_material { get; set; }
        public virtual DbSet<v_Produkty_na_gwarancji> v_Produkty_na_gwarancji { get; set; }
        public virtual DbSet<v_Reklamacja> v_Reklamacja { get; set; }
        public virtual DbSet<v_Rodzaj_kontrola> v_Rodzaj_kontrola { get; set; }
        public virtual DbSet<v_Rodzaj_parametr> v_Rodzaj_parametr { get; set; }
        public virtual DbSet<v_Sklad_maszyna> v_Sklad_maszyna { get; set; }
        public virtual DbSet<v_Sklad_polprodukt> v_Sklad_polprodukt { get; set; }
        public virtual DbSet<v_Sklad_produkt> v_Sklad_produkt { get; set; }
        public virtual DbSet<v_Sklad_produkt_ewidencja> v_Sklad_produkt_ewidencja { get; set; }
        public virtual DbSet<v_Sklad_produkt_material> v_Sklad_produkt_material { get; set; }
        public virtual DbSet<v_Sklad_SP_maszyna> v_Sklad_SP_maszyna { get; set; }
        public virtual DbSet<v_Sklad_stanowisko_produkcyjne_maszyna> v_Sklad_stanowisko_produkcyjne_maszyna { get; set; }
        public virtual DbSet<v_Sklad_stanowisko_produkcyjne_maszyna_ID> v_Sklad_stanowisko_produkcyjne_maszyna_ID { get; set; }
        public virtual DbSet<v_Sklad_stanowisko_produkcyjne_narzedzie> v_Sklad_stanowisko_produkcyjne_narzedzie { get; set; }
        public virtual DbSet<v_Sklad_stanowisko_produkcyjne_narzedzie_ID> v_Sklad_stanowisko_produkcyjne_narzedzie_ID { get; set; }
        public virtual DbSet<v_Slownik_stanowisko> v_Slownik_stanowisko { get; set; }
        public virtual DbSet<v_Sprzedane_zamowienia> v_Sprzedane_zamowienia { get; set; }
        public virtual DbSet<v_Sprzedane_zamowienia_form> v_Sprzedane_zamowienia_form { get; set; }
        public virtual DbSet<v_Sprzedany_produkt> v_Sprzedany_produkt { get; set; }
        public virtual DbSet<v_Sprzedaz> v_Sprzedaz { get; set; }
        public virtual DbSet<v_Sprzedaz_statystyki> v_Sprzedaz_statystyki { get; set; }
        public virtual DbSet<v_Sprzedaz_statystyki_produkty> v_Sprzedaz_statystyki_produkty { get; set; }
        public virtual DbSet<v_Sprzedaz_statystyki_zarobek_dnia> v_Sprzedaz_statystyki_zarobek_dnia { get; set; }
        public virtual DbSet<v_Stanowiska_do_uzycia> v_Stanowiska_do_uzycia { get; set; }
        public virtual DbSet<v_Stanowiska_produkcyjne> v_Stanowiska_produkcyjne { get; set; }
        public virtual DbSet<v_Stanowiska_w_uzyciu> v_Stanowiska_w_uzyciu { get; set; }
        public virtual DbSet<v_Stanowisko_produkcyjne> v_Stanowisko_produkcyjne { get; set; }
        public virtual DbSet<v_Sz_czas_proces_polprodukt_czynnosc> v_Sz_czas_proces_polprodukt_czynnosc { get; set; }
        public virtual DbSet<v_Sz_czas_proces_produkt_czynnosc> v_Sz_czas_proces_produkt_czynnosc { get; set; }
        public virtual DbSet<v_Szacowany_czas_wytwarzania_polprodukt> v_Szacowany_czas_wytwarzania_polprodukt { get; set; }
        public virtual DbSet<v_Szacowany_czas_wytwarzania_produkt> v_Szacowany_czas_wytwarzania_produkt { get; set; }
        public virtual DbSet<v_Szczegoly_sprzedaz> v_Szczegoly_sprzedaz { get; set; }
        public virtual DbSet<v_Tygodniowe_rozliczenie_pracy_produkcja> v_Tygodniowe_rozliczenie_pracy_produkcja { get; set; }
        public virtual DbSet<v_Umowa> v_Umowa { get; set; }
        public virtual DbSet<v_Umowa_do_sprzedaz> v_Umowa_do_sprzedaz { get; set; }
        public virtual DbSet<v_Wymiana_czesc> v_Wymiana_czesc { get; set; }
        public virtual DbSet<v_Wymiana_czesc_w_trakcie> v_Wymiana_czesc_w_trakcie { get; set; }
        public virtual DbSet<v_Wynik_kontroli> v_Wynik_kontroli { get; set; }
        public virtual DbSet<v_Wytwarzanie> v_Wytwarzanie { get; set; }
        public virtual DbSet<v_Wytworzone_polprodukty_material> v_Wytworzone_polprodukty_material { get; set; }
        public virtual DbSet<v_Wytworzone_produkty> v_Wytworzone_produkty { get; set; }
        public virtual DbSet<v_Wytworzone_produkty_sklad> v_Wytworzone_produkty_sklad { get; set; }
        public virtual DbSet<v_Wytworzone_produkty_zamowienie> v_Wytworzone_produkty_zamowienie { get; set; }
        public virtual DbSet<v_Wytworzony_produkt_material> v_Wytworzony_produkt_material { get; set; }
        public virtual DbSet<v_Zamowienia_czesci_w_trakcie> v_Zamowienia_czesci_w_trakcie { get; set; }
        public virtual DbSet<v_Zamowienia_czesci_w_trakcie_bez_odebranych> v_Zamowienia_czesci_w_trakcie_bez_odebranych { get; set; }
        public virtual DbSet<v_Zamowienia_czesci_w_trakcie_wszystko> v_Zamowienia_czesci_w_trakcie_wszystko { get; set; }
        public virtual DbSet<v_Zamowienia_maszyny_w_trakcie> v_Zamowienia_maszyny_w_trakcie { get; set; }
        public virtual DbSet<v_Zamowienia_maszyny_w_trakcie_bez_odebranych> v_Zamowienia_maszyny_w_trakcie_bez_odebranych { get; set; }
        public virtual DbSet<v_Zamowienia_maszyny_w_trakcie_wszystko> v_Zamowienia_maszyny_w_trakcie_wszystko { get; set; }
        public virtual DbSet<v_Zamowienia_materialy_w_trakcie> v_Zamowienia_materialy_w_trakcie { get; set; }
        public virtual DbSet<v_Zamowienia_materialy_w_trakcie_bez_odebranych> v_Zamowienia_materialy_w_trakcie_bez_odebranych { get; set; }
        public virtual DbSet<v_Zamowienia_materialy_w_trakcie_wszystko> v_Zamowienia_materialy_w_trakcie_wszystko { get; set; }
        public virtual DbSet<v_Zamowienia_narzedzia_w_trakcie> v_Zamowienia_narzedzia_w_trakcie { get; set; }
        public virtual DbSet<v_Zamowienia_narzedzia_w_trakcie_bez_odebranych> v_Zamowienia_narzedzia_w_trakcie_bez_odebranych { get; set; }
        public virtual DbSet<v_Zamowienia_narzedzia_w_trakcie_wszystko> v_Zamowienia_narzedzia_w_trakcie_wszystko { get; set; }
        public virtual DbSet<v_Zamowienia_niesprzedane> v_Zamowienia_niesprzedane { get; set; }
        public virtual DbSet<v_Zamowienie> v_Zamowienie { get; set; }
        public virtual DbSet<v_Zamowienie_produkcja> v_Zamowienie_produkcja { get; set; }
        public virtual DbSet<v_Zamowienie_szczegol> v_Zamowienie_szczegol { get; set; }
        public virtual DbSet<v_Zamowienie_szczegol_produkcja> v_Zamowienie_szczegol_produkcja { get; set; }
    }
}
