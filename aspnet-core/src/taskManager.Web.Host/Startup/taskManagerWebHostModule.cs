using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using taskManager.Configuration;

namespace taskManager.Web.Host.Startup
{
    [DependsOn(
       typeof(taskManagerWebCoreModule))]
    public class taskManagerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public taskManagerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(taskManagerWebHostModule).GetAssembly());
        }
    }
}
