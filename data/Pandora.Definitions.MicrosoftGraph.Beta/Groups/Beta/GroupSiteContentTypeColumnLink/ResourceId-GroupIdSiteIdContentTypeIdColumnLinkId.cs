// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSiteContentTypeColumnLink;

internal class GroupIdSiteIdContentTypeIdColumnLinkId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/sites/{siteId}/contentTypes/{contentTypeId}/columnLinks/{columnLinkId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteId"),
        ResourceIDSegment.Static("staticContentTypes", "contentTypes"),
        ResourceIDSegment.UserSpecified("contentTypeId"),
        ResourceIDSegment.Static("staticColumnLinks", "columnLinks"),
        ResourceIDSegment.UserSpecified("columnLinkId")
    };
}
