// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.SetGroupSiteTermStoreGroupSetTermChildren;

internal class GroupIdSiteIdTermStoreIdGroupIdSetIdTermIdChildrenId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/sites/{siteId}/termStores/{storeId}/groups/{groupId1}/sets/{setId}/terms/{termId}/children/{termId1}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteId"),
        ResourceIDSegment.Static("staticTermStores", "termStores"),
        ResourceIDSegment.UserSpecified("storeId"),
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId1"),
        ResourceIDSegment.Static("staticSets", "sets"),
        ResourceIDSegment.UserSpecified("setId"),
        ResourceIDSegment.Static("staticTerms", "terms"),
        ResourceIDSegment.UserSpecified("termId"),
        ResourceIDSegment.Static("staticChildren", "children"),
        ResourceIDSegment.UserSpecified("termId1")
    };
}
