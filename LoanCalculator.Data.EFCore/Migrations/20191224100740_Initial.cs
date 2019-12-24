using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanCalculator.Data.EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanApplicationResults",
                columns: table => new
                {
                    ResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<int>(nullable: false),
                    CreditScore = table.Column<int>(nullable: false),
                    LoanAmount = table.Column<double>(nullable: false),
                    LoanTerm = table.Column<int>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    DenialReason = table.Column<string>(nullable: true),
                    ApplicantType = table.Column<string>(nullable: true),
                    InterestRate = table.Column<double>(nullable: true),
                    MonthlyPayment = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplicationResults", x => x.ResultId);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    LoanTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoanTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.LoanTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LoanRates",
                columns: table => new
                {
                    LoanRateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LowerCreditScore = table.Column<int>(nullable: false),
                    UpperCreditScore = table.Column<int>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    LoanTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRates", x => x.LoanRateId);
                    table.ForeignKey(
                        name: "FK_LoanRates_LoanTypes_LoanTypeId",
                        column: x => x.LoanTypeId,
                        principalTable: "LoanTypes",
                        principalColumn: "LoanTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LoanApplicationResults",
                columns: new[] { "ResultId", "AnnualIncome", "ApplicantType", "Approved", "CreditScore", "DenialReason", "FirstName", "InterestRate", "LastName", "LoanAmount", "LoanTerm", "MonthlyPayment" },
                values: new object[,]
                {
                    { 1, 75000, "Standard", true, 790, null, "John", 0.085000000000000006, "Smith", 125000.0, 30, 769.64999999999998 },
                    { 2, 60000, "Standard", true, 680, null, "Mary", 0.074999999999999997, "Jones", 135000.0, 30, 934.94000000000005 },
                    { 4, 125000, "Standard", true, 880, null, "Sally", 0.050000000000000003, "Johnson", 250000.0, 20, 1684.6099999999999 },
                    { 5, 75000, "Standard", true, 790, null, "John", 0.074999999999999997, "Test", 125000.0, 30, 769.64999999999998 },
                    { 6, 60000, "Standard", true, 680, null, "Jeff", 0.0625, "Pral", 135000.0, 10, 934.94000000000005 },
                    { 7, 100000, "Standard", false, 460, "Credit Score", "Steve", null, "Sun", 0.0, 30, null },
                    { 8, 125000, "Premiere", true, 880, null, "Alan", 0.17499999999999999, "Roll", 250000.0, 20, 1684.6099999999999 },
                    { 9, 75000, "Premiere", true, 790, null, "Bob", 0.14999999999999999, "Stevens", 25000.0, 10, 769.64999999999998 },
                    { 3, 100000, "Standard", false, 460, "Credit Score", "Andy", null, "Anderson", 0.0, 30, null },
                    { 10, 60000, "Standard", true, 680, null, "Phil", 0.074999999999999997, "Tell", 135000.0, 20, 934.94000000000005 },
                    { 11, 100000, "Standard", false, 406, "Credit Score", "Joel", null, "Tess", 0.0, 30, null },
                    { 12, 125000, "Standard", true, 880, null, "Bob", 0.050000000000000003, "Test", 250000.0, 20, 1684.6099999999999 }
                });

            migrationBuilder.InsertData(
                table: "LoanTypes",
                columns: new[] { "LoanTypeId", "LoanTypeName" },
                values: new object[,]
                {
                    { 1, "car" },
                    { 2, "school" }
                });

            migrationBuilder.InsertData(
                table: "LoanRates",
                columns: new[] { "LoanRateId", "InterestRate", "LoanTypeId", "LowerCreditScore", "UpperCreditScore" },
                values: new object[,]
                {
                    { 2, 0.085000000000000006, 1, 500, 599 },
                    { 3, 0.074999999999999997, 1, 600, 699 },
                    { 1, 0.10000000000000001, 2, 300, 499 },
                    { 4, 0.0625, 2, 700, 799 },
                    { 5, 0.050000000000000003, 2, 800, 850 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRates_LoanTypeId",
                table: "LoanRates",
                column: "LoanTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanApplicationResults");

            migrationBuilder.DropTable(
                name: "LoanRates");

            migrationBuilder.DropTable(
                name: "LoanTypes");
        }
    }
}
