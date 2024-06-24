--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-06-20 01:18:51

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
-- TOC entry 3356 (class 0 OID 17069)
-- Dependencies: 227
-- Data for Name: Secciones; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."Secciones" VALUES (1, 1, 'Seccion compra Soat', NULL, NULL, NULL, 1, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (2, 2, 'Información Soat', '¿CÓMO ADQUIRIR EL SOAT?
', 'Opciones para obtener tu
SOAT de manera rápida y sencilla', NULL, 1, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (3, 3, 'Servicios Soat', 'SERVICIOS SOAT
', 'Explora nuestros servicios
relacionados con el SOAT', NULL, 1, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (4, 4, 'Sección Accidentes
', 'ACCIDENTES DE TRÁNSITO
', '¿Qué hacer en caso de
un accidente de tránsito?', NULL, 1, 3, NULL, NULL, NULL, NULL);


--
-- TOC entry 3362 (class 0 OID 0)
-- Dependencies: 226
-- Name: Secciones_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Secciones_Id_seq"', 1, false);


-- Completed on 2024-06-20 01:18:51

--
-- PostgreSQL database dump complete
--

