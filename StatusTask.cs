﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Group11_Project
{
    public enum StatusTask
    {
        Done,
        [Description("In Process")] InProcess,
        Late,
        Archived,
        Canceled
    }
}
