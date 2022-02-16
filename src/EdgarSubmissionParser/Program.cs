// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Xml.Serialization;
using AutoMapper;
using ConsoleApp5.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;


public class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddLogging(builder => builder.AddConsole())
            .BuildServiceProvider();

        //configure console logging
        var logger = serviceProvider
            .GetService<ILoggerFactory>()!.CreateLogger<Program>();

        logger.LogInformation("Hello, World!");

        edgarSubmission submission;

        submission = DeserializeXml<edgarSubmission>("Data/primary_doc.xml");

        //submission.formData.invstOrSecs
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<edgarSubmissionFormDataInvstOrSec, Output>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Lei, opt => opt.MapFrom(src => src.lei))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.title))
                .ForMember(dest => dest.Cusip, opt => opt.MapFrom(src => src.cusip))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.balance))
                .ForMember(dest => dest.Units, opt => opt.MapFrom(src => src.units))
                .ForMember(dest => dest.CurCd, opt => opt.MapFrom(src => src.curCd))
                .ForMember(dest => dest.ValUsd, opt => opt.MapFrom(src => src.valUSD))
                .ForMember(dest => dest.PctVal, opt => opt.MapFrom(src => src.pctVal))
                .ForMember(dest => dest.PayoffProfile, opt => opt.MapFrom(src => src.payoffProfile))
                .ForMember(dest => dest.AssetCat, opt => opt.MapFrom(src => src.assetCat))
                .ForMember(dest => dest.InvCountry, opt => opt.MapFrom(src => src.invCountry))
                .ForMember(dest => dest.IsRestrictedSec, opt => opt.MapFrom(src => src.isRestrictedSec))
                .ForMember(dest => dest.FairValLevel, opt => opt.MapFrom(src => src.fairValLevel))
            );

        var mapper = config.CreateMapper();
        var dto = mapper.Map<Output[]>(submission.formData.invstOrSecs);

        WriteCsv(dto, "Data/output.csv");
        logger.LogInformation("end");


    }

    private static T DeserializeXml<T>(string path) where T : class
    {
       
        using var fileStream = new FileStream(path, FileMode.Open);
        var submission = new XmlSerializer(typeof(T)).Deserialize(fileStream)! as T;

        return submission;
    }

    static void WriteCsv<T>(IEnumerable<T> items, string path)
    {
        var itemType = typeof(T);
        var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);

        using var writer = new StreamWriter(path);

        writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

        foreach (var item in items)
            writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
    }
}


