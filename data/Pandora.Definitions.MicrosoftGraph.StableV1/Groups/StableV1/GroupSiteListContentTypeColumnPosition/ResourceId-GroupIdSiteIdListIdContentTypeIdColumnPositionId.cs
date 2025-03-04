// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupSiteListContentTypeColumnPosition;

internal class GroupIdSiteIdListIdContentTypeIdColumnPositionId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/sites/{siteId}/lists/{listId}/contentTypes/{contentTypeId}/columnPositions/{columnDefinitionId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteId"),
        ResourceIDSegment.Static("staticLists", "lists"),
        ResourceIDSegment.UserSpecified("listId"),
        ResourceIDSegment.Static("staticContentTypes", "contentTypes"),
        ResourceIDSegment.UserSpecified("contentTypeId"),
        ResourceIDSegment.Static("staticColumnPositions", "columnPositions"),
        ResourceIDSegment.UserSpecified("columnDefinitionId")
    };
}
