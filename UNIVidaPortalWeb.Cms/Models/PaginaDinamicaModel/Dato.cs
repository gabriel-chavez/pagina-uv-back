﻿using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class Dato : BaseDomainModel
    {        
        public string? DatoTexto { get; set; }
        public DateTime? DatoFechaHora { get; set; }
        public string? DatoUrl { get; set; }
        public int? RecursoId { get; set; }
        public int SeccionId { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }

        public virtual Recurso? Recurso { get; set; }
        public virtual Seccion? Seccion { get; set; }
    }
}
