﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectSoundAction : ActionComponent
{
    [JsonPropertyName("seName_")]
    public string SeName { get; set; } = string.Empty;
     
    [JsonPropertyName("isWorldPositionSet_")]
    public bool IsWorldPositionSet { get; set; } = false;

    [JsonPropertyName("isMaterialCheck_")]
    public bool IsMaterialCheck { get; set; } = false;

    [JsonPropertyName("materialCheckHigh_")]
    public float MaterialCheckHigh { get; set; } = 1.0f;

    [JsonPropertyName("materialCheckLow_")]
    public float MaterialCheckLow { get; set; } = -1.0f;
}