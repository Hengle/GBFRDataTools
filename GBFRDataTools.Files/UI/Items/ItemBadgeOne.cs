﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemBadgeOne
public class ItemBadgeOne // Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("BadgeInfo", UIFieldType.ObjectRef),
         new("TitleTexts", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
