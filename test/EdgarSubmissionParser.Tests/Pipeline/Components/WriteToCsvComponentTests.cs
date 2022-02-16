using System;
using EdgarSubmissionParser.Pipeline.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdgarSubmissionParser.Tests.Pipeline.Components;

[TestClass]
public class WriteToCsvComponentTests
{

    [TestInitialize]
    public void Init()
    {
    }

    //[TestMethod]
    //public async Task CanWriteToComponent()
    //{
    //    // Arrange
    //    var mapper = Substitute.For<IMapper>();
    //    mapper.Map<Output[]>(Arg.Any<object>()).ReturnsForAnyArgs(new Output[] {});
    //    var component = new WriteToCsvComponent(mapper);
    //    var payload = new PipelinePayload();

    //    // Act
    //    var result = await component.ExecuteAsync(payload, CancellationToken.None);

    //    // Assert
    //}

    class FooBar
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
    }

    [TestMethod]
    public async Task CanBuildCsvLog()
    {
        // Arrange
        var list = new List<FooBar>()
        {
            new FooBar()
            {
                Property1 = "foo",
                Property2 = "bar"
            }
        };


        // Act
        var result = WriteToCsvComponent.BuildCsvLog(list).ToString();

        // Assert
        Assert.AreEqual("Property1, Property2foo, bar", result.Replace(Environment.NewLine, ""));
    }
}

