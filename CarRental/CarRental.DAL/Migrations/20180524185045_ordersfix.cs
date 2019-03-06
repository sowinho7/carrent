using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarRental.DAL.Migrations
{
    public partial class ordersfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date10",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date2",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date3",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date4",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date5",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date6",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date7",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date8",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date9",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description10",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description8",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description9",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date10",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date3",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date4",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date5",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date6",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date7",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date8",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Date9",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description10",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description8",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Description9",
                table: "Orders");
        }
    }
}
