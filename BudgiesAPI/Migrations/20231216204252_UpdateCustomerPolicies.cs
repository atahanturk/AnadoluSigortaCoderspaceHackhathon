using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BudgiesAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerPolicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    TcNo = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.TcNo);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    TcNo = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.TcNo);
                });

            migrationBuilder.CreateTable(
                name: "HealthPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    SmokingStatus = table.Column<bool>(type: "boolean", nullable: false),
                    GeneticDisease = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthPolicies_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomePolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    HomeType = table.Column<string>(type: "text", nullable: false),
                    HomeAge = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomePolicies_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerTcNo = table.Column<string>(type: "text", nullable: false),
                    PetAge = table.Column<int>(type: "integer", nullable: false),
                    Genus = table.Column<string>(type: "text", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetPolicies_Customers_CustomerTcNo",
                        column: x => x.CustomerTcNo,
                        principalTable: "Customers",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthPolicies_CustomerTcNo",
                table: "HealthPolicies",
                column: "CustomerTcNo");

            migrationBuilder.CreateIndex(
                name: "IX_HomePolicies_CustomerTcNo",
                table: "HomePolicies",
                column: "CustomerTcNo");

            migrationBuilder.CreateIndex(
                name: "IX_PetPolicies_CustomerTcNo",
                table: "PetPolicies",
                column: "CustomerTcNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "HealthPolicies");

            migrationBuilder.DropTable(
                name: "HomePolicies");

            migrationBuilder.DropTable(
                name: "PetPolicies");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
