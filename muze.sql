-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 02 Oca 2023, 17:07:04
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `muze`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bilet`
--

DROP TABLE IF EXISTS `bilet`;
CREATE TABLE IF NOT EXISTS `bilet` (
  `biletno` int(3) NOT NULL,
  `kartno` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `skt` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cvv` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `duyuru`
--

DROP TABLE IF EXISTS `duyuru`;
CREATE TABLE IF NOT EXISTS `duyuru` (
  `baslik` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `icerik` varchar(2000) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `duyuru`
--

INSERT INTO `duyuru` (`baslik`, `icerik`) VALUES
('KAPALIYIZ', 'Ankara Cumhuriyet Müzesi 05 OCAK 2023 tarihinde 1 gün süre ile geçici olarak ziyarete kapatılacaktır');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iletisim`
--

DROP TABLE IF EXISTS `iletisim`;
CREATE TABLE IF NOT EXISTS `iletisim` (
  `ad` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `soyad` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tel` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `icerik` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `iletisim`
--

INSERT INTO `iletisim` (`ad`, `soyad`, `email`, `tel`, `icerik`) VALUES
('fsd', 'gbv', 'xfbvx', 'xfbvvvv', 'dgvvvvv');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

DROP TABLE IF EXISTS `kullanici`;
CREATE TABLE IF NOT EXISTS `kullanici` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usr` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `usr` (`usr`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`id`, `usr`, `pwd`) VALUES
(1, 'nuri', '123123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `mlistesi`
--

DROP TABLE IF EXISTS `mlistesi`;
CREATE TABLE IF NOT EXISTS `mlistesi` (
  `icerik` varchar(2500) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `mlistesi`
--

INSERT INTO `mlistesi` (`icerik`) VALUES
('CUMHURİYET MÜZESİ :\r\n Bina, \"Birinci Ulusal Mimarlık Akımı\" öncülerinden Vedat TEK tarafından, 1923 te Cumhuriyet Halk Partisi binası olarak inşa edildi. İlk Türkiye Büyük Millet Meclisi binasının meclise yetersiz gelmesi nedeniyle Atatürk ün talimatıyla meclis binası olarak düzenlendi. 18 Ekim 1924 ten itibaren de meclis binası olarak hizmet vermeye başladı. Selçuklu ve Osmanlı bezeme motiflerinin yer aldığı tavan süslemeleri: kemer, saçak ve çinileriyle cumhuriyet dönemi mimarisini yansıtan bu yapı, işlevini 1960 yılına kadar sürdürdü.'),
('fff'),
('kkkkk');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
