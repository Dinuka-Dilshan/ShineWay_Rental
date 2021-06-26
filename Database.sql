-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 26, 2021 at 01:24 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vehicle`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
CREATE TABLE IF NOT EXISTS `booking` (
  `Vehicle_num` varchar(8) NOT NULL,
  `Booking_ID` int(20) NOT NULL AUTO_INCREMENT,
  `Licen_num` varchar(10) NOT NULL,
  `Start_date` timestamp NOT NULL,
  `Start_ODO` int(6) NOT NULL,
  `Package_Type` int(20) NOT NULL,
  `Cus_NIC` int(12) NOT NULL,
  `Discription` varchar(1000) NOT NULL,
  PRIMARY KEY (`Booking_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `Cus_NIC` varchar(12) NOT NULL,
  `Licen_num` varchar(10) NOT NULL,
  `First_name` varchar(20) NOT NULL,
  `Last_name` varchar(20) NOT NULL,
  `Tel_num` varchar(10) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Cus_Address` varchar(100) NOT NULL,
  PRIMARY KEY (`Cus_NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `owner`
--

DROP TABLE IF EXISTS `owner`;
CREATE TABLE IF NOT EXISTS `owner` (
  `Owner_NIC` varchar(12) NOT NULL,
  `Owner_name` varchar(20) NOT NULL,
  `Tel_num` varchar(10) NOT NULL,
  `Owner_Email` varchar(50) NOT NULL,
  `Owner_Address` varchar(100) NOT NULL,
  PRIMARY KEY (`Owner_NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `owner_payment`
--

DROP TABLE IF EXISTS `owner_payment`;
CREATE TABLE IF NOT EXISTS `owner_payment` (
  `Owner_NIC` varchar(12) NOT NULL,
  `payment_date` timestamp NOT NULL,
  `Payament_ID` int(11) NOT NULL AUTO_INCREMENT,
  `payment_ODO` int(11) NOT NULL,
  `Owner_pay_Amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Payament_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE IF NOT EXISTS `payment` (
  `Booking_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cust_NIC` varchar(12) NOT NULL,
  `Vehicle_num` varchar(10) NOT NULL,
  `Status` varchar(10) NOT NULL,
  `End_date` timestamp NOT NULL,
  `End_ODO` int(6) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Discount` decimal(10,2) NOT NULL,
  `Sub_Amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Booking_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
CREATE TABLE IF NOT EXISTS `vehicle` (
  `Vehicle_num` varchar(10) NOT NULL,
  `Brand` varchar(10) NOT NULL,
  `Model` varchar(15) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Engine_Num` varchar(25) NOT NULL,
  `Chassis_Num` varchar(30) NOT NULL,
  `Owner_NIC` varchar(12) NOT NULL,
  `Reg_Date` date NOT NULL,
  `Owner_Condi` varchar(200) NOT NULL,
  `Rent_price` int(10) NOT NULL,
  `Owner_payment` int(10) NOT NULL,
  `Starting_odo` int(6) NOT NULL,
  `Daily_price` decimal(10,2) NOT NULL,
  `Daliy_KM` int(6) NOT NULL,
  `Weekly_price` decimal(10,2) NOT NULL,
  `Weekly_KM` int(6) NOT NULL,
  `Monthly_price` decimal(10,2) NOT NULL,
  `Monthy_KM` int(6) NOT NULL,
  `Wedding_price` decimal(10,2) NOT NULL,
  `hourly_KM` int(11) NOT NULL,
  `hourly_price` int(11) NOT NULL,
  PRIMARY KEY (`Vehicle_num`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
