--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-12-22 23:46:52

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
-- TOC entry 3355 (class 0 OID 17055)
-- Dependencies: 217
-- Data for Name: ParTipoRecurso; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParTipoRecurso" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (1, 'Imagen
', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParTipoRecurso" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (2, 'Video', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParTipoRecurso" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (3, 'Otro', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3357 (class 0 OID 17063)
-- Dependencies: 219
-- Data for Name: Recurso; Type: TABLE DATA; Schema: Noticias; Owner: postgres
--

INSERT INTO "Noticias"."Recurso" ("Id", "Nombre", "ParTipoRecursoId", "RecursoEscritorio", "RecursoMovil", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (1, 'IMG_20220611_102805', 1, '/assets///IMG_20220611_102805_1704e965.jpg', NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 3351 (class 0 OID 17039)
-- Dependencies: 213
-- Data for Name: ParCategoria; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParCategoria" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (1, 'Noticia', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3353 (class 0 OID 17047)
-- Dependencies: 215
-- Data for Name: ParEstado; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParEstado" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") VALUES (1, 'Publicado', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3359 (class 0 OID 17076)
-- Dependencies: 221
-- Data for Name: Noticia; Type: TABLE DATA; Schema: Noticias; Owner: postgres
--



--
-- TOC entry 3349 (class 0 OID 17031)
-- Dependencies: 211
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20240709215046_inicio', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20240724020422_actualización-referencias-bannerPagina', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20241111040628_actualizacionDatetime', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20241111054131_RecursoIdOpcional', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES ('20241111060825_RecursoIdOpcional2', '7.0.20');


--
-- TOC entry 3365 (class 0 OID 0)
-- Dependencies: 220
-- Name: Noticia_Id_seq; Type: SEQUENCE SET; Schema: Noticias; Owner: postgres
--

SELECT pg_catalog.setval('"Noticias"."Noticia_Id_seq"', 1, false);


--
-- TOC entry 3366 (class 0 OID 0)
-- Dependencies: 218
-- Name: Recurso_Id_seq; Type: SEQUENCE SET; Schema: Noticias; Owner: postgres
--

SELECT pg_catalog.setval('"Noticias"."Recurso_Id_seq"', 1, true);


--
-- TOC entry 3367 (class 0 OID 0)
-- Dependencies: 212
-- Name: ParCategoria_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParCategoria_Id_seq"', 1, true);


--
-- TOC entry 3368 (class 0 OID 0)
-- Dependencies: 214
-- Name: ParEstado_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstado_Id_seq"', 1, true);


--
-- TOC entry 3369 (class 0 OID 0)
-- Dependencies: 216
-- Name: ParTipoRecurso_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParTipoRecurso_Id_seq"', 3, true);


-- Completed on 2024-12-22 23:46:52

--
-- PostgreSQL database dump complete
--

