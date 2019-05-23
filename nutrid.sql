-- MySQL dump 10.13  Distrib 5.5.61, for Win64 (AMD64)
--
-- Host: localhost    Database: nutrid
-- ------------------------------------------------------
-- Server version	5.5.61

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
-- Table structure for table `comidas`
--

DROP TABLE IF EXISTS `comidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comidas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `comida` varchar(50) NOT NULL,
  `categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comidas`
--

LOCK TABLES `comidas` WRITE;
/*!40000 ALTER TABLE `comidas` DISABLE KEYS */;
INSERT INTO `comidas` VALUES (1,'frutas secaas','frutas'),(2,'fruta del pan','frutas'),(13,'plÃ¡tano','frutas'),(4,'frijoles','leguminosas'),(5,'trigo','cereales'),(6,'cereal kellogs','cereales'),(7,'cereal choco kripis','cereales'),(8,'sandÃ­a','frutas'),(9,'ser','leguminosas'),(10,'manzana','frutas'),(11,'res','leguminosas'),(12,'granola','cereales'),(14,'atÃºn','leguminosas'),(15,'tacos','leguminosas'),(16,'fresa','frutas'),(17,'brocoli','frutas'),(18,'pera','frutas'),(19,'pepino','frutas'),(20,'kiwi','frutas'),(21,'rabano','frutas'),(22,'linaza','cereales');
/*!40000 ALTER TABLE `comidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dieta`
--

DROP TABLE IF EXISTS `dieta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dieta` (
  `correo` varchar(70) NOT NULL,
  `dia` varchar(70) NOT NULL,
  `comida` varchar(70) NOT NULL,
  PRIMARY KEY (`correo`,`dia`,`comida`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dieta`
--

LOCK TABLES `dieta` WRITE;
/*!40000 ALTER TABLE `dieta` DISABLE KEYS */;
INSERT INTO `dieta` VALUES ('adrian@gmail.com','Lunes','fresa'),('adrian@gmail.com','Martes','res'),('ddanielhdz@gmail.com','Jueves','frijoles'),('ddanielhdz@gmail.com','Jueves','frutas secaas'),('ddanielhdz@gmail.com','Jueves','ser'),('ddanielhdz@gmail.com','Lunes','cereal kellogs'),('ddanielhdz@gmail.com','Lunes','fruta del pan'),('ddanielhdz@gmail.com','Lunes','frutas secaas'),('ddanielhdz@gmail.com','Lunes','manzana'),('ddanielhdz@gmail.com','Martes',''),('ddanielhdz@gmail.com','Martes','frijoles'),('ddanielhdz@gmail.com','Martes','ser'),('derefer@fere','Lunes','manzana'),('emanuel_ramirez123@hotmail.com','Lunes','frijoles'),('emanuel_ramirez123@hotmail.com','Lunes','sandÃ­a'),('emanuel_ramirez123@hotmail.com','MiÃ©rcoles','cereal choco kripis'),('emanuel_ramirez123@hotmail.com','Viernes','atÃºn'),('emanuel_ramirez123@hotmail.com','Viernes','frutas secaas'),('emanuel_ramirez123@hotmail.com','Viernes','trigo'),('valv','Jueves','res'),('valv','Lunes','frijoles'),('valv','Lunes','ser'),('valv','Martes','ser'),('valv','MiÃ©rcoles','res'),('valv','SÃ¡bado','frijoles'),('valv','SÃ¡bado','frutas secaas'),('valv','Viernes','atÃºn'),('valv','Viernes','frutas secaas'),('valv','Viernes','res');
/*!40000 ALTER TABLE `dieta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usrs_data`
--

DROP TABLE IF EXISTS `usrs_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usrs_data` (
  `correo` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apep` varchar(30) NOT NULL,
  `apem` varchar(30) NOT NULL,
  `telefono` char(10) NOT NULL,
  `nacimiento` varchar(30) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `sexo` varchar(10) NOT NULL,
  `peso` int(11) NOT NULL,
  `altura` decimal(10,0) NOT NULL,
  `alergias` varchar(80) NOT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usrs_data`
--

LOCK TABLES `usrs_data` WRITE;
/*!40000 ALTER TABLE `usrs_data` DISABLE KEYS */;
INSERT INTO `usrs_data` VALUES ('derefer@fere','fffafa','fifi','val','23232','1222','aca','Masculino',12,12,'34'),('valv','brah','va','va','3232','1111','aca','Masculino',122,12,'12'),('ddanielhdz@gmail.com','alisson','valverde','hernandez','7778989','1990','Calle Galaxias No. 19','Femenino',70,78,'2'),('adrian@gmail.com','adrian','sanchez','cortina','7774945574','2000','tu corazon','Masculino',70,2,'hola'),('emanuel_ramirez123@hotmail.com','Emanuel','Ramirez','Munoz','7774462087','0','tu corazon','Masculino',200,3,'a la penicilina y a el amor');
/*!40000 ALTER TABLE `usrs_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usrs_login`
--

DROP TABLE IF EXISTS `usrs_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usrs_login` (
  `correo` varchar(50) NOT NULL,
  `psw` blob NOT NULL,
  `rol` char(3) NOT NULL,
  `pregunta` varchar(40) NOT NULL,
  `respuesta` varchar(30) NOT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usrs_login`
--

LOCK TABLES `usrs_login` WRITE;
/*!40000 ALTER TABLE `usrs_login` DISABLE KEYS */;
INSERT INTO `usrs_login` VALUES ('valv','¶[Ñ§<‚Ø–]&äæ\r:','USR','Â¿CuÃ¡l fue tu primer nÃºmero?','123'),('ddanielhdz@gmail.com','ÛMÀ>a	ì5P,lû\'H','USR','Â¿CuÃ¡l fue tu primer nÃºmero?','Respuesta'),('derefer@fere','åXV­#I‰vø^Â­©M','USR','Â¿CuÃ¡l fue tu primer nÃºmero?','123'),('jarek@mail.com','l?eÇé7òùh#kªœYU','ADM','Comida favorita','frijoles'),('ddanielhdz@mail.com','N2Þ2¯ÌñB,ê›§’Ð‘','USR','Comida favorita','Respuesta'),('ddanielhdz@cgmail.com','N2Þ2¯ÌñB,ê›§’Ð‘','USR','Comida favorita','Respuesta'),('','N2Þ2¯ÌñB,ê›§’Ð‘','USR','Comida favorita','Respuesta'),('adrian@gmail.com','kÈÓ{ã¯¡	ÆéŸc›šZ','USR','Â¿Nombre de tu mascota?','Respuesta'),('emanuelramire','N2Þ2¯ÌñB,ê›§’Ð‘','USR','Â¿CuÃ¡l fue tu primer nÃºmero?','Respuesta'),('emanuel_ramirez123@hotmail.com','=/ªè\"¢P¬äS?l[À','USR','Comida favorita','baloncesto');
/*!40000 ALTER TABLE `usrs_login` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-23  8:44:59
