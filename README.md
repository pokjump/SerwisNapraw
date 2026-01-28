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
<img width="778" height="496" alt="image" src="https://github.com/user-attachments/assets/8c4ae5b4-02ba-4851-a964-d5939a56ebe9" />
<img width="475" height="507" alt="image" src="https://github.com/user-attachments/assets/475fcf3d-a07d-45b8-b63d-e917747c83c9" />
<img width="853" height="475" alt="image" src="https://github.com/user-attachments/assets/ada0fab2-dd27-4b92-b469-e18d4fea6114" />
<img width="795" height="477" alt="image" src="https://github.com/user-attachments/assets/d65ee4b8-b361-4511-b7ef-d5f959e7093c" />
<img width="776" height="486" alt="image" src="https://github.com/user-attachments/assets/ffeeb12f-003b-494c-891f-afeb9e87a365" />
<img width="784" height="590" alt="image" src="https://github.com/user-attachments/assets/69ea2975-c2a7-43e6-ba95-91923542117b" />
<img width="648" height="479" alt="image" src="https://github.com/user-attachments/assets/65b23db3-bd5b-46b9-81d9-06dc77ca64b7" />

## 📝 Autor
pokjump
