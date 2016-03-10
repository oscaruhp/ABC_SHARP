/*
Navicat MySQL Data Transfer

Source Server         : pruebaMysql
Source Server Version : 50623
Source Host           : 37.187.57.48:3306
Source Database       : develote_cotizador

Target Server Type    : MYSQL
Target Server Version : 50623
File Encoding         : 65001

Date: 2016-03-10 12:45:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for Alumnos
-- ----------------------------
DROP TABLE IF EXISTS `Alumnos`;
CREATE TABLE `Alumnos` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Matricula` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of Alumnos
-- ----------------------------
INSERT INTO `Alumnos` VALUES ('2', 'Oscar', '090789');
INSERT INTO `Alumnos` VALUES ('3', 'Pedro', '8090');
INSERT INTO `Alumnos` VALUES ('4', 'Marisa', '9080009');
INSERT INTO `Alumnos` VALUES ('1', 'Lola', '090899');
INSERT INTO `Alumnos` VALUES ('10', 'Lolita', '08998');
INSERT INTO `Alumnos` VALUES ('11', 'Pepe', '777123498');
INSERT INTO `Alumnos` VALUES ('5', 'Oscar', '454545');
INSERT INTO `Alumnos` VALUES ('14', 'Oscar', '096762');
INSERT INTO `Alumnos` VALUES ('15', 'Lola', '998ioi');
INSERT INTO `Alumnos` VALUES ('16', 'Lolita', '8iuiu');
INSERT INTO `Alumnos` VALUES ('17', 'Lolita', '8iuiu');
INSERT INTO `Alumnos` VALUES ('18', 'Luis', '777');
INSERT INTO `Alumnos` VALUES ('19', 'rich', '143214342');
INSERT INTO `Alumnos` VALUES ('20', 'k9999', '999');
INSERT INTO `Alumnos` VALUES ('21', 'Calamardo', '123456789');
INSERT INTO `Alumnos` VALUES ('27', 'manu', '24226262');
INSERT INTO `Alumnos` VALUES ('28', 'Cinemex', '010390');
INSERT INTO `Alumnos` VALUES ('29', 'dsf', '5242');
INSERT INTO `Alumnos` VALUES ('30', 'Jose Luis', '1245k');
INSERT INTO `Alumnos` VALUES ('31', 'Simnona la mona', '14536');
INSERT INTO `Alumnos` VALUES ('32', 'lokillo', '325945');
INSERT INTO `Alumnos` VALUES ('33', '0', 'Neko');
INSERT INTO `Alumnos` VALUES ('34', '43', 'dfg');
INSERT INTO `Alumnos` VALUES ('35', '0', 'Debora');
INSERT INTO `Alumnos` VALUES ('36', 'Debora Mesa Caveza', '417528639');

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Clave` varchar(255) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Descripcion` text NOT NULL,
  `Precio` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of productos
-- ----------------------------
INSERT INTO `productos` VALUES ('1', '4451-X', 'Cisco 4000 ', 'Cisco 4000 Series Integrated Services Router\n\nCisco IOS XE Operating System\n1-rack-unit (RU) or 2RU form factor\nUp to 2 Gbps of throughput\nUp to 3 network interface module slots\nUp to 2 service module slots\nUp to 4 integrated 10/100/1000 Ethernet ports\nUp to 8 CPU core integrated server modules', '15000');
INSERT INTO `productos` VALUES ('2', '810S', 'Smallest Cisco Fixed ISR', '810 Series (Smallest Cisco Fixed ISR)', '2000');
INSERT INTO `productos` VALUES ('3', '310RM78898', 'FalgsShip 600', 'Basic features, security performance, and connectivity for teleworkers and small branch offices of 10 users or fewer', '10000');
INSERT INTO `productos` VALUES ('8', '0AsR', 'Coca-Cola', 'Refresco', '9.00');
