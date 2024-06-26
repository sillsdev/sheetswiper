using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using SheetSwiper;

namespace Tests;

public class ConverterTests
{
    [SetUp]
    public void Setup()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }

    [Test]
    public void ConvertXls()
    {
        Assert.Multiple(() =>
        {
            Assert.That(
                File.Exists(Path.Combine(TestContext.CurrentContext.TestDirectory, "one.xls"))
            );
            Assert.That(
                File.Exists(Path.Combine(TestContext.CurrentContext.TestDirectory, "one.sfm"))
            );
        });

        var actual = Converter.Convert(
            Path.Combine(TestContext.CurrentContext.TestDirectory, "one.xls")
        );

        var expected = File.ReadAllText(
            Path.Combine(TestContext.CurrentContext.TestDirectory, "one.sfm")
        );

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void ConvertXlsx()
    {
        Assert.Multiple(() =>
        {
            Assert.That(
                File.Exists(Path.Combine(TestContext.CurrentContext.TestDirectory, "one.xlsx"))
            );
            Assert.That(
                File.Exists(Path.Combine(TestContext.CurrentContext.TestDirectory, "one.sfm"))
            );
        });

        var actual = Converter.Convert(
            Path.Combine(TestContext.CurrentContext.TestDirectory, "one.xlsx")
        );

        var expected = File.ReadAllText(
            Path.Combine(TestContext.CurrentContext.TestDirectory, "one.sfm")
        );

        Assert.That(actual, Is.EqualTo(expected));
    }
}
