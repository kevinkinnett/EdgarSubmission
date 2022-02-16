using EdgarSubmissionParser.Model;

namespace EdgarSubmissionParser.Pipeline.Payloads;

public class PipelinePayload
{
    public edgarSubmission EdgerSubmission { get; set; }
    public string Path { get; set; }
}
