#pragma checksum "C:\Users\me\ClientSite\ClientSite\ClientSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2066fce3736cb211802a0c5c022eb5519de7eb28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\me\ClientSite\ClientSite\ClientSite\Views\_ViewImports.cshtml"
using ClientSite;

#line default
#line hidden
#line 2 "C:\Users\me\ClientSite\ClientSite\ClientSite\Views\_ViewImports.cshtml"
using ClientSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2066fce3736cb211802a0c5c022eb5519de7eb28", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefd5075dabb221a7aa06f16701c1fed2d50a92b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\me\ClientSite\ClientSite\ClientSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(99, 17, false);
#line 6 "C:\Users\me\ClientSite\ClientSite\ClientSite\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(116, 2139, true);
            WriteLiteral(@"</h2>
<hr />
<div>
    <h3>What:</h3>

    <p class=""homePagePara"">
        The base of this project is a ASP.NET Core Web MVC Application created on Visual Studio 2017. 
        Created to provide a code example of my .Net Ability. 
        The purpose of this site is to display clients, by name and category. 
        It also allows for adding new clients, as well as edit, delete, and view. 
        The data is stored in MS SQL Local DB that is created on the build of the project, which also seeds data to the table. 
        The database holds ID, Title, Category, Website, and Image. 
        Title and Category are viewable in the client table, the rest is viewable in the detail page. 
        There are both an about page and contact page on the top nav bar to be filled in at a later date.
    </p>
</div>
<hr />
<div>
    <h3>Why:</h3>

    <p class=""homePagePara"">
        The reason I used the Visual Studio ASP.NET MVC was to create a quick base that I am comfortable with to start this ");
            WriteLiteral(@"project. 
        This project was created yesterday 3/31/2019 to give a code example. 
        I came up with this idea because it is similar to the work I did as CASS, as well as a way to look more into the grey ghost clients. 
        I decided to make a site that used a database and multiple pages, instead of a single static website (such as my personal website https://sawyerkokesh.github.io/) because it would not show off what I am capable of. 
        Once I knew I was going to use a database, I choose to use MVC because it is a good way for the separation between the data in the models and the interface in the views. 
        Furthermore developing in visual studio lets this happen quickly, by being able to create scaffolding off of a model which allows for a very quick implementation of the CRUD methods and the database. 
        In the database everything is stored as strings, where the website and image are both urls. 
        validation is done within the client as regular expressions. 
   ");
            WriteLiteral("     The purpose of the Images being stored as a url was because of time.\r\n    </p>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
