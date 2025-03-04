// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserSecurityInformationProtectionSensitivityLabelParent;

internal class UserIdSecurityInformationProtectionSensitivityLabelId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/security/informationProtection/sensitivityLabels/{sensitivityLabelId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticSecurity", "security"),
        ResourceIDSegment.Static("staticInformationProtection", "informationProtection"),
        ResourceIDSegment.Static("staticSensitivityLabels", "sensitivityLabels"),
        ResourceIDSegment.UserSpecified("sensitivityLabelId")
    };
}
