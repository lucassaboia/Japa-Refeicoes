-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 18-Out-2020 às 22:47
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdjapapito2`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbfuncionariojp`
--

DROP TABLE IF EXISTS `tbfuncionariojp`;
CREATE TABLE IF NOT EXISTS `tbfuncionariojp` (
  `idfuncionario` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `email` text NOT NULL,
  `genero` varchar(20) NOT NULL,
  `salario` varchar(30) NOT NULL,
  `endereco` text NOT NULL,
  `telefone` varchar(40) NOT NULL,
  `cpf` varchar(40) NOT NULL,
  `nascimento` varchar(40) NOT NULL,
  `admissao` varchar(40) NOT NULL,
  `cargo` varchar(40) NOT NULL,
  `nivel` int NOT NULL,
  PRIMARY KEY (`idfuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbfuncionariojp`
--

INSERT INTO `tbfuncionariojp` (`idfuncionario`, `nome`, `email`, `genero`, `salario`, `endereco`, `telefone`, `cpf`, `nascimento`, `admissao`, `cargo`, `nivel`) VALUES
(19, 'admin', 'admin@gmail.com', 'MASCULINO', 'R$ 1.300.00', 'Dono', '(21) 9741-15699', 'admin', '12/12/2012', '15/11/2017', 'CEO', 3),
(20, 'Lucas Sabóia', 'lucas.saboia54@gmail.com', 'MASCULINO', 'R$ 5.400,00', 'Rua Mercúrio 500, RJ', '(21) 9684-93203', '335-039-100-18', '02/02/2004', '06/10/2020', 'Gerente', 1),
(21, 'Thauan Rafael', 'thauanrafael@gmail.com', 'MASCULINO', 'R$ 3.000,00', 'Rua Mercúrio 200, RJ', '(21) 1111-11111', '625-142-840-66', '05/02/2005', '06/01/2020', 'Gerente', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbitenspedido`
--

DROP TABLE IF EXISTS `tbitenspedido`;
CREATE TABLE IF NOT EXISTS `tbitenspedido` (
  `iditempedido` int NOT NULL AUTO_INCREMENT,
  `idpedido` int NOT NULL,
  `codigo` int NOT NULL,
  `quantidade` int NOT NULL,
  `valor` double NOT NULL,
  PRIMARY KEY (`iditempedido`),
  KEY `idpedido` (`idpedido`),
  KEY `codigo` (`codigo`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbitenspedido`
--

INSERT INTO `tbitenspedido` (`iditempedido`, `idpedido`, `codigo`, `quantidade`, `valor`) VALUES
(1, 1, 34, 3, 36),
(2, 1, 35, 4, 32),
(5, 4, 34, 2, 24),
(6, 4, 35, 1, 8),
(7, 4, 35, 2, 16),
(8, 5, 35, 3, 24),
(9, 6, 35, 2, 16);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbpedidosjp`
--

DROP TABLE IF EXISTS `tbpedidosjp`;
CREATE TABLE IF NOT EXISTS `tbpedidosjp` (
  `idpedido` int NOT NULL AUTO_INCREMENT,
  `cliente` varchar(30) NOT NULL,
  `valortotal` double NOT NULL,
  `data` varchar(20) NOT NULL,
  `status` varchar(20) NOT NULL,
  PRIMARY KEY (`idpedido`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbpedidosjp`
--

INSERT INTO `tbpedidosjp` (`idpedido`, `cliente`, `valortotal`, `data`, `status`) VALUES
(1, 'Thauan', 68, '18/10/2020', 'Ativo'),
(4, 'zapzap', 48, '18/10/2020', 'Ativo'),
(5, 'lula', 24, '18/10/2020', 'Ativo'),
(6, 'goku', 16, '18/10/2020', 'Ativo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbprodutosjp`
--

DROP TABLE IF EXISTS `tbprodutosjp`;
CREATE TABLE IF NOT EXISTS `tbprodutosjp` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(30) NOT NULL,
  `marca` varchar(30) NOT NULL,
  `tipo` varchar(30) NOT NULL,
  `categoria` varchar(30) NOT NULL,
  `subcategoria` varchar(30) NOT NULL,
  `estoque` varchar(10) NOT NULL,
  `custo` varchar(20) NOT NULL,
  `venda` varchar(20) NOT NULL,
  `lucro` varchar(20) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbprodutosjp`
--

INSERT INTO `tbprodutosjp` (`codigo`, `descricao`, `marca`, `tipo`, `categoria`, `subcategoria`, `estoque`, `custo`, `venda`, `lucro`) VALUES
(34, 'Coca-Cola', 'JAPAPITO DELIVERY\'S', 'UNIDADE', 'BEBIDAS', 'REFRIGERANTES', '300', '5', '12', 'R$ 7,00'),
(35, 'Arroz Doce', 'JAPAPITO DELIVERY\'S', 'UNIDADE', 'REFEIÇÕES', 'ARROZ', '200', '4', '8', 'R$ 4,00');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tbitenspedido`
--
ALTER TABLE `tbitenspedido`
  ADD CONSTRAINT `tbitenspedido_ibfk_1` FOREIGN KEY (`idpedido`) REFERENCES `tbpedidosjp` (`idpedido`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbitenspedido_ibfk_2` FOREIGN KEY (`codigo`) REFERENCES `tbprodutosjp` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
