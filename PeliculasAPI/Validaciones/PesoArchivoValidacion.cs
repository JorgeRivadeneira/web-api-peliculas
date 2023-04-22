using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Validaciones
{
    public class PesoArchivoValidacion : ValidationAttribute
    {
        private readonly int _pesoMaximoEnMegabytes;
        public PesoArchivoValidacion(int pesoMaximoEnMegabytes)
        {
            _pesoMaximoEnMegabytes = pesoMaximoEnMegabytes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            IFormFile formFile = value as IFormFile;

            if (formFile == null) return ValidationResult.Success;

            if(formFile.Length > _pesoMaximoEnMegabytes * 1024 * 1024)
            {
                return new ValidationResult($"El peso del archivo no deb ser mayor a: {_pesoMaximoEnMegabytes} mb");
            }

            return ValidationResult.Success;
        }
    }
}
