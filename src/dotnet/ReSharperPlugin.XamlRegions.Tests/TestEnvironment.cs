using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.XamlRegions.Tests
{

    [ZoneDefinition]
    public class XamlRegionsTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IXamlRegionsZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<XamlRegionsTestEnvironmentZone> { }
    
    [SetUpFixture]
    public class XamlRegionsTestsAssembly : ExtensionTestEnvironmentAssembly<XamlRegionsTestEnvironmentZone> { }
}