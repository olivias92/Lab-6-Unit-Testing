using System;
using System.Collections.Generic;
using System.Text;
using ApiAiBlazorLab.Services;
using Microsoft.AspNetCore.Builder;
using Xunit;

namespace ApiAiBlazorLab.Tests {
 
    public class CatFactServiceTests {
        [Fact]
        public async Task GetRandomFact_ReturnsFact() {
            var json = "{\"fact\":\"Cats sleep 16 hours a day.\",\"length\":32}";
            var client = new HttpClient(new FakeHandler(json));

            var service = new CatFactService(client);

            var result = await service.GetRandomFactAsync();

            Assert.Equal("Cats sleep 16 hours a day.", result);
        } // End async

    } // End class

} // End namespace
