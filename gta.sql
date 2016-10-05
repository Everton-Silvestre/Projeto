-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 26-Nov-2014 às 04:37
-- Versão do servidor: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gta`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `agen000`
--

CREATE TABLE IF NOT EXISTS `agen000` (
  `AgenCod` int(11) NOT NULL AUTO_INCREMENT,
  `AgenRazSoc` varchar(80) NOT NULL,
  `AgenNomFant` varchar(60) NOT NULL,
  `AgenCnpj` bigint(14) unsigned zerofill NOT NULL,
  `AgenEnd` varchar(80) NOT NULL,
  `AgenBairro` varchar(15) NOT NULL,
  `AgenCid` varchar(60) NOT NULL,
  `AgenTel` bigint(12) NOT NULL,
  `AgenRespCad` varchar(40) NOT NULL,
  `AgenCep` bigint(8) unsigned zerofill NOT NULL,
  `AgenEst` varchar(2) NOT NULL,
  `AgenEmail` varchar(60) NOT NULL,
  `AgenBan` varchar(50) NOT NULL,
  `AgenFavo` varchar(50) NOT NULL,
  `AgenNro` bigint(10) unsigned zerofill NOT NULL,
  `AgenContCor` bigint(13) unsigned zerofill NOT NULL,
  `AgenNomResp` varchar(50) NOT NULL,
  `AgenRgResp` varchar(20) NOT NULL,
  `AgenNomSuple` varchar(50) NOT NULL,
  `AgenRgSuple` varchar(20) NOT NULL,
  PRIMARY KEY (`AgenCod`),
  UNIQUE KEY `AgenCnpj` (`AgenCnpj`),
  UNIQUE KEY `AgenEmail` (`AgenEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `atributos`
--

