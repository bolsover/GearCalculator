using Bolsover.GearCalculator.Dictionary;
using Bolsover.GearCalculator.Gear;
using NUnit.Framework;

namespace UnitTests.NameTests;

[TestFixture]
public class NameTest
{
    [SetUp]
    public void SetUp()
    {
    }

    [TearDown]
    public void TearDown()
    {
    }

    private static readonly InvoluteSpurGear Gear = new();


    [Test]
    public void TestAddendum1()
    {
        var module = GearParameterName.Module;
        Assert.That("Module", Is.EqualTo(module.ToString()));
    }
}