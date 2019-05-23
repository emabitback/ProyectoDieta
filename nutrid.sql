-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 23-05-2019 a las 06:22:07
-- Versión del servidor: 5.7.24
-- Versión de PHP: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `nutrid`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comidas`
--

DROP TABLE IF EXISTS `comidas`;
CREATE TABLE IF NOT EXISTS `comidas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `comida` varchar(50) NOT NULL,
  `categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `comidas`
--

INSERT INTO `comidas` (`id`, `comida`, `categoria`) VALUES
(1, 'frutas secaas', 'frutas'),
(2, 'fruta del pan', 'frutas'),
(13, 'plátano', 'frutas'),
(4, 'frijoles', 'leguminosas'),
(5, 'trigo', 'cereales'),
(6, 'cereal kellogs', 'cereales'),
(7, 'cereal choco kripis', 'cereales'),
(8, 'sandía', 'frutas'),
(9, 'ser', 'leguminosas'),
(10, 'manzana', 'frutas'),
(11, 'res', 'leguminosas'),
(12, 'granola', 'cereales'),
(14, 'atún', 'leguminosas'),
(15, 'tacos', 'leguminosas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dieta`
--

DROP TABLE IF EXISTS `dieta`;
CREATE TABLE IF NOT EXISTS `dieta` (
  `correo` varchar(70) NOT NULL,
  `dia` varchar(70) NOT NULL,
  `comida` varchar(70) NOT NULL,
  PRIMARY KEY (`correo`,`dia`,`comida`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `dieta`
--

INSERT INTO `dieta` (`correo`, `dia`, `comida`) VALUES
('ddanielhdz@gmail.com', 'Jueves', 'frijoles'),
('ddanielhdz@gmail.com', 'Jueves', 'frutas secaas'),
('ddanielhdz@gmail.com', 'Jueves', 'ser'),
('ddanielhdz@gmail.com', 'Lunes', 'fruta del pan'),
('ddanielhdz@gmail.com', 'Lunes', 'frutas secaas'),
('ddanielhdz@gmail.com', 'Lunes', 'manzana'),
('ddanielhdz@gmail.com', 'Martes', ''),
('ddanielhdz@gmail.com', 'Martes', 'frijoles'),
('ddanielhdz@gmail.com', 'Martes', 'ser'),
('derefer@fere', 'Lunes', 'manzana'),
('valv', 'Jueves', 'res'),
('valv', 'Lunes', 'frijoles'),
('valv', 'Lunes', 'ser'),
('valv', 'Martes', 'ser'),
('valv', 'Miércoles', 'res'),
('valv', 'Sábado', 'frijoles'),
('valv', 'Sábado', 'frutas secaas'),
('valv', 'Viernes', 'atún'),
('valv', 'Viernes', 'frutas secaas'),
('valv', 'Viernes', 'res');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usrs_data`
--

DROP TABLE IF EXISTS `usrs_data`;
CREATE TABLE IF NOT EXISTS `usrs_data` (
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

--
-- Volcado de datos para la tabla `usrs_data`
--

INSERT INTO `usrs_data` (`correo`, `nombre`, `apep`, `apem`, `telefono`, `nacimiento`, `direccion`, `sexo`, `peso`, `altura`, `alergias`) VALUES
('derefer@fere', 'fffafa', 'fifi', 'val', '23232', '1222', 'aca', 'Masculino', 12, '12', '34'),
('valv', 'brah', 'va', 'va', '3232', '1111', 'aca', 'Masculino', 122, '12', '12'),
('ddanielhdz@gmail.com', 'alisson', 'valverde', 'hernandez', '7778989', '1990', 'Calle Galaxias No. 19', 'Femenino', 70, '78', '2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usrs_login`
--

DROP TABLE IF EXISTS `usrs_login`;
CREATE TABLE IF NOT EXISTS `usrs_login` (
  `correo` varchar(50) NOT NULL,
  `psw` blob NOT NULL,
  `rol` char(3) NOT NULL,
  `pregunta` varchar(40) NOT NULL,
  `respuesta` varchar(30) NOT NULL,
  PRIMARY KEY (`correo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usrs_login`
--

INSERT INTO `usrs_login` (`correo`, `psw`, `rol`, `pregunta`, `respuesta`) VALUES
('valv', 0x08b65b1fd1a73c82d8965d26e4e60d3a, 'USR', '¿Cuál fue tu primer número?', '123'),
('ddanielhdz@gmail.com', 0xdb4dc03e610f09ec35502c6cfb082748, 'USR', '¿Cuál fue tu primer número?', 'Respuesta'),
('derefer@fere', 0xe55856ad234989761cf85ec2ada9144d, 'USR', '¿Cuál fue tu primer número?', '123'),
('jarek@mail.com', 0x6c3f65c7e937f2f968236baa9c590b55, 'ADM', 'Comida favorita', 'frijoles'),
('ddanielhdz@mail.com', 0x4e1032de32afccf1422cea9ba792d091, 'USR', 'Comida favorita', 'Respuesta'),
('ddanielhdz@cgmail.com', 0x4e1032de32afccf1422cea9ba792d091, 'USR', 'Comida favorita', 'Respuesta');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
