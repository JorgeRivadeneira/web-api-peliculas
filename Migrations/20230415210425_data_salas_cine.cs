using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace PeliculasAPI.Migrations
{
    public partial class data_salas_cine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 2, "Super Cines", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (0.0210616, -78.9732008)") });

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 1, "Multicines", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.0210609, -78.9732054)") });

            migrationBuilder.InsertData(
                table: "SalasDeCine",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 5, "Cinemark", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-0.1751269, -78.644943)") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalasDeCine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalasDeCine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalasDeCine",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
