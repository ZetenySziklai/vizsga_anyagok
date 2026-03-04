CREATE DATABASE IF NOT EXISTS robotdb
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE robotdb;

CREATE TABLE robotporszivo (
    id INT AUTO_INCREMENT PRIMARY KEY,
    marka VARCHAR(100) NOT NULL,
    tipus VARCHAR(100) NOT NULL,
    teljesitmeny INT NOT NULL,
    ar INT NOT NULL
);

INSERT INTO robotporszivo (marka, tipus, teljesitmeny, ar) VALUES
('Xiaomi', 'Mi Robot S10', 4000, 120000),
('iRobot', 'Roomba i7', 3500, 180000),
('Roborock', 'S8 Pro', 6000, 250000);