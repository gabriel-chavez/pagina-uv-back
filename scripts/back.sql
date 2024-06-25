--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-06-25 07:17:24

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
-- TOC entry 3425 (class 0 OID 17016)
-- Dependencies: 216
-- Data for Name: CatTipoRecurso; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (1, 'Imagen', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (2, 'Video', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (3, 'Archivo', NULL, NULL, NULL, NULL, false);


--
-- TOC entry 3427 (class 0 OID 17024)
-- Dependencies: 218
-- Data for Name: CatTipoSeccion; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (1, 'SeccionContenidoTipo3', '2 columnas', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (2, 'SeccionSliderTipo1', 'Seccion slider tipo 1', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (3, 'SeccionSliderTipo2', 'Seccion slider tipo 2', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (4, 'SeccionAcordeonTipo1', 'Seccion acordeon tipo 1', NULL, NULL, NULL, NULL, false);


--
-- TOC entry 3445 (class 0 OID 17485)
-- Dependencies: 236
-- Data for Name: CatTipoSeguro; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (1, 'Seguro de Vida', true, NULL, NULL, NULL, NULL);
INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (2, 'Seguro de Accidentes Personales', true, NULL, NULL, NULL, NULL);
INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (3, 'Otros Seguros', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3447 (class 0 OID 17630)
-- Dependencies: 238
-- Data for Name: MenuPrincipal; Type: TABLE DATA; Schema: Menu; Owner: postgres
--

INSERT INTO "Menu"."MenuPrincipal" VALUES (3, 'Inicio', '/', NULL, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (4, 'Nuestros Seguros', '/nuestros-seguros', NULL, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (5, 'Seguros Obligatorios', '/seguros-obligatorios', NULL, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (7, 'Seguro de Accidentes Personales', '/accidentes-personales', 4, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (8, 'Seguro de Vida', '/vida', 4, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (9, 'Seguro de Desgravamen', '/desgravamen', 4, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (10, 'Seguro de Cesantía', '/cesantia', 4, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (11, 'Soat', '/soat', 5, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (12, 'Soatc', '/soatc', 5, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (13, 'Comprar Soat', '/soat/comprar', 11, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (14, 'Precios Soat', '/soat/precios', 11, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (15, 'Puntos de venta', '/soat/puntos-de-venta', 11, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (16, 'Historia', '/empresa/historia', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (17, 'Misión, Visión y Valores', '/empresa/mision-vision-valores', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (18, 'Objetivos Estratégicos', '/empresa/objetivos-estrategicos', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (19, 'Directorio y Plantel Ejecutivo', '/empresa/directorio-plantel-ejecutivo', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (20, 'Estructura Orgánica', '/empresa/estructura-organica', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (21, 'Grupo Financiero Unión', '/empresa/grupo-financiero-union', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (22, 'Gestión Normativa', '/empresa/gestion-normativa', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (23, 'Memorias Empresariales', '/empresa/memorias-empresariales', 6, true, true, 0, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (6, 'Sobre la Empresa', '/empresa', NULL, true, true, 0, NULL, NULL, NULL, NULL);


--
-- TOC entry 3429 (class 0 OID 17040)
-- Dependencies: 220
-- Data for Name: PaginasDinamicas; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (1, 'S O A T', NULL, NULL, NULL, NULL, false, 11);


--
-- TOC entry 3435 (class 0 OID 17069)
-- Dependencies: 226
-- Data for Name: Secciones; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."Secciones" VALUES (1, 1, 'Seccion compra Soat', NULL, NULL, NULL, 1, 0, NULL, NULL, NULL, NULL, false);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (2, 2, 'Información Soat', '¿CÓMO ADQUIRIR EL SOAT?
', 'Opciones para obtener tu
SOAT de manera rápida y sencilla', NULL, 1, 1, NULL, NULL, NULL, NULL, false);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (3, 3, 'Servicios Soat', 'SERVICIOS SOAT
', 'Explora nuestros servicios
relacionados con el SOAT', NULL, 1, 2, NULL, NULL, NULL, NULL, false);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (4, 4, 'Sección Accidentes
', 'ACCIDENTES DE TRÁNSITO
', '¿Qué hacer en caso de
un accidente de tránsito?', NULL, 1, 3, NULL, NULL, NULL, NULL, false);


--
-- TOC entry 3433 (class 0 OID 17056)
-- Dependencies: 224
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
-- TOC entry 3443 (class 0 OID 17141)
-- Dependencies: 234
-- Data for Name: Datos; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."Datos" VALUES (1, '¿Qué es el **SOAT**?', NULL, NULL, NULL, 1, 0, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (2, 'El artículo 37 de la Ley N° 1883 de Seguros, señala que el SOAT es el “Seguro Obligatorio de Accidentes de Tránsito” que todo vehículo motorizado, público y/o privado, debe contar con carácter obligatorio, para poder transitar por vías públicas del territorio boliviano. Además, la norma señala que, el Seguro es incuestionable y de beneficio uniforme con coberturas por muerte, incapacidad total permanente y gastos médicos.', NULL, NULL, NULL, 1, 0, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (3, '¿Qué necesitas para adquirir el **SOAT?**', NULL, NULL, NULL, 1, 1, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (4, '- **RENOVACIÓN**    

    Aquellos propietarios cuyo vehículo(s) ya cuente con el SOAT de la gestión anterior y con la respectiva ROSETA, podrán adquirir su SOAT solamente dictando o digitando el número de placa de su vehículo, en cualquiera de los puntos de comercialización presenciales y digitales, habilitados y autorizados

- **COMPRA NUEVA**

    Para aquellos propietarios de vehículos que adquieran el SOAT por primera vez (Vehículos 
             recién importados, vehículos que salgan de taller de carrozado, de reconstrucción por 
             accidente o que por alguna otra razón no hayan tramitado el SOAT correspondiente en 
             gestiones anteriores), deberán presentar cualquier documento que identifque al vehículo, 
             por ejemplo: RUAT, FVR o Póliza de importación y deberán hacerlo solamente en 
             sucursales y agencias de UNIVIDA S.A. para recabar la ROSETA correspondiente, además de 
             actualizar los datos del vehículo', NULL, NULL, NULL, 1, 1, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (5, '¿Qué cubre **el SOAT?**', NULL, NULL, NULL, 1, 2, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (6, '- Si falleces por causa de un accidente automovilístico, tus beneficiarios reciben una indemnización de Bs. 22.000
- Te indemnizamos en caso de invalidez total y permanente con un monto de Bs. 22.000
- Te indemnizamos con gastos médicos con un monto de hasta Bs. 24.000', NULL, NULL, NULL, 1, 2, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (7, 'Requisitos para cambio de uso **PARTICULAR a PÚBLICO o PÚBLICO a PARTICULAR**', NULL, NULL, NULL, 1, 3, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (8, '- Certificado de extravío de la FELC
- Depósito de Bs.20 (veinte bolivianos 00/100) a la cuenta 1-25041009 del Banco Unión S.A.
- Comprobante factura SOAT
- Fotocopia de RUAT
- Fotocopia de la Cédula de Identidad', NULL, NULL, NULL, 1, 3, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (9, 'Página Web', NULL, NULL, NULL, 2, 0, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (10, 'bi bi-globe', NULL, NULL, NULL, 2, 0, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (11, NULL, NULL, NULL, 2, 2, 0, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (12, 'COMPRAR SOAT', NULL, 'comprar-soat', NULL, 2, 0, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (13, 'UNIVidaApp', NULL, NULL, NULL, 2, 1, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (14, 'bi bi-phone', NULL, NULL, NULL, 2, 1, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (15, NULL, NULL, NULL, 3, 2, 1, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (16, 'DESCARGAR APP', NULL, 'descarga-app', NULL, 2, 1, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (17, 'Puntos de venta', NULL, NULL, NULL, 2, 2, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (18, 'bi bi-geo-alt', NULL, NULL, NULL, 2, 2, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (19, NULL, NULL, NULL, 4, 2, 2, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (20, 'Ver Puntos', NULL, 'soat/puntos-de-venta', NULL, 2, 2, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (21, 'Redes Sociales', NULL, NULL, NULL, 2, 3, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (22, 'bi bi-chat-left-dots', NULL, NULL, NULL, 2, 3, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (23, NULL, NULL, NULL, 5, 2, 3, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (24, 'VER MÁS', NULL, 'soat/redes-sociales', NULL, 2, 3, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (25, 'Precios SOAT', NULL, NULL, NULL, 3, 0, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (26, 'Verifica el precio del SOAT para tu motorizado', NULL, NULL, NULL, 3, 0, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (27, 'bi bi-cash-coin', NULL, NULL, NULL, 3, 0, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (28, NULL, NULL, NULL, 6, 3, 0, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (29, 'VER MÁS', NULL, 'soat/precios', NULL, 3, 0, 4, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (30, 'Datos Vehículo', NULL, NULL, NULL, 3, 1, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (31, 'Modifica los datos de tu motorizado', NULL, NULL, NULL, 3, 1, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (32, 'bi bi-car-front', NULL, NULL, NULL, 3, 1, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (33, NULL, NULL, NULL, 7, 3, 1, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (34, 'VER MÁS', NULL, 'soat/datos', NULL, 3, 1, 4, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (35, 'Comprobante SOAT', NULL, NULL, NULL, 3, 2, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (36, 'Adquiere el comprobante SOAT', NULL, NULL, NULL, 3, 2, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (37, 'bi bi-file-text', NULL, NULL, NULL, 3, 2, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (38, NULL, NULL, NULL, 8, 3, 2, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (39, 'VER MÁS', NULL, 'soat/comprobante', NULL, 3, 2, 4, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (40, 'Paso 1 - Succeso del accidente de tránsito', NULL, NULL, NULL, 4, 0, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (41, '- Las víctimas deben ser auxiliadas al centro médico más cercano
- Dar aviso del siniestro al Organismo Operativo de Tránsito', NULL, NULL, NULL, 4, 0, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (42, 'Paso 2 - Dar aviso del siniestro a Seguros y Reaseguros Personales UNIVIDA S.A. a través de:', NULL, NULL, NULL, 4, 1, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (43, '- Línea gratuita del Call Center 800-10-8444 (habilitado las 24 horas y los 7 días de la semana)
- Correo electrónico o Página Web
- Sucursales y agencias de UNIVIDA S.A. de lunes a viernes en horarios de oficina
    
**Personas que pueden realizar la denuncia:**
- Personal del centro médico
- Personal del Organismo Operativo de Tránsito 
- Víctimas
- Conductor o propietario del vehículo
- Cualquier persona que acredite interés legal 

**Datos que debe proporcionar:**
- Nombre completo del accidentado
- Número de placa o número de roseta del vehículo
- Denuncia realizada a Tránsito
- Fecha de ocurrencia y descripción del hecho
- Centro médico al que fue evacuado el accidentado
- Datos de contacto del denunciante
    
    **Nota:** El plazo para realizar la denuncia es de 15 días luego del suceso del accidente.', NULL, NULL, NULL, 4, 1, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (44, 'Paso 3 - Apertura del reclamo y verificación de causales de exclusión de cobertura', NULL, NULL, NULL, 4, 2, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (45, 'Con el aviso del siniestro, se procede a la asignación del código correspondiente al reclamo y a la apertura física del file con la documentación presentada. A su vez, se evalúan las circunstancias en las que ocurrió el siniestro para su cobertura, verificándose si éstas se enmarcan en alguna de las causales de exclusión de cobertura señaladas en el artículo 32 del Decreto Supremo 27295 de 20 de diciembre de 2003.', NULL, NULL, NULL, 4, 2, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (46, 'Paso 4 - Entrega de formulario de requisitos para la cobertura', NULL, NULL, NULL, 4, 3, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (47, 'De acuerdo a la evaluación del siniestro y las coberturas requeridas, se entrega al cliente el formulario con la documentación necesaria para otorgar la cobertura correspondiente, de conformidad al artículo 29 del Decreto Supremo 27295 de 20 de diciembre de 2003.', NULL, NULL, NULL, 4, 3, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (48, 'Paso 5 - Entrega de la documentación', NULL, NULL, NULL, 4, 4, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (49, '**Heridos**
- Documento que identifique al herido
- Certificado emitido por el organismo operativo de tránsito
- Certificado médico
    
    En caso de víctimas que hayan cancelado al centro médico se solicitará recibos y/o facturas a nombre de Seguros y Reaseguros Personales UNIVIDA S.A. al Nº de NIT 301204024.

**Fallecidos**
- Documento que identifique al fallecido
- Certificado emitido por el organismo operativo de tránsito
- Certificado médico forense o certificado médico (si corresponde)

**Incapacidad total y permanente**
- Documento que identifique al herido
- Certificado emitido por el organismo operativo de tránsito
- Dictamen de calificación de incapacidad emitido por la EEC
    
    Seguros y reaseguros UNIVIDA S.A. A requerimiento de la víctima solicitará la calificación de incapacidad de conformidad al artículo 26 del D.S. 27295.', NULL, NULL, NULL, 4, 4, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (50, 'Paso 6 - Pago de la indemnización', NULL, NULL, NULL, 4, 5, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (51, 'El plazo para el pago es de 15 días hábiles a partir de la recepción de todos los documentos necesarios.

**Indemnización por gastos médicos**
- Pago de las proformas al centro médico
- En caso de recibos y/o facturas de las víctimas se procede a su reembolso

**Indemnización por fallecimiento**
- Pago a los derechohabientes del fallecido

En caso de existir conflicto de intereses entre los derechohabientes se realiza un depósito judicial.

**Indemnización por incapacidad permanente**
- Pago de la indemnización a la víctima', NULL, NULL, NULL, 4, 5, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (52, 'Paso 7 - Ejercicio del Derecho de Repetición', NULL, NULL, NULL, 4, 6, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (53, 'Se verifica la conclusión del reclamo con el pago de todas las indemnizaciones del siniestro. Inicio del proceso de repetición ante la autoridad competente. En caso de existir causales de repetición.', NULL, NULL, NULL, 4, 6, 1, NULL, NULL, NULL, NULL);


--
-- TOC entry 3431 (class 0 OID 17048)
-- Dependencies: 222
-- Data for Name: Seguros; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."Seguros" VALUES (1, 'Seguro de Accidentes Personales Individual', NULL, NULL, NULL, NULL, 'Accidentes Personales', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-healthcare', 0, 3, false, 2, NULL);
INSERT INTO "Seguro"."Seguros" VALUES (2, 'Seguro de Vida Individual', NULL, NULL, NULL, NULL, 'Vida Individual', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)', 'icon-family-insurance', 0, 2, true, 1, NULL);


--
-- TOC entry 3441 (class 0 OID 17118)
-- Dependencies: 232
-- Data for Name: BannerPagina; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

INSERT INTO "Recurso"."BannerPagina" VALUES (1, 1, NULL, 1, NULL, NULL, NULL, NULL, '', 'S O A T');
INSERT INTO "Recurso"."BannerPagina" VALUES (2, NULL, 1, 1, NULL, NULL, NULL, NULL, '', 'Seguro de Vida Individual');


--
-- TOC entry 3437 (class 0 OID 17087)
-- Dependencies: 228
-- Data for Name: Planes; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."Planes" VALUES (1, 1, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 45, '- Muerte por cualquier causa **Bs.15.000**
- Invalidez total y permanente **Bs.7.500**
- Gastos de sepelio **Bs.1.500**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (2, 1, 'Plan B', ' PRECIO ANUAL (POR PERSONA)', 90, '- Muerte por cualquier causa **Bs.30.000**
- Invalidez total y permanente **Bs.15.000**
- Gastos de sepelio **Bs.3.000**', NULL, NULL, NULL, NULL, 0, false);


--
-- TOC entry 3439 (class 0 OID 17100)
-- Dependencies: 230
-- Data for Name: SeguroDetalles; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."SeguroDetalles" VALUES (1, 1, '¿Qué es el **Seguro de
Accidentes Personales?**', 'Es un plan de protección creado para usted y su familia, consistente en otorgar un apoyo económico a la familia del asegurado ante el fallecimiento de este por cualquier causa (salvo exclusiones específicas). 

Por ejemplo, con el **Plan A** de nuestro Seguro de Vida Individual, en caso de invalidez total y permanente el asegurado recibirá un monto de **Bs.7.500**. En caso de fallecimiento la empresa pagará **Bs.15.000** a los beneficiarios, además de **Bs.1.500** para gastos de sepelio.
', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (2, 1, '¿Qué cubre el **Seguro 
de Vida Individual?**', '- En caso de muerte por cualquier causa, tus beneficiarios reciben una indemnización.
- Te indemnizamos en caso de invalidez total y permanente.
- Indemnizamos a tus beneficiarios con gastos de sepelio.
', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (3, 1, '¿Cómo 
**asegurarte?**', '- Presenta la fotocopia de tu Cédula de Identidad vigente.
- Llena los formularios que serán proporcionados por nuestra entidad.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (4, 1, '**Exclusiones** del 
Seguro de Vida 
Individual', '- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.', NULL, NULL, NULL, NULL, 0);


--
-- TOC entry 3423 (class 0 OID 17006)
-- Dependencies: 214
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" VALUES ('20240619214807_inicio', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240619215006_inicio1', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620061704_modelo-seguros', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620062614_modelo-seguros2', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620065615_eliminacion-catsegurodetalle', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620071157_adicion-campos-faltantes', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620072746_adicion-campos-faltantes2', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620073713_campos-faltantes-orden-visible', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620142614_propiedades-navegacion', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620145917_propiedad-ruta', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620155000_propiedades-bannerpagina', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620193942_modificacion-propiedad-seguros', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620222712_campo-tiposeguro', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620225253_cambio-esquema', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240620233310_retiro-ruta-adicion-relaciones', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240625095425_menu-model3', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240625101814_menu-propiedades', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240625102942_menu-propiedades3', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240625105011_menu-propiedades4', '7.0.20');


--
-- TOC entry 3453 (class 0 OID 0)
-- Dependencies: 215
-- Name: CatTipoRecurso_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoRecurso_Id_seq"', 3, true);


--
-- TOC entry 3454 (class 0 OID 0)
-- Dependencies: 217
-- Name: CatTipoSeccion_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeccion_Id_seq"', 4, true);


--
-- TOC entry 3455 (class 0 OID 0)
-- Dependencies: 235
-- Name: CatTipoSeguro_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeguro_Id_seq"', 3, true);


--
-- TOC entry 3456 (class 0 OID 0)
-- Dependencies: 237
-- Name: MenuPrincipal_Id_seq; Type: SEQUENCE SET; Schema: Menu; Owner: postgres
--

SELECT pg_catalog.setval('"Menu"."MenuPrincipal_Id_seq"', 23, true);


--
-- TOC entry 3457 (class 0 OID 0)
-- Dependencies: 233
-- Name: Datos_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Datos_Id_seq"', 53, true);


--
-- TOC entry 3458 (class 0 OID 0)
-- Dependencies: 219
-- Name: PaginasDinamicas_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."PaginasDinamicas_Id_seq"', 1, false);


--
-- TOC entry 3459 (class 0 OID 0)
-- Dependencies: 225
-- Name: Secciones_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Secciones_Id_seq"', 1, false);


--
-- TOC entry 3460 (class 0 OID 0)
-- Dependencies: 231
-- Name: BannerPagina_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."BannerPagina_Id_seq"', 2, true);


--
-- TOC entry 3461 (class 0 OID 0)
-- Dependencies: 223
-- Name: Recursos_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."Recursos_Id_seq"', 1, false);


--
-- TOC entry 3462 (class 0 OID 0)
-- Dependencies: 227
-- Name: Planes_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Planes_Id_seq"', 2, true);


--
-- TOC entry 3463 (class 0 OID 0)
-- Dependencies: 229
-- Name: SeguroDetalles_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."SeguroDetalles_Id_seq"', 4, true);


--
-- TOC entry 3464 (class 0 OID 0)
-- Dependencies: 221
-- Name: Seguros_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Seguros_Id_seq"', 2, true);


-- Completed on 2024-06-25 07:17:24

--
-- PostgreSQL database dump complete
--

