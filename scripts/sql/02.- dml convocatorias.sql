--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-12-22 23:46:20

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
-- TOC entry 3504 (class 0 OID 16688)
-- Dependencies: 214
-- Data for Name: ParEstadoConvocatoria; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (1, 'Abierta', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (2, 'Cerrada', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (3, 'En Revisión', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (4, 'Cancelada', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (5, 'Suspendida', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (6, 'Finalizada', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoConvocatoria" VALUES (7, 'En Espera', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3522 (class 0 OID 16760)
-- Dependencies: 232
-- Data for Name: Convocatoria; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

INSERT INTO "Convocatorias"."Convocatoria" VALUES (1, 'string', 'string', 1, '2024-11-19', '2024-11-19', 0, 0, 'string', NULL, '2024-11-19 09:29:42.798208', NULL, NULL);
INSERT INTO "Convocatorias"."Convocatoria" VALUES (5, 'string', 'string', 1, '2024-12-05', '2024-12-05', 0, 0, 'string', NULL, '2024-12-05 04:23:39.84478', NULL, NULL);


--
-- TOC entry 3542 (class 0 OID 17905)
-- Dependencies: 252
-- Data for Name: ExperienciaPuntos; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

INSERT INTO "Convocatorias"."ExperienciaPuntos" VALUES (1, 1, 1, 10, 50, true, '2024-11-26 23:36:01.069743', NULL, NULL, NULL);
INSERT INTO "Convocatorias"."ExperienciaPuntos" VALUES (2, 1, 2, 2, 80, false, '2024-11-26 23:36:28.705295', NULL, NULL, NULL);
INSERT INTO "Convocatorias"."ExperienciaPuntos" VALUES (3, 1, 1, 10, 50, true, '2024-11-26 23:36:53.030104', NULL, NULL, NULL);


--
-- TOC entry 3512 (class 0 OID 16720)
-- Dependencies: 222
-- Data for Name: ParNivelFormacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (1, 'Bachiller', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (2, 'Estudiante Universitario', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (3, 'Tecnico Medio', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (4, 'Tecnico Superior', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (5, 'Egresado', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (6, 'Licenciatura', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (7, 'Diplomado', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (8, 'Maestria', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (9, 'Doctorado', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelFormacion" VALUES (10, 'Post Doctorado', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3544 (class 0 OID 17918)
-- Dependencies: 254
-- Data for Name: NivelFormacionPuntos; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

INSERT INTO "Convocatorias"."NivelFormacionPuntos" VALUES (1, 1, 1, 200, '2024-11-26 23:39:51.544023', NULL, NULL, NULL);


--
-- TOC entry 3506 (class 0 OID 16696)
-- Dependencies: 216
-- Data for Name: ParEstadoPostulacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParEstadoPostulacion" VALUES (1, 'Pendiente', false, '', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoPostulacion" VALUES (2, 'Preseleccionado', true, 'Ha sido preseleccionado para la siguiente fase.', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoPostulacion" VALUES (3, 'Evaluacion Tecnica', true, 'Debe presentar la evaluación técnica.', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoPostulacion" VALUES (4, 'Entrevista', true, 'Se ha programado una entrevista.', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParEstadoPostulacion" VALUES (5, 'Contratado', true, '¡Felicitaciones! Ha sido contratado.', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3520 (class 0 OID 16752)
-- Dependencies: 230
-- Data for Name: Postulante; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

INSERT INTO "Postulantes"."Postulante" VALUES (3, 'string', 'string', 'string', 'string', 'string', 'string', '2024-11-19', 'string', 'string', 'string', 'string', 'string', 'string', 'string', 'string', '2024-11-19 09:28:37.087077', NULL, NULL, NULL, 'string', 2);
INSERT INTO "Postulantes"."Postulante" VALUES (1, 'string', 'string', 'string', 'string', 'string', 'string', '2024-12-05', 'string', 'string', 'string', 'string', 'string', 'string', 'string', 'string', '2024-12-05 04:45:25.608051', NULL, NULL, NULL, 'string', NULL);


--
-- TOC entry 3536 (class 0 OID 16896)
-- Dependencies: 246
-- Data for Name: Postulacion; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

INSERT INTO "Convocatorias"."Postulacion" VALUES (1, 1, 3, '2024-11-19', 0, 1, '{"nombres":"string","apellidoPaterno":"string","apellidoMaterno":"string","email":"string","numeroDocumento":"string","documentoExpedido":"string","fechaNacimiento":"2024-11-19","ciudadNacimiento":"string","paisNacimiento":"string","ciudadResidencia":"string","paisResidencia":"string","direccion":"string","zona":"string","telefono":"string","telefonoMovil":"string","fotografia":"string","formacionesAcademicas":[],"capacitaciones":[],"conocimientosIdiomas":[],"conocimientosSistemas":[],"referenciasLaborales":[],"referenciasPersonales":[],"experienciaLaboral":[],"id":3,"fechaCreacion":"2024-11-19T09:28:37.087077"}', NULL, NULL, NULL, NULL, 0, true, 'string', 0, true);


--
-- TOC entry 3538 (class 0 OID 16919)
-- Dependencies: 248
-- Data for Name: Notificacion; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--



--
-- TOC entry 3508 (class 0 OID 16704)
-- Dependencies: 218
-- Data for Name: ParIdioma; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParIdioma" VALUES (1, 'ALEMAN', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (2, 'AYMARA', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (3, 'FRANCES', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (4, 'GUARANI', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (5, 'INGLES', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (6, 'JAPONES', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (7, 'PORTUGUES', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParIdioma" VALUES (8, 'QUECHUA', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3510 (class 0 OID 16712)
-- Dependencies: 220
-- Data for Name: ParNivelConocimiento; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParNivelConocimiento" VALUES (1, 'Básico', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelConocimiento" VALUES (2, 'Intermedio', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParNivelConocimiento" VALUES (3, 'Avanzado', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3514 (class 0 OID 16728)
-- Dependencies: 224
-- Data for Name: ParParentesco; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParParentesco" VALUES (1, 'ABUELO', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (2, 'BISABUELOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (3, 'BIZNIETOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (4, 'CUÑADO', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (5, 'CONYUGUE', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (6, 'HERMANOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (7, 'HIJOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (8, 'NIETOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (9, 'YERNO-NUERA', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (10, 'PADRES', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (11, 'PRIMOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (12, 'SOBRINOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (13, 'SUEGROS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (14, 'TIOS', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (15, 'AMISTAD', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParParentesco" VALUES (16, 'OTRO', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3516 (class 0 OID 16736)
-- Dependencies: 226
-- Data for Name: ParPrograma; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParPrograma" VALUES (1, 'MICROSOFT OFFICE EXCEL', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParPrograma" VALUES (2, 'MICROSOFT OFFICE OUTLOOK', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParPrograma" VALUES (3, 'MICROSOFT OFFICE POWER POINT', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParPrograma" VALUES (4, 'MICROSOFT OFFICE WORD', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParPrograma" VALUES (5, 'OTRO', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3518 (class 0 OID 16744)
-- Dependencies: 228
-- Data for Name: ParTipoCapacitacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

INSERT INTO "Parametricas"."ParTipoCapacitacion" VALUES (1, 'Conferencia', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParTipoCapacitacion" VALUES (2, 'Curso', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParTipoCapacitacion" VALUES (3, 'Seminario', true, NULL, NULL, NULL, NULL);
INSERT INTO "Parametricas"."ParTipoCapacitacion" VALUES (4, 'Taller', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3524 (class 0 OID 16773)
-- Dependencies: 234
-- Data for Name: Capacitacion; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--



--
-- TOC entry 3526 (class 0 OID 16791)
-- Dependencies: 236
-- Data for Name: ConocimientoIdioma; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--



--
-- TOC entry 3528 (class 0 OID 16824)
-- Dependencies: 238
-- Data for Name: ConocimientoSistemas; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--



--
-- TOC entry 3540 (class 0 OID 17017)
-- Dependencies: 250
-- Data for Name: ExperienciaLaboral; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--



--
-- TOC entry 3530 (class 0 OID 16847)
-- Dependencies: 240
-- Data for Name: FormacionAcademica; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

INSERT INTO "Postulantes"."FormacionAcademica" VALUES (1, 3, 1, 'string', 'string', '2024-11-20', 'string', 'string', '2024-11-20 06:13:26.73058', NULL, NULL, NULL);


--
-- TOC entry 3532 (class 0 OID 16865)
-- Dependencies: 242
-- Data for Name: ReferenciaLaboral; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--



--
-- TOC entry 3534 (class 0 OID 16878)
-- Dependencies: 244
-- Data for Name: ReferenciaPersonal; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

INSERT INTO "Postulantes"."ReferenciaPersonal" VALUES (2, 3, 'string', 'string', 'string', 'string', 'string', 1, 'string', '2024-11-20 06:18:56.158538', NULL, NULL, NULL);


--
-- TOC entry 3502 (class 0 OID 16680)
-- Dependencies: 212
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" VALUES ('20241104155602_InicioMigracion', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241104160424_InicioMigracionCorreccion', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241104164217_InicioMigracionCorreccion2', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241104194150_InicioMigracionCorreccion3', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241104194822_InicioMigracionCorreccion4', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241107095508_actualizacionCampos', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241107103444_actualizacionCampos2', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241118023631_agregarcolumnafoto', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241119143052_adicionParametro', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241127033030_adicionpuntos', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241207124620_adicionusuario', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241207124650_usuarioconvocatoria', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241211021018_usuarioidnull', '7.0.20');


--
-- TOC entry 3550 (class 0 OID 0)
-- Dependencies: 231
-- Name: Convocatoria_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Convocatoria_Id_seq"', 5, true);


--
-- TOC entry 3551 (class 0 OID 0)
-- Dependencies: 251
-- Name: ExperienciaPuntos_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."ExperienciaPuntos_Id_seq"', 3, true);


--
-- TOC entry 3552 (class 0 OID 0)
-- Dependencies: 253
-- Name: NivelFormacionPuntos_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."NivelFormacionPuntos_Id_seq"', 1, true);


--
-- TOC entry 3553 (class 0 OID 0)
-- Dependencies: 247
-- Name: Notificacion_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Notificacion_Id_seq"', 1, false);


--
-- TOC entry 3554 (class 0 OID 0)
-- Dependencies: 245
-- Name: Postulacion_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Postulacion_Id_seq"', 1, true);


--
-- TOC entry 3555 (class 0 OID 0)
-- Dependencies: 213
-- Name: ParEstadoConvocatoria_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstadoConvocatoria_Id_seq"', 1, false);


--
-- TOC entry 3556 (class 0 OID 0)
-- Dependencies: 215
-- Name: ParEstadoPostulacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstadoPostulacion_Id_seq"', 1, false);


--
-- TOC entry 3557 (class 0 OID 0)
-- Dependencies: 217
-- Name: ParIdioma_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParIdioma_Id_seq"', 1, false);


--
-- TOC entry 3558 (class 0 OID 0)
-- Dependencies: 219
-- Name: ParNivelConocimiento_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParNivelConocimiento_Id_seq"', 1, false);


--
-- TOC entry 3559 (class 0 OID 0)
-- Dependencies: 221
-- Name: ParNivelFormacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParNivelFormacion_Id_seq"', 1, false);


--
-- TOC entry 3560 (class 0 OID 0)
-- Dependencies: 223
-- Name: ParParentesco_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParParentesco_Id_seq"', 1, false);


--
-- TOC entry 3561 (class 0 OID 0)
-- Dependencies: 225
-- Name: ParPrograma_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParPrograma_Id_seq"', 1, false);


--
-- TOC entry 3562 (class 0 OID 0)
-- Dependencies: 227
-- Name: ParTipoCapacitacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParTipoCapacitacion_Id_seq"', 1, false);


--
-- TOC entry 3563 (class 0 OID 0)
-- Dependencies: 233
-- Name: Capacitacion_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."Capacitacion_Id_seq"', 1, false);


--
-- TOC entry 3564 (class 0 OID 0)
-- Dependencies: 235
-- Name: ConocimientoIdioma_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ConocimientoIdioma_Id_seq"', 1, false);


--
-- TOC entry 3565 (class 0 OID 0)
-- Dependencies: 237
-- Name: ConocimientoSistemas_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ConocimientoSistemas_Id_seq"', 1, false);


--
-- TOC entry 3566 (class 0 OID 0)
-- Dependencies: 249
-- Name: ExperienciaLaboral_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ExperienciaLaboral_Id_seq"', 1, false);


--
-- TOC entry 3567 (class 0 OID 0)
-- Dependencies: 239
-- Name: FormacionAcademica_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."FormacionAcademica_Id_seq"', 1, true);


--
-- TOC entry 3568 (class 0 OID 0)
-- Dependencies: 229
-- Name: Postulante_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."Postulante_Id_seq"', 1, true);


--
-- TOC entry 3569 (class 0 OID 0)
-- Dependencies: 241
-- Name: ReferenciaLaboral_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ReferenciaLaboral_Id_seq"', 1, false);


--
-- TOC entry 3570 (class 0 OID 0)
-- Dependencies: 243
-- Name: ReferenciaPersonal_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ReferenciaPersonal_Id_seq"', 2, true);


-- Completed on 2024-12-22 23:46:21

--
-- PostgreSQL database dump complete
--

