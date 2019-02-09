using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace QuickInvoice.Config
{
    public class MixManifest
    {

        public MixManifest(IHostingEnvironment env)
        {
            var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(env.WebRootPath)
                    .AddJsonFile("mix-manifest.json", optional: true);
            config = configBuilder.Build();

        }

        public IConfigurationRoot config { get; private set; }
    }
}