-- =============================================================================
-- Diagram Name: RSG Database Design
-- Created on: 2010-04-09 22:31:52
-- Diagram Version: 1.135
-- =============================================================================
DROP DATABASE IF EXISTS `RainbowStainedGlass`;

CREATE DATABASE IF NOT EXISTS `RainbowStainedGlass`;

USE `RainbowStainedGlass`;

SET FOREIGN_KEY_CHECKS=0;

CREATE TABLE `Collections` (
  `ProductCollection` varchar(50) NOT NULL,
  `CollectionDescription` text,
  PRIMARY KEY(`ProductCollection`)
)
ENGINE=INNODB
COMMENT = 'Kolekcje produktów';

CREATE TABLE `ProductLine` (
  `ProductLine` varchar(50) NOT NULL,
  `ProductDescription` text,
  PRIMARY KEY(`ProductLine`)
)
ENGINE=INNODB
COMMENT = 'Kategorie produktów';

CREATE TABLE `ComponentParts` (
  `ComponentPart` varchar(50) NOT NULL,
  `ComponentPartDescription` text,
  PRIMARY KEY(`ComponentPart`)
)
ENGINE=INNODB
COMMENT = 'Lista czêœci sk³adowych komponentów.';

CREATE TABLE `Themes` (
  `ProductTheme` varchar(50) NOT NULL,
  `ThemeDescription` text,
  PRIMARY KEY(`ProductTheme`)
)
ENGINE=INNODB
COMMENT = 'Tematy przewodnie, Obiekty';

CREATE TABLE `Workmanships` (
  `WorkmanshipName` varchar(50) NOT NULL,
  `Description` text,
  PRIMARY KEY(`WorkmanshipName`)
)
ENGINE=INNODB
COMMENT = 'Wykonania z opisami';

CREATE TABLE `License` (
  `License` varchar(50) NOT NULL,
  `LicenseDescription` text,
  PRIMARY KEY(`License`)
)
ENGINE=INNODB
COMMENT = 'Opis Licencji';

CREATE TABLE `ManufacturingSettings` (
  `Parameter` varchar(50) NOT NULL,
  `Value` float(9,3),
  PRIMARY KEY(`Parameter`)
)
ENGINE=INNODB
COMMENT = 'Parametry obliczeñ';

CREATE TABLE `ProductParts` (
  `ProductPart` varchar(50) NOT NULL,
  `ProductPartDescription` text,
  PRIMARY KEY(`ProductPart`)
)
ENGINE=INNODB
COMMENT = 'Lista czêœci sk³adowych produktów.';

