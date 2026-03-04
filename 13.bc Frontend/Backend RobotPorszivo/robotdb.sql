-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Feb 04. 11:09
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `robotdb`
--
CREATE DATABASE IF NOT EXISTS `robotdb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `robotdb`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ertekelesek`
--

CREATE TABLE `ertekelesek` (
  `id` int(11) NOT NULL,
  `robot_id` int(11) DEFAULT NULL,
  `felhasznalonev` varchar(50) DEFAULT NULL,
  `csillagszam` int(11) DEFAULT NULL CHECK (`csillagszam` between 1 and 5),
  `szoveg` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `ertekelesek`
--

INSERT INTO `ertekelesek` (`id`, `robot_id`, `felhasznalonev`, `csillagszam`, `szoveg`) VALUES
(1, 1, 'PorszivoGuru', 5, 'Kiválóan felszívja a kutyafürtöket is, nagyon elégedett vagyok.'),
(2, 2, 'LakatosBela', 3, 'Kicsit hangos, de a dolgát elvégzi. A szoftvere néha megzavarodik.'),
(3, 3, 'TisztaHaz88', 5, 'A legjobb vétel volt! A felmosó funkció meglepően hatékony.'),
(4, 1, 'RobotFan', 4, 'Szépen dolgozik, de a küszöbökkel néha meggyűlik a baja.'),
(5, 4, 'MorgosGabor', 2, 'Folyton elakad a szőnyeg rojtjaiban. Többet vártam ennyiért.'),
(6, 5, 'SmartHomeAlice', 5, 'Imádom, hogy az alkalmazásból bárhonnan elindíthatom. Nagyon okos.'),
(7, 2, 'TesztElo', 4, 'Ár-érték arányban verhetetlen, de a portartálya lehetne nagyobb.'),
(8, 3, 'Csaladanya2', 5, 'Megváltás a két kisgyerek mellett. Naponta kétszer is körbemegy.'),
(9, 1, 'TechJoe', 4, 'A lézeres navigáció pontos, de a sötétben néha bizonytalan.'),
(10, 4, 'Minimalista', 3, 'Egyszerű, mint a faék. Teszi a dolgát, de semmi extra.'),
(11, 5, 'LuxusLaci', 5, 'Prémium minőség, minden fillért megért a dokkoló állomás.'),
(12, 2, 'Pityu77', 1, 'Két hét után elromlott az oldalkeféje. Csalódás.'),
(13, 3, 'ZöldÖvezet', 4, 'Halk és hatékony, a macskám is szereti nézni munka közben.'),
(14, 4, 'RendszeresReni', 5, 'Nagyon alapos, még a sarkokból is kiszedi a port.'),
(15, 5, 'IrodaiLany', 4, 'Az irodában használjuk, remekül bírja a napi strapát.'),
(16, 1, 'HobbySéf', 3, 'A konyhai morzsákkal elboldogul, de a szőnyegen gyenge.'),
(17, 2, 'BakosAndras', 2, 'Gyakran elveszíti a Wi-Fi kapcsolatot, ami elég bosszantó.'),
(18, 3, 'KovacsCsalad', 5, 'Szuper gép, azóta sokkal tisztább a levegő is a lakásban.'),
(19, 4, 'GyorsGuszti', 4, 'Gyorsan feltérképezte a lakást, a takarítási ideje is rendben van.'),
(20, 5, 'Noemi_92', 5, 'Gyönyörű design és profi tisztítás. Csak ajánlani tudom!');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `robotporszivo`
--

CREATE TABLE `robotporszivo` (
  `id` int(11) NOT NULL,
  `marka` varchar(100) NOT NULL,
  `tipus` varchar(100) NOT NULL,
  `teljesitmeny` int(11) NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `robotporszivo`
--

INSERT INTO `robotporszivo` (`id`, `marka`, `tipus`, `teljesitmeny`, `ar`) VALUES
(1, 'Xiaomi', 'Mi Robot S10', 4000, 120000),
(2, 'iRobot', 'Roomba i7', 3500, 180000),
(3, 'Roborock', 'S8 Pro', 6000, 250000),
(4, 'Roborock', 'Q10', 5000, 139900),
(5, 'Dreame', 'X50', 22000, 389900);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ertekelesek`
--
ALTER TABLE `ertekelesek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_ertekeles_robotproszivo` (`robot_id`);

--
-- A tábla indexei `robotporszivo`
--
ALTER TABLE `robotporszivo`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ertekelesek`
--
ALTER TABLE `ertekelesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT a táblához `robotporszivo`
--
ALTER TABLE `robotporszivo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ertekelesek`
--
ALTER TABLE `ertekelesek`
  ADD CONSTRAINT `FK_ertekeles_robotproszivo` FOREIGN KEY (`robot_id`) REFERENCES `robotporszivo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
