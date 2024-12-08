using Abp.Modules;
using Abp.Reflection.Extensions;
using NexusDigital.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace NexusDigital.Web.Host.Startup
{
    [DependsOn(
       typeof(NexusDigitalWebCoreModule))]
    public class NexusDigitalWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NexusDigitalWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NexusDigitalWebHostModule).GetAssembly());
        }
    }
}
