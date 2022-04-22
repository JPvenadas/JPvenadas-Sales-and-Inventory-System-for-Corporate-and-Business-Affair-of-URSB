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
INSERT INTO `tbl_colleges` VALUES ('CCS','College of Computer Studies'),('COA','College of Accountancy'),('COB','College of Business');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_products`
--

LOCK TABLES `tbl_products` WRITE;
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
INSERT INTO `tbl_products` VALUES (1,'Female\'s School Uniform','Uniform',200,131),(2,'Folders','Stationery',15,212),(3,'Paper Pad 1/4','Stationery',20,176),(4,'Canteen Soup','Foods',10,9),(5,'Permanent Black Marker','Stationery',20,100),(6,'Male\'s PE Shirt','Uniform',180,75),(7,'HBW Pen','Stationery',10,210),(8,'Male\'s School Uniform','Uniform',200,112),(9,'Paper Pad 1/2','Stationery',20,100);
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stocks`
--

LOCK TABLES `tbl_stocks` WRITE;
/*!40000 ALTER TABLE `tbl_stocks` DISABLE KEYS */;
INSERT INTO `tbl_stocks` VALUES (2,5,'Permanent Black Marker',50,'2022-04-22'),(3,1,'Female\'s School Uniform',10,'2022-04-22'),(4,8,'Male\'s School Uniform',12,'2022-04-22'),(5,6,'Male\'s PE Shirt',10,'2022-04-22'),(6,4,'Canteen Soup',4,'2022-04-22'),(7,3,'Paper Pad 1/4',45,'2022-04-22'),(8,3,'Paper Pad 1/4',86,'2022-05-01');
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_students`
--

LOCK TABLES `tbl_students` WRITE;
/*!40000 ALTER TABLE `tbl_students` DISABLE KEYS */;
INSERT INTO `tbl_students` VALUES (1,'Jp','Año','Venadas','COB','BSBA','Binangonan, Rizal','09121212121'),(2,'Julius','Dominguez','Flores','COA','BSA','Binangonan, Rizal','09121212121'),(3,'Danica','Tolentino','Carullo','CCS','BSIT','Binangonan, Rizal','09121212121'),(4,'Jasper','Asiado','Silongan','CCS','BSIT','Binangonan, Rizal','09121212121'),(5,'Ludwig','Arabit','Aralar','CCS','BSIT','Binangonan, Rizal','09121212121'),(10,'Maria','Alajar','Sta Cruz','COB','BSBA','Binangonan, Rizal','09121212121'),(11,'Jason','Atrajenda','Del Carmen','COB','BSBA','Binangonan, Rizal','09784635282');
/*!40000 ALTER TABLE `tbl_students` ENABLE KEYS */;
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
INSERT INTO `tbl_users` VALUES ('Danica Carullo','12345','Danica Carullo','CBA Head','Active'),('DanicaCarullo','12345','Danica Carullo','CBA Head','Inactive'),('ddd','ddd','DanicaCarullo','CBA Head','Inactive'),('Helen123','12345','Helen','CBA Staff','Active'),('Herald123','12345','Herald Evangelista','CBA Head','Active'),('Jacob123','12345','Jacob Merjudio','CBA Staff','Active'),('JasperSilongan','12345','Jasper Silongan','CBA Head','Active'),('JpVenadas','12345','Jp Venadas','CBA Head','Active'),('JuliusFlores','12345','Julius Flores','CBA Head','Active'),('Kath123','12345','Katherine Alimon','CBA Staff','Active'),('LudwigAralar','1234','Ludwig Aralar','CBA Head','Active'),('Maria','12345','Maria','CBA Head','Inactive'),('Maria123','12345','Maria','CBA Staff','Active');
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

-- Dump completed on 2022-04-22 18:02:19
