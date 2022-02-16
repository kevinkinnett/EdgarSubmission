namespace ConsoleApp5.Model;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sec.gov/edgar/nport", IsNullable = false)]
public partial class edgarSubmission
{

    private edgarSubmissionHeaderData headerDataField;

    private edgarSubmissionFormData formDataField;

    /// <remarks/>
    public edgarSubmissionHeaderData headerData
    {
        get
        {
            return this.headerDataField;
        }
        set
        {
            this.headerDataField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormData formData
    {
        get
        {
            return this.formDataField;
        }
        set
        {
            this.formDataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionHeaderData
{

    private string submissionTypeField;

    private bool isConfidentialField;

    private edgarSubmissionHeaderDataFilerInfo filerInfoField;

    /// <remarks/>
    public string submissionType
    {
        get
        {
            return this.submissionTypeField;
        }
        set
        {
            this.submissionTypeField = value;
        }
    }

    /// <remarks/>
    public bool isConfidential
    {
        get
        {
            return this.isConfidentialField;
        }
        set
        {
            this.isConfidentialField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionHeaderDataFilerInfo filerInfo
    {
        get
        {
            return this.filerInfoField;
        }
        set
        {
            this.filerInfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionHeaderDataFilerInfo
{

    private edgarSubmissionHeaderDataFilerInfoFiler filerField;

    private edgarSubmissionHeaderDataFilerInfoSeriesClassInfo seriesClassInfoField;

    /// <remarks/>
    public edgarSubmissionHeaderDataFilerInfoFiler filer
    {
        get
        {
            return this.filerField;
        }
        set
        {
            this.filerField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionHeaderDataFilerInfoSeriesClassInfo seriesClassInfo
    {
        get
        {
            return this.seriesClassInfoField;
        }
        set
        {
            this.seriesClassInfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionHeaderDataFilerInfoFiler
{

    private edgarSubmissionHeaderDataFilerInfoFilerIssuerCredentials issuerCredentialsField;

    /// <remarks/>
    public edgarSubmissionHeaderDataFilerInfoFilerIssuerCredentials issuerCredentials
    {
        get
        {
            return this.issuerCredentialsField;
        }
        set
        {
            this.issuerCredentialsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionHeaderDataFilerInfoFilerIssuerCredentials
{

    private uint cikField;

    private string cccField;

    /// <remarks/>
    public uint cik
    {
        get
        {
            return this.cikField;
        }
        set
        {
            this.cikField = value;
        }
    }

    /// <remarks/>
    public string ccc
    {
        get
        {
            return this.cccField;
        }
        set
        {
            this.cccField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionHeaderDataFilerInfoSeriesClassInfo
{

    private string seriesIdField;

    private string[] classIdField;

    /// <remarks/>
    public string seriesId
    {
        get
        {
            return this.seriesIdField;
        }
        set
        {
            this.seriesIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("classId")]
    public string[] classId
    {
        get
        {
            return this.classIdField;
        }
        set
        {
            this.classIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormData
{

    private edgarSubmissionFormDataGenInfo genInfoField;

    private edgarSubmissionFormDataFundInfo fundInfoField;

    private edgarSubmissionFormDataInvstOrSec[] invstOrSecsField;

    private edgarSubmissionFormDataExplntrNotes explntrNotesField;

    private edgarSubmissionFormDataSignature signatureField;

    /// <remarks/>
    public edgarSubmissionFormDataGenInfo genInfo
    {
        get
        {
            return this.genInfoField;
        }
        set
        {
            this.genInfoField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfo fundInfo
    {
        get
        {
            return this.fundInfoField;
        }
        set
        {
            this.fundInfoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("invstOrSec", IsNullable = false)]
    public edgarSubmissionFormDataInvstOrSec[] invstOrSecs
    {
        get
        {
            return this.invstOrSecsField;
        }
        set
        {
            this.invstOrSecsField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataExplntrNotes explntrNotes
    {
        get
        {
            return this.explntrNotesField;
        }
        set
        {
            this.explntrNotesField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataSignature signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataGenInfo
{

    private string regNameField;

    private string regFileNumberField;

    private uint regCikField;

    private string regLeiField;

    private string regStreet1Field;

    private string regStreet2Field;

    private string regCityField;

    private edgarSubmissionFormDataGenInfoRegStateConditional regStateConditionalField;

    private ushort regZipOrPostalCodeField;

    private string regPhoneField;

    private string seriesNameField;

    private string seriesIdField;

    private string seriesLeiField;

    private System.DateTime repPdEndField;

    private System.DateTime repPdDateField;

    private string isFinalFilingField;

    /// <remarks/>
    public string regName
    {
        get
        {
            return this.regNameField;
        }
        set
        {
            this.regNameField = value;
        }
    }

    /// <remarks/>
    public string regFileNumber
    {
        get
        {
            return this.regFileNumberField;
        }
        set
        {
            this.regFileNumberField = value;
        }
    }

    /// <remarks/>
    public uint regCik
    {
        get
        {
            return this.regCikField;
        }
        set
        {
            this.regCikField = value;
        }
    }

    /// <remarks/>
    public string regLei
    {
        get
        {
            return this.regLeiField;
        }
        set
        {
            this.regLeiField = value;
        }
    }

    /// <remarks/>
    public string regStreet1
    {
        get
        {
            return this.regStreet1Field;
        }
        set
        {
            this.regStreet1Field = value;
        }
    }

    /// <remarks/>
    public string regStreet2
    {
        get
        {
            return this.regStreet2Field;
        }
        set
        {
            this.regStreet2Field = value;
        }
    }

    /// <remarks/>
    public string regCity
    {
        get
        {
            return this.regCityField;
        }
        set
        {
            this.regCityField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataGenInfoRegStateConditional regStateConditional
    {
        get
        {
            return this.regStateConditionalField;
        }
        set
        {
            this.regStateConditionalField = value;
        }
    }

    /// <remarks/>
    public ushort regZipOrPostalCode
    {
        get
        {
            return this.regZipOrPostalCodeField;
        }
        set
        {
            this.regZipOrPostalCodeField = value;
        }
    }

    /// <remarks/>
    public string regPhone
    {
        get
        {
            return this.regPhoneField;
        }
        set
        {
            this.regPhoneField = value;
        }
    }

    /// <remarks/>
    public string seriesName
    {
        get
        {
            return this.seriesNameField;
        }
        set
        {
            this.seriesNameField = value;
        }
    }

    /// <remarks/>
    public string seriesId
    {
        get
        {
            return this.seriesIdField;
        }
        set
        {
            this.seriesIdField = value;
        }
    }

    /// <remarks/>
    public string seriesLei
    {
        get
        {
            return this.seriesLeiField;
        }
        set
        {
            this.seriesLeiField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime repPdEnd
    {
        get
        {
            return this.repPdEndField;
        }
        set
        {
            this.repPdEndField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime repPdDate
    {
        get
        {
            return this.repPdDateField;
        }
        set
        {
            this.repPdDateField = value;
        }
    }

    /// <remarks/>
    public string isFinalFiling
    {
        get
        {
            return this.isFinalFilingField;
        }
        set
        {
            this.isFinalFilingField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataGenInfoRegStateConditional
{

    private string regCountryField;

    private string regStateField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string regCountry
    {
        get
        {
            return this.regCountryField;
        }
        set
        {
            this.regCountryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string regState
    {
        get
        {
            return this.regStateField;
        }
        set
        {
            this.regStateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfo
{

    private decimal totAssetsField;

    private decimal totLiabsField;

    private decimal netAssetsField;

    private decimal assetsAttrMiscSecField;

    private decimal assetsInvestedField;

    private decimal amtPayOneYrBanksBorrField;

    private decimal amtPayOneYrCtrldCompField;

    private decimal amtPayOneYrOthAffilField;

    private decimal amtPayOneYrOtherField;

    private decimal amtPayAftOneYrBanksBorrField;

    private decimal amtPayAftOneYrCtrldCompField;

    private decimal amtPayAftOneYrOthAffilField;

    private decimal amtPayAftOneYrOtherField;

    private decimal delayDelivField;

    private decimal standByCommitField;

    private decimal liquidPrefField;

    private decimal cshNotRptdInCorDField;

    private edgarSubmissionFormDataFundInfoBorrower[] borrowersField;

    private edgarSubmissionFormDataFundInfoAggregateCondition aggregateConditionField;

    private edgarSubmissionFormDataFundInfoReturnInfo returnInfoField;

    private edgarSubmissionFormDataFundInfoMon1Flow mon1FlowField;

    private edgarSubmissionFormDataFundInfoMon2Flow mon2FlowField;

    private edgarSubmissionFormDataFundInfoMon3Flow mon3FlowField;

    /// <remarks/>
    public decimal totAssets
    {
        get
        {
            return this.totAssetsField;
        }
        set
        {
            this.totAssetsField = value;
        }
    }

    /// <remarks/>
    public decimal totLiabs
    {
        get
        {
            return this.totLiabsField;
        }
        set
        {
            this.totLiabsField = value;
        }
    }

    /// <remarks/>
    public decimal netAssets
    {
        get
        {
            return this.netAssetsField;
        }
        set
        {
            this.netAssetsField = value;
        }
    }

    /// <remarks/>
    public decimal assetsAttrMiscSec
    {
        get
        {
            return this.assetsAttrMiscSecField;
        }
        set
        {
            this.assetsAttrMiscSecField = value;
        }
    }

    /// <remarks/>
    public decimal assetsInvested
    {
        get
        {
            return this.assetsInvestedField;
        }
        set
        {
            this.assetsInvestedField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayOneYrBanksBorr
    {
        get
        {
            return this.amtPayOneYrBanksBorrField;
        }
        set
        {
            this.amtPayOneYrBanksBorrField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayOneYrCtrldComp
    {
        get
        {
            return this.amtPayOneYrCtrldCompField;
        }
        set
        {
            this.amtPayOneYrCtrldCompField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayOneYrOthAffil
    {
        get
        {
            return this.amtPayOneYrOthAffilField;
        }
        set
        {
            this.amtPayOneYrOthAffilField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayOneYrOther
    {
        get
        {
            return this.amtPayOneYrOtherField;
        }
        set
        {
            this.amtPayOneYrOtherField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayAftOneYrBanksBorr
    {
        get
        {
            return this.amtPayAftOneYrBanksBorrField;
        }
        set
        {
            this.amtPayAftOneYrBanksBorrField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayAftOneYrCtrldComp
    {
        get
        {
            return this.amtPayAftOneYrCtrldCompField;
        }
        set
        {
            this.amtPayAftOneYrCtrldCompField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayAftOneYrOthAffil
    {
        get
        {
            return this.amtPayAftOneYrOthAffilField;
        }
        set
        {
            this.amtPayAftOneYrOthAffilField = value;
        }
    }

    /// <remarks/>
    public decimal amtPayAftOneYrOther
    {
        get
        {
            return this.amtPayAftOneYrOtherField;
        }
        set
        {
            this.amtPayAftOneYrOtherField = value;
        }
    }

    /// <remarks/>
    public decimal delayDeliv
    {
        get
        {
            return this.delayDelivField;
        }
        set
        {
            this.delayDelivField = value;
        }
    }

    /// <remarks/>
    public decimal standByCommit
    {
        get
        {
            return this.standByCommitField;
        }
        set
        {
            this.standByCommitField = value;
        }
    }

    /// <remarks/>
    public decimal liquidPref
    {
        get
        {
            return this.liquidPrefField;
        }
        set
        {
            this.liquidPrefField = value;
        }
    }

    /// <remarks/>
    public decimal cshNotRptdInCorD
    {
        get
        {
            return this.cshNotRptdInCorDField;
        }
        set
        {
            this.cshNotRptdInCorDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("borrower", IsNullable = false)]
    public edgarSubmissionFormDataFundInfoBorrower[] borrowers
    {
        get
        {
            return this.borrowersField;
        }
        set
        {
            this.borrowersField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoAggregateCondition aggregateCondition
    {
        get
        {
            return this.aggregateConditionField;
        }
        set
        {
            this.aggregateConditionField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoReturnInfo returnInfo
    {
        get
        {
            return this.returnInfoField;
        }
        set
        {
            this.returnInfoField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoMon1Flow mon1Flow
    {
        get
        {
            return this.mon1FlowField;
        }
        set
        {
            this.mon1FlowField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoMon2Flow mon2Flow
    {
        get
        {
            return this.mon2FlowField;
        }
        set
        {
            this.mon2FlowField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoMon3Flow mon3Flow
    {
        get
        {
            return this.mon3FlowField;
        }
        set
        {
            this.mon3FlowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoBorrower
{

    private decimal aggrValField;

    private string leiField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal aggrVal
    {
        get
        {
            return this.aggrValField;
        }
        set
        {
            this.aggrValField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lei
    {
        get
        {
            return this.leiField;
        }
        set
        {
            this.leiField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoAggregateCondition
{

    private edgarSubmissionFormDataFundInfoAggregateConditionAggregateInfo[] aggregateInfosField;

    private string isNonCashCollateralField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("aggregateInfo", IsNullable = false)]
    public edgarSubmissionFormDataFundInfoAggregateConditionAggregateInfo[] aggregateInfos
    {
        get
        {
            return this.aggregateInfosField;
        }
        set
        {
            this.aggregateInfosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isNonCashCollateral
    {
        get
        {
            return this.isNonCashCollateralField;
        }
        set
        {
            this.isNonCashCollateralField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoAggregateConditionAggregateInfo
{

    private string invstCatField;

    private decimal amtField;

    private decimal collatrlField;

    /// <remarks/>
    public string invstCat
    {
        get
        {
            return this.invstCatField;
        }
        set
        {
            this.invstCatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal amt
    {
        get
        {
            return this.amtField;
        }
        set
        {
            this.amtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal collatrl
    {
        get
        {
            return this.collatrlField;
        }
        set
        {
            this.collatrlField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoReturnInfo
{

    private edgarSubmissionFormDataFundInfoReturnInfoMonthlyTotReturn[] monthlyTotReturnsField;

    private edgarSubmissionFormDataFundInfoReturnInfoOthMon1 othMon1Field;

    private edgarSubmissionFormDataFundInfoReturnInfoOthMon2 othMon2Field;

    private edgarSubmissionFormDataFundInfoReturnInfoOthMon3 othMon3Field;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("monthlyTotReturn", IsNullable = false)]
    public edgarSubmissionFormDataFundInfoReturnInfoMonthlyTotReturn[] monthlyTotReturns
    {
        get
        {
            return this.monthlyTotReturnsField;
        }
        set
        {
            this.monthlyTotReturnsField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoReturnInfoOthMon1 othMon1
    {
        get
        {
            return this.othMon1Field;
        }
        set
        {
            this.othMon1Field = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoReturnInfoOthMon2 othMon2
    {
        get
        {
            return this.othMon2Field;
        }
        set
        {
            this.othMon2Field = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataFundInfoReturnInfoOthMon3 othMon3
    {
        get
        {
            return this.othMon3Field;
        }
        set
        {
            this.othMon3Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoReturnInfoMonthlyTotReturn
{

    private string classIdField;

    private decimal rtn1Field;

    private decimal rtn2Field;

    private decimal rtn3Field;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classId
    {
        get
        {
            return this.classIdField;
        }
        set
        {
            this.classIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rtn1
    {
        get
        {
            return this.rtn1Field;
        }
        set
        {
            this.rtn1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rtn2
    {
        get
        {
            return this.rtn2Field;
        }
        set
        {
            this.rtn2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rtn3
    {
        get
        {
            return this.rtn3Field;
        }
        set
        {
            this.rtn3Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoReturnInfoOthMon1
{

    private decimal netRealizedGainField;

    private decimal netUnrealizedApprField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netRealizedGain
    {
        get
        {
            return this.netRealizedGainField;
        }
        set
        {
            this.netRealizedGainField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netUnrealizedAppr
    {
        get
        {
            return this.netUnrealizedApprField;
        }
        set
        {
            this.netUnrealizedApprField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoReturnInfoOthMon2
{

    private decimal netRealizedGainField;

    private decimal netUnrealizedApprField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netRealizedGain
    {
        get
        {
            return this.netRealizedGainField;
        }
        set
        {
            this.netRealizedGainField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netUnrealizedAppr
    {
        get
        {
            return this.netUnrealizedApprField;
        }
        set
        {
            this.netUnrealizedApprField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoReturnInfoOthMon3
{

    private decimal netRealizedGainField;

    private decimal netUnrealizedApprField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netRealizedGain
    {
        get
        {
            return this.netRealizedGainField;
        }
        set
        {
            this.netRealizedGainField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal netUnrealizedAppr
    {
        get
        {
            return this.netUnrealizedApprField;
        }
        set
        {
            this.netUnrealizedApprField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoMon1Flow
{

    private decimal redemptionField;

    private decimal reinvestmentField;

    private decimal salesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal redemption
    {
        get
        {
            return this.redemptionField;
        }
        set
        {
            this.redemptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal reinvestment
    {
        get
        {
            return this.reinvestmentField;
        }
        set
        {
            this.reinvestmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal sales
    {
        get
        {
            return this.salesField;
        }
        set
        {
            this.salesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoMon2Flow
{

    private decimal redemptionField;

    private decimal reinvestmentField;

    private decimal salesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal redemption
    {
        get
        {
            return this.redemptionField;
        }
        set
        {
            this.redemptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal reinvestment
    {
        get
        {
            return this.reinvestmentField;
        }
        set
        {
            this.reinvestmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal sales
    {
        get
        {
            return this.salesField;
        }
        set
        {
            this.salesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataFundInfoMon3Flow
{

    private decimal redemptionField;

    private decimal reinvestmentField;

    private decimal salesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal redemption
    {
        get
        {
            return this.redemptionField;
        }
        set
        {
            this.redemptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal reinvestment
    {
        get
        {
            return this.reinvestmentField;
        }
        set
        {
            this.reinvestmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal sales
    {
        get
        {
            return this.salesField;
        }
        set
        {
            this.salesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSec
{

    private string nameField;

    private string leiField;

    private string titleField;

    private string cusipField;

    private edgarSubmissionFormDataInvstOrSecIdentifiers identifiersField;

    private decimal balanceField;

    private string unitsField;

    private string curCdField;

    private decimal valUSDField;

    private decimal pctValField;

    private string payoffProfileField;

    private string assetCatField;

    private edgarSubmissionFormDataInvstOrSecIssuerConditional issuerConditionalField;

    private string issuerCatField;

    private string invCountryField;

    private string isRestrictedSecField;

    private byte fairValLevelField;

    private edgarSubmissionFormDataInvstOrSecDebtSec debtSecField;

    private edgarSubmissionFormDataInvstOrSecSecurityLending securityLendingField;

    /// <remarks/>
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

    /// <remarks/>
    public string lei
    {
        get
        {
            return this.leiField;
        }
        set
        {
            this.leiField = value;
        }
    }

    /// <remarks/>
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string cusip
    {
        get
        {
            return this.cusipField;
        }
        set
        {
            this.cusipField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecIdentifiers identifiers
    {
        get
        {
            return this.identifiersField;
        }
        set
        {
            this.identifiersField = value;
        }
    }

    /// <remarks/>
    public decimal balance
    {
        get
        {
            return this.balanceField;
        }
        set
        {
            this.balanceField = value;
        }
    }

    /// <remarks/>
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    public string curCd
    {
        get
        {
            return this.curCdField;
        }
        set
        {
            this.curCdField = value;
        }
    }

    /// <remarks/>
    public decimal valUSD
    {
        get
        {
            return this.valUSDField;
        }
        set
        {
            this.valUSDField = value;
        }
    }

    /// <remarks/>
    public decimal pctVal
    {
        get
        {
            return this.pctValField;
        }
        set
        {
            this.pctValField = value;
        }
    }

    /// <remarks/>
    public string payoffProfile
    {
        get
        {
            return this.payoffProfileField;
        }
        set
        {
            this.payoffProfileField = value;
        }
    }

    /// <remarks/>
    public string assetCat
    {
        get
        {
            return this.assetCatField;
        }
        set
        {
            this.assetCatField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecIssuerConditional issuerConditional
    {
        get
        {
            return this.issuerConditionalField;
        }
        set
        {
            this.issuerConditionalField = value;
        }
    }

    /// <remarks/>
    public string issuerCat
    {
        get
        {
            return this.issuerCatField;
        }
        set
        {
            this.issuerCatField = value;
        }
    }

    /// <remarks/>
    public string invCountry
    {
        get
        {
            return this.invCountryField;
        }
        set
        {
            this.invCountryField = value;
        }
    }

    /// <remarks/>
    public string isRestrictedSec
    {
        get
        {
            return this.isRestrictedSecField;
        }
        set
        {
            this.isRestrictedSecField = value;
        }
    }

    /// <remarks/>
    public byte fairValLevel
    {
        get
        {
            return this.fairValLevelField;
        }
        set
        {
            this.fairValLevelField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecDebtSec debtSec
    {
        get
        {
            return this.debtSecField;
        }
        set
        {
            this.debtSecField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecSecurityLending securityLending
    {
        get
        {
            return this.securityLendingField;
        }
        set
        {
            this.securityLendingField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecIdentifiers
{

    private edgarSubmissionFormDataInvstOrSecIdentifiersOther otherField;

    private edgarSubmissionFormDataInvstOrSecIdentifiersIsin isinField;

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecIdentifiersOther other
    {
        get
        {
            return this.otherField;
        }
        set
        {
            this.otherField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecIdentifiersIsin isin
    {
        get
        {
            return this.isinField;
        }
        set
        {
            this.isinField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecIdentifiersOther
{

    private string otherDescField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string otherDesc
    {
        get
        {
            return this.otherDescField;
        }
        set
        {
            this.otherDescField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecIdentifiersIsin
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecIssuerConditional
{

    private string descField;

    private string issuerCatField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string desc
    {
        get
        {
            return this.descField;
        }
        set
        {
            this.descField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string issuerCat
    {
        get
        {
            return this.issuerCatField;
        }
        set
        {
            this.issuerCatField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecDebtSec
{

    private System.DateTime maturityDtField;

    private string couponKindField;

    private decimal annualizedRtField;

    private string isDefaultField;

    private string areIntrstPmntsInArrsField;

    private string isPaidKindField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime maturityDt
    {
        get
        {
            return this.maturityDtField;
        }
        set
        {
            this.maturityDtField = value;
        }
    }

    /// <remarks/>
    public string couponKind
    {
        get
        {
            return this.couponKindField;
        }
        set
        {
            this.couponKindField = value;
        }
    }

    /// <remarks/>
    public decimal annualizedRt
    {
        get
        {
            return this.annualizedRtField;
        }
        set
        {
            this.annualizedRtField = value;
        }
    }

    /// <remarks/>
    public string isDefault
    {
        get
        {
            return this.isDefaultField;
        }
        set
        {
            this.isDefaultField = value;
        }
    }

    /// <remarks/>
    public string areIntrstPmntsInArrs
    {
        get
        {
            return this.areIntrstPmntsInArrsField;
        }
        set
        {
            this.areIntrstPmntsInArrsField = value;
        }
    }

    /// <remarks/>
    public string isPaidKind
    {
        get
        {
            return this.isPaidKindField;
        }
        set
        {
            this.isPaidKindField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecSecurityLending
{

    private edgarSubmissionFormDataInvstOrSecSecurityLendingCashCollateralCondition cashCollateralConditionField;

    private string isCashCollateralField;

    private string isNonCashCollateralField;

    private edgarSubmissionFormDataInvstOrSecSecurityLendingLoanByFundCondition loanByFundConditionField;

    private string isLoanByFundField;

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecSecurityLendingCashCollateralCondition cashCollateralCondition
    {
        get
        {
            return this.cashCollateralConditionField;
        }
        set
        {
            this.cashCollateralConditionField = value;
        }
    }

    /// <remarks/>
    public string isCashCollateral
    {
        get
        {
            return this.isCashCollateralField;
        }
        set
        {
            this.isCashCollateralField = value;
        }
    }

    /// <remarks/>
    public string isNonCashCollateral
    {
        get
        {
            return this.isNonCashCollateralField;
        }
        set
        {
            this.isNonCashCollateralField = value;
        }
    }

    /// <remarks/>
    public edgarSubmissionFormDataInvstOrSecSecurityLendingLoanByFundCondition loanByFundCondition
    {
        get
        {
            return this.loanByFundConditionField;
        }
        set
        {
            this.loanByFundConditionField = value;
        }
    }

    /// <remarks/>
    public string isLoanByFund
    {
        get
        {
            return this.isLoanByFundField;
        }
        set
        {
            this.isLoanByFundField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecSecurityLendingCashCollateralCondition
{

    private decimal cashCollateralValField;

    private string isCashCollateralField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cashCollateralVal
    {
        get
        {
            return this.cashCollateralValField;
        }
        set
        {
            this.cashCollateralValField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isCashCollateral
    {
        get
        {
            return this.isCashCollateralField;
        }
        set
        {
            this.isCashCollateralField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataInvstOrSecSecurityLendingLoanByFundCondition
{

    private string isLoanByFundField;

    private decimal loanValField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isLoanByFund
    {
        get
        {
            return this.isLoanByFundField;
        }
        set
        {
            this.isLoanByFundField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal loanVal
    {
        get
        {
            return this.loanValField;
        }
        set
        {
            this.loanValField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataExplntrNotes
{

    private edgarSubmissionFormDataExplntrNotesExplntrNote explntrNoteField;

    /// <remarks/>
    public edgarSubmissionFormDataExplntrNotesExplntrNote explntrNote
    {
        get
        {
            return this.explntrNoteField;
        }
        set
        {
            this.explntrNoteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataExplntrNotesExplntrNote
{

    private string noteField;

    private string noteItemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noteItem
    {
        get
        {
            return this.noteItemField;
        }
        set
        {
            this.noteItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sec.gov/edgar/nport")]
public partial class edgarSubmissionFormDataSignature
{

    private System.DateTime dateSignedField;

    private string nameOfApplicantField;

    private string signatureField;

    private string signerNameField;

    private string titleField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sec.gov/edgar/nportcommon", DataType = "date")]
    public System.DateTime dateSigned
    {
        get
        {
            return this.dateSignedField;
        }
        set
        {
            this.dateSignedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sec.gov/edgar/nportcommon")]
    public string nameOfApplicant
    {
        get
        {
            return this.nameOfApplicantField;
        }
        set
        {
            this.nameOfApplicantField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sec.gov/edgar/nportcommon")]
    public string signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sec.gov/edgar/nportcommon")]
    public string signerName
    {
        get
        {
            return this.signerNameField;
        }
        set
        {
            this.signerNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sec.gov/edgar/nportcommon")]
    public string title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }
}


