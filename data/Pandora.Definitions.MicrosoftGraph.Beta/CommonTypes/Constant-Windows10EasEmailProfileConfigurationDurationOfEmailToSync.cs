// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum Windows10EasEmailProfileConfigurationDurationOfEmailToSyncConstant
{
    [Description("UserDefined")]
    @userDefined,

    [Description("OneDay")]
    @oneDay,

    [Description("ThreeDays")]
    @threeDays,

    [Description("OneWeek")]
    @oneWeek,

    [Description("TwoWeeks")]
    @twoWeeks,

    [Description("OneMonth")]
    @oneMonth,

    [Description("Unlimited")]
    @unlimited,
}
