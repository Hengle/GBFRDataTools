﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7700ShotMoveFallAction : ActionComponent
{
    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 0.0f;

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 0.0f;

    [JsonPropertyName("slowTimeRate_")]
    public float SlowTimeRate { get; set; } = 0.1f;

    [JsonPropertyName("minHeight_")]
    public float MinHeight { get; set; } = -10.0f;
}
