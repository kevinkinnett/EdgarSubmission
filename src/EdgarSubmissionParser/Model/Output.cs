namespace EdgarSubmissionParser.Model;
public class Output
{
    public string Name { get; set; }

    public string Lei { get; set; }

    public string Title { get; set; }

    public string Cusip { get; set; }

    public decimal Balance { get; set; }

    public string Units { get; set; }

    public string CurCd { get; set; }

    public decimal ValUsd { get; set; }

    public decimal PctVal { get; set; }

    public string PayoffProfile { get; set; }

    public string AssetCat { get; set; }

    public string IssuerCat { get; set; }

    public string InvCountry { get; set; }

    public string IsRestrictedSec { get; set; }

    public byte FairValLevel { get; set; }
}
