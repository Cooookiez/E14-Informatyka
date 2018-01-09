-- phpMyAdmin SQL Dump
-- version 4.7.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 04 Gru 2017, 21:43
-- Wersja serwera: 10.1.28-MariaDB
-- Wersja PHP: 7.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `d14_kukiz_krzysztof`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `fml_odpowiedzi`
--

CREATE TABLE `fml_odpowiedzi` (
  `odp_id` int(11) NOT NULL,
  `pyt_id` int(11) NOT NULL,
  `odp_tresc` text CHARACTER SET utf8 COLLATE utf8_polish_ci NOT NULL,
  `odp_pkt` int(11) NOT NULL,
  `odp_nth` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Zrzut danych tabeli `fml_odpowiedzi`
--

INSERT INTO `fml_odpowiedzi` (`odp_id`, `pyt_id`, `odp_tresc`, `odp_pkt`, `odp_nth`) VALUES
(1, 1, 'Czytamy', 30, 1),
(2, 1, 'Śpimy', 25, 2),
(3, 1, 'Rozmawiamy', 17, 3),
(4, 1, 'Patrzymy przez okno', 12, 4),
(5, 1, 'Rozmyślamy', 10, 5),
(6, 1, 'Słuchamy muzyki', 6, 6),
(7, 2, 'Muzyka', 30, 1),
(8, 2, 'Zakupy', 25, 2),
(9, 2, 'Kąpiel', 17, 3),
(10, 2, 'Spacer', 12, 4),
(11, 2, 'Spotkanie', 10, 5),
(12, 2, 'Pogoda', 6, 6),
(13, 3, 'Spodnie', 30, 1),
(14, 3, 'Sweter', 25, 2),
(15, 3, 'Sukienka', 17, 3),
(16, 3, 'Spódnica', 12, 4),
(17, 3, 'Skarpetki', 10, 5),
(18, 3, 'Szalik', 6, 6),
(19, 4, 'Dania', 30, 1),
(20, 4, 'Hiszpania', 25, 2),
(21, 4, 'Japonia', 17, 3),
(22, 4, 'Estonia', 12, 4),
(23, 4, 'Wielka brytania', 10, 5),
(24, 4, 'Rumunia', 6, 6),
(25, 5, 'Stolik', 30, 1),
(26, 5, 'Lampke', 25, 2),
(27, 5, 'Budzik', 17, 3),
(28, 5, 'Kapcie', 12, 4),
(29, 5, 'Telefon', 10, 5),
(30, 5, 'Okulary', 6, 6),
(31, 6, 'Zwycięzca', 30, 1),
(32, 6, 'Mistrz', 25, 2),
(33, 6, 'Medalista', 17, 3),
(34, 6, 'Laureat', 12, 4),
(35, 6, 'Lider', 10, 5),
(36, 6, 'Triumfator', 6, 6),
(37, 7, 'Przechowywanie w lodówce', 30, 1),
(38, 7, 'Mrożenie', 25, 2),
(39, 7, 'Suszenie', 17, 3),
(40, 7, 'Kiszenie', 12, 4),
(41, 7, 'Marynowanie', 10, 5),
(42, 7, 'Wędzenie', 6, 6),
(43, 8, 'Okna', 30, 1),
(44, 8, 'Drzwi', 25, 2),
(45, 8, 'Toaleta', 17, 3),
(46, 8, 'Fotele', 12, 4),
(47, 8, 'Stolik', 10, 5),
(48, 8, 'światło', 6, 6),
(49, 9, 'Jazda figurowa', 30, 1),
(50, 9, 'Tenis', 25, 2),
(51, 9, 'Kajakarsto', 17, 3),
(52, 9, 'Wioślarstow', 12, 4),
(53, 9, 'Badminton', 10, 5),
(54, 9, 'Rajdy', 6, 6),
(55, 10, 'Szkolny', 30, 1),
(56, 10, 'Akademicki', 25, 2),
(57, 10, 'Liturgiczny', 17, 3),
(58, 10, 'Żydowski', 12, 4),
(59, 10, 'Świetlny', 10, 5),
(60, 10, 'Chiński', 6, 6);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `fml_pytania`
--

CREATE TABLE `fml_pytania` (
  `pyt_id` int(11) NOT NULL,
  `pyt_tresc` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Zrzut danych tabeli `fml_pytania`
--

INSERT INTO `fml_pytania` (`pyt_id`, `pyt_tresc`) VALUES
(1, 'Jak zabijamy czas podczas jazdy pociągiem?'),
(2, 'Co może poprawić nasz nastrój?'),
(3, 'Część garderoby na literę \"S\"?'),
(4, 'Państwo , którego nazwa kończy się na \"nia\"?'),
(5, 'Jakie rzeczy mamy przy łóżku'),
(6, 'Jak określimy osobę, która zdobyła pierwsze miejsce?'),
(7, 'Podaj sposób na przedłużenie trwałości żywności?'),
(8, 'Co jest w pociągu i w domu?'),
(9, 'Dyscyplina sportowa w której zawodnicy występują w parach?'),
(10, 'Jaki rok nie zaczyna się od pierwszego stycznia?');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `fml_odpowiedzi`
--
ALTER TABLE `fml_odpowiedzi`
  ADD PRIMARY KEY (`odp_id`),
  ADD KEY `pyt_id` (`pyt_id`);

--
-- Indexes for table `fml_pytania`
--
ALTER TABLE `fml_pytania`
  ADD PRIMARY KEY (`pyt_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `fml_odpowiedzi`
--
ALTER TABLE `fml_odpowiedzi`
  MODIFY `odp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT dla tabeli `fml_pytania`
--
ALTER TABLE `fml_pytania`
  MODIFY `pyt_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
