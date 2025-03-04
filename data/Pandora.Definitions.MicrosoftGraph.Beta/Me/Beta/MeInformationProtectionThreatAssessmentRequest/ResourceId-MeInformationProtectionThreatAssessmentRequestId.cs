// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeInformationProtectionThreatAssessmentRequest;

internal class MeInformationProtectionThreatAssessmentRequestId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/informationProtection/threatAssessmentRequests/{threatAssessmentRequestId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticInformationProtection", "informationProtection"),
        ResourceIDSegment.Static("staticThreatAssessmentRequests", "threatAssessmentRequests"),
        ResourceIDSegment.UserSpecified("threatAssessmentRequestId")
    };
}
