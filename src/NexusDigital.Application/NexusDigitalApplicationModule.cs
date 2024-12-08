using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NexusDigital.Authorization;

namespace NexusDigital;

[DependsOn(
    typeof(NexusDigitalCoreModule),
    typeof(AbpAutoMapperModule))]
public class NexusDigitalApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<NexusDigitalAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(NexusDigitalApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
