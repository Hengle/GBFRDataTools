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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001SetWaitOffTargetAction : ActionComponent
{
    [JsonPropertyName("offNpcBattleWaitOffTarget_")]
    public bool OffNpcBattleWaitOffTarget { get; set; } = false;

    [JsonPropertyName("timing_")]
    public int Timing { get; set; } = 0;

}
