using rNascar26.ViewModels;

namespace rNascar26.CustomViews
{
    public class GridStyleSettings : INamedItem
    {
        public string Name { get; set; }
        public GridStyle GridStyle { get; set; } = GridStyle.GetDefaultGridStyle();
        public GridRowStyle HeaderStyle { get; set; } = GridRowStyle.GetDefaultGridRowStyle();
        public GridRowStyle RowStyle { get; set; } = GridRowStyle.GetDefaultGridRowStyle();
        public GridRowStyle AlternatingRowStyle { get; set; } = GridRowStyle.GetDefaultGridRowStyle();
        public GridRowStyle SelectedRowStyle { get; set; } = GridRowStyle.GetDefaultGridRowStyle();

        public static GridStyleSettings GetDefaultGridStyleSettings()
        {
            return new GridStyleSettings();
        }
    }
}
