## Ogulne
### Logowanie
```sql
user@host: mysql -u d14_5cc698 -p
Enter password: zaq1@WSX
```

### Działąją tu również zapytania
```sql
SELECT * FROM test;

Wynik:
+-------+-----------+-------------+--------+-------------+------------+
| ts_id | ts_imie   | ts_operator | ts_ile | ts_ip       | ts_data    |
+-------+-----------+-------------+--------+-------------+------------+
|     1 | Krzyzstof |           0 |      5 | 127.0.0.1   | 2016-10-03 |
+-------+-----------+-------------+--------+-------------+------------+
```

## Bazy danych
### Pokaż dostępne bazy danych
```sql
show databases;

Wynik:
+---------------------+
| Database            |
+---------------------+
| Baza_1              |
| Baza_2              |
+---------------------+
```

### Wybierz baze danych
``` sql
use Baza_1;
```
zostanie wyświetlona informaca o zmianie bazy danych (Można korzystać również jak już się jest w jakiejś bazie)

## Tabele
### Pokaż dostępne tabele (z wybranej bazy danych)
```sql
show tables;

Wynik:
+-----------------------+
| Tables_in_Baza_1      |
+-----------------------+
| Tabela_1              |
| Tabela_2              |
+-----------------------+
```

### Tworzenie tabeli
```sql
create table nazwa_tabeli(
    -> id int auto_increment,
    -> imie varchar(20),
    -> nazwisko varczhar(30),
    -> PRIMARY KEY(id)
    -> );
```

### Pokazuje strukture danej tabeli
```sql
describe nazwa_tabeli;

Wynik:
+----------+-------------+------+-----+---------+----------------+
| Field    | Type        | Null | Key | Default | Extra          |
+----------+-------------+------+-----+---------+----------------+
| id       | int(11)     | NO   | PRI | NULL    | auto_increment |
| imie     | varchar(20) | YES  |     | NULL    |                |
| nazwisko | varchar(30) | YES  |     | NULL    |                |
+----------+-------------+------+-----+---------+----------------+
```

### Modifikacje na tabelach
```sql
Dodanie rekordu na koniec
alter table nazwa_tabeli ADD telefon varchar(13);

Dodanie rekordu jako pierwsze / po czymś:
alter table nazwa_tabeli ADD e_mail varchar(40) FIRST/AFTER nazwisko;

Zmiana na rekordzie (nazwa i typ)
alter table nazwa_tabeli CHANGE e_mail Email varchar(60);

Zmiana na rekordzie (TYLKO typ)
alter table nazwa_tabeli MODIFY imie varchar(40);

Usuwanie rekordu
alter table nazwa_tabeli DROP COLUMN telefon;

Zmiana nazwy tabeli (Nie rekordu)
alter table nazwa_tabeli RENAME nazwaTabeli;


```