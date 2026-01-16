# SerwisNapraw v2.0

Kompleksowy system obsługi zleceń serwisowych napisany w C# (Windows Forms). Aplikacja umożliwia pełne zarządzanie procesem naprawy sprzętu elektronicznego, od przyjęcia zlecenia, przez przydział serwisanta, aż po finalizację i analizę statystyk.

## Kluczowe Funkcjonalności

### 1. Zarządzanie Zleceniami
- **Rejestracja:** Przyjmowanie zgłoszeń dla różnych typów sprzętu (domyślnie: Komputer, Telefon, Monitor, Drukarka).
- **Klienci:** Obsługa zarówno osób prywatnych, jak i firm (walidacja NIP).
- **Walidacja:** Rygorystyczne sprawdzanie poprawności danych wejściowych (np. format numeru telefonu, wymagane pola).

### 2. Konfiguracja Systemu (Nowość w v2.0)
- **Dynamiczne typy sprzętu:** Możliwość dodawania i usuwania obsługiwanych typów urządzeń bez ingerencji w kod źródłowy.
- **Edycja bazy wiedzy:** Zarządzanie listą typowych usterek dla każdego rodzaju sprzętu.
- **Zarządzanie kadrami:** Dodawanie i usuwanie serwisantów oraz definiowanie ich kwalifikacji.

### 3. Statystyki i Raporty
- **Wykresy:** Generowanie rocznych zestawień (słupkowych) prezentujących liczbę napraw, wydajność serwisantów i trendy.
- **Eksport:** Możliwość zapisu wygenerowanych wykresów do plików PNG.
- **Historia:** Przeglądanie i filtrowanie historii wszystkich napraw (aktywnych i zakończonych).

## Architektura i Technologia

Projekt został napisany z naciskiem na czystość kodu i dobre praktyki:

- **Język:** C# (.NET)
- **UI:** Windows Forms (GDI+ do rysowania wykresów)
- **Wzorce:**
  - **MVP (Model-View-Presenter):** Separacja logiki (`ZarzadzanieSerwisem`, `WykresPresenter`) od widoku (Formularze).
  - **Factory:** Dynamiczne tworzenie obiektów sprzętu na podstawie konfiguracji.
  - **Event-Driven Architecture:** Komunikacja między logiką a UI odbywa się wyłącznie poprzez zdarzenia (`event`).
- **Dane:** Serializacja do formatu JSON (`baza.json`).

## Struktura Plików

- `ZarzadzanieSerwisem.cs` - Główny kontroler logiki biznesowej i walidacji.
- `KonfiguracjaSystemu.cs` - Moduł zarządzający dynamicznymi typami i ustawieniami (realizacja OCP).
- `WykresRenderer.cs` - Silnik graficzny odpowiedzialny za rysowanie wykresów.
- `Form*.cs` - Warstwa prezentacji (tylko obsługa zdarzeń, brak logiki biznesowej).

## Wymagania

- System operacyjny Windows
- .NET 10
