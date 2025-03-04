using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.BenefitUtilizationSummaries;

internal class SavingsPlanId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftBillingBenefits", "Microsoft.BillingBenefits"),
        ResourceIDSegment.Static("staticSavingsPlanOrders", "savingsPlanOrders"),
        ResourceIDSegment.UserSpecified("savingsPlanOrderId"),
        ResourceIDSegment.Static("staticSavingsPlans", "savingsPlans"),
        ResourceIDSegment.UserSpecified("savingsPlanId"),
    };
}
