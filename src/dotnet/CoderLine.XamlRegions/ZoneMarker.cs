using JetBrains.Application.BuildScript.Application.Zones;

namespace ReSharperPlugin.XamlRegions
{
    [ZoneMarker]
    public class ZoneMarker : IRequire<IXamlRegionsZone>
    {
    }
}