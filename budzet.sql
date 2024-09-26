-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 26, 2024 at 01:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `budzet`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `name`) VALUES
(1, 'jedzenie'),
(3, 'nauka'),
(2, 'rachunki'),
(4, 'sport'),
(5, 'subskrypcje'),
(6, 'technika');

-- --------------------------------------------------------

--
-- Table structure for table `earnings`
--

CREATE TABLE `earnings` (
  `id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `comm` varchar(150) DEFAULT NULL,
  `data_trans` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `earnings`
--

INSERT INTO `earnings` (`id`, `amount`, `comm`, `data_trans`) VALUES
(1, 500, 'Wynagrodzenie za wrzesień', '2024-09-29'),
(2, 600, 'Premia za wydajność', '2024-09-30'),
(3, 700, 'Wynagrodzenie za październik', '2024-10-01'),
(4, 800, 'Nagroda za wyjątkowe osiągnięcia', '2024-10-02'),
(5, 900, 'Bonus za sprzedaż', '2024-10-03'),
(6, 1000, 'Wynagrodzenie za nadgodziny', '2024-10-04'),
(7, 1100, 'Premia świąteczna', '2024-10-05'),
(8, 1200, 'Prezent od szefa', '2024-10-06'),
(9, 1300, 'Wynagrodzenie listopad', '2024-10-07'),
(10, 1400, 'Bonus za projekt X', '2024-10-08'),
(11, 1500, 'Prezent urodzinowy', '2024-10-09'),
(12, 1600, 'Wynagrodzenie za grudzień', '2024-10-10'),
(13, 1700, 'Premia noworoczna', '2024-10-11'),
(14, 1800, 'Dodatek na święta', '2024-10-12'),
(15, 1900, 'Prezent firmowy', '2024-10-13'),
(16, 2000, 'Wynagrodzenie za styczeń', '2024-10-14'),
(17, 2100, 'Nagroda za pomysły', '2024-10-15'),
(18, 2200, 'Prezent jubileuszowy', '2024-10-16'),
(19, 2300, 'Wynagrodzenie za luty', '2024-10-17'),
(20, 2400, 'Nagroda za udział w konkursie', '2024-10-18');

-- --------------------------------------------------------

--
-- Table structure for table `outgo`
--

CREATE TABLE `outgo` (
  `id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `category_id` int(11) DEFAULT NULL,
  `comm` varchar(150) DEFAULT NULL,
  `data_trans` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `outgo`
--

INSERT INTO `outgo` (`id`, `amount`, `category_id`, `comm`, `data_trans`) VALUES
(1, 100, NULL, 'Zakup materiałów biurowych', '2024-09-26'),
(2, 200, 3, 'Zakup sprzętu komputerowego', '2024-09-27'),
(3, 150, 1, 'Obiad z klientem', '2024-09-28'),
(4, 50, 4, 'Opłaty za parkowanie', '2024-09-29'),
(5, 300, 2, 'Wyjazd służbowy', '2024-09-30'),
(6, 120, 2, 'Zakup artykułów spożywczych', '2024-10-01'),
(7, 400, 6, 'Kampania marketingowa', '2024-10-02'),
(8, 250, 4, 'Ubezpieczenie', '2024-10-03'),
(9, 500, NULL, 'Zakup oprogramowania', '2024-10-04'),
(10, 600, 1, 'Szkolenie pracowników', '2024-10-05'),
(11, 200, 3, 'Naprawa samochodu', '2024-10-06'),
(12, 80, 5, 'Paliwo', '2024-10-07'),
(13, 300, 3, 'Zakup mebli', '2024-10-08'),
(14, 700, NULL, 'Opłata za usługi konsultingowe', '2024-10-09'),
(15, 50, 2, 'Opłata za hosting strony internetowej', '2024-10-10'),
(16, 150, 1, 'Zakup prezentów dla pracowników', '2024-10-11'),
(17, 350, 2, 'Zakup urządzeń kuchennych', '2024-10-12'),
(18, 500, 5, 'Zakup książek branżowych', '2024-10-13'),
(19, 90, 6, 'Koszty wysyłki', '2024-10-14'),
(20, 600, 1, 'Opłata za wynajem biura', '2024-10-15');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `earnings`
--
ALTER TABLE `earnings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `outgo`
--
ALTER TABLE `outgo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `category_id` (`category_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `earnings`
--
ALTER TABLE `earnings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `outgo`
--
ALTER TABLE `outgo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `outgo`
--
ALTER TABLE `outgo`
  ADD CONSTRAINT `outgo_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
