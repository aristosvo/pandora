using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.PrefixListGlobalRulestack;

internal class PrefixListId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixLists/{prefixListName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticPaloAltoNetworksCloudngfw", "PaloAltoNetworks.Cloudngfw"),
        ResourceIDSegment.Static("staticGlobalRulestacks", "globalRulestacks"),
        ResourceIDSegment.UserSpecified("globalRulestackName"),
        ResourceIDSegment.Static("staticPrefixLists", "prefixLists"),
        ResourceIDSegment.UserSpecified("prefixListName"),
    };
}
