using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    [TestClass]
    public class DateTimeConverterTests
    {
        [TestMethod]
        public void When_Convert_is_called_with_a_valid_datetime_string_then_the_result_is_a_valid_DateTime_instance()
        {
            const string soundCloudDateTime = "2009/08/13 18:30:10 +0000";
            var converter = new DateTimeConverter();
            var result = converter.Convert(soundCloudDateTime);

            Assert.IsTrue(result.HasValue);

            Assert.AreEqual(2009, result.Value.Year);
            Assert.AreEqual(8, result.Value.Month);
            Assert.AreEqual(13, result.Value.Day);
            Assert.AreEqual(18, result.Value.Hour);
            Assert.AreEqual(30, result.Value.Minute);
            Assert.AreEqual(10, result.Value.Second);
        }

        [TestMethod]
        public void When_Convert_is_called_with_a_null_datetime_string_then_the_result_is_a_valid_DateTime_instance()
        {
            var converter = new DateTimeConverter();
            var result = converter.Convert(null);

            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void When_Convert_is_called_with_an_invalid_datetime_string_then_the_result_is_a_valid_DateTime_instance()
        {
            const string soundCloudDateTime = "20090813 18:30:10 +0000";
            var converter = new DateTimeConverter();
            var result = converter.Convert(soundCloudDateTime);

            Assert.IsFalse(result.HasValue);
        }
    }
}