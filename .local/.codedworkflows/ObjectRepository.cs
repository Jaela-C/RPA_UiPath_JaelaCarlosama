using UiPath.CodedWorkflows.DescriptorIntegration;

namespace UiPath_RPA_JaelaCarlosama.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace UiPath_RPA_JaelaCarlosama._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }
}