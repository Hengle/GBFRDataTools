﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Maglielle;

public class Em2100SetVisibleBarrierAction : ActionComponent
{
    [JsonPropertyName("visible_")]
    public bool Visible { get; set; }
}