Podsumowanie:
1. Zrealizowano wszystkie wymagane funkcjonalności
   a. Pobieranie aktualnych średnich kursów walut ze strony NBP.
   b.Pobieranie archiwalnych średnich kursów walut z wybranego przez użytkownika roku i miesiąca.
   c. Wyświetlanie pobranych kursów walut w interfejsie użytkownika.
2. Zrealizowane dodatkowe wymagania
   a. Obsługa błędów.
   b. Czytelny i intuicyjny interfejs użytkownika. (W mojej opinii)
3. Wprowadzone dodatkowe usprawnienia
   a. Wprowadzenie podstawowych logów, w celu prezentacji znajomości tych mechanizmów
   b. Wprowadzenie Dependency Injection
   c. Wprowadzenie dedykowanych Exception w celu rozróżnienia obsługiwanych (oczekiwanych) błędów oraz tych nieobsługiwanych.
   d. Struktura kodu pozwala na proste wprowadzanie kolejnych sposobów pobierania kursów walut (np. Średnia roczna, średnia z wybranych dat) - odbywa się to poprzez umiejętne wykorzystanie interfejsów
   e. Walidacja wejść (tutaj tylko roku)
5. Możliwości poprawy/rozwoju
   a. Dodanie Unit Testów (umiejętności ich tworzenia zostały pokazane w drugim projekcie)
   b. Dokładniejszy refactoring
   c. Przeanalizowanie potencjalnych zysków z wprowadzenia dedytkowanej klasy do obsługi zapytań API
   d. Lepsza obsługa błędów API (analiza dokumentacji API i odpowiednie obsługiwanie błędów/informowanie użytkowników)
