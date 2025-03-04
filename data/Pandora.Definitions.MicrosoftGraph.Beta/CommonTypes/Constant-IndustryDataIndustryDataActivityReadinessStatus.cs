// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum IndustryDataIndustryDataActivityReadinessStatusConstant
{
    [Description("NotReady")]
    @notReady,

    [Description("Ready")]
    @ready,

    [Description("Failed")]
    @failed,

    [Description("Disabled")]
    @disabled,

    [Description("Expired")]
    @expired,
}
