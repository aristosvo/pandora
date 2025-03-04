using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2022_06_01.PolicyAssignments;

internal class PolicyAssignmentIdId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/{policyAssignmentId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.UserSpecified("policyAssignmentId"),
    };
}
