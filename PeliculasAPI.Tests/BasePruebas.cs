using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using PeliculasAPI.Data;
using PeliculasAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasAPI.Tests
{
    public class BasePruebas
    {
        protected ApplicationDBContext ConstruirContext(string nombreDB)
        {
            //var opciones = new DbContextOptionsBuilder<ApplicationDBContext>()
            //    .UseInMemoryDatabase(nombreDB).Options;

            var opciones = new DbContextOptionsBuilder<ApplicationDBContext>().UseInMemoryDatabase(databaseName: nombreDB).Options;

            var dbContext = new ApplicationDBContext(opciones);
            return dbContext;
        }

        protected IMapper ConfigurarAutoMapper()
        {
            var config = new MapperConfiguration(options =>
            {
                var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
                options.AddProfile(new AutoMapperProfiles(geometryFactory));
            });

            return config.CreateMapper();
        }
    }
}
