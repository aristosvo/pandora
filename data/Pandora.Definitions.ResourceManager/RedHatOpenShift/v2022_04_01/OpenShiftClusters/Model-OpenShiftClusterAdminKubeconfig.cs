using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RedHatOpenShift.v2022_04_01.OpenShiftClusters;


internal class OpenShiftClusterAdminKubeconfigModel
{
    [JsonPropertyName("kubeconfig")]
    public string? Kubeconfig { get; set; }
}
