# SerwisNapraw

System obsługi zleceń serwisowych napisany w C# (Windows Forms). Aplikacja służy do rejestrowania przyjęć sprzętu elektronicznego i automatycznego zarządzania pracą serwisu.

## Funkcjonalności

- **Rejestracja zleceń:** Formularz przyjmujący zgłoszenia dla komputerów, telefonów, monitorów i drukarek.
- **Obsługa klientów:** Rozróżnienie formularza dla osób prywatnych i firm (obsługa NIP).
- **Zarządzanie usterkami:**
  - Automatyczne wczytywanie listy typowych usterek zależnie od wybranego urządzenia.
  - Możliwość ręcznego wpisywania i dodawania niestandardowych czynności do listy.
- **Inteligentny przydział:** Algorytm automatycznie przypisuje zlecenie do serwisanta, który:
  1. Posiada kwalifikacje do naprawy danego typu sprzętu.
  2. Ma obecnie najmniej przypisanych aktywnych zleceń.
- **Walidacja danych:** Blokada dodania zlecenia bez wymaganych danych kontaktowych lub opisu problemu.

## Struktura kodu

Projekt oparty jest na obiektach:
- **FormDodaj:** Główny interfejs wprowadzania danych.
- **Sprzęt:** Klasy dziedziczące (Komputer, Telefon, Monitor, Drukarka) definiujące specyficzne listy usterek.
- **Logika biznesowa:** Automatyczne parowanie zgłoszeń z dostępnymi zasobami ludzkimi (serwisantami).

## Wymagania

- Visual Studio (Windows Forms App)
- .NET Framework / .NET
