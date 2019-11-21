using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using taskManager.Authorization;

namespace taskManager
{
    [DependsOn(
        typeof(taskManagerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class taskManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<taskManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(taskManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
