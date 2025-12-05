using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ApiAiBlazorLab;


namespace ApiAiBlazorLab.Tests {
    public class TestUtilitiesTests {

        [Fact]
        public void NullInput() {

            string result = ApiAiBlazorLab.TextUtilities.NormalizeFact(null);
            Assert.Equal("No fact available.", result);

        } // End test


        [Fact]
        public void EmptyInput() {

            string result = ApiAiBlazorLab.TextUtilities.NormalizeFact("");
            Assert.Equal("No fact available.", result);

        } // End test


        [Fact]
        public void MissingInput() {

            string result = ApiAiBlazorLab.TextUtilities.NormalizeFact("."!);
            Assert.Equal("No fact available.", result);

        } // End test


        [Fact]
        public void ExistingInput() {

            string result = ApiAiBlazorLab.TextUtilities.NormalizeFact(".");
            Assert.Equal("No fact available.", result);

        } // End test


        [Fact]
        public void ExtraInput() {

            string result = ApiAiBlazorLab.TextUtilities.NormalizeFact(" ");
            Assert.Equal("No fact available.", result);

        } // End test

    } // End class
} // End namespace
