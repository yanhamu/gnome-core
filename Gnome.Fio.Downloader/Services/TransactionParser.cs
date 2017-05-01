using Gnome.Fio.Downloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Gnome.Fio.Downloader.Services
{
    public class TransactionParser : ITransactionParser
    {
        public IEnumerable<FioTransaction> Parse(Stream document)
        {
            var s = new XmlSerializer(typeof(AccountStatement));
            var deserialized = s.Deserialize(document) as AccountStatement;
            var transactions = deserialized.TransactionList;

            throw new NotImplementedException();
        }
    }
}
