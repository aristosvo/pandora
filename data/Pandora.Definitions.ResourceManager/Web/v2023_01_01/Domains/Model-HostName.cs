using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.Domains;


internal class HostNameModel
{
    [JsonPropertyName("azureResourceName")]
    public string? AzureResourceName { get; set; }

    [JsonPropertyName("azureResourceType")]
    public AzureResourceTypeConstant? AzureResourceType { get; set; }

    [JsonPropertyName("customHostNameDnsRecordType")]
    public CustomHostNameDnsRecordTypeConstant? CustomHostNameDnsRecordType { get; set; }

    [JsonPropertyName("hostNameType")]
    public HostNameTypeConstant? HostNameType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("siteNames")]
    public List<string>? SiteNames { get; set; }
}
