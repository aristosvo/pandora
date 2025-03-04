using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.RegisteredServerResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServerAuthTypeConstant
{
    [Description("Certificate")]
    Certificate,

    [Description("ManagedIdentity")]
    ManagedIdentity,
}
