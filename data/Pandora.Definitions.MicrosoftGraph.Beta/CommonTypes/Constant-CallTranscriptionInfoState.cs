// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CallTranscriptionInfoStateConstant
{
    [Description("NotStarted")]
    @notStarted,

    [Description("Active")]
    @active,

    [Description("Inactive")]
    @inactive,
}
