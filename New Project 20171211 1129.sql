-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema ebulletindb
--

CREATE DATABASE IF NOT EXISTS ebulletindb;
USE ebulletindb;

--
-- Definition of table `tbla1`
--

DROP TABLE IF EXISTS `tbla1`;
CREATE TABLE `tbla1` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbla1`
--

/*!40000 ALTER TABLE `tbla1` DISABLE KEYS */;
INSERT INTO `tbla1` (`id`,`msg1`) VALUES 
 (1,'gggg'),
 (2,'ffff'),
 (3,'xcvxcvcxvcxvcxv'),
 (4,'kkkfkf'),
 (5,'thisisiss');
/*!40000 ALTER TABLE `tbla1` ENABLE KEYS */;


--
-- Definition of table `tbla2`
--

DROP TABLE IF EXISTS `tbla2`;
CREATE TABLE `tbla2` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbla2`
--

/*!40000 ALTER TABLE `tbla2` DISABLE KEYS */;
INSERT INTO `tbla2` (`id`,`msg1`) VALUES 
 (1,'xcvxcvcxvcxvcxv'),
 (2,'BLOOD'),
 (3,'hjhjhjh');
/*!40000 ALTER TABLE `tbla2` ENABLE KEYS */;


--
-- Definition of table `tbla3`
--

DROP TABLE IF EXISTS `tbla3`;
CREATE TABLE `tbla3` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbla3`
--

/*!40000 ALTER TABLE `tbla3` DISABLE KEYS */;
INSERT INTO `tbla3` (`id`,`msg1`) VALUES 
 (1,'BLOODSSS');
/*!40000 ALTER TABLE `tbla3` ENABLE KEYS */;


--
-- Definition of table `tbla4`
--

DROP TABLE IF EXISTS `tbla4`;
CREATE TABLE `tbla4` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbla4`
--

/*!40000 ALTER TABLE `tbla4` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbla4` ENABLE KEYS */;


--
-- Definition of table `tbla5`
--

DROP TABLE IF EXISTS `tbla5`;
CREATE TABLE `tbla5` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbla5`
--

/*!40000 ALTER TABLE `tbla5` DISABLE KEYS */;
INSERT INTO `tbla5` (`id`,`msg1`) VALUES 
 (1,'fggfgfgf');
/*!40000 ALTER TABLE `tbla5` ENABLE KEYS */;


--
-- Definition of table `tblannouncement`
--

DROP TABLE IF EXISTS `tblannouncement`;
CREATE TABLE `tblannouncement` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `message` varchar(500) default NULL,
  `dateentry` varchar(500) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblannouncement`
--

/*!40000 ALTER TABLE `tblannouncement` DISABLE KEYS */;
INSERT INTO `tblannouncement` (`id`,`message`,`dateentry`) VALUES 
 (1,'[ANNOUNCEMENT]\r\n Test123','October 16, 2015'),
 (2,'[ANNOUNCEMENT]\r\n Test1234','October 16, 2015'),
 (3,'test','October 16, 2015'),
 (4,'233','October 16, 2015'),
 (5,'sdfsdf','October 16, 2015'),
 (6,'rywrywywrywr','October 16, 2015'),
 (7,'23523','October 16, 2015'),
 (8,'uykkf','October 16, 2015'),
 (9,'dsfsd','October 16, 2015'),
 (10,'denver','October 16, 2015'),
 (11,'joseph','October 16, 2015'),
 (12,'asdadds','October 16, 2015'),
 (13,'denverg','October 16, 2015'),
 (14,'hsdhshs','October 16, 2015'),
 (15,'ytfjhhgjhg','October 16, 2015'),
 (16,'mnvbvmnbm','October 16, 2015'),
 (17,'.;;.,p,;','October 16, 2015'),
 (18,'There will be no classes on Friday [October 24, 2015]','October 18, 2015'),
 (19,'TEST','October 18, 2015'),
 (20,'Test123','October 18, 2015'),
 (21,'Testing Announcement 1','October 18, 2015'),
 (22,'Testing Announcement 2','October 18, 2015'),
 (23,'Testing Announcement 3','October 18, 2015'),
 (24,'P20.00 prepaid credits was loaded to ur mobile# 09156992805 by 09956911158. Trace No','September 17, 2017');
/*!40000 ALTER TABLE `tblannouncement` ENABLE KEYS */;


