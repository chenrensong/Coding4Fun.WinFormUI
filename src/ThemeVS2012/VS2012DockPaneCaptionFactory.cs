using Coding4Fun.WinFormUI.Docking;

namespace Coding4Fun.WinFormUI.ThemeVS2012
{
    internal class VS2012DockPaneCaptionFactory : DockPanelExtender.IDockPaneCaptionFactory
    {
        public DockPaneCaptionBase CreateDockPaneCaption(DockPane pane)
        {
            return new VS2012DockPaneCaption(pane);
        }
    }
}
