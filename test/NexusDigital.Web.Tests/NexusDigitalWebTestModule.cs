using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NexusDigital.EntityFrameworkCore;
using NexusDigital.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NexusDigital.Web.Tests;

[DependsOn(
    typeof(NexusDigitalWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class NexusDigitalWebTestModule : AbpModule
{
    public NexusDigitalWebTestModule(NexusDigitalEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(NexusDigitalWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(NexusDigitalWebMvcModule).Assembly);
    }
}