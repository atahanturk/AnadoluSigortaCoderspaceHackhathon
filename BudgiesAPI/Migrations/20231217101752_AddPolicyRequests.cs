using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BudgiesAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPolicyRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    SmokingStatus = table.Column<bool>(type: "boolean", nullable: false),
                    GeneticDisease = table.Column<bool>(type: "boolean", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRequests_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    HomeType = table.Column<string>(type: "text", nullable: false),
                    HomeAge = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeRequests_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    PetAge = table.Column<int>(type: "integer", nullable: false),
                    Genus = table.Column<string>(type: "text", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetRequests_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthRequests_CustomerTcNo",
                table: "HealthRequests",
                column: "CustomerTcNo");

            migrationBuilder.CreateIndex(
                name: "IX_HomeRequests_CustomerTcNo",
                table: "HomeRequests",
                column: "CustomerTcNo");

            migrationBuilder.CreateIndex(
                name: "IX_PetRequests_CustomerTcNo",
                table: "PetRequests",
                column: "CustomerTcNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthRequests");

            migrationBuilder.DropTable(
                name: "HomeRequests");

            migrationBuilder.DropTable(
                name: "PetRequests");
        }
    }
}
