using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stables",
                columns: table => new
                {
                    StableId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StableName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Colors = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stables", x => x.StableId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Length = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    HorseId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorseName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registration = table.Column<int>(type: "int", nullable: false),
                    StableId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.HorseId);
                    table.ForeignKey(
                        name: "FK_Horses_Stables_StableId",
                        column: x => x.StableId,
                        principalTable: "Stables",
                        principalColumn: "StableId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    TrainerId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StableId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.TrainerId);
                    table.ForeignKey(
                        name: "FK_Trainers_Stables_StableId",
                        column: x => x.StableId,
                        principalTable: "Stables",
                        principalColumn: "StableId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RaceName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrackName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RaceDate = table.Column<DateTime>(type: "date", nullable: true),
                    RaceTime = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_Tracks_TrackName",
                        column: x => x.TrackName,
                        principalTable: "Tracks",
                        principalColumn: "TrackName");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HorseOwner",
                columns: table => new
                {
                    HorsesHorseId = table.Column<string>(type: "varchar(15)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OwnersOwnerId = table.Column<string>(type: "varchar(15)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorseOwner", x => new { x.HorsesHorseId, x.OwnersOwnerId });
                    table.ForeignKey(
                        name: "FK_HorseOwner_Horses_HorsesHorseId",
                        column: x => x.HorsesHorseId,
                        principalTable: "Horses",
                        principalColumn: "HorseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorseOwner_Owners_OwnersOwnerId",
                        column: x => x.OwnersOwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Owns",
                columns: table => new
                {
                    OwnerId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorseId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owns", x => new { x.OwnerId, x.HorseId });
                    table.ForeignKey(
                        name: "FK_Owns_Horses_HorseId",
                        column: x => x.HorseId,
                        principalTable: "Horses",
                        principalColumn: "HorseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owns_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RaceResults",
                columns: table => new
                {
                    RaceId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorseId = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Results = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prize = table.Column<float>(type: "float", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceResults", x => new { x.RaceId, x.HorseId });
                    table.ForeignKey(
                        name: "FK_RaceResults_Horses_HorseId",
                        column: x => x.HorseId,
                        principalTable: "Horses",
                        principalColumn: "HorseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceResults_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "FName", "LName" },
                values: new object[,]
                {
                    { "owner1", "Ahmed", "Saeed" },
                    { "owner10", "Khan", "Faisal" },
                    { "owner11", "Mohammed", "Jabr" },
                    { "owner12", "Mahmood", "Faleh" },
                    { "owner13", "Mohammed", "Yahya" },
                    { "owner14", "", "Sulaiman" },
                    { "owner15", "Ali", "Saeed" },
                    { "owner16", "Faisal", "Ahmed" },
                    { "owner17", "Mohammed", "Saud" },
                    { "owner18", "Mohammed", "Nazir" },
                    { "owner19", "Fahd", "Saleh" },
                    { "owner2", "Khalid", "Mohammed" },
                    { "owner20", "Naeem", "Mohammed" },
                    { "owner3", "Faisal", "Mohammed" },
                    { "owner4", "Abdul Rahman", "Fahd" },
                    { "owner5", "", "Nasr" },
                    { "owner6", "Sheikh", "Mohammed" },
                    { "owner7", "Ahmed", "Abed" },
                    { "owner8", "", "Mashour" },
                    { "owner9", "Sheikh", "Said" }
                });

            migrationBuilder.InsertData(
                table: "Stables",
                columns: new[] { "StableId", "Colors", "Location", "StableName" },
                values: new object[,]
                {
                    { "stable1", "orange", "Riyadh", "Zobair Farm" },
                    { "stable2", "kiwi", "Dubai", "Zayed Farm" },
                    { "stable3", "cinnamon", "Jeddah", "Zahra Farm" },
                    { "stable4", "lemon", "Jubail", "Sunny Stables" },
                    { "stable5", "lemon", "Ajman", "Ajman Stables" },
                    { "stable6", "bright blue", "Dubai", "Dubai Stables" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackName", "Length", "Location" },
                values: new object[,]
                {
                    { "Bahrain", 18, "BH" },
                    { "Dhahran", 20, "SA" },
                    { "Doha", 20, "QT" },
                    { "Dubai", 17, "UE" },
                    { "Jeddah", 19, "SA" },
                    { "Jubail", 15, "SA" },
                    { "Riyadh", 22, "SA" },
                    { "Sharjah", 20, "UE" },
                    { "Yanbu", 18, "SA" }
                });

            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "HorseId", "Age", "Gender", "HorseName", "Registration", "StableId" },
                values: new object[,]
                {
                    { "horse1", 2, "C", "Warrior", 11111, "stable1" },
                    { "horse10", 6, "G", "Formula One", 10101, "stable2" },
                    { "horse11", 3, "C", "Frisky Frolic", 11011, "stable4" },
                    { "horse12", 3, "F", "Fantastic", 12121, "stable2" },
                    { "horse13", 2, "C", "Midnight", 13131, "stable3" },
                    { "horse14", 4, "S", "Running Wild", 14141, "stable2" },
                    { "horse15", 3, "C", "FastOffMyFeet", 15151, "stable1" },
                    { "horse16", 2, "C", "Slow Poke", 16161, "stable3" },
                    { "horse17", 3, "F", "Slinger", 17171, "stable2" },
                    { "horse18", 5, "M", "Sublime", 18181, "stable6" },
                    { "horse19", 4, "G", "Front Runner", 19191, "stable4" },
                    { "horse2", 2, "F", "Conquerer", 22222, "stable6" },
                    { "horse20", 3, "C", "Night", 20200, "stable1" },
                    { "horse21", 3, "F", "Negative", 21210, "stable3" },
                    { "horse22", 2, "C", "Lightening", 22220, "stable6" },
                    { "horse23", 4, "G", "Lazy Loser", 23230, "stable1" },
                    { "horse24", 2, "C", "Leaping Lizard", 24240, "stable1" },
                    { "horse25", 3, "F", "Beautiful Brown", 25250, "stable6" },
                    { "horse26", 5, "M", "Sick Winner", 26260, "stable2" },
                    { "horse3", 3, "C", "Dove of Peace", 33333, "stable1" },
                    { "horse4", 3, "F", "Ever Faster", 44444, "stable3" },
                    { "horse5", 2, "C", "Slow Winner", 55555, "stable3" },
                    { "horse6", 2, "F", "Windrunner", 66666, "stable2" },
                    { "horse7", 4, "M", "Catapult", 77777, "stable6" },
                    { "horse8", 2, "C", "Flying Force", 88888, "stable4" },
                    { "horse9", 2, "F", "Laggard", 99999, "stable4" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RaceId", "RaceDate", "RaceName", "RaceTime", "TrackName" },
                values: new object[,]
                {
                    { "race1", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kings Cup", new TimeSpan(0, 14, 0, 0, 0), "Riyadh" },
                    { "race10", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 12, 30, 0, 0), "Sharjah" },
                    { "race11", new DateTime(2007, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old fillies", new TimeSpan(0, 10, 30, 0, 0), "Dubai" },
                    { "race12", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 11, 30, 0, 0), "Yanbu" },
                    { "race13", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old fillies", new TimeSpan(0, 11, 0, 0, 0), "Yanbu" },
                    { "race14", new DateTime(2007, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 10, 0, 0, 0), "Dhahran" },
                    { "race15", new DateTime(2007, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 15, 0, 0, 0), "Dubai" },
                    { "race16", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 14, 30, 0, 0), "Yanbu" },
                    { "race17", new DateTime(2007, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 13, 0, 0, 0), "Doha" },
                    { "race18", new DateTime(2007, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old fillies", new TimeSpan(0, 8, 0, 0, 0), "Sharjah" },
                    { "race19", new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old colts", new TimeSpan(0, 11, 0, 0, 0), "Dhahran" },
                    { "race2", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old fillies", new TimeSpan(0, 13, 0, 0, 0), "Doha" },
                    { "race20", new DateTime(2007, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 8, 30, 0, 0), "Jeddah" },
                    { "race21", new DateTime(2007, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 14, 30, 0, 0), "Riyadh" },
                    { "race22", new DateTime(2007, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 15, 0, 0, 0), "Dhahran" },
                    { "race23", new DateTime(2007, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old fillies", new TimeSpan(0, 9, 30, 0, 0), "Jeddah" },
                    { "race24", new DateTime(2007, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 13, 30, 0, 0), "Jubail" },
                    { "race25", new DateTime(2007, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 10, 0, 0, 0), "Jeddah" },
                    { "race26", new DateTime(2007, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 12, 30, 0, 0), "Yanbu" },
                    { "race27", new DateTime(2007, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 14, 0, 0, 0), "Dubai" },
                    { "race28", new DateTime(2007, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old fillies", new TimeSpan(0, 8, 30, 0, 0), "Jeddah" },
                    { "race29", new DateTime(2007, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 8, 0, 0, 0), "Bahrain" },
                    { "race3", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old colts", new TimeSpan(0, 13, 30, 0, 0), "Doha" },
                    { "race30", new DateTime(2007, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 9, 30, 0, 0), "Dhahran" },
                    { "race31", new DateTime(2007, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 9, 0, 0, 0), "Dhahran" },
                    { "race32", new DateTime(2007, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old colts", new TimeSpan(0, 11, 0, 0, 0), "Jubail" },
                    { "race33", new DateTime(2007, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 13, 0, 0, 0), "Bahrain" },
                    { "race34", new DateTime(2007, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 12, 0, 0, 0), "Dubai" },
                    { "race35", new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 10, 30, 0, 0), "Dubai" },
                    { "race36", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old colts", new TimeSpan(0, 14, 30, 0, 0), "Jeddah" },
                    { "race4", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 12, 0, 0, 0), "Doha" },
                    { "race5", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claiming Stake", new TimeSpan(0, 12, 30, 0, 0), "Sharjah" },
                    { "race6", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-year-old fillies", new TimeSpan(0, 12, 30, 0, 0), "Jubail" },
                    { "race7", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handicap", new TimeSpan(0, 9, 30, 0, 0), "Jubail" },
                    { "race8", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old colts", new TimeSpan(0, 10, 30, 0, 0), "Riyadh" },
                    { "race9", new DateTime(2007, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-year-old fillies", new TimeSpan(0, 11, 30, 0, 0), "Jubail" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "TrainerId", "FName", "LName", "StableId" },
                values: new object[,]
                {
                    { "trainer1", "Fahd", "Mohammed", "stable2" },
                    { "trainer2", "Saeed", "Saleh", "stable1" },
                    { "trainer3", "Raad", "Ali", "stable4" },
                    { "trainer4", "Wasim", "Sayed", "stable3" },
                    { "trainer5", "Ali", "Ahmed", "stable3" },
                    { "trainer6", "Salah", "Faisal", "stable5" },
                    { "trainer7", "Ahmed", "Hamid", "stable6" },
                    { "trainer8", "Ahmed", "Khalid", "stable6" }
                });

            migrationBuilder.InsertData(
                table: "Owns",
                columns: new[] { "HorseId", "OwnerId" },
                values: new object[,]
                {
                    { "horse5", "owner1" },
                    { "horse6", "owner1" },
                    { "horse23", "owner10" },
                    { "horse20", "owner12" },
                    { "horse24", "owner12" },
                    { "horse5", "owner12" },
                    { "horse25", "owner13" },
                    { "horse1", "owner14" },
                    { "horse5", "owner14" },
                    { "horse14", "owner15" },
                    { "horse15", "owner15" },
                    { "horse12", "owner16" },
                    { "horse13", "owner17" },
                    { "horse10", "owner18" },
                    { "horse8", "owner19" },
                    { "horse26", "owner2" },
                    { "horse3", "owner2" },
                    { "horse4", "owner2" },
                    { "horse9", "owner2" },
                    { "horse16", "owner20" },
                    { "horse7", "owner20" },
                    { "horse10", "owner3" },
                    { "horse2", "owner3" },
                    { "horse11", "owner4" },
                    { "horse17", "owner4" },
                    { "horse6", "owner5" },
                    { "horse19", "owner6" },
                    { "horse21", "owner7" },
                    { "horse22", "owner7" },
                    { "horse18", "owner8" },
                    { "horse23", "owner9" }
                });

            migrationBuilder.InsertData(
                table: "RaceResults",
                columns: new[] { "HorseId", "RaceId", "Prize", "Results" },
                values: new object[,]
                {
                    { "horse11", "race1", 200000f, "second" },
                    { "horse15", "race1", 500000f, "third" },
                    { "horse3", "race1", 500000f, "first" },
                    { "horse18", "race10", 500f, "fourth" },
                    { "horse12", "race11", 50000f, "first" },
                    { "horse17", "race11", 25000f, "second" },
                    { "horse21", "race11", 10000f, "fourth" },
                    { "horse14", "race12", 6000f, "first" },
                    { "horse18", "race12", 5000f, "second" },
                    { "horse12", "race13", 30000f, "third" },
                    { "horse25", "race13", 100000f, "first" },
                    { "horse4", "race13", 50000f, "second" },
                    { "horse23", "race14", 25000f, "first" },
                    { "horse26", "race14", 20000f, "second" },
                    { "horse11", "race15", 10000f, "second" },
                    { "horse24", "race15", 8000f, "third" },
                    { "horse10", "race16", 5000f, "second" },
                    { "horse14", "race16", 4000f, "third" },
                    { "horse10", "race17", 1100f, "second" },
                    { "horse7", "race17", 15000f, "first" },
                    { "horse6", "race18", 70000f, "first" },
                    { "horse1", "race19", 80000f, "second" },
                    { "horse22", "race19", 1000000f, "first" },
                    { "horse8", "race19", 60000f, "third" },
                    { "horse2", "race2", 50000f, "second" },
                    { "horse20", "race2", 20000f, "third" },
                    { "horse6", "race2", 100000f, "first" },
                    { "horse10", "race20", 500f, "fourth" },
                    { "horse14", "race20", 1000f, "second" },
                    { "horse23", "race20", 1500f, "first" },
                    { "horse26", "race20", 800f, "third" },
                    { "horse15", "race21", 55000f, "second" },
                    { "horse24", "race21", 70000f, "first" },
                    { "horse3", "race21", 40000f, "third" },
                    { "horse18", "race22", 10000f, "first" },
                    { "horse19", "race22", 8000f, "second" },
                    { "horse25", "race23", 150000f, "first" },
                    { "horse7", "race24", 10000f, "first" },
                    { "horse10", "race25", 8000f, "second" },
                    { "horse20", "race25", 2000f, "fourth" },
                    { "horse20", "race26", 2000f, "fourth" },
                    { "horse24", "race26", 8000f, "first" },
                    { "horse18", "race27", 70000f, "first" },
                    { "horse23", "race27", 40000f, "third" },
                    { "horse25", "race28", 90000f, "first" },
                    { "horse15", "race29", 80000f, "first" },
                    { "horse24", "race29", 50000f, "third" },
                    { "horse3", "race29", 65000f, "second" },
                    { "horse1", "race3", 20000f, "third" },
                    { "horse22", "race3", 70000f, "first" },
                    { "horse5", "race3", 50000f, "second" },
                    { "horse10", "race30", 500f, "fourth" },
                    { "horse14", "race30", 1500f, "second" },
                    { "horse10", "race31", 30000f, "fourth" },
                    { "horse23", "race31", 50000f, "third" },
                    { "horse26", "race31", 70000f, "second" },
                    { "horse7", "race31", 90000f, "first" },
                    { "horse13", "race32", 125000f, "second" },
                    { "horse16", "race32", 100000f, "third" },
                    { "horse22", "race32", 150000f, "first" },
                    { "horse23", "race33", 1700f, "second" },
                    { "horse26", "race33", 1200f, "third" },
                    { "horse11", "race34", 50000f, "first" },
                    { "horse15", "race34", 30000f, "second" },
                    { "horse19", "race35", 25000f, "second" },
                    { "horse7", "race35", 45000f, "first" },
                    { "horse11", "race36", 100000f, "first" },
                    { "horse15", "race36", 80000f, "second" },
                    { "horse20", "race36", 50000f, "third" },
                    { "horse14", "race4", 0f, "no show" },
                    { "horse18", "race4", 0f, "no show" },
                    { "horse19", "race4", 50000f, "first" },
                    { "horse25", "race6", 5000f, "first" },
                    { "horse7", "race7", 2000f, "second" },
                    { "horse11", "race9", 0f, "last" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorseOwner_OwnersOwnerId",
                table: "HorseOwner",
                column: "OwnersOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Horses_StableId",
                table: "Horses",
                column: "StableId");

            migrationBuilder.CreateIndex(
                name: "IX_Owns_HorseId",
                table: "Owns",
                column: "HorseId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceResults_HorseId",
                table: "RaceResults",
                column: "HorseId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_TrackName",
                table: "Races",
                column: "TrackName");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_StableId",
                table: "Trainers",
                column: "StableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorseOwner");

            migrationBuilder.DropTable(
                name: "Owns");

            migrationBuilder.DropTable(
                name: "RaceResults");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Stables");

            migrationBuilder.DropTable(
                name: "Tracks");
        }
    }
}
