using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetControlSystem.Migrations
{
    /// <inheritdoc />
    public partial class RelationPetCustomerAndCustomerAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Customers_CustomerId",
                table: "Agendas");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Agendas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Customers_CustomerId",
                table: "Agendas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Customers_CustomerId",
                table: "Agendas");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Agendas",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Customers_CustomerId",
                table: "Agendas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
