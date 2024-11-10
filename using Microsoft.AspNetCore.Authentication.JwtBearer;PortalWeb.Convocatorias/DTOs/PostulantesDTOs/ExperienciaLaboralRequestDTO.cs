namespace UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs
{
    public class ExperienciaLaboralRequestDTO
    {
        public int PostulanteId { get; set; }

        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Sector { get; set; }
        public int NroDependientes { get; set; }

        public string NombreSuperior { get; set; }
        public string CargoSuperior { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Funciones { get; set; }

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaConclusion { get; set; }
        public string MotivoDesvinculacion { get; set; }
        public bool ActualmenteTrabajando { get; set; }



    }
}
