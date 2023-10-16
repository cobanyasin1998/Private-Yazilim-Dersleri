﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mig5Yas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "Files");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Files",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Files_ProductId",
                table: "Files",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Products_ProductId",
                table: "Files",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Products_ProductId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_ProductId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Files",
                type: "integer",
                nullable: true);
        }
    }
}
