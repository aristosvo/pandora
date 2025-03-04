// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class X509CertificateRuleModel
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("issuerSubjectIdentifier")]
    public string? IssuerSubjectIdentifier { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("policyOidIdentifier")]
    public string? PolicyOidIdentifier { get; set; }

    [JsonPropertyName("x509CertificateAuthenticationMode")]
    public X509CertificateRuleX509CertificateAuthenticationModeConstant? X509CertificateAuthenticationMode { get; set; }

    [JsonPropertyName("x509CertificateRequiredAffinityLevel")]
    public X509CertificateRuleX509CertificateRequiredAffinityLevelConstant? X509CertificateRequiredAffinityLevel { get; set; }

    [JsonPropertyName("x509CertificateRuleType")]
    public X509CertificateRuleX509CertificateRuleTypeConstant? X509CertificateRuleType { get; set; }
}
