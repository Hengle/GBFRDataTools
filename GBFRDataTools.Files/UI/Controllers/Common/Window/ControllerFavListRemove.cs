﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerFavListRemove
public class ControllerFavListRemove // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", UIFieldType.ObjectRef),
        new("Info", UIFieldType.ObjectRef),
        new("FavList", UIFieldType.ObjectRef),
        new("Count", UIFieldType.ObjectRef),
        new("FavMenu", UIFieldType.ObjectRef),
        new(0x94567DD3, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
