using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConnectJob.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cpf", "Email", "Nome", "Senha" },
                values: new object[] { "12312312312", "rafaelsantos@hotmail.com", "Rafael santos", "123123" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cpf", "Email", "Nome", "Senha" },
                values: new object[] { "12312312312", "rafaelnascimento@hotmail.com", "Rafael nascimento", "123123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Cpf", "Email", "Nome", "Senha" },
                values: new object[,]
                {
                    { 3, "12312312312", "renatomdavid811@hotmail.com", "Renato marques david", "123123" },
                    { 4, "12312312312", "myllhertavares@hotmail.com", "Myller Tavares", "123123" },
                    { 5, "12312312312", "stefanymarques@hotmail.com", "stefany marques", "123123" },
                    { 6, "12312312312", "thalessampaio@hotmail.com", "Thales Sampaio", "123123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cpf", "Email", "Nome", "Senha" },
                values: new object[] { null, null, "The Witcher 3", null });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cpf", "Email", "Nome", "Senha" },
                values: new object[] { null, null, "The Witcher 2", null });
        }
    }
}