CREATE TABLE IF NOT EXISTS `atributos` (
  `AtriCod` int(11) NOT NULL AUTO_INCREMENT,
  `PlanCod` int(11) NOT NULL,
  `AtriValor` decimal(10,2) NOT NULL,
  `AtriDescri` varchar(50) NOT NULL,
  PRIMARY KEY (`AtriCod`),
  KEY `PlanCod` (`PlanCod`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=284 ;

--
-- Extraindo dados da tabela `atributos`
--

INSERT INTO `atributos` (`AtriCod`, `PlanCod`, `AtriValor`, `AtriDescri`) VALUES
(1, 1, '25.00', 'até 5 dias'),
(2, 1, '34.00', 'de 6 a 8 dias'),
(5, 2, '41.00', 'até 5 dias'),
(6, 2, '44.00', 'de 6 a 8 dias'),
(11, 1, '43.00', 'de 9 a 10 dias'),
(12, 1, '46.00', 'de 11 a 16 dias'),
(13, 1, '53.00', 'de 17 a 22 dias	'),
(14, 1, '59.00', 'de 23 a 30 dias'),
(17, 1, '62.00', 'de 31 a 31 dias'),
(18, 1, '73.00', 'de 32 a 45 dias'),
(19, 1, '95.00', 'de 46 a 60 dias'),
(20, 1, '98.00', 'de 61 a 61 dias'),
(22, 1, '101.00', 'de 62 a 62 dias'),
(23, 1, '124.00', 'de 63 a 90 dias'),
(24, 1, '127.00', 'de 91 a 91 dias'),
(25, 1, '130.00', 'de 92 a 92 dias	'),
(26, 1, '133.00', 'de 93 a 93 dias'),
(37, 1, '186.00', 'de 94 a 120 dias'),
(38, 1, '189.00', 'de 121 a 121 dias'),
(39, 1, '192.00', 'de 122 a 122 dias'),
(40, 1, '195.00', 'de 123 a 123 dias'),
(41, 1, '198.00', 'de 124 a 124 dias'),
(42, 1, '310.00', 'de 125 a 180 dias'),
(43, 1, '313.00', 'de 181 a 181 dias'),
(44, 1, '414.00', 'de 182 a 240 dias'),
(45, 1, '586.00', 'Anual'),
(55, 2, '46.00', 'de 9 a 10 dias'),
(56, 2, '55.00', 'de 11 a 16 dias'),
(57, 2, '62.00', 'de 17 a 22 dias'),
(58, 2, '65.00', 'de 23 a 30 dias'),
(59, 2, '69.00', 'de 31 a 31 dias'),
(60, 2, '77.00', 'de 32 a 45 dias'),
(61, 2, '119.00', 'de 46 a 60 dias'),
(62, 2, '123.00', 'de 61 a 61 dias'),
(63, 2, '127.00', 'de 62 a 62 dias'),
(64, 2, '175.00', 'de 63 a 90 dias'),
(65, 2, '179.00', 'de 91 a 91 dias'),
(66, 2, '183.00', 'de 92 a 92 dias'),
(67, 2, '187.00', 'de 93 a 93 dias'),
(68, 2, '247.00', 'de 94 a 120 dias'),
(69, 2, '251.00', 'de 121 a 121 dias'),
(85, 2, '255.00', 'de 122 a 122 dias'),
(86, 2, '259.00', 'de 123 a 123 dias'),
(87, 2, '263.00', 'de 124 a 124 dias'),
(88, 2, '411.00', 'de 125 a 180 dias'),
(89, 2, '546.00', 'de 181 a 240 dias'),
(90, 2, '697.00', 'Anual'),
(99, 3, '13.00', 'até 8 dias'),
(100, 3, '17.00', 'de 9 a 15 dias'),
(101, 3, '23.00', 'de 16 a 21 dias'),
(102, 3, '1.50', 'Dia adicional'),
(107, 4, '16.00', 'até 8 dias'),
(108, 4, '23.00', 'de 9 a 15 dias'),
(109, 4, '33.00', 'de 16 a 21 dias'),
(110, 4, '1.90', 'Dia adicional'),
(115, 5, '21.00', 'até 5 dias'),
(116, 5, '28.00', 'de 6 a 8 dias'),
(117, 5, '30.00', 'de 9 a 10 dias'),
(118, 5, '44.00', 'de 11 a 16 dias'),
(123, 6, '15.00', 'até 5 dias'),
(124, 6, '17.00', 'de 6 a 6 dias'),
(125, 6, '20.00', 'de 7 a 7 dias'),
(126, 6, '23.00', 'de 8 a 8 dias'),
(127, 6, '25.00', 'de 9 a 9 dias'),
(128, 6, '27.00', 'de 10 a 10 dias	'),
(129, 6, '31.00', 'de 11 a 16 dias	'),
(137, 7, '55.00', 'até 7 dias'),
(138, 7, '8.00', 'Dia adicional'),
(141, 8, '58.00', 'até 5 dias'),
(143, 8, '74.00', 'de 6 a 8 dias'),
(144, 8, '94.00', 'de 9 a 10 dias'),
(145, 8, '132.00', 'de 16 a 16 dias'),
(146, 8, '158.00', 'de 22 a 22 dias'),
(147, 8, '190.00', 'de 30 a 30 dias	'),
(148, 8, '253.00', 'de 45 a 45 dias'),
(149, 8, '315.00', 'de 59 a 60 dias'),
(150, 8, '442.00', 'de 89 a 90 dias'),
(159, 9, '25.00', 'até 5 dias'),
(160, 9, '34.00', 'de 6 a 8 dias'),
(161, 9, '43.00', 'de 9 a 10 dias'),
(162, 9, '46.00', 'de 11 a 16 dias'),
(163, 9, '53.00', 'de 17 a 22 dias'),
(164, 9, '59.00', 'de 23 a 30 dias'),
(165, 9, '73.00', 'de 31 a 45 dias'),
(166, 9, '95.00', 'de 46 a 60 dias'),
(167, 9, '124.00', 'de 61 a 90 dias'),
(168, 9, '186.00', 'de 91 a 120 dias'),
(169, 9, '310.00', 'de 121 a 180 dias'),
(170, 9, '414.00', 'de 181 a 240 dias'),
(171, 9, '586.00', 'Anual'),
(185, 10, '39.00', 'até 5 dias'),
(186, 10, '56.00', 'de 6 a 8 dias'),
(187, 10, '68.00', 'de 9 a 10 dias'),
(188, 10, '86.00', 'de 11 a 16 dias'),
(189, 10, '108.00', 'de 17 a 22 dias'),
(190, 10, '140.00', 'de 23 a 30 dias'),
(191, 10, '204.00', 'de 31 a 45 dias'),
(192, 10, '252.00', 'de 46 a 60 dias'),
(193, 10, '312.00', 'de 61 a 90 dias'),
(194, 10, '440.00', 'de 91 a 120 dias'),
(205, 10, '682.00', 'de 121 a 180 dias'),
(206, 10, '1027.00', 'de 181 a 240 dias'),
(207, 10, '1535.00', 'Anual'),
(211, 11, '100.00', 'até 30 dias'),
(212, 11, '210.00', 'de 31 a 60 dias	'),
(213, 11, '315.00', 'de 61 a 90 dias'),
(214, 11, '388.00', 'de 91 a 120 dias	'),
(215, 11, '478.00', 'de 121 a 150 dias'),
(216, 11, '630.00', 'de 151 a 180 dias'),
(217, 11, '662.00', 'de 181 a 210 dias'),
(218, 11, '748.00', 'de 211 a 240 dias'),
(219, 11, '844.00', 'de 241 a 270 dias'),
(220, 11, '941.00', 'de 271 a 300 dias'),
(221, 11, '1029.00', 'de 301 a 330 dias'),
(222, 11, '1200.00', 'de 366 a 390 dias'),
(223, 11, '1280.00', 'de 391 a 420 dias'),
(224, 11, '1360.00', 'de 421 a 450 dias'),
(225, 11, '1530.00', 'de 451 a 480 dias'),
(241, 11, '1630.00', 'de 481 a 510 dias'),
(242, 11, '1730.00', 'de 511 a 545 dias'),
(245, 12, '144.00', 'até 30 dias'),
(246, 12, '236.00', 'de 31 a 60 dias'),
(247, 12, '345.00', 'de 61 a 90 dias'),
(248, 12, '422.00', 'de 91 a 120 dias'),
(249, 12, '536.00', 'de 121 a 150 dias'),
(250, 12, '628.00', 'de 151 a 180 dias'),
(251, 12, '710.00', 'de 181 a 210 dias'),
(252, 12, '798.00', 'de 211 a 240 dias	'),
(253, 12, '896.00', 'de 241 a 270 dias'),
(254, 12, '990.00', 'de 271 a 300 dias'),
(255, 12, '1090.00', 'de 301 a 330 dias'),
(256, 12, '1250.00', 'de 366 a 395 dias'),
(257, 12, '1350.00', 'de 396 a 425 dias'),
(258, 12, '1420.00', 'de 426 a 455 dias'),
(259, 12, '1580.00', 'de 456 a 485 dias'),
(260, 12, '1680.00', 'de 486 a 515 dias'),
(261, 12, '1780.00', 'de 516 a 545 dias'),
(279, 13, '280.00', 'Anual'),
(281, 14, '800.00', 'Anual'),
(283, 8, '4.40', 'Dia adicional');

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes000`
--

CREATE TABLE IF NOT EXISTS `clientes000` (
  `CliCod` int(11) NOT NULL AUTO_INCREMENT,
  `CliNome` varchar(60) NOT NULL,
  `CliEnd` varchar(60) NOT NULL,
  `CliEndNro` int(11) NOT NULL,
  `CliTel` bigint(10) unsigned zerofill NOT NULL,
  `CliCpf` bigint(11) unsigned zerofill NOT NULL,
  `CliRg` bigint(9) unsigned zerofill NOT NULL,
  `CliCid` varchar(40) NOT NULL,
  `CliEst` varchar(2) NOT NULL,
  `CliEmail` varchar(80) NOT NULL,
  `CliCep` bigint(20) unsigned zerofill NOT NULL,
  `CliBairro` varchar(40) NOT NULL,
  `CliBan` varchar(40) NOT NULL,
  `CliFavo` varchar(40) NOT NULL,
  `CliAgen` bigint(20) NOT NULL,
  `CliCorren` bigint(20) NOT NULL,
  PRIMARY KEY (`CliCod`),
  UNIQUE KEY `CliCpf` (`CliCpf`),
  UNIQUE KEY `CliEmail` (`CliEmail`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=42 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `controlelog`
--

CREATE TABLE IF NOT EXISTS `controlelog` (
  `ConCod` int(11) NOT NULL AUTO_INCREMENT,
  `ConLogin` varchar(50) NOT NULL,
  `ConSenha` varchar(20) NOT NULL,
  `ConData` date NOT NULL,
  PRIMARY KEY (`ConCod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `planos000`
--

CREATE TABLE IF NOT EXISTS `planos000` (
  `PlanCod` int(11) NOT NULL AUTO_INCREMENT,
  `PlanNome` varchar(50) NOT NULL,
  `PlanCate` varchar(50) NOT NULL,
  PRIMARY KEY (`PlanCod`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Extraindo dados da tabela `planos000`
--

INSERT INTO `planos000` (`PlanCod`, `PlanNome`, `PlanCate`) VALUES
(1, 'BRONZE', 'INTERNACIONAL'),
(2, 'RUBI', 'INTERNACIONAL'),
(3, 'PLUS', 'NACIONAIS'),
(4, 'VIP', 'NACIONAIS'),
(5, 'BRONZE MARITIMO', 'MARITIMO'),
(6, 'MERCOSUL MARITIMO', 'MARITIMO'),
(7, 'BRONZE NEVE', 'PRATICA DE ESPORTES'),
(8, 'ALL SPORTS', 'PRATICA DE ESPORTES'),
(9, 'RECEPTIVO BRONZE', 'RECEPTIVO'),
(10, 'RECEPTIVO UNION', 'RECEPTIVO'),
(11, 'STUDENT FULL', 'STUDENT'),
(12, 'STUDENT GLOBAL', 'STUDENT'),
(13, 'EURO BUSINESS', 'CORPORATIVO'),
(14, 'TITANIUM', 'CORPORATIVO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario000`
--

CREATE TABLE IF NOT EXISTS `usuario000` (
  `UsuCod` int(11) NOT NULL AUTO_INCREMENT,
  `Agen_Cod` int(11) NOT NULL,
  `UsuLog` varchar(50) NOT NULL,
  `UsuSen` varchar(20) NOT NULL,
  `UsuData` date NOT NULL,
  `UsuNivel` varchar(20) NOT NULL,
  PRIMARY KEY (`UsuCod`),
  UNIQUE KEY `UsuSen` (`UsuSen`),
  KEY `Agen_Cod` (`Agen_Cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario001`
--

CREATE TABLE IF NOT EXISTS `usuario001` (
  `CodUsu` int(11) NOT NULL AUTO_INCREMENT,
  `CodCli` int(11) NOT NULL,
  `UsuLog` varchar(50) NOT NULL,
  `UsuSenha` varchar(50) NOT NULL,
  `UsuData` date NOT NULL,
  PRIMARY KEY (`CodUsu`),
  UNIQUE KEY `UsuSenha` (`UsuSenha`),
  KEY `CodCli` (`CodCli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `voucher000`
--

CREATE TABLE IF NOT EXISTS `voucher000` (
  `VouCod` int(11) NOT NULL AUTO_INCREMENT,
  `AgenCod` int(11) NOT NULL,
  `PlanCod` int(11) NOT NULL,
  `VouDadosAtu` varchar(10) NOT NULL,
  `VouDataIni` date NOT NULL,
  `VouDias` varchar(20) NOT NULL,
  `VouQuantPess` int(11) NOT NULL,
  `VouValReal` decimal(10,3) NOT NULL,
  `VouValDolar` decimal(10,3) NOT NULL,
  PRIMARY KEY (`VouCod`),
  KEY `AgenCod` (`AgenCod`),
  KEY `PlanCod` (`PlanCod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `voucher001`
--

CREATE TABLE IF NOT EXISTS `voucher001` (
  `VouCod` int(11) NOT NULL AUTO_INCREMENT,
  `CliCod` int(11) NOT NULL,
  `PlanCod` int(11) NOT NULL,
  `VouDias` varchar(20) NOT NULL,
  `VouQuantPess` int(11) NOT NULL,
  `VouDataIni` date NOT NULL,
  `VouDadosAtu` varchar(10) NOT NULL,
  `VouValReal` decimal(10,3) NOT NULL,
  `VouValDolar` decimal(10,3) NOT NULL,
  PRIMARY KEY (`VouCod`),
  KEY `CodCli` (`CliCod`),
  KEY `PlanCod` (`PlanCod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `atributos`
--
ALTER TABLE `atributos`
  ADD CONSTRAINT `FK_Planos` FOREIGN KEY (`PlanCod`) REFERENCES `planos000` (`PlanCod`);

--
-- Limitadores para a tabela `usuario000`
--
ALTER TABLE `usuario000`
  ADD CONSTRAINT `FK_Agencia` FOREIGN KEY (`Agen_Cod`) REFERENCES `agen000` (`AgenCod`);

--
-- Limitadores para a tabela `usuario001`
--
ALTER TABLE `usuario001`
  ADD CONSTRAINT `FK_Cliente` FOREIGN KEY (`CodCli`) REFERENCES `clientes000` (`CliCod`);

--
-- Limitadores para a tabela `voucher000`
--
ALTER TABLE `voucher000`
  ADD CONSTRAINT `FK_AgenCod` FOREIGN KEY (`AgenCod`) REFERENCES `agen000` (`AgenCod`),
  ADD CONSTRAINT `FK_Vou_Plan` FOREIGN KEY (`PlanCod`) REFERENCES `planos000` (`PlanCod`);

--
-- Limitadores para a tabela `voucher001`
--
ALTER TABLE `voucher001`
  ADD CONSTRAINT `FK_CliCod` FOREIGN KEY (`CliCod`) REFERENCES `clientes000` (`CliCod`),
  ADD CONSTRAINT `FK_PlanCod` FOREIGN KEY (`PlanCod`) REFERENCES `planos000` (`PlanCod`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
