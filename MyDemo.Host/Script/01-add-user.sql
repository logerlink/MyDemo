CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Users` (
    `Id` char(36) COLLATE ascii_general_ci NOT NULL,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Age` int NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230411100436_add-table-user', '6.0.15');

COMMIT;

START TRANSACTION;

ALTER TABLE `Users` ADD `Address_City` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `Address_Country` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `Address_Detail` longtext CHARACTER SET utf8mb4 NULL;

ALTER TABLE `Users` ADD `Address_State` longtext CHARACTER SET utf8mb4 NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230412022011_add-user-column-address', '6.0.15');

COMMIT;

