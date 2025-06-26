using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AREASYVOLUMENES.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Radio = table.Column<double>(type: "double precision", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Area = table.Column<double>(type: "double precision", nullable: false),
                    Volumen = table.Column<double>(type: "double precision", nullable: false),
                    Perimetro = table.Column<double>(type: "double precision", nullable: false),
                    FechaCalculo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuadrados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Lado = table.Column<double>(type: "double precision", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Area = table.Column<double>(type: "double precision", nullable: false),
                    Volumen = table.Column<double>(type: "double precision", nullable: false),
                    Perimetro = table.Column<double>(type: "double precision", nullable: false),
                    FechaCalculo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuadrados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rectangulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Base = table.Column<double>(type: "double precision", nullable: false),
                    Altura = table.Column<double>(type: "double precision", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Area = table.Column<double>(type: "double precision", nullable: false),
                    Volumen = table.Column<double>(type: "double precision", nullable: false),
                    Perimetro = table.Column<double>(type: "double precision", nullable: false),
                    FechaCalculo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rectangulos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circulos");

            migrationBuilder.DropTable(
                name: "Cuadrados");

            migrationBuilder.DropTable(
                name: "Rectangulos");
        }
    }
}
