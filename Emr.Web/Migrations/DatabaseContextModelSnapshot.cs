﻿// <auto-generated />
using System;
using Emr.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Emr.Web.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Emr.Database.Models.Admin", b =>
                {
                    b.Property<Guid>("AdminGuid");

                    b.Property<Guid>("ClientGuid");

                    b.HasKey("AdminGuid");

                    b.HasIndex("ClientGuid");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Emr.Database.Models.BloodType", b =>
                {
                    b.Property<Guid>("BloodTypeGuid");

                    b.Property<int>("BloodTypeNumber");

                    b.Property<string>("RedCellType")
                        .IsRequired();

                    b.HasKey("BloodTypeGuid");

                    b.ToTable("BloodTypes");
                });

            modelBuilder.Entity("Emr.Database.Models.Client", b =>
                {
                    b.Property<Guid>("ClientGuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Dob")
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Number")
                        .HasMaxLength(100);

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Pob")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("RoleId");

                    b.Property<int>("Snils")
                        .HasMaxLength(100);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ClientGuid");

                    b.HasIndex("RoleId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Emr.Database.Models.Diagnos", b =>
                {
                    b.Property<Guid>("DiagnosGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("NameDiagnos")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DiagnosGuid");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("Emr.Database.Models.Disability", b =>
                {
                    b.Property<Guid>("DisabilityGuid");

                    b.Property<DateTime>("DateOfWithdrawal");

                    b.Property<DateTime>("EstablishmentDate");

                    b.Property<DateTime>("LastSurveyDate");

                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("PatientGuid");

                    b.Property<string>("Reasons")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("TypeOfDisabilityGuid");

                    b.HasKey("DisabilityGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.HasIndex("TypeOfDisabilityGuid");

                    b.ToTable("Disability");
                });

            modelBuilder.Entity("Emr.Database.Models.Drag", b =>
                {
                    b.Property<Guid>("DragGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("NameDrug")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DragGuid");

                    b.ToTable("Drags");
                });

            modelBuilder.Entity("Emr.Database.Models.ElectronicPersonalMedicalRecord", b =>
                {
                    b.Property<Guid>("EpmrGuid");

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("DiagnosGuid");

                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("PatientGuid");

                    b.Property<string>("ReceptionResults")
                        .IsRequired();

                    b.Property<Guid>("ResearchResultGuid");

                    b.Property<DateTime>("Signing");

                    b.Property<string>("Symptons")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("VaccinationResultGuid");

                    b.HasKey("EpmrGuid");

                    b.HasIndex("DiagnosGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.HasIndex("ResearchResultGuid");

                    b.HasIndex("VaccinationResultGuid");

                    b.ToTable("ElectronicPersonalMedicalRecords");
                });

            modelBuilder.Entity("Emr.Database.Models.HealthGroup", b =>
                {
                    b.Property<Guid>("HealthGroupGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("NameHealthGroup")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("HealthGroupGuid");

                    b.ToTable("HealthGroups");
                });

            modelBuilder.Entity("Emr.Database.Models.Medic", b =>
                {
                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("AdminGuid");

                    b.Property<Guid>("ClientGuid");

                    b.Property<string>("EducationalInstitution")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Subdivision")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("MedicGuid");

                    b.HasIndex("AdminGuid");

                    b.HasIndex("ClientGuid");

                    b.ToTable("Medics");
                });

            modelBuilder.Entity("Emr.Database.Models.MedicalDrags", b =>
                {
                    b.Property<Guid>("DragGuid");

                    b.Property<Guid>("PatientRecordGuid");

                    b.HasKey("DragGuid", "PatientRecordGuid");

                    b.HasIndex("PatientRecordGuid");

                    b.ToTable("MedicalExaminations");
                });

            modelBuilder.Entity("Emr.Database.Models.Metric", b =>
                {
                    b.Property<Guid>("MetricGuid");

                    b.Property<int>("BodyTemperature");

                    b.Property<int>("DiastolicPressure");

                    b.Property<int>("Growth");

                    b.Property<int>("Mass");

                    b.Property<Guid>("MedicGuid");

                    b.Property<DateTime>("MetricDate");

                    b.Property<Guid>("PatientGuid");

                    b.Property<int>("Pulse");

                    b.Property<int>("RespiratoryRate");

                    b.Property<int>("SystolicPressure");

                    b.Property<int>("WaistCircumference");

                    b.HasKey("MetricGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.ToTable("Metrics");
                });

            modelBuilder.Entity("Emr.Database.Models.Patient", b =>
                {
                    b.Property<Guid>("PatientGuid");

                    b.Property<Guid>("AdminGuid");

                    b.Property<Guid>("ClientGuid");

                    b.Property<string>("HealthInsurancePolicy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("LevelOfEducation")
                        .HasMaxLength(100);

                    b.Property<int>("MaritalStatus")
                        .HasMaxLength(100);

                    b.Property<int>("PlaceOfWork")
                        .HasMaxLength(100);

                    b.HasKey("PatientGuid");

                    b.HasIndex("AdminGuid");

                    b.HasIndex("ClientGuid");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Emr.Database.Models.PatientRecord", b =>
                {
                    b.Property<Guid>("PatientRecordGuid");

                    b.Property<bool>("Addiction");

                    b.Property<bool>("Alcoholism");

                    b.Property<string>("AllergicHistory")
                        .HasMaxLength(100);

                    b.Property<Guid>("BloodTypeGuid");

                    b.Property<string>("Characteristics")
                        .HasMaxLength(100);

                    b.Property<string>("ChildrenDiseases")
                        .HasMaxLength(100);

                    b.Property<string>("Conclusion")
                        .HasMaxLength(100);

                    b.Property<Guid>("DisabilityGuid");

                    b.Property<string>("FamilyHistory")
                        .HasMaxLength(100);

                    b.Property<Guid>("HealthGroupGuid");

                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("PatientGuid");

                    b.Property<DateTime>("PatientRecordDate");

                    b.Property<Guid>("RhesusFactorGuid");

                    b.Property<bool>("Smoking");

                    b.Property<string>("SocialStatus")
                        .HasMaxLength(100);

                    b.HasKey("PatientRecordGuid");

                    b.HasIndex("BloodTypeGuid");

                    b.HasIndex("DisabilityGuid");

                    b.HasIndex("HealthGroupGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.HasIndex("RhesusFactorGuid");

                    b.ToTable("PatientRecords");
                });

            modelBuilder.Entity("Emr.Database.Models.RecieptDrags", b =>
                {
                    b.Property<Guid>("DragGuid");

                    b.Property<Guid>("RecipeGuid");

                    b.HasKey("DragGuid", "RecipeGuid");

                    b.HasIndex("RecipeGuid");

                    b.ToTable("RecieptDragses");
                });

            modelBuilder.Entity("Emr.Database.Models.Recipe", b =>
                {
                    b.Property<Guid>("RecipeGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("ElectronicPersonalMedicalRecordGuid");

                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("PatientGuid");

                    b.Property<DateTime>("RecipeDate");

                    b.Property<string>("Room")
                        .IsRequired();

                    b.Property<string>("Series")
                        .IsRequired();

                    b.Property<string>("ShelfLife")
                        .IsRequired();

                    b.HasKey("RecipeGuid");

                    b.HasIndex("ElectronicPersonalMedicalRecordGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Emr.Database.Models.Research", b =>
                {
                    b.Property<Guid>("ResearchGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("NameResearch")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ResearchGuid");

                    b.ToTable("Researches");
                });

            modelBuilder.Entity("Emr.Database.Models.ResearchResult", b =>
                {
                    b.Property<Guid>("ResearchResultGuid");

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("MedicGuid");

                    b.Property<Guid>("PatientGuid");

                    b.Property<Guid>("ResearchGuid");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ResearchResultGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.HasIndex("ResearchGuid");

                    b.ToTable("ResearchResults");
                });

            modelBuilder.Entity("Emr.Database.Models.RhesusFactor", b =>
                {
                    b.Property<Guid>("RhesusFactorGuid");

                    b.Property<string>("RhesusFactorView")
                        .IsRequired();

                    b.HasKey("RhesusFactorGuid");

                    b.ToTable("RhesusFactors");
                });

            modelBuilder.Entity("Emr.Database.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Emr.Database.Models.TypeOfDisability", b =>
                {
                    b.Property<Guid>("TypeOfDisabilityGuid");

                    b.Property<string>("DisabilityGroup")
                        .IsRequired();

                    b.Property<string>("TypeOfViolation")
                        .IsRequired();

                    b.Property<string>("View")
                        .IsRequired();

                    b.HasKey("TypeOfDisabilityGuid");

                    b.ToTable("TypeOfDisabilities");
                });

            modelBuilder.Entity("Emr.Database.Models.User", b =>
                {
                    b.Property<Guid>("UserGuid");

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("RoleId");

                    b.HasKey("UserGuid");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Emr.Database.Models.Vaccination", b =>
                {
                    b.Property<Guid>("VaccinationGuid");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("NameVaccination")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("VaccinationGuid");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("Emr.Database.Models.VaccinationResult", b =>
                {
                    b.Property<Guid>("VaccinationResultGuid");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Dose")
                        .IsRequired();

                    b.Property<Guid>("MedicGuid");

                    b.Property<int>("Number");

                    b.Property<Guid>("PatientGuid");

                    b.Property<string>("Series")
                        .IsRequired();

                    b.Property<Guid>("VaccinationGuid");

                    b.HasKey("VaccinationResultGuid");

                    b.HasIndex("MedicGuid");

                    b.HasIndex("PatientGuid");

                    b.HasIndex("VaccinationGuid");

                    b.ToTable("VaccinationResults");
                });

            modelBuilder.Entity("Emr.Database.Models.Admin", b =>
                {
                    b.HasOne("Emr.Database.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Client", b =>
                {
                    b.HasOne("Emr.Database.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Disability", b =>
                {
                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.TypeOfDisability", "TypeOfDisability")
                        .WithMany()
                        .HasForeignKey("TypeOfDisabilityGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.ElectronicPersonalMedicalRecord", b =>
                {
                    b.HasOne("Emr.Database.Models.Diagnos", "Diagnos")
                        .WithMany()
                        .HasForeignKey("DiagnosGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.ResearchResult", "ResearchResult")
                        .WithMany()
                        .HasForeignKey("ResearchResultGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.VaccinationResult", "VaccinationResult")
                        .WithMany()
                        .HasForeignKey("VaccinationResultGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Medic", b =>
                {
                    b.HasOne("Emr.Database.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.MedicalDrags", b =>
                {
                    b.HasOne("Emr.Database.Models.Drag", "Drag")
                        .WithMany("MedicalDrags")
                        .HasForeignKey("DragGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.PatientRecord", "PatientRecord")
                        .WithMany("MedicalDrags")
                        .HasForeignKey("PatientRecordGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Metric", b =>
                {
                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Patient", b =>
                {
                    b.HasOne("Emr.Database.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.PatientRecord", b =>
                {
                    b.HasOne("Emr.Database.Models.BloodType", "BloodType")
                        .WithMany()
                        .HasForeignKey("BloodTypeGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Disability", "Disability")
                        .WithMany()
                        .HasForeignKey("DisabilityGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.HealthGroup", "HealthGroup")
                        .WithMany()
                        .HasForeignKey("HealthGroupGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.RhesusFactor", "RhesusFactor")
                        .WithMany()
                        .HasForeignKey("RhesusFactorGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.RecieptDrags", b =>
                {
                    b.HasOne("Emr.Database.Models.Drag", "Drag")
                        .WithMany("RecieptDragses")
                        .HasForeignKey("DragGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Recipe", "Recipe")
                        .WithMany("RecieptDragses")
                        .HasForeignKey("RecipeGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.Recipe", b =>
                {
                    b.HasOne("Emr.Database.Models.ElectronicPersonalMedicalRecord", "ElectronicPersonalMedicalRecord")
                        .WithMany()
                        .HasForeignKey("ElectronicPersonalMedicalRecordGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.ResearchResult", b =>
                {
                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Research", "Research")
                        .WithMany()
                        .HasForeignKey("ResearchGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.User", b =>
                {
                    b.HasOne("Emr.Database.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Emr.Database.Models.VaccinationResult", b =>
                {
                    b.HasOne("Emr.Database.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Emr.Database.Models.Vaccination", "Vaccination")
                        .WithMany()
                        .HasForeignKey("VaccinationGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
