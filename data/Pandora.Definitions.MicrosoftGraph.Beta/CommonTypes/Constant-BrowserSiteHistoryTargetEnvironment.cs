// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BrowserSiteHistoryTargetEnvironmentConstant
{
    [Description("InternetExplorerMode")]
    @internetExplorerMode,

    [Description("InternetExplorer11")]
    @internetExplorer11,

    [Description("MicrosoftEdge")]
    @microsoftEdge,

    [Description("Configurable")]
    @configurable,

    [Description("None")]
    @none,
}
