// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupSiteTermStoreSetTermChildrenRelation;

internal class GroupIdSiteIdTermStoreSetIdTermIdChildrenId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/sites/{siteId}/termStore/sets/{setId}/terms/{termId}/children/{termId1}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteId"),
        ResourceIDSegment.Static("staticTermStore", "termStore"),
        ResourceIDSegment.Static("staticSets", "sets"),
        ResourceIDSegment.UserSpecified("setId"),
        ResourceIDSegment.Static("staticTerms", "terms"),
        ResourceIDSegment.UserSpecified("termId"),
        ResourceIDSegment.Static("staticChildren", "children"),
        ResourceIDSegment.UserSpecified("termId1")
    };
}
