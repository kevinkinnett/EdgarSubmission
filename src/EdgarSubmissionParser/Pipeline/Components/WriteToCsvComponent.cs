using System.Reflection;
using AutoMapper;
using ConsoleApp5.Model;
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

