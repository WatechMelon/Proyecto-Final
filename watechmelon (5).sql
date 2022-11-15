-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-11-2022 a las 14:55:09
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `watechmelon`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asocia`
--

CREATE TABLE `asocia` (
  `Cultivo1` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `Cultivo2` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `asocia`
--

INSERT INTO `asocia` (`Cultivo1`, `Cultivo2`) VALUES
('Acelga', 'Lechuga'),
('Ajo', 'Lechuga'),
('Ajo', 'Remolacha'),
('Apio', 'Repollo'),
('Arvejas', 'Ajo'),
('Arvejas', 'Repollo'),
('Arvejas', 'Zanahoria'),
('Berenjena', 'Porotos'),
('Cebolla', 'Lechuga'),
('Cebolla', 'Remolacha'),
('Cebolla', 'Repollo'),
('Choclo', 'Acelga'),
('Choclo', 'Porotos'),
('Habas', 'Repollo'),
('Habas', 'Zanahoria'),
('Lechuga', 'Acelga'),
('Lechuga', 'Cebolla'),
('Lechuga', 'Remolacha'),
('Lechuga', 'Repollo'),
('Lechuga', 'Zanahoria'),
('Pimenton', 'Zanahoria'),
('PorotosVerdes', 'Choclo'),
('PorotosVerdes', 'Tomate'),
('Remolacha', 'Ajo'),
('Remolacha', 'Lechuga'),
('Remolacha', 'Repollo'),
('Tomate', 'Zanahoria'),
('Zanahoria', 'Lechuga'),
('Zanahoria', 'Repollo'),
('Zanahoria', 'Tomate');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `calendario`
--

CREATE TABLE `calendario` (
  `NombreCultivo` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `Tiempo_Cosecha` int(11) NOT NULL,
  `Tiempo_Trasplante` int(11) DEFAULT NULL,
  `Tiempo_Germinacion` int(11) DEFAULT NULL,
  `Siembra_Inicio` int(11) NOT NULL,
  `Siembra_Fin` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `calendario`
--

INSERT INTO `calendario` (`NombreCultivo`, `Tiempo_Cosecha`, `Tiempo_Trasplante`, `Tiempo_Germinacion`, `Siembra_Inicio`, `Siembra_Fin`) VALUES
('Acelga', 90, 40, 9, 1, 12),
('Aji', 90, NULL, NULL, 7, 8),
('Ajo', 180, NULL, NULL, 4, 8),
('Apio', 70, 70, 20, 1, 12),
('Arvejas', 90, NULL, 10, 5, 8),
('Berenjena', 90, 60, 10, 9, 12),
('Cebolla', 100, 20, 10, 8, 4),
('Cebollin', 100, 20, 10, 8, 2),
('Frutilla', 120, NULL, NULL, 4, 5),
('Habas', 90, NULL, NULL, 4, 6),
('Lechuga', 90, NULL, 8, 1, 12),
('Papa', 90, NULL, 40, 2, 9),
('Pimenton', 90, 30, 5, 7, 8),
('Porotos', 60, NULL, NULL, 8, 1),
('PorotosVerdes', 80, NULL, 8, 9, 1),
('Remolacha', 90, NULL, NULL, 8, 9),
('Repollo', 100, 40, 6, 1, 12),
('Tomate', 90, 60, 8, 8, 9),
('Zanahoria', 120, NULL, 15, 1, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clienteempresa`
--

