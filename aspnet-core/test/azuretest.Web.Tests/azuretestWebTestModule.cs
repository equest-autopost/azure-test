using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest.EntityFrameworkCore;
using azuretest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace azuretest.Web.Tests
{
    [DependsOn(
        typeof(azuretestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class azuretestWebTestModule : AbpModule
    {
        public azuretestWebTestModule(azuretestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(azuretestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(azuretestWebMvcModule).Assembly);
        }
    }
}