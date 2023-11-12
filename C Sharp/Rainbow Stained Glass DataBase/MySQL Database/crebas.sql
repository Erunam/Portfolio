-- =============================================================================
-- Diagram Name: RSG Database Design
-- Created on: 2009-09-30 22:28:01
-- Diagram Version: 1.42
-- =============================================================================
SET FOREIGN_KEY_CHECKS=0;

-- Drop table Specifications
DROP TABLE IF EXISTS `Specifications`;

CREATE TABLE `Specifications` (
  `CategoryID` int(12) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'tylko index',
  `Specification` text COMMENT 'tytu³ specyfikacji',
  `Object` text COMMENT 'zkategoryzowany obiekt',
  `Category` text COMMENT 'Nazwa w³asna kategorii - taka sama jak nazwa kolumny',
  `Name` varchar(50) NOT NULL,
  `Parent` int(12),
  `Code` int(9),
  `Description` text,
  PRIMARY KEY(`CategoryID`),
  INDEX `CategoryName`(`Name`),
  INDEX `FKIndex1`(`Parent`),
  CONSTRAINT `Ref_01` FOREIGN KEY (`Parent`)
    REFERENCES `Specifications`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

-- Drop table StainedGlassDesign
DROP TABLE IF EXISTS `StainedGlassDesign`;

CREATE TABLE `StainedGlassDesign` (
  `DesignID` int(4) UNSIGNED NOT NULL,
  `DesignName` varchar(50),
  `DesignSize` varchar(50),
  `Width` float(9,3),
  `Height` float(9,3),
  `Deep` float(9,3),
  `TotalElements` float(9,3),
  `TotalPerimeter` float(9,3),
  `SolderLine` float(9,3),
  `TotalArea` float(9,3),
  `GrindedPerimeter` float(9,3),
  `ScrapFactor` float(9,3),
  `LayoutFactor` float(9,3),
  `Author` varchar(50),
  `LicenseType` varchar(50),
  `EnteredBy` varchar(50),
  `DateEnter` date,
  `ReviewedBy` varchar(50),
  `DateReview` date,
  `ValidationOrder` int(11),
  `DateAccepted` date,
  `Comments` text,
  PRIMARY KEY(`DesignID`)
)
ENGINE=INNODB;

-- Drop table Product
DROP TABLE IF EXISTS `Product`;

CREATE TABLE `Product` (
  `ProductID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Name` varchar(24) NOT NULL COMMENT 'unikalna nazwa',
  `Size` varchar(12) NOT NULL COMMENT 'S, L, M, XM',
  `Product` varchar(50) NOT NULL COMMENT 'produkt sprzedawany - stained glass, mosaic',
  `ProductCategory` varchar(50),
  `ProductSubCategory` varchar(50),
  `ProductTheme` varchar(50),
  `ProductCollection` varchar(50),
  `TotalCostLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `WarehousePriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `RRPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `VatPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `TotalCostHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `WarehousePriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `RRPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `VatPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `WarehousePrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `RetailPrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `Weight` float(9,3) DEFAULT '0' COMMENT 'wprowadzane',
  `Width` float(9,3) DEFAULT '0' COMMENT 'wprowadzane',
  `Height` float(9,3) DEFAULT '0' COMMENT 'wprowadzane',
  `Deep` float(9,3) DEFAULT '0' COMMENT 'wprowadzane',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane WP w³asne',
  `CWP` float(9,3) COMMENT 'uaktualniane',
  `TWP` float(9,3) COMMENT 'uaktualniane',
  `MC` float(9,3) COMMENT 'uaktualniane',
  `Description` text,
  PRIMARY KEY(`ProductID`),
  UNIQUE INDEX `ProductName`(`Name`),
  INDEX `Categories`(`ProductCategory`, `ProductSubCategory`, `ProductTheme`, `ProductCollection`)
)
ENGINE=INNODB;

-- Drop table ComponentAndPart
DROP TABLE IF EXISTS `ComponentAndPart`;

CREATE TABLE `ComponentAndPart` (
  `Component` varchar(24) NOT NULL,
  `Attribute` varchar(12),
  `ComponentCategory` varchar(50),
  `Group` enum('Component','Part') NOT NULL DEFAULT 'Component',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane WP w³asne',
  `CWP` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `MC` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `Description` text,
  PRIMARY KEY(`Component`),
  INDEX `Component`(`Component`, `Attribute`)
)
ENGINE=INNODB;

-- Drop table DefaultProduct
DROP TABLE IF EXISTS `DefaultProduct`;

CREATE TABLE `DefaultProduct` (
  `Product` varchar(50),
  `ProductCategory` varchar(50),
  `ComponentCategory` varchar(50),
  `ComponentName` varchar(24),
  CONSTRAINT `DefaultProduct` FOREIGN KEY (`ComponentName`)
    REFERENCES `ComponentAndPart`(`Component`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

-- Drop table DefaultComponent
DROP TABLE IF EXISTS `DefaultComponent`;

CREATE TABLE `DefaultComponent` (
  `Component` varchar(50),
  `PartCategory` varchar(50),
  `PartName` varchar(24),
  CONSTRAINT `DefaultComponent` FOREIGN KEY (`PartName`)
    REFERENCES `ComponentAndPart`(`Component`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

-- Drop table ComponentDetails
DROP TABLE IF EXISTS `ComponentDetails`;

CREATE TABLE `ComponentDetails` (
  `Component` varchar(24) NOT NULL COMMENT 'komponent',
  `Attribute` varchar(12),
  `PartCategory` varchar(50) NOT NULL,
  `Part` varchar(24) NOT NULL COMMENT 'czeœæ sk³adowa',
  `Quantity` float(9,3) NOT NULL DEFAULT '1' COMMENT 'iloœæ',
  INDEX `Component`(`Component`, `Attribute`),
  CONSTRAINT `Component` FOREIGN KEY (`Component`)
    REFERENCES `ComponentAndPart`(`Component`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Part` FOREIGN KEY (`Part`)
    REFERENCES `ComponentAndPart`(`Component`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

-- Drop table ProductDetails
DROP TABLE IF EXISTS `ProductDetails`;

CREATE TABLE `ProductDetails` (
  `ProductName` varchar(24) NOT NULL DEFAULT '0',
  `Size` varchar(12),
  `ComponentCategory` varchar(50) NOT NULL,
  `Component` varchar(24) NOT NULL,
  `Quantity` float(9,3),
  INDEX `Product`(`ProductName`, `Size`),
  CONSTRAINT `Product` FOREIGN KEY (`ProductName`)
    REFERENCES `Product`(`Name`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProductComponent` FOREIGN KEY (`Component`)
    REFERENCES `ComponentAndPart`(`Component`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

SET FOREIGN_KEY_CHECKS=1;
