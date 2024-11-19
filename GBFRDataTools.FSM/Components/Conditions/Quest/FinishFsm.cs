﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class FinishFsm : QuestConditionComponent
{
    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; }

    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; }
}
