using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest.Authorization;

namespace azuretest
{
    [DependsOn(
        typeof(azuretestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class azuretestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<azuretestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(azuretestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
