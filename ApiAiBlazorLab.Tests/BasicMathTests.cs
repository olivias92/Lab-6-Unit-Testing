using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiAiBlazorLab.Tests {
    public class BasicMathTests {

        [Fact]
        public void AddNumbers_ReturnsSum() {

            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a + b;

            // Assert 
            Assert.Equal(5, result);

        } // End void


    } // End class
} // End namespace
