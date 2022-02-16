using System.Reflection;
using System.Text;
using AutoMapper;
using EdgarSubmissionParser.Model;
using EdgarSubmissionParser.Pipeline.Payloads;
using PipelineFramework.Abstractions;

namespace EdgarSubmissionParser.Pipeline.Components;

public class WriteToCsvComponent : AsyncPipelineComponentBase<PipelinePayload>
{
    private readonly IMapper mapper;

    public WriteToCsvComponent(IMapper mapper)
    {
        this.mapper = mapper;
    }

    public override async Task<PipelinePayload> ExecuteAsync(PipelinePayload payload,
        CancellationToken cancellationToken)
    {
        var dto = mapper.Map<Output[]>(payload.EdgerSubmission.formData.invstOrSecs);

        WriteCsv(dto, "Data/output.csv");

        return await Task.FromResult(payload);
    }

    internal static void WriteCsv<T>(IEnumerable<T> items, string path)
    {
        using var writer = new StreamWriter(path);
        writer.WriteLine(BuildCsvLog(items));
    }

    internal static StringBuilder BuildCsvLog<T>(IEnumerable<T> items)
    {
        var itemType = typeof(T);
        var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);

        var builder = new StringBuilder();

        builder.AppendLine(string.Join(", ", props.Select(p => p.Name)));

        foreach (var item in items)
            builder.AppendLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));

        return builder;
    }


}

