PGDMP                  
    |             BD_UNIVidaPortalWebConvocatorias    14.1    16.2 +    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    17979     BD_UNIVidaPortalWebConvocatorias    DATABASE     �   CREATE DATABASE "BD_UNIVidaPortalWebConvocatorias" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';
 2   DROP DATABASE "BD_UNIVidaPortalWebConvocatorias";
                postgres    false            �          0    17988    ParEstadoConvocatoria 
   TABLE DATA           �   COPY "Parametricas"."ParEstadoConvocatoria" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    214   �1       �          0    18060    Convocatoria 
   TABLE DATA           �   COPY "Convocatorias"."Convocatoria" ("Id", "Codigo", "Nombre", "ParEstadoConvocatoriaId", "FechaInicio", "FechaFin", "PuntajeMinimo", "PuntajeTotal", "Descripcion", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor") FROM stdin;
    Convocatorias          postgres    false    232   h2       �          0    17996    ParEstadoPostulacion 
   TABLE DATA           �   COPY "Parametricas"."ParEstadoPostulacion" ("Id", "Descripcion", "Notificar", "ContenidoNotificacion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    216   '3       �          0    18052 
   Postulante 
   TABLE DATA           j  COPY "Postulantes"."Postulante" ("Id", "Nombres", "ApellidoPaterno", "ApellidoMaterno", "Email", "NumeroDocumento", "DocumentoExpedido", "FechaNacimiento", "CiudadNacimiento", "PaisNacimiento", "CiudadResidencia", "PaisResidencia", "Direccion", "Zona", "Telefono", "TelefonoMovil", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    230   �3       �          0    18196    Postulacion 
   TABLE DATA           �  COPY "Convocatorias"."Postulacion" ("Id", "ConvocatoriaId", "PostulanteId", "FechaPostulacion", "PuntajeObtenido", "ParEstadoPostulacionId", "PostulanteDatosJSON", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor", "CantidadDiasDisponibilidad", "DisponibilidadInmediata", "NombreParentescoFuncionario", "PretensionSalarial", "TieneParentescoConFuncionario") FROM stdin;
    Convocatorias          postgres    false    246   �4       �          0    18219    Notificacion 
   TABLE DATA           �   COPY "Convocatorias"."Notificacion" ("Id", "PostulacionId", "Mensaje", "FechaEnvio", "CreadoPor", "FechaCreacion", "FechaModificacion", "ModificadoPor") FROM stdin;
    Convocatorias          postgres    false    248   �9       �          0    18004 	   ParIdioma 
   TABLE DATA           �   COPY "Parametricas"."ParIdioma" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    218   �9       �          0    18012    ParNivelConocimiento 
   TABLE DATA           �   COPY "Parametricas"."ParNivelConocimiento" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    220   J:       �          0    18020    ParNivelFormacion 
   TABLE DATA           �   COPY "Parametricas"."ParNivelFormacion" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    222   �:       �          0    18028    ParParentesco 
   TABLE DATA           �   COPY "Parametricas"."ParParentesco" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    224   /;       �          0    18036    ParPrograma 
   TABLE DATA           �   COPY "Parametricas"."ParPrograma" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    226   �;       �          0    18044    ParTipoCapacitacion 
   TABLE DATA           �   COPY "Parametricas"."ParTipoCapacitacion" ("Id", "Descripcion", "Habilitado", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Parametricas          postgres    false    228   D<       �          0    18073    Capacitacion 
   TABLE DATA             COPY "Postulantes"."Capacitacion" ("Id", "PostulanteId", "ParTipoCapacitacionId", "Nombre", "CentroEstudios", "Pais", "HorasAcademicas", "Modalidad", "FechaInicio", "FechaFin", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    234   �<       �          0    18091    ConocimientoIdioma 
   TABLE DATA             COPY "Postulantes"."ConocimientoIdioma" ("Id", "PostulanteId", "ParIdiomaId", "ParNivelConocimientoLecturaId", "ParNivelConocimientoEscrituraId", "ParNivelConocimientoConversacionId", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    236   +=       �          0    18124    ConocimientoSistemas 
   TABLE DATA           �   COPY "Postulantes"."ConocimientoSistemas" ("Id", "PostulanteId", "ParProgramaId", "ParNivelConocimientoId", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    238   l=       �          0    26176    ExperienciaLaboral 
   TABLE DATA           �  COPY "Postulantes"."ExperienciaLaboral" ("Id", "PostulanteId", "Empresa", "Cargo", "Sector", "NroDependientes", "NombreSuperior", "CargoSuperior", "TelefonoEmpresa", "Funciones", "FechaInicio", "FechaConclusion", "MotivoDesvinculacion", "ActualmenteTrabajando", "ExperienciaGeneral", "ExperienciaEspecifica", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    250   �=       �          0    18147    FormacionAcademica 
   TABLE DATA           �   COPY "Postulantes"."FormacionAcademica" ("Id", "PostulanteId", "ParNivelFormacionId", "CentroEstudios", "TituloObtenido", "FechaTitulo", "Ciudad", "Pais", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    240   �>       �          0    18165    ReferenciaLaboral 
   TABLE DATA           �   COPY "Postulantes"."ReferenciaLaboral" ("Id", "PostulanteId", "Nombre", "Cargo", "Empresa", "Telefono", "TelefonoMovil", "Relacion", "Email", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    242   ?       �          0    18178    ReferenciaPersonal 
   TABLE DATA           �   COPY "Postulantes"."ReferenciaPersonal" ("Id", "PostulanteId", "Nombre", "Cargo", "Empresa", "Telefono", "TelefonoMovil", "ParParentescoId", "Email", "FechaCreacion", "CreadoPor", "FechaModificacion", "ModificadoPor") FROM stdin;
    Postulantes          postgres    false    244   �?       �          0    17980    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    212   $@       �           0    0    Convocatoria_Id_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('"Convocatorias"."Convocatoria_Id_seq"', 1, true);
          Convocatorias          postgres    false    231            �           0    0    Notificacion_Id_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('"Convocatorias"."Notificacion_Id_seq"', 1, false);
          Convocatorias          postgres    false    247            �           0    0    Postulacion_Id_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('"Convocatorias"."Postulacion_Id_seq"', 6, true);
          Convocatorias          postgres    false    245            �           0    0    ParEstadoConvocatoria_Id_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('"Parametricas"."ParEstadoConvocatoria_Id_seq"', 7, true);
          Parametricas          postgres    false    213            �           0    0    ParEstadoPostulacion_Id_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('"Parametricas"."ParEstadoPostulacion_Id_seq"', 5, true);
          Parametricas          postgres    false    215            �           0    0    ParIdioma_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('"Parametricas"."ParIdioma_Id_seq"', 8, true);
          Parametricas          postgres    false    217            �           0    0    ParNivelConocimiento_Id_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('"Parametricas"."ParNivelConocimiento_Id_seq"', 3, true);
          Parametricas          postgres    false    219            �           0    0    ParNivelFormacion_Id_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('"Parametricas"."ParNivelFormacion_Id_seq"', 10, true);
          Parametricas          postgres    false    221            �           0    0    ParParentesco_Id_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('"Parametricas"."ParParentesco_Id_seq"', 16, true);
          Parametricas          postgres    false    223            �           0    0    ParPrograma_Id_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('"Parametricas"."ParPrograma_Id_seq"', 5, true);
          Parametricas          postgres    false    225            �           0    0    ParTipoCapacitacion_Id_seq    SEQUENCE SET     R   SELECT pg_catalog.setval('"Parametricas"."ParTipoCapacitacion_Id_seq"', 4, true);
          Parametricas          postgres    false    227            �           0    0    Capacitacion_Id_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('"Postulantes"."Capacitacion_Id_seq"', 2, true);
          Postulantes          postgres    false    233            �           0    0    ConocimientoIdioma_Id_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('"Postulantes"."ConocimientoIdioma_Id_seq"', 1, true);
          Postulantes          postgres    false    235            �           0    0    ConocimientoSistemas_Id_seq    SEQUENCE SET     R   SELECT pg_catalog.setval('"Postulantes"."ConocimientoSistemas_Id_seq"', 4, true);
          Postulantes          postgres    false    237            �           0    0    ExperienciaLaboral_Id_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('"Postulantes"."ExperienciaLaboral_Id_seq"', 2, true);
          Postulantes          postgres    false    249            �           0    0    FormacionAcademica_Id_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('"Postulantes"."FormacionAcademica_Id_seq"', 2, true);
          Postulantes          postgres    false    239            �           0    0    Postulante_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('"Postulantes"."Postulante_Id_seq"', 1, true);
          Postulantes          postgres    false    229            �           0    0    ReferenciaLaboral_Id_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('"Postulantes"."ReferenciaLaboral_Id_seq"', 1, true);
          Postulantes          postgres    false    241            �           0    0    ReferenciaPersonal_Id_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('"Postulantes"."ReferenciaPersonal_Id_seq"', 1, true);
          Postulantes          postgres    false    243            �   b   x�3�tL�L-*I�,��#.#N�Ԣ��tqcN�<��Բ���Û��$M8��Ss0��r���dbH�q�e�%�dVa�2Y�
�W�.���� 0�2�      �   �   x�MN�
�0|�_���beۛ�4�n�KX�����K�a���r�A�����oz�N[D�3��w�0��֕��b�/d��p��~TV5�i��ڴJ���9�e��(䰤B��p	���@9$$��4� B�Ł�_�$&%3IL�r���}�]���\ݴ��te;�j����0LL�      �   �   x�]�M�0���S� ���qeHt�f,6������t��b��$���}�˛%d���3� ��tb�e�5K����H�Ta��O�!KXǰj��8�אvT�[xa������ʣQ{�Q�_�i��s ���[��Qrf�Q����=Nju�Lļ���	!����������-������"O��xh�      �   �   x�]���0E��W� ��-��h"!W�'6��)���Kd��,�,W@������p�i�44��#&�/&�ԍ�v�#�,�5�ȍ����CE�F���VG�zu��^�������������J�B搥\�s@�2b�aB��$�J<��DQ��	9�      �     x��Ms�8���W�|N\���)L¤�J ����A�"ؖW���L�o�`bs`�R���[�����^a|��F���x44F_&���vd��OF�����N���� �B���n���SV�G�Y�f��{�"�͜gSA������
FS��$MS��GRR�s�p�B���ezؘ�H�%XhFX
ߟW�Xq=����`�<�Ny�Q�oy�y����c;���i��*hk��gf��el=wCܸ��cV%$ٲ�㑨���-���%#�aOT���14�۲�K��q�x�_YNR�K�'ܸ�JF����PpÆ?���s5~����ASIS:�r�k�������0p�^W�7�"#jE*{1Ih�b!���YpYV)�K:H��}�![��k3d������w¸
����ɕG%�I�hZ�|%�=����ΐL�Sل`RwT��$�F�]��4c`�ד�J��O3�^���m[��w̷`bR@�r��A�'��7��k�*�a�[*�<M��PC�Y���a�(7���h�ρ.Ȗ�]�O�����(+�6Jr[i\Dk�j�̮�l��#�ؑX�멼z��Z�/rW,�f�)r<a�ۖ�v�W	�9�r .d����}��ܴf��qY��z�e,ؑ>�yI�lG�p;�Xa!���ܸ9���{�Y�O�S&��ݸr,���L�����5��׍0�\'��{Қ��5��t�� uk��QQyO���顛hsƾ��2R(��@�̛6u��ߨ4+����=�3�cl����"����(��M�Ŵqf�gP6IɍqUP��hU�9��Z�u9�'�;Adw-'t}�J����M*�5b<�o�F��h�h���n���u�TB^��*#�r�ȸ�����5�	�k9��0�]+��WE�QZ��zNh���l�9�4�i,�X��Lc��2�e���\�e�4�i,�X��Lc��2�e�e��2�e�4�i,�X��Lc�Ʋs�2˂��2Me��·A4�i*�T��LS�yS�����_'�~�?���t$�D *#�C�I����G��$Q�ʁ�h��j�5o��J?�_x�Y��E���vK��f㠸� ��=]�M6AC�,d27�''�I�sF�ŜH�z&|A��H��'\.౐�$�W�F���	�q�Vr'2ʜ�-A�dy\mN@�ʍR�)���֌Ī
)�������
��i��>��T��x,s�	�#7����B�o��2س�$Ӕ�$��&�g5n�$a�!�x�?����t<�~���...��$��      �      x������ � �      �   a   x�e�;
�0�zr���b���-�������z3Ŕ�ŭ�x����@�J��#�u��^�5�-�%�w�i�8��/�5qv}(Ƙ��-K      �   5   x�3�t:��839���3����8=�JR�rSS2ѥ�9��S�%b���� ��      �   �   x�u�=�0���9EO�(����(B�.Vb���T���a����G_'�/����|f}���R��!I�(��5�����Uu3�[��˝-�O����;8��`5qO>�kv�)�pI��E�Qj�.��6���0�|�~T�      �   �   x�m�=�0���. B�1m�ֈ&��E=�L\$$ɓ?�ٲ��2�����ǯDEՇ�)R�ϯ�tX�>�5����Hf狤&��3���`%�a�3�SfX� �g��"<Y��:��$[!f����n7sLn��"$�/��Ƙ7\�]       �   Y   x�3���t��wQ�ws�tvUp�pv��,��#.#Le��!>���h
�1���IO�4�&�����\�T�r����	��qqq �1.Q      �   @   x�3�t��KK-J�K�L�,��#.#N�Ң�|4Qc����̼ĢLtΐĜ��"4�=... �UW      �   �   x�3�4B���Ģ����|��T������ĢTNgw?�`N���̲�DNCΰ̢���N##]C]���`hjejdej�glbjdd��A\FX,��L.�/N-*�L��/��Zc+C#=3#C��1z\\\ di;�      �   1   x�3�4�C##]CC]CS+Sc+cs=KS3�?����� �	F      �   Q   x�m̻� ��O��Y�x�!2��.)h8��wB�Z$7g��B��B+:Y�|�ė����P�m|���ٽ�Ty�%      �   �   x�ݐMj�@���)�6��]��e�E)��Q��+9��;nI�P��xBHB@�Z�-0�n�t%þJ��Y�L�~S��QX��^ԛ|j.g{�'���ER6���!��pg���)��Yi4\;��,�*�Ffp�a����f�q���b�BG������xԍ}��q�n���~W㞮��z�E���|�4��Yk_���]�4?2ϣ�      �   ]   x�3�4��Ĝ���ļDN��dO?w�������bN##]CC]N�D���*N���̲�D$CS+S3+##=sCC3c�?����� A1�      �   }   x�%�1�0 g�y@�!%�a`�غ%�mP��~@�n�厀��%�Wa���=-A��cГ��x$r��.)rس��;m�7x��R����u-Q�NS7t~�'s��=̷���R���%�      �   j   x�%�A
�0���)rC�8��U�R\�v�,��޿��G�^>��/�e3�Y}]��j�(Dy@�F��F�_�b�bᾭ�(ڐMT�ԧ܋�L���<���sJ��      �   �   x�uα
�0��y�p����ܩ�oP�J	���u��+�
1Ng�~8"S���|�]x&7�p���xU5�%Wט�×�0�sχ����<�
AÇ�{ Y`���w�7�W��ޟ��%����nߵR�;"]c     