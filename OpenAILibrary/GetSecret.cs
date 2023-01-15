using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAILibrary
{
    public class GetSecret
    {
        public string GetSecretByKey(string key)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<GetSecret>().Build();
            var secretProvider = config.Providers.First();
            try
            {
                secretProvider.TryGet(key.ToUpper(), out var secret);
                return secret;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }


}
