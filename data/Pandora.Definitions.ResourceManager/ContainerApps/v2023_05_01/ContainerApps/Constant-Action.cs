using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ContainerApps;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ActionConstant
{
    [Description("Allow")]
    Allow,

    [Description("Deny")]
    Deny,
}
