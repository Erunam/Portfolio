-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.40-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


USE rainbowstainedglass;

--
-- Dumping data for table `collections`
--

/*!40000 ALTER TABLE `collections` DISABLE KEYS */;
INSERT INTO `collections` (`ProductCollection`,`CollectionDescription`) VALUES 
 ('Angels',NULL),
 ('Astral',NULL),
 ('Birds',NULL),
 ('Butterfly',NULL),
 ('Chakra',NULL),
 ('Children',NULL),
 ('Christmas',NULL),
 ('Cross',NULL),
 ('Cube',NULL),
 ('Daisy',NULL),
 ('Dogs',NULL),
 ('Dragonflies',NULL),
 ('Dragons',NULL),
 ('Easter',NULL),
 ('Fairy',NULL),
 ('Fish',NULL),
 ('Fruits',NULL),
 ('Geometric',NULL),
 ('Gothic',NULL),
 ('Grapes',NULL),
 ('Harp',NULL),
 ('Heart',NULL),
 ('Horses',NULL),
 ('Knot',NULL),
 ('Lilly',NULL),
 ('Mackintosh',NULL),
 ('Moose',NULL),
 ('Pansy',NULL),
 ('Rainbow',NULL),
 ('Religious',NULL),
 ('Retro',NULL),
 ('Roses',NULL),
 ('Shotokan',NULL),
 ('Spider',NULL),
 ('Squares',NULL),
 ('Sunflower',NULL),
 ('SunRise',NULL),
 ('Swan',NULL),
 ('Trees',NULL),
 ('Trifolium',NULL),
 ('Waves',NULL),
 ('Zodiac',NULL);
/*!40000 ALTER TABLE `collections` ENABLE KEYS */;


--
-- Dumping data for table `componentandpart`
--

/*!40000 ALTER TABLE `componentandpart` DISABLE KEYS */;
INSERT INTO `componentandpart` (`ComponentID`,`ProductPart`,`ComponentName`,`Attribute`,`Group`,`AWP`,`CWP`,`MC`,`Description`) VALUES 
 (1,'Mounting','a','1','Part',0.000,0.000,0.000,''),
 (2,'Mounting','b','2','Part',0.000,0.000,0.000,''),
 (3,'Mounting','c','3','Part',0.000,0.000,0.000,''),
 (4,'Mounting','d','4','Part',0.000,0.000,0.000,'');
/*!40000 ALTER TABLE `componentandpart` ENABLE KEYS */;


--
-- Dumping data for table `componentconfiguration`
--

/*!40000 ALTER TABLE `componentconfiguration` DISABLE KEYS */;
/*!40000 ALTER TABLE `componentconfiguration` ENABLE KEYS */;


--
-- Dumping data for table `componentdetails`
--

/*!40000 ALTER TABLE `componentdetails` DISABLE KEYS */;
INSERT INTO `componentdetails` (`ComponentID`,`ComponentPart`,`PartID`,`Quantity`) VALUES 
 (1,'Came',2,12.000),
 (1,'Came',3,0.000),
 (1,'Came',4,2.000),
 (2,'Bead',4,0.000),
 (2,'Board',3,0.000),
 (2,'CandleHolder',4,1.000),
 (4,'Bead',3,0.000);
/*!40000 ALTER TABLE `componentdetails` ENABLE KEYS */;


--
-- Dumping data for table `componentparts`
--

/*!40000 ALTER TABLE `componentparts` DISABLE KEYS */;
INSERT INTO `componentparts` (`ComponentPart`,`ComponentPartDescription`) VALUES 
 ('Bead',NULL),
 ('Board',NULL),
 ('Came',NULL),
 ('CandleHolder',NULL),
 ('Celophane Bag',NULL),
 ('Clock Chain',NULL),
 ('Copper Foil',NULL),
 ('Crimp',NULL),
 ('Flux',NULL),
 ('Glass',NULL),
 ('Globs',NULL),
 ('Grinder Bit',NULL),
 ('Labels',NULL),
 ('Labour',NULL),
 ('Outliner',NULL),
 ('Solder',NULL),
 ('Tiger Tail',NULL),
 ('Wire',NULL);
