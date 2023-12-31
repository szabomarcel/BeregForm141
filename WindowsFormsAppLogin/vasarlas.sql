-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 29. 09:13
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `vasarlas`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termek`
--

CREATE TABLE `termek` (
  `termek_id` int(10) UNSIGNED NOT NULL,
  `termek_nev` varchar(30) NOT NULL,
  `ar` int(11) NOT NULL,
  `db` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `termek`
--

INSERT INTO `termek` (`termek_id`, `termek_nev`, `ar`, `db`) VALUES
(1, 'tv', 99999, 6),
(2, 'radio', 29999, 7);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vasarlas`
--

CREATE TABLE `vasarlas` (
  `vasarlo_id` int(10) UNSIGNED NOT NULL,
  `termek_id` int(10) UNSIGNED NOT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp(),
  `vasaroltdb` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vasarlo`
--

CREATE TABLE `vasarlo` (
  `vasarlo_id` int(10) UNSIGNED NOT NULL,
  `nev` varchar(20) NOT NULL,
  `jelszo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `vasarlo`
--

INSERT INTO `vasarlo` (`vasarlo_id`, `nev`, `jelszo`) VALUES
(1, 'Lajos', '1234');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `termek`
--
ALTER TABLE `termek`
  ADD PRIMARY KEY (`termek_id`);

--
-- A tábla indexei `vasarlas`
--
ALTER TABLE `vasarlas`
  ADD KEY `fk_vasarlo_vasarlas` (`vasarlo_id`),
  ADD KEY `fk_termek_vasarlas` (`termek_id`);

--
-- A tábla indexei `vasarlo`
--
ALTER TABLE `vasarlo`
  ADD PRIMARY KEY (`vasarlo_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `termek`
--
ALTER TABLE `termek`
  MODIFY `termek_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `vasarlo`
--
ALTER TABLE `vasarlo`
  MODIFY `vasarlo_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vasarlas`
--
ALTER TABLE `vasarlas`
  ADD CONSTRAINT `fk_termek_vasarlas` FOREIGN KEY (`termek_id`) REFERENCES `termek` (`termek_id`),
  ADD CONSTRAINT `fk_vasarlo_vasarlas` FOREIGN KEY (`vasarlo_id`) REFERENCES `vasarlo` (`vasarlo_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
