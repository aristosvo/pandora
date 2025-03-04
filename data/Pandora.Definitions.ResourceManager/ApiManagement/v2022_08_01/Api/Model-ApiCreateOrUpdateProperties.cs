using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.Api;


internal class ApiCreateOrUpdatePropertiesModel
{
    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    [JsonPropertyName("apiType")]
    public SoapApiTypeConstant? ApiType { get; set; }

    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    [JsonPropertyName("apiVersionSet")]
    public ApiVersionSetContractDetailsModel? ApiVersionSet { get; set; }

    [JsonPropertyName("apiVersionSetId")]
    public string? ApiVersionSetId { get; set; }

    [JsonPropertyName("authenticationSettings")]
    public AuthenticationSettingsContractModel? AuthenticationSettings { get; set; }

    [JsonPropertyName("contact")]
    public ApiContactInformationModel? Contact { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("format")]
    public ContentFormatConstant? Format { get; set; }

    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    [JsonPropertyName("license")]
    public ApiLicenseInformationModel? License { get; set; }

    [JsonPropertyName("path")]
    [Required]
    public string Path { get; set; }

    [JsonPropertyName("protocols")]
    public List<ProtocolConstant>? Protocols { get; set; }

    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    [JsonPropertyName("subscriptionKeyParameterNames")]
    public SubscriptionKeyParameterNamesContractModel? SubscriptionKeyParameterNames { get; set; }

    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    [JsonPropertyName("translateRequiredQueryParameters")]
    public TranslateRequiredQueryParametersConductConstant? TranslateRequiredQueryParameters { get; set; }

    [JsonPropertyName("type")]
    public ApiTypeConstant? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("wsdlSelector")]
    public ApiCreateOrUpdatePropertiesWsdlSelectorModel? WsdlSelector { get; set; }
}
