// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Xml.Serialization;
using AutoMapper;
using ConsoleApp5.Model;
using EdgarSubmissionParser.Mapping;
using EdgarSubmissionParser.Pipeline.Components;
using EdgarSubmissionParser.Pipeline.Payloads;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using PipelineFramework;
using PipelineFramework.Abstractions;


public class Program
{
    static async Task Main()
    {
        // Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddLogging(builder => builder.AddConsole())
            .AddSingleton(factory =>
            {
                var config = new MapperConfiguration(
                    cfg => { cfg.AddProfile<MappingProfile>(); });
                config.AssertConfigurationIsValid();
                return config.CreateMapper();

            })
            // Adding pipeline and components
            .AddPipelineFramework()
            .AddAsyncPipeline<PipelinePayload>(cfg => cfg
                .WithComponent<DeserializeXmlComponent>()
                .WithComponent<WriteToCsvComponent>())
            .BuildServiceProvider();

        // Now we start to execute
        // Getting loggers
        var logger = serviceProvider
            .GetService<ILoggerFactory>()!.CreateLogger<Program>();
        logger.LogInformation("Hello, World!");

        // Get Pipeline
        var pipeline = serviceProvider
            .GetService<IAsyncPipeline<PipelinePayload>>();

        // Kick off pipeline
        var result = await pipeline.ExecuteAsync(new PipelinePayload()
        {
            Path = "Data/primary_doc.xml"
        });


        logger.LogInformation("end");
    }
}


