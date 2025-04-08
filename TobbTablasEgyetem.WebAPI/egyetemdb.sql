-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Ápr 08. 08:20
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
-- Adatbázis: `egyetemdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `courses`
--

CREATE TABLE `courses` (
  `ID` int(2) DEFAULT NULL,
  `Name` varchar(25) DEFAULT NULL,
  `Credits` int(1) DEFAULT NULL,
  `DepartmentID` int(1) DEFAULT NULL,
  `TeacherID` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `courses`
--

INSERT INTO `courses` (`ID`, `Name`, `Credits`, `DepartmentID`, `TeacherID`) VALUES
(1, 'Programozás alapjai', 6, 1, 1),
(2, 'Adatbázis-kezelés', 5, 2, 2),
(3, 'Webfejlesztés', 4, 3, 3),
(4, 'Gépitanulás', 6, 4, 4),
(5, 'Mesterséges intelligencia', 5, 5, 5),
(6, 'Operációs rendszerek', 6, 1, 6),
(7, 'Szoftverfejlesztés', 5, 2, 7),
(8, 'Hálózatbiztonság', 4, 3, 8),
(9, 'Big Data', 6, 4, 9),
(10, 'Cloud Computing', 5, 5, 10),
(11, 'Robotika', 6, 1, 11),
(12, 'Adatstruktúrák', 5, 2, 12),
(13, 'Algoritmusok', 4, 3, 13),
(14, 'IoT technológiák', 6, 4, 14),
(15, 'IT projektmenedzsment', 5, 5, 15),
(16, 'Cybersecurity', 6, 1, 16),
(17, 'Blockchain technológia', 5, 2, 17),
(18, 'Szoftvertervezés', 4, 3, 18),
(19, 'Mobilfejlesztés', 6, 4, 19),
(20, 'Game Development', 5, 5, 20);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `department`
--

CREATE TABLE `department` (
  `ID` int(2) DEFAULT NULL,
  `Name` varchar(29) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `department`
--

INSERT INTO `department` (`ID`, `Name`) VALUES
(1, 'Informatikai Tanszék'),
(2, 'Gazdaságtudományi Tanszék'),
(3, 'Villamosmérnöki Tanszék'),
(4, 'Gépészmérnöki Tanszék'),
(5, 'Műszaki Menedzsment Tanszék'),
(6, 'Környezetmérnöki Tanszék'),
(7, 'Matematika és Fizika Tanszék'),
(8, 'Közgazdaságtan Tanszék'),
(9, 'Jogtudományi Tanszék'),
(10, 'Média és Kommunikáció Tanszék'),
(11, 'Pszichológia Tanszék'),
(12, 'Szociológia Tanszék'),
(13, 'Orvostudományi Tanszék'),
(14, 'Biológia Tanszék'),
(15, 'Kémia Tanszék'),
(16, 'Filozófia Tanszék'),
(17, 'Művészeti Tanszék'),
(18, 'Nyelvészeti Tanszék'),
(19, 'Sporttudományi Tanszék'),
(20, 'Zenetudományi Tanszék');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `student`
--

CREATE TABLE `student` (
  `ID` int(2) DEFAULT NULL,
  `Name` varchar(16) DEFAULT NULL,
  `Age` int(2) DEFAULT NULL,
  `Email` varchar(28) DEFAULT NULL,
  `DepartmentID` int(1) DEFAULT NULL,
  `Enrolled` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `student`
--

INSERT INTO `student` (`ID`, `Name`, `Age`, `Email`, `DepartmentID`, `Enrolled`) VALUES
(1, 'Kovács Péter', 21, 'peter.kovacs@example.com', 1, 1),
(2, 'Nagy Anna', 22, 'anna.nagy@example.com', 2, 1),
(3, 'Tóth Gábor', 20, 'gabor.toth@example.com', 3, 0),
(4, 'Hegedűs László', 23, 'laszlo.hegedus@example.com', 4, 1),
(5, 'Szabó Katalin', 22, 'katalin.szabo@example.com', 5, 1),
(6, 'Oláh Ferenc', 24, 'ferenc.olah@example.com', 1, 1),
(7, 'Kiss Márta', 21, 'marta.kiss@example.com', 2, 1),
(8, 'Molnár Dániel', 22, 'daniel.molnar@example.com', 3, 1),
(9, 'Lakatos István', 20, 'istvan.lakatos@example.com', 4, 1),
(10, 'Farkas Zsuzsanna', 23, 'zsuzsanna.farkas@example.com', 5, 0),
(11, 'Németh Gergely', 21, 'gergely.nemeth@example.com', 1, 1),
(12, 'Balogh Edit', 22, 'edit.balogh@example.com', 2, 1),
(13, 'Varga Sándor', 20, 'sandor.varga@example.com', 3, 1),
(14, 'Veres Andrea', 23, 'andrea.veres@example.com', 4, 1),
(15, 'Pintér Attila', 22, 'attila.pinter@example.com', 5, 0),
(16, 'Lukács Gábor', 24, 'gabor.lukacs@example.com', 1, 1),
(17, 'Horváth István', 21, 'istvan.horvath@example.com', 2, 1),
(18, 'Kovács Dóra', 22, 'dora.kovacs@example.com', 3, 1),
(19, 'Kiss Roland', 20, 'roland.kiss@example.com', 4, 1),
(20, 'Székely Tamás', 23, 'tamas.szekely@example.com', 5, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `teacher`
--

CREATE TABLE `teacher` (
  `ID` int(2) DEFAULT NULL,
  `Name` varchar(18) DEFAULT NULL,
  `Email` varchar(26) DEFAULT NULL,
  `DepartmentID` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `teacher`
--

INSERT INTO `teacher` (`ID`, `Name`, `Email`, `DepartmentID`) VALUES
(1, 'Dr. Kovács Béla', 'kovacs.bela@example.com', 1),
(2, 'Dr. Nagy Mária', 'nagy.maria@example.com', 2),
(3, 'Dr. Tóth Zoltán', 'toth.zoltan@example.com', 3),
(4, 'Dr. Szabó Gergely', 'szabo.gergely@example.com', 4),
(5, 'Dr. Hegedűs Júlia', 'hegedus.julia@example.com', 5),
(6, 'Dr. Oláh Zsolt', 'olah.zsolt@example.com', 1),
(7, 'Dr. Kiss Lajos', 'kiss.lajos@example.com', 2),
(8, 'Dr. Molnár Eszter', 'molnar.eszter@example.com', 3),
(9, 'Dr. Lakatos Róbert', 'lakatos.robert@example.com', 4),
(10, 'Dr. Farkas Éva', 'farkas.eva@example.com', 5),
(11, 'Dr. Németh István', 'nemeth.istvan@example.com', 1),
(12, 'Dr. Balogh Zsuzsa', 'balogh.zsuzsa@example.com', 2),
(13, 'Dr. Varga Károly', 'varga.karoly@example.com', 3),
(14, 'Dr. Veres Anna', 'veres.anna@example.com', 4),
(15, 'Dr. Pintér Gábor', 'pinter.gabor@example.com', 5),
(16, 'Dr. Lukács Tamás', 'lukacs.tamas@example.com', 1),
(17, 'Dr. Horváth Lilla', 'horvath.lilla@example.com', 2),
(18, 'Dr. Kovács Norbert', 'kovacs.norbert@example.com', 3),
(19, 'Dr. Kiss Erika', 'kiss.erika@example.com', 4),
(20, 'Dr. Székely Péter', 'szekely.peter@example.com', 5);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
