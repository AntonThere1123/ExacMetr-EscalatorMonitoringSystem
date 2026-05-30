-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Май 30 2026 г., 01:20
-- Версия сервера: 5.7.24
-- Версия PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `excametr_database`
--

-- --------------------------------------------------------

--
-- Структура таблицы `complaints`
--

CREATE TABLE `complaints` (
  `id` int(11) NOT NULL,
  `user_id` int(11) UNSIGNED NOT NULL,
  `escalator_id` int(11) NOT NULL,
  `complaint_text` text NOT NULL,
  `status` enum('New','InProgress','Resolved') NOT NULL DEFAULT 'New',
  `manager_response` text,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `complaints`
--

INSERT INTO `complaints` (`id`, `user_id`, `escalator_id`, `complaint_text`, `status`, `manager_response`, `created_at`) VALUES
(1, 1, 1, 'Эскалатор сильно вибрирует и издает скрежет', 'Resolved', 'Мастер вызван, проблема устранена', '2026-05-25 10:30:00'),
(2, 1, 5, 'Кнопка остановки не работает', 'InProgress', 'Мастер уже в пути', '2026-05-26 14:20:00'),
(3, 30, 3, 'Поручни грязные', 'Resolved', 'Проведена уборка', '2026-05-27 09:15:00'),
(4, 31, 8, 'Слышен странный шум', 'New', NULL, '2026-05-28 16:45:00');

-- --------------------------------------------------------

--
-- Структура таблицы `escalators`
--

CREATE TABLE `escalators` (
  `id` int(11) NOT NULL,
  `location` varchar(200) NOT NULL,
  `status` enum('Working','Maintenance','Broken') NOT NULL DEFAULT 'Working',
  `assigned_master_id` int(11) DEFAULT NULL,
  `last_maintenance_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `escalators`
--

INSERT INTO `escalators` (`id`, `location`, `status`, `assigned_master_id`, `last_maintenance_date`) VALUES
(1, 'м. Автово, выход №1', 'Working', 10, '2025-05-01'),
(2, 'м. Автово, выход №2', 'Working', 10, '2025-05-01'),
(3, 'м. Автово, выход №3', 'Working', 10, '2025-05-10'),
(4, 'м. Автово, выход №4', 'Maintenance', 10, '2025-04-15'),
(5, 'м. Автово, выход №5', 'Broken', 10, '2025-05-20'),
(6, 'м. Невский проспект, выход №1', 'Working', 11, '2025-05-02'),
(7, 'м. Невский проспект, выход №2', 'Working', 11, '2025-05-02'),
(8, 'м. Невский проспект, выход №3', 'Maintenance', 11, '2025-04-20'),
(9, 'м. Невский проспект, выход №4', 'Working', 11, '2025-05-15'),
(10, 'м. Невский проспект, выход №5', 'Working', 11, '2025-05-15'),
(11, 'м. Площадь Восстания, выход №1', 'Working', 12, '2025-05-03'),
(12, 'м. Площадь Восстания, выход №2', 'Working', 12, '2025-05-03'),
(13, 'м. Площадь Восстания, выход №3', 'Working', 12, '2025-05-12'),
(14, 'м. Площадь Восстания, выход №4', 'Working', 12, '2025-05-12'),
(15, 'м. Площадь Восстания, выход №5', 'Working', 12, '2025-05-12'),
(16, 'м. Лиговский проспект, выход №1', 'Working', 13, '2025-05-04'),
(17, 'м. Лиговский проспект, выход №2', 'Working', 13, '2025-05-04'),
(18, 'м. Лиговский проспект, выход №3', 'Working', 13, '2025-05-18'),
(19, 'м. Лиговский проспект, выход №4', 'Working', 13, '2025-05-18'),
(20, 'м. Лиговский проспект, выход №5', 'Maintenance', 13, '2025-04-25'),
(21, 'м. Горьковская, выход №1', 'Working', 14, '2025-05-05'),
(22, 'м. Горьковская, выход №2', 'Working', 14, '2025-05-05'),
(23, 'м. Горьковская, выход №3', 'Working', 14, '2025-05-19'),
(24, 'м. Горьковская, выход №4', 'Working', 14, '2025-05-19'),
(25, 'м. Горьковская, выход №5', 'Working', 14, '2025-05-19'),
(26, 'м. Сенная площадь, выход №1', 'Working', 15, '2025-05-06'),
(27, 'м. Сенная площадь, выход №2', 'Working', 15, '2025-05-06'),
(28, 'м. Сенная площадь, выход №3', 'Working', 15, '2025-05-21'),
(29, 'м. Сенная площадь, выход №4', 'Working', 15, '2025-05-21'),
(30, 'м. Сенная площадь, выход №5', 'Working', 15, '2025-05-21'),
(31, 'м. Технологический институт, выход №1', 'Working', 16, '2025-05-07'),
(32, 'м. Технологический институт, выход №2', 'Working', 16, '2025-05-07'),
(33, 'м. Технологический институт, выход №3', 'Working', 16, '2025-05-22'),
(34, 'м. Технологический институт, выход №4', 'Working', 16, '2025-05-22'),
(35, 'м. Технологический институт, выход №5', 'Working', 16, '2025-05-22'),
(36, 'м. Фрунзенская, выход №1', 'Working', 17, '2025-05-08'),
(37, 'м. Фрунзенская, выход №2', 'Working', 17, '2025-05-08'),
(38, 'м. Фрунзенская, выход №3', 'Working', 17, '2025-05-23'),
(39, 'м. Фрунзенская, выход №4', 'Working', 17, '2025-05-23'),
(40, 'м. Фрунзенская, выход №5', 'Working', 17, '2025-05-23'),
(41, 'м. Московские ворота, выход №1', 'Working', 18, '2025-05-09'),
(42, 'м. Московские ворота, выход №2', 'Working', 18, '2025-05-09'),
(43, 'м. Московские ворота, выход №3', 'Working', 18, '2025-05-24'),
(44, 'м. Московские ворота, выход №4', 'Working', 18, '2025-05-24'),
(45, 'м. Московские ворота, выход №5', 'Working', 18, '2025-05-24'),
(46, 'м. Электросила, выход №1', 'Working', 19, '2025-05-10'),
(47, 'м. Электросила, выход №2', 'Working', 19, '2025-05-10'),
(48, 'м. Электросила, выход №3', 'Maintenance', 19, '2025-04-30'),
(49, 'м. Электросила, выход №4', 'Working', 19, '2025-05-25'),
(50, 'м. Электросила, выход №5', 'Working', 19, '2025-05-25'),
(51, 'м. Парк Победы, выход №1', 'Working', 20, '2025-05-11'),
(52, 'м. Парк Победы, выход №2', 'Working', 20, '2025-05-11'),
(53, 'м. Парк Победы, выход №3', 'Working', 20, '2025-05-26'),
(54, 'м. Парк Победы, выход №4', 'Working', 20, '2025-05-26'),
(55, 'м. Парк Победы, выход №5', 'Working', 20, '2025-05-26'),
(56, 'м. Московская, выход №1', 'Working', 21, '2025-05-12'),
(57, 'м. Московская, выход №2', 'Working', 21, '2025-05-12'),
(58, 'м. Московская, выход №3', 'Working', 21, '2025-05-27'),
(59, 'м. Московская, выход №4', 'Working', 21, '2025-05-27'),
(60, 'м. Московская, выход №5', 'Working', 21, '2025-05-27'),
(61, 'м. Звёздная, выход №1', 'Working', 22, '2025-05-13'),
(62, 'м. Звёздная, выход №2', 'Working', 22, '2025-05-13'),
(63, 'м. Звёздная, выход №3', 'Working', 22, '2025-05-28'),
(64, 'м. Звёздная, выход №4', 'Working', 22, '2025-05-28'),
(65, 'м. Звёздная, выход №5', 'Working', 22, '2025-05-28');

-- --------------------------------------------------------

--
-- Структура таблицы `status_changes`
--

CREATE TABLE `status_changes` (
  `id` int(11) NOT NULL,
  `escalator_id` int(11) NOT NULL,
  `changed_by_manager_id` int(11) NOT NULL,
  `old_status` enum('Working','Maintenance','Broken') NOT NULL,
  `new_status` enum('Working','Maintenance','Broken') NOT NULL,
  `change_reason` varchar(500) DEFAULT NULL,
  `changed_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `status_changes`
--

INSERT INTO `status_changes` (`id`, `escalator_id`, `changed_by_manager_id`, `old_status`, `new_status`, `change_reason`, `changed_at`) VALUES
(1, 5, 5, 'Working', 'Broken', 'Поступила жалоба от пользователя', '2026-05-26 14:25:00'),
(2, 4, 5, 'Working', 'Maintenance', 'Плановое техническое обслуживание', '2026-05-27 09:00:00');

-- --------------------------------------------------------

--
-- Структура таблицы `tasks`
--

CREATE TABLE `tasks` (
  `id` int(11) NOT NULL,
  `master_id` int(11) NOT NULL,
  `escalator_id` int(11) NOT NULL,
  `complaint_id` int(11) DEFAULT NULL,
  `task_text` varchar(500) NOT NULL,
  `status` enum('Pending','InProgress','Completed') NOT NULL DEFAULT 'Pending',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `tasks`
--

INSERT INTO `tasks` (`id`, `master_id`, `escalator_id`, `complaint_id`, `task_text`, `status`, `created_at`) VALUES
(1, 10, 5, 2, 'Проверить и заменить кнопку остановки', 'InProgress', '2026-05-26 14:30:00'),
(2, 10, 4, NULL, 'Провести плановое ТО эскалатора', 'Pending', '2026-05-27 09:05:00');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Last Name` varchar(100) NOT NULL,
  `Role` enum('Manager','Master','User') NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Phone_Number` varchar(40) DEFAULT NULL,
  `IsActive` int(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

-- Пользователь (id=1)
INSERT INTO `users` (`id`, `login`, `Password`, `Name`, `Last Name`, `Role`, `Email`, `Phone_Number`, `IsActive`) VALUES
(1, 'Ант', '112', 'Антон', 'Носов', 'User', 'ant@mail.ru', '+7 (977) 872-09-06', 1);

-- Менеджеры
INSERT INTO `users` (`id`, `login`, `Password`, `Name`, `Last Name`, `Role`, `Email`, `Phone_Number`, `IsActive`) VALUES
(5, 'KApusta1212', '15572329', 'Альберт', 'Вескер', 'Manager', 'manager1@excametr.ru', '+7 (911) 232-93-29', 1);

-- Мастера (id 10-29)
INSERT INTO `users` (`id`, `login`, `Password`, `Name`, `Last Name`, `Role`, `Email`, `Phone_Number`, `IsActive`) VALUES
(10, 'Master_X7K9P', 'HtR5q', 'Алексей', 'Смирнов', 'Master', 'master10@fake-mail.net', '+7 (921) 473-28-15', 1),
(11, 'Tech_W3R2M', 'FdG7k', 'Владимир', 'Кузнецов', 'Master', 'master11@fake-mail.net', '+7 (921) 638-41-92', 0),
(12, 'Mech_8A1Fd', 'JkL9m', 'Денис', 'Попов', 'Master', 'master12@fake-mail.net', '+7 (921) 152-73-46', 0),
(13, 'Serv_0R3nT', 'CfG4h', 'Максим', 'Васильев', 'Master', 'master13@fake-mail.net', '+7 (921) 894-37-61', 0),
(14, 'Eng_N5vQ2', 'LpX2r', 'Артём', 'Соколов', 'Master', 'master14@fake-mail.net', '+7 (921) 256-19-84', 0),
(15, 'Fix_T4x9M', 'QsW1z', 'Евгений', 'Михайлов', 'Master', 'master15@fake-mail.net', '+7 (921) 743-58-27', 0),
(16, 'Repair_K2H8w', 'ZrU8k', 'Игорь', 'Новиков', 'Master', 'master16@fake-mail.net', '+7 (921) 319-62-93', 0),
(17, 'Elec_P6yJ3', 'YhV7b', 'Павел', 'Фёдоров', 'Master', 'master17@fake-mail.net', '+7 (921) 597-44-18', 0),
(18, 'Check_D1wV8', 'MnC5t', 'Роман', 'Морозов', 'Master', 'master18@fake-mail.net', '+7 (921) 862-73-51', 0),
(19, 'Test_Z9uL4', 'VbR3p', 'Андрей', 'Волков', 'Master', 'master19@fake-mail.net', '+7 (921) 428-95-36', 0),
(20, 'Inspect_A7sX0', 'NdM6c', 'Николай', 'Алексеев', 'Master', 'master20@fake-mail.net', '+7 (921) 673-81-24', 0),
(21, 'Master_B3fYq', 'RcP9v', 'Вадим', 'Лебедев', 'Master', 'master21@fake-mail.net', '+7 (921) 236-57-49', 0),
(22, 'Tech_V8cR2', 'WxM4g', 'Григорий', 'Семёнов', 'Master', 'master22@fake-mail.net', '+7 (921) 749-28-63', 0),
(23, 'Mech_E4tU7', 'TfJ2l', 'Кирилл', 'Егоров', 'Master', 'master23@fake-mail.net', '+7 (921) 184-96-27', 0),
(24, 'Serv_H9wI1', 'PuS3x', 'Станислав', 'Павлов', 'Master', 'master24@fake-mail.net', '+7 (921) 582-74-13', 0),
(25, 'Eng_M2zA6', 'XoB7y', 'Олег', 'Козлов', 'Master', 'master25@fake-mail.net', '+7 (921) 319-65-98', 0),
(26, 'Fix_L5qY0', 'GdN1z', 'Валентин', 'Степанов', 'Master', 'master26@fake-mail.net', '+7 (921) 764-23-81', 0),
(27, 'Repair_J8rB3', 'CsV6f', 'Юрий', 'Николаев', 'Master', 'master27@fake-mail.net', '+7 (921) 427-59-36', 0),
(28, 'Elec_S1hD4', 'KoL8u', 'Фёдор', 'Григорьев', 'Master', 'master28@fake-mail.net', '+7 (921) 538-27-94', 0),
(29, 'Check_G7oK9', 'JmN4h', 'Тимур', 'Орлов', 'Master', 'master29@fake-mail.net', '+7 (921) 162-83-47', 0);

-- Пользователи (id 30-33)
INSERT INTO `users` (`id`, `login`, `Password`, `Name`, `Last Name`, `Role`, `Email`, `Phone_Number`, `IsActive`) VALUES
(30, 'Walker_R0cP3', 'QdM5v', 'Иван', 'Петров', 'User', 'user30@fake-email.org', '+7 (931) 284-71-56', 0),
(31, 'Runner_N2tF7', 'EuB9x', 'Мария', 'Сидорова', 'User', 'user31@fake-email.org', '+7 (931) 713-62-48', 0),
(32, 'Guest_X9yW5', 'ZmP1c', 'Екатерина', 'Иванова', 'User', 'user32@fake-email.org', '+7 (931) 456-28-79', 0),
(33, 'Furry_D3vK8', 'TrL8w', 'Сергей', 'Матросов', 'User', 'user33@fake-email.org', '+7 (931) 942-35-18', 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `complaints`
--
ALTER TABLE `complaints`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `escalator_id` (`escalator_id`);

--
-- Индексы таблицы `escalators`
--
ALTER TABLE `escalators`
  ADD PRIMARY KEY (`id`),
  ADD KEY `assigned_master_id` (`assigned_master_id`);

--
-- Индексы таблицы `status_changes`
--
ALTER TABLE `status_changes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `escalator_id` (`escalator_id`);

--
-- Индексы таблицы `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `master_id` (`master_id`),
  ADD KEY `escalator_id` (`escalator_id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `complaints`
--
ALTER TABLE `complaints`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `escalators`
--
ALTER TABLE `escalators`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT для таблицы `status_changes`
--
ALTER TABLE `status_changes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `tasks`
--
ALTER TABLE `tasks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `complaints`
--
ALTER TABLE `complaints`
  ADD CONSTRAINT `complaints_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `complaints_ibfk_2` FOREIGN KEY (`escalator_id`) REFERENCES `escalators` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `escalators`
--
ALTER TABLE `escalators`
  ADD CONSTRAINT `escalators_ibfk_1` FOREIGN KEY (`assigned_master_id`) REFERENCES `users` (`id`) ON DELETE SET NULL;

--
-- Ограничения внешнего ключа таблицы `status_changes`
--
ALTER TABLE `status_changes`
  ADD CONSTRAINT `status_changes_ibfk_1` FOREIGN KEY (`escalator_id`) REFERENCES `escalators` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tasks`
--
ALTER TABLE `tasks`
  ADD CONSTRAINT `tasks_ibfk_1` FOREIGN KEY (`master_id`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `tasks_ibfk_2` FOREIGN KEY (`escalator_id`) REFERENCES `escalators` (`id`) ON DELETE CASCADE;

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;