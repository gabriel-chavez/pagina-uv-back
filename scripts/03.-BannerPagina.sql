--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-06-20 01:18:01

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
-- TOC entry 3358 (class 0 OID 17118)
-- Dependencies: 233
-- Data for Name: BannerPagina; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

INSERT INTO "Recurso"."BannerPagina" VALUES (1, 1, NULL, 1, NULL, NULL, NULL, NULL);


--
-- TOC entry 3364 (class 0 OID 0)
-- Dependencies: 232
-- Name: BannerPagina_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."BannerPagina_Id_seq"', 1, false);


-- Completed on 2024-06-20 01:18:01

--
-- PostgreSQL database dump complete
--

