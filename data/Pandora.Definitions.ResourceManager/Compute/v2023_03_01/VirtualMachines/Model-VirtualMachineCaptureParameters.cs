using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.VirtualMachines;


internal class VirtualMachineCaptureParametersModel
{
    [JsonPropertyName("destinationContainerName")]
    [Required]
    public string DestinationContainerName { get; set; }

    [JsonPropertyName("overwriteVhds")]
    [Required]
    public bool OverwriteVhds { get; set; }

    [JsonPropertyName("vhdPrefix")]
    [Required]
    public string VhdPrefix { get; set; }
}
