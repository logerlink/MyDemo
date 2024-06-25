START TRANSACTION;

ALTER TABLE `Users` ADD `Money` decimal(65,30) NOT NULL DEFAULT 0.0;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230412023822_add-user-column-money', '6.0.15');

COMMIT;

START TRANSACTION;

ALTER TABLE `Users` MODIFY COLUMN `Money` decimal(16,5) NOT NULL;

ALTER TABLE `Users` ADD `Address_Price` decimal(16,5) NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230412030112_update-user-column-money', '6.0.15');

COMMIT;