--
-- Definition of table `tblb1`
--

DROP TABLE IF EXISTS `tblb1`;
CREATE TABLE `tblb1` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `img1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblb1`
--

/*!40000 ALTER TABLE `tblb1` DISABLE KEYS */;
INSERT INTO `tblb1` (`id`,`img1`) VALUES 
 (1,'masterentry.png');
/*!40000 ALTER TABLE `tblb1` ENABLE KEYS */;


--
-- Definition of table `tblb2`
--

DROP TABLE IF EXISTS `tblb2`;
CREATE TABLE `tblb2` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `img1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblb2`
--

/*!40000 ALTER TABLE `tblb2` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblb2` ENABLE KEYS */;


--
-- Definition of table `tblb3`
--

DROP TABLE IF EXISTS `tblb3`;
CREATE TABLE `tblb3` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `img1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblb3`
--

/*!40000 ALTER TABLE `tblb3` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblb3` ENABLE KEYS */;


--
-- Definition of table `tblb4`
--

DROP TABLE IF EXISTS `tblb4`;
CREATE TABLE `tblb4` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `img1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblb4`
--

/*!40000 ALTER TABLE `tblb4` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblb4` ENABLE KEYS */;


--
-- Definition of table `tblb5`
--

DROP TABLE IF EXISTS `tblb5`;
CREATE TABLE `tblb5` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `img1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblb5`
--

/*!40000 ALTER TABLE `tblb5` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblb5` ENABLE KEYS */;


--
-- Definition of table `tblbirthday`
--

DROP TABLE IF EXISTS `tblbirthday`;
CREATE TABLE `tblbirthday` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `name` varchar(45) default NULL,
  `dateofbirth` datetime default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbirthday`
--

/*!40000 ALTER TABLE `tblbirthday` DISABLE KEYS */;
INSERT INTO `tblbirthday` (`id`,`name`,`dateofbirth`) VALUES 
 (1,'Denver','2017-12-11 08:39:45');
/*!40000 ALTER TABLE `tblbirthday` ENABLE KEYS */;


--
-- Definition of table `tbleventphoto`
--

DROP TABLE IF EXISTS `tbleventphoto`;
CREATE TABLE `tbleventphoto` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `photos` varchar(255) default NULL,
  `dateentry` varchar(255) default NULL,
  `hours` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleventphoto`
--

/*!40000 ALTER TABLE `tbleventphoto` DISABLE KEYS */;
INSERT INTO `tbleventphoto` (`id`,`photos`,`dateentry`,`hours`) VALUES 
 (2,'IMG_20140101_082551.jpg','August 26, 2017','00:31:19');
/*!40000 ALTER TABLE `tbleventphoto` ENABLE KEYS */;


--
-- Definition of table `tblfeedback`
--

DROP TABLE IF EXISTS `tblfeedback`;
CREATE TABLE `tblfeedback` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `section` varchar(255) default NULL,
  `message` varchar(255) default NULL,
  `dateentry` datetime default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblfeedback`
--

/*!40000 ALTER TABLE `tblfeedback` DISABLE KEYS */;
INSERT INTO `tblfeedback` (`id`,`section`,`message`,`dateentry`) VALUES 
 (1,'BSIT12356','Oh common! Seriously?','2017-11-19 00:00:00');
/*!40000 ALTER TABLE `tblfeedback` ENABLE KEYS */;


--
-- Definition of table `tblnewannouncement`
--

DROP TABLE IF EXISTS `tblnewannouncement`;
CREATE TABLE `tblnewannouncement` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `message` varchar(255) default NULL,
  `name` varchar(255) default NULL,
  `dateentry` datetime default NULL,
  `title` varchar(255) default NULL,
  `address` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblnewannouncement`
--

/*!40000 ALTER TABLE `tblnewannouncement` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblnewannouncement` ENABLE KEYS */;


--
-- Definition of table `tblnotifcourse`
--

