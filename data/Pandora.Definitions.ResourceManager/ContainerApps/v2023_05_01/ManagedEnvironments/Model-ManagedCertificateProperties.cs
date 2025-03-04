using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ManagedEnvironments;


internal class ManagedCertificatePropertiesModel
{
    [JsonPropertyName("domainControlValidation")]
    public ManagedCertificateDomainControlValidationConstant? DomainControlValidation { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("provisioningState")]
    public CertificateProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("subjectName")]
    public string? SubjectName { get; set; }

    [JsonPropertyName("validationToken")]
    public string? ValidationToken { get; set; }
}
