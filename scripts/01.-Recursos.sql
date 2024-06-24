--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-06-20 01:16:28

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 3354 (class 0 OID 17056)
-- Dependencies: 225
-- Data for Name: Recursos; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

INSERT INTO "Recurso"."Recursos" VALUES (1, 'baner prueba', 1, '/assets/images/backgrounds/page-header-bg.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (2, 'Compra soat', 1, '/assets/images/soat/compra-web.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (3, 'Descarga App', 1, '/assets/images/soat/unividaapp.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (4, 'Puntos de venta', 1, '/assets/images/soat/puntos.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (5, 'Redes sociales', 1, '/assets/images/soat/facebook-whatsapp.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (6, 'Precios SOAT', 1, '/assets/images/soat/precios-soat.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (7, 'Datos SOAT', 1, '/assets/images/soat/datos-vehiculo.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (8, 'Comprobante SOAT', 1, '/assets/images/soat/comprobante-soat.jpg', NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 3360 (class 0 OID 0)
-- Dependencies: 224
-- Name: Recursos_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."Recursos_Id_seq"', 1, false);


-- Completed on 2024-06-20 01:16:29

--
-- PostgreSQL database dump complete
--

