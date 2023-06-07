using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest.Configuration;

namespace azuretest.Web.Host.Startup
{
    [DependsOn(
       typeof(azuretestWebCoreModule))]
    public class azuretestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public azuretestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(azuretestWebHostModule).GetAssembly());
        }
    }
}
