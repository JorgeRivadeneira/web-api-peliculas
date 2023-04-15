using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class SalaDeCineCercanoFiltroDTO
    {
        [Range(-90, 90)]
        public double Latitud { get; set; }
        [Range(-180, 180)]
        public double Longitud { get; set; }
        private int distanciaEnKms { get; set; } = 10;

        private int distanciaMaximaEnKms { get; set; } = 250;

        public int DistanciaEnKms
        {
            get { return distanciaEnKms; }
            set { distanciaEnKms = (value > distanciaMaximaEnKms) ? distanciaMaximaEnKms : value; }
        }

    }
}
