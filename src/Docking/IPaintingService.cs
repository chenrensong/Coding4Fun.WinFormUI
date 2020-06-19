﻿using System.Drawing;

namespace Coding4Fun.WinFormUI.Docking
{
    public interface IPaintingService
    {
        Pen GetPen(Color color, int thickness = 1);
        SolidBrush GetBrush(Color color);
        void CleanUp();
    }
}
