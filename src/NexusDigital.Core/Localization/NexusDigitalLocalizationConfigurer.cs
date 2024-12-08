using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NexusDigital.Localization;

public static class NexusDigitalLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(NexusDigitalConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(NexusDigitalLocalizationConfigurer).GetAssembly(),
                    "NexusDigital.Localization.SourceFiles"
                )
            )
        );
    }
}
