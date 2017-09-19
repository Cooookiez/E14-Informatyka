--	1. (z98) Ile osób chodzi to każdej klasy?
		SELECT DISTINCT(Klasa), COUNT(Imie) as 'Ile osób'
		FROM `z98_uczniowie`
		GROUP BY Klasa

--	2. (z98) Z Ktureko przedmiotu jest najwiecej piątek?
		SELECT DISTINCT(Nazwa_przedmiotu) AS Przedmiot, COUNT(Ocena) AS 'Ilość piątek'
		FROM `z98_oceny`
		NATURAL JOIN z98_przedmioty
		WHERE Ocena = 5
		GROUP BY Nazwa_przedmiotu
		ORDER BY COUNT(Ocena) DESC
		LIMIT 0,1

--	3. (z101) Ile jest kobiet?
		SELECT COUNT(*) AS "Ile Kobiet" 
		FROM `z101_osoby`
		WHERE `Id_uzytkownika;Nazwisko;Imie;Plec` LIKE '%k'

--	4. (z101) Ile jest osub z imieniem lub nazwiskiem, które zawieraja w sobie 'la'?
		SELECT COUNT(*) AS Ile
		FROM `z101_osoby`
		WHERE `Id_uzytkownika;Nazwisko;Imie;Plec` LIKE '%;%la%;_'

--	5. (z102) Kto Zrobił najwięcej zdięć?
		SELECT DISTINCT(Imie), COUNT(ID_zdjecia) AS 'Ilość zdięć'
		FROM `z102_zdjecia`
		NATURAL JOIN z102_uzytkownicy
		GROUP BY Imie
		ORDER BY COUNT(ID_zdjecia) DESC
		LIMIT 0,1

--	6. (z102) Kto zrobił Największe (pod względem ilości px) zdięcie
		SELECT Imie
		FROM `z102_zdjecia`
		NATURAL JOIN z102_uzytkownicy
		ORDER BY Szerokosc * Wysokosc DESC
		LIMIT 0,1

--	7. (z102) ktura płeć zrobiła więcej zdięć
		SELECT DISTINCT(Plec), COUNT(ID_zdjecia) AS 'Ilość zdięć'
		FROM `z102_zdjecia`
		NATURAL JOIN z102_uzytkownicy
		GROUP BY Plec
		ORDER BY COUNT(ID_zdjecia) DESC
		LIMIT 0,1

--	8. (z103) Kto ma Urodziny 30 maja
		SELECT Nazwisko, Imie
		FROM `z103_pacjenci`
		WHERE PESEL LIKE '__0530%'

--	9. (z112) W ilu krajach każda firma ma swoje oddziały.
		SELECT  DISTINCT(nazwa_firmy) AS Firma, COUNT(Kraj) AS Kraje
		FROM `z112_producenci`
		NATURAL JOIN z112_kraje
		GROUP BY nazwa_firmy
		ORDER BY COUNT(Kraj) DESC, nazwa_firmy ASC

--	10. (z105) Ktury kolor jest najczęstszy
		SELECT DISTINCT(Kolor_kwiatow) AS kolor, COUNT(*) as Ile
		FROM `z105_rosliny`
		GROUP BY Kolor_kwiatow
		ORDER BY Ile DESC
		LIMIT 1
	
--	11. (z102) Ile użytkowników to mężczyźni, il kobiety
		SELECT DISTINCT(plec), COUNT(*) AS Ile
		FROM `z102_uzytkownicy`
		GROUP BY plec
		ORDER BY Ile DESC

--	12. (z106) Gatunki  u kturych zaopserwowano że pływają
		SELECT DISTINCT(nazwa_lacinska), nazwa_zwyczajowa
		FROM `z106_obserwacje`
		NATURAL JOIN z106_gatunki
		WHERE zachowanie = 'plywa'
		ORDER BY nazwa_lacinska ASC

--	13. (z107) O kturej godzinie jest najwięcej wylotów
		SELECT DISTINCT(godzina), COUNT(*) AS Ile
		FROM `z107_loty`
		GROUP BY godzina
		ORDER BY Ile DESC
		LIMIT 1

--	14. (Z107) Z kturego miasta jest najwięcej pasaserów
		SELECT DISTINCT(miejscowosc), COUNT(*) AS Ile
		FROM `z107_pasazerowie`
		GROUP BY miejscowosc
		ORDER BY Ile DESC
		LIMIT 1

--	15. (z109) Ile klijentów to kobiety
		SELECT COUNT(*) AS 'Ile kobiet'
		FROM `z109_klienci`
		WHERE Imie LIKE '%a'

--	16. (z99) Ile ankiet zostało napisanych przez kobiety, a ile męzczyny
		SELECT DISTINCT(Plec), COUNT(*) AS Ile
		FROM `z99_ankiety`
		GROUP BY Plec
		ORDER BY Ile DESC

--	17. (z013) Kture badanie jest najdroszsze
		SELECT Nazwa_badania
		FROM `z103_rtg`
		ORDER BY Cena_Badania DESC
		LIMIT 1

--	18. (z103) Ile pacjętów w każdym wojewuctiwe
		SELECT DISTINCT(NFZ), COUNT(*) AS Ile
		FROM `z103_pacjenci`
		GROUP BY NFZ
		ORDER BY Ile DESC, NFZ ASC

--	19. (z106) Ile w jest opserwowanych gatunków w każdej lokalizacji
		SELECT DISTINCT(lokalizacja), COUNT(DISTINCT(nazwa_lacinska)) AS Ile
		FROM `z106_obserwacje`
		NATURAL JOIN z106_gatunki
		NATURAL JOIN z106_lokalizacje
		GROUP BY lokalizacja
		ORDER BY Ile DESC, lokalizacja ASC

--	20. (z112) jaki rodzaj jest najczęstszy wśrud produktów
		SELECT DISTINCT(rodzaj), COUNT(*) AS Ile
		FROM `z112_towary`
		GROUP BY rodzaj
		ORDER BY Ile DESC
		LIMIT 1