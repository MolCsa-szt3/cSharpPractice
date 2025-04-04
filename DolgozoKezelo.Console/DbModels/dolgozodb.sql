-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Ápr 04. 12:34
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
-- Adatbázis: `dolgozodb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `worker`
--

CREATE TABLE `worker` (
  `name` varchar(14) DEFAULT NULL,
  `email` varchar(26) DEFAULT NULL,
  `salary` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `worker`
--

INSERT INTO `worker` (`name`, `email`, `salary`) VALUES
('Kovács János', 'kovács.jános@munkahely.com', 974100),
('Nagy Péter', 'nagy.péter@ceg.hu', 699100),
('Szabó László', 'szabó.lászló@ceg.hu', 488500),
('Tóth István', 'tóth.istván@vallalat.hu', 299100),
('Varga Zoltán', 'varga.zoltán@ceg.hu', 102200),
('Horváth Ferenc', 'horváth.ferenc@vallalat.hu', 304500),
('Kiss Attila', 'kiss.attila@vallalat.hu', 693000),
('Molnár Gábor', 'molnár.gábor@minta.org', 863700),
('Farkas Balázs', 'farkas.balázs@minta.org', 719600),
('Balogh Tamás', 'balogh.tamás@ceg.hu', 489500),
('Papp Zsuzsa', 'papp.zsuzsa@vallalat.hu', 227300);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
