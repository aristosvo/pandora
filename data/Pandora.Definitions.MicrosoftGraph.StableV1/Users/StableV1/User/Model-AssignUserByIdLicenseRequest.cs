// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.User;

internal class AssignUserByIdLicenseRequestModel
{
    [JsonPropertyName("addLicenses")]
    public List<AssignedLicenseModel>? AddLicenses { get; set; }

    [JsonPropertyName("removeLicenses")]
    public List<string>? RemoveLicenses { get; set; }
}