CREATE TABLE `clienteempresa` (
  `RUT` int(11) NOT NULL,
  `Email` varchar(32) NOT NULL,
  `Pass` varchar(64) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `Calle` varchar(32) NOT NULL,
  `Barrio` varchar(32) NOT NULL,
  `Numero` int(11) NOT NULL,
  `Esquina` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `clienteempresa`
--

INSERT INTO `clienteempresa` (`RUT`, `Email`, `Pass`, `Telefono`, `Calle`, `Barrio`, `Numero`, `Esquina`) VALUES
(0, 'julio@gmail.com', '711383a59fda05336fd2ccf70c8059d1523eb41a', 92357876, 'Calle 5', 'Avellaneda', 2142, 'Asuncion'),
(123, 'prueba', '711383a59fda05336fd2ccf70c8059d1523eb41a', 9289323, 'prueba', 'prueba', 3223, 'prueba'),
(1223223, 'juan@gmail.com', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 9237743, 'Por ahí', 'Barros Blancos', 17, 'Ni idea y 3 cuartos'),
(2132123, 'purba', 'd5644e8105ad77c3c3324ba693e83d8fffd54950', 2321, 'HOLA', 'asdsad', 12312, 'asdsa'),
(5568222, 'pepito1234@gmail.com', '0f3fde0103dd44077c040215a2fabd09a097aecc', 92845675, 'Avenida 5', 'Flores', 1203, 'Ibañez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clienteterminal`
--

CREATE TABLE `clienteterminal` (
  `CI` varchar(9) NOT NULL,
  `Email` varchar(32) NOT NULL,
  `Pass` varchar(64) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `Barrio` varchar(32) NOT NULL,
  `Numero` int(11) NOT NULL,
  `Esquina` varchar(32) NOT NULL,
  `Calle` varchar(32) NOT NULL,
  `PrimerNombre` varchar(32) NOT NULL,
  `PrimerApellido` varchar(32) NOT NULL,
  `SegundoNombre` varchar(32) DEFAULT NULL,
  `SegundoApellido` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `clienteterminal`
--

INSERT INTO `clienteterminal` (`CI`, `Email`, `Pass`, `Telefono`, `Barrio`, `Numero`, `Esquina`, `Calle`, `PrimerNombre`, `PrimerApellido`, `SegundoNombre`, `SegundoApellido`) VALUES
('1234', 'prueba@gmail.com', '711383a59fda05336fd2ccf70c8059d1523eb41a', 9234234, 'prueba', 1101, 'pruebita', 'pruebita', 'prueba', 'prueba', 'prueba', 'prueba'),
('12345', 'lola@gmail.com', '711383a59fda05336fd2ccf70c8059d1523eb41a', 9277762, 'Maracana', 1102, 'Cachabacha', 'Avenida 2', 'Julio', 'Rodriguez', 'Jorge', 'Sanchez'),
('55683291', 'ivan@gmail.com', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 92377632, 'Cosobo', 14, 'Si', 'Matamorez', 'Ivan', 'Juarez', '', 'Rodriguez'),
('55987371', 'jorge1234@gmail.com', 'e516f979536994a14d9b0500bca3a1287b9ea9fe', 923333, 'Las Piedras', 1114, 'Blancas', 'Largavida', 'Julio', 'Suarez', 'Jorge', 'Rodriguez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cultivo`
--

CREATE TABLE `cultivo` (
  `NombreCultivo` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `Stock` int(11) DEFAULT NULL,
  `Precio` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `cultivo`
--

INSERT INTO `cultivo` (`NombreCultivo`, `Stock`, `Precio`) VALUES
('Acelga', 700, 64),
('Aji', 695, 200),
('Ajo', 700, 55),
('Apio', 700, 100),
('Arvejas', 700, 300),
('Berenjena', 700, 138),
('Cebolla', 700, 89),
('Cebollin', 700, 140),
('Choclo', 700, 186),
('Frutilla', 700, 300),
('Habas', 700, 154),
('Lechuga', 700, 150),
('Papa', 700, 49),
('Pimenton', 700, 300),
('Porotos', 700, 80),
('PorotosVerdes', 700, 125),
('Remolacha', 700, 100),
('Repollo', 700, 64),
('Tomate', 700, 130),
('Zanahoria', 700, 45);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entrega`
--

CREATE TABLE `entrega` (
  `NumPedido` int(11) NOT NULL,
  `FechaEntrega` date NOT NULL,
  `ID_Repartidor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esta`
--

CREATE TABLE `esta` (
  `NumPedido` int(11) NOT NULL,
  `FechaInicio` date NOT NULL,
  `ID_Estado` int(11) NOT NULL,
  `FechaFin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadopedido`
--

CREATE TABLE `estadopedido` (
  `ID_Estado` int(11) NOT NULL,
  `NombreEstado` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `estadopedido`
--

INSERT INTO `estadopedido` (`ID_Estado`, `NombreEstado`) VALUES
(0, 'Pedido Cancelado'),
(1, 'Esperando Aprobacion'),
(2, 'Armando el pedido'),
(3, 'Pedido Despachado'),
(4, 'En ruta'),
(5, 'Recibido'),
(6, 'No recibido');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `hace`
--

CREATE TABLE `hace` (
  `NumPedido` int(11) NOT NULL,
  `CantProducto` int(11) NOT NULL,
  `Producto` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `RUT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `hace`
--

INSERT INTO `hace` (`NumPedido`, `CantProducto`, `Producto`, `RUT`) VALUES
(2, 0, 'Lechuga', 0),
(3, 0, 'Lechuga', 0),
(4, 0, 'Lechuga', 0),
(5, 0, 'Lechuga', 0),
(10, 22, 'Lechuga', 0),
(17, 15, 'Lechuga', 0),
(17, 22, 'PorotosVerdes', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `he`
--

CREATE TABLE `he` (
  `ID_HE` int(11) NOT NULL,
  `Tamanio` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `he`
--

INSERT INTO `he` (`ID_HE`, `Tamanio`) VALUES
(0, 'Pequeña '),
(1, 'Pequeña '),
(2, 'Pequeña '),
(3, 'Mediana'),
(4, 'Mediana');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `NumPedido` int(11) NOT NULL,
  `MetodoPago` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `FechaEntrega` date NOT NULL,
  `FechaPedido` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`NumPedido`, `MetodoPago`, `FechaEntrega`, `FechaPedido`) VALUES
(1, 'Paypal', '2022-11-14', '2022-11-14'),
(2, 'Paypal', '2022-11-14', '2022-11-14'),
(3, 'Paypal', '2022-11-14', '2022-11-14'),
(4, 'Paypal', '2022-11-14', '2022-11-14'),
(5, 'Paypal', '2022-11-14', '2022-11-14'),
(6, 'Paypal', '2022-11-14', '2022-11-14'),
(7, 'Paypal', '2022-11-14', '2022-11-14'),
(8, 'Paypal', '2022-11-14', '2022-11-14'),
(9, 'Visa', '2022-11-14', '2022-11-14'),
(10, 'Paypal', '2022-11-14', '2022-11-14'),
(11, 'Paypal', '2022-11-14', '2022-11-14'),
(12, 'Paypal', '2022-11-14', '2022-11-14'),
(13, 'Paypal', '2022-11-14', '2022-11-14'),
(14, 'Paypal', '2022-11-14', '2022-11-14'),
(15, 'Paypal', '2022-11-14', '2022-11-14'),
(16, 'Paypal', '2022-11-14', '2022-11-14'),
(17, 'Visa', '2022-11-14', '2022-11-14'),
(18, 'Paypal', '2022-11-14', '2022-11-14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planta`
--

CREATE TABLE `planta` (
  `ID_HE` int(11) NOT NULL,
  `NombreCultivo` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `EstadoCultivo` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `MetaCultivos` int(11) NOT NULL,
  `FechaCultivo` date NOT NULL,
  `CantidadCosecha` int(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `planta`
--

INSERT INTO `planta` (`ID_HE`, `NombreCultivo`, `EstadoCultivo`, `MetaCultivos`, `FechaCultivo`, `CantidadCosecha`) VALUES
(0, 'Repollo  ', 'Vegetativo', 1200, '2022-11-11', 0),
(1, 'PorotosVerdes', 'Germinacion', 800, '2022-11-14', 0),
(2, 'Acelga   ', 'Plantula', 1200, '2022-11-14', 1300),
(2, 'Ajo      ', 'Vegetativo', 900, '2022-11-14', 900),
(2, 'Lechuga  ', 'Germinacion', 1500, '2022-11-14', 1400);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `realiza`
--

CREATE TABLE `realiza` (
  `NumPedido` int(11) NOT NULL,
  `Producto` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `CantProducto` int(11) NOT NULL,
  `CI` varchar(9) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repartidor`
--

CREATE TABLE `repartidor` (
  `ID_Repartidor` int(11) NOT NULL,
  `Contrasena` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `ID_Sucursal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `repartidor`
--

INSERT INTO `repartidor` (`ID_Repartidor`, `Contrasena`, `ID_Sucursal`) VALUES
(123, 'prueba', 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `seubica`
--

CREATE TABLE `seubica` (
  `ID_HE` int(11) NOT NULL,
  `ID_Sucursal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `subtotalempresa`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `subtotalempresa` (
`NumPedido` int(11)
,`Producto` varchar(30)
,`Precio` int(2)
,`CantProducto` int(11)
,`Subtotal` bigint(21)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `subtotalterminal`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `subtotalterminal` (
`NumPedido` int(11)
,`Producto` varchar(30)
,`Precio` int(2)
,`CantProducto` int(11)
,`Subtotal` bigint(21)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE `sucursal` (
  `ID_Sucursal` int(11) NOT NULL,
  `Barrio` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `Numero` int(11) NOT NULL,
  `Esquina` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `Calle` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `sucursal`
--

INSERT INTO `sucursal` (`ID_Sucursal`, `Barrio`, `Numero`, `Esquina`, `Calle`) VALUES
(15, 'Casavalle', 1120, 'Los Puerros', 'Avenida 4');

-- --------------------------------------------------------

--
-- Estructura para la vista `subtotalempresa`
--
DROP TABLE IF EXISTS `subtotalempresa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `subtotalempresa`  AS SELECT `hace`.`NumPedido` AS `NumPedido`, `hace`.`Producto` AS `Producto`, `cultivo`.`Precio` AS `Precio`, `hace`.`CantProducto` AS `CantProducto`, `hace`.`CantProducto`* `cultivo`.`Precio` AS `Subtotal` FROM (`cultivo` join `hace`) WHERE `cultivo`.`NombreCultivo` = `hace`.`Producto``Producto`  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `subtotalterminal`
--
DROP TABLE IF EXISTS `subtotalterminal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `subtotalterminal`  AS SELECT `realiza`.`NumPedido` AS `NumPedido`, `realiza`.`Producto` AS `Producto`, `cultivo`.`Precio` AS `Precio`, `realiza`.`CantProducto` AS `CantProducto`, `realiza`.`CantProducto`* `cultivo`.`Precio` AS `Subtotal` FROM (`cultivo` join `realiza`) WHERE `cultivo`.`NombreCultivo` = `realiza`.`Producto``Producto`  ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asocia`
--
ALTER TABLE `asocia`
  ADD PRIMARY KEY (`Cultivo1`,`Cultivo2`),
  ADD KEY `Asocia2` (`Cultivo2`);

--
-- Indices de la tabla `calendario`
--
ALTER TABLE `calendario`
  ADD PRIMARY KEY (`NombreCultivo`);

--
-- Indices de la tabla `clienteempresa`
--
ALTER TABLE `clienteempresa`
  ADD PRIMARY KEY (`RUT`);

--
-- Indices de la tabla `clienteterminal`
--
ALTER TABLE `clienteterminal`
  ADD PRIMARY KEY (`CI`);

--
-- Indices de la tabla `cultivo`
--
ALTER TABLE `cultivo`
  ADD PRIMARY KEY (`NombreCultivo`);

--
-- Indices de la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`NumPedido`,`FechaEntrega`),
  ADD KEY `ID_Repartidor` (`ID_Repartidor`);

--
-- Indices de la tabla `esta`
--
ALTER TABLE `esta`
  ADD PRIMARY KEY (`NumPedido`,`FechaInicio`),
  ADD KEY `ID_Estado` (`ID_Estado`);

--
-- Indices de la tabla `estadopedido`
--
ALTER TABLE `estadopedido`
  ADD PRIMARY KEY (`ID_Estado`,`NombreEstado`);

--
-- Indices de la tabla `hace`
--
ALTER TABLE `hace`
  ADD PRIMARY KEY (`NumPedido`,`Producto`),
  ADD KEY `RUT` (`RUT`),
  ADD KEY `FKNum` (`NumPedido`);

--
-- Indices de la tabla `he`
--
ALTER TABLE `he`
  ADD PRIMARY KEY (`ID_HE`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`NumPedido`);

--
-- Indices de la tabla `planta`
--
ALTER TABLE `planta`
  ADD PRIMARY KEY (`ID_HE`,`NombreCultivo`),
  ADD KEY `ID_HE` (`ID_HE`),
  ADD KEY `NombreCultivoFK` (`NombreCultivo`);

--
-- Indices de la tabla `realiza`
--
ALTER TABLE `realiza`
  ADD PRIMARY KEY (`NumPedido`,`Producto`),
  ADD KEY `NumPedido` (`NumPedido`),
  ADD KEY `CI` (`CI`);

--
-- Indices de la tabla `repartidor`
--
ALTER TABLE `repartidor`
  ADD PRIMARY KEY (`ID_Repartidor`),
  ADD KEY `ID_Sucursal` (`ID_Sucursal`);

--
-- Indices de la tabla `seubica`
--
ALTER TABLE `seubica`
  ADD PRIMARY KEY (`ID_HE`),
  ADD KEY `ID_Sucursal` (`ID_Sucursal`),
  ADD KEY `ID_HE` (`ID_HE`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD PRIMARY KEY (`ID_Sucursal`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asocia`
--
ALTER TABLE `asocia`
  ADD CONSTRAINT `Asocia1` FOREIGN KEY (`Cultivo1`) REFERENCES `cultivo` (`NombreCultivo`),
  ADD CONSTRAINT `Asocia2` FOREIGN KEY (`Cultivo2`) REFERENCES `cultivo` (`NombreCultivo`);

--
-- Filtros para la tabla `calendario`
--
ALTER TABLE `calendario`
  ADD CONSTRAINT `Calendario_ibfk_1` FOREIGN KEY (`NombreCultivo`) REFERENCES `cultivo` (`NombreCultivo`);

--
-- Filtros para la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `Entrega_ibfk_2` FOREIGN KEY (`ID_Repartidor`) REFERENCES `repartidor` (`ID_Repartidor`),
  ADD CONSTRAINT `Entrega_ibfk_3` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`);

--
-- Filtros para la tabla `esta`
--
ALTER TABLE `esta`
  ADD CONSTRAINT `Esta_ibfk_1` FOREIGN KEY (`ID_Estado`) REFERENCES `estadopedido` (`ID_Estado`),
  ADD CONSTRAINT `Esta_ibfk_2` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`);

--
-- Filtros para la tabla `hace`
--
ALTER TABLE `hace`
  ADD CONSTRAINT `FKNumPedido` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`);

--
-- Filtros para la tabla `planta`
--
ALTER TABLE `planta`
  ADD CONSTRAINT `FKID` FOREIGN KEY (`ID_HE`) REFERENCES `he` (`ID_HE`),
  ADD CONSTRAINT `Planta_ibfk_2` FOREIGN KEY (`NombreCultivo`) REFERENCES `cultivo` (`NombreCultivo`);

--
-- Filtros para la tabla `realiza`
--
ALTER TABLE `realiza`
  ADD CONSTRAINT `CIFK` FOREIGN KEY (`CI`) REFERENCES `clienteterminal` (`CI`),
  ADD CONSTRAINT `NumPedido` FOREIGN KEY (`NumPedido`) REFERENCES `pedido` (`NumPedido`);

--
-- Filtros para la tabla `repartidor`
--
ALTER TABLE `repartidor`
  ADD CONSTRAINT `FKSUCURSAL` FOREIGN KEY (`ID_Sucursal`) REFERENCES `sucursal` (`ID_Sucursal`);

--
-- Filtros para la tabla `seubica`
--
ALTER TABLE `seubica`
  ADD CONSTRAINT `FKHE` FOREIGN KEY (`ID_HE`) REFERENCES `he` (`ID_HE`),
  ADD CONSTRAINT `FkSucu` FOREIGN KEY (`ID_Sucursal`) REFERENCES `sucursal` (`ID_Sucursal`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
