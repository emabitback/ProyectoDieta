-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: proyectodieta
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `comidas`
--

DROP TABLE IF EXISTS `comidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `comidas` (
  `id_comida` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(20) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`id_comida`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comidas`
--

LOCK TABLES `comidas` WRITE;
/*!40000 ALTER TABLE `comidas` DISABLE KEYS */;
INSERT INTO `comidas` VALUES (1,'frutas','pera'),(2,'frutas','pi√±a'),(3,'leguminosas','pollo'),(4,'cereales','linaza'),(5,'frutas','durazno'),(6,'frutas','fresa'),(7,'frutas','limon'),(8,'frutas','mandarina'),(9,'frutas','mango'),(10,'frutas','melon'),(11,'frutas','platano'),(12,'frutas','papaya'),(13,'frutas','pepino'),(14,'frutas','guayaba'),(15,'frutas','zanahoria'),(16,'frutas','brocoli'),(17,'frutas','jitomate'),(18,'frutas','rabano'),(19,'leguminosas','garbanzos'),(20,'frutas','habas'),(21,'leguminosas','lentejas'),(23,'leguminosas','pescado'),(25,'leguminosas','salmon'),(26,'leguminosas','huevo'),(27,'leguminosas','res'),(28,'cereales','arroz'),(29,'cereales','trigo'),(30,'cereales','avena'),(31,'cereales','quinoa'),(32,'cereales','amaranto');
/*!40000 ALTER TABLE `comidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dietas`
--

DROP TABLE IF EXISTS `dietas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dietas` (
  `correo` varchar(50) DEFAULT NULL,
  `dia` varchar(10) NOT NULL,
  `id_comida` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dietas`
--

LOCK TABLES `dietas` WRITE;
/*!40000 ALTER TABLE `dietas` DISABLE KEYS */;
INSERT INTO `dietas` VALUES ('juana@gmail.com','Lunes',2),('juana@gmail.com','Lunes',3),('juana@gmail.com','Martes',4),('juana@gmail.com','Martes',3),('juana@gmail.com','Mi√©rcoles',1),('juana@gmail.com','Mi√©rcoles',4),('adrian@gmail.com','Viernes',4),('adrian@gmail.com','S√°bado',3),('julian@gmail','Lunes',1),('julian@gmail','Martes',3),('julian@gmail','Mi√©rcoles',4),('julian@gmail','Jueves',2);
/*!40000 ALTER TABLE `dietas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `correo` varchar(50) NOT NULL,
  `psw` blob NOT NULL,
  `rol` char(1) NOT NULL,
  `nombre_completo` tinytext NOT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `anio_nacimiento` smallint(6) NOT NULL,
  `direccion` tinytext NOT NULL,
  `sexo` char(1) NOT NULL,
  `peso` float(5,2) NOT NULL,
  `altura` float(3,2) NOT NULL,
  `alergias` tinytext,
  `pregunta` tinytext NOT NULL,
  `respuesta` varchar(30) NOT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('adrian@gmail.com',_binary '\ÙKÆ-\'\–:∞+ô≥=˚a','A','AdrianSanchezCortina','7771234567',1995,'plan de aayala','F',70.00,2.00,'ninguna','Cual fue la marca de tu primer celular','nokia'),('diego@gmail.com',_binary 'Z¶.ùˇ\Ï*\Ì¸JõÅ∫;Z]','P','Diego CartujanoPerez','1234567777',1990,'Jojutla','M',70.00,1.30,'lidocaina y penicilina','Nombre de tu mascota actual','diego'),('emanuel@gmail.com',_binary '±(Y≠Q¥j\0\ƒf≠°\ÿ\…¢','A','Emanuel Ramirez Munoz','7774462087',1994,'tu corazon','M',80.50,1.85,'ninguna','Cual fue la marca de tu primer celular','pegaso'),('juana@gmail.com',_binary 'V˝\»\';\nπ\Ô∂/^ß','P','Juana Ramirez','7772961255',1968,'Jiutepec','F',80.00,1.65,'ninguna','Nombre de tu mascota actual','spike');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-28 12:07:09
