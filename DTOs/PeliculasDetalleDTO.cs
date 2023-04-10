namespace PeliculasAPI.DTOs
{
    public class PeliculasDetalleDTO: PeliculaDTO
    {
        public List<GeneroDTO> Generos { get; set; }
        public List<ActorPeliculaDetalleDTO> Actores { get; set; }
    }
}
