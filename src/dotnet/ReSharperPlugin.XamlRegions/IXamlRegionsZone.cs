using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Xaml;

namespace ReSharperPlugin.XamlRegions
{
    [ZoneDefinition]
    public interface IXamlRegionsZone : IPsiLanguageZone,
        IRequire<ILanguageXamlZone>,
        IRequire<DaemonZone>
    {
    }
}