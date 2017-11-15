using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FeatureApplication.Migrations
{
    public partial class RemoveCreatedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "mst",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "mst",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "mst",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "mst",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "mst",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "mst",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "mst",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "mst",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "mst",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "mst",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "mst",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "mst",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "mst",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                schema: "mst",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateModified",
                schema: "mst",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "mst",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "mst",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                schema: "mst",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "mst",
                table: "ProductCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "mst",
                table: "ProductCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "mst",
                table: "ProductCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "mst",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "mst",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "mst",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "mst",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "mst",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "mst",
                table: "OrderDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "mst",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "mst",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "mst",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                schema: "mst",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "mst",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                schema: "mst",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                schema: "mst",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "mst",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "mst",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
