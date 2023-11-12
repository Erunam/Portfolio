-- =============================================================================
-- Diagram Name: RSG Database Design
-- Created on: 2009-10-26 12:42:51
-- Diagram Version: 1.76
-- =============================================================================
DROP DATABASE IF EXISTS `RainbowStainedGlass`;

CREATE DATABASE IF NOT EXISTS `RainbowStainedGlass`;

USE `RainbowStainedGlass`;

SET FOREIGN_KEY_CHECKS=0;

CREATE TABLE `ProductCategory` (
  `Product` varchar(50) NOT NULL,
  `Description` text,
  PRIMARY KEY(`Product`)
)
ENGINE=INNODB
COMMENT = 'Kategorie produkt�w';

CREATE TABLE `MaterialClass` (
  `PartClass` varchar(50) NOT NULL,
  `Description` text,
  PRIMARY KEY(`PartClass`)
)
ENGINE=INNODB
COMMENT = 'Lista cz�ci sk�adowych komponent�w.';

CREATE TABLE `ComponentCategory` (
  `ComponentCategory` varchar(50) NOT NULL,
  `Description` text,
  PRIMARY KEY(`ComponentCategory`)
)
ENGINE=INNODB
COMMENT = 'Lista cz�ci sk�adowych dla produkt�w.';

CREATE TABLE `ManufacturingSettings` (
  `Parameter` varchar(50) NOT NULL,
  `Value` float(9,3),
  PRIMARY KEY(`Parameter`)
)
ENGINE=INNODB
COMMENT = 'Parametry oblicze�';

CREATE TABLE `Themes` (
  `ProductTheme` varchar(50) NOT NULL,
  `Description` text,
  PRIMARY KEY(`ProductTheme`)
)
ENGINE=INNODB
COMMENT = 'Tematy przewodnie, Obiekty';

CREATE TABLE `Collections` (
  `ProductCollection` varchar(50) NOT NULL,
  `Description` float(9,3),
  PRIMARY KEY(`ProductCollection`)
)
ENGINE=INNODB
COMMENT = 'Kolekcje produkt�w';

CREATE TABLE `StainedGlassDesign` (
  `DesignID` int(4) UNSIGNED NOT NULL,
  `DesignName` varchar(24),
  `DesignSize` varchar(12),
  `DesignWidth` float(9,3),
  `DesignHeight` float(9,3),
  `TotalElements` float(9,3),
  `TotalPerimeter` float(9,3),
  `SolderLine` float(9,3),
  `TotalArea` float(9,3),
  `GrindedPerimeter` float(9,3),
  `ScrapFactor` float(9,3),
  `Author` varchar(50),
  `LicenseType` varchar(50),
  `EnteredBy` varchar(50),
  `DateEnter` date,
  `Comments` text,
  PRIMARY KEY(`DesignID`)
)
ENGINE=INNODB
COMMENT = 'Tabela Projekt�w dla Stained Glass';

