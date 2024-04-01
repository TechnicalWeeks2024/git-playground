-- ### Завдання №2*

-- Виконується при умові успішного виконання попередніх завдань.
--  Файл-результат повинен містити:

-- 1. Запит на виведення з Таблиці №1 рядків PK,A1,A2,A3 в яких D1>=x,
--  де x є х[D1min, D1max];
SELECT show_id, name, description, category
FROM shows
WHERE duration_minutes >= 30
ORDER BY duration_minutes ASC;

-- 2. Запит на виведення з Таблиці №1 кількості рядків в яких 
-- D1>=x & D1<=y, де x,y є х[D1min, D1max];
SELECT COUNT(*) AS total_rows
FROM shows
WHERE duration_minutes >= 10 AND duration_minutes <= 30;



-- 3. Запит на виведення з Таблиці №1 рядків PK,A1 де A1 має довжину == x,
--  де x є (0, MAX(Length(A1))];
SELECT show_id, name
FROM shows
WHERE LENGTH(name) = 21;


-- 4. Запит на виведення з Таблиці №1 рядків PK,A1,A2,A3 
-- де A1 починається з літери "А" і А2 або А3 містять літеру "А",
--  літера "А" - довільна літера яка відповідає контексту внесених даних;
SELECT show_id, name, description, category
FROM shows
WHERE name LIKE 'The B%' AND (description LIKE '%a%' OR category LIKE '%a%');