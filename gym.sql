-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 20, 2022 at 05:50 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gym`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `Client_id` int(11) NOT NULL,
  `Client_name` varchar(10) DEFAULT NULL,
  `Client_surname` varchar(10) DEFAULT NULL,
  `Client_password` varchar(20) NOT NULL,
  `Client_age` int(11) DEFAULT NULL,
  `Tariff_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`Client_id`, `Client_name`, `Client_surname`, `Client_password`, `Client_age`, `Tariff_id`) VALUES
(2, 'Aleksandrs', 'Caks', '123', 98, 2),
(3, 'Maxim', 'Klava', '123', 18, 2),
(4, 'Aleksandrs', 'Kirilovsky', '123', 45, 2),
(5, 'Jonny', 'Cage', '123', 33, 3),
(6, 'Den', 'Brown', '123', 55, 5),
(7, 'Britney', 'Spears', '123', 33, 3),
(8, 'Thamar', 'Smith', '123', 22, 3),
(9, 'Ahmed', 'Muhammad', '123', 44, 4),
(10, 'Nikolay', 'Baskov', '123', 88, 2),
(11, 'Petrov', 'Pavel', '123', 34, 5),
(12, 'Robert', 'Straus', '123', 87, 6),
(15, 'Bob', 'Marley', '123', 24, 4),
(16, 'Simona', 'Glusenok', '12345', 24, 5),
(17, 'admin', 'admin', 'admin', 30, 6),
(18, 'Anton', 'Banderos', 'qwert', 78, 42),
(19, 'Alexander', 'Smith', '123', 19, 683),
(20, 'Philipp', 'Kirkorov', '12345', 57, NULL),
(21, 'admin1', 'admin', '123', 56, NULL),
(22, 'Edgars', 'Ruda', '123', 45, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `coach`
--

CREATE TABLE `coach` (
  `Coach_id` int(11) NOT NULL,
  `Coach_name` varchar(10) DEFAULT NULL,
  `Coach_surname` varchar(10) DEFAULT NULL,
  `Coach_phone_number` int(8) DEFAULT NULL,
  `Client_id` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `coach`
--

INSERT INTO `coach` (`Coach_id`, `Coach_name`, `Coach_surname`, `Coach_phone_number`, `Client_id`) VALUES
(8, 'Raimond', 'Liepins', 27182834, 8),
(9, 'Bob', 'bobby', 4563235, 9),
(10, 'Valery', 'Stavinsky', 3445122, 3),
(11, 'Anny', 'Bujor', 20303003, 2),
(12, 'Bob', 'Anntell', 23444444, 4),
(13, 'Claus', 'Santa', 23412555, 5),
(14, 'Kaspars', 'Gravis', 27182834, 6),
(15, 'Anny', 'Bujor', 20303003, 7),
(16, 'Mikhail', 'Kizlo', 3445122, 10);

-- --------------------------------------------------------

--
-- Table structure for table `gym`
--

CREATE TABLE `gym` (
  `Gym_id` int(11) NOT NULL,
  `Gym_adress` varchar(20) DEFAULT NULL,
  `Coach_id` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gym`
--

INSERT INTO `gym` (`Gym_id`, `Gym_adress`, `Coach_id`) VALUES
(11, 'Ogre', 8),
(12, 'Riga', 10),
(13, 'Kengarags', 9),
(14, 'Imanta', 11),
(15, 'Salaspils', 14),
(16, 'Saulkalne', 13),
(17, 'Zilupe', 15),
(18, 'Moscow', 12),
(19, 'Liepaja', 16);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Tariff_id` int(11) DEFAULT NULL,
  `Payment_id` int(11) NOT NULL,
  `Payment_date` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Tariff_id`, `Payment_id`, `Payment_date`) VALUES
(5, 3, 11042022),
(4, 4, 20622),
(3, 22, 170322),
(3, 23, 190322),
(3, 24, 160322),
(2, 25, 160522),
(3, 26, 180122);

-- --------------------------------------------------------

--
-- Table structure for table `tariff`
--

CREATE TABLE `tariff` (
  `Tariff_id` int(11) NOT NULL,
  `Tariff_name` varchar(8) DEFAULT NULL,
  `Tariff_price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tariff`
--

INSERT INTO `tariff` (`Tariff_id`, `Tariff_name`, `Tariff_price`) VALUES
(2, 'Premium', 50),
(3, 'Simple', 15),
(4, 'Student', 9),
(5, 'Basic', 5),
(6, 'Premium', 50),
(33, 'Simple', 15),
(42, 'Basic', 9),
(54, 'Basic', 5),
(62, 'Premium', 50),
(68, 'Premium', 50),
(323, 'Simple', 15),
(683, 'Premium', 50),
(42233, 'Basic', 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`Client_id`),
  ADD KEY `Tariff_id` (`Tariff_id`);

--
-- Indexes for table `coach`
--
ALTER TABLE `coach`
  ADD PRIMARY KEY (`Coach_id`),
  ADD KEY `Client_id` (`Client_id`);

--
-- Indexes for table `gym`
--
ALTER TABLE `gym`
  ADD PRIMARY KEY (`Gym_id`),
  ADD KEY `Coach_id` (`Coach_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`Payment_id`),
  ADD KEY `Tariff_id` (`Tariff_id`);

--
-- Indexes for table `tariff`
--
ALTER TABLE `tariff`
  ADD PRIMARY KEY (`Tariff_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `Client_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `coach`
--
ALTER TABLE `coach`
  MODIFY `Coach_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `gym`
--
ALTER TABLE `gym`
  MODIFY `Gym_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `Payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tariff`
--
ALTER TABLE `tariff`
  MODIFY `Tariff_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42234;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`Tariff_id`) REFERENCES `tariff` (`Tariff_id`);

--
-- Constraints for table `coach`
--
ALTER TABLE `coach`
  ADD CONSTRAINT `coach_ibfk_1` FOREIGN KEY (`Client_id`) REFERENCES `client` (`Client_id`);

--
-- Constraints for table `gym`
--
ALTER TABLE `gym`
  ADD CONSTRAINT `gym_ibfk_1` FOREIGN KEY (`Coach_id`) REFERENCES `coach` (`Coach_id`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`Tariff_id`) REFERENCES `tariff` (`Tariff_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
