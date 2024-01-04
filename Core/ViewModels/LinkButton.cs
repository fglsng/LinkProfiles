namespace Core.ViewModels
{
    public enum LinkButtonType
    {
        GenericLayer1,
        GenericLayer2,
        GenericLayer3,
        Facebook,
        Instagram,
    }
    public class LinkButton
    {
        public string? Name { get; set; }
        public string Link { get; set; }
        public string StyleReference { get; set; }
        public LinkButtonType Type { get; set; }
        public string? ToolTipText { get; set; }
        public string? ToolTipLink { get; set; }
        public string? ToolTipLinkName { get; set; }
        public string? IconReference { get; set; }


        public LinkButton(string? name, string link, string styleReference, LinkButtonType type)
        {
            Name = name;
            Link = link;
            StyleReference = styleReference;
            Type = type;
        }
    }
}
