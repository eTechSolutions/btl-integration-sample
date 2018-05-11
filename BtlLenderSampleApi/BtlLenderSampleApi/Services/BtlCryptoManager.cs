using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BtlLenderSampleApi.Services
{
    public class BtlCryptoManager : IBtlCryptoManager
    {
        private readonly string _secret;

        public BtlCryptoManager(string secret)
        {
            _secret = secret;
        }

        public string HashPayload(string json)
        {
            var secretBytes = Encoding.UTF8.GetBytes(_secret);
            var contentBytes = Encoding.UTF8.GetBytes(json);

            var hmac = new HMACSHA1(secretBytes);

            using (var ms = new MemoryStream(contentBytes))
            {
                var hashBytes = hmac.ComputeHash(ms);

                return string.Join(string.Empty, hashBytes.Select(b => b.ToString("x2")));
            }
        }
    }
}
