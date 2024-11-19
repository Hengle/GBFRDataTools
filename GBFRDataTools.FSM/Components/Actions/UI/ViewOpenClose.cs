﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ViewOpenClose : ActionComponent
{
    [JsonPropertyName("views_")]
    public BindingList<string> Views { get; set; }

    [JsonPropertyName("count_")]
    public int Count { get; set; }

    [JsonPropertyName("layerOffset_")]
    public int LayerOffset { get; set; }

    [JsonPropertyName("openSkip_")]
    public bool OpenSkip { get; set; }

    [JsonPropertyName("closeSkip_")]
    public bool CloseSkip { get; set; }
}
