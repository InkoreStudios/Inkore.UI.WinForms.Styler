﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inkore.UI.WinForms.Styler.Native {
    internal static class IntHelpers {

        public static ushort LowWord(uint val) {
            return (ushort)val;
        }

        public static ushort HighWord(uint val) {
            return (ushort)(val >> 16);
        }

    }
}