DROP TABLE IF EXISTS `tblnotifcourse`;
CREATE TABLE `tblnotifcourse` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `department` varchar(45) default NULL,
  `message` varchar(255) default NULL,
  `dateentry` datetime default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblnotifcourse`
--

/*!40000 ALTER TABLE `tblnotifcourse` DISABLE KEYS */;
INSERT INTO `tblnotifcourse` (`id`,`department`,`message`,`dateentry`) VALUES 
 (1,'COMPUTER SCIENCE/INFORMATION TECHNOLOGY','tttt','2017-11-20 00:27:13'),
 (2,'ENGINEERING','asdas','2017-11-20 00:38:34'),
 (3,'ENGINEERING','asdsad\r\nasdad\r\nasdasd\r\nasd\r\nasdasda','2017-11-20 00:38:46'),
 (4,'COMPUTER SCIENCE/INFORMATION TECHNOLOGY','asdasd\r\nasdasd\r\nter3e\r\nasd2w','2017-11-20 00:38:56');
/*!40000 ALTER TABLE `tblnotifcourse` ENABLE KEYS */;


--
-- Definition of table `tblphonebook`
--

DROP TABLE IF EXISTS `tblphonebook`;
CREATE TABLE `tblphonebook` (
  `name` varchar(100) NOT NULL default '',
  `number` varchar(100) NOT NULL default '',
  PRIMARY KEY  (`name`,`number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblphonebook`
--

/*!40000 ALTER TABLE `tblphonebook` DISABLE KEYS */;
INSERT INTO `tblphonebook` (`name`,`number`) VALUES 
 ('Denver','09169233045'),
 ('Test1','09123455667');
/*!40000 ALTER TABLE `tblphonebook` ENABLE KEYS */;


--
-- Definition of table `tblphonebookall`
--

DROP TABLE IF EXISTS `tblphonebookall`;
CREATE TABLE `tblphonebookall` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `mnum` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `groupby` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblphonebookall`
--

/*!40000 ALTER TABLE `tblphonebookall` DISABLE KEYS */;
INSERT INTO `tblphonebookall` (`id`,`mnum`,`name`,`section`,`groupby`) VALUES 
 (1,'8080','Denver','BSIT-123','Student'),
 (2,'AutoLoadMAX','Shiela Gocoyo','Faculty Member','Faculty'),
 (4,'+639985632507','Genesis','BSIT12356','Student'),
 (5,'+639471044987','anyang','BSIT9999','Student');
/*!40000 ALTER TABLE `tblphonebookall` ENABLE KEYS */;


--
-- Definition of table `tblphotoannouncement`
--

DROP TABLE IF EXISTS `tblphotoannouncement`;
CREATE TABLE `tblphotoannouncement` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `photoentry1` varchar(255) default NULL,
  `postentry` varchar(255) default NULL,
  `sizeentry` varchar(255) default NULL,
  `photoentry2` varchar(255) default NULL,
  `photoentry3` varchar(255) default NULL,
  `photoentry4` varchar(255) default NULL,
  `photoentry5` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblphotoannouncement`
--

/*!40000 ALTER TABLE `tblphotoannouncement` DISABLE KEYS */;
INSERT INTO `tblphotoannouncement` (`id`,`photoentry1`,`postentry`,`sizeentry`,`photoentry2`,`photoentry3`,`photoentry4`,`photoentry5`) VALUES 
 (1,'Notification-Folder-icon.png','test12','1 times',NULL,NULL,NULL,NULL),
 (2,'magnifier1.png','sfdddfd','4 times','Notification-Folder-icon.png','Other-Power-Log-Off-Metro-icon.png','remove-button (1).png','');
/*!40000 ALTER TABLE `tblphotoannouncement` ENABLE KEYS */;


--
-- Definition of table `tblpost1`
--

DROP TABLE IF EXISTS `tblpost1`;
CREATE TABLE `tblpost1` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  `msg2` varchar(255) default NULL,
  `msg3` varchar(255) default NULL,
  `msg4` varchar(255) default NULL,
  `msg5` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpost1`
--

/*!40000 ALTER TABLE `tblpost1` DISABLE KEYS */;
INSERT INTO `tblpost1` (`id`,`msg1`,`msg2`,`msg3`,`msg4`,`msg5`) VALUES 
 (3,'dfdf','df','dfd','dfd','dfd'),
 (4,'GENESIS','Denver','Denver','Denver','Denver');
/*!40000 ALTER TABLE `tblpost1` ENABLE KEYS */;


--
-- Definition of table `tblpost2`
--

