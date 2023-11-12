USE rainbowstainedglass;

SET FOREIGN_KEY_CHECKS=0;

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
ENGINE=INNODB

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