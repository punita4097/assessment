#pragma checksum "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3eb5ea86c56913ff628f9577a129b59dcc709f9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/databinding")]
    public partial class Question4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>One-way Data Binding</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    In one-way binding, we need to pass property or variable name along with special symbol.<br>\r\n    In One-way data-binding no special attribute is required like in other binding.<br>\r\n</p>\r\n");
            __builder.AddMarkupContent(2, "<label>Enter Name</label>\r\n");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "col-sm-3");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                         Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<hr>\r\n");
            __builder.AddMarkupContent(7, "<h3>Two-way Data Binding</h3>\r\n");
            __builder.AddMarkupContent(8, @"<p>
    Blazor supports two-way binding. This can be achieved by using ""bind"" attribute.<br>
    The current version of Blazor supports the following types for two-way binding.<br>
    <ul>
        <li>string</li>
        <li>int</li>
        <li>DateTime</li>
        <li>Enum</li>
        <li>bool</li>
    </ul>

</p>
<br>
<br>
");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "placeholder", "Name");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                                              FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "placeholder", "Surname");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                                                 LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(21, "<h3>Three-way Data Binding</h3>\r\n");
            __builder.AddMarkupContent(22, "<p>\r\n    The current version of Blazor, event binding is very limited.\r\n    <br>Currently, it only supports onclick and on change event.\r\n</p>\r\n");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "placeholder", "Name");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                                              FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "placeholder", "Surname");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                                                 LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n\r\n");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "value", "Submit");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                                              Concatenate

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n<br>\r\n");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "readonly", true);
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
                        finalresult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => finalresult = __value, finalresult));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Punita Yadav\BlazorComplete\BlazorBasic\BlazorIntroduction1\Pages\Question4.razor"
  
    string Name = "Punita";
    string FirstName;
    string LastName;
    string finalresult;
    void Concatenate()
    {
        finalresult = FirstName + LastName;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
