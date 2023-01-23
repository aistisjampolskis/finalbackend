using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsAPI.Migrations
{
    /// <inheritdoc />
    public partial class @return : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfos_AddContactRequest_AddContactRequestId",
                table: "UserInfos");

            migrationBuilder.DropTable(
                name: "AddContactRequest");

            migrationBuilder.DropIndex(
                name: "IX_UserInfos_AddContactRequestId",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "AddContactRequestId",
                table: "UserInfos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddContactRequestId",
                table: "UserInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AddContactRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivingPlaceId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ProfileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddContactRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddContactRequest_LivingPlaces_LivingPlaceId",
                        column: x => x.LivingPlaceId,
                        principalTable: "LivingPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_AddContactRequestId",
                table: "UserInfos",
                column: "AddContactRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_AddContactRequest_LivingPlaceId",
                table: "AddContactRequest",
                column: "LivingPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfos_AddContactRequest_AddContactRequestId",
                table: "UserInfos",
                column: "AddContactRequestId",
                principalTable: "AddContactRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
