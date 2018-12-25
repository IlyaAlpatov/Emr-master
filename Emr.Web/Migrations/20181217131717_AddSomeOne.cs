using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emr.Web.Migrations
{
    public partial class AddSomeOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Diagnoses_DiagnosGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Medics_MedicGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Patients_PatientGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Recipes_RecipeGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_DiagnosGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_MedicGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_MedicalExaminations_PatientGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Passport",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Pob",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "Snils",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "MeGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "DiagnosGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "InspectionDate",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "InspectionResult",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "MedicGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "Symptom",
                table: "MedicalExaminations");

            migrationBuilder.DropColumn(
                name: "FileEpmr",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.RenameColumn(
                name: "Snils",
                table: "Patients",
                newName: "PlaceOfWork");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Metrics",
                newName: "MetricDate");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Medics",
                newName: "Subdivision");

            migrationBuilder.RenameColumn(
                name: "Pob",
                table: "Medics",
                newName: "Specialty");

            migrationBuilder.RenameColumn(
                name: "Patronymic",
                table: "Medics",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "Medics",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Medics",
                newName: "EducationalInstitution");

            migrationBuilder.RenameColumn(
                name: "RecipeGuid",
                table: "MedicalExaminations",
                newName: "PatientRecordGuid");

            migrationBuilder.RenameColumn(
                name: "PatientGuid",
                table: "MedicalExaminations",
                newName: "DragGuid");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalExaminations_RecipeGuid",
                table: "MedicalExaminations",
                newName: "IX_MedicalExaminations_PatientRecordGuid");

            migrationBuilder.RenameColumn(
                name: "TextEpmr",
                table: "ElectronicPersonalMedicalRecords",
                newName: "Symptons");

            migrationBuilder.AddColumn<Guid>(
                name: "ElectronicPersonalMedicalRecordGuid",
                table: "Recipes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MedicGuid",
                table: "Recipes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PatientGuid",
                table: "Recipes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "RecipeDate",
                table: "Recipes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Recipes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Recipes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShelfLife",
                table: "Recipes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "AdminGuid",
                table: "Patients",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClientGuid",
                table: "Patients",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "HealthInsurancePolicy",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LevelOfEducation",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AdminGuid",
                table: "Medics",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClientGuid",
                table: "Medics",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ElectronicPersonalMedicalRecords",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ReceptionResults",
                table: "ElectronicPersonalMedicalRecords",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ResearchResultGuid",
                table: "ElectronicPersonalMedicalRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccinationResultGuid",
                table: "ElectronicPersonalMedicalRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations",
                columns: new[] { "DragGuid", "PatientRecordGuid" });

            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    BloodTypeGuid = table.Column<Guid>(nullable: false),
                    BloodTypeNumber = table.Column<int>(nullable: false),
                    RedCellType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.BloodTypeGuid);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientGuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 100, nullable: false),
                    Snils = table.Column<int>(maxLength: 100, nullable: false),
                    Dob = table.Column<DateTime>(maxLength: 100, nullable: false),
                    Pob = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<string>(maxLength: 100, nullable: false),
                    Passport = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<int>(maxLength: 100, nullable: false),
                    Mail = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientGuid);
                });

            migrationBuilder.CreateTable(
                name: "HealthGroup",
                columns: table => new
                {
                    HealthGroupGuid = table.Column<Guid>(nullable: false),
                    NameHealthGroup = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthGroup", x => x.HealthGroupGuid);
                });

            migrationBuilder.CreateTable(
                name: "ResearchResult",
                columns: table => new
                {
                    ResearchResultGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    ResearchGuid = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Result = table.Column<string>(maxLength: 100, nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchResult", x => x.ResearchResultGuid);
                    table.ForeignKey(
                        name: "FK_ResearchResult_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchResult_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchResult_Researches_ResearchGuid",
                        column: x => x.ResearchGuid,
                        principalTable: "Researches",
                        principalColumn: "ResearchGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RhesusFactors",
                columns: table => new
                {
                    RhesusFactorGuid = table.Column<Guid>(nullable: false),
                    RhesusFactorView = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhesusFactors", x => x.RhesusFactorGuid);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfDisability",
                columns: table => new
                {
                    TypeOfDisabilityGuid = table.Column<Guid>(nullable: false),
                    View = table.Column<string>(nullable: false),
                    DisabilityGroup = table.Column<string>(nullable: false),
                    TypeOfViolation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDisability", x => x.TypeOfDisabilityGuid);
                });

            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    VaccinationGuid = table.Column<Guid>(nullable: false),
                    NameVaccination = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccination", x => x.VaccinationGuid);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminGuid = table.Column<Guid>(nullable: false),
                    ClientGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminGuid);
                    table.ForeignKey(
                        name: "FK_Admins_Clients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "Clients",
                        principalColumn: "ClientGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disability",
                columns: table => new
                {
                    DisabilityGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    TypeOfDisabilityGuid = table.Column<Guid>(nullable: false),
                    Reasons = table.Column<string>(maxLength: 100, nullable: false),
                    EstablishmentDate = table.Column<DateTime>(nullable: false),
                    LastSurveyDate = table.Column<DateTime>(nullable: false),
                    DateOfWithdrawal = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disability", x => x.DisabilityGuid);
                    table.ForeignKey(
                        name: "FK_Disability_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disability_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disability_TypeOfDisability_TypeOfDisabilityGuid",
                        column: x => x.TypeOfDisabilityGuid,
                        principalTable: "TypeOfDisability",
                        principalColumn: "TypeOfDisabilityGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationResult",
                columns: table => new
                {
                    VaccinationResultGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    VaccinationGuid = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Series = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Dose = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationResult", x => x.VaccinationResultGuid);
                    table.ForeignKey(
                        name: "FK_VaccinationResult_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinationResult_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccinationResult_Vaccination_VaccinationGuid",
                        column: x => x.VaccinationGuid,
                        principalTable: "Vaccination",
                        principalColumn: "VaccinationGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientRecords",
                columns: table => new
                {
                    PatientRecordGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    BloodTypeGuid = table.Column<Guid>(nullable: false),
                    RhesusFactorGuid = table.Column<Guid>(nullable: false),
                    HealthGroupGuid = table.Column<Guid>(nullable: false),
                    Conclusion = table.Column<string>(maxLength: 100, nullable: true),
                    DisabilityGuid = table.Column<Guid>(nullable: false),
                    PatientRecordDate = table.Column<DateTime>(nullable: false),
                    SocialStatus = table.Column<string>(maxLength: 100, nullable: true),
                    Smoking = table.Column<bool>(nullable: false),
                    Alcoholism = table.Column<bool>(nullable: false),
                    Addiction = table.Column<bool>(nullable: false),
                    AllergicHistory = table.Column<string>(maxLength: 100, nullable: true),
                    Characteristics = table.Column<string>(maxLength: 100, nullable: true),
                    ChildrenDiseases = table.Column<string>(maxLength: 100, nullable: true),
                    FamilyHistory = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecords", x => x.PatientRecordGuid);
                    table.ForeignKey(
                        name: "FK_PatientRecords_BloodTypes_BloodTypeGuid",
                        column: x => x.BloodTypeGuid,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Disability_DisabilityGuid",
                        column: x => x.DisabilityGuid,
                        principalTable: "Disability",
                        principalColumn: "DisabilityGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_HealthGroup_HealthGroupGuid",
                        column: x => x.HealthGroupGuid,
                        principalTable: "HealthGroup",
                        principalColumn: "HealthGroupGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientRecords_RhesusFactors_RhesusFactorGuid",
                        column: x => x.RhesusFactorGuid,
                        principalTable: "RhesusFactors",
                        principalColumn: "RhesusFactorGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ElectronicPersonalMedicalRecordGuid",
                table: "Recipes",
                column: "ElectronicPersonalMedicalRecordGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MedicGuid",
                table: "Recipes",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_PatientGuid",
                table: "Recipes",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AdminGuid",
                table: "Patients",
                column: "AdminGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ClientGuid",
                table: "Patients",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Medics_AdminGuid",
                table: "Medics",
                column: "AdminGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Medics_ClientGuid",
                table: "Medics",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicPersonalMedicalRecords_DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "DiagnosGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicPersonalMedicalRecords_ResearchResultGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "ResearchResultGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicPersonalMedicalRecords_VaccinationResultGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "VaccinationResultGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ClientGuid",
                table: "Admins",
                column: "ClientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Disability_MedicGuid",
                table: "Disability",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Disability_PatientGuid",
                table: "Disability",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Disability_TypeOfDisabilityGuid",
                table: "Disability",
                column: "TypeOfDisabilityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_BloodTypeGuid",
                table: "PatientRecords",
                column: "BloodTypeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_DisabilityGuid",
                table: "PatientRecords",
                column: "DisabilityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_HealthGroupGuid",
                table: "PatientRecords",
                column: "HealthGroupGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_MedicGuid",
                table: "PatientRecords",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_PatientGuid",
                table: "PatientRecords",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRecords_RhesusFactorGuid",
                table: "PatientRecords",
                column: "RhesusFactorGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchResult_MedicGuid",
                table: "ResearchResult",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchResult_PatientGuid",
                table: "ResearchResult",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchResult_ResearchGuid",
                table: "ResearchResult",
                column: "ResearchGuid");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationResult_MedicGuid",
                table: "VaccinationResult",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationResult_PatientGuid",
                table: "VaccinationResult",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationResult_VaccinationGuid",
                table: "VaccinationResult",
                column: "VaccinationGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_Diagnoses_DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "DiagnosGuid",
                principalTable: "Diagnoses",
                principalColumn: "DiagnosGuid",
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
                name: "FK_MedicalExaminations_Drags_DragGuid",
                table: "MedicalExaminations",
                column: "DragGuid",
                principalTable: "Drags",
                principalColumn: "DragGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_PatientRecords_PatientRecordGuid",
                table: "MedicalExaminations",
                column: "PatientRecordGuid",
                principalTable: "PatientRecords",
                principalColumn: "PatientRecordGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medics_Admins_AdminGuid",
                table: "Medics",
                column: "AdminGuid",
                principalTable: "Admins",
                principalColumn: "AdminGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medics_Clients_ClientGuid",
                table: "Medics",
                column: "ClientGuid",
                principalTable: "Clients",
                principalColumn: "ClientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Admins_AdminGuid",
                table: "Patients",
                column: "AdminGuid",
                principalTable: "Admins",
                principalColumn: "AdminGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Clients_ClientGuid",
                table: "Patients",
                column: "ClientGuid",
                principalTable: "Clients",
                principalColumn: "ClientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_ElectronicPersonalMedicalRecords_ElectronicPersonal~",
                table: "Recipes",
                column: "ElectronicPersonalMedicalRecordGuid",
                principalTable: "ElectronicPersonalMedicalRecords",
                principalColumn: "EpmrGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Medics_MedicGuid",
                table: "Recipes",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Patients_PatientGuid",
                table: "Recipes",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_Diagnoses_DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_ResearchResult_ResearchRes~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicPersonalMedicalRecords_VaccinationResult_Vaccinat~",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_Drags_DragGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalExaminations_PatientRecords_PatientRecordGuid",
                table: "MedicalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_Medics_Admins_AdminGuid",
                table: "Medics");

            migrationBuilder.DropForeignKey(
                name: "FK_Medics_Clients_ClientGuid",
                table: "Medics");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Admins_AdminGuid",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Clients_ClientGuid",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_ElectronicPersonalMedicalRecords_ElectronicPersonal~",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Medics_MedicGuid",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Patients_PatientGuid",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "PatientRecords");

            migrationBuilder.DropTable(
                name: "ResearchResult");

            migrationBuilder.DropTable(
                name: "VaccinationResult");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "Disability");

            migrationBuilder.DropTable(
                name: "HealthGroup");

            migrationBuilder.DropTable(
                name: "RhesusFactors");

            migrationBuilder.DropTable(
                name: "Vaccination");

            migrationBuilder.DropTable(
                name: "TypeOfDisability");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ElectronicPersonalMedicalRecordGuid",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_MedicGuid",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_PatientGuid",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AdminGuid",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ClientGuid",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Medics_AdminGuid",
                table: "Medics");

            migrationBuilder.DropIndex(
                name: "IX_Medics_ClientGuid",
                table: "Medics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicPersonalMedicalRecords_DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicPersonalMedicalRecords_ResearchResultGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicPersonalMedicalRecords_VaccinationResultGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropColumn(
                name: "ElectronicPersonalMedicalRecordGuid",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "MedicGuid",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PatientGuid",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeDate",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ShelfLife",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "AdminGuid",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ClientGuid",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HealthInsurancePolicy",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LevelOfEducation",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AdminGuid",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "ClientGuid",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropColumn(
                name: "DiagnosGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropColumn(
                name: "ReceptionResults",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropColumn(
                name: "ResearchResultGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropColumn(
                name: "VaccinationResultGuid",
                table: "ElectronicPersonalMedicalRecords");

            migrationBuilder.RenameColumn(
                name: "PlaceOfWork",
                table: "Patients",
                newName: "Snils");

            migrationBuilder.RenameColumn(
                name: "MetricDate",
                table: "Metrics",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Subdivision",
                table: "Medics",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Medics",
                newName: "Pob");

            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "Medics",
                newName: "Patronymic");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Medics",
                newName: "Passport");

            migrationBuilder.RenameColumn(
                name: "EducationalInstitution",
                table: "Medics",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PatientRecordGuid",
                table: "MedicalExaminations",
                newName: "RecipeGuid");

            migrationBuilder.RenameColumn(
                name: "DragGuid",
                table: "MedicalExaminations",
                newName: "PatientGuid");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalExaminations_PatientRecordGuid",
                table: "MedicalExaminations",
                newName: "IX_MedicalExaminations_RecipeGuid");

            migrationBuilder.RenameColumn(
                name: "Symptons",
                table: "ElectronicPersonalMedicalRecords",
                newName: "TextEpmr");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Passport",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pob",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Patients",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Medics",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "Medics",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Medics",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Snils",
                table: "Medics",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "MeGuid",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "MedicalExaminations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "DiagnosGuid",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "InspectionDate",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InspectionResult",
                table: "MedicalExaminations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "MedicGuid",
                table: "MedicalExaminations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Symptom",
                table: "MedicalExaminations",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileEpmr",
                table: "ElectronicPersonalMedicalRecords",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalExaminations",
                table: "MedicalExaminations",
                column: "MeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_DiagnosGuid",
                table: "MedicalExaminations",
                column: "DiagnosGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_MedicGuid",
                table: "MedicalExaminations",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_PatientGuid",
                table: "MedicalExaminations",
                column: "PatientGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Diagnoses_DiagnosGuid",
                table: "MedicalExaminations",
                column: "DiagnosGuid",
                principalTable: "Diagnoses",
                principalColumn: "DiagnosGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Medics_MedicGuid",
                table: "MedicalExaminations",
                column: "MedicGuid",
                principalTable: "Medics",
                principalColumn: "MedicGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Patients_PatientGuid",
                table: "MedicalExaminations",
                column: "PatientGuid",
                principalTable: "Patients",
                principalColumn: "PatientGuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalExaminations_Recipes_RecipeGuid",
                table: "MedicalExaminations",
                column: "RecipeGuid",
                principalTable: "Recipes",
                principalColumn: "RecipeGuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
