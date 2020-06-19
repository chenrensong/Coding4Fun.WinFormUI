using Coding4Fun.WinFormUI.Docking;

namespace Coding4Fun.WinFormUI.ThemeVS2012
{
    internal class VS2012DockPaneSplitterControlFactory : DockPanelExtender.IDockPaneSplitterControlFactory
    {
        public DockPane.SplitterControlBase CreateSplitterControl(DockPane pane)
        {
            return new VS2012SplitterControl(pane);
        }
    }
}
