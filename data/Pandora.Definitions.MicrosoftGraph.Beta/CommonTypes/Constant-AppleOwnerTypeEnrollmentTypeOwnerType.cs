// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AppleOwnerTypeEnrollmentTypeOwnerTypeConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Company")]
    @company,

    [Description("Personal")]
    @personal,
}
