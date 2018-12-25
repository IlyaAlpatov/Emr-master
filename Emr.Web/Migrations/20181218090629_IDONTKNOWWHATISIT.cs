using Microsoft.EntityFrameworkCore.Migrations;

namespace Emr.Web.Migrations
{
    public partial class IDONTKNOWWHATISIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disability_TypeOfDisability_TypeOfDisabilityGuid",
                table: "Disability");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_ResearchResult_ResearchRes~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_VaccinationResult_Vaccinat~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResult_Medics_MedicGuid",
                table: "ResearchResult");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResult_Patients_PatientGuid",
                table: "ResearchResult");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResult_Researches_ResearchGuid",
                table: "ResearchResult");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResult_Medics_MedicGuid",
                table: "VaccinationResult");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResult_Patients_PatientGuid",
                table: "VaccinationResult");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResult_Vaccination_VaccinationGuid",
                table: "VaccinationResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaccinationResult",
                table: "VaccinationResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaccination",
                table: "Vaccination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfDisability",
                table: "TypeOfDisability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearchResult",
                table: "ResearchResult");

            migrationBuilder.RenameTable(
                name: "VaccinationResult",
                newName: "VaccinationResults");

            migrationBuilder.RenameTable(
                name: "Vaccination",
                newName: "Vaccinations");

            migrationBuilder.RenameTable(
                name: "TypeOfDisability",
                newName: "TypeOfDisabilities");

            migrationBuilder.RenameTable(
                name: "ResearchResult",
                newName: "ResearchResults");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResult_VaccinationGuid",
                table: "VaccinationResults",
                newName: "IX_VaccinationResults_VaccinationGuid");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResult_PatientGuid",
                table: "VaccinationResults",
                newName: "IX_VaccinationResults_PatientGuid");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResult_MedicGuid",
                table: "VaccinationResults",
                newName: "IX_VaccinationResults_MedicGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResult_ResearchGuid",
                table: "ResearchResults",
                newName: "IX_ResearchResults_ResearchGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResult_PatientGuid",
                table: "ResearchResults",
                newName: "IX_ResearchResults_PatientGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResult_MedicGuid",
                table: "ResearchResults",
                newName: "IX_ResearchResults_MedicGuid");

            migrationBuilder.AlterColumn<string>(
                name: "HealthInsurancePolicy",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaccinationResults",
                table: "VaccinationResults",
                column: "VaccinationResultGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccinations",
                table: "Vaccinations",
                column: "VaccinationGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfDisabilities",
                table: "TypeOfDisabilities",
                column: "TypeOfDisabilityGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearchResults",
                table: "ResearchResults",
                column: "ResearchResultGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Disability_TypeOfDisabilities_TypeOfDisabilityGuid",
                table: "Disability",
                column: "TypeOfDisabilityGuid",
                principalTable: "TypeOfDisabilities",
                principalColumn: "TypeOfDisabilityGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_ResearchResults_ResearchRe~",
                table: "ElectronicPersonalMedicalRecords",
                column: "ResearchResultGuid",
                principalTable: "ResearchResults",
                principalColumn: "ResearchResultGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_VaccinationResults_Vaccina~",
                table: "ElectronicPersonalMedicalRecords",
                column: "VaccinationResultGuid",
                principalTable: "VaccinationResults",
                principalColumn: "VaccinationResultGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResults_Medics_MedicGuid",
                table: "ResearchResults",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResults_Patients_PatientGuid",
                table: "ResearchResults",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResults_Researches_ResearchGuid",
                table: "ResearchResults",
                column: "ResearchGuid",
                principalTable: "Researches",
                principalColumn: "ResearchGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResults_Medics_MedicGuid",
                table: "VaccinationResults",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResults_Patients_PatientGuid",
                table: "VaccinationResults",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResults_Vaccinations_VaccinationGuid",
                table: "VaccinationResults",
                column: "VaccinationGuid",
                principalTable: "Vaccinations",
                principalColumn: "VaccinationGuid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disability_TypeOfDisabilities_TypeOfDisabilityGuid",
                table: "Disability");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_ResearchResults_ResearchRe~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_VaccinationResults_Vaccina~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResults_Medics_MedicGuid",
                table: "ResearchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResults_Patients_PatientGuid",
                table: "ResearchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchResults_Researches_ResearchGuid",
                table: "ResearchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResults_Medics_MedicGuid",
                table: "VaccinationResults");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResults_Patients_PatientGuid",
                table: "VaccinationResults");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationResults_Vaccinations_VaccinationGuid",
                table: "VaccinationResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaccinations",
                table: "Vaccinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaccinationResults",
                table: "VaccinationResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfDisabilities",
                table: "TypeOfDisabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearchResults",
                table: "ResearchResults");

            migrationBuilder.RenameTable(
                name: "Vaccinations",
                newName: "Vaccination");

            migrationBuilder.RenameTable(
                name: "VaccinationResults",
                newName: "VaccinationResult");

            migrationBuilder.RenameTable(
                name: "TypeOfDisabilities",
                newName: "TypeOfDisability");

            migrationBuilder.RenameTable(
                name: "ResearchResults",
                newName: "ResearchResult");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResults_VaccinationGuid",
                table: "VaccinationResult",
                newName: "IX_VaccinationResult_VaccinationGuid");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResults_PatientGuid",
                table: "VaccinationResult",
                newName: "IX_VaccinationResult_PatientGuid");

            migrationBuilder.RenameIndex(
                name: "IX_VaccinationResults_MedicGuid",
                table: "VaccinationResult",
                newName: "IX_VaccinationResult_MedicGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResults_ResearchGuid",
                table: "ResearchResult",
                newName: "IX_ResearchResult_ResearchGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResults_PatientGuid",
                table: "ResearchResult",
                newName: "IX_ResearchResult_PatientGuid");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchResults_MedicGuid",
                table: "ResearchResult",
                newName: "IX_ResearchResult_MedicGuid");

            migrationBuilder.AlterColumn<int>(
                name: "HealthInsurancePolicy",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaccination",
                table: "Vaccination",
                column: "VaccinationGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaccinationResult",
                table: "VaccinationResult",
                column: "VaccinationResultGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfDisability",
                table: "TypeOfDisability",
                column: "TypeOfDisabilityGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearchResult",
                table: "ResearchResult",
                column: "ResearchResultGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Disability_TypeOfDisability_TypeOfDisabilityGuid",
                table: "Disability",
                column: "TypeOfDisabilityGuid",
                principalTable: "TypeOfDisability",
                principalColumn: "TypeOfDisabilityGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_ResearchResult_ResearchRes~",
                table: "ElectronicPersonalMedicalRecords",
                column: "ResearchResultGuid",
                principalTable: "ResearchResult",
                principalColumn: "ResearchResultGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_VaccinationResult_Vaccinat~",
                table: "ElectronicPersonalMedicalRecords",
                column: "VaccinationResultGuid",
                principalTable: "VaccinationResult",
                principalColumn: "VaccinationResultGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResult_Medics_MedicGuid",
                table: "ResearchResult",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResult_Patients_PatientGuid",
                table: "ResearchResult",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchResult_Researches_ResearchGuid",
                table: "ResearchResult",
                column: "ResearchGuid",
                principalTable: "Researches",
                principalColumn: "ResearchGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResult_Medics_MedicGuid",
                table: "VaccinationResult",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResult_Patients_PatientGuid",
                table: "VaccinationResult",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationResult_Vaccination_VaccinationGuid",
                table: "VaccinationResult",
                column: "VaccinationGuid",
                principalTable: "Vaccination",
                principalColumn: "VaccinationGuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
