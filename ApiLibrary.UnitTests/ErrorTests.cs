using System;
using System.Collections.Generic;
using Ewk.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    [TestClass]
    public class ErrorTests : UnitTestBase
    {
        [TestMethod]
        public void When_ToString_is_called_and_there_are_more_than_one_errors_then_the_result_contains_all_error_messages()
        {
            var errors = CreateErrors(5);

            var errorsString = errors.ToString();
            Assert.IsFalse(string.IsNullOrEmpty(errorsString));
            Assert.IsTrue(errorsString.Split(new[]{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Length == 5);
        }

        [TestMethod]
        public void When_ToString_is_called_and_there_is_one_error_then_the_result_contains_one_error_messages()
        {
            var errors = CreateErrors(1);

            var errorsString = errors.ToString();
            Assert.IsFalse(string.IsNullOrEmpty(errorsString));
            Assert.IsTrue(errorsString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Length == 1);
        }

        [TestMethod]
        public void When_ToString_is_called_and_there_is_no_error_then_the_result_contains_an_empty_string()
        {
            var errors = CreateErrors(0);

            var errorsString = errors.ToString();
            Assert.IsTrue(string.IsNullOrEmpty(errorsString));
        }

        [TestMethod]
        public void When_ToString_is_called_and_the_errors_are_not_initialized_then_the_result_contains_an_empty_string()
        {
            var errors = new Errors();

            var errorsString = errors.ToString();
            Assert.IsTrue(string.IsNullOrEmpty(errorsString));
        }

        private static Errors CreateErrors(int count)
        {
            var errors = new List<Error>();
            for (var i = 0; i < count; i++)
            {
                errors.Add(CreateError());
            }

            return new Errors {errors = errors};
        }

        private static Error CreateError()
        {
            return new Error {error_message = Guid.NewGuid().ToString()};
        }
    }
}