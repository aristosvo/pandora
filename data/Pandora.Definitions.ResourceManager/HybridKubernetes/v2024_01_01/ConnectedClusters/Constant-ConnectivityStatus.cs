using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.HybridKubernetes.v2024_01_01.ConnectedClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConnectivityStatusConstant
{
    [Description("Connected")]
    Connected,

    [Description("Connecting")]
    Connecting,

    [Description("Expired")]
    Expired,

    [Description("Offline")]
    Offline,
}
