﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300PointJumpAction : ActionComponent
{
    [JsonPropertyName("toDoppel_")]
    public bool ToDoppel { get; set; }

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; }
}
