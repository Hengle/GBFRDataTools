﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class BlackBoardFloatAction : BlackBoardAction
{
    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0.0f;
}
