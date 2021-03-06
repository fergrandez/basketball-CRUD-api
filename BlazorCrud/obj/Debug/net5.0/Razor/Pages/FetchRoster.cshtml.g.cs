#pragma checksum "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1905afad65c4c873607c90681b98442e6fbb482b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlazorCrud.Pages.Pages_FetchRoster), @"mvc.1.0.razor-page", @"/Pages/FetchRoster.cshtml")]
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\_ViewImports.cshtml"
using BlazorCrud;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1905afad65c4c873607c90681b98442e6fbb482b", @"/Pages/FetchRoster.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bcf2a59edbe69d3a4c793af9cbe8b07f5729596", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FetchRoster : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
  
    ViewData["Title"] = "FetchRoster";

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n<h1>Player Data</h1>  \r\n<p>This component demonstrates fetching the Roster from the server.</p>  \r\n<p>  \r\n    <a href=\"/addplayer\">Add New Player</a>  \r\n</p>  \r\n\r\n");
#nullable restore
#line 14 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
 if (Model.Roster == null)  
{  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><em>Loading...</em></p>  \r\n");
#nullable restore
#line 17 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
}  
else  
{  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class='table'>  
        <thead>  
            <tr>  
                <th>ID</th>  
                <th>Name</th>  
                <th>Number</th>  
                <th>Position</th>  
                <th>Points</th>  
                <th>Assists</th>
                <th>Rebounds</th>
            </tr>  
        </thead>  
        <tbody>  
");
#nullable restore
#line 33 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
             foreach (var player in Model.Roster)  
            {  

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>  \r\n                    <td>");
#nullable restore
#line 36 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 37 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 38 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 39 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 40 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 41 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Assists);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>");
#nullable restore
#line 42 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
                   Write(player.Rebounds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                    <td>  \r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1198, "\'", 1227, 2);
            WriteAttributeValue("", 1205, "/editplayer/", 1205, 12, true);
#nullable restore
#line 44 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
WriteAttributeValue("", 1217, player.Id, 1217, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>  |  \r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1270, "\'", 1295, 2);
            WriteAttributeValue("", 1277, "/delete/", 1277, 8, true);
#nullable restore
#line 45 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
WriteAttributeValue("", 1285, player.Id, 1285, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>  \r\n                    </td>  \r\n                </tr>  \r\n");
#nullable restore
#line 48 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>  \r\n    </table>  \r\n");
#nullable restore
#line 51 "C:\Users\user\source\repos\BlazorCrud\BlazorCrud\Pages\FetchRoster.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlazorCrud.Pages.FetchRosterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlazorCrud.Pages.FetchRosterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlazorCrud.Pages.FetchRosterModel>)PageContext?.ViewData;
        public BlazorCrud.Pages.FetchRosterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
