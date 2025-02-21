using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6.Migrations
{
    /// <inheritdoc />
    public partial class joelnewdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "genre",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Movies",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Movies",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "lentTo",
                table: "Movies",
                newName: "LentTo");

            migrationBuilder.RenameColumn(
                name: "edited",
                table: "Movies",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "director",
                table: "Movies",
                newName: "Director");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "yearReleased",
                table: "Movies",
                newName: "Year");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "LentTo",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Edited",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CopiedToPlex",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieId");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cats_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Cats",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cats_CategoryId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movies",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Movies",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "LentTo",
                table: "Movies",
                newName: "lentTo");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Movies",
                newName: "edited");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Movies",
                newName: "director");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Movies",
                newName: "yearReleased");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "notes",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lentTo",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "edited",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "director",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "genre",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "title");
        }
    }
}
