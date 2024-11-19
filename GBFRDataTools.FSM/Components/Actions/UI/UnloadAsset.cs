﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class UnloadAsset : ActionComponent
{
    [JsonPropertyName("count_")]
    public int Count { get; set; }

    [JsonPropertyName("categories_")]
    public BindingList<EnumString> Categories { get; set; }
}
