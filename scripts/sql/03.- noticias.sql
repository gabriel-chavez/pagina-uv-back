PGDMP  8    "            
    |            BD_UNIVidaPortalWebNoticias    14.1    16.2 ,    "           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            #           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            $           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            %           1262    17030    BD_UNIVidaPortalWebNoticias    DATABASE     �   CREATE DATABASE "BD_UNIVidaPortalWebNoticias" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';
 -   DROP DATABASE "BD_UNIVidaPortalWebNoticias";
                postgres    false                        2615    17036    Noticias    SCHEMA        CREATE SCHEMA "Noticias";
    DROP SCHEMA "Noticias";
                postgres    false                        2615    17037    Parametricas    SCHEMA        CREATE SCHEMA "Parametricas";
    DROP SCHEMA "Parametricas";
                postgres    false                        2615    2200    public    SCHEMA     2   -- *not* creating schema, since initdb creates it
 2   -- *not* dropping schema, since initdb creates it
                postgres    false            &           0    0    SCHEMA public    ACL     Q   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    4            �            1259    17076    Noticia    TABLE     1  CREATE TABLE "Noticias"."Noticia" (
    "Id" integer NOT NULL,
    "Titulo" text NOT NULL,
    "TituloCorto" text NOT NULL,
    "Contenido" text NOT NULL,
    "Resumen" text NOT NULL,
    "RecursoId_ImagenPrincipal" integer,
    "Fecha" timestamp without time zone NOT NULL,
    "ParCategoriaId" integer NOT NULL,
    "ParEstadoId" integer NOT NULL,
    "Etiquetas" text NOT NULL,
    "Orden" integer NOT NULL,
    "CreatedDate" timestamp without time zone,
    "CreatedBy" text,
    "LastModifiedDate" timestamp without time zone,
    "LastModifiedBy" text
);
 !   DROP TABLE "Noticias"."Noticia";
       Noticias         heap    postgres    false    6            �            1259    17075    Noticia_Id_seq    SEQUENCE     �   ALTER TABLE "Noticias"."Noticia" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME "Noticias"."Noticia_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            Noticias          postgres    false    221    6            �            1259    17063    Recurso    TABLE     Z  CREATE TABLE "Noticias"."Recurso" (
    "Id" integer NOT NULL,
    "Nombre" text NOT NULL,
    "ParTipoRecursoId" integer NOT NULL,
    "RecursoEscritorio" text NOT NULL,
    "RecursoMovil" text,
    "CreatedDate" timestamp without time zone,
    "CreatedBy" text,
    "LastModifiedDate" timestamp without time zone,
    "LastModifiedBy" text
);
 !   DROP TABLE "Noticias"."Recurso";
       Noticias         heap    postgres    false    6            �            1259    17062    Recurso_Id_seq    SEQUENCE     �   ALTER TABLE "Noticias"."Recurso" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME "Noticias"."Recurso_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            Noticias          postgres    false    6    219            �            1259    17039    ParCategoria    TABLE       CREATE TABLE "Parametricas"."ParCategoria" (
    "Id" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Habilitado" boolean NOT NULL,
    "CreatedDate" timestamp without time zone,
    "CreatedBy" text,
    "LastModifiedDate" timestamp without time zone,
    "LastModifiedBy" text
);
 *   DROP TABLE "Parametricas"."ParCategoria";
       Parametricas         heap    postgres    false    7            �            1259    17038    ParCategoria_Id_seq    SEQUENCE     �   ALTER TABLE "Parametricas"."ParCategoria" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME "Parametricas"."ParCategoria_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            Parametricas          postgres    false    213    7            �            1259    17047 	   ParEstado    TABLE       CREATE TABLE "Parametricas"."ParEstado" (
    "Id" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Habilitado" boolean NOT NULL,
    "CreatedDate" timestamp without time zone,
    "CreatedBy" text,
    "LastModifiedDate" timestamp without time zone,
    "LastModifiedBy" text
);
 '   DROP TABLE "Parametricas"."ParEstado";
       Parametricas         heap    postgres    false    7            �            1259    17046    ParEstado_Id_seq    SEQUENCE     �   ALTER TABLE "Parametricas"."ParEstado" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME "Parametricas"."ParEstado_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            Parametricas          postgres    false    215    7            �            1259    17055    ParTipoRecurso    TABLE       CREATE TABLE "Parametricas"."ParTipoRecurso" (
    "Id" integer NOT NULL,
    "Nombre" text NOT NULL,
    "Habilitado" boolean NOT NULL,
    "CreatedDate" timestamp without time zone,
    "CreatedBy" text,
    "LastModifiedDate" timestamp without time zone,
    "LastModifiedBy" text
);
 ,   DROP TABLE "Parametricas"."ParTipoRecurso";
       Parametricas         heap    postgres    false    7            �            1259    17054    ParTipoRecurso_Id_seq    SEQUENCE     �   ALTER TABLE "Parametricas"."ParTipoRecurso" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME "Parametricas"."ParTipoRecurso_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            Parametricas          postgres    false    217    7            �            1259    17031    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false    4                      0    17076    Noticia 
   TABLE DATA           �   COPY "Noticias"."Noticia" ("Id", "Titulo", "TituloCorto", "Contenido", "Resumen", "RecursoId_ImagenPrincipal", "Fecha", "ParCategoriaId", "ParEstadoId", "Etiquetas", "Orden", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
    Noticias          postgres    false    221   I:                 0    17063    Recurso 
   TABLE DATA           �   COPY "Noticias"."Recurso" ("Id", "Nombre", "ParTipoRecursoId", "RecursoEscritorio", "RecursoMovil", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
    Noticias          postgres    false    219   f:                 0    17039    ParCategoria 
   TABLE DATA           �   COPY "Parametricas"."ParCategoria" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
    Parametricas          postgres    false    213   �:                 0    17047 	   ParEstado 
   TABLE DATA           �   COPY "Parametricas"."ParEstado" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
    Parametricas          postgres    false    215   �:                 0    17055    ParTipoRecurso 
   TABLE DATA           �   COPY "Parametricas"."ParTipoRecurso" ("Id", "Nombre", "Habilitado", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy") FROM stdin;
    Parametricas          postgres    false    217   ;                 0    17031    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    211   S;       '           0    0    Noticia_Id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('"Noticias"."Noticia_Id_seq"', 1, false);
          Noticias          postgres    false    220            (           0    0    Recurso_Id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('"Noticias"."Recurso_Id_seq"', 1, true);
          Noticias          postgres    false    218            )           0    0    ParCategoria_Id_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('"Parametricas"."ParCategoria_Id_seq"', 1, true);
          Parametricas          postgres    false    212            *           0    0    ParEstado_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('"Parametricas"."ParEstado_Id_seq"', 1, true);
          Parametricas          postgres    false    214            +           0    0    ParTipoRecurso_Id_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('"Parametricas"."ParTipoRecurso_Id_seq"', 3, true);
          Parametricas          postgres    false    216            �           2606    17082    Noticia PK_Noticia 
   CONSTRAINT     Z   ALTER TABLE ONLY "Noticias"."Noticia"
    ADD CONSTRAINT "PK_Noticia" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY "Noticias"."Noticia" DROP CONSTRAINT "PK_Noticia";
       Noticias            postgres    false    221            �           2606    17069    Recurso PK_Recurso 
   CONSTRAINT     Z   ALTER TABLE ONLY "Noticias"."Recurso"
    ADD CONSTRAINT "PK_Recurso" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY "Noticias"."Recurso" DROP CONSTRAINT "PK_Recurso";
       Noticias            postgres    false    219            y           2606    17045    ParCategoria PK_ParCategoria 
   CONSTRAINT     h   ALTER TABLE ONLY "Parametricas"."ParCategoria"
    ADD CONSTRAINT "PK_ParCategoria" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY "Parametricas"."ParCategoria" DROP CONSTRAINT "PK_ParCategoria";
       Parametricas            postgres    false    213            {           2606    17053    ParEstado PK_ParEstado 
   CONSTRAINT     b   ALTER TABLE ONLY "Parametricas"."ParEstado"
    ADD CONSTRAINT "PK_ParEstado" PRIMARY KEY ("Id");
 L   ALTER TABLE ONLY "Parametricas"."ParEstado" DROP CONSTRAINT "PK_ParEstado";
       Parametricas            postgres    false    215            }           2606    17061     ParTipoRecurso PK_ParTipoRecurso 
   CONSTRAINT     l   ALTER TABLE ONLY "Parametricas"."ParTipoRecurso"
    ADD CONSTRAINT "PK_ParTipoRecurso" PRIMARY KEY ("Id");
 V   ALTER TABLE ONLY "Parametricas"."ParTipoRecurso" DROP CONSTRAINT "PK_ParTipoRecurso";
       Parametricas            postgres    false    217            w           2606    17035 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    211            �           1259    17093    IX_Noticia_ParCategoriaId    INDEX     a   CREATE INDEX "IX_Noticia_ParCategoriaId" ON "Noticias"."Noticia" USING btree ("ParCategoriaId");
 3   DROP INDEX "Noticias"."IX_Noticia_ParCategoriaId";
       Noticias            postgres    false    221            �           1259    17101    IX_Noticia_ParEstadoId    INDEX     [   CREATE INDEX "IX_Noticia_ParEstadoId" ON "Noticias"."Noticia" USING btree ("ParEstadoId");
 0   DROP INDEX "Noticias"."IX_Noticia_ParEstadoId";
       Noticias            postgres    false    221            �           1259    17094 $   IX_Noticia_RecursoId_ImagenPrincipal    INDEX     w   CREATE INDEX "IX_Noticia_RecursoId_ImagenPrincipal" ON "Noticias"."Noticia" USING btree ("RecursoId_ImagenPrincipal");
 >   DROP INDEX "Noticias"."IX_Noticia_RecursoId_ImagenPrincipal";
       Noticias            postgres    false    221            ~           1259    17095    IX_Recurso_ParTipoRecursoId    INDEX     e   CREATE INDEX "IX_Recurso_ParTipoRecursoId" ON "Noticias"."Recurso" USING btree ("ParTipoRecursoId");
 5   DROP INDEX "Noticias"."IX_Recurso_ParTipoRecursoId";
       Noticias            postgres    false    219            �           2606    17083 .   Noticia FK_Noticia_ParCategoria_ParCategoriaId    FK CONSTRAINT     �   ALTER TABLE ONLY "Noticias"."Noticia"
    ADD CONSTRAINT "FK_Noticia_ParCategoria_ParCategoriaId" FOREIGN KEY ("ParCategoriaId") REFERENCES "Parametricas"."ParCategoria"("Id") ON DELETE CASCADE;
 `   ALTER TABLE ONLY "Noticias"."Noticia" DROP CONSTRAINT "FK_Noticia_ParCategoria_ParCategoriaId";
       Noticias          postgres    false    213    221    3193            �           2606    17102 (   Noticia FK_Noticia_ParEstado_ParEstadoId    FK CONSTRAINT     �   ALTER TABLE ONLY "Noticias"."Noticia"
    ADD CONSTRAINT "FK_Noticia_ParEstado_ParEstadoId" FOREIGN KEY ("ParEstadoId") REFERENCES "Parametricas"."ParEstado"("Id") ON DELETE CASCADE;
 Z   ALTER TABLE ONLY "Noticias"."Noticia" DROP CONSTRAINT "FK_Noticia_ParEstado_ParEstadoId";
       Noticias          postgres    false    3195    215    221            �           2606    17096 4   Noticia FK_Noticia_Recurso_RecursoId_ImagenPrincipal    FK CONSTRAINT     �   ALTER TABLE ONLY "Noticias"."Noticia"
    ADD CONSTRAINT "FK_Noticia_Recurso_RecursoId_ImagenPrincipal" FOREIGN KEY ("RecursoId_ImagenPrincipal") REFERENCES "Noticias"."Recurso"("Id");
 f   ALTER TABLE ONLY "Noticias"."Noticia" DROP CONSTRAINT "FK_Noticia_Recurso_RecursoId_ImagenPrincipal";
       Noticias          postgres    false    219    3200    221            �           2606    17070 2   Recurso FK_Recurso_ParTipoRecurso_ParTipoRecursoId    FK CONSTRAINT     �   ALTER TABLE ONLY "Noticias"."Recurso"
    ADD CONSTRAINT "FK_Recurso_ParTipoRecurso_ParTipoRecursoId" FOREIGN KEY ("ParTipoRecursoId") REFERENCES "Parametricas"."ParTipoRecurso"("Id") ON DELETE CASCADE;
 d   ALTER TABLE ONLY "Noticias"."Recurso" DROP CONSTRAINT "FK_Recurso_ParTipoRecurso_ParTipoRecursoId";
       Noticias          postgres    false    217    3197    219                  x������ � �         C   x�3���u�72022034�740�00�4��O,.N-)����"ohn`�jif��U��㇌�b���� �VS            x�3���/�L�L�,��#�=... w`�            x�3�(M��LNL��,��#�=... �g�         .   x�3���MLO͋��,��#.#ΰ̔�|4QcN��"t�=... ��	         �   x�e�A
�0е�K�dLӺw�Jq-�1�2P�������U
��W�}t��m�Q�2��j��q.�C�D�<)���U�+'�(4VgR�t��(-�v8��-߃n)s�;�qvmÑ��aw�?����y�)��6�| �,?@     