/*!40000 ALTER TABLE `componentparts` ENABLE KEYS */;


--
-- Dumping data for table `license`
--

/*!40000 ALTER TABLE `license` DISABLE KEYS */;
INSERT INTO `license` (`License`,`LicenseDescription`) VALUES 
 ('Copyrights','company holds full copyrights to file'),
 ('Free','company holds rights to make any product basing on file'),
 ('Individual','company have special kind of licence arranged with copyrighter'),
 ('OnDemand','license is obtained in case of customer order'),
 ('Single','company have rights to make one product from file'),
 ('Unlicensed','company does not hold license'),
 ('Unspecified','company make product, with no clear specified licence');
/*!40000 ALTER TABLE `license` ENABLE KEYS */;


--
-- Dumping data for table `manufacturingsettings`
--

/*!40000 ALTER TABLE `manufacturingsettings` DISABLE KEYS */;
INSERT INTO `manufacturingsettings` (`Parameter`,`Value`) VALUES 
 ('Area',0.508),
 ('Elements',26.200),
 ('GrindedPerimeter',13.390),
 ('Perimeter',3.619),
 ('Profit',0.150),
 ('RetailerProfit',0.400),
 ('SolderLine',14.906),
 ('SolderUsage',0.390),
 ('VAT215',0.215);
/*!40000 ALTER TABLE `manufacturingsettings` ENABLE KEYS */;


--
-- Dumping data for table `product`
--

/*!40000 ALTER TABLE `product` DISABLE KEYS */;
/*!40000 ALTER TABLE `product` ENABLE KEYS */;


--
-- Dumping data for table `productcategories`
--

/*!40000 ALTER TABLE `productcategories` DISABLE KEYS */;
INSERT INTO `productcategories` (`CategoryID`,`Category`,`ProductLine`,`CategoryDescription`) VALUES 
 (1,'Mirrors','Stained Glass',NULL),
 (2,'Panels','Stained Glass',NULL),
 (3,'Architectural','Stained Glass',NULL),
 (4,'Lightings','Stained Glass',NULL),
 (5,'Decorations','Stained Glass',NULL),
 (6,'Templates','Stained Glass',NULL);
/*!40000 ALTER TABLE `productcategories` ENABLE KEYS */;


--
-- Dumping data for table `productconfiguration`
--

/*!40000 ALTER TABLE `productconfiguration` DISABLE KEYS */;
/*!40000 ALTER TABLE `productconfiguration` ENABLE KEYS */;


--
-- Dumping data for table `productdetails`
--

/*!40000 ALTER TABLE `productdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `productdetails` ENABLE KEYS */;


--
-- Dumping data for table `productline`
--

/*!40000 ALTER TABLE `productline` DISABLE KEYS */;
INSERT INTO `productline` (`ProductLine`,`ProductDescription`) VALUES 
 ('Stained Glass',NULL);
/*!40000 ALTER TABLE `productline` ENABLE KEYS */;


--
-- Dumping data for table `productparts`
--

/*!40000 ALTER TABLE `productparts` DISABLE KEYS */;
INSERT INTO `productparts` (`ProductPart`,`ProductPartDescription`) VALUES 
 ('Accessories',NULL),
 ('Design Copper Foil',NULL),
 ('Design Leaded',NULL),
 ('Mounting',NULL),
 ('Outliner',NULL),
 ('Packaging',NULL);
/*!40000 ALTER TABLE `productparts` ENABLE KEYS */;


--
-- Dumping data for table `productsubcategories`
--

