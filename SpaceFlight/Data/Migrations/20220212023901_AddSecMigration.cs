using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceFlight.Data.Migrations
{
    public partial class AddSecMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsModel_Articles_ArticlesModelId",
                table: "EventsModel");

            migrationBuilder.DropForeignKey(
                name: "FK_LaunchesModel_Articles_ArticlesModelId",
                table: "LaunchesModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaunchesModel",
                table: "LaunchesModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsModel",
                table: "EventsModel");

            migrationBuilder.RenameTable(
                name: "LaunchesModel",
                newName: "Launches");

            migrationBuilder.RenameTable(
                name: "EventsModel",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_LaunchesModel_ArticlesModelId",
                table: "Launches",
                newName: "IX_Launches_ArticlesModelId");

            migrationBuilder.RenameIndex(
                name: "IX_EventsModel_ArticlesModelId",
                table: "Events",
                newName: "IX_Events_ArticlesModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launches",
                table: "Launches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Articles_ArticlesModelId",
                table: "Events",
                column: "ArticlesModelId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Articles_ArticlesModelId",
                table: "Launches",
                column: "ArticlesModelId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Articles_ArticlesModelId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Articles_ArticlesModelId",
                table: "Launches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Launches",
                table: "Launches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Launches",
                newName: "LaunchesModel");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "EventsModel");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_ArticlesModelId",
                table: "LaunchesModel",
                newName: "IX_LaunchesModel_ArticlesModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_ArticlesModelId",
                table: "EventsModel",
                newName: "IX_EventsModel_ArticlesModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaunchesModel",
                table: "LaunchesModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsModel",
                table: "EventsModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsModel_Articles_ArticlesModelId",
                table: "EventsModel",
                column: "ArticlesModelId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LaunchesModel_Articles_ArticlesModelId",
                table: "LaunchesModel",
                column: "ArticlesModelId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
