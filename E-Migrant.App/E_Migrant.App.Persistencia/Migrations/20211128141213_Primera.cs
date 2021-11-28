using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migrant.App.Persistencia.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razon_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pagina_Web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    Tipo_Servicios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Documento = table.Column<int>(type: "int", nullable: false),
                    Numero_Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<int>(type: "int", nullable: true),
                    Situacion_Laboral = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MigranteId = table.Column<int>(type: "int", nullable: true),
                    AmigoOFamiliar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amigos_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nesecidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria_Nesecidades = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelP = table.Column<int>(type: "int", nullable: false),
                    MigranteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nesecidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nesecidades_Personas_MigranteId",
                        column: x => x.MigranteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Max_Migrante = table.Column<int>(type: "int", nullable: false),
                    Fecha_InicioOfer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_FinalOfer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoServicio = table.Column<int>(type: "int", nullable: false),
                    Categoria_Nesecidades = table.Column<int>(type: "int", nullable: false),
                    NesecidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Nesecidades_NesecidadId",
                        column: x => x.NesecidadId,
                        principalTable: "Nesecidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_MigranteId",
                table: "Amigos",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Nesecidades_MigranteId",
                table: "Nesecidades",
                column: "MigranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_NesecidadId",
                table: "Servicios",
                column: "NesecidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Nesecidades");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
