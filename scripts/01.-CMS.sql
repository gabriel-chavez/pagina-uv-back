--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-11-11 07:15:50

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
-- TOC entry 3441 (class 0 OID 17016)
-- Dependencies: 216
-- Data for Name: CatTipoRecurso; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

COPY "Catalogo"."CatTipoRecurso" ("Id", "Nombre", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Habilitado") FROM stdin;
1	Imagen	\N	\N	\N	\N	f
2	Video	\N	\N	\N	\N	f
3	Archivo	\N	\N	\N	\N	f
\.


--
-- TOC entry 3443 (class 0 OID 17024)
-- Dependencies: 218
-- Data for Name: CatTipoSeccion; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

COPY "Catalogo"."CatTipoSeccion" ("Id", "Nombre", "Descripcion", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Habilitado", "ImagenSeccion", "ImagenSeccionGuia") FROM stdin;
5	SeccionContenidoTipo1	Titulo texto e imagen	\N	\N	\N	\N	t		
6	SeccionContenidoTipo4	Imagenes, titulo, subtitulo y texto	\N	\N	\N	\N	t		
7	SeccionCardTipo1	3 cards por fila	\N	\N	\N	\N	t		
8	SeccionCardImagenTipo1	imagenes	\N	\N	\N	\N	t		
9	SeccionCardImagenTipo2	card con imagenes y boton	\N	\N	\N	\N	f		
10	SeccionContenedorIFrame	Contenedor iframe	\N	\N	\N	\N	t		
1	SeccionContenidoTipo3	2 columnas	\N	\N	\N	\N	t	\\assets\\images\\secciones\\ContenidoInformativo.png	\\assets\\images\\secciones\\ContenidoInformativoGuia.png
2	SeccionSliderTipo1	Seccion slider tipo 1	\N	\N	\N	\N	t	\\assets\\images\\secciones\\SliderContenidos.png	\\assets\\images\\secciones\\SliderContenidosGuia.png
3	SeccionSliderTipo2	Seccion slider tipo 2	\N	\N	\N	\N	t	\\assets\\images\\secciones\\SliderElementos.png	\\assets\\images\\secciones\\SliderElementosGuia.png
4	SeccionAcordeonTipo1	Seccion acordeon tipo 1	\N	\N	\N	\N	t	\\assets\\images\\secciones\\AcordeonContenido.png	\\assets\\images\\secciones\\AcordeonContenidoGuia.png
\.


--
-- TOC entry 3461 (class 0 OID 17485)
-- Dependencies: 236
-- Data for Name: CatTipoSeguro; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

COPY "Catalogo"."CatTipoSeguro" ("Id", "Nombre", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Seguro de Vida	t	\N	\N	\N	\N
2	Seguro de Accidentes Personales	t	\N	\N	\N	\N
3	Otros Seguros	t	\N	\N	\N	\N
\.


--
-- TOC entry 3463 (class 0 OID 17630)
-- Dependencies: 238
-- Data for Name: MenuPrincipal; Type: TABLE DATA; Schema: Menu; Owner: postgres
--

COPY "Menu"."MenuPrincipal" ("Id", "Nombre", "Url", "IdPadre", "Habilitado", "Visible", "Orden", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "IdPaginaDinamica", "IdSeguro") FROM stdin;
34	Deportista Seguro	deportista-seguro	4	t	t	1	\N	\N	\N	\N	\N	5
35	Gremialista Seguro	gremialista-seguro	4	t	t	1	\N	\N	\N	\N	\N	6
9	Seguro de Desgravamen	desgravamen	4	t	t	0	\N	\N	2024-10-18 06:41:33.318881	\N	\N	\N
15	Puntos de venta	puntos-de-venta	11	t	t	0	\N	\N	2024-10-18 06:41:57.577827	\N	\N	\N
10	Seguro de Cesantía	cesantia	4	t	t	0	\N	\N	2024-10-18 06:41:57.584074	\N	\N	\N
3	Inicio	\N	\N	t	t	1	\N	\N	\N	\N	\N	\N
4	Nuestros Seguros	nuestros-seguros	\N	t	t	2	\N	\N	\N	\N	\N	\N
5	Seguros Obligatorios	seguros-obligatorios	\N	t	t	3	\N	\N	\N	\N	\N	\N
6	Sobre la Empresa	empresa	\N	t	t	4	\N	\N	\N	\N	\N	\N
7	Seguro de Accidentes Personales	accidentes-personales	4	t	t	0	\N	\N	\N	\N	\N	1
8	Seguro de Vida	vida	4	t	t	0	\N	\N	\N	\N	\N	2
11	Soat	soat	5	t	t	0	\N	\N	\N	\N	1	\N
16	Historia	historia	6	t	t	0	\N	\N	\N	\N	2	\N
17	Misión, Visión y Valores	mision-vision-valores	6	t	t	0	\N	\N	\N	\N	3	\N
18	Objetivos Estratégicos	objetivos-estrategicos	6	t	t	0	\N	\N	\N	\N	4	\N
19	Directorio y Plantel Ejecutivo	directorio-plantel-ejecutivo	6	t	t	0	\N	\N	\N	\N	5	\N
20	Estructura Orgánica	estructura-organica	6	t	t	0	\N	\N	\N	\N	6	\N
21	Grupo Financiero Unión	grupo-financiero-union	6	t	t	0	\N	\N	\N	\N	7	\N
22	Gestión Normativa	gestion-normativa	6	t	t	0	\N	\N	\N	\N	8	\N
23	Memorias Empresariales	memorias-empresariales	6	t	t	0	\N	\N	\N	\N	9	\N
14	Precios Soat	precios	11	t	t	0	\N	\N	\N	\N	10	\N
13	Comprar Soat	comprar	11	t	t	0	\N	\N	\N	\N	11	\N
12	Soatc	soatc	5	t	t	0	\N	\N	\N	\N	\N	\N
27	Cobertura Soat	cobertura-soat	11	t	f	0	\N	\N	\N	\N	\N	\N
31	Vida Mujer	vida-mujer	4	t	t	1	\N	\N	\N	\N	\N	3
32	COVID-19	covid-19	4	t	t	1	\N	\N	\N	\N	\N	4
\.


--
-- TOC entry 3459 (class 0 OID 17141)
-- Dependencies: 234
-- Data for Name: Datos; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

COPY "PaginaDinamica"."Datos" ("Id", "DatoTexto", "DatoFechaHora", "DatoUrl", "RecursoId", "SeccionId", "Fila", "Columna", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	¿Qué es el **SOAT**?	\N	\N	\N	1	0	0	\N	\N	\N	\N
2	El artículo 37 de la Ley N° 1883 de Seguros, señala que el SOAT es el “Seguro Obligatorio de Accidentes de Tránsito” que todo vehículo motorizado, público y/o privado, debe contar con carácter obligatorio, para poder transitar por vías públicas del territorio boliviano. Además, la norma señala que, el Seguro es incuestionable y de beneficio uniforme con coberturas por muerte, incapacidad total permanente y gastos médicos.	\N	\N	\N	1	0	1	\N	\N	\N	\N
3	¿Qué necesitas para adquirir el **SOAT?**	\N	\N	\N	1	1	0	\N	\N	\N	\N
5	¿Qué cubre **el SOAT?**	\N	\N	\N	1	2	0	\N	\N	\N	\N
6	- Si falleces por causa de un accidente automovilístico, tus beneficiarios reciben una indemnización de Bs. 22.000\n- Te indemnizamos en caso de invalidez total y permanente con un monto de Bs. 22.000\n- Te indemnizamos con gastos médicos con un monto de hasta Bs. 24.000	\N	\N	\N	1	2	1	\N	\N	\N	\N
7	Requisitos para cambio de uso **PARTICULAR a PÚBLICO o PÚBLICO a PARTICULAR**	\N	\N	\N	1	3	0	\N	\N	\N	\N
8	- Certificado de extravío de la FELC\n- Depósito de Bs.20 (veinte bolivianos 00/100) a la cuenta 1-25041009 del Banco Unión S.A.\n- Comprobante factura SOAT\n- Fotocopia de RUAT\n- Fotocopia de la Cédula de Identidad	\N	\N	\N	1	3	1	\N	\N	\N	\N
9	Página Web	\N	\N	\N	2	0	0	\N	\N	\N	\N
10	bi bi-globe	\N	\N	\N	2	0	1	\N	\N	\N	\N
11	\N	\N	\N	2	2	0	2	\N	\N	\N	\N
13	UNIVidaApp	\N	\N	\N	2	1	0	\N	\N	\N	\N
14	bi bi-phone	\N	\N	\N	2	1	1	\N	\N	\N	\N
15	\N	\N	\N	3	2	1	2	\N	\N	\N	\N
16	DESCARGAR APP	\N	descarga-app	\N	2	1	3	\N	\N	\N	\N
17	Puntos de venta	\N	\N	\N	2	2	0	\N	\N	\N	\N
18	bi bi-geo-alt	\N	\N	\N	2	2	1	\N	\N	\N	\N
19	\N	\N	\N	4	2	2	2	\N	\N	\N	\N
20	Ver Puntos	\N	soat/puntos-de-venta	\N	2	2	3	\N	\N	\N	\N
21	Redes Sociales	\N	\N	\N	2	3	0	\N	\N	\N	\N
22	bi bi-chat-left-dots	\N	\N	\N	2	3	1	\N	\N	\N	\N
23	\N	\N	\N	5	2	3	2	\N	\N	\N	\N
24	VER MÁS	\N	soat/redes-sociales	\N	2	3	3	\N	\N	\N	\N
25	Precios SOAT	\N	\N	\N	3	0	0	\N	\N	\N	\N
26	Verifica el precio del SOAT para tu motorizado	\N	\N	\N	3	0	1	\N	\N	\N	\N
27	bi bi-cash-coin	\N	\N	\N	3	0	2	\N	\N	\N	\N
28	\N	\N	\N	6	3	0	3	\N	\N	\N	\N
29	VER MÁS	\N	soat/precios	\N	3	0	4	\N	\N	\N	\N
32	bi bi-car-front	\N	\N	\N	3	1	2	\N	\N	\N	\N
33	\N	\N	\N	7	3	1	3	\N	\N	\N	\N
35	Comprobante SOAT	\N	\N	\N	3	2	0	\N	\N	\N	\N
36	Adquiere el comprobante SOAT	\N	\N	\N	3	2	1	\N	\N	\N	\N
37	bi bi-file-text	\N	\N	\N	3	2	2	\N	\N	\N	\N
38	\N	\N	\N	8	3	2	3	\N	\N	\N	\N
40	Paso 1 - Succeso del accidente de tránsito	\N	\N	\N	4	0	0	\N	\N	\N	\N
41	- Las víctimas deben ser auxiliadas al centro médico más cercano\n- Dar aviso del siniestro al Organismo Operativo de Tránsito	\N	\N	\N	4	0	1	\N	\N	\N	\N
42	Paso 2 - Dar aviso del siniestro a Seguros y Reaseguros Personales UNIVIDA S.A. a través de:	\N	\N	\N	4	1	0	\N	\N	\N	\N
43	- Línea gratuita del Call Center 800-10-8444 (habilitado las 24 horas y los 7 días de la semana)\n- Correo electrónico o Página Web\n- Sucursales y agencias de UNIVIDA S.A. de lunes a viernes en horarios de oficina\n    \n**Personas que pueden realizar la denuncia:**\n- Personal del centro médico\n- Personal del Organismo Operativo de Tránsito \n- Víctimas\n- Conductor o propietario del vehículo\n- Cualquier persona que acredite interés legal \n\n**Datos que debe proporcionar:**\n- Nombre completo del accidentado\n- Número de placa o número de roseta del vehículo\n- Denuncia realizada a Tránsito\n- Fecha de ocurrencia y descripción del hecho\n- Centro médico al que fue evacuado el accidentado\n- Datos de contacto del denunciante\n    \n    **Nota:** El plazo para realizar la denuncia es de 15 días luego del suceso del accidente.	\N	\N	\N	4	1	1	\N	\N	\N	\N
44	Paso 3 - Apertura del reclamo y verificación de causales de exclusión de cobertura	\N	\N	\N	4	2	0	\N	\N	\N	\N
45	Con el aviso del siniestro, se procede a la asignación del código correspondiente al reclamo y a la apertura física del file con la documentación presentada. A su vez, se evalúan las circunstancias en las que ocurrió el siniestro para su cobertura, verificándose si éstas se enmarcan en alguna de las causales de exclusión de cobertura señaladas en el artículo 32 del Decreto Supremo 27295 de 20 de diciembre de 2003.	\N	\N	\N	4	2	1	\N	\N	\N	\N
46	Paso 4 - Entrega de formulario de requisitos para la cobertura	\N	\N	\N	4	3	0	\N	\N	\N	\N
47	De acuerdo a la evaluación del siniestro y las coberturas requeridas, se entrega al cliente el formulario con la documentación necesaria para otorgar la cobertura correspondiente, de conformidad al artículo 29 del Decreto Supremo 27295 de 20 de diciembre de 2003.	\N	\N	\N	4	3	1	\N	\N	\N	\N
48	Paso 5 - Entrega de la documentación	\N	\N	\N	4	4	0	\N	\N	\N	\N
130	Descargar memoria	2024-09-19 20:26:59.874+00		64	16	6	3	2024-09-20 10:09:23.997502	\N	\N	\N
126	Descargar memoria	2024-09-19 20:26:59.874+00		62	16	5	3	\N	\N	2024-09-20 10:09:33.03698	\N
114	Descargar memoria	2024-09-19 20:26:59.874+00		56	16	2	3	\N	\N	2024-09-20 10:09:48.288691	\N
133		2024-09-20 14:39:43.729+00		\N	17	0	2	\N	\N	2024-09-20 11:11:58.189944	\N
136	100%	2024-09-20 15:38:10.612+00		\N	18	0	1	2024-09-20 11:39:26.234635	\N	\N	\N
30	Cobertura de SOAT	2024-09-20 16:07:44.796+00		\N	3	1	0	\N	\N	2024-09-20 12:07:56.728898	\N
31	Verifica la cobertura de SOAT	2024-09-20 16:08:11.195+00		\N	3	1	1	\N	\N	2024-09-20 12:08:25.700718	\N
39	VER MÁS	2024-09-20 16:37:08.378+00	https://soat.univida.bo:9097/UNIVidaNetSOATClienteFinal/Modulos_/Cliente/Login/wfLoginCliente	\N	3	2	4	\N	\N	2024-09-20 12:37:15.668321	\N
34	VER MÁS	2024-09-20 16:03:28.031+00	https://soat.univida.bo:9097/UNIVidaNetSOATClienteFinal/Modulos_/Cliente/ConsultasVerificacionSoat/wfObtener	\N	3	1	4	\N	\N	2024-09-20 12:37:02.172419	\N
12	COMPRAR SOAT	2024-09-20 16:43:58.894+00	soat/comprar	\N	2	0	3	\N	\N	2024-09-20 12:44:46.844958	\N
49	**Heridos**\n- Documento que identifique al herido\n- Certificado emitido por el organismo operativo de tránsito\n- Certificado médico\n    \n    En caso de víctimas que hayan cancelado al centro médico se solicitará recibos y/o facturas a nombre de Seguros y Reaseguros Personales UNIVIDA S.A. al Nº de NIT 301204024.\n\n**Fallecidos**\n- Documento que identifique al fallecido\n- Certificado emitido por el organismo operativo de tránsito\n- Certificado médico forense o certificado médico (si corresponde)\n\n**Incapacidad total y permanente**\n- Documento que identifique al herido\n- Certificado emitido por el organismo operativo de tránsito\n- Dictamen de calificación de incapacidad emitido por la EEC\n    \n    Seguros y reaseguros UNIVIDA S.A. A requerimiento de la víctima solicitará la calificación de incapacidad de conformidad al artículo 26 del D.S. 27295.	\N	\N	\N	4	4	1	\N	\N	\N	\N
50	Paso 6 - Pago de la indemnización	\N	\N	\N	4	5	0	\N	\N	\N	\N
51	El plazo para el pago es de 15 días hábiles a partir de la recepción de todos los documentos necesarios.\n\n**Indemnización por gastos médicos**\n- Pago de las proformas al centro médico\n- En caso de recibos y/o facturas de las víctimas se procede a su reembolso\n\n**Indemnización por fallecimiento**\n- Pago a los derechohabientes del fallecido\n\nEn caso de existir conflicto de intereses entre los derechohabientes se realiza un depósito judicial.\n\n**Indemnización por incapacidad permanente**\n- Pago de la indemnización a la víctima	\N	\N	\N	4	5	1	\N	\N	\N	\N
52	Paso 7 - Ejercicio del Derecho de Repetición	\N	\N	\N	4	6	0	\N	\N	\N	\N
53	Se verifica la conclusión del reclamo con el pago de todas las indemnizaciones del siniestro. Inicio del proceso de repetición ante la autoridad competente. En caso de existir causales de repetición.	\N	\N	\N	4	6	1	\N	\N	\N	\N
132		2024-09-20 14:35:42.264+00		\N	17	0	1	\N	\N	2024-09-20 11:11:39.559805	\N
131	Precios SOAT 2024	2024-09-20 14:35:42.264+00		\N	17	0	0	\N	\N	2024-09-20 11:11:49.70293	\N
134		2024-09-20 14:39:43.729+00		67	17	0	3	2024-09-20 11:12:07.560336	\N	\N	\N
137	750	2024-09-20 15:38:10.612+00		\N	18	0	2	2024-09-20 11:39:34.420645	\N	\N	\N
4	* **RENOVACIÓN**\n  Aquellos propietarios cuyo vehículo(s) ya cuente con el SOAT de la gestión anterior y con la respectiva ROSETA, podrán adquirir su SOAT solamente dictando o digitando el número de placa de su vehículo, en cualquiera de los puntos de comercialización presenciales y digitales, habilitados y autorizados\n* **COMPRA NUEVA**\n  Para aquellos propietarios de vehículos que adquieran el SOAT por primera vez (Vehículos\n  recién importados, vehículos que salgan de taller de carrozado, de reconstrucción por\n  accidente o que por alguna otra razón no hayan tramitado el SOAT correspondiente en\n  gestiones anteriores), deberán presentar cualquier documento que identifque al vehículo,\n  por ejemplo: RUAT, FVR o Póliza de importación y deberán hacerlo solamente en\n  sucursales y agencias de UNIVIDA S.A. para recabar la ROSETA correspondiente, además de\n  actualizar los datos del vehículo	2024-08-24 05:56:47.072+00		\N	1	1	1	\N	\N	2024-08-24 01:57:02.097156	\N
62	Conoce nuestra historia	2024-09-19 15:18:38.384+00		\N	9	0	0	2024-09-19 11:19:07.864886	\N	\N	\N
63		2024-09-19 15:18:38.384+00		\N	9	0	1	\N	\N	2024-09-19 11:21:21.351214	\N
64	Seguros y Reaseguros Personales **UNIVIDA S.A.** especializada en la administración de riesgos personales y cuyos lineamientos se encuentran dirigidos a brindar protección a la población boliviana, democratizando el acceso a los seguros con un enfoque social e inclusivo.\n\n**UNIVIDA S.A.** obtuvo la autorización de funcionamiento el 19 de noviembre de 2015 a través de Resolución Administrativa APS/DJ/DS/Nº 1215·2015 de la Autoridad de Fiscalización y Control de Pensiones y Seguros (APS). Asimismo, el lanzamiento oficial al público fue en febrero de 2016.\n\nPosteriormente y conforme a lo establecido en Resolución Administrativa APS/DJ/DS/Nº1517·2016 del 17 de octubre de 2016 **UNIVIDA S.A.** se habilitó como la empresa para la administración y comercialización del Seguro Obligatorio de Accidentes de Tránsito (SOAT).\n\nDe igual manera se le otorgó la autorización para la comercialización del Seguro Obligatorio de Accidentes de la Trabajadora y el Trabajador en el Ámbito de la Construcción (SOAT-C) a través de Resolución Administrativa APS/DJ/DS/Nº0380/2021 del 22 de abril de 2021.\n\nLa demanda de mercado ha hecho que **UNIVIDA S.A.** tenga presencia geográfica a nivel nacional, contando actualmente con 18 oficinas en todo el territorio boliviano (1 oficina nacional, 9 sucursales y 8 agencias en ciudades capitales) y con más de 250 trabajadores a nivel nacional.\n\nDe acuerdo con los datos de la Autoridad de Fiscalización y Control de Pensiones y Seguros (APS), **UNIVIDA S.A.** ocupa el 3er lugar en Producción Directa Neta de Anulaciones en el Mercado de Seguros de Personas en Bolivia. Asimismo, la calificación de riesgo denota solvencia en cuanto al cumplimiento de obligaciones; en este sentido Moody’s LA. Proporcionó una calificación AA3 y AESA RATINGS calificó a UNIVIDA S.A. con A1.	2024-09-19 15:18:38.384+00		\N	9	0	2	2024-09-19 11:21:29.029651	\N	\N	\N
66		2024-09-19 15:29:04.686+00		2	9	0	3	2024-09-19 11:31:48.42025	\N	\N	\N
69		2024-09-19 15:50:32.094+00		\N	10	0	2	\N	\N	2024-09-19 11:51:48.700301	\N
81	Directorio y plantel ejecutivo	2024-09-19 18:29:38.889+00		\N	12	0	0	\N	\N	2024-09-19 14:34:39.326423	\N
85	Estructura orgánica	2024-09-19 18:42:49.789+00		\N	13	0	0	2024-09-19 14:43:02.025844	\N	\N	\N
67	Misión, visión y valores	2024-09-19 15:48:08.758+00		\N	10	0	0	\N	\N	2024-09-19 11:56:39.939185	\N
68	Somos la empresa de los bolivianos\norientada a:	2024-09-19 15:48:08.758+00		\N	10	0	1	\N	\N	2024-09-19 11:56:54.752582	\N
86		2024-09-19 18:42:49.789+00		\N	13	0	1	2024-09-19 14:43:07.275197	\N	\N	\N
70	50	2024-09-19 15:50:32.094+00		12	10	0	3	\N	\N	2024-09-19 12:45:21.009246	\N
71	Incrementar la rentabilidad empresarial a partir de la cartera consolidada y la diversificación de productos y servicios.	2024-09-19 17:59:05.118+00		13	11	0	0	2024-09-19 14:02:04.479737	\N	\N	\N
72	Modernizar la gestión empresarial en todos sus componentes.	2024-09-19 17:59:05.118+00		14	11	0	1	2024-09-19 14:03:16.467532	\N	\N	\N
73	Consolidar la cartera de productos de seguros personales innovadores y accesibles para las familias bolivianas.	2024-09-19 17:59:05.118+00		15	11	0	2	2024-09-19 14:03:34.532465	\N	\N	\N
74	Fortalecer la gestión integral de riesgos y el control interno de UNIVIDA S.A. consolidando un buen gobierno corporativo.	2024-09-19 17:59:05.118+00		16	11	0	3	\N	\N	2024-09-19 14:04:15.661624	\N
75	Obtener ventaja competitiva en base a la estructuración de alianzas estratégicas públicas y privadas.	2024-09-19 17:59:05.118+00		17	11	0	4	2024-09-19 14:04:26.530936	\N	\N	\N
76	Afianzar el equipo de trabajo generando sinergia, empatía, motivación y sentido de pertenencia.	2024-09-19 17:59:05.118+00		18	11	0	5	2024-09-19 14:04:37.712849	\N	\N	\N
77	Garantizar la protección de los derechos de vida y salud de los asegurados, beneficiarios y usuarios con efectivas contraprestaciones y promoviendo la prevención de riesgos personales.	2024-09-19 17:59:05.118+00		19	11	0	6	2024-09-19 14:04:57.582461	\N	\N	\N
82		2024-09-19 18:29:38.889+00		\N	12	0	1	2024-09-19 14:31:43.708501	\N	\N	\N
83		2024-09-19 18:29:38.889+00		\N	12	0	2	2024-09-19 14:31:47.385299	\N	\N	\N
84		2024-09-19 18:29:38.889+00		20	12	0	3	2024-09-19 14:31:54.372452	\N	\N	\N
89		2024-09-19 18:44:46.384+00		21	13	0	4	2024-09-19 14:44:55.597777	\N	\N	\N
88		2024-09-19 18:42:49.789+00		\N	13	0	3	\N	\N	2024-09-19 14:45:00.348161	\N
90		2024-09-19 19:18:08.4+00	https://bancounion.com.bo/	22	14	0	0	\N	\N	2024-09-19 15:23:46.982701	\N
91		2024-09-19 19:18:08.4+00	https://www.unibienes.com.bo/	23	14	0	1	\N	\N	2024-09-19 15:23:58.618685	\N
92		2024-09-19 19:18:08.4+00	https://www.safiunion.com.bo/	24	14	0	2	\N	\N	2024-09-19 15:24:19.514355	\N
93		2024-09-19 19:18:08.4+00	https://valoresunion.com.bo/	25	14	0	3	\N	\N	2024-09-19 15:24:31.526646	\N
94		2024-09-19 19:49:41.042+00		26	15	0	0	2024-09-19 15:49:54.866498	\N	\N	\N
95	Código de Ética Empresarial	2024-09-19 19:49:41.042+00		\N	15	0	1	2024-09-19 15:50:42.746657	\N	\N	\N
98		2024-09-19 19:49:41.042+00		27	15	1	0	2024-09-19 15:59:28.921812	\N	\N	\N
96	Descargar	2024-09-19 19:49:41.042+00		28	15	0	2	\N	\N	2024-09-19 16:00:01.693681	\N
99	Reglamento de Transparencia y Lucha Contra la Corrupción	2024-09-19 19:49:41.042+00		\N	15	1	1	2024-09-19 16:00:24.170418	\N	\N	\N
100	Descargar	2024-09-19 19:49:41.042+00		29	15	1	2	2024-09-19 16:00:37.06695	\N	\N	\N
101	Memoria Anual 2023	2024-09-19 20:11:38.795+00		\N	16	0	0	2024-09-19 16:26:27.326783	\N	\N	\N
103		2024-09-19 20:26:59.874+00		51	16	0	2	2024-09-19 16:27:22.997946	\N	\N	\N
102	bi bi-journal-bookmark	2024-09-19 20:11:38.795+00		\N	16	0	1	\N	\N	2024-09-19 16:34:06.479678	\N
105	Memoria Anual 2022	2024-09-19 20:26:59.874+00		\N	16	1	0	2024-09-20 09:59:41.110036	\N	\N	\N
106	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	1	1	2024-09-20 09:59:50.762462	\N	\N	\N
107		2024-09-19 20:26:59.874+00		53	16	1	2	2024-09-20 10:00:03.566532	\N	\N	\N
111	Memoria Anual 2021	2024-09-19 20:26:59.874+00		\N	16	2	0	2024-09-20 10:02:07.624245	\N	\N	\N
112	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	2	1	2024-09-20 10:02:14.886946	\N	\N	\N
113		2024-09-19 20:26:59.874+00		55	16	2	2	2024-09-20 10:02:23.638089	\N	\N	\N
115	Memoria Anual 2020	2024-09-19 20:26:59.874+00		\N	16	3	0	2024-09-20 10:03:52.840545	\N	\N	\N
116	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	3	1	2024-09-20 10:04:11.212551	\N	\N	\N
117		2024-09-19 20:26:59.874+00		57	16	3	2	2024-09-20 10:04:19.130889	\N	\N	\N
118	Descargar memoria	2024-09-19 20:26:59.874+00		58	16	3	3	2024-09-20 10:05:43.539383	\N	\N	\N
119	Memoria Anual 2019	2024-09-19 20:26:59.874+00		\N	16	4	0	2024-09-20 10:06:03.647049	\N	\N	\N
120	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	4	1	2024-09-20 10:06:11.860218	\N	\N	\N
121		2024-09-19 20:26:59.874+00		59	16	4	2	2024-09-20 10:06:27.728666	\N	\N	\N
123	Memoria Anual 2018	2024-09-19 20:26:59.874+00		\N	16	5	0	2024-09-20 10:07:19.210965	\N	\N	\N
124	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	5	1	2024-09-20 10:07:31.564321	\N	\N	\N
125		2024-09-19 20:26:59.874+00		61	16	5	2	2024-09-20 10:08:03.526717	\N	\N	\N
128	bi bi-journal-bookmark	2024-09-19 20:26:59.874+00		\N	16	6	1	2024-09-20 10:08:35.845098	\N	\N	\N
127	Memoria Anual 2017	2024-09-19 20:26:59.874+00		\N	16	6	0	\N	\N	2024-09-20 10:08:47.462197	\N
129		2024-09-19 20:26:59.874+00		63	16	6	2	2024-09-20 10:09:04.758651	\N	\N	\N
122	Descargar memoria	2024-09-19 20:26:59.874+00		60	16	4	3	\N	\N	2024-09-20 10:09:42.078442	\N
108	Descargar memoria	2024-09-19 20:26:59.874+00		54	16	1	3	\N	\N	2024-09-20 10:09:53.622524	\N
104	Descargar memoria	2024-09-19 20:26:59.874+00		52	16	0	3	\N	\N	2024-09-20 10:09:58.382405	\N
135	https://transaccion-electronica.univida.bo:81/	2024-09-20 15:38:10.612+00		\N	18	0	0	2024-09-20 11:39:00.801531	\N	\N	\N
\.


--
-- TOC entry 3445 (class 0 OID 17040)
-- Dependencies: 220
-- Data for Name: PaginasDinamicas; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

COPY "PaginaDinamica"."PaginasDinamicas" ("Id", "Nombre", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Habilitado") FROM stdin;
1	S O A T	\N	\N	2024-07-26 10:45:11.460086	\N	t
2	Historia	\N	\N	2024-07-26 10:45:17.235773	\N	f
3	Misión, visión y valores	\N	\N	2024-09-19 11:47:44.104646	\N	t
4	Objetivos estratégicos	2024-09-19 13:57:21.802407	\N	\N	\N	t
5	Directorio y plantel ejecutivo	2024-09-19 14:27:40.985458	\N	\N	\N	t
6	Estructura orgánica	2024-09-19 14:42:31.425445	\N	\N	\N	t
7	Grupo financiero unión	2024-09-19 15:17:48.563252	\N	\N	\N	t
8	Gestión Normativa	2024-09-19 15:44:16.979022	\N	\N	\N	t
9	Memorias Empresariales	2024-09-19 16:11:12.270061	\N	\N	\N	t
10	Precios SOAT	\N	\N	2024-09-20 12:11:19.915121	\N	t
11	Comprar o renovar SOAT	\N	\N	2024-09-20 18:47:18.574391	\N	t
\.


--
-- TOC entry 3451 (class 0 OID 17069)
-- Dependencies: 226
-- Data for Name: Secciones; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

COPY "PaginaDinamica"."Secciones" ("Id", "CatTipoSeccionId", "Nombre", "Titulo", "SubTitulo", "Clase", "PaginaDinamicaId", "Orden", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Habilitado") FROM stdin;
1	1	Seccion compra Soat				1	0	\N	\N	2024-07-26 19:01:24.008504	\N	t
9	5	Historia	Historia			2	0	2024-09-19 11:18:32.876577	\N	\N	\N	t
10	5	Misión, visión y valores				3	0	2024-09-19 11:48:07.104399	\N	\N	\N	t
11	7	Objetivos estratégicos	Objetivos Estratégicos	Impulsando soluciones innovadoras y un impacto positivo		4	0	\N	\N	2024-09-19 14:17:30.385974	\N	t
12	5	Directorio y plantel ejecutivo				5	0	2024-09-19 14:28:16.932648	\N	\N	\N	t
13	5	Estructura orgánica				6	0	\N	\N	2024-09-19 14:44:38.58775	\N	t
14	8	Grupo financiero unión		Grupo financiero unión		7	0	\N	\N	2024-09-19 15:22:00.358639	\N	t
15	9	Gestión Normativa		Gestión Normativa		8	0	\N	\N	2024-09-19 16:03:04.800248	\N	t
16	2	Memorias Empresariales	Memorias Empresariales	Nuestros hitos&#x20;\ny logros a lo largo del camino.		9	0	\N	\N	2024-09-20 10:14:18.558739	\N	t
17	5	Precios soat	precios	Conoce nuestros precios para la gestión Soat 2024		10	0	2024-09-20 10:35:35.423743	\N	\N	\N	t
18	10	COMPRAR O RENOVAR SOAT				11	0	2024-09-20 11:38:09.274744	\N	\N	\N	t
3	3	Servicios Soat	SERVICIOS SOAT\n	Explora nuestros servicios\nrelacionados con el SOAT		1	2	\N	\N	2024-07-26 13:04:30.267267	\N	t
4	4	Sección Accidentes\n	ACCIDENTES DE TRÁNSITO\n	¿Qué hacer en caso de\nun accidente de tránsito?		1	3	\N	\N	2024-07-26 13:04:34.038104	\N	t
2	2	Información Soat	¿CÓMO ADQUIRIR EL SOAT?\n	Opciones para obtener tu\nSOAT de manera rápida y sencilla		1	1	\N	\N	2024-07-26 17:46:27.063625	\N	t
\.


--
-- TOC entry 3457 (class 0 OID 17118)
-- Dependencies: 232
-- Data for Name: BannerPagina; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

COPY "Recurso"."BannerPagina" ("Id", "PaginaDinamicaId", "SeguroId", "RecursoId", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "SubTitulo", "Titulo") FROM stdin;
2	\N	1	1	\N	\N	\N	\N		Seguro de Vida Individual
3	2	\N	1	2024-09-19 11:42:19.317315	\N	\N	\N		
4	3	\N	1	2024-09-19 11:47:50.135788	\N	\N	\N		
5	4	\N	1	2024-09-19 13:57:26.997127	\N	\N	\N		
6	5	\N	1	2024-09-19 14:27:56.689471	\N	\N	\N		
7	6	\N	1	2024-09-19 14:42:38.112464	\N	\N	\N		
8	7	\N	1	2024-09-19 15:17:53.77075	\N	\N	\N		
9	8	\N	1	2024-09-19 15:44:22.78704	\N	\N	\N		
1	1	\N	1	\N	\N	2024-09-20 18:45:26.391344	\N		
11	\N	2	1	\N	\N	\N	\N		
12	\N	3	1	\N	\N	\N	\N		
14	\N	5	1	\N	\N	\N	\N		
15	\N	6	1	\N	\N	\N	\N		
13	\N	4	1	\N	\N	\N	\N		Seguro de Vida Individual con cobertura \nadicional por COVID-19
10	9	\N	7	\N	\N	2024-10-09 00:20:15.770314	\N		
\.


--
-- TOC entry 3449 (class 0 OID 17056)
-- Dependencies: 224
-- Data for Name: Recursos; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

COPY "Recurso"."Recursos" ("Id", "Nombre", "CatTipoRecursoId", "RecursoEscritorio", "RecursoMovil", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	baner prueba	1	/assets/images/backgrounds/page-header-bg.jpg	\N	\N	\N	\N	\N
2	Compra soat	1	/assets/images/soat/compra-web.jpg	\N	\N	\N	\N	\N
3	Descarga App	1	/assets/images/soat/unividaapp.jpg	\N	\N	\N	\N	\N
4	Puntos de venta	1	/assets/images/soat/puntos.jpg	\N	\N	\N	\N	\N
5	Redes sociales	1	/assets/images/soat/facebook-whatsapp.jpg	\N	\N	\N	\N	\N
7	Datos SOAT	1	/assets/images/soat/datos-vehiculo.jpg	\N	\N	\N	\N	\N
8	Comprobante SOAT	1	/assets/images/soat/comprobante-soat.jpg	\N	\N	\N	\N	\N
6	Precios SOAT	1	/assets/images/soat/precios-soat.jpg	\N	\N	\N	\N	\N
9	Pareja con celular	1	/assets/images/varios/about-three-img-1.jpg	\N	\N	\N	\N	\N
10	Mujer con papeles	1	/assets/images/varios/about-three-img-2.jpg	\N	\N	\N	\N	\N
11	Mujer con niña	1	/assets/images/varios/about-three-img-3.jpg	\N	\N	\N	\N	\N
12	mision vision valores	1	/assets/images/varios/IMAGEN_1Recurso_10.png	\N	\N	\N	\N	\N
13	icono incrementar	1	/assets/images/varios/icono_mesa1.png	\N	\N	\N	\N	\N
14	icono recarga	1	/assets/images/varios/icono_mesa2.png	\N	\N	\N	\N	\N
15	icono familia	1	/assets/images/varios/icono_mesa3.png	\N	\N	\N	\N	\N
16	icono personas	1	/assets/images/varios/icono_mesa4.png	\N	\N	\N	\N	\N
17	icono manos	1	/assets/images/varios/icono_mesa5.png	\N	\N	\N	\N	\N
18	icono personas 2\n	1	/assets/images/varios/icono_mesa6.png	\N	\N	\N	\N	\N
19	icono corazon	1	/assets/images/varios/icono_mesa7.png	\N	\N	\N	\N	\N
20	plantel ejecutivo	1	/assets/images/varios/directorio-plantel-e1.png	\N	\N	\N	\N	\N
21	Estructura organica	1	/assets/images/varios/ESTRUECUTRA_ORGANICARecurso_28.png	\N	\N	\N	\N	\N
22	BancoUnion	1	/assets/images/varios/BANCO_UNIONRecurso_27.png	\N	\N	\N	\N	\N
23	UniBienes	1	/assets/images/varios/UNIBIENESRecurso_29.png	\N	\N	\N	\N	\N
24	SafiUnion	1	/assets/images/varios/SAFI_UNION_Recurso 30.png	\N	\N	\N	\N	\N
25	ValoresUnion	1	/assets/images/varios/VALORES_UNION_Recurso_31.png	\N	\N	\N	\N	\N
26	Código de Ética Empresarial	1	/assets/images/varios/GEST_NORMATIVA_1Recurso_32.png	\N	\N	\N	\N	\N
27	Reglamento de Transparencia	1	/assets/images/varios/GEST_NORMATIVA 2Recurso_33.png	\N	\N	\N	\N	\N
28	Doc Código de Ética Empresarial	3	/assets/images/varios/codigo_etica_empresarial.pdf	\N	\N	\N	\N	\N
29	Doc Reglamento de Transparencia	3	/assets/images/varios/reglamento_transparencia_lucha_corrupcion.pdf	\N	\N	\N	\N	\N
61	Memoria2018	1	/assets/memorias/2018Recurso.png	\N	\N	\N	\N	\N
51	Memoria2023	1	/assets/memorias/2023Recurso.png	\N	\N	\N	\N	\N
52	doc Memoria2023	3	/assets/memorias/memoria2023.pdf	\N	\N	\N	\N	\N
53	Memoria2022	1	/assets/memorias/2022Recurso.png	\N	\N	\N	\N	\N
54	doc Memoria2022	3	/assets/memorias/memoria2022.pdf	\N	\N	\N	\N	\N
55	Memoria2021	1	/assets/memorias/2021Recurso.png	\N	\N	\N	\N	\N
56	doc Memoria2021	3	/assets/memorias/memoria2021.pdf	\N	\N	\N	\N	\N
57	Memoria2020	1	/assets/memorias/2020Recurso.png	\N	\N	\N	\N	\N
59	Memoria2019	1	/assets/memorias/2019Recurso.png	\N	\N	\N	\N	\N
60	doc Memoria2019	3	/assets/memorias/memoria2019.pdf	\N	\N	\N	\N	\N
62	doc Memoria2018	3	/assets/memorias/memoria2018.pdf	\N	\N	\N	\N	\N
63	Memoria2017	1	/assets/memorias/2017Recurso.png	\N	\N	\N	\N	\N
64	doc Memoria2017	3	/assets/memorias/memoria2017.pdf	\N	\N	\N	\N	\N
65	Memoria2016	1	/assets/memorias/2016Recurso.png	\N	\N	\N	\N	\N
66	doc Memoria2016	3	/assets/memorias/memoria2016.pdf	\N	\N	\N	\N	\N
58	doc Memoria2020	3	/assets/memorias/memoria2020.pdf	\N	\N	\N	\N	\N
67	precios soat 2024	1	/assets/images/soat/precios-soat-2024.png	\N	\N	\N	\N	\N
\.


--
-- TOC entry 3453 (class 0 OID 17087)
-- Dependencies: 228
-- Data for Name: Planes; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

COPY "Seguro"."Planes" ("Id", "SeguroId", "Titulo", "SubTitulo", "Precio", "Cobertura", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Orden", "Habilitado") FROM stdin;
1	1	Plan A	PRECIO ANUAL (POR PERSONA)	45	- Muerte por cualquier causa **Bs.15.000**\n- Invalidez total y permanente **Bs.7.500**\n- Gastos de sepelio **Bs.1.500**	\N	\N	\N	\N	0	f
2	1	Plan B	 PRECIO ANUAL (POR PERSONA)	90	- Muerte por cualquier causa **Bs.30.000**\n- Invalidez total y permanente **Bs.15.000**\n- Gastos de sepelio **Bs.3.000**	\N	\N	\N	\N	0	f
3	2	Plan A	PRECIO ANUAL (POR PERSONA)	45	- Muerte por cualquier causa **Bs.15.000**\n- Invalidez total y permanente **Bs.7.500**\n- Gastos de sepelio **Bs.1.500**	\N	\N	\N	\N	0	f
4	2	Plan B	PRECIO ANUAL (POR PERSONA)	90	- Muerte por cualquier causa **Bs.30.000**\n- Invalidez total y permanente **Bs.15.000**\n- Gastos de sepelio **Bs.3.000**\n	\N	\N	\N	\N	0	f
5	2	Plan C	PRECIO ANUAL (POR PERSONA)	220	- Muerte por cualquier causa **Bs.70.000**\n- Invalidez total y permanente **Bs.35.000**\n- Gastos de sepelio **Bs.6.000**\n\n	\N	\N	\N	\N	0	f
6	2	Plan D	PRECIO ANUAL (POR PERSONA)	365	- Muerte por cualquier causa **Bs.120.000**\n- Invalidez total y permanente **Bs.70.000**\n- Gastos de sepelio **Bs.10.000**	\N	\N	\N	\N	0	f
7	3	Plan	PRECIO ANUAL (POR PERSONA)	45	- Muerte por cualquier causa **Bs.10.000**\n- Invalidez total y permanente **Bs.2.000**	\N	\N	\N	\N	0	f
13	4	Plan A	PRECIO ANUAL (POR PERSONA)	160	- Muerte por cualquier causa excepto COVID-19 **Bs.5.000**\n- Muerte por COVID-19 **Bs.7.000**\n- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.560 (por día)**\n- Gastos de sepelio **Bs.1.000**	\N	\N	\N	\N	0	f
14	4	Plan B	PRECIO ANUAL (POR PERSONA)	225	- Muerte por cualquier causa excepto COVID-19 **Bs.7.000**\n- Muerte por COVID-19 **Bs.10.000**\n- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.700 (por día)**\n- Gastos de sepelio **Bs.1.000**	\N	\N	\N	\N	0	f
15	4	Plan C	PRECIO ANUAL (POR PERSONA)	350	- Muerte por cualquier causa excepto COVID-19 **Bs.10.000**\n- Muerte por COVID-19 **Bs.14.000**\n- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.1.050 (por día)**\n- Gastos de sepelio **Bs.2.000**	\N	\N	\N	\N	0	f
16	4	Plan D	PRECIO ANUAL (POR PERSONA)	599	- Muerte por cualquier causa excepto COVID-19 **Bs.20.000**\n- Muerte por COVID-19 **Bs.22.000**\n- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.2.000 (por día)**\n- Gastos de sepelio **Bs.2.000**	\N	\N	\N	\N	0	f
18	5	Plan B	PRECIO ANUAL (POR PERSONA)	5	- Muerte accidental* **Bs.10.000**\n- Gastos médicos **Bs.3.000**	\N	\N	\N	\N	0	f
19	6	Plan A	PRECIO ANUAL (POR PERSONA)	35	- Muerte accidental Bs.10.000\n- Invalidez total y permanente Bs.2.500\n- Gastos médicos Bs.2.000	\N	\N	\N	\N	0	f
17	5	Plan A	PRECIO ANUAL (POR PERSONA)	201	* Muerte accidental **Bs.10.000**\n* Gastos médicos **Bs.3.000**	\N	\N	2024-11-02 14:53:31.527069	\N	0	t
\.


--
-- TOC entry 3455 (class 0 OID 17100)
-- Dependencies: 230
-- Data for Name: SeguroDetalles; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

COPY "Seguro"."SeguroDetalles" ("Id", "SeguroId", "Titulo", "Respuesta", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "Orden") FROM stdin;
9	2	**Exclusiones** del \nSeguro de Vida \nIndividual	- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro	\N	\N	\N	\N	0
11	3	¿Qué cubre el\n**Seguro de Vida\nindividual?**	- En caso de muerte por cualquier causa, tus benefciarios reciben una indemnización.\n- Indemnizamos a tus benefciarios con gastos de sepelio	\N	\N	\N	\N	0
13	3	¿Cómo \n**asegurarte?**	- Presenta la fotocopia de tu Cédula de Identidad vigente.\n- Llena los formularios que serán proporcionados por nuestra entidad.	\N	\N	\N	\N	0
1	1	¿Qué es el **Seguro de\nAccidentes Personales?**	Es un plan de protección creado para usted y su familia, consistente en otorgar un apoyo económico a la familia del asegurado ante el fallecimiento de este por cualquier causa (salvo exclusiones específicas). \n\nPor ejemplo, con el **Plan A** de nuestro Seguro de Vida Individual, en caso de invalidez total y permanente el asegurado recibirá un monto de **Bs.7.500**. En caso de fallecimiento la empresa pagará **Bs.15.000** a los beneficiarios, además de **Bs.1.500** para gastos de sepelio.\n	\N	\N	\N	\N	0
2	1	¿Qué cubre el **Seguro \nde Vida Individual?**	- En caso de muerte por cualquier causa, tus beneficiarios reciben una indemnización.\n- Te indemnizamos en caso de invalidez total y permanente.\n- Indemnizamos a tus beneficiarios con gastos de sepelio.\n	\N	\N	\N	\N	0
3	1	¿Cómo \n**asegurarte?**	- Presenta la fotocopia de tu Cédula de Identidad vigente.\n- Llena los formularios que serán proporcionados por nuestra entidad.	\N	\N	\N	\N	0
4	1	**Exclusiones** del \nSeguro de Vida \nIndividual	- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.	\N	\N	\N	\N	0
14	3	**Exclusiones** del \nSeguro de Vida \nIndividual	- Enfermedades preexistentes conocidas.\n- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.	\N	\N	\N	\N	0
15	4	¿Qué cubre el\n**Seguro de Vida\nIndividual?**	- En caso de muerte por cualquier causa excepto COVID-19, tus benefciarios reciben una indemnización.\n- En caso de muerte por COVID-19, tus benefciarios reciben una indemnización.\n- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días.\n- Indemnizamos a tus benefciarios con gastos de sepelio.	\N	\N	\N	\N	0
5	2	¿Qué es el **Seguro de \nVida Individual?**	Es un plan de protección creado para usted y su familia, consistente en otorgar un apoyo \neconómico a la familia del asegurado ante el fallecimiento de este por cualquier causa, \n(salvo exclusiones específcas).\nPor ejemplo con el Plan A de nuestro Seguro de Vida Individual, en caso de invalidez total \ny permanente el asegurado recibirá un monto de Bs.7.500. En caso de fallecimiento la \nempresa pagará Bs.15.000 a los benefciarios, además de Bs.1.500 para gastos de sepelio.	\N	\N	\N	\N	0
6	2	¿Qué cubre el **Seguro \nde Vida Individual?**	- En caso de muerte por cualquier causa, tus benefciarios reciben una indemnización.\n- Te indemnizamos en caso de invalidez total y permanente.\n- Indemnizamos a tus benefciarios con gastos de sepelio	\N	\N	\N	\N	0
8	2	¿Como **Asegurarte?**	- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro	\N	\N	\N	\N	0
16	4	Benefcios \n**adicionales**	**DESCUENTO POR RENOVACIÓN**\nSi el cliente se encuentra realizando la renovación de algún seguro, \npuede comprar el producto con un descuento del 5%.\n\n**DESCUENTO POR NÚMERO DE ASEGURADOS**\nA partir del segundo asegurado, se aplicará el descuento del 4% \nen la prima.\n\n**DESCUENTO POR PRODUCTO**\nSi el cliente compra el producto adicionalmente puede obtener un \ndescuento del 6% en la compra del siguiente (distinto al seguro de vida \nincluyendo COVID-19).	\N	\N	\N	\N	0
17	4	¿Cómo \n**asegurarte?**	- Presenta la fotocopia de tu Cédula de Identidad vigente.\n- Llena los formularios que serán proporcionados por nuestra entidad.	\N	\N	\N	\N	0
18	4	**Exclusiones** del \nSeguro de Vida \nIndividual	- Enfermedades preexistentes y aislamiento para el caso de COVID-19.\n- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Para la cobertura de renta diaria por Covid-19, el diagnostico debe ser realizado con la prueba PCR \n- Molecular positiva en centros autorizados por el Min. Salud/SEDES en la vigencia de la póliza.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro	\N	\N	\N	\N	0
19	5	¿Qué cubre el **Seguro de \nAccidentes Personales?**	- En caso de muerte accidental durante la actividad física propia de la disciplina declarada, tus benefciarios reciben una indemnización.\n- Cubrimos los gastos médicos en caso de accidente.	\N	\N	\N	\N	0
21	5	¿Cómo \n**asegurarte?**	- Presenta la fotocopia de tu Cédula de Identidad vigente.\n- Llena los formularios que serán proporcionados por nuestra entidad.	\N	\N	\N	\N	0
22	5	**Exclusiones** del \nSeguro de Accidentes \nPersonales	- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.	\N	\N	\N	\N	0
23	6	¿Qué cubre el **Seguro \nde Accidentes \nPersonales?**	- En caso de muerte accidental, tus benefciarios reciben una indemnización.\n- Te indemnizamos en caso de invalidez total y permanente.\n- Cubrimos los gastos médicos en caso de accidente.	\N	\N	\N	\N	0
24	6	¿Cómo \n**asegurarte?**	- Presenta la fotocopia de tu Cédula de Identidad vigente.\n- Llena los formularios que serán proporcionados por nuestra entidad. 	\N	\N	\N	\N	0
26	6	**Exclusiones** del \nSeguro de Accidentes \nPersonales	- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.\n- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.\n- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.	\N	\N	\N	\N	0
\.


--
-- TOC entry 3447 (class 0 OID 17048)
-- Dependencies: 222
-- Data for Name: Seguros; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

COPY "Seguro"."Seguros" ("Id", "Nombre", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor", "NombreCorto", "DetalleAdicional", "Icono", "Orden", "RecursoId", "Habilitado", "CatTipoSeguroId") FROM stdin;
5	Seguro de Accidentes Personales - Deportista Seguro	\N	\N	\N	\N	Deportista Seguro	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)\n**Cláusula Adicional de Aviso de Siniestro 10 días.**	icon-family-insurance	0	3	t	2
2	Seguro de Vida Individual	\N	\N	\N	\N	Vida Individual	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)	icon-family-insurance	0	3	t	1
3	Seguro de Vida Individual - Vida Mujer	\N	\N	\N	\N	Vida Mujer	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)\n**Cláusula Adicional de Aviso de Siniestro 10 días.**	icon-healthcare	0	3	t	2
6	Seguro de Accidentes Personales - Gremialista Seguro	\N	\N	\N	\N	Gremialista Seguro	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)\n**Cláusula Adicional de Aviso de Siniestro 10 días.**	icon-healthcare	0	3	t	2
4	Seguro de Vida Individual con cobertura \nadicional por COVID-19	\N	\N	\N	\N	COVID-19	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)\n**Cláusula Adicional de Aviso de Siniestro 10 días.**	icon-healthcare	0	3	f	2
1	Seguro de Accidentes Personales Individual	\N	\N	2024-10-29 20:59:02.833828	\N	Accidentes Personales	Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)\n**Cláusula Adicional de Aviso de Siniestro 10 días.**	icon-healthcare	0	3	f	1
\.


--
-- TOC entry 3439 (class 0 OID 17006)
-- Dependencies: 214
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20240619214807_inicio	7.0.20
20240619215006_inicio1	7.0.20
20240620061704_modelo-seguros	7.0.20
20240620062614_modelo-seguros2	7.0.20
20240620065615_eliminacion-catsegurodetalle	7.0.20
20240620071157_adicion-campos-faltantes	7.0.20
20240620072746_adicion-campos-faltantes2	7.0.20
20240620073713_campos-faltantes-orden-visible	7.0.20
20240620142614_propiedades-navegacion	7.0.20
20240620145917_propiedad-ruta	7.0.20
20240620155000_propiedades-bannerpagina	7.0.20
20240620193942_modificacion-propiedad-seguros	7.0.20
20240620222712_campo-tiposeguro	7.0.20
20240620225253_cambio-esquema	7.0.20
20240620233310_retiro-ruta-adicion-relaciones	7.0.20
20240625095425_menu-model3	7.0.20
20240625101814_menu-propiedades	7.0.20
20240625102942_menu-propiedades3	7.0.20
20240625105011_menu-propiedades4	7.0.20
20240725193807_actualización-menu-seguro-pagina	7.0.20
20240726135622_actualización-basedomainmodel	7.0.20
20240726135746_actualización-basedomainmodel2	7.0.20
20240726144310_actualización-basedomainmodel3	7.0.20
20240829200903_ImagenSeccion	7.0.20
20240829204718_ImagenSeccionGuia	7.0.20
\.


--
-- TOC entry 3470 (class 0 OID 0)
-- Dependencies: 215
-- Name: CatTipoRecurso_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoRecurso_Id_seq"', 3, true);


--
-- TOC entry 3471 (class 0 OID 0)
-- Dependencies: 217
-- Name: CatTipoSeccion_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeccion_Id_seq"', 10, true);


--
-- TOC entry 3472 (class 0 OID 0)
-- Dependencies: 235
-- Name: CatTipoSeguro_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeguro_Id_seq"', 29, true);


--
-- TOC entry 3473 (class 0 OID 0)
-- Dependencies: 237
-- Name: MenuPrincipal_Id_seq; Type: SEQUENCE SET; Schema: Menu; Owner: postgres
--

SELECT pg_catalog.setval('"Menu"."MenuPrincipal_Id_seq"', 35, true);


--
-- TOC entry 3474 (class 0 OID 0)
-- Dependencies: 233
-- Name: Datos_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Datos_Id_seq"', 141, true);


--
-- TOC entry 3475 (class 0 OID 0)
-- Dependencies: 219
-- Name: PaginasDinamicas_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."PaginasDinamicas_Id_seq"', 20, true);


--
-- TOC entry 3476 (class 0 OID 0)
-- Dependencies: 225
-- Name: Secciones_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Secciones_Id_seq"', 29, true);


--
-- TOC entry 3477 (class 0 OID 0)
-- Dependencies: 231
-- Name: BannerPagina_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."BannerPagina_Id_seq"', 15, true);


--
-- TOC entry 3478 (class 0 OID 0)
-- Dependencies: 223
-- Name: Recursos_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."Recursos_Id_seq"', 67, true);


--
-- TOC entry 3479 (class 0 OID 0)
-- Dependencies: 227
-- Name: Planes_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Planes_Id_seq"', 22, true);


--
-- TOC entry 3480 (class 0 OID 0)
-- Dependencies: 229
-- Name: SeguroDetalles_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."SeguroDetalles_Id_seq"', 28, true);


--
-- TOC entry 3481 (class 0 OID 0)
-- Dependencies: 221
-- Name: Seguros_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Seguros_Id_seq"', 18, true);


-- Completed on 2024-11-11 07:15:51

--
-- PostgreSQL database dump complete
--

