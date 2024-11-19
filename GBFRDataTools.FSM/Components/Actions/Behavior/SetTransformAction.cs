﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetTransformAction : ActionComponent
{
    [JsonPropertyName("position_")]
    public cVec4 Position { get; set; }

    [JsonPropertyName("rotation_")]
    public cVec4 Rotation { get; set; }
}
