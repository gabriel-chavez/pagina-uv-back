--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-06-20 00:23:09

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
-- TOC entry 3375 (class 0 OID 17206)
-- Dependencies: 221
-- Data for Name: BannerPagina; Type: TABLE DATA; Schema: Recurso; Owner: postgres
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
-- TOC entry 3382 (class 0 OID 0)
-- Dependencies: 222
-- Name: Datos_DatoId_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Datos_Id_seq"', 53, true);




-- Completed on 2024-06-20 00:23:10

--
-- PostgreSQL database dump complete
--

