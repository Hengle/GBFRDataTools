﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetExcavallionInfo : QuestConditionComponent
{
    [JsonPropertyName("cut2Pos_")]
    public BindingList<ulong> Cut2Pos { get; set; } // 4 elem

    [JsonPropertyName("excavallionPosHash_")]
    public ulong ExcavallionPosHash { get; set; }
}
