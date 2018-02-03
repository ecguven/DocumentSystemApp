using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DocumentSystemApp.Data.Migrations
{
    public partial class AddChangeRequestEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "ChangeRequestForms",
                columns: table => new
                {
                    ChangeRequestFormId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attachments = table.Column<string>(nullable: true),
                    CHAPrintName1 = table.Column<string>(nullable: true),
                    CHAPrintName2 = table.Column<string>(nullable: true),
                    CHAPrintName3 = table.Column<string>(nullable: true),
                    CHARole1 = table.Column<string>(nullable: true),
                    CHARole2 = table.Column<string>(nullable: true),
                    CHARole3 = table.Column<string>(nullable: true),
                    CHASignatureDate1 = table.Column<string>(nullable: true),
                    CHASignatureDate2 = table.Column<string>(nullable: true),
                    CHASignatureDate3 = table.Column<string>(nullable: true),
                    ChangeAccept = table.Column<bool>(nullable: false),
                    ChangeJustification = table.Column<string>(nullable: true),
                    ChangeReason = table.Column<string>(nullable: true),
                    ChangeReject = table.Column<bool>(nullable: false),
                    ChangeRequestDescrpition = table.Column<string>(nullable: true),
                    ChangeRequestID = table.Column<string>(nullable: true),
                    ChangeType1BugFixing = table.Column<bool>(nullable: false),
                    ChangeType1DesignChange = table.Column<bool>(nullable: false),
                    ChangeType1NewRequirement = table.Column<bool>(nullable: false),
                    ChangeType1Other = table.Column<bool>(nullable: false),
                    ChangeType1RequirementChange = table.Column<bool>(nullable: false),
                    ChangeType2Commercial = table.Column<bool>(nullable: false),
                    ChangeType2Investment = table.Column<bool>(nullable: false),
                    ChangeType2Text = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    ConfigurationFirmware = table.Column<bool>(nullable: false),
                    ConfigurationHardware = table.Column<bool>(nullable: false),
                    ConfigurationSoftware = table.Column<bool>(nullable: false),
                    ConfigurationSystemDocumentation = table.Column<bool>(nullable: false),
                    ConfigurationUserTraining = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    FAPrintName1 = table.Column<string>(nullable: true),
                    FAPrintName2 = table.Column<string>(nullable: true),
                    FAPrintName3 = table.Column<string>(nullable: true),
                    FARole1 = table.Column<string>(nullable: true),
                    FARole2 = table.Column<string>(nullable: true),
                    FARole3 = table.Column<string>(nullable: true),
                    FASignatureDate1 = table.Column<string>(nullable: true),
                    FASignatureDate2 = table.Column<string>(nullable: true),
                    FASignatureDate3 = table.Column<string>(nullable: true),
                    ImpactAssessmentDC = table.Column<string>(nullable: true),
                    ImpactAssessmentMA = table.Column<string>(nullable: true),
                    ImpactAssessmentOth = table.Column<string>(nullable: true),
                    ImpactAssessmentToA = table.Column<string>(nullable: true),
                    ImpactAssessmentTtE = table.Column<string>(nullable: true),
                    InitiatedBy = table.Column<string>(nullable: true),
                    PriorityEmergency = table.Column<bool>(nullable: false),
                    PriorityNextVersion = table.Column<bool>(nullable: false),
                    PriorityRoutine = table.Column<bool>(nullable: false),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    SPRS = table.Column<string>(nullable: true),
                    SignatureDate = table.Column<DateTime>(nullable: false),
                    SummaryofResults = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdaterUserId = table.Column<int>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    bImpactAssessmentDC = table.Column<bool>(nullable: false),
                    bImpactAssessmentMA = table.Column<bool>(nullable: false),
                    bImpactAssessmentOth = table.Column<bool>(nullable: false),
                    bImpactAssessmentToA = table.Column<bool>(nullable: false),
                    bImpactAssessmentTtE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeRequestForms", x => x.ChangeRequestFormId);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChangeRequestForms");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
