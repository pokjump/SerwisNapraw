# SerwisNapraw 2.0 - System Zarządzania Serwisem Sprzętu Elektronicznego

Aplikacja desktopowa (Windows Forms) napisana w języku C# służąca do kompleksowej obsługi serwisu naprawczego. System umożliwia przyjmowanie zleceń, zarządzanie pracą serwisantów, konfigurację typów sprzętu oraz analizę statystyk za pomocą autorskiego silnika wykresów.

## 🚀 Główne Funkcjonalności

* **Obsługa Zleceń:** Rejestracja nowych napraw z walidacją danych (NIP, telefon), podział na klientów indywidualnych i firmowych.
* **Workflow Naprawy:** Śledzenie statusu (W toku / Zakończone), rozliczanie kosztów (części + robocizna) oraz weryfikacja wykonanych czynności.
* **Zarządzanie Personelem:** Przypisywanie zadań do serwisantów na podstawie ich kwalifikacji.
* **Dynamiczna Konfiguracja:** Możliwość dodawania nowych typów sprzętu (np. Konsola, Tablet) oraz definiowania dla nich typowych usterek w czasie rzeczywistym.
* **Historia i Wyszukiwanie:** Przeszukiwanie bazy zleceń po modelu, nazwisku klienta lub numerze seryjnym.
* **Moduł Raportowy:** Generowanie wykresów słupkowych (statystyki miesięczne) rysowanych od podstaw przy użyciu GDI+ (bez użycia gotowych kontrolek wykresów).
* **Zapis Danych:** Automatyczna serializacja bazy napraw do pliku JSON.

## 🛠 Technologie i Architektura

Projekt został zrealizowany z naciskiem na czysty kod i podział odpowiedzialności.

* **Język:** C# (.NET)
* **Interfejs:** Windows Forms (WinForms)
* **Dane:** System.Text.Json (baza danych w pliku `baza.json`)
* **Grafika:** System.Drawing (GDI+) - własny silnik renderujący wykresy.

### Zastosowane Wzorce Projektowe i Rozwiązania:

1.  **MVC (Model-View-Controller):** Ścisła separacja logiki od interfejsu.
    * *View:* Formularze (np. `FormDodaj`, `FormWykresy`) zajmują się tylko wyświetlaniem.
    * *Controller:* (np. `KontrolerDodawaniaZlecenia`) pośredniczy i przygotowuje dane.
    * *Model/Service:* `ZarzadzanieSerwisem` zawiera całą logikę biznesową i walidację.
2.  **Fasada:** Klasa `ZarzadzanieSerwisem` jest głównym punktem dostępu do logiki aplikacji dla wszystkich kontrolerów.
3.  **Observer (Zdarzenia):** Komunikacja między logiką a UI odbywa się poprzez `Event` i `Delegate` (np. `ZglosKomunikat`, `ZadajPytanie`), co zapobiega "zamrażaniu" interfejsu i zapewnia luźne powiązania.
4.  **Factory Pattern (Fabryka):** Klasa `KonfiguracjaSystemu` wykorzystuje słownik delegatów `Func<Sprzet>` do dynamicznego tworzenia instancji odpowiednich klas sprzętu (Komputer, Telefon itp.) bez konieczności używania rozbudowanych instrukcji `switch`.

## 📂 Struktura Projektu

* **Formularze (`View`):** Odpowiadają za interakcję z użytkownikiem (np. `Form1.cs`, `FormZakoncz.cs`).
* **Kontrolery (`Controller`):** Logika sterująca konkretnymi oknami (np. `KontrolerSerwisantow.cs`).
* **Modele (`Model`):** Klasy danych (`Naprawa.cs`, `Klient.cs`, `Serwisant.cs`).
* **Logika Biznesowa:**
    * `ZarzadzanieSerwisem.cs` - Mózg aplikacji.
    * `KonfiguracjaSystemu.cs` - Zarządzanie definicjami sprzętu i pracownikami.
    * `ObslugaDanych.cs` - Odczyt/Zapis JSON.
* **Silnik Wykresów:**
    * `WykresRenderer.cs` - Rysowanie osi, słupków i legendy (GDI+).
    * `WykresPresenter.cs` - Przygotowanie danych liczbowych dla wykresu.

## 🔧 Instalacja i Uruchomienie

1.  Sklonuj repozytorium lub pobierz pliki.
2.  Otwórz plik rozwiązania (`.sln`) w Visual Studio.
3.  Upewnij się, że masz zainstalowane środowisko .NET obsługujące WinForms.
4.  Zbuduj i uruchom projekt (F5).

> **Uwaga:** Przy pierwszym uruchomieniu aplikacja utworzy plik `baza.json` w folderze wykonywalnym. Domyślna konfiguracja (pracownicy, typy sprzętu) ładowana jest przy każdym starcie z metody `KonfiguracjaSystemu.ZaladujDomyslne()`.

## 📸 Zrzuty Ekranu
*(Tutaj możesz dodać screenshoty aplikacji, jeśli posiadasz)*

## 📝 Autor
[Twoje Imię / Nick]
