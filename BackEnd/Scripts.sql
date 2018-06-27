--TABLAS---------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS `trabajos` (
  `id` INTEGER PRIMARY KEY ASC,
  `nombre` TEXT,
  `title` TEXT,
  `listing_title` TEXT,
  `size` TEXT,
  `queue_name` TEXT,
  `local_server` TEXT,
  `customer_name` TEXT,
  `owner` TEXT,
  `host_name` TEXT,
  `device` TEXT,
  `fecha` TEXT NOT NULL ,
  `pages` TEXT,
  `size_pdf` TEXT,
  `status` TEXT
)