using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DocumentSystemApp.Data.Migrations
{
    public partial class ChangeRequestEntity22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdaterUserId",
                table: "ChangeRequestForms",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatorUserId",
                table: "ChangeRequestForms",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpdaterUserId",
                table: "ChangeRequestForms",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatorUserId",
                table: "ChangeRequestForms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
