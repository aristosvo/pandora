// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeOnenoteResource;

internal class MeOnenoteResourceId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/onenote/resources/{onenoteResourceId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticOnenote", "onenote"),
        ResourceIDSegment.Static("staticResources", "resources"),
        ResourceIDSegment.UserSpecified("onenoteResourceId")
    };
}
