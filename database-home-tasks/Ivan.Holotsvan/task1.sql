-- 1. Команда створення БД;
CREATE DATABASE circus;

-- 2. Команда зміни контексту на створену БД;
-- \connect circus;

-- 3. Команда створення Таблиці №1, яка повинна містити
--     1. Первинний ключ (PK);
--     2. Не менше 3ох текстових полів (A1, A2, A3, ...) - реальні назви обрати залежно від теми БД;
--     3. Не менше 2ох числових поліх різних форматів (D1, D2, ...) - реальні назви обрати залежно від теми БД;
--     4. Не менше 1го поля з датою (датою-часом, тощо) - (T1, T2, ...) - реальні назви обрати залежно від теми БД;

CREATE TABLE shows (
  show_id SERIAL PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description TEXT,
  category VARCHAR(50) NOT NULL,
  duration_minutes INTEGER,
  start_time TIMESTAMP WITH TIME ZONE,
  ticket_price DECIMAL(10,2)
);

-- 4. Команду\команди на внесення даних в таблицю

INSERT INTO shows (name, description, category, duration_minutes, start_time, ticket_price)
VALUES
  ('The Acrobatic Extravaganza', 'A dazzling display of acrobatics, flips, and feats of strength.', 'Acrobatics', 45, '2024-04-25 19:00:00', 30.00),
  ('The Illusions of Magic Steve', 'Prepare to be amazed by mind-blowing magic and illusions.', 'Magic Show', 60, '2024-04-26 14:00:00', 35.00),
  ('The Roar of the Jungle', 'Witness the power and grace of exotic animals in this thrilling show.', 'Animal Show', 30, '2024-04-26 19:00:00', 25.00),
  ('The BMX Kings', 'Hold on tight as these BMX riders defy gravity with incredible stunts.', 'Stunt Show', 25, '2024-04-27 14:00:00', 20.00),
  ('The Symphony of Light', 'A mesmerizing light show set to beautiful music.', 'Light Show', 40, '2024-04-27 19:00:00', 25.00),
  ('The Juggling Jesters', 'Laughter and amazement collide with these hilarious and talented jugglers.', 'Juggling & Comedy', 30, '2024-04-28 14:00:00', 20.00),
  ('The Balancing Elephants', 'Marvel at the strength and coordination of these magnificent creatures as they perform incredible feats of balance.', 'Animal Show', 30, '2024-04-28 19:00:00', 30.00),
  ('The Daring Trapeze Artists', 'Be amazed by the grace and skill of these acrobats as they perform high-flying stunts on the trapeze.', 'Acrobatics', 20, '2024-04-29 14:00:00', 25.00),
  ('The Laser Labyrinth', 'Navigate your way through a dazzling maze of lasers and lights.', 'Interactive Show', NULL, '2024-04-29 19:00:00', 15.00),  
  ('The Unicycle Extravaganza', 'A display of skill and balance on one wheel!', 'Comedy & Acrobatics', 30, '2024-04-30 14:00:00', 20.00),
  ('The Sea Lion Splash', 'Watch these playful sea lions perform tricks and entertain the crowd.', 'Animal Show', 20, '2024-04-30 19:00:00', 25.00),
  ('The Fire & Ice Spectacular', 'A breathtaking display of fire dancing and ice skating artistry.', 'Special Show', 45, '2024-05-01 14:00:00', 35.00),
  ('The Canine Capers', 'Witness the incredible talents and tricks of these amazing dogs.', 'Animal Show', 25, '2024-05-01 19:00:00', 20.00);
