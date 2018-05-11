using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace BtlLenderSampleApi.Services
{
    public class BtlPayloadValidator : IBtlPayloadValidator
    {
        private const string BtlSignatureHeader = "X-Btl-Signature";

        private readonly IBtlCryptoManager _cryptoManager;

        public BtlPayloadValidator(IBtlCryptoManager cryptoManager)
        {
            _cryptoManager = cryptoManager;
        }

        public bool IsPayloadValid(HttpRequest request, out string payload)
        {
            payload = ReadRequestBody(request);
            var hashedBody = _cryptoManager.HashPayload(payload);

            var hashedPayload = ReadHashedPayload(request);

            return string.Equals(hashedBody, hashedPayload);
        }

        private string ReadRequestBody(HttpRequest request)
        {
            using (var streamReader = new StreamReader(request.Body))
            {
                return streamReader.ReadToEnd();
            }
        }

        private string ReadHashedPayload(HttpRequest request)
        {
            return request.Headers[BtlSignatureHeader].FirstOrDefault();
        }
    }
}
