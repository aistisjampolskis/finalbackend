using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsAPI.Migrations
{
    /// <inheritdoc />
    public partial class newmigratforeign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LivingPlaces_AddContactRequest_ContactId",
                table: "LivingPlaces");

            migrationBuilder.DropIndex(
                name: "IX_LivingPlaces_ContactId",
                table: "LivingPlaces");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "LivingPlaces");

            migrationBuilder.AddColumn<int>(
                name: "AddContactRequestId",
                table: "UserInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_AddContactRequestId",
                table: "UserInfos",
                column: "AddContactRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_AddContactRequest_LivingPlaceId",
                table: "AddContactRequest",
                column: "LivingPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddContactRequest_LivingPlaces_LivingPlaceId",
                table: "AddContactRequest",
                column: "LivingPlaceId",
                principalTable: "LivingPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfos_AddContactRequest_AddContactRequestId",
                table: "UserInfos",
                column: "AddContactRequestId",
                principalTable: "AddContactRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddContactRequest_LivingPlaces_LivingPlaceId",
                table: "AddContactRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfos_AddContactRequest_AddContactRequestId",
                table: "UserInfos");

            migrationBuilder.DropIndex(
                name: "IX_UserInfos_AddContactRequestId",
                table: "UserInfos");

            migrationBuilder.DropIndex(
                name: "IX_AddContactRequest_LivingPlaceId",
                table: "AddContactRequest");

            migrationBuilder.DropColumn(
                name: "AddContactRequestId",
                table: "UserInfos");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "LivingPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LivingPlaces_ContactId",
                table: "LivingPlaces",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_LivingPlaces_AddContactRequest_ContactId",
                table: "LivingPlaces",
                column: "ContactId",
                principalTable: "AddContactRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