/*!40000 ALTER TABLE `productsubcategories` DISABLE KEYS */;
INSERT INTO `productsubcategories` (`SubcategoryID`,`Subcategory`,`CategoryID`,`ProductLine`,`SubcategoryDescription`) VALUES 
 (1,'Bathroom',1,'Stained Glass',NULL),
 (2,'CustomMade',1,'Stained Glass',NULL),
 (3,'Decorative',1,'Stained Glass',NULL),
 (4,'KingSize',1,'Stained Glass',NULL),
 (5,'Wall',1,'Stained Glass',NULL),
 (6,'Furniture',2,'Stained Glass',NULL),
 (7,'Panels',2,'Stained Glass',NULL),
 (8,'Signboards',2,'Stained Glass',NULL),
 (9,'SunCatcher',2,'Stained Glass',NULL),
 (10,'Textplates',2,'Stained Glass',NULL),
 (11,'Corners',3,'Stained Glass',NULL),
 (12,'Doors',3,'Stained Glass',NULL),
 (13,'Entries',3,'Stained Glass',NULL),
 (14,'FanLight',3,'Stained Glass',NULL),
 (15,'Furniture',3,'Stained Glass',NULL),
 (16,'SideLights',3,'Stained Glass',NULL),
 (17,'Windows',3,'Stained Glass',NULL),
 (18,'Candleholder',4,'Stained Glass',NULL),
 (19,'Lamp',4,'Stained Glass',NULL),
 (20,'Lantern',4,'Stained Glass',NULL),
 (21,'Pendant',4,'Stained Glass',NULL),
 (22,'Shade',4,'Stained Glass',NULL),
 (23,'Wall Lamp',4,'Stained Glass',NULL),
 (24,'Mobiles',5,'Stained Glass',NULL),
 (25,'Ornaments',5,'Stained Glass',NULL),
 (26,'PotStick',5,'Stained Glass',NULL),
 (27,'Digits',6,'Stained Glass',NULL),
 (28,'Doors Shapes',6,'Stained Glass',NULL),
 (29,'Letters',6,'Stained Glass',NULL);
/*!40000 ALTER TABLE `productsubcategories` ENABLE KEYS */;


--
-- Dumping data for table `stainedglassdesign`
--

