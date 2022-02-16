// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Xml.Serialization;
using AutoMapper;
using ConsoleApp5.Model;

Console.WriteLine("Hello, World!");

edgarSubmission submission;

XmlSerializer serializer = new XmlSerializer(typeof(edgarSubmission));
using (FileStream fileStream = new FileStream("Data/primary_doc.xml", FileMode.Open))
{
    submission = (edgarSubmission)serializer.Deserialize(fileStream);
}

//submission.formData.invstOrSecs
var config = new MapperConfiguration(cfg => 
    cfg.CreateMap<edgarSubmissionFormDataInvstOrSec, Output>()
        .ForMember(dest => dest.NameField, opt => opt.MapFrom(src => src.name))
        .ForMember(dest => dest.LeiField, opt => opt.MapFrom(src => src.lei))
        .ForMember(dest => dest.TitleField, opt => opt.MapFrom(src => src.title))
        .ForMember(dest => dest.CusipField, opt => opt.MapFrom(src => src.cusip))
        .ForMember(dest => dest.BalanceField, opt => opt.MapFrom(src => src.balance))
        .ForMember(dest => dest.UnitsField, opt => opt.MapFrom(src => src.units))
        .ForMember(dest => dest.CurCdField, opt => opt.MapFrom(src => src.curCd))
        .ForMember(dest => dest.ValUsdField, opt => opt.MapFrom(src => src.valUSD))
        .ForMember(dest => dest.PctValField, opt => opt.MapFrom(src => src.pctVal))
        .ForMember(dest => dest.PayoffProfileField, opt => opt.MapFrom(src => src.payoffProfile))
        .ForMember(dest => dest.AssetCatField, opt => opt.MapFrom(src => src.assetCat))
        .ForMember(dest => dest.InvCountryField, opt => opt.MapFrom(src => src.invCountry))
        .ForMember(dest => dest.IsRestrictedSecField, opt => opt.MapFrom(src => src.isRestrictedSec))
        .ForMember(dest => dest.FairValLevelField, opt => opt.MapFrom(src => src.fairValLevel))
    );

var mapper = config.CreateMapper();
var dto = mapper.Map<Output[]>(submission.formData.invstOrSecs);

WriteCSV(dto, "Data/output.csv");
Console.WriteLine("end");

void WriteCSV<T>(IEnumerable<T> items, string path)
{
    var itemType = typeof(T);
    var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
        .OrderBy(p => p.Name);

    using (var writer = new StreamWriter(path))
    {
        writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

        foreach (var item in items)
        {
            writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
        }
    }
}
