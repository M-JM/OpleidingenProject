using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpleidingenProject.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorieen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorieen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opleidingen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Niveau = table.Column<int>(nullable: false),
                    Taal = table.Column<int>(nullable: false),
                    AantalUren = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleidingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opleidingen_Categorieen_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorieen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AantalPlaatsen = table.Column<int>(nullable: false),
                    TypeLeerVorm = table.Column<int>(nullable: false),
                    Prijs = table.Column<int>(nullable: false),
                    StartDatum = table.Column<DateTime>(nullable: false),
                    EindDatum = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OpleidingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessies_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inschrijvingen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessieId = table.Column<int>(nullable: false),
                    CustomUserId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inschrijvingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inschrijvingen_AspNetUsers_CustomUserId",
                        column: x => x.CustomUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inschrijvingen_Sessies_SessieId",
                        column: x => x.SessieId,
                        principalTable: "Sessies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorieen",
                columns: new[] { "Id", "IsDeleted", "Naam" },
                values: new object[,]
                {
                    { 1, false, "Retail banking" },
                    { 2, false, "Verzekeringen" },
                    { 3, false, "Kredieten" },
                    { 4, false, "Duurzaamheid" },
                    { 5, false, "Boekhouding" },
                    { 6, false, "Corporate Banking" }
                });

            migrationBuilder.InsertData(
                table: "Opleidingen",
                columns: new[] { "Id", "AantalUren", "Beschrijving", "CategorieId", "IsDeleted", "Naam", "Niveau", "Taal" },
                values: new object[,]
                {
                    { 1, 60, "Korte introductie tot de wereld van verzekeringen", 2, false, "Verzekeringen voor beginners", 0, 0 },
                    { 2, 20, "Korte introductie tot de wereld van kredieten", 3, false, "Kredieten voor beginners", 0, 2 },
                    { 3, 50, "Duurzaam investeren is de toekomst.", 4, false, "Duurzaamheid, de wereld van morgen", 2, 1 },
                    { 5, 60, "Opleiding voor professionelen ", 5, false, "Fiscaliteit en boekhouding", 2, 2 },
                    { 4, 100, "Intensieve opleiding gaande van FX naar cash management", 6, false, "Kapitaal en markten", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sessies",
                columns: new[] { "Id", "AantalPlaatsen", "EindDatum", "IsDeleted", "OpleidingId", "Prijs", "StartDatum", "TypeLeerVorm" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2021, 6, 17, 10, 55, 20, 393, DateTimeKind.Local).AddTicks(9847), false, 1, 250, new DateTime(2021, 6, 11, 10, 55, 20, 388, DateTimeKind.Local).AddTicks(27), 1 },
                    { 2, 40, new DateTime(2021, 6, 14, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6605), false, 1, 150, new DateTime(2021, 6, 9, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6582), 2 },
                    { 3, 50, new DateTime(2021, 6, 21, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6699), false, 1, 150, new DateTime(2021, 6, 15, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6696), 2 },
                    { 4, 15, new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6706), false, 1, 102, new DateTime(2021, 6, 13, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6704), 1 },
                    { 5, 5, new DateTime(2021, 7, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6840), false, 2, 658, new DateTime(2021, 6, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6834), 3 },
                    { 6, 30, new DateTime(2021, 7, 2, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6847), false, 2, 850, new DateTime(2021, 6, 19, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6844), 0 },
                    { 7, 18, new DateTime(2021, 6, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6853), false, 2, 150, new DateTime(2021, 6, 15, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6850), 1 },
                    { 8, 10, new DateTime(2021, 6, 25, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6859), false, 3, 480, new DateTime(2021, 6, 14, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6856), 0 },
                    { 9, 18, new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6866), false, 3, 455, new DateTime(2021, 6, 13, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6862), 3 },
                    { 11, 50, new DateTime(2021, 6, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6878), false, 5, 975, new DateTime(2021, 6, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6875), 2 },
                    { 12, 40, new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6884), false, 5, 105, new DateTime(2021, 6, 22, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6881), 1 },
                    { 13, 60, new DateTime(2021, 7, 2, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6891), false, 5, 804, new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6887), 0 },
                    { 14, 80, new DateTime(2021, 8, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6897), false, 5, 642, new DateTime(2021, 7, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6894), 2 },
                    { 10, 30, new DateTime(2021, 6, 22, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6872), false, 4, 846, new DateTime(2021, 6, 16, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6869), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvingen_CustomUserId",
                table: "Inschrijvingen",
                column: "CustomUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvingen_SessieId",
                table: "Inschrijvingen",
                column: "SessieId");

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingen_CategorieId",
                table: "Opleidingen",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessies_OpleidingId",
                table: "Sessies",
                column: "OpleidingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Inschrijvingen");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sessies");

            migrationBuilder.DropTable(
                name: "Opleidingen");

            migrationBuilder.DropTable(
                name: "Categorieen");
        }
    }
}
