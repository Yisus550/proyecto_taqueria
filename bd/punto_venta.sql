-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-04-2024 a las 02:11:47
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `punto_venta`
--

CREATE DATABASE IF NOT EXISTS `punto_venta`;
USE `punto_venta`;

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(60) NOT NULL,
  `apellido_paterno` varchar(30) NOT NULL,
  `apellido_materno` varchar(30) NOT NULL,
  `correo` varchar(80) NOT NULL CHECK (`correo` regexp '^[^@]+@[^@]+\\.[^@]{2,}$'),
  `usuario` varchar(30) NOT NULL,
  `contrasena` varchar(24) NOT NULL,
  `fecha_registro` datetime NOT NULL,
  `perfil` varchar(20) NOT NULL,
  `estatus` int(1) NOT NULL,
  `telefono` varchar(10) NOT NULL CHECK (`telefono` regexp '^[0-9]{10}'),
  `foto` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `apellido_paterno`, `apellido_materno`, `correo`, `usuario`, `contrasena`, `fecha_registro`, `perfil`, `estatus`, `telefono`, `foto`) VALUES
(1, 'Jesus', 'Romero', 'Arvizu', 'jesus@ues.mx', 'Admin', 'admin123', '2024-03-11 23:49:09', 'Admin', 1, '6621112233', NULL),
(2, 'Kenai', 'Graff', 'Moreno', 'kenai@ues.mx', 'kenai', 'kenai123', '2024-03-11 23:49:09', 'Usuario', 1, '6629998877', NULL);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD UNIQUE KEY `id` (`id`),
  ADD UNIQUE KEY `correo` (`correo`),
  ADD UNIQUE KEY `usuario` (`usuario`),
  ADD UNIQUE KEY `telefono` (`telefono`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
