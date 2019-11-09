

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


CREATE TABLE IF NOT EXISTS `employees` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `salary` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;



INSERT INTO `employees` (`id`, `name`, `address`, `salary`) VALUES
(1, 'Samuel Encarnacion', 'el brisal, santo domingo', 12000),
(2, 'Keila rosario', 'sabana larga, santo domingo', 8506),
(3, 'Hector de la rosa', '17, los minas , santo domingo', 500000);

