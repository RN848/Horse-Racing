using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddProcAndTrigger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Archive table for deleted horses
            // Ensure archive table exists
            migrationBuilder.Sql(@"
CREATE TABLE IF NOT EXISTS old_info (
    horseId      VARCHAR(15)  NOT NULL,
    horseName    VARCHAR(15)  NOT NULL,
    age          INT          NULL,
    gender       CHAR(1)      NULL,
    registration INT          NOT NULL,
    stableId     VARCHAR(15)  NOT NULL,
    deleted_at   DATETIME     NOT NULL,
    PRIMARY KEY (horseId, deleted_at)
);");
            
            // Drop old trigger/proc if they used wrong table
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_horse_before_delete;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteOwnerAndRelated;");

            // Re-create TRIGGER on **Horses** (plural)
            migrationBuilder.Sql(@"
CREATE TRIGGER trg_horse_before_delete
BEFORE DELETE ON `Horses`
FOR EACH ROW
BEGIN
    INSERT INTO old_info (horseId, horseName, age, gender, registration, stableId, deleted_at)
    VALUES (OLD.horseId, OLD.horseName, OLD.age, OLD.gender, OLD.registration, OLD.stableId, NOW());
END;");

            // Re-create PROCEDURE using **Horses**
            migrationBuilder.Sql(@"
CREATE PROCEDURE DeleteOwnerAndRelated(IN p_ownerId VARCHAR(15))
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    START TRANSACTION;

    /* remove ownership links */
    DELETE FROM `Owns`
    WHERE ownerId = p_ownerId;

    /* delete race results for orphan horses (no remaining owners) */
    DELETE rr FROM `RaceResults` rr
    JOIN (
        SELECT h.horseId
        FROM `Horses` h
        LEFT JOIN `Owns` ow ON ow.horseId = h.horseId
        WHERE ow.horseId IS NULL
    ) orphan ON orphan.horseId = rr.horseId;

    /* delete orphan horses (trigger will archive to old_info) */
    DELETE h FROM `Horses` h
    LEFT JOIN `Owns` ow ON ow.horseId = h.horseId
    WHERE ow.horseId IS NULL;

    /* finally delete the owner */
    DELETE FROM `Owners`
    WHERE ownerId = p_ownerId;

    COMMIT;
END;");       
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_horse_before_delete;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteOwnerAndRelated;");
        }
    }
}
