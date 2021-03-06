﻿using Entropy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Tuples;
using Turnable.Components;
using Turnable.Locations;

namespace Turnable.Api
{
    public interface IViewport
    {
        // ----------------
        // Public interface
        // ----------------

        // Methods

        // Properties
        ILevel Level { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        Position MapOrigin { get; set; }

        // -----------------
        // Private interface
        // -----------------
    }
}
