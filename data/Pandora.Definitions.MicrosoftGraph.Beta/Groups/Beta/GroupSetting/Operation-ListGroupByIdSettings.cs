// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSetting;

internal class ListGroupByIdSettingsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new GroupId();
    public override Type NestedItemType() => typeof(DirectorySettingCollectionResponseModel);
    public override string? UriSuffix() => "/settings";
}
