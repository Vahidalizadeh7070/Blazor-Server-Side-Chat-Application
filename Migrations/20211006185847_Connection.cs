using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrivateMessenger.Migrations
{
    public partial class Connection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Connection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderUserConnectionId = table.Column<string>(nullable: true),
                    RecieverUserConnectionId = table.Column<string>(nullable: true),
                    SenderUserId = table.Column<string>(nullable: true),
                    SenderUserConnected = table.Column<bool>(nullable: false),
                    RecieverUserConnected = table.Column<bool>(nullable: false),
                    RecieverUserId = table.Column<string>(nullable: true),
                    SenderUserConnectDate = table.Column<DateTime>(nullable: false),
                    RecieverUserConnectDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connection_AspNetUsers_RecieverUserId",
                        column: x => x.RecieverUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Connection_AspNetUsers_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Connection_RecieverUserId",
                table: "Connection",
                column: "RecieverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Connection_SenderUserId",
                table: "Connection",
                column: "SenderUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connection");
        }
    }
}
