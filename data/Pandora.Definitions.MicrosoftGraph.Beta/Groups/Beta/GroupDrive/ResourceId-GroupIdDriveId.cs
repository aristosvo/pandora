// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupDrive;

internal class GroupIdDriveId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/drives/{driveId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticDrives", "drives"),
        ResourceIDSegment.UserSpecified("driveId")
    };
}
