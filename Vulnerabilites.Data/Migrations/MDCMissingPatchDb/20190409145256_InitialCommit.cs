using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vulnerabilities.Data.Migrations.MDCMissingPatchDb
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IP = table.Column<string>(maxLength: 50, nullable: false),
                    Systemname = table.Column<string>(name: "System name", maxLength: 100, nullable: false),
                    Systemstatus = table.Column<string>(name: "System status", maxLength: 50, nullable: false),
                    Systemtype = table.Column<string>(name: "System type", maxLength: 50, nullable: false),
                    OSVersion = table.Column<string>(name: "OS Version", maxLength: 70, nullable: true),
                    Technicalowner = table.Column<string>(name: "Technical owner", maxLength: 50, nullable: true),
                    Downtimecontact = table.Column<string>(name: "Downtime contact", maxLength: 70, nullable: true),
                    Lastdetecteddate = table.Column<DateTime>(name: "Last detected date", nullable: false),
                    Port = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vulnerabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Severity = table.Column<string>(maxLength: 5, nullable: false),
                    Lastdetecteddate = table.Column<DateTime>(name: "Last detected date", nullable: false),
                    CVE = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    QID = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vulnerabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServerVulnerability",
                columns: table => new
                {
                    VulnerabilityId = table.Column<int>(nullable: false),
                    ServerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerVulnerability", x => new { x.ServerId, x.VulnerabilityId });
                    table.ForeignKey(
                        name: "FK_ServerVulnerability_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerVulnerability_Vulnerabilities_VulnerabilityId",
                        column: x => x.VulnerabilityId,
                        principalTable: "Vulnerabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServerVulnerability_VulnerabilityId",
                table: "ServerVulnerability",
                column: "VulnerabilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerVulnerability");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Vulnerabilities");
        }
    }
}
