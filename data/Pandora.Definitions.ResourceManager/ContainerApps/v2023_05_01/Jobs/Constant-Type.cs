using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.Jobs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TypeConstant
{
    [Description("Liveness")]
    Liveness,

    [Description("Readiness")]
    Readiness,

    [Description("Startup")]
    Startup,
}
