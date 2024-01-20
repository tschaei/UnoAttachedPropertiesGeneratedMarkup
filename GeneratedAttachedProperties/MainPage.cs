using CommunityToolkit.WinUI.UI.Controls;
using Microsoft.UI.Xaml;
using Uno.Extensions.Markup.Generator;

[assembly: GenerateMarkupForAssembly(typeof(DockPanel))]

namespace GeneratedAttachedProperties;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this
            .Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
            .Content(new StackPanel()
            .VerticalAlignment(VerticalAlignment.Center)
            .HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                new DockPanel()
                    .Children(
                        new StackPanel()
                            .DockPanel(dock: Dock.Top)
                            .Children(
                                new TextBlock()
                                    .Text("Hello Uno Platform!"),
                                new Button()
                                    .Content("Press me!")
                            ),
                        new TextBlock()
                            .Text("Hi there!")
                    )
            ));
    }
}