CREATE TABLE `ComponentAndPart` (
  `ComponentID` int(11) UNSIGNED NOT NULL,
  `ProductPart` varchar(50) NOT NULL,
  `ComponentName` varchar(24) NOT NULL COMMENT 'Nazwa komponentu',
  `Attribute` varchar(12) COMMENT 'Atrybut',
  `Group` enum('Component','Part') NOT NULL DEFAULT 'Component' COMMENT 'Rozró¿nia czêœæ od komponentu',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane WP w³asne',
  `CWP` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - WP czêœci sk³adowych',
  `MC` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - koszt materia³u',
  `Description` text,
  PRIMARY KEY(`ComponentID`),
  UNIQUE INDEX `ComponentName`(`ComponentName`, `Attribute`),
  CONSTRAINT `ProductPartInComponents` FOREIGN KEY (`ProductPart`)
    REFERENCES `ProductParts`(`ProductPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Lista dostêpnych komponentów i czêœci.';

CREATE TABLE `ProductCategories` (
  `CategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(50),
  `ProductLine` varchar(50) NOT NULL,
  `CategoryDescription` varchar(50),
  PRIMARY KEY(`CategoryID`),
  UNIQUE INDEX `Category`(`Category`, `ProductLine`),
  CONSTRAINT `ProductLineInCategories` FOREIGN KEY (`ProductLine`)
    REFERENCES `ProductLine`(`ProductLine`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Kategorie produktów';

CREATE TABLE `StainedGlassDesign` (
  `DesignID` int(4) UNSIGNED NOT NULL,
  `DesignName` varchar(24) NOT NULL,
  `DesignSize` varchar(12) NOT NULL,
  `DesignWidth` float(9,3) DEFAULT '0',
  `DesignHeight` float(9,3) DEFAULT '0',
  `TotalElements` float(9,3) NOT NULL DEFAULT '0',
  `TotalPerimeter` float(9,3) NOT NULL DEFAULT '0',
  `SolderLine` float(9,3) NOT NULL DEFAULT '0',
  `TotalArea` float(9,3) NOT NULL DEFAULT '0',
  `GrindedPerimeter` float(9,3) NOT NULL DEFAULT '0',
  `AWP` float(9,3) NOT NULL DEFAULT '0',
  `ScrapFactor` float(9,3) NOT NULL DEFAULT '0',
  `Author` varchar(50),
  `EnteredBy` varchar(50),
  `DateEnter` varchar(18),
  `Comments` text,
  `License` varchar(50) NOT NULL DEFAULT 'Unspecified',
  PRIMARY KEY(`DesignID`),
  UNIQUE INDEX `DesignName`(`DesignName`, `DesignSize`),
  CONSTRAINT `LicenseInDesign` FOREIGN KEY (`License`)
    REFERENCES `License`(`License`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Tabela Projektów dla Stained Glass';

CREATE TABLE `ProductSubCategories` (
  `SubcategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `Subcategory` varchar(50),
  `CategoryID` int(11) NOT NULL DEFAULT '0',
  `ProductLine` varchar(50) NOT NULL,
  `SubcategoryDescription` varchar(50),
  PRIMARY KEY(`SubcategoryID`),
  UNIQUE INDEX `Subcategory`(`Subcategory`, `CategoryID`, `ProductLine`),
  CONSTRAINT `CetagoriesInSubCategory` FOREIGN KEY (`CategoryID`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductInSubcategory` FOREIGN KEY (`ProductLine`)
    REFERENCES `ProductLine`(`ProductLine`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Kategorie produktów';

CREATE TABLE `ComponentConfiguration` (
  `ProductPart` varchar(50) NOT NULL,
  `ComponentPart` varchar(50) NOT NULL,
  `ComponentID` int(11) UNSIGNED DEFAULT '0',
  CONSTRAINT `ComponentPartInComponentConfig` FOREIGN KEY (`ComponentPart`)
    REFERENCES `ComponentParts`(`ComponentPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `PartIDInComponentConfig` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductPartInComponentConfig` FOREIGN KEY (`ProductPart`)
    REFERENCES `ProductParts`(`ProductPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Konfiguracja komponentów.';

CREATE TABLE `WorkmanshipsDetails` (
  `WorkmanshipName` varchar(50) NOT NULL DEFAULT '1',
  `ProductPart` varchar(50) NOT NULL,
  `ComponentID` int(11) UNSIGNED DEFAULT '0',
  `Quantity` float(9,3),
  CONSTRAINT `ComponentInConfiguration` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductPartInWorkmanship` FOREIGN KEY (`ProductPart`)
    REFERENCES `ProductParts`(`ProductPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `WorkmanshipsInDetails` FOREIGN KEY (`WorkmanshipName`)
    REFERENCES `Workmanships`(`WorkmanshipName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Wykoñczenie';

CREATE TABLE `ComponentDetails` (
  `ComponentID` int(11) UNSIGNED NOT NULL DEFAULT '0',
  `ComponentPart` varchar(50) NOT NULL,
  `PartID` int(11) UNSIGNED NOT NULL DEFAULT '0',
  `Quantity` float(9,3) NOT NULL DEFAULT '0' COMMENT 'iloœæ',
  CONSTRAINT `ComponentDetails` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `PartClassInDetails` FOREIGN KEY (`ComponentPart`)
    REFERENCES `ComponentParts`(`ComponentPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `PartIdInDetails` FOREIGN KEY (`PartID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Szczegó³owy wykaz czêœci w komponencie.';

CREATE TABLE `ProductConfiguration` (
  `ProductLine` varchar(50) NOT NULL,
  `CategoryID` int(11) NOT NULL DEFAULT '0',
  `SubcategoryID` int(11) NOT NULL DEFAULT '0',
  `StandardWorkmanship` varchar(50) NOT NULL,
  UNIQUE INDEX `Configuration`(`ProductLine`, `CategoryID`, `SubcategoryID`, `StandardWorkmanship`),
  CONSTRAINT `ProductLineInProductConfig` FOREIGN KEY (`ProductLine`)
    REFERENCES `ProductLine`(`ProductLine`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductCategoriesInProductConfig` FOREIGN KEY (`CategoryID`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductSubCategoriesInProductConfig` FOREIGN KEY (`SubcategoryID`)
    REFERENCES `ProductSubCategories`(`SubcategoryID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `StandardWorkmanshipInProduct` FOREIGN KEY (`StandardWorkmanship`)
    REFERENCES `Workmanships`(`WorkmanshipName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Definiuje standardowe wykoñczenie dla klasy produktów.';

CREATE TABLE `Product` (
  `ProductID` int(11) UNSIGNED NOT NULL,
  `ProductLine` varchar(50) NOT NULL COMMENT 'produkt sprzedawany - stained glass, mosaic',
  `ProductName` varchar(24) NOT NULL COMMENT 'unikalna nazwa',
  `ProductSize` varchar(12) NOT NULL COMMENT 'S, L, M, XM',
  `WorkmanshipName` varchar(50) NOT NULL COMMENT 'wykonanie',
  `ProductCategory` int(11) NOT NULL DEFAULT '0',
  `ProductSubcategory` int(11) NOT NULL DEFAULT '0',
  `ProductTheme` varchar(50),
  `ProductCollection` varchar(50),
  `WarehousePrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - ustalona cena hurtowa',
  `RetailPrice` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - ustalona cena detaliczna',
  `TotalCostLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - koszt robocizny i materia³u',
  `WarehousePriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena hurtowa',
  `RRPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena detaliczna',
  `VatPriceLo` float(9,3) DEFAULT '0' COMMENT 'uaktualniane - cena detaliczna z vatem',
  `TotalCostHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `WarehousePriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `RRPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `VatPriceHi` float(9,3) DEFAULT '0' COMMENT 'uaktualniane',
  `Weight` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - waga',
  `ProductWidth` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca³kowita szerokoœæ',
  `ProductHeight` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca³kowita d³ugoœæ',
  `Deep` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - ca³kowita gruboœæ',
  `AWP` float(9,3) DEFAULT '0' COMMENT 'wprowadzane - WP w³asne',
  `CWP` float(9,3) COMMENT 'uaktualniane - WP komponentów',
  `TWP` float(9,3) COMMENT 'uaktualniane - WP ca³kowite',
  `MC` float(9,3) COMMENT 'uaktualniane - koszt materia³u',
  `Description` text,
  PRIMARY KEY(`ProductID`),
  UNIQUE INDEX `ProductName`(`ProductName`, `ProductSize`, `ProductLine`, `WorkmanshipName`),
  CONSTRAINT `ProductLineInProduct` FOREIGN KEY (`ProductLine`)
    REFERENCES `ProductLine`(`ProductLine`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductCategories` FOREIGN KEY (`ProductCategory`)
    REFERENCES `ProductCategories`(`CategoryID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ThemesInProduct` FOREIGN KEY (`ProductTheme`)
    REFERENCES `Themes`(`ProductTheme`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `CollectionsInProduct` FOREIGN KEY (`ProductCollection`)
    REFERENCES `Collections`(`ProductCollection`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `WorkmanshipsInProducts` FOREIGN KEY (`WorkmanshipName`)
    REFERENCES `Workmanships`(`WorkmanshipName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `SubcategoryInProduct` FOREIGN KEY (`ProductSubcategory`)
    REFERENCES `ProductSubCategories`(`SubcategoryID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Tabela g³ówna produktu.';

CREATE TABLE `ProductDetails` (
  `ProductID` int(11) UNSIGNED NOT NULL DEFAULT '0' COMMENT 'klucz obcy produktu',
  `ProductPart` varchar(50) NOT NULL COMMENT 'Nazwa czêœci sk³adowej',
  `ComponentID` int(11) UNSIGNED NOT NULL DEFAULT '0' COMMENT 'klucz obcy komponentu',
  `Quantity` float(9,3) NOT NULL DEFAULT '0',
  CONSTRAINT `ProductDetails` FOREIGN KEY (`ProductID`)
    REFERENCES `Product`(`ProductID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ComponentsInProduct` FOREIGN KEY (`ComponentID`)
    REFERENCES `ComponentAndPart`(`ComponentID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `ProductPartsInProductDetails` FOREIGN KEY (`ProductPart`)
    REFERENCES `ProductParts`(`ProductPart`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
ENGINE=INNODB
COMMENT = 'Tabela pomocnicza. Szczegó³owy wykaz czêœci sk³adowych.';

SET FOREIGN_KEY_CHECKS=1;
