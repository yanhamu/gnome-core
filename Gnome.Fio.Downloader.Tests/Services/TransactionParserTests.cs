﻿using Gnome.Fio.Downloader.Services;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Gnome.Fio.Downloader.Tests.Services
{
    public class TransactionParserTests
    {
        [Fact]
        public void Should_Parse_Transaction()
        {
            var transactionParser = new TransactionParser();

            var url = Get();
            var document = File.OpenRead(Get());

            var transaction = transactionParser.Parse(document).ToList().First();

            Assert.Equal(13845191074, transaction.MovementId);
            Assert.Equal(new DateTime(2016, 11, 12), transaction.MovementDate);
            Assert.Equal(-10500m, transaction.Amount);
            Assert.Equal("CZK", transaction.Currency);
            Assert.Equal("2111242001", transaction.ContraAccount);
            Assert.Equal("5500", transaction.ContraAccountBankCode);
            Assert.Equal("Raiffeisenbank a.s.", transaction.ContraAccountBankName);
            Assert.Equal(558, transaction.ConstantSymbol.Value);
            Assert.Equal("najom", transaction.UserIdentification);
            Assert.Equal("Bezhotovostní platba", transaction.TransactionType);
            Assert.Equal("Kriška, Tomáš", transaction.TransactionExecutive);
            Assert.Equal("najom", transaction.Comment);
            Assert.Equal(15336169335L, transaction.TransactionId);
        }

        private string Get()
        {
            var location = typeof(FioServiceTests).GetTypeInfo().Assembly.Location;
            var dirPath = Path.GetDirectoryName(location);
            return Path.Combine(dirPath, "sample-transaction.xml");
        }
    }
}
