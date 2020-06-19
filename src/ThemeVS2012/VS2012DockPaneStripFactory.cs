using Coding4Fun.WinFormUI.Docking;

namespace Coding4Fun.WinFormUI.ThemeVS2012
{
    internal class VS2012DockPaneStripFactory : DockPanelExtender.IDockPaneStripFactory
    {
        public DockPaneStripBase CreateDockPaneStrip(DockPane pane)
        {
            return new VS2012DockPaneStrip(pane);
        }
    }
}
