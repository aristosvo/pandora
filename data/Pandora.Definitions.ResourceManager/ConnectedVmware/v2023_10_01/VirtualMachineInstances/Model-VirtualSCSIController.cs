using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ConnectedVmware.v2023_10_01.VirtualMachineInstances;


internal class VirtualSCSIControllerModel
{
    [JsonPropertyName("busNumber")]
    public int? BusNumber { get; set; }

    [JsonPropertyName("controllerKey")]
    public int? ControllerKey { get; set; }

    [JsonPropertyName("scsiCtlrUnitNumber")]
    public int? ScsiCtlrUnitNumber { get; set; }

    [JsonPropertyName("sharing")]
    public VirtualSCSISharingConstant? Sharing { get; set; }

    [JsonPropertyName("type")]
    public SCSIControllerTypeConstant? Type { get; set; }
}
