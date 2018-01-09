-- phpMyAdmin SQL Dump
-- version 4.7.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 09 Sty 2018, 17:29
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
-- Struktura tabeli dla tabeli `filrezyser`
--

CREATE TABLE `filrezyser` (
  `rezID` int(11) NOT NULL,
  `rezImie` varchar(20) COLLATE utf8_polish_ci DEFAULT NULL,
  `rezNazwisko` varchar(30) COLLATE utf8_polish_ci DEFAULT NULL,
  `rezDataUrodzenia` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `filrezyser`
--

INSERT INTO `filrezyser` (`rezID`, `rezImie`, `rezNazwisko`, `rezDataUrodzenia`) VALUES
(5, 'Cezary', 'Pazura', '1962-06-13'),
(6, 'Stanley', 'Kubrick', '1928-07-26'),
(7, 'Frank', 'Darabont', '1959-01-28'),
(8, 'James', 'Cameron', '1954-08-16'),
(9, 'Juliusz', 'Machulski', '1955-03-10'),
(10, 'Marc', 'Webb', '1974-08-11'),
(11, 'Gore', 'Verbinski', '1964-03-16'),
(12, 'Andy', 'Wachowski', '1967-12-29'),
(13, 'Alex', 'Proyas', '1963-09-23'),
(14, '13', ' Edytuj', '0000-00-00'),
(15, 'Olivier', 'Nakache', '1973-04-14'),
(16, 'Robert', 'Zemeckis', '1952-05-14'),
(17, 'Quentin', 'Dupieux', '1974-04-14'),
(18, 'Sylvester', 'Stallone', '1946-07-06'),
(19, 'Ted', 'Kotcheff', '1931-04-07'),
(20, 'Alfonso', 'Cuaron', '1961-11-28'),
(21, 'Francis', 'Lawrence', '1971-03-26'),
(22, 'Justin', 'Lin', '1973-05-13'),
(23, 'Antoine', 'Fuqua', '1966-01-19'),
(24, 'James', 'Wan', '1977-02-27'),
(25, 'Patrick', 'Hughes', '1969-05-22'),
(26, 'Ang', 'Lee', '1954-02-12'),
(27, 'Phyllidy', 'Lloyd', '1957-03-13'),
(28, 'Raja', 'Gosnell', '1958-05-01'),
(29, 'Jan', 'Komasa', '1981-04-30'),
(30, 'R.J.', 'Cutler', '1961-11-10'),
(31, 'Bryan', 'Singer', '1965-09-17'),
(32, 'David', ' Zucker', '1947-10-16'),
(33, 'Richard', 'Schwartzberg', '1930-04-24'),
(34, 'John', 'McTiernan', '1951-01-08'),
(35, 'Mark', 'Mylod', '1979-11-03'),
(36, 'Stephen', 'Chiodo', '1957-02-12'),
(37, 'Leszek', 'Dawid', '1971-03-00'),
(38, 'Roman', 'Polański', '1933-08-18'),
(39, 'Andrew', 'Wachowski', '1967-12-29'),
(40, '13', '23', '1111-11-11'),
(41, '1', '1', '0000-00-00');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `filrezyser`
--
ALTER TABLE `filrezyser`
  ADD PRIMARY KEY (`rezID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `filrezyser`
--
ALTER TABLE `filrezyser`
  MODIFY `rezID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
