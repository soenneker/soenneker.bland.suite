using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Bland.Suite.Tests;

[Collection("Collection")]
public class DefaultTests : FixturedUnitTest
{

    public DefaultTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}