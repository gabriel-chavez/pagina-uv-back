--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-11-11 07:16:42

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
-- TOC entry 3359 (class 0 OID 17710)
-- Dependencies: 221
-- Data for Name: Noticia; Type: TABLE DATA; Schema: Noticias; Owner: postgres
--

COPY "Noticias"."Noticia" ("Id", "Titulo", "TituloCorto", "Contenido", "Resumen", "RecursoId_ImagenPrincipal", "Fecha", "ParCategoriaId", "ParEstadoId", "Etiquetas", "Orden", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
4	UNIVIDA S.A. lleva a cabo el “I Simposio Internacional: Perspectivas Globales del Mercado Asegurador”	I Simposio Internacional	**UNIVIDA S.A. lleva a cabo el “I Simposio Internacional: Perspectivas Globales del Mercado Asegurador”**\n\n**La Paz, 30 de octubre de 2024 (Redacción UNIVIDA).-** Con el objetivo de fomentar una cultura de seguros en Bolivia y crear espacios académicos para el intercambio de conocimientos sobre los desafíos y oportunidades del mercado asegurador, Seguros y Reaseguros Personales **UNIVIDA S.A.** organizó el “I Simposio Internacional: Perspectivas Globales del Mercado Asegurador".\n\nEl evento, que tuvo lugar en el Gran Salón del Hotel Casa Grande en La Paz, reunió a destacados expertos del ámbito asegurador tanto a nivel nacional como internacional, promoviendo un diálogo enriquecedor sobre la actualidad del sector.\n\nEl simposio incluyó ponencias magistrales de líderes en la industria, como Vincenzo Bertoli, representante de Gallagher (Perú), quien presentó un análisis de las tendencias actuales en la industria de seguros y reaseguros. Su exposición abarcó el impacto de la pandemia en el sector, las innovaciones tecnológicas emergentes y regulatorios entorno a los seguros. \n\nEl Gerente General de UNIVIDA S.A., Larry Fernández, enfatizó la relevancia de los seguros obligatorios en Bolivia, mismo que están comprometidos con la   protección del derecho a la salud y la vida de las y los bolivianos.\n\nOtra de las ponencias, fue la de María Fernanda Chávez Albornoz, Gerente General de Grupo VDR Asiste (Ecuador), quién abordó el tema de los seguros inclusivos. En su intervención, destacó la importancia de la asistencia para grupos vulnerables, como personas mayores, emprendedores y mujeres, subrayando áreas prioritarias.\n\nMarcelo Renzo Jiménez Córdova, Gerente General de Banco Unión S.A, presentó la evolución del Sistema Financiero en cartera de créditos, el enfoque macroprudencial de los Seguros en las operaciones crediticias, los resultados o beneficios para los clientes/asegurados (pagos de siniestros DGH-RTC) y las oportunidades de crecimiento y la democratización de servicios financieros.\n\nPor su lado, Adolfo Juan Boyermán Galván, Gerente General de UNIBIENES S.A., presentó la experiencia del cliente (Customer Experience), el recorrido del cliente (Customer Journey), la mejora de la experiencia del cliente de seguros y los nuevos perfiles de consumidores.\n\nEdgar Chávez, Vicepresidente de Hannover Re (Alemania), ofreció una visión integral del mercado mundial de seguros, destacando factores clave que influyen en el desarrollo del sector en Latinoamérica y analizando las tendencias actuales.\n\nFinalmente, Fabiola Justiniano Zeballos, Gerente General de Addiuva Bolivia (Colombia), centró su presentación en el impacto de la tecnología y la innovación en la industria aseguradora. Habló sobre el uso de análisis de datos e inteligencia artificial en la gestión de riesgos, así como las tendencias innovadoras.\n\nEl simposio incluyó un panel de expertos que discutió temas cruciales para el sector, aportando conocimientos y experiencias valiosas al sector.\n\n**UNIVIDA S.A.** se enorgullece de ofrecer esta plataforma, que se consolida como un punto de encuentro esencial para el intercambio de ideas y la innovación para el mercado asegurador boliviano.\n\n \n\n**¡Bolivianos protegiendo bolivianos!**	**La Paz, 30 de octubre de 2024 (Redacción UNIVIDA).- Con el objetivo de fomentar una cultura de seguros en Bolivia y crear espacios académicos para el intercambio de conocimientos sobre los desafíos y oportunidades del mercado asegurador, Seguros y Reaseguros Personales UNIVIDA S.A. organizó el “I Simposio Internacional: Perspectivas Globales del Mercado Asegurador".**	\N	2024-11-11 00:00:00	1	1	sdfsdfsdfsdf	0	\N	\N	\N	\N
\.


--
-- TOC entry 3357 (class 0 OID 17697)
-- Dependencies: 219
-- Data for Name: Recurso; Type: TABLE DATA; Schema: Noticias; Owner: postgres
--

COPY "Noticias"."Recurso" ("Id", "Nombre", "ParTipoRecursoId", "RecursoEscritorio", "RecursoMovil", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
\.


--
-- TOC entry 3351 (class 0 OID 17673)
-- Dependencies: 213
-- Data for Name: ParCategoria; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParCategoria" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
1	Principal	t	\N	\N	\N	\N
\.


--
-- TOC entry 3353 (class 0 OID 17681)
-- Dependencies: 215
-- Data for Name: ParEstado; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParEstado" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
1	Publicado	t	\N	\N	\N	\N
\.


--
-- TOC entry 3355 (class 0 OID 17689)
-- Dependencies: 217
-- Data for Name: ParTipoRecurso; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParTipoRecurso" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
\.


--
-- TOC entry 3349 (class 0 OID 17665)
-- Dependencies: 211
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20240709215046_inicio	7.0.20
20240724020422_actualización-referencias-bannerPagina	7.0.20
20241111040628_actualizacionDatetime	7.0.20
20241111054131_RecursoIdOpcional	7.0.20
20241111060825_RecursoIdOpcional2	7.0.20
\.


--
-- TOC entry 3366 (class 0 OID 0)
-- Dependencies: 220
-- Name: Noticia_Id_seq; Type: SEQUENCE SET; Schema: Noticias; Owner: postgres
--

SELECT pg_catalog.setval('"Noticias"."Noticia_Id_seq"', 4, true);


--
-- TOC entry 3367 (class 0 OID 0)
-- Dependencies: 218
-- Name: Recurso_Id_seq; Type: SEQUENCE SET; Schema: Noticias; Owner: postgres
--

SELECT pg_catalog.setval('"Noticias"."Recurso_Id_seq"', 1, false);


--
-- TOC entry 3368 (class 0 OID 0)
-- Dependencies: 212
-- Name: ParCategoria_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParCategoria_Id_seq"', 1, true);


--
-- TOC entry 3369 (class 0 OID 0)
-- Dependencies: 214
-- Name: ParEstado_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstado_Id_seq"', 1, true);


--
-- TOC entry 3370 (class 0 OID 0)
-- Dependencies: 216
-- Name: ParTipoRecurso_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParTipoRecurso_Id_seq"', 1, false);


-- Completed on 2024-11-11 07:16:42

--
-- PostgreSQL database dump complete
--

