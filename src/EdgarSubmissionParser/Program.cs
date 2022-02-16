// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Xml.Serialization;
using AutoMapper;
using ConsoleApp5.Model;
using EdgarSubmissionParser.Mapping;
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
            .AddSingleton(factory =>
            {
                var config = new MapperConfiguration(
                    cfg => { cfg.AddProfile<MappingProfile>(); });
                config.AssertConfigurationIsValid();
                return config.CreateMapper();

            })
            .BuildServiceProvider();

        //configure console logging
        var logger = serviceProvider
            .GetService<ILoggerFactory>()!.CreateLogger<Program>();

        logger.LogInformation("Hello, World!");

        var submission = DeserializeXml<edgarSubmission>("Data/primary_doc.xml");

        var mapper = serviceProvider
            .GetService<IMapper>();

        var dto = mapper!.Map<Output[]>(submission.formData.invstOrSecs);

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


