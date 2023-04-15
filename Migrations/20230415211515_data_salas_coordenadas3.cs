using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace PeliculasAPI.Migrations
{
    public partial class data_salas_coordenadas3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalasDeCine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 4, "Star Cines", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (0.3491438 -78.1278624)") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalasDeCine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 5, "Cinemark", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.1751269 -78.644943)") });
        }
    }
}
