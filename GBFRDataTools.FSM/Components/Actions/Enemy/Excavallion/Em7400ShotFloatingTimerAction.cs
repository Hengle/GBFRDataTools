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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Excavallion;

public class Em7400ShotFloatingTimerAction : ShotAttackAction
{
    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; }

    [JsonPropertyName("isForceSet_")]
    public bool IsForceSet { get; set; }
}
