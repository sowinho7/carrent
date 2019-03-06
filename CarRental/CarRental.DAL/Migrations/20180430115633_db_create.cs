using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarRental.DAL.Migrations
{
    public partial class db_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustId = table.Column<int>(nullable: false),
                    Parking = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ServiceNo = table.Column<int>(nullable: false),
                    ServiceType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    RentFinish = table.Column<DateTime>(nullable: false),
                    RentStart = table.Column<DateTime>(nullable: false),
                    RentType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descriptions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bail = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    CarModel = table.Column<string>(nullable: true),
                    Clim = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Doors = table.Column<int>(nullable: false),
                    DriveType = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Horsepower = table.Column<int>(nullable: false),
                    Navi = table.Column<bool>(nullable: false),
                    ProdDate = table.Column<DateTime>(nullable: false),
                    RentId = table.Column<int>(nullable: true),
                    RentPrice = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Upholestry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Rental_RentId",
                        column: x => x.RentId,
                        principalTable: "Rental",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CustCarBrand = table.Column<string>(nullable: true),
                    CustCarCapacity = table.Column<int>(nullable: false),
                    CustCarDescription = table.Column<string>(nullable: true),
                    CustCarHorsepower = table.Column<int>(nullable: false),
                    CustCarModel = table.Column<string>(nullable: true),
                    CustCarProdDate = table.Column<DateTime>(nullable: false),
                    CustCarVin = table.Column<string>(nullable: true),
                    DocNo = table.Column<string>(nullable: true),
                    DocType = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    RentId = table.Column<int>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Rental_RentId",
                        column: x => x.RentId,
                        principalTable: "Rental",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RentId",
                table: "Cars",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_InvoiceId",
                table: "Customers",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrderId",
                table: "Customers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RentId",
                table: "Customers",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_OrderId",
                table: "Descriptions",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
