﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopManagement.Infrastructure.EFCore.Migrations
{
    public partial class OrderIssueTrackingNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IssueTracking",
                table: "Orders",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IssueTracking",
                table: "Orders",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);
        }
    }
}
