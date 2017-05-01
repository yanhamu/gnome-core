using System.Xml;
using System.Xml.Serialization;

[XmlRoot(ElementName = "AccountStatement")]
public class AccountStatement
{
    public AccountStatementInfo Info { get; set; }

    [XmlArrayItem("Transaction", IsNullable = false)]
    public AccountStatementTransaction[] TransactionList { get; set; }
}

public class AccountStatementInfo
{
    public string accountId { get; set; }

    public string bankId { get; set; }

    public string currency { get; set; }

    public string iban { get; set; }

    public string bic { get; set; }

    public decimal openingBalance { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool openingBalanceSpecified { get; set; }

    public decimal closingBalance { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool closingBalanceSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime dateStart { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateStartSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime dateEnd { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateEndSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string yearList { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string idList { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string idFrom { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string idTo { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string idLastDownload { get; set; }
}

public class AccountStatementTransaction
{
    public AccountStatementTransactionColumn_22 column_22 { get; set; }

    public AccountStatementTransactionColumn_0 column_0 { get; set; }

    public AccountStatementTransactionColumn_1 column_1 { get; set; }

    public AccountStatementTransactionColumn_14 column_14 { get; set; }

    public AccountStatementTransactionColumn_2 column_2 { get; set; }

    public AccountStatementTransactionColumn_10 column_10 { get; set; }

    public AccountStatementTransactionColumn_3 column_3 { get; set; }

    public AccountStatementTransactionColumn_12 column_12 { get; set; }

    public AccountStatementTransactionColumn_4 column_4 { get; set; }

    [XmlElement(ElementName = "column_5")]
    public AccountStatementTransactionColumn_5 column_5 { get; set; }

    public AccountStatementTransactionColumn_6 column_6 { get; set; }

    public AccountStatementTransactionColumn_7 column_7 { get; set; }

    public AccountStatementTransactionColumn_16 column_16 { get; set; }

    public AccountStatementTransactionColumn_8 column_8 { get; set; }

    public AccountStatementTransactionColumn_9 column_9 { get; set; }

    public AccountStatementTransactionColumn_18 column_18 { get; set; }

    public AccountStatementTransactionColumn_25 column_25 { get; set; }

    public AccountStatementTransactionColumn_26 column_26 { get; set; }

    public AccountStatementTransactionColumn_17 column_17 { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_22 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_0 : IValue<System.DateTime>
{

    private string nameField;

    private string idField;

    private System.DateTime valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_1 : IValue<decimal>
{

    private string nameField;

    private string idField;

    private decimal valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_14 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_2 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_10 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_3 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_12 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_4 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_5 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_6 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_7 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public class AccountStatementTransactionColumn_16 : IValue<string>
{
    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string id { get; set; }

    [XmlText]
    public string Value { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_8 : IValue<string>
{
    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public class AccountStatementTransactionColumn_9 : IValue<string>
{
    [XmlAttribute]
    public string name { get; set; }

    [XmlAttribute]
    public string id { get; set; }

    [XmlText]
    public string Value { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_18 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_25 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_26 : IValue<string>
{

    private string nameField;

    private string idField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fio.cz/IBSchema")]
public partial class AccountStatementTransactionColumn_17 : IValue<long>
{

    private string nameField;

    private string idField;

    private long valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public long Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

public interface IValue<T>
{
    T Value { get; }
}