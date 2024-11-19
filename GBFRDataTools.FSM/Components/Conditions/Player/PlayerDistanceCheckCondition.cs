﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class PlayerDistanceCheckCondition : ConditionComponent
{
    [JsonPropertyName("distance_")]
    public float Distance { get; set; }
}
