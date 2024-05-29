﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::ImageButtonSetter
public class ImageButtonSetter // : ImageSetter
{
    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        return ImageSetter.GetAllProperties();
    }
}
