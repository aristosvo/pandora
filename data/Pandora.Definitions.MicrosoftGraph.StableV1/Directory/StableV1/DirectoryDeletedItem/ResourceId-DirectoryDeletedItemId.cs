// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Directory.StableV1.DirectoryDeletedItem;

internal class DirectoryDeletedItemId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/directory/deletedItems/{directoryObjectId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticDirectory", "directory"),
        ResourceIDSegment.Static("staticDeletedItems", "deletedItems"),
        ResourceIDSegment.UserSpecified("directoryObjectId")
    };
}
