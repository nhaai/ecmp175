using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LTW.Nhom1.Localization
{
    public static class Nhom1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Nhom1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Nhom1LocalizationConfigurer).GetAssembly(),
                        "LTW.Nhom1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
