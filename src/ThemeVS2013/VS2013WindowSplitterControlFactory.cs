using Coding4Fun.WinFormUI.Docking;

namespace Coding4Fun.WinFormUI.ThemeVS2013
{
    internal class VS2013WindowSplitterControlFactory : DockPanelExtender.IWindowSplitterControlFactory
    {
        public SplitterBase CreateSplitterControl(ISplitterHost host)
        {
            return new VS2013WindowSplitterControl(host);
        }
    }
}
