-- MySQL dump 10.16  Distrib 10.3.10-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: gaminginv
-- ------------------------------------------------------
-- Server version	10.3.10-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `checkinginout`
--

DROP TABLE IF EXISTS `checkinginout`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checkinginout` (
  `ID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Check` datetime NOT NULL,
  `Direction` enum('In','Out','Unseen','Arrived','Departed') NOT NULL,
  `ItemID` int(10) unsigned NOT NULL DEFAULT 0,
  `Duration` int(11) unsigned DEFAULT 0,
  PRIMARY KEY (`ID`),
  KEY `ItemChecked` (`ItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkinginout`
--

LOCK TABLES `checkinginout` WRITE;
/*!40000 ALTER TABLE `checkinginout` DISABLE KEYS */;
/*!40000 ALTER TABLE `checkinginout` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `configs`
--

DROP TABLE IF EXISTS `configs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configs` (
  `Platforms` text DEFAULT 'NES,SNES,N64,GameCube,Wii,Wii U,PSX,PS2,PS3,PS4,XBox,XBox 360,XBox One,Sega Genesis,Sega Saturn,Sega Dreamcast,Atari,Other,Xbox One X,Nintendo Switch'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configs`
--

LOCK TABLES `configs` WRITE;
/*!40000 ALTER TABLE `configs` DISABLE KEYS */;
/*!40000 ALTER TABLE `configs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items` (
  `Owner` varchar(50) NOT NULL,
  `ID` int(10) unsigned NOT NULL DEFAULT 0,
  `Type` varchar(50) NOT NULL,
  `Platform` varchar(50) NOT NULL,
  `Serial` varchar(50) DEFAULT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `LastCheckIn` datetime DEFAULT current_timestamp(),
  `LastCheckout` datetime DEFAULT current_timestamp(),
  `LogisticState` enum('Unseen','Arrived','Departed') DEFAULT 'Arrived',
  `LogisticStateUpdated` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemtypes`
--

DROP TABLE IF EXISTS `itemtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemtypes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TypeName` varchar(50) NOT NULL DEFAULT '0',
  `QtyMin` int(11) NOT NULL DEFAULT 0,
  `QtyMax` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemtypes`
--

LOCK TABLES `itemtypes` WRITE;
/*!40000 ALTER TABLE `itemtypes` DISABLE KEYS */;
INSERT INTO `itemtypes` VALUES (1,'Console',0,99),(2,'Controller',100,199),(3,'Peripheral',200,299),(4,'Cable',300,399),(5,'Game',500,999);
/*!40000 ALTER TABLE `itemtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `owner`
--

DROP TABLE IF EXISTS `owner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `owner` (
  `ID` int(10) unsigned NOT NULL DEFAULT 0,
  `Name` varchar(50) NOT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `BadgeName` varchar(50) DEFAULT NULL,
  `ItemCount` int(11) DEFAULT 0,
  `ConsoleCount` int(11) DEFAULT 0,
  `ControllerCount` int(11) DEFAULT 0,
  `PeripheralCount` int(11) DEFAULT 0,
  `CableCount` int(11) DEFAULT 0,
  `GameCount` int(11) DEFAULT 0,
  PRIMARY KEY (`ID`),
  KEY `Name` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `owner`
--

LOCK TABLES `owner` WRITE;
/*!40000 ALTER TABLE `owner` DISABLE KEYS */;
/*!40000 ALTER TABLE `owner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'gaminginv'
--
/*!50003 DROP FUNCTION IF EXISTS `insertItem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `insertItem`(
	`@NameParam` VARCHAR(50),
	`@TypeParam` VARCHAR(50),
	`@PlatformParam` VARCHAR(50),
	`@SerialParam` VARCHAR(50),
	`@DescriptionParam` VARCHAR(50)








) RETURNS decimal(10,0)
BEGIN
select `ID`  into @currentID from `owner` where `Name` = `@NameParam`;
select QtyMin into @typeVal from itemtypes where `TypeName` = `@TypeParam`;
CASE `@TypeParam`
	WHEN 'Game' THEN SELECT GameCount + @typeVal INTO @currentOffset FROM `owner` WHERE `Name` = `@NameParam`;
	WHEN 'Console' THEN SELECT ConsoleCount + @typeVal INTO @currentOffset FROM `owner` WHERE `Name` = `@NameParam`;
	WHEN 'Cable' THEN SELECT CableCount + @typeVal INTO @currentOffset FROM `owner` WHERE `Name` = `@NameParam`;
	WHEN 'Controller' THEN SELECT ControllerCount + @typeVal INTO @currentOffset FROM `owner` WHERE `Name` = `@NameParam`;
	WHEN 'Peripheral' THEN SELECT PeripheralCount + @typeVal INTO @currentOffset FROM `owner` WHERE `Name` = `@NameParam`;
END CASE;
set @generatedID = @currentID + @currentOffset;
insert into items (`Owner`,`ID`,`Type`,`Platform`,`Serial`,`Description`)
	values(`@NameParam`, @generatedID, `@TypeParam`, `@PlatformParam`, `@SerialParam`, `@DescriptionParam`);
update `owner` set `ItemCount` = ItemCount + 1 where `ID` = @currentID;
CASE `@TypeParam`
	WHEN 'Game' THEN update `owner` set `GameCount` = `GameCount` + 1 WHERE `ID` = @currentID;
	WHEN 'Console' THEN update `owner` set `ConsoleCount` = `ConsoleCount` + 1 WHERE `ID` = @currentID;
	WHEN 'Cable' THEN update `owner` set `CableCount` = `CableCount` + 1 WHERE `ID` = @currentID;
	WHEN 'Controller' THEN update `owner` set `ControllerCount` = `ControllerCount` + 1 WHERE `ID` = @currentID;
	WHEN 'Peripheral' THEN update `owner` set `PeripheralCount` = `PeripheralCount` + 1 WHERE `ID` = @currentID;
END CASE;
return @generatedID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertOwner` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `insertOwner`(
	IN `@NameParam` VARCHAR(50),
	IN `@PhoneParam` VARCHAR(50),
	IN `@EmailParam` VARCHAR(50),
	IN `@BadgeParam` VARCHAR(50)



)
BEGIN
select coalesce(max(`ID`), 0) into @owner_var from `owner`;
set @owner_var = @owner_var + 1000;
insert into `owner` (ID, `Name`, Phone, Email, BadgeName, ItemCount) values (@owner_var, `@NameParam`, `@PhoneParam`, `@EmailParam`, `@BadgeParam`, 0);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09 22:11:04
