using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.Devices;


internal class UpdateDetailsModel
{
    [JsonPropertyName("estimatedInstallTimeInMins")]
    public int? EstimatedInstallTimeInMins { get; set; }

    [JsonPropertyName("friendlyVersionNumber")]
    public string? FriendlyVersionNumber { get; set; }

    [JsonPropertyName("installationImpact")]
    public InstallationImpactConstant? InstallationImpact { get; set; }

    [JsonPropertyName("rebootBehavior")]
    public InstallRebootBehaviorConstant? RebootBehavior { get; set; }

    [JsonPropertyName("status")]
    public UpdateStatusConstant? Status { get; set; }

    [JsonPropertyName("targetVersion")]
    public string? TargetVersion { get; set; }

    [JsonPropertyName("updateSize")]
    public float? UpdateSize { get; set; }

    [JsonPropertyName("updateTitle")]
    public string? UpdateTitle { get; set; }

    [JsonPropertyName("updateType")]
    public UpdateTypeConstant? UpdateType { get; set; }
}
