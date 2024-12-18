﻿using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class BannerPagina : BaseDomainModel
    {
        public int? PaginaDinamicaId { get; set; }
        public int? SeguroId { get; set; }
        public int RecursoId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string SubTitulo { get; set; } = string.Empty;
        public virtual PaginaDinamica? PaginaDinamica { get; set; }
        public virtual Seguro? Seguro { get; set; }
        public virtual Recurso Recurso { get; set; }
    }
}

