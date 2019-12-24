﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class DropdownItem
    {

        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Dropdowns.Item);
            base.OnParametersSet();
        }
    }
}
