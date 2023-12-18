using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBSCourseWork3kurs.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookId = table.Column<int>(name: "Book_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Collateralvalue = table.Column<double>(name: "Collateral_value", type: "double", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "discounts",
                columns: table => new
                {
                    DiscountId = table.Column<int>(name: "Discount_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discounts", x => x.DiscountId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fines",
                columns: table => new
                {
                    FineId = table.Column<int>(name: "Fine_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Payment = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fines", x => x.FineId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(name: "Customer_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Paternalname = table.Column<string>(name: "Paternal_name", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscountId = table.Column<int>(name: "Discount_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_customers_discounts_Discount_Id",
                        column: x => x.DiscountId,
                        principalTable: "discounts",
                        principalColumn: "Discount_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "lendings",
                columns: table => new
                {
                    LendingId = table.Column<int>(name: "Lending_Id", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(name: "Customer_Id", type: "int", nullable: false),
                    Loandate = table.Column<DateOnly>(name: "Loan_date", type: "date", nullable: false),
                    Expectedreturndate = table.Column<DateOnly>(name: "Expected_return_date", type: "date", nullable: true),
                    Actualreturndate = table.Column<DateOnly>(name: "Actual_return_date", type: "date", nullable: true),
                    BookId = table.Column<int>(name: "Book_Id", type: "int", nullable: false),
                    FineId = table.Column<int>(name: "Fine_Id", type: "int", nullable: false),
                    DiscountId = table.Column<int>(name: "Discount_Id", type: "int", nullable: false),
                    Initialrentalprice = table.Column<double>(name: "Initial_rental_price", type: "double", nullable: false),
                    Finalrentalprice = table.Column<double>(name: "Final_rental_price", type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lendings", x => x.LendingId);
                    table.ForeignKey(
                        name: "FK_lendings_books_Book_Id",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lendings_customers_Customer_Id",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lendings_discounts_Discount_Id",
                        column: x => x.DiscountId,
                        principalTable: "discounts",
                        principalColumn: "Discount_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lendings_fines_Fine_Id",
                        column: x => x.FineId,
                        principalTable: "fines",
                        principalColumn: "Fine_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_customers_Discount_Id",
                table: "customers",
                column: "Discount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_lendings_Book_Id",
                table: "lendings",
                column: "Book_Id");

            migrationBuilder.CreateIndex(
                name: "IX_lendings_Customer_Id",
                table: "lendings",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_lendings_Discount_Id",
                table: "lendings",
                column: "Discount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_lendings_Fine_Id",
                table: "lendings",
                column: "Fine_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lendings");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "fines");

            migrationBuilder.DropTable(
                name: "discounts");
        }
    }
}
