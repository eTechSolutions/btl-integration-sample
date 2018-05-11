namespace BtlLenderSampleApi.Services
{
    public interface IBtlCryptoManager
    {
        string HashPayload(string json);
    }
}
