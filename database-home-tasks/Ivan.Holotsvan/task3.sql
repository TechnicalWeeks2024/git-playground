-- ### Завдання №3**

-- 1. Команду створення Таблиці №2, яка міститиме груповий атрибут для об"єктів в Таблиці №1.
--     1. Таблиця №2 містить первинний ключ
--     2. Таблиця №2 містить текстове поле з груповою знакою\характеристокою.
CREATE TABLE groups (
  group_id SERIAL PRIMARY KEY,
  group_name VARCHAR(255) NOT NULL
);

-- 2. Команду оновлення Таблиці №1 зі створенням колонки (FK) для Вторинного ключа, колонка може містити NULL
ALTER TABLE shows ADD COLUMN group_id INT NULL;

-- 3. Команда додавання обмеження (constraint) на колонку FK
ALTER TABLE shows ADD CONSTRAINT fk_group_id FOREIGN KEY (group_id)
REFERENCES groups (group_id) ON DELETE SET NULL;

-- 4. Команду\команди на внесення даних в Таблицю №2,
--  не менше 5 значень рядків
INSERT INTO groups (group_name) VALUES ('Comedy');
INSERT INTO groups (group_name) VALUES ('Light Shows');
INSERT INTO groups (group_name) VALUES ('Interactive Shows');
INSERT INTO groups (group_name) VALUES ('Special Shows');
INSERT INTO groups (group_name) VALUES ('Acrobatics');
INSERT INTO groups (group_name) VALUES ('Magic');
INSERT INTO groups (group_name) VALUES ('Animals');
INSERT INTO groups (group_name) VALUES ('Stunt Shows');

-- 5. Команду\команди на оновлення даних в Таблиці №1 колонка FK знаеннями PK
--  з Таблиці №2 (присвоєння групового атрибуту)
UPDATE shows
SET group_id = (
  SELECT group_id
  FROM groups
  WHERE groups.group_name = shows.category
);

-- 6. Запит на виведення всіх рядків з Таблиці №1 в яких не встановлено груповий атрибут FK
SELECT show_id, name, description, category
FROM shows
WHERE group_id IS NULL;

-- 7. Запит на виведення всіх рядків з Таблиці №1 зі всіма колонками і їх
--  відповідного групового атрибуту
SELECT s.show_id, s.name, s.description, s.category, g.group_name
FROM shows s
INNER JOIN groups g ON s.group_id = g.group_id;
