using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiAiBlazorLab.Tests {
    public class FakeHandler : HttpMessageHandler {
        private readonly string _json;

        public FakeHandler(string json) {
            _json = json;
        } // End public

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(_json);
            return Task.FromResult(response);
        } // End protected

    } // End class

} // End namespace
