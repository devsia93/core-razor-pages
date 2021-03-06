#pragma checksum "/home/dev/Documents/projects/core-razor-pages/RazorPages/RazorPages/Pages/Movies/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d579263c8a0beb87d19ebda513b6709cc490a40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Movies_Edit), @"mvc.1.0.razor-page", @"/Pages/Movies/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d579263c8a0beb87d19ebda513b6709cc490a40", @"/Pages/Movies/Edit.cshtml")]
    public class Pages_Movies_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/home/dev/Documents/projects/core-razor-pages/RazorPages/RazorPages/Pages/Movies/Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Movie</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Movie.ID"" />
            <div class=""form-group"">
                <label asp-for=""Movie.Title"" class=""control-label""></label>
                <input asp-for=""Movie.Title"" class=""form-control"" />
                <span asp-validation-for=""Movie.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.ReleaseDate"" class=""control-label""></label>
                <input asp-for=""Movie.ReleaseDate"" class=""form-control"" />
                <span asp-validation-for=""Movie.ReleaseDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Genre"" class=""control-label""></label>
                <input asp-for=""Movie.Genre"" class=""form-");
            WriteLiteral(@"control"" />
                <span asp-validation-for=""Movie.Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Price"" class=""control-label""></label>
                <input asp-for=""Movie.Price"" class=""form-control"" />
                <span asp-validation-for=""Movie.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 49 "/home/dev/Documents/projects/core-razor-pages/RazorPages/RazorPages/Pages/Movies/Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPages.Pages.Movies.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPages.Pages.Movies.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPages.Pages.Movies.EditModel>)PageContext?.ViewData;
        public RazorPages.Pages.Movies.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