CREATE TABLE `ProductCategories` (
  `CategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(50),
  `Product` varchar(50) NOT NULL,
  `ParentID` int(11) DEFAULT '0',
  `Description` text,
  PRIMARY KEY(`CategoryID`),
  INDEX `Category`(`Category`),
  CONSTRAINT `ProductInCategories` FOREIGN KEY (`Product`)
    REFERENCES `ProductCategory`(`Product`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ParentCategory` FOREIGN KEY (`ParentID`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Kategorie produkt�w';

CREATE TABLE `ComponentAndPart` (
  `ComponentID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `ComponentName` varchar(24) NOT NULL COMMENT 'Nazwa komponentu',
  `Attribute` varchar(12) COMMENT 'Atrybut',
  `Group` enum('Component','Part') NOT NULL DEFAULT 'Component' COMMENT 'Rozr�nia cz�� od komponentu',
  `ComponentCategory` varchar(50) COMMENT 'Domy�lna kategoria komponentu',
  `PartClass` varchar(50) COMMENT 'Domy�lna klasa cz�ci',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane WP w�asne',
  `CWP` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - WP cz�ci sk�adowych',
  `MC` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - koszt materia�u',
  `Description` text,
  PRIMARY KEY(`ComponentID`),
  INDEX `ComponentName`(`ComponentName`, `Attribute`),
  CONSTRAINT `ComponentCategoriesInParts` FOREIGN KEY (`ComponentCategory`)
    REFERENCES `ComponentCategory`(`ComponentCategory`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `PartClassInComponents` FOREIGN KEY (`PartClass`)
    REFERENCES `MaterialClass`(`PartClass`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Lista dost�pnych komponent�w i cz�ci.';

CREATE TABLE `ComponentDetails` (
  `ComponentID` int(11) UNSIGNED NOT NULL DEFAULT '0',
  `PartClass` varchar(50) NOT NULL,
  `PartID` int(11) UNSIGNED NOT NULL DEFAULT '0',
  `Quantity` float(9,3) NOT NULL DEFAULT '0' COMMENT 'ilo��',
  INDEX `ComponentID`(`ComponentID`),
  CONSTRAINT `ComponentDetails` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `PartClassInDetails` FOREIGN KEY (`PartClass`)
    REFERENCES `MaterialClass`(`PartClass`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `PartIdInDetails` FOREIGN KEY (`PartID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB;

CREATE TABLE `ComponentConfiguration` (
  `ComponentCategory` varchar(50) NOT NULL,
  `PartClass` varchar(50) NOT NULL,
  `ComponentID` int(11) UNSIGNED DEFAULT '0',
  CONSTRAINT `PartsInConfiguration` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ComponentCategoriesConfiguration` FOREIGN KEY (`ComponentCategory`)
    REFERENCES `ComponentCategory`(`ComponentCategory`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `PartClassInConfiguration` FOREIGN KEY (`PartClass`)
    REFERENCES `MaterialClass`(`PartClass`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Cz�ci sk�adowe komponent�w.';

CREATE TABLE `Product` (
  `ProductID` int(6) UNSIGNED NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(24) NOT NULL COMMENT 'unikalna nazwa',
  `ProductSize` varchar(12) NOT NULL COMMENT 'S, L, M, XM',
  `Product` varchar(50) NOT NULL COMMENT 'produkt sprzedawany - stained glass, mosaic',
  `ProductCategory` int(11) NOT NULL DEFAULT '0',
  `ProductSubCategory` int(11) NOT NULL DEFAULT '0',
  `ProductTheme` varchar(50),
  `ProductCollection` varchar(50),
  `WarehousePrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - ustalona cena hurtowa',
  `RetailPrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - ustalona cena detaliczna',
  `TotalCostLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - koszt robocizny i materia�u',
  `WarehousePriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena hurtowa',
  `RRPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena detaliczna',
  `VatPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena detaliczna z vatem',
  `TotalCostHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `WarehousePriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `RRPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `VatPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `Weight` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - waga',
  `ProductWidth` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca�kowita szeroko��',
  `ProductHeight` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca�kowita d�ugo��',
  `Deep` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca�kowita grubo��',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - WP w�asne',
  `CWP` float(9,3) COMMENT 'uaktualniane - WP komponent�w',
  `TWP` float(9,3) COMMENT 'uaktualniane - WP ca�kowite',
  `MC` float(9,3) COMMENT 'uaktualniane - koszt materia�u',
  `Description` text,
  PRIMARY KEY(`ProductID`),
  INDEX `ProductName`(`ProductName`, `ProductSize`),
  INDEX `Categories`(`ProductCategory`, `ProductSubCategory`, `ProductTheme`, `ProductCollection`),
  CONSTRAINT `ProductsInProduct` FOREIGN KEY (`Product`)
    REFERENCES `ProductCategory`(`Product`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProductCategories` FOREIGN KEY (`ProductCategory`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProductSubCategories` FOREIGN KEY (`ProductSubCategory`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ThemesInProduct` FOREIGN KEY (`ProductTheme`)
    REFERENCES `Themes`(`ProductTheme`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `CollectionsInProduct` FOREIGN KEY (`ProductCollection`)
    REFERENCES `Collections`(`ProductCollection`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Tabela g��wna produktu.';

CREATE TABLE `ProductConfiguration` (
  `Product` varchar(50) NOT NULL COMMENT 'Produkt',
  `ProductCategory` int(11) NOT NULL DEFAULT '0',
  `ProductSubCategory` int(11) NOT NULL DEFAULT '0',
  `ComponentCategory` varchar(50) NOT NULL,
  `ComponentID` int(11) UNSIGNED DEFAULT '0',
  INDEX `ProductClass`(`Product`, `ProductCategory`, `ProductSubCategory`),
  CONSTRAINT `ComponentInConfiguration` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ComponentsCategoriesForConfiguration` FOREIGN KEY (`ComponentCategory`)
    REFERENCES `ComponentCategory`(`ComponentCategory`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProductsInConfiguration` FOREIGN KEY (`Product`)
    REFERENCES `ProductCategory`(`Product`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `CategoryInConfiguration` FOREIGN KEY (`ProductCategory`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `SubCategoryInConfiguration` FOREIGN KEY (`ProductSubCategory`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Definiuje cz�ci sk�adowe produktu.';

CREATE TABLE `ProductDetails` (
  `ProductID` int(6) UNSIGNED NOT NULL DEFAULT '0' COMMENT 'klucz obcy produktu',
  `ComponentCategory` varchar(50) NOT NULL COMMENT 'Nazwa cz�ci sk�adowej',
  `ComponentID` int(11) UNSIGNED NOT NULL DEFAULT '0' COMMENT 'klucz obcy komponentu',
  `Quantity` float(9,3) NOT NULL DEFAULT '0',
  INDEX `ProductID`(`ProductID`),
  CONSTRAINT `ProductDetails` FOREIGN KEY (`ProductID`)
    REFERENCES `Product`(`ProductID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ComponentsInProduct` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ComponentsCategoriesForProduct` FOREIGN KEY (`ComponentCategory`)
    REFERENCES `ComponentCategory`(`ComponentCategory`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
ENGINE=INNODB
COMMENT = 'Tabela pomocnicza. Szczeg�owy wykaz cz�ci sk�adowych.';

SET FOREIGN_KEY_CHECKS=1;
