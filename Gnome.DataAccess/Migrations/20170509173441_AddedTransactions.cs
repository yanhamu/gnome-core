using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gnome.DataAccess.Migrations
{
    public partial class AddedTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AspNetUsers_OwnerId",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    BankIndentifierCode = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ConstantSymbol = table.Column<string>(nullable: true),
                    ContraAccount = table.Column<string>(nullable: true),
                    ContraAccountBankCode = table.Column<string>(nullable: true),
                    ContraAccountBankName = table.Column<string>(nullable: true),
                    ContraAccountName = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    MessageForReceiver = table.Column<string>(nullable: true),
                    MovementDate = table.Column<DateTime>(nullable: false),
                    MovementId = table.Column<string>(nullable: true),
                    SpecificSymbol = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    TransactionExecutive = table.Column<string>(nullable: true),
                    TransactionId = table.Column<long>(nullable: false),
                    TransactionType = table.Column<string>(nullable: true),
                    UserIdentification = table.Column<string>(nullable: true),
                    VariableSymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AspNetUsers_OwnerId",
                table: "Accounts",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AspNetUsers_OwnerId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Accounts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AspNetUsers_OwnerId",
                table: "Accounts",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
