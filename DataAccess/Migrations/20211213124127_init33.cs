using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineName",
                table: "PrescriptionMedicines");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PrescriptionMedicines",
                newName: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicines_MedicineId",
                table: "PrescriptionMedicines",
                column: "MedicineId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicines_Medicines_MedicineId",
                table: "PrescriptionMedicines",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicines_Medicines_MedicineId",
                table: "PrescriptionMedicines");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionMedicines_MedicineId",
                table: "PrescriptionMedicines");

            migrationBuilder.RenameColumn(
                name: "MedicineId",
                table: "PrescriptionMedicines",
                newName: "Price");

            migrationBuilder.AddColumn<string>(
                name: "MedicineName",
                table: "PrescriptionMedicines",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
