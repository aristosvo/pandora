// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class VirtualEventWebinarModel
{
    [JsonPropertyName("audience")]
    public VirtualEventWebinarAudienceConstant? Audience { get; set; }

    [JsonPropertyName("coOrganizers")]
    public List<CommunicationsUserIdentityModel>? CoOrganizers { get; set; }

    [JsonPropertyName("createdBy")]
    public CommunicationsIdentitySetModel? CreatedBy { get; set; }

    [JsonPropertyName("description")]
    public ItemBodyModel? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("endDateTime")]
    public DateTimeTimeZoneModel? EndDateTime { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("registrations")]
    public List<VirtualEventRegistrationModel>? Registrations { get; set; }

    [JsonPropertyName("sessions")]
    public List<VirtualEventSessionModel>? Sessions { get; set; }

    [JsonPropertyName("startDateTime")]
    public DateTimeTimeZoneModel? StartDateTime { get; set; }

    [JsonPropertyName("status")]
    public VirtualEventWebinarStatusConstant? Status { get; set; }
}
