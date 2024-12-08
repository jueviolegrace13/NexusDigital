using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NexusDigital.Configuration;
using NexusDigital.EntityFrameworkCore;
using NexusDigital.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace NexusDigital.Migrator;

[DependsOn(typeof(NexusDigitalEntityFrameworkModule))]
public class NexusDigitalMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public NexusDigitalMigratorModule(NexusDigitalEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(NexusDigitalMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            NexusDigitalConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(NexusDigitalMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
