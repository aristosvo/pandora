using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.ExpressRouteLinks;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExpressRouteLinkMacSecSciStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
