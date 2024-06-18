using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class DBinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    c_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_phone_num = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_dob = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.c_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
