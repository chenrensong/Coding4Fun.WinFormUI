using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Coding4Fun.WinFormUI
{
    public class BetterLinkLabel : LinkLabel
    {
        private static readonly Color DefaultNormalColor = Color.FromArgb(0, 102, 204);

        private static readonly Color DefaultHoverColor = Color.FromArgb(51, 153, 255);

        [Browsable(true)]
        public Color NormalColor
        {
            get;
            set;
        }

        [Browsable(true)]
        public Color HoverColor
        {
            get;
            set;
        }

        public BetterLinkLabel()
        {
            if (!base.DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                NormalColor = DefaultNormalColor;
                HoverColor = DefaultHoverColor;
                base.LinkColor = NormalColor;
                base.ActiveLinkColor = NormalColor;
            }
        }

        internal bool ShouldSerializeNormalColor()
        {
            if (NormalColor != DefaultNormalColor)
            {
                return NormalColor != Color.Empty;
            }
            return false;
        }

        internal bool ShouldSerializeHoverColor()
        {
            if (HoverColor != DefaultHoverColor)
            {
                return HoverColor != Color.Empty;
            }
            return false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll")]
        private static extern int SetCursor(IntPtr hCursor);

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.LinkColor = HoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.LinkColor = NormalColor;
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 32)
            {
                DefWndProc(ref msg);
                IntPtr cursor = LoadCursor(IntPtr.Zero, 32649);
                SetCursor(cursor);
            }
            else
            {
                base.WndProc(ref msg);
            }
        }
    }
}