DROP TABLE IF EXISTS `tblpost2`;
CREATE TABLE `tblpost2` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpost2`
--

/*!40000 ALTER TABLE `tblpost2` DISABLE KEYS */;
INSERT INTO `tblpost2` (`id`,`msg1`) VALUES 
 (1,'h'),
 (2,'Denver');
/*!40000 ALTER TABLE `tblpost2` ENABLE KEYS */;


--
-- Definition of table `tblpost3`
--

DROP TABLE IF EXISTS `tblpost3`;
CREATE TABLE `tblpost3` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `msg1` varchar(255) default NULL,
  `msg2` varchar(255) default NULL,
  `msg3` varchar(255) default NULL,
  `msg4` varchar(255) default NULL,
  `msg5` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpost3`
--

/*!40000 ALTER TABLE `tblpost3` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblpost3` ENABLE KEYS */;


--
-- Definition of table `tblroom`
--

DROP TABLE IF EXISTS `tblroom`;
CREATE TABLE `tblroom` (
  `roomid` varchar(100) NOT NULL default '',
  `room` varchar(100) default NULL,
  PRIMARY KEY  (`roomid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblroom`
--

/*!40000 ALTER TABLE `tblroom` DISABLE KEYS */;
INSERT INTO `tblroom` (`roomid`,`room`) VALUES 
 ('ID001','SB 101'),
 ('RM001','TGY 1 - a'),
 ('RM005','SB204');
/*!40000 ALTER TABLE `tblroom` ENABLE KEYS */;


--
-- Definition of table `tblschedule`
--

DROP TABLE IF EXISTS `tblschedule`;
CREATE TABLE `tblschedule` (
  `schID` varchar(100) NOT NULL default '',
  `starttime` varchar(100) default NULL,
  `endtime` varchar(100) default NULL,
  `dateentry` varchar(100) default NULL,
  `subjects` varchar(100) default NULL,
  `roomno` varchar(100) default NULL,
  `section` varchar(100) default NULL,
  `year` varchar(100) default NULL,
  `days` varchar(100) default NULL,
  PRIMARY KEY  (`schID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblschedule`
--

/*!40000 ALTER TABLE `tblschedule` DISABLE KEYS */;
INSERT INTO `tblschedule` (`schID`,`starttime`,`endtime`,`dateentry`,`subjects`,`roomno`,`section`,`year`,`days`) VALUES 
 ('001','7:00','9:00','October 18, 2015','IT-101','TGY-1A','IT-111','1st Year','1'),
 ('002','9:00','10:00','October 18, 2015','FIL-101','TGY-1A','IT-111','1st Year','1'),
 ('003','7:00','9:00','October 19,2015','MATH-103','TGY-1A','IT-111','1st Year','2'),
 ('004 ','9:00','10:00','October 19.2015','HUM-101','TGY-1A','IT-111','1st Year','2'),
 ('005','7:00','8:00','October 20, 2015','ENG-101','TGY-1A','IT-111','1st Year','3'),
 ('006','8:00','9:00','October 20, 2015','SS-101','TGY-1A','IT-111','1st Year','3'),
 ('007','7:00','9:00','October 18, 2015','IT-101','TGY-2A','IT-112','Ist Year','1'),
 ('008','9:00','10:00','October 18, 2015','FIL-101','TGY-2A','IT-112','1st Year','1'),
 ('009','7:00','9:00','October 19, 2015','MATH-103','TGY-2A','IT-112','1st Year','2'),
 ('010','9:00','10:00','October 19, 2015','HUM101','TGY-2A','IT-112','Ist Year','2'),
 ('011','7:00','8:00','October 20, 2015','ENG100','TGY-2A','IT-112','1st Year','3'),
 ('012','8:00','9:00','October 20, 2015','SS101','TGY-2A','IT-112','1st Year','3'),
 ('013','7:00','9:00','October 18, 2015','IT-101','TGY-3A','IT-113','1st Year','1'),
 ('014','9:00','10:00','October 18, 2015','FIL-101','TGY-3A','IT-113','1st Year','1'),
 ('015','7:00','9:00','October 19, 2015','MATH-103','TGY-3A','IT-113','Ist Year','2'),
 ('016','9:00','10:00','October 19, 2015','HUM-101','TGY-3A','IT-113','1st Year','2'),
 ('017','7:00','8:00','October 20, 2015','ENG-100','TGY-3A','IT-113','1st Year','3'),
 ('018','8:00','9:00','October 20, 2015','SS-101','TGY-3A','IT-113','1st Year','3'),
 ('020','9:00','10:00','October 18, 2015','FIL-101','IT-201','IT-114','1st Year','1'),
 ('021','7:00','9:00','October 19, 2015','MATH-103','IT-201','IT-114','1sr Year','2'),
 ('022','9:00','10:00','October 19 2015','HUM-101','IT201','IT-114','1st Year','2'),
 ('023','7:00','8:00','October 20, 2015','ENG-101','IT-201','IT-114','1st Year','3'),
 ('024','8:00','9:00','October 20, 2015','SS-101','IT-201','IT-114','1st Year','3'),
 ('025','7:00','9:00','October 18, 2015','IT-101','IT-202','IT-115','1st Year','1'),
 ('026','9:00','10:00','October 18, 2015','FIL101','IT202','IT-115','1sT Year','1'),
 ('027','7:00','9:00','October 19, 2015','MATH-103','IT-202','IT-115','1st Year','2'),
 ('029','9:00','10:00','October 19, 2015','HUM-101','IT-202','IT-115','1st Year','2'),
 ('030','7:00','8:00','October 20, 2015','ENG-100','IT-202','IT-115','1sT Year','3'),
 ('031','8:00','9:00','October 20, 2015','SS-101','IT-202','IT-115','1st Year','3'),
 ('032','7:00','9:00','October 18, 2015','IT-101','ADMIN 1','IT-116','1st Year','1'),
 ('033','9:00','10:00','October 18, 2015','FIL-101','ADMIN 1','IT-116','1st Year','1'),
 ('034','7:00','9:00','October 19, 2015','MATH-101','ADMIN 1','IT-116','1st Year','2'),
 ('035','9:00','10:00','October 19, 2015','HUM-101','ADMIN 1','IT-116','1st Year','2'),
 ('036','7:00','8:00','October 20, 2015','ENG-100','ADMIN1','IT-116','1st Year','3'),
 ('037','8:00','9;00','October 20, 2015','SS-101','ADMIN1','IT-116','1st Year','3'),
 ('038','7:00','9:00','October 18, 2015','IT-101','ADMIN4','CS-111','1st Year','1'),
 ('040','7:00','9:00','October 19, 2015','MATH-101','ADMIN4','CS-111','1st Year','2'),
 ('041','9:00','10:00','October 19, 2015','HUM-101','ADMIN4','CS-111','1st Year','2'),
 ('042','7:00','8:00','October 20, 2015','ENG-101','ADMIN4','CS-111','1st Year','3'),
 ('043','8:00','9:00','October 20, 2015','SS-101','ADMIN4','CS-111','1st Year','3'),
 ('044','7:00','9:00','October 18, 2015','IT-101','IT-201','IT-114','1st Year','1'),
 ('045','10:00','12:00','October 18, 2015','MATH-104','SB-201','GE-111','1st Year','1'),
 ('046','12:00','1:00','October 18, 2015','FIL-101','SB-201','GE-111','1st Year','1'),
 ('047','10:00','12:00','October 19, 2015','MATH-108','SB-201','GE-111','1st Year','2'),
 ('048','12:00','1:00','October 19, 2015','HUM-101','SB-201','GE-111','1st Year','2'),
 ('049','9:00','11:00','October 20, 2015','CHEM-102','SB-201','GE-111','1st Year','3'),
 ('050','11:00','12:00','October 20, 2015','ENG-101','SB-201','GE-111','1st Year','3'),
 ('051','12:00','1:00','October 20, 2015','SS-101','SB-201','GE-111','1st Year','3'),
 ('052','10:00','12:00','October 18, 2015','Math-104','SB-201','GE-112','1st Year','1'),
 ('053','12:00','1:00','October 18, 2015','FIL-101','SB-201','GE-112','1st Year','1'),
 ('054','10:00','12:00','October 19, 2015','MATH-108','SB-204','GE-112','1st Year','2'),
 ('055','12:00','01:00','October 19, 2015','HUM-101','SB-204','GE-112','1st Year','2'),
 ('056','09:00','11:00','October 20, 2015','CHEM-102','SB-204','GE-112','1st Year','3'),
 ('057','11:00','12:00','October 20, 2015','ENG-100','SB-204','GE-112','1st Year','3'),
 ('058','12:00','01:00','October 20, 2015','SS-101','SB-204','GE-112','1st Year','3'),
 ('059','10:00','12:00','October 18, 2015','MATH-104','ADMIN1','GE-113','1st Year','1'),
 ('060','12:00','01:00','October 18, 2015','FIL-101','ADMIN1','GE-113','1st Year','1'),
 ('061','10:00','12:00','October 19, 2015','MATH-108','ADMIN1','GE-113','1st Year','2'),
 ('062','12:00','1:00','October 19, 2015','HUM-101','ADMIN1','GE-113','1st Year','2'),
 ('063','9:00','11:00','October 20, 2015','CHEM-102','ADMIN1','GE-113','1st Year','3'),
 ('064','11:00','12:00','October 20, 2015','ENG-101','ADMIN1','GE-113','1st Year','3'),
 ('065','12:00','1:00','October 20, 2015','SS-101','ADMIN1','GE-113','1st Year','3'),
 ('066','10:00','12:00','October 18,2015','MATH-104','TGY-1A','GE-114','1st Year','1'),
 ('067','12:00','01:00','October 18,2015','FIL-101','TGY-1A','GE-114','1st Year','1'),
 ('068','10:00','12:00','October 19, 2015','MATH-108','TGY-1A','GE-114','1st Year','2'),
 ('069','12:00','1:00','October 19, 2015','HUM-101','TGY-1A','GE-114','1st Year','2'),
 ('070','9:00','11:00','October 20, 2015','CHEM-102','TGY-1A','GE-114','1st Year','3'),
 ('071','11:00','12:00','October 20, 2015','ENG-101','TGY-1A','GE-114','1st Year','3'),
 ('072','12:00','1:00','October 20, 2015','SS-101','TGY-1A','GE-114','1st Year','3'),
 ('073','10:00','12:00','October 18, 2015','MATH-104','ADMIN2','GE-115','1st Year','1'),
 ('074','12:00','01:00','October 18, 2015','FIL-101','ADMIN2','GE-115','1st Year','1'),
 ('075','10:00','12:00','October 19, 2015','MATH-108','ADMIN2.1','GE-115','1st Year','2'),
 ('076','12:00','01:00','October 19, 2015','MATH-108','ADMIN2.1','GE-115','1st Year','2'),
 ('077','12:00','01:00','October 19, 2015','HUM-101','ADMIN2.1','GE-115','1st Year','2'),
 ('078','09:00','11:00','October 20, 2015','CHEM-102','ADMIN2.1','GE-115','1st Year','3'),
 ('079','11:00','12:00','October 20, 2015','ENG-101','ADMIN2.1','GE-115','1st Year','3'),
 ('080','12:00','01:00','October 20, 2015','SS-101','ADMIN2.1','GE-115','1st Year','3'),
 ('081','10:00','12:00','October 18, 2015','MATH-104','IT-201','GE-116','1st Year','1'),
 ('082','12:00','01:00','October 18, 2015','FIL-101','IT-201','GE-116','1st Year','1'),
 ('083','10:00','12:00','October 19, 2015','MATH-108','IT-201','GE-116','1st Year','2'),
 ('084','12:00','01:00','October 19, 2015','HUM-101','IT-201','GE-116','1st Year','2'),
 ('085','09:00','11:00','October 20, 2015','CHEM-102','IT-201','GE-116','1st Year','3'),
 ('086','11:00','12:00','October 20, 2015','ENG-100','IT-201','GE-116','1st Year','3'),
 ('087','11:00','12:00','October 20, 2015','SS-101','IT-201','GE-116','1st Year','3'),
 ('100','07:00','08:00','october  18, 2015','gfhgfjhgjhiluyuyfddfg','cs1111','ie456',NULL,'1'),
 ('101','08:00','09:00','october  18, 2015','gfhgfjhgjhilu','cs1111','ie456',NULL,'1');
/*!40000 ALTER TABLE `tblschedule` ENABLE KEYS */;


--
-- Definition of table `tblsection`
--

DROP TABLE IF EXISTS `tblsection`;
CREATE TABLE `tblsection` (
  `sectionid` varchar(100) NOT NULL default '',
  `section` varchar(100) default NULL,
  PRIMARY KEY  (`sectionid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsection`
--

/*!40000 ALTER TABLE `tblsection` DISABLE KEYS */;
INSERT INTO `tblsection` (`sectionid`,`section`) VALUES 
 ('ID001','SB 101'),
 ('SC001','IT421'),
 ('Sec001','CS 421');
/*!40000 ALTER TABLE `tblsection` ENABLE KEYS */;


--
-- Definition of table `tblsentitems`
--

DROP TABLE IF EXISTS `tblsentitems`;
CREATE TABLE `tblsentitems` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `mnum` varchar(255) default NULL,
  `messages` varchar(255) default NULL,
  `datesent` varchar(45) default NULL,
  `name` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsentitems`
--

/*!40000 ALTER TABLE `tblsentitems` DISABLE KEYS */;
INSERT INTO `tblsentitems` (`id`,`mnum`,`messages`,`datesent`,`name`) VALUES 
 (1,'AutoLoadMAX','data test','2017-11-18','Shiela Gocoyo'),
 (2,'8080','ttt','2017-11-18','Denver'),
 (3,'+639095808943','test','2017-11-18','No Name'),
 (4,'AutoLoadMAX','gfhff','2017-11-18','Shiela Gocoyo'),
 (5,'+639985632507','gfhff','2017-11-18','Genesis');
/*!40000 ALTER TABLE `tblsentitems` ENABLE KEYS */;


--
-- Definition of table `tblstudentsms`
--

DROP TABLE IF EXISTS `tblstudentsms`;
CREATE TABLE `tblstudentsms` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `mnum` varchar(255) default NULL,
  `section` varchar(255) default NULL,
  `sname` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentsms`
--

/*!40000 ALTER TABLE `tblstudentsms` DISABLE KEYS */;
INSERT INTO `tblstudentsms` (`id`,`mnum`,`section`,`sname`) VALUES 
 (1,'2910','BSIT-4111','Denver'),
 (2,'8080','BSIT-123','DDD'),
 (3,'AutoLoadMAX','BSIT-1111','asdas'),
 (4,'+639095808943','BSIT-WHAT','A'),
 (5,'+639503862473','Software Engineer','B'),
 (6,'+639563362499','Computer Engineer','Potanes');
/*!40000 ALTER TABLE `tblstudentsms` ENABLE KEYS */;


--
-- Definition of table `tblsubject`
--

DROP TABLE IF EXISTS `tblsubject`;
CREATE TABLE `tblsubject` (
  `subjcode` varchar(100) NOT NULL default '',
  `description` varchar(100) default NULL,
  PRIMARY KEY  (`subjcode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsubject`
--

/*!40000 ALTER TABLE `tblsubject` DISABLE KEYS */;
INSERT INTO `tblsubject` (`subjcode`,`description`) VALUES 
 ('CCNA4','WAN'),
 ('ID001','asdasd'),
 ('ID002','asdasdasda'),
 ('UN1001','MAICA');
/*!40000 ALTER TABLE `tblsubject` ENABLE KEYS */;


--
-- Definition of table `tbltextlocation`
--

DROP TABLE IF EXISTS `tbltextlocation`;
CREATE TABLE `tbltextlocation` (
  `txt1X` varchar(56) default NULL,
  `txt1Y` varchar(56) default NULL,
  `status` varchar(45) NOT NULL default '',
  PRIMARY KEY  USING BTREE (`status`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltextlocation`
--

/*!40000 ALTER TABLE `tbltextlocation` DISABLE KEYS */;
INSERT INTO `tbltextlocation` (`txt1X`,`txt1Y`,`status`) VALUES 
 ('858','159','pic1'),
 ('-1000','-1000','pic2'),
 ('-1000','-1000','pic3'),
 ('-1000','-1000','pic4'),
 ('-1000','-1000','pic5'),
 ('233','53','ps1'),
 ('-1000','-1000','ps2'),
 ('-1000','-1000','ps3'),
 ('265','71','txt1'),
 ('9','67','txt2'),
 ('348','61','txt3'),
 ('-1000','-1000','txt4'),
 ('9','67','txt5');
/*!40000 ALTER TABLE `tbltextlocation` ENABLE KEYS */;


--
-- Definition of table `tbluserlog`
--

DROP TABLE IF EXISTS `tbluserlog`;
CREATE TABLE `tbluserlog` (
  `username` varchar(100) NOT NULL default '',
  `password` varchar(100) default NULL,
  PRIMARY KEY  (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluserlog`
--

/*!40000 ALTER TABLE `tbluserlog` DISABLE KEYS */;
INSERT INTO `tbluserlog` (`username`,`password`) VALUES 
 ('admin','admin');
/*!40000 ALTER TABLE `tbluserlog` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
