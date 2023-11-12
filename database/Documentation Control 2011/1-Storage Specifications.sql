-- =============================================================================
-- Diagram Name: SP-S05 - Storage Books
-- Created on: 2011-03-26 18:14:42
-- Diagram Version: 
-- =============================================================================
SET FOREIGN_KEY_CHECKS=0;

-- Drop table Stock Framework
DROP TABLE IF EXISTS `Stock Framework`;

CREATE TABLE `Stock Framework` (
  `Stock Id` int(2) NOT NULL,
  `Stock Title` varchar(36) NOT NULL,
  `Description` varchar(50),
  `Function` enum('Register','Stock','Warehouse') NOT NULL,
  `Storage Book` text,
  `Attachments Localisation` text,
  `Attachment Sub 1` varchar(50),
  `Attachment Sub 2` varchar(50),
  `Usage` enum('In Use','Not In Use') NOT NULL,
  PRIMARY KEY(`Stock Id`),
  UNIQUE INDEX `Stock Title`(`Stock Title`)
)
ENGINE=INNODB;

-- Drop table Part Class
DROP TABLE IF EXISTS `Part Class`;

CREATE TABLE `Part Class` (
  `Part Class` varchar(24) NOT NULL,
  `Description` text,
  PRIMARY KEY(`Part Class`)
)
ENGINE=INNODB;

-- Drop table Parts Assignment
DROP TABLE IF EXISTS `Parts Assignment`;

CREATE TABLE `Parts Assignment` (
  `Part` varchar(24) NOT NULL,
  `Part Class` varchar(24),
  PRIMARY KEY(`Part`),
  CONSTRAINT `PartClass_In_PartAssignment` FOREIGN KEY (`Part Class`)
    REFERENCES `Part Class`(`Part Class`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Cost Codes
DROP TABLE IF EXISTS `Cost Codes`;

CREATE TABLE `Cost Codes` (
  `Cost Code` int(2) NOT NULL,
  `Cost Class` varchar(24),
  `Part Class` varchar(24),
  `Description` text,
  `Tax Classification` varchar(50),
  `Tax Form Index` int(3),
  PRIMARY KEY(`Cost Code`),
  CONSTRAINT `PartClass-In-CostCodes` FOREIGN KEY (`Part Class`)
    REFERENCES `Part Class`(`Part Class`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Storage Assignment
DROP TABLE IF EXISTS `Storage Assignment`;

CREATE TABLE `Storage Assignment` (
  `Stock Title` varchar(36) NOT NULL,
  `Part Class` varchar(24) NOT NULL,
  `Cost Code` int(2) NOT NULL DEFAULT '0',
  UNIQUE INDEX `FullIndex`(`Stock Title`, `Part Class`, `Cost Code`),
  CONSTRAINT `StockTitle_In_StorageAssignment` FOREIGN KEY (`Stock Title`)
    REFERENCES `Stock Framework`(`Stock Title`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `PartClass_In_StorageAssignment` FOREIGN KEY (`Part Class`)
    REFERENCES `Part Class`(`Part Class`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `CostCode_In_StorageAssignment` FOREIGN KEY (`Cost Code`)
    REFERENCES `Cost Codes`(`Cost Code`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

SET FOREIGN_KEY_CHECKS=1;
