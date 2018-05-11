using Microsoft.AspNetCore.Http;

namespace BtlLenderSampleApi.Services
{
    public interface IBtlPayloadValidator
    {
        bool IsPayloadValid(HttpRequest request, out string payload);
    }
}
