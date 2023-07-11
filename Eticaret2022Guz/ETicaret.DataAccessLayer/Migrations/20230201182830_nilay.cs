using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccesLayer.Migrations
{
    public partial class nilay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdressName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AdressDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AdressStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.AdressID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CustomerEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CustomerUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CustomerStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    varchar = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeLastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EmployeeStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleStatu = table.Column<bool>(type: "bit", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.CartID);
                });

            migrationBuilder.InsertData(
                table: "Adress",
                columns: new[] { "AdressID", "AdressDescription", "AdressName", "AdressStatus", "CityName", "NeighborhoodName", "TownName" },
                values: new object[] { 1, "türkiye", "istanbul", true, "kartal", "tertip sk", "cumhuriyet mah" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "BrandStatus" },
                values: new object[] { 1, "deneme", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryStatus", "SortKey" },
                values: new object[] { 1, "Elektronik", true, (short)1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthDay", "datetime", "CustomerEmail", "CustomerLastName", "CustomerName", "CustomerPassword", "CustomerStatus", "CustomerUserName", "varchar", "Token", "TokenExpireDate" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 21, 28, 29, 714, DateTimeKind.Local).AddTicks(9949), "tt@gmail.com", "Tanin", "Tuncay", null, true, "tt", "+905327411235", null, null });

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "EmployeeId", "EmployeeEmail", "EmployeeLastname", "EmployeeName", "EmployeeStatu", "EmployeeUserName" },
                values: new object[] { 1, "sajksajf@gmail.com", "deneme", "deneme", true, "deneme" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleName", "RoleStatu" },
                values: new object[] { 1, "Admin kullanıcıları için oluşturuğumuz role", "Admin", true });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "CartID", "Status", "Price", "ProductID", "Quantity" },
                values: new object[] { 1, true, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ShoppingCart");
        }
    }
}
