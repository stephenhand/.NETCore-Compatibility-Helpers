using Handy.DotNETCoreCompatibility.ColourTranslations;
using NUnit.Framework;
using System;

namespace Handy.DotNETCoreCompatibility.ColourTranslations.UnitTests
{
    [TestFixture]
    public class HTMLColourTranslatorTests
    {
        [Test]
        public void Translate_6FigureHexVal_ReturnSameRGBAndFullAlpha()
        {
            var result = HTMLColorTranslator.Translate("#1A3F44");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0x1A);
            Assert.AreEqual(result.G, 0x3F);
            Assert.AreEqual(result.B, 0x44);

        }
        [Test]
        public void Translate_6FigureHexVal_CaseInsensitive()
        {
            var result = HTMLColorTranslator.Translate("#1a3f4b");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0x1A);
            Assert.AreEqual(result.G, 0x3F);
            Assert.AreEqual(result.B, 0x4B);
            result = HTMLColorTranslator.Translate("#1a3F4b");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0x1A);
            Assert.AreEqual(result.G, 0x3F);
            Assert.AreEqual(result.B, 0x4B);

        }

        [Test]
        public void Translate_3FigureHexVal_ReturnsRGBWhereSingleDigitIsExpandedToTwoOfSameDigit()
        {
            var result = HTMLColorTranslator.Translate("#F2B");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0xFF);
            Assert.AreEqual(result.G, 0x22);
            Assert.AreEqual(result.B, 0xBB);
        }

        [Test]
        public void Translate_3FigureHexVal_CaseInsensitive()
        {
            var result = HTMLColorTranslator.Translate("#f2b");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0xFF);
            Assert.AreEqual(result.G, 0x22);
            Assert.AreEqual(result.B, 0xBB);
            result = HTMLColorTranslator.Translate("#f2B");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0xFF);
            Assert.AreEqual(result.G, 0x22);
            Assert.AreEqual(result.B, 0xBB);
        }

        [Test]
        public void Translate_NamedColor_ReturnsRGBEquivalent()
        {
            var result = HTMLColorTranslator.Translate("slateblue");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
        }

        [Test]
        public void Translate_NamedColor_CaseInsensitive()
        {
            var result = HTMLColorTranslator.Translate("SLATEBLUE");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
            result = HTMLColorTranslator.Translate("SlateBlue");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
            result = HTMLColorTranslator.Translate("sLaTeBlUe");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
        }

        [Test]
        public void Translate_NullInput_Throws()
        {
            Assert.IsInstanceOf(typeof(NullReferenceException), Assert.Catch(()=> HTMLColorTranslator.Translate(null)));
        }

        [Test]
        public void Translate_UnrecognisedInput_Throws()
        {
            Assert.IsInstanceOf(typeof(ArgumentException), Assert.Catch(() => HTMLColorTranslator.Translate("NOT A HTML COLOR")));
        }

        [Test]
        public void Translate_HexValueNot3Or6Long_Throws()
        {
            Assert.IsInstanceOf(typeof(ArgumentException), Assert.Catch(() => HTMLColorTranslator.Translate("#22")));
            Assert.IsInstanceOf(typeof(ArgumentException), Assert.Catch(() => HTMLColorTranslator.Translate("#F423")));
            Assert.IsInstanceOf(typeof(ArgumentException), Assert.Catch(() => HTMLColorTranslator.Translate("#F3A45DD")));
        }
        [Test]
        public void Translate_TrailingOrLeadingWhitespace_Trims()
        {
            var result = HTMLColorTranslator.Translate("    #1A3F44");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0x1A);
            Assert.AreEqual(result.G, 0x3F);
            Assert.AreEqual(result.B, 0x44);
            result = HTMLColorTranslator.Translate("  #F2B ");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 0xFF);
            Assert.AreEqual(result.G, 0x22);
            Assert.AreEqual(result.B, 0xBB);
            result = HTMLColorTranslator.Translate("slateblue    ");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
            result = HTMLColorTranslator.Translate("  SlateBlue ");
            Assert.AreEqual(result.A, 0xFF);
            Assert.AreEqual(result.R, 106);
            Assert.AreEqual(result.G, 90);
            Assert.AreEqual(result.B, 205);
        }
    }
}
