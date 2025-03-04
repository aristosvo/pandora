using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CosmosDB.v2023_09_15.CosmosDB;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DefaultConsistencyLevelConstant
{
    [Description("BoundedStaleness")]
    BoundedStaleness,

    [Description("ConsistentPrefix")]
    ConsistentPrefix,

    [Description("Eventual")]
    Eventual,

    [Description("Session")]
    Session,

    [Description("Strong")]
    Strong,
}
