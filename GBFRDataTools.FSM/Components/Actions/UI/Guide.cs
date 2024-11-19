﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class Guide : ActionComponent
{
    [JsonPropertyName("guides_")]
    public BindingList<string> Guides { get; set; }

    [JsonPropertyName("count_")]
    public int Count { get; set; }

    [JsonPropertyName("footer_")]
    public EnumString Footer { get; set; }

    [JsonPropertyName("isFixAdd_")]
    public bool IsFixAdd { get; set; }
}
