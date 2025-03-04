using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_03_01.ScheduledActions;


internal class SchedulePropertiesModel
{
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    [JsonPropertyName("daysOfWeek")]
    public List<DaysOfWeekConstant>? DaysOfWeek { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("endDate")]
    [Required]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("frequency")]
    [Required]
    public ScheduleFrequencyConstant Frequency { get; set; }

    [JsonPropertyName("hourOfDay")]
    public int? HourOfDay { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("startDate")]
    [Required]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("weeksOfMonth")]
    public List<WeeksOfMonthConstant>? WeeksOfMonth { get; set; }
}
