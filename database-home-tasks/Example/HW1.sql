CREATE DATABASE my_db;

USE my_db;

CREATE TABLE Colleges (
  id INT,
  code VARCHAR(20) NOT NULL,
  name VARCHAR(50),
  CONSTRAINT CollegePK PRIMARY KEY (college_id)
);

//якщо на Первний ключ встановлено бмеження "unique" - в рядок команди він не вноситься
//приклад: https://www.programiz.com/sql/unique
INSERT INTO Customers(customer_id, first_name, last_name, age, country)
VALUES (7, 'Ron', 'Weasley', 31, 'UK');



