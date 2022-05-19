-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: db_inventory
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_activities`
--

DROP TABLE IF EXISTS `tbl_activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_activities` (
  `ActivityID` int NOT NULL AUTO_INCREMENT,
  `Activity` varchar(150) NOT NULL,
  `UserName` varchar(45) NOT NULL,
  `Date` datetime NOT NULL,
  PRIMARY KEY (`ActivityID`)
) ENGINE=InnoDB AUTO_INCREMENT=411 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_activities`
--

LOCK TABLES `tbl_activities` WRITE;
/*!40000 ALTER TABLE `tbl_activities` DISABLE KEYS */;
INSERT INTO `tbl_activities` VALUES (184,'Logged in','JpVenadas','2022-05-10 08:14:17'),(185,'Made a Transaction with ID: 11','JpVenadas','2022-05-10 08:14:39'),(186,'Added a user with Username: Kath','JpVenadas','2022-05-10 08:16:16'),(187,'Logged in','JpVenadas','2022-05-10 09:32:44'),(188,'Logged in','JpVenadas','2022-05-10 09:33:11'),(189,'Logged in','JpVenadas','2022-05-10 09:34:20'),(190,'Updated a product with ID: 4','JpVenadas','2022-05-10 09:34:43'),(191,'Updated a product with ID: 4','JpVenadas','2022-05-10 09:34:57'),(192,'Logged in','JpVenadas','2022-05-10 09:35:44'),(193,'Updated a product with ID: 4','JpVenadas','2022-05-10 09:35:52'),(194,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 09:36:20'),(195,'Logged in','JpVenadas','2022-05-10 09:47:28'),(196,'Logged in','JpVenadas','2022-05-10 09:49:14'),(197,'Logged in','JpVenadas','2022-05-10 09:54:48'),(198,'Logged in','JpVenadas','2022-05-10 10:02:44'),(199,'Logged in','JpVenadas','2022-05-10 10:03:14'),(200,'Updated a product with ID: 4','JpVenadas','2022-05-10 10:05:21'),(201,'Logged in','JpVenadas','2022-05-10 10:17:07'),(202,'Logged in','JpVenadas','2022-05-10 10:27:25'),(203,'Logged in','JpVenadas','2022-05-10 10:28:13'),(204,'Logged in','JpVenadas','2022-05-10 10:38:31'),(205,'Deactivated an Account: JpVenadas','JpVenadas','2022-05-10 10:38:39'),(206,'Activated an Account: JpVenadas','JpVenadas','2022-05-10 10:38:45'),(207,'Logged in','JpVenadas','2022-05-10 11:00:06'),(208,'Logged in','JpVenadas','2022-05-10 11:01:46'),(209,'Updated a product with ID: 4','JpVenadas','2022-05-10 11:02:34'),(210,'Updated a product with ID: 4','JpVenadas','2022-05-10 11:02:38'),(211,'Logged in','JpVenadas','2022-05-10 11:13:16'),(212,'Logged in','Jacob123','2022-05-10 11:16:24'),(213,'Logged in','Jacob123','2022-05-10 11:17:56'),(214,'Logged in','JpVenadas','2022-05-10 11:18:35'),(215,'Logged in','Jacob123','2022-05-10 11:18:48'),(216,'Logged in','JpVenadas','2022-05-10 11:23:33'),(217,'Logged in','Jacob123','2022-05-10 11:23:57'),(218,'Logged in','Jacob123','2022-05-10 11:24:24'),(219,'Logged in','JpVenadas','2022-05-10 11:25:46'),(220,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:26:38'),(221,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:26:44'),(222,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 11:26:49'),(223,'Logged in','JpVenadas','2022-05-10 11:27:50'),(224,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:27:56'),(225,'Updated a product with ID: 10','JpVenadas','2022-05-10 11:28:05'),(226,'Added Stocks to a Product with ID: 1','JpVenadas','2022-05-10 11:28:10'),(227,'Logged in','JpVenadas','2022-05-10 11:28:36'),(228,'Updated a Student with ID: 2','JpVenadas','2022-05-10 11:28:50'),(229,'Logged in','JpVenadas','2022-05-10 11:30:32'),(230,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:30:38'),(231,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:30:41'),(232,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:30:44'),(233,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 11:31:07'),(234,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 11:31:12'),(235,'Updated a Student with ID: 1','JpVenadas','2022-05-10 11:31:21'),(236,'Updated a product with ID: 1','JpVenadas','2022-05-10 11:31:29'),(237,'Added Stocks to a Product with ID: 1','JpVenadas','2022-05-10 11:31:36'),(238,'Updated a Student with ID: 1','JpVenadas','2022-05-10 11:32:08'),(239,'Updated a Student with ID: 1','JpVenadas','2022-05-10 11:32:13'),(240,'Logged in','JpVenadas','2022-05-10 11:33:26'),(241,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:33:32'),(242,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:33:35'),(243,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 11:33:39'),(244,'Deactivated an Account: Danica Carullo','JpVenadas','2022-05-10 11:33:43'),(245,'Activated an Account: Danica Carullo','JpVenadas','2022-05-10 11:33:48'),(246,'Logged in','JpVenadas','2022-05-10 11:35:18'),(247,'Updated a Student with ID: 1','JpVenadas','2022-05-10 11:35:24'),(248,'Updated a Student with ID: 1','JpVenadas','2022-05-10 11:35:27'),(249,'Logged in','JpVenadas','2022-05-10 12:26:32'),(250,'Logged in','Jacob123','2022-05-10 12:26:49'),(251,'Logged in','JpVenadas','2022-05-10 12:27:31'),(252,'Logged in','Jacob123','2022-05-10 12:27:43'),(253,'Logged in','Jacob123','2022-05-10 12:29:22'),(254,'Logged in','JpVenadas','2022-05-10 12:29:36'),(255,'Logged in','JpVenadas','2022-05-10 12:31:42'),(256,'Logged in','Jacob123','2022-05-10 12:31:53'),(257,'Logged in','JpVenadas','2022-05-10 12:32:45'),(258,'Logged in','JpVenadas','2022-05-10 12:34:16'),(259,'Logged in','Jacob123','2022-05-10 12:34:28'),(260,'Logged in','JpVenadas','2022-05-10 12:43:56'),(261,'Logged in','JpVenadas','2022-05-10 12:44:30'),(262,'Logged in','JpVenadas','2022-05-10 12:50:18'),(263,'Added Stocks to a Product with ID: 6','JpVenadas','2022-05-10 12:57:12'),(264,'Made a Transaction with ID: 12','JpVenadas','2022-05-10 12:57:37'),(265,'Updated a user with ID: JpVenadas','JpVenadas','2022-05-10 12:59:54'),(266,'Updated a user with ID: JpVenadas','JpVenadas','2022-05-10 13:00:05'),(267,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 13:03:54'),(268,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 13:04:21'),(269,'Logged in','JpVenadas','2022-05-10 13:05:06'),(270,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 13:05:15'),(271,'Updated a user with ID: Herald123','JpVenadas','2022-05-10 13:05:39'),(272,'Activated an Account: Maria123','JpVenadas','2022-05-10 13:07:07'),(273,'Deactivated an Account: Maria123','JpVenadas','2022-05-10 13:07:17'),(274,'Added a new Student: Juan Evangelista','JpVenadas','2022-05-10 13:10:41'),(275,'Updated a Student with ID: 13','JpVenadas','2022-05-10 13:11:00'),(276,'Updated a Student with ID: 13','JpVenadas','2022-05-10 13:11:26'),(277,'Added a Product: djdjdj','JpVenadas','2022-05-10 13:19:26'),(278,'Deleted a Product with ID: 28','JpVenadas','2022-05-10 13:19:32'),(279,'Logged in','JpVenadas','2022-05-10 13:21:57'),(280,'Added Stocks to a Product with ID: 6','JpVenadas','2022-05-10 13:25:14'),(281,'Added Stocks to a Product with ID: 10','JpVenadas','2022-05-10 13:28:13'),(282,'Logged in','JpVenadas','2022-05-10 13:31:31'),(283,'Logged in','Jacob123','2022-05-10 13:47:15'),(284,'Logged in','JpVenadas','2022-05-10 13:48:53'),(285,'Logged in','JpVenadas','2022-05-10 13:53:31'),(286,'Logged in','JpVenadas','2022-05-10 14:05:21'),(287,'Logged in','Jacob123','2022-05-10 14:05:36'),(288,'Logged in','JpVenadas','2022-05-10 14:05:57'),(289,'Logged in','JpVenadas','2022-05-10 14:06:30'),(290,'Logged in','Jacob123','2022-05-10 14:06:46'),(291,'Logged in','JpVenadas','2022-05-10 14:08:38'),(292,'Logged in','JpVenadas','2022-05-10 14:14:58'),(293,'Logged in','JpVenadas','2022-05-10 14:19:09'),(294,'Logged in','JpVenadas','2022-05-10 14:19:32'),(295,'Logged in','JpVenadas','2022-05-10 14:21:44'),(296,'Logged in','JpVenadas','2022-05-10 14:22:42'),(297,'Logged in','JpVenadas','2022-05-10 14:23:20'),(298,'Logged in','JpVenadas','2022-05-10 14:31:38'),(299,'Logged in','JpVenadas','2022-05-10 14:32:22'),(300,'Logged in','JpVenadas','2022-05-10 14:34:52'),(301,'Logged in','JpVenadas','2022-05-10 14:35:42'),(302,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 14:35:52'),(303,'Logged in','JpVenadas','2022-05-10 14:39:05'),(304,'Updated a user with ID: Danica Carullo','JpVenadas','2022-05-10 14:39:15'),(305,'Logged in','JpVenadas','2022-05-10 14:43:51'),(306,'Logged in','JpVenadas','2022-05-10 14:44:39'),(307,'Logged in','Jacob123','2022-05-10 14:45:01'),(308,'Logged in','JpVenadas','2022-05-10 14:50:29'),(309,'Logged in','JpVenadas','2022-05-10 14:51:15'),(310,'Logged in','JpVenadas','2022-05-10 14:52:09'),(311,'Logged in','Jacob123','2022-05-10 14:52:29'),(312,'Logged in','JpVenadas','2022-05-10 14:54:30'),(313,'Logged in','JpVenadas','2022-05-10 14:55:52'),(314,'Logged in','JpVenadas','2022-05-10 22:21:23'),(315,'Logged in','JpVenadas','2022-05-10 22:22:08'),(316,'Logged in','JpVenadas','2022-05-10 22:27:54'),(317,'Logged in','JpVenadas','2022-05-10 22:29:09'),(318,'Logged in','Jacob123','2022-05-10 22:29:35'),(319,'Logged in','JpVenadas','2022-05-10 22:34:24'),(320,'Logged in','JpVenadas','2022-05-10 22:36:17'),(321,'Logged in','JpVenadas','2022-05-10 22:39:24'),(322,'Logged in','JpVenadas','2022-05-10 22:40:05'),(323,'Logged in','JpVenadas','2022-05-10 22:43:48'),(324,'Logged in','JpVenadas','2022-05-10 22:45:23'),(325,'Logged in','JpVenadas','2022-05-10 22:46:02'),(326,'Logged in','JpVenadas','2022-05-10 22:46:39'),(327,'Logged in','JpVenadas','2022-05-10 22:47:30'),(328,'Logged in','Jacob123','2022-05-10 22:47:52'),(329,'Logged in','JpVenadas','2022-05-10 22:48:37'),(330,'Logged in','JpVenadas','2022-05-10 22:52:39'),(331,'Logged in','JpVenadas','2022-05-10 22:58:43'),(332,'Logged in','JpVenadas','2022-05-10 22:59:27'),(333,'Logged in','JpVenadas','2022-05-10 23:00:17'),(334,'Logged in','JpVenadas','2022-05-10 23:01:02'),(335,'Logged in','JpVenadas','2022-05-10 23:04:35'),(336,'Logged in','JpVenadas','2022-05-10 23:05:36'),(337,'Logged in','JpVenadas','2022-05-10 23:05:56'),(338,'Logged in','JpVenadas','2022-05-10 23:07:54'),(339,'Logged in','JpVenadas','2022-05-10 23:13:37'),(340,'Logged in','JpVenadas','2022-05-10 23:19:44'),(341,'Logged in','Jacob123','2022-05-10 23:20:05'),(342,'Logged in','JpVenadas','2022-05-10 23:24:08'),(343,'Logged in','JpVenadas','2022-05-11 06:31:30'),(344,'Logged in','JpVenadas','2022-05-11 06:32:05'),(345,'Logged in','JpVenadas','2022-05-11 06:32:47'),(346,'Logged in','Jacob123','2022-05-11 06:33:16'),(347,'Logged in','JpVenadas','2022-05-11 06:33:41'),(348,'Logged in','Jacob123','2022-05-11 06:34:08'),(349,'Logged in','JpVenadas','2022-05-11 06:34:54'),(350,'Logged in','Jacob123','2022-05-11 06:35:23'),(351,'Logged in','JpVenadas','2022-05-11 06:36:33'),(352,'Logged in','Jacob123','2022-05-11 06:37:01'),(353,'Logged in','JpVenadas','2022-05-11 06:38:13'),(354,'Logged in','Jacob123','2022-05-11 06:38:50'),(355,'Logged in','JpVenadas','2022-05-11 06:47:30'),(356,'Logged in','JpVenadas','2022-05-11 06:49:03'),(357,'Logged in','JpVenadas','2022-05-11 06:49:24'),(358,'Logged in','JpVenadas','2022-05-11 06:52:43'),(359,'Logged in','JpVenadas','2022-05-11 06:53:39'),(360,'Logged in','Jacob123','2022-05-11 06:54:32'),(361,'Logged in','JpVenadas','2022-05-11 06:55:09'),(362,'Logged in','JpVenadas','2022-05-11 06:59:27'),(363,'Updated a product with ID: 1','JpVenadas','2022-05-11 07:01:15'),(364,'Logged in','JpVenadas','2022-05-11 07:04:18'),(365,'Logged in','Danica Carullo','2022-05-11 07:04:43'),(366,'Logged in','JpVenadas','2022-05-11 07:09:01'),(367,'Logged in','JpVenadas','2022-05-11 07:15:36'),(368,'Updated a user with ID: Helen123','JpVenadas','2022-05-11 07:15:59'),(369,'Updated a user with ID: Helen123','JpVenadas','2022-05-11 07:16:02'),(370,'Logged in','JpVenadas','2022-05-11 07:17:24'),(371,'Logged in','JpVenadas','2022-05-11 07:18:06'),(372,'Logged in','JpVenadas','2022-05-11 07:19:10'),(373,'Logged in','JpVenadas','2022-05-11 07:21:11'),(374,'Logged in','JpVenadas','2022-05-11 07:29:25'),(375,'Added a College with ID: COE','JpVenadas','2022-05-11 07:32:13'),(376,'Updated a College with ID: COE','JpVenadas','2022-05-11 07:33:06'),(377,'Updated a College with ID: COY','JpVenadas','2022-05-11 07:33:12'),(378,'Deleted a College with ID: COE','JpVenadas','2022-05-11 07:35:31'),(379,'Added a College with ID: COE','JpVenadas','2022-05-11 07:37:51'),(380,'Added a course with ID: BSCE','JpVenadas','2022-05-11 07:38:42'),(381,'Updated a Course with ID: BSCE','JpVenadas','2022-05-11 07:39:08'),(382,'Deleted a Course with ID: BSCE','JpVenadas','2022-05-11 07:39:44'),(383,'Added a Product Category: Something','JpVenadas','2022-05-11 07:41:08'),(384,'Deleted a Product Category: Something','JpVenadas','2022-05-11 07:41:35'),(385,'Deleted a College with ID: COE','JpVenadas','2022-05-11 07:42:27'),(386,'Logged in','JpVenadas','2022-05-11 07:47:16'),(387,'Logged in','JpVenadas','2022-05-11 07:49:34'),(388,'Logged in','JpVenadas','2022-05-11 08:08:01'),(389,'Logged in','JuliusFlores','2022-05-11 08:08:39'),(390,'Logged in','JpVenadas','2022-05-11 08:17:40'),(391,'Logged in','JpVenadas','2022-05-11 08:54:45'),(392,'Made a Transaction with ID: 12','JpVenadas','2022-05-11 08:59:26'),(393,'Added a user with Username: Maria','JpVenadas','2022-05-11 09:01:05'),(394,'Added a new Student: fggf fgf','JpVenadas','2022-05-11 09:03:39'),(395,'Updated a Student with ID: 3','JpVenadas','2022-05-11 09:04:38'),(396,'Added a Product: Something','JpVenadas','2022-05-11 09:05:39'),(397,'Deleted a Product with ID: 29','JpVenadas','2022-05-11 09:06:04'),(398,'Added Stocks to a Product with ID: 4','JpVenadas','2022-05-11 09:08:08'),(399,'Made a Transaction with ID: 13','JpVenadas','2022-05-11 09:10:16'),(400,'Added a College with ID: COE','JpVenadas','2022-05-11 09:13:51'),(401,'Added a course with ID: BSCE','JpVenadas','2022-05-11 09:14:36'),(402,'Deleted a Course with ID: BSCE','JpVenadas','2022-05-11 09:14:53'),(403,'Added a Product Category: dkdkddj','JpVenadas','2022-05-11 09:15:12'),(404,'Deleted a Product Category: dkdkddj','JpVenadas','2022-05-11 09:15:22'),(405,'Added a Product Category: ddgd','JpVenadas','2022-05-11 09:15:30'),(406,'Deleted a Product Category: ddgd','JpVenadas','2022-05-11 09:15:36'),(407,'Logged in','JpVenadas','2022-05-11 18:49:09'),(408,'Logged in','JpVenadas','2022-05-12 21:12:49'),(409,'Logged in','JpVenadas','2022-05-12 21:17:45'),(410,'Made a Transaction with ID: 14','JpVenadas','2022-05-12 21:19:07');
/*!40000 ALTER TABLE `tbl_activities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cart`
--

DROP TABLE IF EXISTS `tbl_cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cart` (
  `TransactionID` int NOT NULL,
  `StudentID` int NOT NULL,
  `Fullname` varchar(100) NOT NULL,
  `ProductID` int NOT NULL,
  `ProductName` varchar(45) NOT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(20,0) NOT NULL,
  `TotalAmount` decimal(20,0) NOT NULL,
  PRIMARY KEY (`TransactionID`,`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cart`
--

LOCK TABLES `tbl_cart` WRITE;
/*!40000 ALTER TABLE `tbl_cart` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_categories`
--

DROP TABLE IF EXISTS `tbl_categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_categories` (
  `ProductCategory` varchar(120) NOT NULL,
  PRIMARY KEY (`ProductCategory`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_categories`
--

LOCK TABLES `tbl_categories` WRITE;
/*!40000 ALTER TABLE `tbl_categories` DISABLE KEYS */;
INSERT INTO `tbl_categories` VALUES ('Foods'),('Stationery'),('Uniform');
/*!40000 ALTER TABLE `tbl_categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_colleges`
--

DROP TABLE IF EXISTS `tbl_colleges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_colleges` (
  `CollegeID` varchar(45) NOT NULL,
  `CollegeName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`CollegeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_colleges`
--

LOCK TABLES `tbl_colleges` WRITE;
/*!40000 ALTER TABLE `tbl_colleges` DISABLE KEYS */;
INSERT INTO `tbl_colleges` VALUES ('CCS','College of Computer Studies'),('COA','College of Accountancy'),('COB','College of Business'),('COE','College of Engineering');
/*!40000 ALTER TABLE `tbl_colleges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_courses`
--

DROP TABLE IF EXISTS `tbl_courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_courses` (
  `CourseID` varchar(45) NOT NULL,
  `CourseName` varchar(45) NOT NULL,
  `CollegeID` varchar(45) NOT NULL,
  PRIMARY KEY (`CourseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_courses`
--

LOCK TABLES `tbl_courses` WRITE;
/*!40000 ALTER TABLE `tbl_courses` DISABLE KEYS */;
INSERT INTO `tbl_courses` VALUES ('BSA','BS in Accountancy','COA'),('BSBA','BS in Business Administration','COB'),('BSIS','BS in Information System','CCS'),('BSIT','BS in Information Technology','CCS'),('BSOA','BS in Office Administration','COB');
/*!40000 ALTER TABLE `tbl_courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_products`
--

DROP TABLE IF EXISTS `tbl_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(45) NOT NULL,
  `ProductCategory` varchar(45) NOT NULL,
  `Price` decimal(10,0) NOT NULL,
  `Stocks` int NOT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_products`
--

LOCK TABLES `tbl_products` WRITE;
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
INSERT INTO `tbl_products` VALUES (1,'Female\'s School Uniform','Uniform',201,111),(4,'Canteen Soup','Foods',10,42),(5,'Permanent Black Marker','Stationery',20,100),(6,'Male\'s PE Shirt','Uniform',180,159),(8,'Male\'s School Uniform','Uniform',200,68),(10,'Female\'s PE Uniform','Uniform',211,128),(27,'Folders','Stationery',12,7);
/*!40000 ALTER TABLE `tbl_products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stocks`
--

DROP TABLE IF EXISTS `tbl_stocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_stocks` (
  `StockID` int NOT NULL AUTO_INCREMENT,
  `ProductID` int NOT NULL,
  `ProductName` varchar(45) NOT NULL,
  `AddedStocks` int NOT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`StockID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stocks`
--

LOCK TABLES `tbl_stocks` WRITE;
/*!40000 ALTER TABLE `tbl_stocks` DISABLE KEYS */;
INSERT INTO `tbl_stocks` VALUES (2,5,'Permanent Black Marker',50,'2022-04-22'),(3,1,'Female\'s School Uniform',10,'2022-04-22'),(4,8,'Male\'s School Uniform',12,'2022-04-22'),(5,6,'Male\'s PE Shirt',10,'2022-04-22'),(6,4,'Canteen Soup',4,'2022-04-22'),(7,3,'Paper Pad 1/4',45,'2022-04-22'),(8,3,'Paper Pad 1/4',86,'2022-05-01'),(9,1,'Female\'s School Uniform',28,'2022-05-09'),(10,1,'Female\'s School Uniform',10,'2022-05-09'),(11,10,'Female\'s PE Uniform',38,'2022-05-10'),(12,6,'Male\'s PE Shirt',161,'2022-05-10'),(13,10,'Female\'s PE Uniform',88,'2022-05-10'),(14,4,'Canteen Soup',11,'2022-05-10'),(15,1,'Female\'s School Uniform',25,'2022-05-10'),(16,27,'Folders',77,'2022-05-10'),(17,27,'Folders',30,'2022-05-10'),(18,27,'Folders',30,'2022-05-10'),(19,27,'Folders',34,'2022-05-10'),(20,1,'Female\'s School Uniform',30,'2022-05-10'),(21,1,'Female\'s School Uniform',16,'2022-05-10'),(22,6,'Male\'s PE Shirt',152,'2022-05-10'),(23,6,'Male\'s PE Shirt',20,'2022-05-10'),(24,10,'Female\'s PE Uniform',2,'2022-05-10'),(25,4,'Canteen Soup',30,'2022-05-11');
/*!40000 ALTER TABLE `tbl_stocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_students`
--

DROP TABLE IF EXISTS `tbl_students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_students` (
  `StudentID` int NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(45) NOT NULL,
  `Middlename` varchar(45) DEFAULT NULL,
  `Lastname` varchar(45) NOT NULL,
  `College` varchar(45) NOT NULL,
  `Course` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNo` varchar(45) NOT NULL,
  PRIMARY KEY (`StudentID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_students`
--

LOCK TABLES `tbl_students` WRITE;
/*!40000 ALTER TABLE `tbl_students` DISABLE KEYS */;
INSERT INTO `tbl_students` VALUES (1,'Jp','Año','Venadas','CCS','BSIT','Binangonan, Rizal','09121212122'),(2,'Julius','Dominguez','Flores','COB','BSOA','Binangonan, Rizal','09121212121'),(3,'Danica','Tolentino','Carullo','CCS','BSIT','Binangonan, Rizal','09121212121'),(4,'Jasper','Asiado','Silongan','CCS','BSIT','Binangonan, Rizal','09121212121'),(5,'Ludwig','Arabit','Aralar','CCS','BSIT','Binangonan, Rizal','09121212121'),(10,'Maria','Alajar','Sta Cruz','COB','BSBA','Binangonan, Rizal','09121212121'),(11,'Jason','Atrajenda','Del Carmen','COB','BSBA','Binangonan, Rizal','09784635282'),(12,'Someone','fdfdf','fdfdf','CCS','BSIS','dfdf','1234567'),(13,'Juan','','Bautista','COB','BSOA','Binangonan, Rizal','0923456789'),(14,'fggf','fgfg','fgf','CCS','BSIT','ddfdf','12345678');
/*!40000 ALTER TABLE `tbl_students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transactions`
--

DROP TABLE IF EXISTS `tbl_transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transactions` (
  `TransactionID` int NOT NULL,
  `StudentID` int NOT NULL,
  `Fullname` varchar(100) NOT NULL,
  `ProductID` int NOT NULL,
  `ProductName` varchar(45) NOT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(20,0) NOT NULL,
  `TotalAmount` decimal(20,0) NOT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`TransactionID`,`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transactions`
--

LOCK TABLES `tbl_transactions` WRITE;
/*!40000 ALTER TABLE `tbl_transactions` DISABLE KEYS */;
INSERT INTO `tbl_transactions` VALUES (1,1,'Jp Año Venadas',2,'Folders',3,15,45,'2022-04-06'),(2,1,'Jp Año Venadas',2,'Folders',5,15,75,'2022-05-06'),(3,1,'Jp Año Venadas',6,'Male\'s PE Shirt',6,180,1080,'2022-03-07'),(3,1,'Jp Año Venadas',8,'Male\'s School Uniform',6,200,1200,'2022-02-07'),(4,2,'Julius Dominguez Flores',2,'Folders',10,15,150,'2022-04-07'),(4,2,'Julius Dominguez Flores',6,'Male\'s PE Shirt',10,180,1800,'2022-01-07'),(5,10,'Maria Alajar Sta Cruz',2,'Folders',6,15,90,'2021-12-07'),(6,3,'Danica Tolentino Carullo',1,'Female\'s School Uniform',11,200,2200,'2021-08-07'),(6,3,'Danica Tolentino Carullo',10,'Female\'s PE Uniform',3,210,630,'2021-09-07'),(7,5,'Ludwig Arabit Aralar',6,'Male\'s PE Shirt',8,180,1440,'2021-07-07'),(8,1,'Jp Año Venadas',8,'Male\'s School Uniform',16,200,3200,'2021-06-07'),(9,3,'Danica Tolentino Carullo',10,'Female\'s PE Uniform',3,210,630,'2021-10-07'),(10,4,'Jasper Asiado Silongan',6,'Male\'s PE Shirt',7,180,1260,'2021-11-07'),(11,1,'Jp Año Venadas',27,'Folders',3,12,36,'2022-05-10'),(12,1,'Jp Año Venadas',8,'Male\'s School Uniform',12,200,2400,'2022-05-11'),(13,1,'Jp Año Venadas',4,'Canteen Soup',3,10,30,'2022-05-11'),(13,1,'Jp Año Venadas',27,'Folders',11,12,132,'2022-05-11'),(14,1,'jp Año Venadas',4,'Canteen Soup',5,10,50,'2022-05-12'),(14,1,'jp Año Venadas',27,'Folders',6,12,72,'2022-05-12');
/*!40000 ALTER TABLE `tbl_transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_users` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `LoginName` varchar(150) NOT NULL,
  `UserType` varchar(45) NOT NULL,
  `AccountStatus` varchar(45) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES ('Danica Carullo','12345','Danica Carullo','CBA Head','Active'),('Helen123','12345','Helen','CBA Staff','Inactive'),('Herald123','12345','Herald Bautista','CBA Head','Active'),('Jacob123','12345','Jacob Merjudio','CBA Staff','Active'),('JasperSilongan','12345','Jasper Silongan','CBA Head','Active'),('JpVenadas','12345','Jp Venadas','CBA Head','Active'),('JuliusFlores','12345','Julius Flores','CBA Head','Active'),('Kath','12345','Kath Acostas','CBA Head','Active'),('LudwigAralar','1234','Ludwig Aralar','CBA Head','Active'),('Maria','1234','maria sta cruz','CBA Head','Active'),('Maria123','12345','Maria','CBA Staff','Inactive');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_inventory'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-20  4:36:24
