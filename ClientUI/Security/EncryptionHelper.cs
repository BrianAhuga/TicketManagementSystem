using Jose;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace ClientUI.Security
{
    public class EncryptionHelper<T> where T : class
    {
        byte[] secretkey;
        private readonly IConfiguration configuration;

        public EncryptionHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
            secretkey = Encoding.UTF8.GetBytes(configuration["JWEKey"]);
        }

        public string Encode(object obj)
        {
            return JWT.Encode(obj, secretkey, JweAlgorithm.A256KW,
                JweEncryption.A256CBC_HS512);
        }

        public T Decode(string token)
        {
            var result = JWT.Decode(token, secretkey, JweAlgorithm.A256KW,
                JweEncryption.A256CBC_HS512);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
