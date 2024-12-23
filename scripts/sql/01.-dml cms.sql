--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-12-22 23:45:13

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
-- TOC entry 3459 (class 0 OID 17114)
-- Dependencies: 214
-- Data for Name: CatTipoRecurso; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (1, 'Imagen', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (2, 'Video', NULL, NULL, NULL, NULL, false);
INSERT INTO "Catalogo"."CatTipoRecurso" VALUES (3, 'Archivo', NULL, NULL, NULL, NULL, false);


--
-- TOC entry 3461 (class 0 OID 17121)
-- Dependencies: 216
-- Data for Name: CatTipoSeccion; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (5, 'SeccionContenidoTipo1', 'Titulo texto e imagen', NULL, NULL, NULL, NULL, true, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (6, 'SeccionContenidoTipo4', 'Imagenes, titulo, subtitulo y texto', NULL, NULL, NULL, NULL, true, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (7, 'SeccionCardTipo1', '3 cards por fila', NULL, NULL, NULL, NULL, true, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (8, 'SeccionCardImagenTipo1', 'imagenes', NULL, NULL, NULL, NULL, true, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (9, 'SeccionCardImagenTipo2', 'card con imagenes y boton', NULL, NULL, NULL, NULL, false, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (10, 'SeccionContenedorIFrame', 'Contenedor iframe', NULL, NULL, NULL, NULL, true, '', '');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (1, 'SeccionContenidoTipo3', '2 columnas', NULL, NULL, NULL, NULL, true, '\assets\images\secciones\ContenidoInformativo.png', '\assets\images\secciones\ContenidoInformativoGuia.png');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (2, 'SeccionSliderTipo1', 'Seccion slider tipo 1', NULL, NULL, NULL, NULL, true, '\assets\images\secciones\SliderContenidos.png', '\assets\images\secciones\SliderContenidosGuia.png');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (3, 'SeccionSliderTipo2', 'Seccion slider tipo 2', NULL, NULL, NULL, NULL, true, '\assets\images\secciones\SliderElementos.png', '\assets\images\secciones\SliderElementosGuia.png');
INSERT INTO "Catalogo"."CatTipoSeccion" VALUES (4, 'SeccionAcordeonTipo1', 'Seccion acordeon tipo 1', NULL, NULL, NULL, NULL, true, '\assets\images\secciones\AcordeonContenido.png', '\assets\images\secciones\AcordeonContenidoGuia.png');


--
-- TOC entry 3463 (class 0 OID 17130)
-- Dependencies: 218
-- Data for Name: CatTipoSeguro; Type: TABLE DATA; Schema: Catalogo; Owner: postgres
--

INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (1, 'Seguro de Vida', true, NULL, NULL, NULL, NULL);
INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (2, 'Seguro de Accidentes Personales', true, NULL, NULL, NULL, NULL);
INSERT INTO "Catalogo"."CatTipoSeguro" VALUES (3, 'Otros Seguros', true, NULL, NULL, NULL, NULL);


--
-- TOC entry 3469 (class 0 OID 17148)
-- Dependencies: 224
-- Data for Name: PaginasDinamicas; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (2, 'Historia', NULL, NULL, '2024-07-26 10:45:17.235773', NULL, false);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (3, 'Misión, visión y valores', NULL, NULL, '2024-09-19 11:47:44.104646', NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (4, 'Objetivos estratégicos', '2024-09-19 13:57:21.802407', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (5, 'Directorio y plantel ejecutivo', '2024-09-19 14:27:40.985458', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (6, 'Estructura orgánica', '2024-09-19 14:42:31.425445', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (7, 'Grupo financiero unión', '2024-09-19 15:17:48.563252', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (8, 'Gestión Normativa', '2024-09-19 15:44:16.979022', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (9, 'Memorias Empresariales', '2024-09-19 16:11:12.270061', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (10, 'Precios SOAT', NULL, NULL, '2024-09-20 12:11:19.915121', NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (11, 'Comprar o renovar SOAT', NULL, NULL, '2024-09-20 18:47:18.574391', NULL, true);
INSERT INTO "PaginaDinamica"."PaginasDinamicas" VALUES (1, 'S O A T', NULL, NULL, '2024-12-01 23:34:11.168025', NULL, true);


--
-- TOC entry 3475 (class 0 OID 17170)
-- Dependencies: 230
-- Data for Name: Recursos; Type: TABLE DATA; Schema: Recurso; Owner: postgres
--

INSERT INTO "Recurso"."Recursos" VALUES (1, 'baner prueba', 1, '/assets/images/backgrounds/page-header-bg.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (2, 'Compra soat', 1, '/assets/images/soat/compra-web.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (3, 'Descarga App', 1, '/assets/images/soat/unividaapp.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (4, 'Puntos de venta', 1, '/assets/images/soat/puntos.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (5, 'Redes sociales', 1, '/assets/images/soat/facebook-whatsapp.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (7, 'Datos SOAT', 1, '/assets/images/soat/datos-vehiculo.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (8, 'Comprobante SOAT', 1, '/assets/images/soat/comprobante-soat.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (6, 'Precios SOAT', 1, '/assets/images/soat/precios-soat.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (9, 'Pareja con celular', 1, '/assets/images/varios/about-three-img-1.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (11, 'Mujer con niña', 1, '/assets/images/varios/about-three-img-3.jpg', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (12, 'mision vision valores', 1, '/assets/images/varios/IMAGEN_1Recurso_10.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (13, 'icono incrementar', 1, '/assets/images/varios/icono_mesa1.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (14, 'icono recarga', 1, '/assets/images/varios/icono_mesa2.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (15, 'icono familia', 1, '/assets/images/varios/icono_mesa3.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (16, 'icono personas', 1, '/assets/images/varios/icono_mesa4.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (17, 'icono manos', 1, '/assets/images/varios/icono_mesa5.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (18, 'icono personas 2
', 1, '/assets/images/varios/icono_mesa6.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (19, 'icono corazon', 1, '/assets/images/varios/icono_mesa7.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (20, 'plantel ejecutivo', 1, '/assets/images/varios/directorio-plantel-e1.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (21, 'Estructura organica', 1, '/assets/images/varios/ESTRUECUTRA_ORGANICARecurso_28.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (22, 'BancoUnion', 1, '/assets/images/varios/BANCO_UNIONRecurso_27.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (23, 'UniBienes', 1, '/assets/images/varios/UNIBIENESRecurso_29.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (24, 'SafiUnion', 1, '/assets/images/varios/SAFI_UNION_Recurso 30.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (25, 'ValoresUnion', 1, '/assets/images/varios/VALORES_UNION_Recurso_31.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (26, 'Código de Ética Empresarial', 1, '/assets/images/varios/GEST_NORMATIVA_1Recurso_32.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (27, 'Reglamento de Transparencia', 1, '/assets/images/varios/GEST_NORMATIVA 2Recurso_33.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (28, 'Doc Código de Ética Empresarial', 3, '/assets/images/varios/codigo_etica_empresarial.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (29, 'Doc Reglamento de Transparencia', 3, '/assets/images/varios/reglamento_transparencia_lucha_corrupcion.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (61, 'Memoria2018', 1, '/assets/memorias/2018Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (51, 'Memoria2023', 1, '/assets/memorias/2023Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (52, 'doc Memoria2023', 3, '/assets/memorias/memoria2023.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (53, 'Memoria2022', 1, '/assets/memorias/2022Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (54, 'doc Memoria2022', 3, '/assets/memorias/memoria2022.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (55, 'Memoria2021', 1, '/assets/memorias/2021Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (56, 'doc Memoria2021', 3, '/assets/memorias/memoria2021.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (57, 'Memoria2020', 1, '/assets/memorias/2020Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (59, 'Memoria2019', 1, '/assets/memorias/2019Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (60, 'doc Memoria2019', 3, '/assets/memorias/memoria2019.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (62, 'doc Memoria2018', 3, '/assets/memorias/memoria2018.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (63, 'Memoria2017', 1, '/assets/memorias/2017Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (64, 'doc Memoria2017', 3, '/assets/memorias/memoria2017.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (65, 'Memoria2016', 1, '/assets/memorias/2016Recurso.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (66, 'doc Memoria2016', 3, '/assets/memorias/memoria2016.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (58, 'doc Memoria2020', 3, '/assets/memorias/memoria2020.pdf', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (67, 'precios soat 2024', 1, '/assets/images/soat/precios-soat-2024.png', NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (80, 'IMG_20220611_102805', 1, '/assets/uploads/IMG_20220611_102805_34c05032.jpg', NULL, '2024-11-19 10:37:46.193586', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (82, 'IMG_20220615_174937', 1, '/uploads/IMG_20220615_174937_1cd283f5.jpg', NULL, '2024-11-19 10:52:16.501192', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (83, 'IMG_20220429_182408', 1, '/uploads/assets/IMG_20220429_182408_24874495.jpg', NULL, '2024-11-19 10:54:24.483165', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (89, 'Banner de paginas internas AP', 1, '/assets/images/backgrounds/Banner de paginas internas AP_3f41076d.jpg', NULL, '2024-11-19 13:01:15.402886', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (125, 'IMG_20220615_174937', 1, '/assets/uploads/IMG_20220615_174937_26c00d1c.jpg', NULL, '2024-11-19 13:59:31.530048', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (126, 'IMG_20220429_182408', 1, '/assets//uploads/IMG_20220429_182408_98aa4cd5.jpg', NULL, '2024-11-19 14:08:09.20552', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (127, 'IMG_20220611_102937', 1, '/assets//uploads/IMG_20220611_102937_b18aa0af.jpg', NULL, '2024-11-19 14:09:07.190069', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (129, 'IMG_20220611_102805', 1, '/assets///IMG_20220611_102805_345ecf26.jpg', NULL, '2024-11-20 06:10:56.693673', NULL, NULL, NULL);
INSERT INTO "Recurso"."Recursos" VALUES (130, 'IMG_20220611_102805', 1, '/assets///IMG_20220611_102805_9e106e6f.jpg', NULL, '2024-11-20 06:19:47.791711', NULL, NULL, NULL);


--
-- TOC entry 3481 (class 0 OID 17191)
-- Dependencies: 236
-- Data for Name: Seguros; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."Seguros" VALUES (5, 'Seguro de Accidentes Personales - Deportista Seguro', NULL, NULL, NULL, NULL, 'Deportista Seguro', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-family-insurance', 0, 3, true, 2);
INSERT INTO "Seguro"."Seguros" VALUES (2, 'Seguro de Vida Individual', NULL, NULL, NULL, NULL, 'Vida Individual', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)', 'icon-family-insurance', 0, 3, true, 1);
INSERT INTO "Seguro"."Seguros" VALUES (3, 'Seguro de Vida Individual - Vida Mujer', NULL, NULL, NULL, NULL, 'Vida Mujer', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-healthcare', 0, 3, true, 2);
INSERT INTO "Seguro"."Seguros" VALUES (6, 'Seguro de Accidentes Personales - Gremialista Seguro', NULL, NULL, NULL, NULL, 'Gremialista Seguro', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-healthcare', 0, 3, true, 2);
INSERT INTO "Seguro"."Seguros" VALUES (4, 'Seguro de Vida Individual con cobertura 
adicional por COVID-19', NULL, NULL, NULL, NULL, 'COVID-19', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-healthcare', 0, 3, false, 2);
INSERT INTO "Seguro"."Seguros" VALUES (1, 'Seguro de Accidentes Personales Individual', NULL, NULL, '2024-12-01 23:33:59.420316', NULL, 'Accidentes Personales', 'Precio único para todas las edades (Edad mínima 18 años y edad máxima 60 años)
**Cláusula Adicional de Aviso de Siniestro 10 días.**', 'icon-healthcare', 0, 89, true, 2);


--
-- TOC entry 3465 (class 0 OID 17136)
-- Dependencies: 220
-- Data for Name: MenuPrincipal; Type: TABLE DATA; Schema: Menu; Owner: postgres
--

INSERT INTO "Menu"."MenuPrincipal" VALUES (34, 'Deportista Seguro', 'deportista-seguro', 4, true, true, 1, NULL, NULL, NULL, NULL, NULL, 5);
INSERT INTO "Menu"."MenuPrincipal" VALUES (35, 'Gremialista Seguro', 'gremialista-seguro', 4, true, true, 1, NULL, NULL, NULL, NULL, NULL, 6);
INSERT INTO "Menu"."MenuPrincipal" VALUES (9, 'Seguro de Desgravamen', 'desgravamen', 4, true, true, 0, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (10, 'Seguro de Cesantía', 'cesantia', 4, true, true, 0, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (15, 'Puntos de venta', 'puntos-de-venta', 11, true, true, 0, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (3, 'Inicio', NULL, NULL, true, true, 1, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (4, 'Nuestros Seguros', 'nuestros-seguros', NULL, true, true, 2, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (5, 'Seguros Obligatorios', 'seguros-obligatorios', NULL, true, true, 3, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (6, 'Sobre la Empresa', 'empresa', NULL, true, true, 4, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (7, 'Seguro de Accidentes Personales', 'accidentes-personales', 4, true, true, 0, NULL, NULL, NULL, NULL, NULL, 1);
INSERT INTO "Menu"."MenuPrincipal" VALUES (8, 'Seguro de Vida', 'vida', 4, true, true, 0, NULL, NULL, NULL, NULL, NULL, 2);
INSERT INTO "Menu"."MenuPrincipal" VALUES (11, 'Soat', 'soat', 5, true, true, 0, NULL, NULL, NULL, NULL, 1, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (16, 'Historia', 'historia', 6, true, true, 0, NULL, NULL, NULL, NULL, 2, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (17, 'Misión, Visión y Valores', 'mision-vision-valores', 6, true, true, 0, NULL, NULL, NULL, NULL, 3, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (18, 'Objetivos Estratégicos', 'objetivos-estrategicos', 6, true, true, 0, NULL, NULL, NULL, NULL, 4, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (19, 'Directorio y Plantel Ejecutivo', 'directorio-plantel-ejecutivo', 6, true, true, 0, NULL, NULL, NULL, NULL, 5, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (20, 'Estructura Orgánica', 'estructura-organica', 6, true, true, 0, NULL, NULL, NULL, NULL, 6, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (21, 'Grupo Financiero Unión', 'grupo-financiero-union', 6, true, true, 0, NULL, NULL, NULL, NULL, 7, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (22, 'Gestión Normativa', 'gestion-normativa', 6, true, true, 0, NULL, NULL, NULL, NULL, 8, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (23, 'Memorias Empresariales', 'memorias-empresariales', 6, true, true, 0, NULL, NULL, NULL, NULL, 9, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (14, 'Precios Soat', 'precios', 11, true, true, 0, NULL, NULL, NULL, NULL, 10, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (13, 'Comprar Soat', 'comprar', 11, true, true, 0, NULL, NULL, NULL, NULL, 11, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (12, 'Soatc', 'soatc', 5, true, true, 0, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (27, 'Cobertura Soat', 'cobertura-soat', 11, true, false, 0, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO "Menu"."MenuPrincipal" VALUES (31, 'Vida Mujer', 'vida-mujer', 4, true, true, 1, NULL, NULL, NULL, NULL, NULL, 3);
INSERT INTO "Menu"."MenuPrincipal" VALUES (32, 'COVID-19', 'covid-19', 4, true, true, 1, NULL, NULL, NULL, NULL, NULL, 4);


--
-- TOC entry 3473 (class 0 OID 17162)
-- Dependencies: 228
-- Data for Name: BannerPagina; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (2, NULL, 1, 1, NULL, NULL, NULL, NULL, '', 'Seguro de Vida Individual');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (3, 2, NULL, 1, '2024-09-19 11:42:19.317315', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (4, 3, NULL, 1, '2024-09-19 11:47:50.135788', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (5, 4, NULL, 1, '2024-09-19 13:57:26.997127', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (6, 5, NULL, 1, '2024-09-19 14:27:56.689471', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (7, 6, NULL, 1, '2024-09-19 14:42:38.112464', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (8, 7, NULL, 1, '2024-09-19 15:17:53.77075', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (9, 8, NULL, 1, '2024-09-19 15:44:22.78704', NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (10, 9, NULL, 1, NULL, NULL, '2024-09-20 18:41:56.521019', NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (1, 1, NULL, 1, NULL, NULL, '2024-09-20 18:45:26.391344', NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (11, NULL, 2, 1, NULL, NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (12, NULL, 3, 1, NULL, NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (14, NULL, 5, 1, NULL, NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (15, NULL, 6, 1, NULL, NULL, NULL, NULL, '', '');
INSERT INTO "PaginaDinamica"."BannerPagina" VALUES (13, NULL, 4, 1, NULL, NULL, NULL, NULL, '', 'Seguro de Vida Individual con cobertura 
adicional por COVID-19');


--
-- TOC entry 3485 (class 0 OID 17958)
-- Dependencies: 240
-- Data for Name: CatEstiloBanner; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3487 (class 0 OID 17966)
-- Dependencies: 242
-- Data for Name: CatTipoBannerPaginaPrincipal; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3489 (class 0 OID 17974)
-- Dependencies: 244
-- Data for Name: BannerPaginaPrincipalMaestro; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--



--
-- TOC entry 3491 (class 0 OID 17992)
-- Dependencies: 246
-- Data for Name: BannerPaginaPrincipalDetalle; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--



--
-- TOC entry 3471 (class 0 OID 17155)
-- Dependencies: 226
-- Data for Name: Secciones; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."Secciones" VALUES (1, 1, 'Seccion compra Soat', '', '', '', 1, 0, NULL, NULL, '2024-07-26 19:01:24.008504', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (9, 5, 'Historia', 'Historia', '', '', 2, 0, '2024-09-19 11:18:32.876577', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (10, 5, 'Misión, visión y valores', '', '', '', 3, 0, '2024-09-19 11:48:07.104399', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (11, 7, 'Objetivos estratégicos', 'Objetivos Estratégicos', 'Impulsando soluciones innovadoras y un impacto positivo', '', 4, 0, NULL, NULL, '2024-09-19 14:17:30.385974', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (12, 5, 'Directorio y plantel ejecutivo', '', '', '', 5, 0, '2024-09-19 14:28:16.932648', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (13, 5, 'Estructura orgánica', '', '', '', 6, 0, NULL, NULL, '2024-09-19 14:44:38.58775', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (14, 8, 'Grupo financiero unión', '', 'Grupo financiero unión', '', 7, 0, NULL, NULL, '2024-09-19 15:22:00.358639', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (15, 9, 'Gestión Normativa', '', 'Gestión Normativa', '', 8, 0, NULL, NULL, '2024-09-19 16:03:04.800248', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (16, 2, 'Memorias Empresariales', 'Memorias Empresariales', 'Nuestros hitos&#x20;
y logros a lo largo del camino.', '', 9, 0, NULL, NULL, '2024-09-20 10:14:18.558739', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (17, 5, 'Precios soat', 'precios', 'Conoce nuestros precios para la gestión Soat 2024', '', 10, 0, '2024-09-20 10:35:35.423743', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (18, 10, 'COMPRAR O RENOVAR SOAT', '', '', '', 11, 0, '2024-09-20 11:38:09.274744', NULL, NULL, NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (3, 3, 'Servicios Soat', 'SERVICIOS SOAT
', 'Explora nuestros servicios
relacionados con el SOAT', '', 1, 2, NULL, NULL, '2024-07-26 13:04:30.267267', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (4, 4, 'Sección Accidentes
', 'ACCIDENTES DE TRÁNSITO
', '¿Qué hacer en caso de
un accidente de tránsito?', '', 1, 3, NULL, NULL, '2024-07-26 13:04:34.038104', NULL, true);
INSERT INTO "PaginaDinamica"."Secciones" VALUES (2, 2, 'Información Soat', '¿CÓMO ADQUIRIR EL SOAT?
', 'Opciones para obtener tu
SOAT de manera rápida y sencilla', '', 1, 1, NULL, NULL, '2024-07-26 17:46:27.063625', NULL, true);


--
-- TOC entry 3467 (class 0 OID 17142)
-- Dependencies: 222
-- Data for Name: Datos; Type: TABLE DATA; Schema: PaginaDinamica; Owner: postgres
--

INSERT INTO "PaginaDinamica"."Datos" VALUES (1, '¿Qué es el **SOAT**?', NULL, NULL, NULL, 1, 0, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (2, 'El artículo 37 de la Ley N° 1883 de Seguros, señala que el SOAT es el “Seguro Obligatorio de Accidentes de Tránsito” que todo vehículo motorizado, público y/o privado, debe contar con carácter obligatorio, para poder transitar por vías públicas del territorio boliviano. Además, la norma señala que, el Seguro es incuestionable y de beneficio uniforme con coberturas por muerte, incapacidad total permanente y gastos médicos.', NULL, NULL, NULL, 1, 0, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (3, '¿Qué necesitas para adquirir el **SOAT?**', NULL, NULL, NULL, 1, 1, 0, NULL, NULL, NULL, NULL);
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
INSERT INTO "PaginaDinamica"."Datos" VALUES (32, 'bi bi-car-front', NULL, NULL, NULL, 3, 1, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (33, NULL, NULL, NULL, 7, 3, 1, 3, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (35, 'Comprobante SOAT', NULL, NULL, NULL, 3, 2, 0, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (36, 'Adquiere el comprobante SOAT', NULL, NULL, NULL, 3, 2, 1, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (37, 'bi bi-file-text', NULL, NULL, NULL, 3, 2, 2, NULL, NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (38, NULL, NULL, NULL, 8, 3, 2, 3, NULL, NULL, NULL, NULL);
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
INSERT INTO "PaginaDinamica"."Datos" VALUES (130, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 64, 16, 6, 3, '2024-09-20 10:09:23.997502', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (126, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 62, 16, 5, 3, NULL, NULL, '2024-09-20 10:09:33.03698', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (114, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 56, 16, 2, 3, NULL, NULL, '2024-09-20 10:09:48.288691', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (133, '', '2024-09-20 14:39:43.729+00', '', NULL, 17, 0, 2, NULL, NULL, '2024-09-20 11:11:58.189944', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (136, '100%', '2024-09-20 15:38:10.612+00', '', NULL, 18, 0, 1, '2024-09-20 11:39:26.234635', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (30, 'Cobertura de SOAT', '2024-09-20 16:07:44.796+00', '', NULL, 3, 1, 0, NULL, NULL, '2024-09-20 12:07:56.728898', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (31, 'Verifica la cobertura de SOAT', '2024-09-20 16:08:11.195+00', '', NULL, 3, 1, 1, NULL, NULL, '2024-09-20 12:08:25.700718', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (39, 'VER MÁS', '2024-09-20 16:37:08.378+00', 'https://soat.univida.bo:9097/UNIVidaNetSOATClienteFinal/Modulos_/Cliente/Login/wfLoginCliente', NULL, 3, 2, 4, NULL, NULL, '2024-09-20 12:37:15.668321', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (34, 'VER MÁS', '2024-09-20 16:03:28.031+00', 'https://soat.univida.bo:9097/UNIVidaNetSOATClienteFinal/Modulos_/Cliente/ConsultasVerificacionSoat/wfObtener', NULL, 3, 1, 4, NULL, NULL, '2024-09-20 12:37:02.172419', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (12, 'COMPRAR SOAT', '2024-09-20 16:43:58.894+00', 'soat/comprar', NULL, 2, 0, 3, NULL, NULL, '2024-09-20 12:44:46.844958', NULL);
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
INSERT INTO "PaginaDinamica"."Datos" VALUES (102, 'bi bi-journal-bookmark', '2024-09-19 20:11:38.795+00', '', NULL, 16, 0, 1, NULL, NULL, '2024-09-19 16:34:06.479678', NULL);
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
INSERT INTO "PaginaDinamica"."Datos" VALUES (132, '', '2024-09-20 14:35:42.264+00', '', NULL, 17, 0, 1, NULL, NULL, '2024-09-20 11:11:39.559805', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (131, 'Precios SOAT 2024', '2024-09-20 14:35:42.264+00', '', NULL, 17, 0, 0, NULL, NULL, '2024-09-20 11:11:49.70293', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (134, '', '2024-09-20 14:39:43.729+00', '', 67, 17, 0, 3, '2024-09-20 11:12:07.560336', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (137, '750', '2024-09-20 15:38:10.612+00', '', NULL, 18, 0, 2, '2024-09-20 11:39:34.420645', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (4, '* **RENOVACIÓN**
  Aquellos propietarios cuyo vehículo(s) ya cuente con el SOAT de la gestión anterior y con la respectiva ROSETA, podrán adquirir su SOAT solamente dictando o digitando el número de placa de su vehículo, en cualquiera de los puntos de comercialización presenciales y digitales, habilitados y autorizados
* **COMPRA NUEVA**
  Para aquellos propietarios de vehículos que adquieran el SOAT por primera vez (Vehículos
  recién importados, vehículos que salgan de taller de carrozado, de reconstrucción por
  accidente o que por alguna otra razón no hayan tramitado el SOAT correspondiente en
  gestiones anteriores), deberán presentar cualquier documento que identifque al vehículo,
  por ejemplo: RUAT, FVR o Póliza de importación y deberán hacerlo solamente en
  sucursales y agencias de UNIVIDA S.A. para recabar la ROSETA correspondiente, además de
  actualizar los datos del vehículo', '2024-08-24 05:56:47.072+00', '', NULL, 1, 1, 1, NULL, NULL, '2024-08-24 01:57:02.097156', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (62, 'Conoce nuestra historia', '2024-09-19 15:18:38.384+00', '', NULL, 9, 0, 0, '2024-09-19 11:19:07.864886', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (63, '', '2024-09-19 15:18:38.384+00', '', NULL, 9, 0, 1, NULL, NULL, '2024-09-19 11:21:21.351214', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (64, 'Seguros y Reaseguros Personales **UNIVIDA S.A.** especializada en la administración de riesgos personales y cuyos lineamientos se encuentran dirigidos a brindar protección a la población boliviana, democratizando el acceso a los seguros con un enfoque social e inclusivo.

**UNIVIDA S.A.** obtuvo la autorización de funcionamiento el 19 de noviembre de 2015 a través de Resolución Administrativa APS/DJ/DS/Nº 1215·2015 de la Autoridad de Fiscalización y Control de Pensiones y Seguros (APS). Asimismo, el lanzamiento oficial al público fue en febrero de 2016.

Posteriormente y conforme a lo establecido en Resolución Administrativa APS/DJ/DS/Nº1517·2016 del 17 de octubre de 2016 **UNIVIDA S.A.** se habilitó como la empresa para la administración y comercialización del Seguro Obligatorio de Accidentes de Tránsito (SOAT).

De igual manera se le otorgó la autorización para la comercialización del Seguro Obligatorio de Accidentes de la Trabajadora y el Trabajador en el Ámbito de la Construcción (SOAT-C) a través de Resolución Administrativa APS/DJ/DS/Nº0380/2021 del 22 de abril de 2021.

La demanda de mercado ha hecho que **UNIVIDA S.A.** tenga presencia geográfica a nivel nacional, contando actualmente con 18 oficinas en todo el territorio boliviano (1 oficina nacional, 9 sucursales y 8 agencias en ciudades capitales) y con más de 250 trabajadores a nivel nacional.

De acuerdo con los datos de la Autoridad de Fiscalización y Control de Pensiones y Seguros (APS), **UNIVIDA S.A.** ocupa el 3er lugar en Producción Directa Neta de Anulaciones en el Mercado de Seguros de Personas en Bolivia. Asimismo, la calificación de riesgo denota solvencia en cuanto al cumplimiento de obligaciones; en este sentido Moody’s LA. Proporcionó una calificación AA3 y AESA RATINGS calificó a UNIVIDA S.A. con A1.', '2024-09-19 15:18:38.384+00', '', NULL, 9, 0, 2, '2024-09-19 11:21:29.029651', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (66, '', '2024-09-19 15:29:04.686+00', '', 2, 9, 0, 3, '2024-09-19 11:31:48.42025', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (69, '', '2024-09-19 15:50:32.094+00', '', NULL, 10, 0, 2, NULL, NULL, '2024-09-19 11:51:48.700301', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (81, 'Directorio y plantel ejecutivo', '2024-09-19 18:29:38.889+00', '', NULL, 12, 0, 0, NULL, NULL, '2024-09-19 14:34:39.326423', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (85, 'Estructura orgánica', '2024-09-19 18:42:49.789+00', '', NULL, 13, 0, 0, '2024-09-19 14:43:02.025844', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (67, 'Misión, visión y valores', '2024-09-19 15:48:08.758+00', '', NULL, 10, 0, 0, NULL, NULL, '2024-09-19 11:56:39.939185', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (68, 'Somos la empresa de los bolivianos
orientada a:', '2024-09-19 15:48:08.758+00', '', NULL, 10, 0, 1, NULL, NULL, '2024-09-19 11:56:54.752582', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (86, '', '2024-09-19 18:42:49.789+00', '', NULL, 13, 0, 1, '2024-09-19 14:43:07.275197', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (70, '50', '2024-09-19 15:50:32.094+00', '', 12, 10, 0, 3, NULL, NULL, '2024-09-19 12:45:21.009246', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (71, 'Incrementar la rentabilidad empresarial a partir de la cartera consolidada y la diversificación de productos y servicios.', '2024-09-19 17:59:05.118+00', '', 13, 11, 0, 0, '2024-09-19 14:02:04.479737', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (72, 'Modernizar la gestión empresarial en todos sus componentes.', '2024-09-19 17:59:05.118+00', '', 14, 11, 0, 1, '2024-09-19 14:03:16.467532', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (73, 'Consolidar la cartera de productos de seguros personales innovadores y accesibles para las familias bolivianas.', '2024-09-19 17:59:05.118+00', '', 15, 11, 0, 2, '2024-09-19 14:03:34.532465', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (74, 'Fortalecer la gestión integral de riesgos y el control interno de UNIVIDA S.A. consolidando un buen gobierno corporativo.', '2024-09-19 17:59:05.118+00', '', 16, 11, 0, 3, NULL, NULL, '2024-09-19 14:04:15.661624', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (75, 'Obtener ventaja competitiva en base a la estructuración de alianzas estratégicas públicas y privadas.', '2024-09-19 17:59:05.118+00', '', 17, 11, 0, 4, '2024-09-19 14:04:26.530936', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (76, 'Afianzar el equipo de trabajo generando sinergia, empatía, motivación y sentido de pertenencia.', '2024-09-19 17:59:05.118+00', '', 18, 11, 0, 5, '2024-09-19 14:04:37.712849', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (77, 'Garantizar la protección de los derechos de vida y salud de los asegurados, beneficiarios y usuarios con efectivas contraprestaciones y promoviendo la prevención de riesgos personales.', '2024-09-19 17:59:05.118+00', '', 19, 11, 0, 6, '2024-09-19 14:04:57.582461', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (82, '', '2024-09-19 18:29:38.889+00', '', NULL, 12, 0, 1, '2024-09-19 14:31:43.708501', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (83, '', '2024-09-19 18:29:38.889+00', '', NULL, 12, 0, 2, '2024-09-19 14:31:47.385299', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (84, '', '2024-09-19 18:29:38.889+00', '', 20, 12, 0, 3, '2024-09-19 14:31:54.372452', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (89, '', '2024-09-19 18:44:46.384+00', '', 21, 13, 0, 4, '2024-09-19 14:44:55.597777', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (88, '', '2024-09-19 18:42:49.789+00', '', NULL, 13, 0, 3, NULL, NULL, '2024-09-19 14:45:00.348161', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (90, '', '2024-09-19 19:18:08.4+00', 'https://bancounion.com.bo/', 22, 14, 0, 0, NULL, NULL, '2024-09-19 15:23:46.982701', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (91, '', '2024-09-19 19:18:08.4+00', 'https://www.unibienes.com.bo/', 23, 14, 0, 1, NULL, NULL, '2024-09-19 15:23:58.618685', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (92, '', '2024-09-19 19:18:08.4+00', 'https://www.safiunion.com.bo/', 24, 14, 0, 2, NULL, NULL, '2024-09-19 15:24:19.514355', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (93, '', '2024-09-19 19:18:08.4+00', 'https://valoresunion.com.bo/', 25, 14, 0, 3, NULL, NULL, '2024-09-19 15:24:31.526646', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (94, '', '2024-09-19 19:49:41.042+00', '', 26, 15, 0, 0, '2024-09-19 15:49:54.866498', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (95, 'Código de Ética Empresarial', '2024-09-19 19:49:41.042+00', '', NULL, 15, 0, 1, '2024-09-19 15:50:42.746657', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (98, '', '2024-09-19 19:49:41.042+00', '', 27, 15, 1, 0, '2024-09-19 15:59:28.921812', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (96, 'Descargar', '2024-09-19 19:49:41.042+00', '', 28, 15, 0, 2, NULL, NULL, '2024-09-19 16:00:01.693681', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (99, 'Reglamento de Transparencia y Lucha Contra la Corrupción', '2024-09-19 19:49:41.042+00', '', NULL, 15, 1, 1, '2024-09-19 16:00:24.170418', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (100, 'Descargar', '2024-09-19 19:49:41.042+00', '', 29, 15, 1, 2, '2024-09-19 16:00:37.06695', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (101, 'Memoria Anual 2023', '2024-09-19 20:11:38.795+00', '', NULL, 16, 0, 0, '2024-09-19 16:26:27.326783', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (103, '', '2024-09-19 20:26:59.874+00', '', 51, 16, 0, 2, '2024-09-19 16:27:22.997946', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (105, 'Memoria Anual 2022', '2024-09-19 20:26:59.874+00', '', NULL, 16, 1, 0, '2024-09-20 09:59:41.110036', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (106, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 1, 1, '2024-09-20 09:59:50.762462', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (107, '', '2024-09-19 20:26:59.874+00', '', 53, 16, 1, 2, '2024-09-20 10:00:03.566532', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (111, 'Memoria Anual 2021', '2024-09-19 20:26:59.874+00', '', NULL, 16, 2, 0, '2024-09-20 10:02:07.624245', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (112, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 2, 1, '2024-09-20 10:02:14.886946', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (113, '', '2024-09-19 20:26:59.874+00', '', 55, 16, 2, 2, '2024-09-20 10:02:23.638089', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (115, 'Memoria Anual 2020', '2024-09-19 20:26:59.874+00', '', NULL, 16, 3, 0, '2024-09-20 10:03:52.840545', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (116, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 3, 1, '2024-09-20 10:04:11.212551', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (117, '', '2024-09-19 20:26:59.874+00', '', 57, 16, 3, 2, '2024-09-20 10:04:19.130889', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (118, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 58, 16, 3, 3, '2024-09-20 10:05:43.539383', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (119, 'Memoria Anual 2019', '2024-09-19 20:26:59.874+00', '', NULL, 16, 4, 0, '2024-09-20 10:06:03.647049', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (120, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 4, 1, '2024-09-20 10:06:11.860218', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (121, '', '2024-09-19 20:26:59.874+00', '', 59, 16, 4, 2, '2024-09-20 10:06:27.728666', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (123, 'Memoria Anual 2018', '2024-09-19 20:26:59.874+00', '', NULL, 16, 5, 0, '2024-09-20 10:07:19.210965', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (124, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 5, 1, '2024-09-20 10:07:31.564321', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (125, '', '2024-09-19 20:26:59.874+00', '', 61, 16, 5, 2, '2024-09-20 10:08:03.526717', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (128, 'bi bi-journal-bookmark', '2024-09-19 20:26:59.874+00', '', NULL, 16, 6, 1, '2024-09-20 10:08:35.845098', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (127, 'Memoria Anual 2017', '2024-09-19 20:26:59.874+00', '', NULL, 16, 6, 0, NULL, NULL, '2024-09-20 10:08:47.462197', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (129, '', '2024-09-19 20:26:59.874+00', '', 63, 16, 6, 2, '2024-09-20 10:09:04.758651', NULL, NULL, NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (122, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 60, 16, 4, 3, NULL, NULL, '2024-09-20 10:09:42.078442', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (108, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 54, 16, 1, 3, NULL, NULL, '2024-09-20 10:09:53.622524', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (104, 'Descargar memoria', '2024-09-19 20:26:59.874+00', '', 52, 16, 0, 3, NULL, NULL, '2024-09-20 10:09:58.382405', NULL);
INSERT INTO "PaginaDinamica"."Datos" VALUES (135, 'https://transaccion-electronica.univida.bo:81/', '2024-09-20 15:38:10.612+00', '', NULL, 18, 0, 0, '2024-09-20 11:39:00.801531', NULL, NULL, NULL);


--
-- TOC entry 3477 (class 0 OID 17176)
-- Dependencies: 232
-- Data for Name: Planes; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."Planes" VALUES (1, 1, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 45, '- Muerte por cualquier causa **Bs.15.000**
- Invalidez total y permanente **Bs.7.500**
- Gastos de sepelio **Bs.1.500**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (2, 1, 'Plan B', ' PRECIO ANUAL (POR PERSONA)', 90, '- Muerte por cualquier causa **Bs.30.000**
- Invalidez total y permanente **Bs.15.000**
- Gastos de sepelio **Bs.3.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (3, 2, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 45, '- Muerte por cualquier causa **Bs.15.000**
- Invalidez total y permanente **Bs.7.500**
- Gastos de sepelio **Bs.1.500**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (4, 2, 'Plan B', 'PRECIO ANUAL (POR PERSONA)', 90, '- Muerte por cualquier causa **Bs.30.000**
- Invalidez total y permanente **Bs.15.000**
- Gastos de sepelio **Bs.3.000**
', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (5, 2, 'Plan C', 'PRECIO ANUAL (POR PERSONA)', 220, '- Muerte por cualquier causa **Bs.70.000**
- Invalidez total y permanente **Bs.35.000**
- Gastos de sepelio **Bs.6.000**

', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (6, 2, 'Plan D', 'PRECIO ANUAL (POR PERSONA)', 365, '- Muerte por cualquier causa **Bs.120.000**
- Invalidez total y permanente **Bs.70.000**
- Gastos de sepelio **Bs.10.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (7, 3, 'Plan', 'PRECIO ANUAL (POR PERSONA)', 45, '- Muerte por cualquier causa **Bs.10.000**
- Invalidez total y permanente **Bs.2.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (13, 4, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 160, '- Muerte por cualquier causa excepto COVID-19 **Bs.5.000**
- Muerte por COVID-19 **Bs.7.000**
- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.560 (por día)**
- Gastos de sepelio **Bs.1.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (14, 4, 'Plan B', 'PRECIO ANUAL (POR PERSONA)', 225, '- Muerte por cualquier causa excepto COVID-19 **Bs.7.000**
- Muerte por COVID-19 **Bs.10.000**
- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.700 (por día)**
- Gastos de sepelio **Bs.1.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (15, 4, 'Plan C', 'PRECIO ANUAL (POR PERSONA)', 350, '- Muerte por cualquier causa excepto COVID-19 **Bs.10.000**
- Muerte por COVID-19 **Bs.14.000**
- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.1.050 (por día)**
- Gastos de sepelio **Bs.2.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (16, 4, 'Plan D', 'PRECIO ANUAL (POR PERSONA)', 599, '- Muerte por cualquier causa excepto COVID-19 **Bs.20.000**
- Muerte por COVID-19 **Bs.22.000**
- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días **Bs.2.000 (por día)**
- Gastos de sepelio **Bs.2.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (17, 5, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 20, '- Muerte accidental* **Bs.10.000**
- Gastos médicos **Bs.3.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (18, 5, 'Plan B', 'PRECIO ANUAL (POR PERSONA)', 5, '- Muerte accidental* **Bs.10.000**
- Gastos médicos **Bs.3.000**', NULL, NULL, NULL, NULL, 0, false);
INSERT INTO "Seguro"."Planes" VALUES (19, 6, 'Plan A', 'PRECIO ANUAL (POR PERSONA)', 35, '- Muerte accidental Bs.10.000
- Invalidez total y permanente Bs.2.500
- Gastos médicos Bs.2.000', NULL, NULL, NULL, NULL, 0, false);


--
-- TOC entry 3479 (class 0 OID 17184)
-- Dependencies: 234
-- Data for Name: SeguroDetalles; Type: TABLE DATA; Schema: Seguro; Owner: postgres
--

INSERT INTO "Seguro"."SeguroDetalles" VALUES (9, 2, '**Exclusiones** del 
Seguro de Vida 
Individual', '- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (11, 3, '¿Qué cubre el
**Seguro de Vida
individual?**', '- En caso de muerte por cualquier causa, tus benefciarios reciben una indemnización.
- Indemnizamos a tus benefciarios con gastos de sepelio', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (13, 3, '¿Cómo 
**asegurarte?**', '- Presenta la fotocopia de tu Cédula de Identidad vigente.
- Llena los formularios que serán proporcionados por nuestra entidad.', NULL, NULL, NULL, NULL, 0);
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
INSERT INTO "Seguro"."SeguroDetalles" VALUES (14, 3, '**Exclusiones** del 
Seguro de Vida 
Individual', '- Enfermedades preexistentes conocidas.
- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (15, 4, '¿Qué cubre el
**Seguro de Vida
Individual?**', '- En caso de muerte por cualquier causa excepto COVID-19, tus benefciarios reciben una indemnización.
- En caso de muerte por COVID-19, tus benefciarios reciben una indemnización.
- Renta diaria por hospitalización incluyendo COVID-19 hasta 15 días.
- Indemnizamos a tus benefciarios con gastos de sepelio.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (5, 2, '¿Qué es el **Seguro de 
Vida Individual?**', 'Es un plan de protección creado para usted y su familia, consistente en otorgar un apoyo 
económico a la familia del asegurado ante el fallecimiento de este por cualquier causa, 
(salvo exclusiones específcas).
Por ejemplo con el Plan A de nuestro Seguro de Vida Individual, en caso de invalidez total 
y permanente el asegurado recibirá un monto de Bs.7.500. En caso de fallecimiento la 
empresa pagará Bs.15.000 a los benefciarios, además de Bs.1.500 para gastos de sepelio.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (6, 2, '¿Qué cubre el **Seguro 
de Vida Individual?**', '- En caso de muerte por cualquier causa, tus benefciarios reciben una indemnización.
- Te indemnizamos en caso de invalidez total y permanente.
- Indemnizamos a tus benefciarios con gastos de sepelio', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (8, 2, '¿Como **Asegurarte?**', '- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (16, 4, 'Benefcios 
**adicionales**', '**DESCUENTO POR RENOVACIÓN**
Si el cliente se encuentra realizando la renovación de algún seguro, 
puede comprar el producto con un descuento del 5%.

**DESCUENTO POR NÚMERO DE ASEGURADOS**
A partir del segundo asegurado, se aplicará el descuento del 4% 
en la prima.

**DESCUENTO POR PRODUCTO**
Si el cliente compra el producto adicionalmente puede obtener un 
descuento del 6% en la compra del siguiente (distinto al seguro de vida 
incluyendo COVID-19).', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (17, 4, '¿Cómo 
**asegurarte?**', '- Presenta la fotocopia de tu Cédula de Identidad vigente.
- Llena los formularios que serán proporcionados por nuestra entidad.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (18, 4, '**Exclusiones** del 
Seguro de Vida 
Individual', '- Enfermedades preexistentes y aislamiento para el caso de COVID-19.
- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Para la cobertura de renta diaria por Covid-19, el diagnostico debe ser realizado con la prueba PCR 
- Molecular positiva en centros autorizados por el Min. Salud/SEDES en la vigencia de la póliza.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (19, 5, '¿Qué cubre el **Seguro de 
Accidentes Personales?**', '- En caso de muerte accidental durante la actividad física propia de la disciplina declarada, tus benefciarios reciben una indemnización.
- Cubrimos los gastos médicos en caso de accidente.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (21, 5, '¿Cómo 
**asegurarte?**', '- Presenta la fotocopia de tu Cédula de Identidad vigente.
- Llena los formularios que serán proporcionados por nuestra entidad.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (22, 5, '**Exclusiones** del 
Seguro de Accidentes 
Personales', '- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (23, 6, '¿Qué cubre el **Seguro 
de Accidentes 
Personales?**', '- En caso de muerte accidental, tus benefciarios reciben una indemnización.
- Te indemnizamos en caso de invalidez total y permanente.
- Cubrimos los gastos médicos en caso de accidente.', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (24, 6, '¿Cómo 
**asegurarte?**', '- Presenta la fotocopia de tu Cédula de Identidad vigente.
- Llena los formularios que serán proporcionados por nuestra entidad. ', NULL, NULL, NULL, NULL, 0);
INSERT INTO "Seguro"."SeguroDetalles" VALUES (26, 6, '**Exclusiones** del 
Seguro de Accidentes 
Personales', '- Intervención directa o indirecta del Asegurado en actos delictuosos y/o penados por Ley.
- Accidentes ocurridos con anterioridad al inicio de la Cobertura Individual del Asegurado y sus posteriores repercusiones.
- Además de las exclusiones señaladas en las Condiciones Generales de la Póliza del Seguro.', NULL, NULL, NULL, NULL, 0);


--
-- TOC entry 3483 (class 0 OID 17202)
-- Dependencies: 238
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
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240725193807_actualización-menu-seguro-pagina', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240726135622_actualización-basedomainmodel', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240726135746_actualización-basedomainmodel2', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240726144310_actualización-basedomainmodel3', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240829200903_ImagenSeccion', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20240829204718_ImagenSeccionGuia', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241120221103_nuevaEntidad', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241120221303_esquema', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241121143231_cambioEsquema1', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241121161452_AdicionEntidades', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241121225833_detallemaestro', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241202030509_actualizacion', '7.0.20');
INSERT INTO public."__EFMigrationsHistory" VALUES ('20241202030654_actualizacion2024121', '7.0.20');


--
-- TOC entry 3497 (class 0 OID 0)
-- Dependencies: 215
-- Name: CatTipoRecurso_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoRecurso_Id_seq"', 3, true);


--
-- TOC entry 3498 (class 0 OID 0)
-- Dependencies: 217
-- Name: CatTipoSeccion_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeccion_Id_seq"', 10, true);


--
-- TOC entry 3499 (class 0 OID 0)
-- Dependencies: 219
-- Name: CatTipoSeguro_Id_seq; Type: SEQUENCE SET; Schema: Catalogo; Owner: postgres
--

SELECT pg_catalog.setval('"Catalogo"."CatTipoSeguro_Id_seq"', 3, true);


--
-- TOC entry 3500 (class 0 OID 0)
-- Dependencies: 221
-- Name: MenuPrincipal_Id_seq; Type: SEQUENCE SET; Schema: Menu; Owner: postgres
--

SELECT pg_catalog.setval('"Menu"."MenuPrincipal_Id_seq"', 35, true);


--
-- TOC entry 3501 (class 0 OID 0)
-- Dependencies: 245
-- Name: BannerPaginaPrincipalDetalle_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."BannerPaginaPrincipalDetalle_Id_seq"', 1, false);


--
-- TOC entry 3502 (class 0 OID 0)
-- Dependencies: 243
-- Name: BannerPaginaPrincipalMaestro_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."BannerPaginaPrincipalMaestro_Id_seq"', 1, false);


--
-- TOC entry 3503 (class 0 OID 0)
-- Dependencies: 229
-- Name: BannerPagina_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."BannerPagina_Id_seq"', 15, true);


--
-- TOC entry 3504 (class 0 OID 0)
-- Dependencies: 223
-- Name: Datos_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Datos_Id_seq"', 141, true);


--
-- TOC entry 3505 (class 0 OID 0)
-- Dependencies: 225
-- Name: PaginasDinamicas_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."PaginasDinamicas_Id_seq"', 18, true);


--
-- TOC entry 3506 (class 0 OID 0)
-- Dependencies: 227
-- Name: Secciones_Id_seq; Type: SEQUENCE SET; Schema: PaginaDinamica; Owner: postgres
--

SELECT pg_catalog.setval('"PaginaDinamica"."Secciones_Id_seq"', 29, true);


--
-- TOC entry 3507 (class 0 OID 0)
-- Dependencies: 231
-- Name: Recursos_Id_seq; Type: SEQUENCE SET; Schema: Recurso; Owner: postgres
--

SELECT pg_catalog.setval('"Recurso"."Recursos_Id_seq"', 130, true);


--
-- TOC entry 3508 (class 0 OID 0)
-- Dependencies: 233
-- Name: Planes_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Planes_Id_seq"', 19, true);


--
-- TOC entry 3509 (class 0 OID 0)
-- Dependencies: 235
-- Name: SeguroDetalles_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."SeguroDetalles_Id_seq"', 26, true);


--
-- TOC entry 3510 (class 0 OID 0)
-- Dependencies: 237
-- Name: Seguros_Id_seq; Type: SEQUENCE SET; Schema: Seguro; Owner: postgres
--

SELECT pg_catalog.setval('"Seguro"."Seguros_Id_seq"', 6, true);


--
-- TOC entry 3511 (class 0 OID 0)
-- Dependencies: 239
-- Name: CatEstiloBanner_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."CatEstiloBanner_Id_seq"', 1, false);


--
-- TOC entry 3512 (class 0 OID 0)
-- Dependencies: 241
-- Name: CatTipoBannerPaginaPrincipal_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."CatTipoBannerPaginaPrincipal_Id_seq"', 1, false);


-- Completed on 2024-12-22 23:45:13

--
-- PostgreSQL database dump complete
--

