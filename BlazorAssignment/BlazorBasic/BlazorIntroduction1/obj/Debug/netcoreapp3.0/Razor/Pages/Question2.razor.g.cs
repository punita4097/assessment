#pragma checksum "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a497149f34a42cfe202186cc1395753652f10a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorIntroduction1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using BlazorIntroduction1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\_Imports.razor"
using BlazorIntroduction1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Question2")]
    public partial class Question2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Question2</h1>\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"text-danger\">What is the component and component parameter?</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(2, @"<div>
    <h2 class=""text-primary"">Component</h2>
    <p>
        Blazor apps are built using components.<br>
        A component is a self-contained chunk of user interface (UI), such as a page, dialog, or form.<br>
        In blazor application we create the component in either in pages folder or in shared folder<br>
        The extension of the component is .razor<br>
        The imports.razor component build automatically. In this we import all the classes which is shared by the different component<br>
        A component includes HTML markup and the processing logic required to inject data or respond to UI events.<br>

        Components are flexible and lightweight.<br>
        They can be nested, reused, and shared among projects.<br>
        Components are implemented in Razor component files (.razor) using a combination of C# and HTML markup.<br>
        A component in Blazor is formally referred to as a Razor component.<br>

        A component's name must start with an uppercase character.
        For example,MyComponent.razor is valid, and myComponent.razor is invalid.
        Members of the component class are defined in an code block. In the code block, component state (properties, fields) is specified with methods for event handling or for defining other component logic.
        <br>More than one code block is permissible.
    </p>
</div>
");
            __builder.AddMarkupContent(3, @"<div>
    <h2 class=""text-primary"">Component Parameter</h2>
    <p>
        Components can have component parameters, which are defined using public properties on the component class with the [Parameter] attribute. Use attributes to specify arguments for a component in markup.

    </p>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
