using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_05_01.DeletedBackupInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SecretStoreTypeConstant
{
    [Description("AzureKeyVault")]
    AzureKeyVault,

    [Description("Invalid")]
    Invalid,
}
