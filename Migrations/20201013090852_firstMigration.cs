using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeightCollect.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uesrs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    ReamName = table.Column<string>(nullable: true),
                    WxNickName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    InitialWeight = table.Column<double>(nullable: false),
                    TargetWeight = table.Column<double>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uesrs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uesrs");
        }
    }
}
