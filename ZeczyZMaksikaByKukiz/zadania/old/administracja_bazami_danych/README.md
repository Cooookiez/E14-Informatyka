# [strona][1] o zaządzaniu bazami danych

## Ma zawierać administrrowanie z
- konsoli
- phpMyAdmin
- php(kod)

## jak mogże wyglądać część dancyh
-[x] bazy
	- łączeni sięz bazą z
		- konsoli
		- strony
	- Podgląd baz danych
	- Podłączenie się do bazy
-[x] tablel
	- Podgląd tabel
	- Tworzenie tabeli
	- zmiana nazwy tabeli
	- Dodawanie rekordów to tabeli
	- Zmiany na recordzie (change/modfiy)
	- usuwanie recordu
-[x] te żeczy w kodzie php
-[x] funkcje
-[ ] zapytania

### tablea alteró
| -------------------------------- | ------------------ | ------------------------------------------- |
| Dodawanie po ostatnim            |                    | ADD e_mail varchar(30)                      |
| Dodawanie po czymś/jako pierwsze |                    | ADD e_mail varchar(30) FIRST/AFTER nazwisko |
| Zmiana nazwy i typu              | alter table TABLEA | CHANGE e_mail mail varchar(40)              |
| Zmiana TYLKO typu                |                    | MODIFY e_mail varchar(40)                   |
| Zmiana Tylko nazwy               |                    | RENAME e_mail mail                          |
| Usunięcie                        |                    | DROP COLUMN mail                            |





[1]:http://37.8.214.76/~d14.kukiz.krzysztof/zad/administracja_bazami_danych/