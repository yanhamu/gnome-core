using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gnome.DataAccess.Migrations
{
    public partial class RenamedTransactionColumnToFioTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "FioTransactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountId",
                table: "FioTransactions",
                newName: "IX_FioTransactions_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FioTransactions",
                table: "FioTransactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FioTransactions_Accounts_AccountId",
                table: "FioTransactions",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FioTransactions_Accounts_AccountId",
                table: "FioTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FioTransactions",
                table: "FioTransactions");

            migrationBuilder.RenameTable(
                name: "FioTransactions",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_FioTransactions_AccountId",
                table: "Transactions",
                newName: "IX_Transactions_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
