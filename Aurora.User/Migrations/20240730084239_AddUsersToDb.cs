using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aurora.User.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "EmailId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "User_1@gmail.com", "User_1", "Aurora" },
                    { 2, "User_2@gmail.com", "User_2", "Aurora" },
                    { 3, "User_3@gmail.com", "User_3", "Aurora" },
                    { 4, "User_4@gmail.com", "User_4", "Aurora" },
                    { 5, "User_5@gmail.com", "User_5", "Aurora" },
                    { 6, "User_6@gmail.com", "User_6", "Aurora" },
                    { 7, "User_7@gmail.com", "User_7", "Aurora" },
                    { 8, "User_8@gmail.com", "User_8", "Aurora" },
                    { 9, "User_9@gmail.com", "User_9", "Aurora" },
                    { 10, "User_10@gmail.com", "User_10", "Aurora" },
                    { 11, "User_11@gmail.com", "User_11", "Aurora" },
                    { 12, "User_12@gmail.com", "User_12", "Aurora" },
                    { 13, "User_13@gmail.com", "User_13", "Aurora" },
                    { 14, "User_14@gmail.com", "User_14", "Aurora" },
                    { 15, "User_15@gmail.com", "User_15", "Aurora" },
                    { 16, "User_16@gmail.com", "User_16", "Aurora" },
                    { 17, "User_17@gmail.com", "User_17", "Aurora" },
                    { 18, "User_18@gmail.com", "User_18", "Aurora" },
                    { 19, "User_19@gmail.com", "User_19", "Aurora" },
                    { 20, "User_20@gmail.com", "User_20", "Aurora" },
                    { 21, "User_21@gmail.com", "User_21", "Aurora" },
                    { 22, "User_22@gmail.com", "User_22", "Aurora" },
                    { 23, "User_23@gmail.com", "User_23", "Aurora" },
                    { 24, "User_24@gmail.com", "User_24", "Aurora" },
                    { 25, "User_25@gmail.com", "User_25", "Aurora" },
                    { 26, "User_26@gmail.com", "User_26", "Aurora" },
                    { 27, "User_27@gmail.com", "User_27", "Aurora" },
                    { 28, "User_28@gmail.com", "User_28", "Aurora" },
                    { 29, "User_29@gmail.com", "User_29", "Aurora" },
                    { 30, "User_30@gmail.com", "User_30", "Aurora" },
                    { 31, "User_31@gmail.com", "User_31", "Aurora" },
                    { 32, "User_32@gmail.com", "User_32", "Aurora" },
                    { 33, "User_33@gmail.com", "User_33", "Aurora" },
                    { 34, "User_34@gmail.com", "User_34", "Aurora" },
                    { 35, "User_35@gmail.com", "User_35", "Aurora" },
                    { 36, "User_36@gmail.com", "User_36", "Aurora" },
                    { 37, "User_37@gmail.com", "User_37", "Aurora" },
                    { 38, "User_38@gmail.com", "User_38", "Aurora" },
                    { 39, "User_39@gmail.com", "User_39", "Aurora" },
                    { 40, "User_40@gmail.com", "User_40", "Aurora" },
                    { 41, "User_41@gmail.com", "User_41", "Aurora" },
                    { 42, "User_42@gmail.com", "User_42", "Aurora" },
                    { 43, "User_43@gmail.com", "User_43", "Aurora" },
                    { 44, "User_44@gmail.com", "User_44", "Aurora" },
                    { 45, "User_45@gmail.com", "User_45", "Aurora" },
                    { 46, "User_46@gmail.com", "User_46", "Aurora" },
                    { 47, "User_47@gmail.com", "User_47", "Aurora" },
                    { 48, "User_48@gmail.com", "User_48", "Aurora" },
                    { 49, "User_49@gmail.com", "User_49", "Aurora" },
                    { 50, "User_50@gmail.com", "User_50", "Aurora" },
                    { 51, "User_51@gmail.com", "User_51", "Aurora" },
                    { 52, "User_52@gmail.com", "User_52", "Aurora" },
                    { 53, "User_53@gmail.com", "User_53", "Aurora" },
                    { 54, "User_54@gmail.com", "User_54", "Aurora" },
                    { 55, "User_55@gmail.com", "User_55", "Aurora" },
                    { 56, "User_56@gmail.com", "User_56", "Aurora" },
                    { 57, "User_57@gmail.com", "User_57", "Aurora" },
                    { 58, "User_58@gmail.com", "User_58", "Aurora" },
                    { 59, "User_59@gmail.com", "User_59", "Aurora" },
                    { 60, "User_60@gmail.com", "User_60", "Aurora" },
                    { 61, "User_61@gmail.com", "User_61", "Aurora" },
                    { 62, "User_62@gmail.com", "User_62", "Aurora" },
                    { 63, "User_63@gmail.com", "User_63", "Aurora" },
                    { 64, "User_64@gmail.com", "User_64", "Aurora" },
                    { 65, "User_65@gmail.com", "User_65", "Aurora" },
                    { 66, "User_66@gmail.com", "User_66", "Aurora" },
                    { 67, "User_67@gmail.com", "User_67", "Aurora" },
                    { 68, "User_68@gmail.com", "User_68", "Aurora" },
                    { 69, "User_69@gmail.com", "User_69", "Aurora" },
                    { 70, "User_70@gmail.com", "User_70", "Aurora" },
                    { 71, "User_71@gmail.com", "User_71", "Aurora" },
                    { 72, "User_72@gmail.com", "User_72", "Aurora" },
                    { 73, "User_73@gmail.com", "User_73", "Aurora" },
                    { 74, "User_74@gmail.com", "User_74", "Aurora" },
                    { 75, "User_75@gmail.com", "User_75", "Aurora" },
                    { 76, "User_76@gmail.com", "User_76", "Aurora" },
                    { 77, "User_77@gmail.com", "User_77", "Aurora" },
                    { 78, "User_78@gmail.com", "User_78", "Aurora" },
                    { 79, "User_79@gmail.com", "User_79", "Aurora" },
                    { 80, "User_80@gmail.com", "User_80", "Aurora" },
                    { 81, "User_81@gmail.com", "User_81", "Aurora" },
                    { 82, "User_82@gmail.com", "User_82", "Aurora" },
                    { 83, "User_83@gmail.com", "User_83", "Aurora" },
                    { 84, "User_84@gmail.com", "User_84", "Aurora" },
                    { 85, "User_85@gmail.com", "User_85", "Aurora" },
                    { 86, "User_86@gmail.com", "User_86", "Aurora" },
                    { 87, "User_87@gmail.com", "User_87", "Aurora" },
                    { 88, "User_88@gmail.com", "User_88", "Aurora" },
                    { 89, "User_89@gmail.com", "User_89", "Aurora" },
                    { 90, "User_90@gmail.com", "User_90", "Aurora" },
                    { 91, "User_91@gmail.com", "User_91", "Aurora" },
                    { 92, "User_92@gmail.com", "User_92", "Aurora" },
                    { 93, "User_93@gmail.com", "User_93", "Aurora" },
                    { 94, "User_94@gmail.com", "User_94", "Aurora" },
                    { 95, "User_95@gmail.com", "User_95", "Aurora" },
                    { 96, "User_96@gmail.com", "User_96", "Aurora" },
                    { 97, "User_97@gmail.com", "User_97", "Aurora" },
                    { 98, "User_98@gmail.com", "User_98", "Aurora" },
                    { 99, "User_99@gmail.com", "User_99", "Aurora" },
                    { 100, "User_100@gmail.com", "User_100", "Aurora" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
