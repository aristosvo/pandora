using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SystemCenterVirtualMachineManager.v2023_10_07.InventoryItems;


internal class InventoryItemDetailsModel
{
    [JsonPropertyName("inventoryItemId")]
    public string? InventoryItemId { get; set; }

    [JsonPropertyName("inventoryItemName")]
    public string? InventoryItemName { get; set; }
}