/*!40000 ALTER TABLE `stainedglassdesign` DISABLE KEYS */;
INSERT INTO `stainedglassdesign` (`DesignID`,`DesignName`,`DesignSize`,`DesignWidth`,`DesignHeight`,`TotalElements`,`TotalPerimeter`,`SolderLine`,`TotalArea`,`GrindedPerimeter`,`AWP`,`ScrapFactor`,`Author`,`EnteredBy`,`DateEnter`,`Comments`,`License`) VALUES 
 (1,'Claire','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (2,'Gothic','M',10.000,21.000,0.000,0.000,12.000,0.000,0.000,0.000,0.000,'Madzia','Madzia','','','Unspecified'),
 (3,'Trun','M',12.000,12.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'vitmar','madzia','','','Unspecified'),
 (4,'Gothic-Theresa','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (5,'Celtic1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (6,'Celtic2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (7,'Trinity','M',32.000,32.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia','','','Unspecified'),
 (8,'Squares.small','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (9,'Mack','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (10,'Mack1.double','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (11,'Mack1.single','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (12,'Mackintosh','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (13,'Squares.medium','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (14,'TriangleR','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'vitmar','madzia',NULL,NULL,'Unspecified'),
 (15,'SunRound','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (16,'SunWave','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (17,'Trinity','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (18,'Mackintosh1','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (19,'Pansy-V6','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'vitmar','madzia',NULL,NULL,'Unspecified'),
 (20,'Rose-V8','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'vitmar','madzia',NULL,NULL,'Unspecified'),
 (21,'Horse-V3','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','magda',NULL,NULL,'Unspecified'),
 (22,'CelticDragon-V1','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','magda',NULL,NULL,'Unspecified'),
 (23,'Swan-V4','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','magda',NULL,NULL,'Unspecified'),
 (24,'Harp','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Rainbow Glass','madzia',NULL,NULL,'Unspecified'),
 (25,'TrinityKnot','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (26,'Basset-V1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (27,'Bulltrout-V2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (28,'Butterflies-Sp','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'GlasDesign','madzia',NULL,NULL,'Unspecified'),
 (29,'Dolphin-V2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (30,'Dolphin-V9','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (31,'Horse-V4','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (32,'Horse-V6','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (33,'Moose-V3','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (34,'Spider-V42','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (35,'Grapes-V2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (36,'Rose-V1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (37,'WalkingAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (38,'Dove','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Glass by Design','Madzia',NULL,NULL,'Unspecified'),
 (39,'CelticCross-2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'RainbowGlass','Madzia',NULL,NULL,'Unspecified'),
 (40,'Angel-V28','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','Madzia',NULL,NULL,'Unspecified'),
 (41,'Angel&Sheep','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'Madzia',NULL,NULL,'Unspecified'),
 (42,'CelticCross-1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'RainbowGlass','madzia',NULL,NULL,'Unspecified'),
 (43,'CelticCross-11','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'RainbowGlass','madzia',NULL,NULL,'Unspecified'),
 (44,'StBrigid-SFN','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (45,'StBrigid-SF','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (46,'StBrigid-C','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (47,'StBrigid-O','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (48,'StBrigid-S','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (49,'StBrigid-SA','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (50,'Danaan-3D','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'magda',NULL,NULL,'Unspecified'),
 (51,'Assura-2D','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar + Daniel','magda',NULL,NULL,'Unspecified'),
 (52,'Cernunnos-3D','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (53,'DancingFairyA','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','magda',NULL,NULL,'Unspecified'),
 (54,'DancingFairyB','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','magda',NULL,NULL,'Unspecified'),
 (55,'Draco','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'GlasseyeArtist','magda',NULL,NULL,'Unspecified'),
 (56,'Saphira','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'unknown','Madzia',NULL,NULL,'Unspecified'),
 (57,'Rose-C1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel+AlpineStGlass','Madzia',NULL,NULL,'Unspecified'),
 (58,'Sunflower','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','magda',NULL,NULL,'Unspecified'),
 (59,'Daisy','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','magda',NULL,NULL,'Unspecified'),
 (60,'FlyingDuck','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'unknown','Madzia',NULL,NULL,'Unspecified'),
 (61,'MoonBunny','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'Madzia',NULL,NULL,'Unspecified'),
 (62,'Sunmoon','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'from Chantale','Madzia',NULL,NULL,'Unspecified'),
 (63,'Sunmoonpanel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'from Chantale','Madzia',NULL,NULL,'Unspecified'),
 (64,'Ajna','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (65,'Swadhisthana','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (66,'Muladhara','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (67,'Manipura','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (68,'Vishuddha','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (69,'Anahata','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (70,'Sahasrara','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (71,'Aquarius','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (72,'Aries','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (73,'Cancer','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (74,'Capricorn','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (75,'Gemini','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (76,'Leo','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (77,'Libra','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (78,'Pisces','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (79,'Sagittarius','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (80,'Scorpio','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (81,'Taurus','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (82,'Virgo','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (83,'Higgins 65Lilly','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia+Vitmarfree','Madzia',NULL,NULL,'Unspecified'),
 (84,'65Rose','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia+Delphifree','Madzia',NULL,NULL,'Unspecified'),
 (85,'65Waves','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (86,'Shotokan-Tiger','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Daniel',NULL,NULL,'Unspecified'),
 (87,'Cube','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (88,'Berries-C','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','madzia',NULL,NULL,'Unspecified'),
 (89,'Cube','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (90,'AngelRounds-Set','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (91,'SantaSock','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'AlpineStainedGlass','madzia',NULL,NULL,'Unspecified'),
 (92,'SantaSock','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'AlpineStainedGlass','madzia',NULL,NULL,'Unspecified'),
 (93,'SnowMan','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','madzia',NULL,NULL,'Unspecified'),
 (94,'JingleBell-R','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (95,'JingleBell-R','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (96,'Bulb-1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (97,'Bulb-2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (98,'Candy','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (99,'Candy','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (100,'Hollyberries','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (101,'Hollyberries','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (102,'Hollyberries','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (103,'Mistletoe','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (104,'Mistletoe','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (105,'SantaHead','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (106,'SantaTeddy','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (107,'SantaTeddy','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (108,'ShootingStar','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (109,'Star-5','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','madzia',NULL,NULL,'Unspecified'),
 (110,'AngelHorn','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'stainedglassnews','madzia',NULL,NULL,'Unspecified'),
 (111,'AngelHorn','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'StainedGlassNews','madzia',NULL,NULL,'Unspecified'),
 (112,'AngelTrumpet','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Vitmar','madzia',NULL,NULL,'Unspecified'),
 (113,'DancingAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Spectrum','Madzia',NULL,NULL,'Unspecified'),
 (114,'GuardianAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (115,'MoonAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'unknown','madzia',NULL,NULL,'Unspecified'),
 (116,'PrayingAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'unknown','madzia',NULL,NULL,'Unspecified'),
 (117,'PrayingAngel-W','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Unknown+Daniel','Madzia',NULL,NULL,'Unspecified'),
 (118,'PreciousAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (119,'DreamingAngel','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'book+daniel','madzia',NULL,NULL,'Unspecified'),
 (120,'Angel-X1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (121,'Angel-X2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (122,'Angel-X3','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (123,'Angel-X4','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (124,'Angel-X5','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (125,'Angel-X6','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (126,'Heart-S','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (127,'Heart-S','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (128,'Heart-2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (129,'Heart-2','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (130,'Heart-3','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (131,'Heart-3','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (132,'Heart-4','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (133,'Heart-4','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (134,'Heart -2','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (135,'Heart-4w','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (136,'Heart -4w','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (137,'Heart -4w','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (138,'RainbowHeart6','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (139,'Heart-S','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (140,'Heart-4','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (141,'Heart-4','XM',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (142,'Clover-R','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','madzia',NULL,NULL,'Unspecified'),
 (143,'Seamrog-R','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (144,'Knot','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (145,'Knot','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (146,'ShamrockBig2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (147,'ShamrockSmall3','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (148,'ShamrockMedium.','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (149,'Dragonflies','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','madzia',NULL,NULL,'Unspecified'),
 (150,'Butterfly08','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (151,'Butterfly10S','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,'madzia',NULL,NULL,'Unspecified'),
 (152,'Butterfly10W','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,NULL,NULL,NULL,'Unspecified'),
 (153,'Butterfly13','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,NULL,NULL,NULL,'Unspecified'),
 (154,'Butterfly21','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,NULL,NULL,NULL,'Unspecified'),
 (155,'Butterfly23Sp','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,NULL,NULL,NULL,'Unspecified'),
 (156,'Butterfly43Sp','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,NULL,NULL,NULL,NULL,'Unspecified'),
 (157,'RainbowDrops','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (158,'Lemon','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (159,'Lemon','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (160,'ChakraBalancers','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (161,'EasterEgg-D1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (162,'EasterEgg-D2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (163,'EasterEgg-D3','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (164,'EasterEgg-D3','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (165,'EasterEgg-D4','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (166,'EasterEgg-D4','S',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified'),
 (167,'EasterEgg-M1','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (168,'EasterEgg-M2','M',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (169,'EasterEgg-M3','M',12.000,NULL,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Madzia','Madzia',NULL,NULL,'Unspecified'),
 (170,'Betula','L',0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,'Daniel','Madzia',NULL,NULL,'Unspecified');
/*!40000 ALTER TABLE `stainedglassdesign` ENABLE KEYS */;


--
-- Dumping data for table `themes`
--

/*!40000 ALTER TABLE `themes` DISABLE KEYS */;
INSERT INTO `themes` (`ProductTheme`,`ThemeDescription`) VALUES 
 ('Angels',NULL),
 ('Bushido',NULL),
 ('Butterflies',NULL),
 ('Celtic',NULL),
 ('Chakra',NULL),
 ('Christmas',NULL),
 ('DragonFlies',NULL),
 ('Easter',NULL),
 ('Fauna',NULL),
 ('Fearie',NULL),
 ('Flora',NULL),
 ('Geometric',NULL),
 ('Nature',NULL),
 ('New Age',NULL),
 ('Valentine',NULL),
 ('Zodiac',NULL);
/*!40000 ALTER TABLE `themes` ENABLE KEYS */;


--
-- Dumping data for table `workmanships`
--

/*!40000 ALTER TABLE `workmanships` DISABLE KEYS */;
/*!40000 ALTER TABLE `workmanships` ENABLE KEYS */;


--
-- Dumping data for table `workmanshipsdetails`
--

/*!40000 ALTER TABLE `workmanshipsdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `workmanshipsdetails` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
