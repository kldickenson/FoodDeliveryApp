using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCFoodDeliveryApp.Migrations
{
    public partial class AddCartForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cart_Id",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cart",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ApplicationUserId",
                schema: "Identity",
                table: "Cart",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart",
                schema: "Identity");

            migrationBuilder.DropColumn(
                name: "Cart_Id",
                schema: "Identity",
                table: "AspNetUsers");
        }
    }
}
