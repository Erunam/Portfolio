-- =============================================================================
-- Diagram Name: SP-S05 - Storage Books
-- Created on: 2011-03-27 20:13:25
-- Diagram Version: 
-- =============================================================================
SET FOREIGN_KEY_CHECKS=0;

-- Drop table Currencies
DROP TABLE IF EXISTS `Currencies`;

CREATE TABLE `Currencies` (
  `Currency` char(3) NOT NULL,
  `Description` text,
  PRIMARY KEY(`Currency`)
)
ENGINE=INNODB;

-- Drop table Transactions
DROP TABLE IF EXISTS `Transactions`;

CREATE TABLE `Transactions` (
  `Transaction` varchar(24) NOT NULL,
  `Cash Flow` enum('Out','In','None'),
  `Description` text,
  PRIMARY KEY(`Transaction`)
)
ENGINE=INNODB;

-- Drop table Accounts
DROP TABLE IF EXISTS `Accounts`;

CREATE TABLE `Accounts` (
  `Accounts` varchar(24) NOT NULL,
  `Category` enum('Open','Financial'),
  `Class` enum('External','Internal'),
  `Description` text,
  PRIMARY KEY(`Accounts`)
)
ENGINE=INNODB;

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
  `Part Class_FK` varchar(24) NOT NULL,
  `Cost Code_FK` int(2) NOT NULL DEFAULT '0',
  `Stock Title_FK` varchar(36) NOT NULL,
  UNIQUE INDEX `FullIndex`(`Part Class_FK`, `Cost Code_FK`, `Stock Title_FK`),
  CONSTRAINT `StockTitle_In_StorageAssignment` FOREIGN KEY (`Stock Title_FK`)
    REFERENCES `Stock Framework`(`Stock Title`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `PartClass_In_StorageAssignment` FOREIGN KEY (`Part Class_FK`)
    REFERENCES `Part Class`(`Part Class`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `CostCode_In_StorageAssignment` FOREIGN KEY (`Cost Code_FK`)
    REFERENCES `Cost Codes`(`Cost Code`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Classification
DROP TABLE IF EXISTS `Classification`;

CREATE TABLE `Classification` (
  `Part` varchar(24) NOT NULL,
  `Classification` varchar(24) NOT NULL,
  UNIQUE INDEX `CalssificationFull`(`Classification`, `Part`),
  CONSTRAINT `Part_In_Classification` FOREIGN KEY (`Part`)
    REFERENCES `Parts Assignment`(`Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Stock Register
DROP TABLE IF EXISTS `Stock Register`;

CREATE TABLE `Stock Register` (
  `Part Id` int(5) NOT NULL,
  `Part` varchar(24),
  `Attribute` varchar(24),
  `Colour` varchar(24),
  `Barcode` varchar(24),
  `Description` text,
  `Classification` varchar(24),
  `Value` decimal(14,8),
  `Quantity` decimal(12,4),
  `Unit` varchar(6),
  `Favorite` enum('yes','no'),
  `Part Code` varchar(24),
  PRIMARY KEY(`Part Id`),
  UNIQUE INDEX `PartName`(`Part`, `Attribute`, `Colour`),
  CONSTRAINT `Part_In_StockRegister` FOREIGN KEY (`Part`)
    REFERENCES `Parts Assignment`(`Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `Classification_In_StockRegister` FOREIGN KEY (`Classification`, `Part`)
    REFERENCES `Classification`(`Classification`, `Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Manufacturers Stock
DROP TABLE IF EXISTS `Manufacturers Stock`;

CREATE TABLE `Manufacturers Stock` (
  `Manufacturer` varchar(24) NOT NULL,
  `Product` varchar(24),
  `Manufacturer Code` varchar(24) NOT NULL,
  `Description` text,
  `Colour` varchar(24),
  `Family` varchar(24),
  `Class` varchar(24),
  `Effect` varchar(24),
  `File` varchar(24),
  `Price Class` varchar(6),
  `Classification` varchar(24),
  `Part Code` varchar(24),
  `Part` varchar(24),
  UNIQUE INDEX `ManufacturerCode`(`Manufacturer`, `Manufacturer Code`),
  CONSTRAINT `Part_In_ManufacturersStock` FOREIGN KEY (`Part`)
    REFERENCES `Parts Assignment`(`Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `Classification_In_ManufacturersStock` FOREIGN KEY (`Classification`, `Part`)
    REFERENCES `Classification`(`Classification`, `Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

-- Drop table Suppliers Stock
DROP TABLE IF EXISTS `Suppliers Stock`;

CREATE TABLE `Suppliers Stock` (
  `Supplier` varchar(24) NOT NULL,
  `Supplier Code` varchar(50) NOT NULL,
  `Description` text,
  `Category` varchar(24),
  `Price` decimal(12,4),
  `Package` decimal(12,4),
  `Package Unit` varchar(6),
  `Unit Price` decimal(14,8),
  `Unit` varchar(6),
  `Manufacturer` varchar(24),
  `Manufacturer Code` varchar(24),
  `Part Code` varchar(24),
  `Part` varchar(24),
  UNIQUE INDEX `SupplierCode`(`Supplier`, `Supplier Code`),
  CONSTRAINT `Part_In_SuppliersStock` FOREIGN KEY (`Part`)
    REFERENCES `Parts Assignment`(`Part`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `ManufacturerCode_In_SuppliersStock` FOREIGN KEY (`Manufacturer`, `Manufacturer Code`)
    REFERENCES `Manufacturers Stock`(`Manufacturer`, `Manufacturer Code`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
)
ENGINE=INNODB;

SET FOREIGN_KEY_CHECKS=1;
