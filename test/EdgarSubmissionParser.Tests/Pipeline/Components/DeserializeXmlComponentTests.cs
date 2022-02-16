using System.Threading;
using System.Threading.Tasks;
using EdgarSubmissionParser.Pipeline.Components;
using EdgarSubmissionParser.Pipeline.Payloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdgarSubmissionParser.Tests.Pipeline.Components
{
    [TestClass]
    public class DeserializeXmlComponentTests
    {
        [TestMethod]
        public async Task CanDeserialize()
        {
            // Arrange
            var component = new DeserializeXmlComponent();
            var payload = new PipelinePayload()
            {
                Path = "Data/one_invstOrSec.xml"
            };

            // Act
            var result = await component.ExecuteAsync(payload, CancellationToken.None);

            // Assert
            Assert.AreEqual("Foobar Corp", result.EdgerSubmission.formData.invstOrSecs[0].name);
        }
    }
}