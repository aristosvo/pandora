// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserWindowsInformationProtectionDeviceRegistration;

internal class ListUserByIdWindowsInformationProtectionDeviceRegistrationsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new UserId();
    public override Type NestedItemType() => typeof(WindowsInformationProtectionDeviceRegistrationCollectionResponseModel);
    public override string? UriSuffix() => "/windowsInformationProtectionDeviceRegistrations";
}
