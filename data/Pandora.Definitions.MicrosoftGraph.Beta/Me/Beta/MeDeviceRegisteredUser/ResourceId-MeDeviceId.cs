// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeDeviceRegisteredUser;

internal class MeDeviceId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/devices/{deviceId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticDevices", "devices"),
        ResourceIDSegment.UserSpecified("deviceId")
    };
}
