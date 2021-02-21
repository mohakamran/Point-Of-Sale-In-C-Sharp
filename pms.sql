-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2018 at 10:08 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pms`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `username` varchar(43) NOT NULL,
  `password` varchar(43) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`ID`, `username`, `password`) VALUES
(1, 'admin', 'abc');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(40) NOT NULL,
  `ProductQue` int(11) NOT NULL,
  `Discount` int(11) DEFAULT NULL,
  `ProductPrice` int(11) NOT NULL,
  `CustomerName` varchar(40) NOT NULL,
  `CustomerAdd` varchar(40) DEFAULT NULL,
  `Customercell` int(100) DEFAULT NULL,
  `ProductDate` varchar(50) DEFAULT NULL,
  `C_cellCode` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`ProductID`, `ProductName`, `ProductQue`, `Discount`, `ProductPrice`, `CustomerName`, `CustomerAdd`, `Customercell`, `ProductDate`, `C_cellCode`) VALUES
(2, 'MacBook', 2, 1000, 60000, 'Ali', 'Rawalpinidi', 2147483647, '13-12-2018', NULL),
(4, 'Tambako', 3, 0, 250, 'none', 'none', 8907120, '14-12-2018', 307),
(6, 'Fres up', 3, 0, 6, 'farat', 'none', 307123456, '14-12-2018', NULL),
(10, 'Mobile Samsung', 20, 0, 100000, 'Majid Company', 'Main Office: Islamabad', 12345670, '14-12-2018', 300);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`ProductID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
