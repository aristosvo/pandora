using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.Api;


internal class AuthenticationSettingsContractModel
{
    [JsonPropertyName("oAuth2")]
    public OAuth2AuthenticationSettingsContractModel? OAuth2 { get; set; }

    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public List<OAuth2AuthenticationSettingsContractModel>? OAuth2AuthenticationSettings { get; set; }

    [JsonPropertyName("openid")]
    public OpenIdAuthenticationSettingsContractModel? Openid { get; set; }

    [JsonPropertyName("openidAuthenticationSettings")]
    public List<OpenIdAuthenticationSettingsContractModel>? OpenidAuthenticationSettings { get; set; }
}
