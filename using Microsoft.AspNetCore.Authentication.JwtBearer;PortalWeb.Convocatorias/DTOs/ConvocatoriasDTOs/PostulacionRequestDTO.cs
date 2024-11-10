using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;

namespace UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs
{
    public class PostulacionRequestDTO
    {
        public int ConvocatoriaId { get; set; }
        public int PostulanteId { get; set; }
        public decimal PretensionSalarial { get; set; }
        public bool DisponibilidadInmediata { get; set; }
        public int CantidadDiasDisponibilidad { get; set; }
        public bool TieneParentescoConFuncionario { get; set; }
        public string? NombreParentescoFuncionario { get; set; }
        public List<ExperienciaLaboralGeneralEspecificaRequestDTO> ExperienciasLaborales { get; set; } = new List<ExperienciaLaboralGeneralEspecificaRequestDTO>();

    }
}
