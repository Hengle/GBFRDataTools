﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class Pl1800DoubleHateControlAction : ActionComponent
{
    [JsonPropertyName("areaRadius_")]
    public float AreaRadius { get; set; }
}
