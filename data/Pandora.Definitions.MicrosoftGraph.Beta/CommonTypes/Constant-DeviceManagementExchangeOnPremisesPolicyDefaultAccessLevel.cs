// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeviceManagementExchangeOnPremisesPolicyDefaultAccessLevelConstant
{
    [Description("None")]
    @none,

    [Description("Allow")]
    @allow,

    [Description("Block")]
    @block,

    [Description("Quarantine")]
    @quarantine,
}
