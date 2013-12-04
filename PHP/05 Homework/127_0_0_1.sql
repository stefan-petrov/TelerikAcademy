-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2013 at 04:18 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `homework5`
--
CREATE DATABASE IF NOT EXISTS `homework5` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `homework5`;

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE IF NOT EXISTS `authors` (
  `author_id` int(11) NOT NULL AUTO_INCREMENT,
  `author_name` varchar(50) NOT NULL,
  PRIMARY KEY (`author_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`author_id`, `author_name`) VALUES
(1, 'Толкин'),
(2, 'Дж.Мартин'),
(3, 'Шекспир'),
(4, 'Дан Браун');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_title` varchar(50) NOT NULL,
  PRIMARY KEY (`book_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `book_title`) VALUES
(1, 'Пир за врани'),
(2, 'Властелинът на пръстените'),
(3, 'Шестото клеймо'),
(4, 'Шифърът на Леонардо'),
(5, 'Математика 11 клас'),
(6, 'Природознание 6 клас'),
(7, 'География 5клас'),
(8, 'История 10 клас'),
(9, 'Литература 11 клас');

-- --------------------------------------------------------

--
-- Table structure for table `books_authors`
--

CREATE TABLE IF NOT EXISTS `books_authors` (
  `book_id` int(11) NOT NULL,
  `author_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books_authors`
--

INSERT INTO `books_authors` (`book_id`, `author_id`) VALUES
(1, 2),
(2, 1),
(3, 4),
(4, 4),
(5, 1),
(5, 2),
(5, 4),
(6, 2),
(6, 3),
(7, 3),
(7, 4),
(8, 1),
(8, 2),
(9, 1),
(9, 3),
(9, 4);

-- --------------------------------------------------------

--
-- Table structure for table `books_comments`
--

CREATE TABLE IF NOT EXISTS `books_comments` (
  `book_id` int(11) NOT NULL,
  `comment_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books_comments`
--

INSERT INTO `books_comments` (`book_id`, `comment_id`) VALUES
(2, 1),
(3, 2),
(1, 3),
(4, 4),
(4, 5),
(2, 6),
(3, 7),
(1, 8),
(6, 9),
(9, 10),
(7, 11),
(4, 12),
(3, 13),
(2, 14),
(7, 15),
(8, 16),
(2, 17),
(5, 18),
(6, 19),
(4, 20),
(4, 21);

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE IF NOT EXISTS `comments` (
  `comment_id` int(11) NOT NULL AUTO_INCREMENT,
  `comment_content` varchar(250) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `comment_date` datetime NOT NULL,
  PRIMARY KEY (`comment_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`comment_id`, `comment_content`, `user_name`, `comment_date`) VALUES
(1, 'Любимата ми книга', 'gotiniq66', '2013-10-25 15:38:33'),
(2, 'не ме кефи', 'gotiniq66', '2013-10-25 15:38:44'),
(3, 'Страхотна книга 6+++', 'gotiniq66', '2013-10-25 15:38:57'),
(4, 'Не съм я чел. Хубава ли е?', 'gotiniq66', '2013-10-25 15:39:18'),
(5, 'горе-долу става, прочети я', 'pesho86', '2013-10-25 15:39:44'),
(6, 'и на мен....', 'pesho86', '2013-10-25 15:39:56'),
(7, 'it sucks', 'pesho86', '2013-10-25 15:40:10'),
(8, 'Много добра', 'pesho86', '2013-10-25 15:40:23'),
(9, 'садасдас', 'pesho86', '2013-10-25 15:40:28'),
(10, 'sfsdfsdsd', 'pesho86', '2013-10-25 15:40:32'),
(11, 'dasdas', 'pesho86', '2013-10-25 15:43:47'),
(12, 'sfsdf', 'gosho22', '2013-10-25 15:44:02'),
(13, 'sdf', 'gosho22', '2013-10-25 15:44:08'),
(14, 'the best', 'gosho22', '2013-10-25 15:44:18'),
(15, 'dfgfgf', 'gosho22', '2013-10-25 15:44:22'),
(16, 'qkooo', 'test', '2013-10-26 11:31:16'),
(17, 'fsadasd', 'test', '2013-10-26 12:14:38'),
(18, 'sfds', 'test', '2013-10-26 12:17:09'),
(19, 'fdfsf', 'test', '2013-10-26 15:33:44'),
(20, 'sdfsfds', 'test', '2013-10-27 17:09:37'),
(21, 'sdfsdfs', 'test', '2013-10-27 17:16:36');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  PRIMARY KEY (`user_id`),
  KEY `user_name` (`user_name`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `password`) VALUES
(1, 'pesho86', 'test'),
(2, 'gosho22', 'test'),
(3, 'gotiniq66', 'test'),
(4, 'test', 'test'),
(5, 'test1', 'test');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
