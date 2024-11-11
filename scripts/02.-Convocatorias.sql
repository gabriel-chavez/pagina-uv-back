--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 16.2

-- Started on 2024-11-11 07:16:16

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
-- TOC entry 3506 (class 0 OID 18060)
-- Dependencies: 232
-- Data for Name: Convocatoria; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

COPY "Convocatorias"."Convocatoria" ("Id", "Codigo", "Nombre", "ParEstadoConvocatoriaId", "FechaInicio", "FechaFin", "PuntajeMinimo", "PuntajeTotal", "Descripcion", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor") FROM stdin;
1	LP-001	Convocatoria Analista de desarrollo de sistemas NACIONAL	1	2024-11-04	-infinity	10	100	asdkjasdk ajsdkjas dakjsd oaskjdoaisdjaosidjaosi djasod asoi daos djaosi djaosid oad osi osdjoai asdasdasd	\N	2024-11-04 15:59:55.248606	\N	\N
\.


--
-- TOC entry 3522 (class 0 OID 18219)
-- Dependencies: 248
-- Data for Name: Notificacion; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

COPY "Convocatorias"."Notificacion" ("Id", "PostulacionId", "Mensaje", "FechaEnvio", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor") FROM stdin;
\.


--
-- TOC entry 3520 (class 0 OID 18196)
-- Dependencies: 246
-- Data for Name: Postulacion; Type: TABLE DATA; Schema: Convocatorias; Owner: postgres
--

COPY "Convocatorias"."Postulacion" ("Id", "ConvocatoriaId", "PostulanteId", "FechaPostulacion", "PuntajeObtenido", "ParEstadoPostulacionId", "PostulanteDatosJSON", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor", "CantidadDiasDisponibilidad", "DisponibilidadInmediata", "NombreParentescoFuncionario", "PretensionSalarial", "TieneParentescoConFuncionario") FROM stdin;
1	1	1	2024-11-04	10	1	JSON OBTENIDO AUTOMATICAMENTE	\N	2024-11-04 16:00:40.976175	\N	\N	0	f	\N	0.0	f
2	1	1	2024-11-04	10	1	{"nombres":"Luis Gabriel","apellidoPaterno":"Chavez","apellidoMaterno":"Ramos","email":"gabriel.chavez.r@gmail.com","numeroDocumento":"6732326","documentoExpedido":"","fechaNacimiento":"1986-04-20","ciudadNacimiento":"La Paz","paisNacimiento":"Bolivia","ciudadResidencia":"La Paz","paisResidencia":"Bolivia","direccion":"Final Rosendo Gutierrez Nro 2222","zona":"Sopocachi","telefono":"2426149","telefonoMovil":"73011590","formacionesAcademicas":[{"postulanteId":1,"parNivelFormacionId":1,"centroEstudios":"Salesiana","tituloObtenido":"Lic ING sistemas","fechaTitulo":"2024-11-04","ciudad":"La Paz","pais":"Bolivia","id":2,"fechaCreacion":"2024-11-04T15:56:22.711063"}],"capacitaciones":[{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de software","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":1,"fechaCreacion":"2024-11-04T15:52:57.345222"},{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de microservicios","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":2,"fechaCreacion":"2024-11-04T15:53:12.468281"}],"conocimientosIdiomas":[{"postulanteId":1,"parIdiomaId":1,"parNivelConocimientoLecturaId":1,"parNivelConocimientoEscrituraId":1,"parNivelConocimientoConversacionId":1,"id":1,"fechaCreacion":"2024-11-04T15:53:37.890056"}],"conocimientosSistemas":[{"postulanteId":1,"parProgramaId":1,"parNivelConocimientoId":3,"id":1,"fechaCreacion":"2024-11-04T15:54:03.618445"},{"postulanteId":1,"parProgramaId":2,"parNivelConocimientoId":3,"id":2,"fechaCreacion":"2024-11-04T15:54:11.437164"},{"postulanteId":1,"parProgramaId":3,"parNivelConocimientoId":3,"id":3,"fechaCreacion":"2024-11-04T15:54:33.488709"}],"referenciasLaborales":[{"postulanteId":1,"nombre":"Jose luis","cargo":"Jose de sistemas","empresa":"Univida S.A.","telefono":"28008008","telefonoMovil":"7011421","relacion":"Inmediato Superior","email":"jose@univida,bo","id":1,"fechaCreacion":"2024-11-04T15:57:29.384607"}],"referenciasPersonales":[{"postulanteId":1,"nombre":"Juan Luis Rios","cargo":"Jefe empresa","empresa":"724","telefono":"2414141","telefonoMovil":"73014458","parParentescoId":10,"email":"lj@asdas.com","id":1,"fechaCreacion":"2024-11-04T15:58:24.814913"}],"id":1,"fechaCreacion":"2024-11-04T15:50:58.824538"}	\N	\N	\N	\N	0	f	\N	0.0	f
3	1	1	2024-11-04	10	1	{"nombres":"Luis Gabriel","apellidoPaterno":"Chavez","apellidoMaterno":"Ramos","email":"gabriel.chavez.r@gmail.com","numeroDocumento":"6732326","documentoExpedido":"","fechaNacimiento":"1986-04-20","ciudadNacimiento":"La Paz","paisNacimiento":"Bolivia","ciudadResidencia":"La Paz","paisResidencia":"Bolivia","direccion":"Final Rosendo Gutierrez Nro 2222","zona":"Sopocachi","telefono":"2426149","telefonoMovil":"73011590","formacionesAcademicas":[{"postulanteId":1,"parNivelFormacionId":1,"centroEstudios":"Salesiana","tituloObtenido":"Lic ING sistemas","fechaTitulo":"2024-11-04","ciudad":"La Paz","pais":"Bolivia","id":2,"fechaCreacion":"2024-11-04T15:56:22.711063"}],"capacitaciones":[{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de software","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":1,"fechaCreacion":"2024-11-04T15:52:57.345222"},{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de microservicios","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":2,"fechaCreacion":"2024-11-04T15:53:12.468281"}],"conocimientosIdiomas":[{"postulanteId":1,"parIdiomaId":1,"parNivelConocimientoLecturaId":1,"parNivelConocimientoEscrituraId":1,"parNivelConocimientoConversacionId":1,"id":1,"fechaCreacion":"2024-11-04T15:53:37.890056"}],"conocimientosSistemas":[{"postulanteId":1,"parProgramaId":1,"parNivelConocimientoId":3,"id":1,"fechaCreacion":"2024-11-04T15:54:03.618445"},{"postulanteId":1,"parProgramaId":2,"parNivelConocimientoId":3,"id":2,"fechaCreacion":"2024-11-04T15:54:11.437164"},{"postulanteId":1,"parProgramaId":3,"parNivelConocimientoId":3,"id":3,"fechaCreacion":"2024-11-04T15:54:33.488709"}],"referenciasLaborales":[{"postulanteId":1,"nombre":"Jose luis","cargo":"Jose de sistemas","empresa":"Univida S.A.","telefono":"28008008","telefonoMovil":"7011421","relacion":"Inmediato Superior","email":"jose@univida,bo","id":1,"fechaCreacion":"2024-11-04T15:57:29.384607"}],"referenciasPersonales":[{"postulanteId":1,"nombre":"Juan Luis Rios","cargo":"Jefe empresa","empresa":"724","telefono":"2414141","telefonoMovil":"73014458","parParentescoId":10,"email":"lj@asdas.com","id":1,"fechaCreacion":"2024-11-04T15:58:24.814913"}],"id":1,"fechaCreacion":"2024-11-04T15:50:58.824538"}	\N	\N	\N	\N	0	f	\N	0.0	f
4	1	1	2024-11-04	10	1	{"nombres":"Luis Gabriel","apellidoPaterno":"Chavez","apellidoMaterno":"Ramos","email":"gabriel.chavez.r@gmail.com","numeroDocumento":"6732326","documentoExpedido":"","fechaNacimiento":"1986-04-20","ciudadNacimiento":"La Paz","paisNacimiento":"Bolivia","ciudadResidencia":"La Paz","paisResidencia":"Bolivia","direccion":"Final Rosendo Gutierrez Nro 2222","zona":"Sopocachi","telefono":"2426149","telefonoMovil":"73011590","formacionesAcademicas":[{"postulanteId":1,"parNivelFormacionId":1,"centroEstudios":"Salesiana","tituloObtenido":"Lic ING sistemas","fechaTitulo":"2024-11-04","ciudad":"La Paz","pais":"Bolivia","id":2,"fechaCreacion":"2024-11-04T15:56:22.711063"}],"capacitaciones":[{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de software","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":1,"fechaCreacion":"2024-11-04T15:52:57.345222"},{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de microservicios","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":2,"fechaCreacion":"2024-11-04T15:53:12.468281"}],"conocimientosIdiomas":[{"postulanteId":1,"parIdiomaId":1,"parNivelConocimientoLecturaId":1,"parNivelConocimientoEscrituraId":1,"parNivelConocimientoConversacionId":1,"id":1,"fechaCreacion":"2024-11-04T15:53:37.890056"}],"conocimientosSistemas":[{"postulanteId":1,"parProgramaId":1,"parNivelConocimientoId":3,"id":1,"fechaCreacion":"2024-11-04T15:54:03.618445"},{"postulanteId":1,"parProgramaId":2,"parNivelConocimientoId":3,"id":2,"fechaCreacion":"2024-11-04T15:54:11.437164"},{"postulanteId":1,"parProgramaId":3,"parNivelConocimientoId":3,"id":3,"fechaCreacion":"2024-11-04T15:54:33.488709"}],"referenciasLaborales":[{"postulanteId":1,"nombre":"Jose luis","cargo":"Jose de sistemas","empresa":"Univida S.A.","telefono":"28008008","telefonoMovil":"7011421","relacion":"Inmediato Superior","email":"jose@univida,bo","id":1,"fechaCreacion":"2024-11-04T15:57:29.384607"}],"referenciasPersonales":[{"postulanteId":1,"nombre":"Juan Luis Rios","cargo":"Jefe empresa","empresa":"724","telefono":"2414141","telefonoMovil":"73014458","parParentescoId":10,"email":"lj@asdas.com","id":1,"fechaCreacion":"2024-11-04T15:58:24.814913"}],"id":1,"fechaCreacion":"2024-11-04T15:50:58.824538"}	\N	\N	\N	\N	0	f	\N	0.0	f
5	1	1	2024-11-04	10	1	{"nombres":"Luis Gabriel","apellidoPaterno":"Chavez","apellidoMaterno":"Ramos","email":"gabriel.chavez.r@gmail.com","numeroDocumento":"6732326","documentoExpedido":"","fechaNacimiento":"1986-04-20","ciudadNacimiento":"La Paz","paisNacimiento":"Bolivia","ciudadResidencia":"La Paz","paisResidencia":"Bolivia","direccion":"Final Rosendo Gutierrez Nro 2222","zona":"Sopocachi","telefono":"2426149","telefonoMovil":"73011590","formacionesAcademicas":[{"postulanteId":1,"parNivelFormacionId":1,"centroEstudios":"Salesiana","tituloObtenido":"Lic ING sistemas","fechaTitulo":"2024-11-04","ciudad":"La Paz","pais":"Bolivia","id":2,"fechaCreacion":"2024-11-04T15:56:22.711063"}],"capacitaciones":[{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de software","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":1,"fechaCreacion":"2024-11-04T15:52:57.345222"},{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de microservicios","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":2,"fechaCreacion":"2024-11-04T15:53:12.468281"}],"conocimientosIdiomas":[{"postulanteId":1,"parIdiomaId":1,"parNivelConocimientoLecturaId":1,"parNivelConocimientoEscrituraId":1,"parNivelConocimientoConversacionId":1,"id":1,"fechaCreacion":"2024-11-04T15:53:37.890056"}],"conocimientosSistemas":[{"postulanteId":1,"parProgramaId":1,"parNivelConocimientoId":3,"id":1,"fechaCreacion":"2024-11-04T15:54:03.618445"},{"postulanteId":1,"parProgramaId":2,"parNivelConocimientoId":3,"id":2,"fechaCreacion":"2024-11-04T15:54:11.437164"},{"postulanteId":1,"parProgramaId":3,"parNivelConocimientoId":3,"id":3,"fechaCreacion":"2024-11-04T15:54:33.488709"}],"referenciasLaborales":[{"postulanteId":1,"nombre":"Jose luis","cargo":"Jose de sistemas","empresa":"Univida S.A.","telefono":"28008008","telefonoMovil":"7011421","relacion":"Inmediato Superior","email":"jose@univida,bo","id":1,"fechaCreacion":"2024-11-04T15:57:29.384607"}],"referenciasPersonales":[{"postulanteId":1,"nombre":"Juan Luis Rios","cargo":"Jefe empresa","empresa":"724","telefono":"2414141","telefonoMovil":"73014458","parParentescoId":10,"email":"lj@asdas.com","id":1,"fechaCreacion":"2024-11-04T15:58:24.814913"}],"id":1,"fechaCreacion":"2024-11-04T15:50:58.824538"}	\N	\N	\N	\N	0	f	\N	0.0	f
6	1	1	2024-11-07	0	1	{"nombres":"Luis Gabriel","apellidoPaterno":"Chavez","apellidoMaterno":"Ramos","email":"gabriel.chavez.r@gmail.com","numeroDocumento":"6732326","documentoExpedido":"","fechaNacimiento":"1986-04-20","ciudadNacimiento":"La Paz","paisNacimiento":"Bolivia","ciudadResidencia":"La Paz","paisResidencia":"Bolivia","direccion":"Final Rosendo Gutierrez Nro 2222","zona":"Sopocachi","telefono":"2426149","telefonoMovil":"73011590","formacionesAcademicas":[{"postulanteId":1,"parNivelFormacionId":1,"centroEstudios":"Salesiana","tituloObtenido":"Lic ING sistemas","fechaTitulo":"2024-11-04","ciudad":"La Paz","pais":"Bolivia","id":2,"fechaCreacion":"2024-11-04T15:56:22.711063"}],"capacitaciones":[{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de software","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":1,"fechaCreacion":"2024-11-04T15:52:57.345222"},{"postulanteId":1,"parTipoCapacitacionId":1,"nombre":"Desarrollo de microservicios","centroEstudios":"COGNOS","pais":"Bolivia","horasAcademicas":10,"modalidad":"Virtual","fechaInicio":"2024-01-04","fechaFin":"2024-11-04","id":2,"fechaCreacion":"2024-11-04T15:53:12.468281"}],"conocimientosIdiomas":[{"postulanteId":1,"parIdiomaId":1,"parNivelConocimientoLecturaId":1,"parNivelConocimientoEscrituraId":1,"parNivelConocimientoConversacionId":1,"id":1,"fechaCreacion":"2024-11-04T15:53:37.890056"}],"conocimientosSistemas":[{"postulanteId":1,"parProgramaId":1,"parNivelConocimientoId":3,"id":1,"fechaCreacion":"2024-11-04T15:54:03.618445"},{"postulanteId":1,"parProgramaId":2,"parNivelConocimientoId":3,"id":2,"fechaCreacion":"2024-11-04T15:54:11.437164"},{"postulanteId":1,"parProgramaId":3,"parNivelConocimientoId":3,"id":3,"fechaCreacion":"2024-11-04T15:54:33.488709"}],"referenciasLaborales":[{"postulanteId":1,"nombre":"Jose luis","cargo":"Jose de sistemas","empresa":"Univida S.A.","telefono":"28008008","telefonoMovil":"7011421","relacion":"Inmediato Superior","email":"jose@univida,bo","id":1,"fechaCreacion":"2024-11-04T15:57:29.384607"}],"referenciasPersonales":[{"postulanteId":1,"nombre":"Juan Luis Rios","cargo":"Jefe empresa","empresa":"724","telefono":"2414141","telefonoMovil":"73014458","parParentescoId":10,"email":"lj@asdas.com","id":1,"fechaCreacion":"2024-11-04T15:58:24.814913"}],"experienciaLaboral":[{"postulanteId":1,"empresa":"Univida","cargo":"Analista de desarrollo de software","sector":"Privado","nroDependientes":0,"nombreSuperior":"Jose luis quispe","cargoSuperior":"Jefe de desarrollo","telefonoEmpresa":"24120011","funciones":"asd aksdj aosdjoasidjoasikjosadkjasodkjasodkjasdokasj doask jdoskjdoksjdd","fechaInicio":"2021-10-07","fechaConclusion":"2024-11-07","motivoDesvinculacion":"Aun trabajando","actualmenteTrabajando":true,"experienciaGeneral":true,"experienciaEspecifica":true,"id":1,"fechaCreacion":"2024-11-07T06:47:48.58517"},{"postulanteId":1,"empresa":"Univida","cargo":"Responsable de desarrollo de software","sector":"Privado","nroDependientes":0,"nombreSuperior":"Jose luis quispe","cargoSuperior":"Jefe de desarrollo","telefonoEmpresa":"24120011","funciones":"asd aksdj aosdjoasidjoasikjosadkjasodkjasodkjasdokasj doask jdoskjdoksjdd","fechaInicio":"2021-10-07","fechaConclusion":"2024-11-07","motivoDesvinculacion":"Aun trabajando","actualmenteTrabajando":true,"experienciaGeneral":true,"experienciaEspecifica":true,"id":2,"fechaCreacion":"2024-11-07T06:48:17.000359"}],"id":1,"fechaCreacion":"2024-11-04T15:50:58.824538"}	\N	\N	\N	\N	0	t		5000	f
\.


--
-- TOC entry 3488 (class 0 OID 17988)
-- Dependencies: 214
-- Data for Name: ParEstadoConvocatoria; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParEstadoConvocatoria" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Abierta	t	\N	\N	\N	\N
2	Cerrada	t	\N	\N	\N	\N
3	En Revisión	t	\N	\N	\N	\N
4	Cancelada	t	\N	\N	\N	\N
5	Suspendida	t	\N	\N	\N	\N
6	Finalizada	t	\N	\N	\N	\N
7	En Espera	t	\N	\N	\N	\N
\.


--
-- TOC entry 3490 (class 0 OID 17996)
-- Dependencies: 216
-- Data for Name: ParEstadoPostulacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParEstadoPostulacion" ("Id", "Descripcion", "Notificar", "ContenidoNotificacion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Pendiente	f		t	\N	\N	\N	\N
2	Preseleccionado	t	Ha sido preseleccionado para la siguiente fase.	t	\N	\N	\N	\N
3	Evaluacion Tecnica	t	Debe presentar la evaluación técnica.	t	\N	\N	\N	\N
4	Entrevista	t	Se ha programado una entrevista.	t	\N	\N	\N	\N
5	Contratado	t	¡Felicitaciones! Ha sido contratado.	t	\N	\N	\N	\N
\.


--
-- TOC entry 3492 (class 0 OID 18004)
-- Dependencies: 218
-- Data for Name: ParIdioma; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParIdioma" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	ALEMAN	t	\N	\N	\N	\N
2	AYMARA	t	\N	\N	\N	\N
3	FRANCES	t	\N	\N	\N	\N
4	GUARANI	t	\N	\N	\N	\N
5	INGLES	t	\N	\N	\N	\N
6	JAPONES	t	\N	\N	\N	\N
7	PORTUGUES	t	\N	\N	\N	\N
8	QUECHUA	t	\N	\N	\N	\N
\.


--
-- TOC entry 3494 (class 0 OID 18012)
-- Dependencies: 220
-- Data for Name: ParNivelConocimiento; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParNivelConocimiento" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Básico	t	\N	\N	\N	\N
2	Intermedio	t	\N	\N	\N	\N
3	Avanzado	t	\N	\N	\N	\N
\.


--
-- TOC entry 3496 (class 0 OID 18020)
-- Dependencies: 222
-- Data for Name: ParNivelFormacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParNivelFormacion" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Bachiller	t	\N	\N	\N	\N
2	Estudiante Universitario	t	\N	\N	\N	\N
3	Tecnico Medio	t	\N	\N	\N	\N
4	Tecnico Superior	t	\N	\N	\N	\N
5	Egresado	t	\N	\N	\N	\N
6	Licenciatura	t	\N	\N	\N	\N
7	Diplomado	t	\N	\N	\N	\N
8	Maestria	t	\N	\N	\N	\N
9	Doctorado	t	\N	\N	\N	\N
10	Post Doctorado	t	\N	\N	\N	\N
\.


--
-- TOC entry 3498 (class 0 OID 18028)
-- Dependencies: 224
-- Data for Name: ParParentesco; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParParentesco" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	ABUELO	t	\N	\N	\N	\N
2	BISABUELOS	t	\N	\N	\N	\N
3	BIZNIETOS	t	\N	\N	\N	\N
4	CUÑADO	t	\N	\N	\N	\N
5	CONYUGUE	t	\N	\N	\N	\N
6	HERMANOS	t	\N	\N	\N	\N
7	HIJOS	t	\N	\N	\N	\N
8	NIETOS	t	\N	\N	\N	\N
9	YERNO-NUERA	t	\N	\N	\N	\N
10	PADRES	t	\N	\N	\N	\N
11	PRIMOS	t	\N	\N	\N	\N
12	SOBRINOS	t	\N	\N	\N	\N
13	SUEGROS	t	\N	\N	\N	\N
14	TIOS	t	\N	\N	\N	\N
15	AMISTAD	t	\N	\N	\N	\N
16	OTRO	t	\N	\N	\N	\N
\.


--
-- TOC entry 3500 (class 0 OID 18036)
-- Dependencies: 226
-- Data for Name: ParPrograma; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParPrograma" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	MICROSOFT OFFICE EXCEL	t	\N	\N	\N	\N
2	MICROSOFT OFFICE OUTLOOK	t	\N	\N	\N	\N
3	MICROSOFT OFFICE POWER POINT	t	\N	\N	\N	\N
4	MICROSOFT OFFICE WORD	t	\N	\N	\N	\N
5	OTRO	t	\N	\N	\N	\N
\.


--
-- TOC entry 3502 (class 0 OID 18044)
-- Dependencies: 228
-- Data for Name: ParTipoCapacitacion; Type: TABLE DATA; Schema: Parametricas; Owner: postgres
--

COPY "Parametricas"."ParTipoCapacitacion" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Conferencia	t	\N	\N	\N	\N
2	Curso	t	\N	\N	\N	\N
3	Seminario	t	\N	\N	\N	\N
4	Taller	t	\N	\N	\N	\N
\.


--
-- TOC entry 3508 (class 0 OID 18073)
-- Dependencies: 234
-- Data for Name: Capacitacion; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."Capacitacion" ("Id", "PostulanteId", "ParTipoCapacitacionId", "Nombre", "CentroEstudios", "Pais", "HorasAcademicas", "Modalidad", "FechaInicio", "FechaFin", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	1	Desarrollo de software	COGNOS	Bolivia	10	Virtual	2024-01-04	2024-11-04	2024-11-04 15:52:57.345222	\N	\N	\N
2	1	1	Desarrollo de microservicios	COGNOS	Bolivia	10	Virtual	2024-01-04	2024-11-04	2024-11-04 15:53:12.468281	\N	\N	\N
\.


--
-- TOC entry 3510 (class 0 OID 18091)
-- Dependencies: 236
-- Data for Name: ConocimientoIdioma; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."ConocimientoIdioma" ("Id", "PostulanteId", "ParIdiomaId", "ParNivelConocimientoLecturaId", "ParNivelConocimientoEscrituraId", "ParNivelConocimientoConversacionId", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	1	1	1	1	2024-11-04 15:53:37.890056	\N	\N	\N
\.


--
-- TOC entry 3512 (class 0 OID 18124)
-- Dependencies: 238
-- Data for Name: ConocimientoSistemas; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."ConocimientoSistemas" ("Id", "PostulanteId", "ParProgramaId", "ParNivelConocimientoId", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	1	3	2024-11-04 15:54:03.618445	\N	\N	\N
2	1	2	3	2024-11-04 15:54:11.437164	\N	\N	\N
3	1	3	3	2024-11-04 15:54:33.488709	\N	\N	\N
\.


--
-- TOC entry 3524 (class 0 OID 26176)
-- Dependencies: 250
-- Data for Name: ExperienciaLaboral; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."ExperienciaLaboral" ("Id", "PostulanteId", "Empresa", "Cargo", "Sector", "NroDependientes", "NombreSuperior", "CargoSuperior", "TelefonoEmpresa", "Funciones", "FechaInicio", "FechaConclusion", "MotivoDesvinculacion", "ActualmenteTrabajando", "ExperienciaGeneral", "ExperienciaEspecifica", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	Univida	Analista de desarrollo de software	Privado	0	Jose luis quispe	Jefe de desarrollo	24120011	asd aksdj aosdjoasidjoasikjosadkjasodkjasodkjasdokasj doask jdoskjdoksjdd	2021-10-07	2024-11-07	Aun trabajando	t	t	t	2024-11-07 06:47:48.58517	\N	\N	\N
2	1	Univida	Responsable de desarrollo de software	Privado	0	Jose luis quispe	Jefe de desarrollo	24120011	asd aksdj aosdjoasidjoasikjosadkjasodkjasodkjasdokasj doask jdoskjdoksjdd	2021-10-07	2024-11-07	Aun trabajando	t	t	t	2024-11-07 06:48:17.000359	\N	\N	\N
\.


--
-- TOC entry 3514 (class 0 OID 18147)
-- Dependencies: 240
-- Data for Name: FormacionAcademica; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."FormacionAcademica" ("Id", "PostulanteId", "ParNivelFormacionId", "CentroEstudios", "TituloObtenido", "FechaTitulo", "Ciudad", "Pais", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
2	1	1	Salesiana	Lic ING sistemas	2024-11-04	La Paz	Bolivia	2024-11-04 15:56:22.711063	\N	\N	\N
\.


--
-- TOC entry 3504 (class 0 OID 18052)
-- Dependencies: 230
-- Data for Name: Postulante; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."Postulante" ("Id", "Nombres", "ApellidoPaterno", "ApellidoMaterno", "Email", "NumeroDocumento", "DocumentoExpedido", "FechaNacimiento", "CiudadNacimiento", "PaisNacimiento", "CiudadResidencia", "PaisResidencia", "Direccion", "Zona", "Telefono", "TelefonoMovil", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	Luis Gabriel	Chavez	Ramos	gabriel.chavez.r@gmail.com	6732326		1986-04-20	La Paz	Bolivia	La Paz	Bolivia	Final Rosendo Gutierrez Nro 2222	Sopocachi	2426149	73011590	2024-11-04 15:50:58.824538	\N	\N	\N
\.


--
-- TOC entry 3516 (class 0 OID 18165)
-- Dependencies: 242
-- Data for Name: ReferenciaLaboral; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."ReferenciaLaboral" ("Id", "PostulanteId", "Nombre", "Cargo", "Empresa", "Telefono", "TelefonoMovil", "Relacion", "Email", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	Jose luis	Jose de sistemas	Univida S.A.	28008008	7011421	Inmediato Superior	jose@univida,bo	2024-11-04 15:57:29.384607	\N	\N	\N
\.


--
-- TOC entry 3518 (class 0 OID 18178)
-- Dependencies: 244
-- Data for Name: ReferenciaPersonal; Type: TABLE DATA; Schema: Postulantes; Owner: postgres
--

COPY "Postulantes"."ReferenciaPersonal" ("Id", "PostulanteId", "Nombre", "Cargo", "Empresa", "Telefono", "TelefonoMovil", "ParParentescoId", "Email", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
1	1	Juan Luis Rios	Jefe empresa	724	2414141	73014458	10	lj@asdas.com	2024-11-04 15:58:24.814913	\N	\N	\N
\.


--
-- TOC entry 3486 (class 0 OID 17980)
-- Dependencies: 212
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20241104155602_InicioMigracion	7.0.20
20241104160424_InicioMigracionCorreccion	7.0.20
20241104164217_InicioMigracionCorreccion2	7.0.20
20241104194150_InicioMigracionCorreccion3	7.0.20
20241104194822_InicioMigracionCorreccion4	7.0.20
20241107095508_actualizacionCampos	7.0.20
20241107103444_actualizacionCampos2	7.0.20
\.


--
-- TOC entry 3531 (class 0 OID 0)
-- Dependencies: 231
-- Name: Convocatoria_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Convocatoria_Id_seq"', 1, true);


--
-- TOC entry 3532 (class 0 OID 0)
-- Dependencies: 247
-- Name: Notificacion_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Notificacion_Id_seq"', 1, false);


--
-- TOC entry 3533 (class 0 OID 0)
-- Dependencies: 245
-- Name: Postulacion_Id_seq; Type: SEQUENCE SET; Schema: Convocatorias; Owner: postgres
--

SELECT pg_catalog.setval('"Convocatorias"."Postulacion_Id_seq"', 6, true);


--
-- TOC entry 3534 (class 0 OID 0)
-- Dependencies: 213
-- Name: ParEstadoConvocatoria_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstadoConvocatoria_Id_seq"', 7, true);


--
-- TOC entry 3535 (class 0 OID 0)
-- Dependencies: 215
-- Name: ParEstadoPostulacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParEstadoPostulacion_Id_seq"', 5, true);


--
-- TOC entry 3536 (class 0 OID 0)
-- Dependencies: 217
-- Name: ParIdioma_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParIdioma_Id_seq"', 8, true);


--
-- TOC entry 3537 (class 0 OID 0)
-- Dependencies: 219
-- Name: ParNivelConocimiento_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParNivelConocimiento_Id_seq"', 3, true);


--
-- TOC entry 3538 (class 0 OID 0)
-- Dependencies: 221
-- Name: ParNivelFormacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParNivelFormacion_Id_seq"', 10, true);


--
-- TOC entry 3539 (class 0 OID 0)
-- Dependencies: 223
-- Name: ParParentesco_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParParentesco_Id_seq"', 16, true);


--
-- TOC entry 3540 (class 0 OID 0)
-- Dependencies: 225
-- Name: ParPrograma_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParPrograma_Id_seq"', 5, true);


--
-- TOC entry 3541 (class 0 OID 0)
-- Dependencies: 227
-- Name: ParTipoCapacitacion_Id_seq; Type: SEQUENCE SET; Schema: Parametricas; Owner: postgres
--

SELECT pg_catalog.setval('"Parametricas"."ParTipoCapacitacion_Id_seq"', 4, true);


--
-- TOC entry 3542 (class 0 OID 0)
-- Dependencies: 233
-- Name: Capacitacion_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."Capacitacion_Id_seq"', 2, true);


--
-- TOC entry 3543 (class 0 OID 0)
-- Dependencies: 235
-- Name: ConocimientoIdioma_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ConocimientoIdioma_Id_seq"', 1, true);


--
-- TOC entry 3544 (class 0 OID 0)
-- Dependencies: 237
-- Name: ConocimientoSistemas_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ConocimientoSistemas_Id_seq"', 4, true);


--
-- TOC entry 3545 (class 0 OID 0)
-- Dependencies: 249
-- Name: ExperienciaLaboral_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ExperienciaLaboral_Id_seq"', 2, true);


--
-- TOC entry 3546 (class 0 OID 0)
-- Dependencies: 239
-- Name: FormacionAcademica_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."FormacionAcademica_Id_seq"', 2, true);


--
-- TOC entry 3547 (class 0 OID 0)
-- Dependencies: 229
-- Name: Postulante_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."Postulante_Id_seq"', 1, true);


--
-- TOC entry 3548 (class 0 OID 0)
-- Dependencies: 241
-- Name: ReferenciaLaboral_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ReferenciaLaboral_Id_seq"', 1, true);


--
-- TOC entry 3549 (class 0 OID 0)
-- Dependencies: 243
-- Name: ReferenciaPersonal_Id_seq; Type: SEQUENCE SET; Schema: Postulantes; Owner: postgres
--

SELECT pg_catalog.setval('"Postulantes"."ReferenciaPersonal_Id_seq"', 1, true);


-- Completed on 2024-11-11 07:16:16

--
-- PostgreSQL database dump complete
--

