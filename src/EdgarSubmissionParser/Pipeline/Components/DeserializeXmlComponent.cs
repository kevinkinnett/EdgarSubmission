using EdgarSubmissionParser.Model;
using EdgarSubmissionParser.Pipeline.Payloads;
using PipelineFramework.Abstractions;
using System.Xml.Serialization;

namespace EdgarSubmissionParser.Pipeline.Components;

public class DeserializeXmlComponent : AsyncPipelineComponentBase<PipelinePayload>
{
    public override async Task<PipelinePayload> ExecuteAsync(PipelinePayload payload,
        CancellationToken cancellationToken)
    {
        payload.EdgerSubmission = DeserializeXml<edgarSubmission>(payload.Path);

        return await Task.FromResult(payload);
    }

    private static T DeserializeXml<T>(string path) where T : class
    {
        using var fileStream = new FileStream(path, FileMode.Open);
        var submission = new XmlSerializer(typeof(T)).Deserialize(fileStream)! as T;

        return submission;
    }


}

