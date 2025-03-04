// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AndroidWorkProfileGeneralDeviceConfigurationPasswordRequiredTypeConstant
{
    [Description("DeviceDefault")]
    @deviceDefault,

    [Description("LowSecurityBiometric")]
    @lowSecurityBiometric,

    [Description("Required")]
    @required,

    [Description("AtLeastNumeric")]
    @atLeastNumeric,

    [Description("NumericComplex")]
    @numericComplex,

    [Description("AtLeastAlphabetic")]
    @atLeastAlphabetic,

    [Description("AtLeastAlphanumeric")]
    @atLeastAlphanumeric,

    [Description("AlphanumericWithSymbols")]
    @alphanumericWithSymbols,
}
