using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2021_06_01.AssessmentsMetadata;

internal class AssessmentMetadataId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftSecurity", "Microsoft.Security"),
        ResourceIDSegment.Static("staticAssessmentMetadata", "assessmentMetadata"),
        ResourceIDSegment.UserSpecified("assessmentMetadataName"),
    };
}
