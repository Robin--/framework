﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Signum\Views\PaginationSelector.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Signum\Views\PaginationSelector.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Signum\Views\PaginationSelector.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    
    #line 4 "..\..\Signum\Views\PaginationSelector.cshtml"
    using Signum.Utilities.DataStructures;
    
    #line default
    #line hidden
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/PaginationSelector.cshtml")]
    public partial class PaginationSelector : System.Web.Mvc.WebViewPage<Context>
    {
        public PaginationSelector()
        {
        }
        public override void Execute()
        {





WriteLiteral("\r\n");


            
            #line 7 "..\..\Signum\Views\PaginationSelector.cshtml"
   
   Pagination pagination = (Pagination)ViewData[ViewDataKeys.Pagination];
   var paginate = pagination as Pagination.Paginate;
   
   FilterMode filterMode = (FilterMode)ViewData[ViewDataKeys.FilterMode];
   int columnsCount = (int)ViewData[ViewDataKeys.SearchControlColumnsCount];

   ResultTable resultTable = (ResultTable)ViewData[ViewDataKeys.Results];


            
            #line default
            #line hidden
WriteLiteral("\r\n<tr class=\"ui-widget-header ui-corner-bottom sf-search-footer\" style=\"");


            
            #line 17 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                  Write((filterMode == FilterMode.OnlyResults) ?  "display:none" : "");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td colspan=\"");


            
            #line 18 "..\..\Signum\Views\PaginationSelector.cshtml"
            Write(columnsCount);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"sf-search-footer-pagination\">\r\n        <div class=\"sf-pagination-left\">\r" +
"\n");


            
            #line 20 "..\..\Signum\Views\PaginationSelector.cshtml"
             if (resultTable != null)
            {
                if (resultTable.TotalPages > 1)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span class=\"sf-pagination-strong\">");


            
            #line 24 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                  Write(resultTable.StartElementIndex.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");



WriteLiteral("                    <span> - </span>\r\n");



WriteLiteral("                    <span class=\"sf-pagination-strong\">");


            
            #line 26 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                  Write(resultTable.EndElementIndex.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");



WriteLiteral("                    <span>");


            
            #line 27 "..\..\Signum\Views\PaginationSelector.cshtml"
                      Write(" {0} ".Formato(SearchMessage.SearchControl_Pagination_Of.NiceToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 28 "..\..\Signum\Views\PaginationSelector.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <span class=\"sf-pagination-strong\">");


            
            #line 29 "..\..\Signum\Views\PaginationSelector.cshtml"
                                              Write(resultTable.TotalElements.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");



WriteLiteral("                <span>");


            
            #line 30 "..\..\Signum\Views\PaginationSelector.cshtml"
                  Write(" {0}.".Formato(SearchMessage.SearchControl_Pagination_Results.NiceToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 31 "..\..\Signum\Views\PaginationSelector.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div class=\"sf-pagination-center\">\r\n");


            
            #line 34 "..\..\Signum\Views\PaginationSelector.cshtml"
              
                var currentMode = pagination.GetMode();
                var modes = EnumExtensions.GetValues<PaginationMode>().Select(pm => new SelectListItem
                {
                     Text = pm.NiceToString(),
                     Value = pm.ToString(),
                     Selected = currentMode == pm
                });   
            

            
            #line default
            #line hidden
WriteLiteral("            ");


            
            #line 43 "..\..\Signum\Views\PaginationSelector.cshtml"
       Write(Html.DropDownList(Model.Compose("sfPagination"),  modes, new { @class = "sf-pagination-size" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 44 "..\..\Signum\Views\PaginationSelector.cshtml"
               
                var currentElements = pagination.GetElementsPerPage();
                var elements = new List<int> { 5, 10, 20, 50, 100, 200 }.Select(i => new SelectListItem { Text = i.ToString(), Value = i.ToString(), Selected = i == currentElements }).ToList();
            

            
            #line default
            #line hidden
WriteLiteral("            ");


            
            #line 48 "..\..\Signum\Views\PaginationSelector.cshtml"
       Write(Html.DropDownList(Model.Compose("sfElems"), elements, new { @class = "sf-pagination-size" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"sf-pagination-right\">\r\n");


            
            #line 52 "..\..\Signum\Views\PaginationSelector.cshtml"
             if (resultTable != null && paginate != null)
            {   

            
            #line default
            #line hidden
WriteLiteral("                <input type=\"hidden\" id=\"");


            
            #line 54 "..\..\Signum\Views\PaginationSelector.cshtml"
                                     Write(Model.Compose("sfPage"));

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 54 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                       Write(paginate.CurrentPage);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");



WriteLiteral("                <input type=\"button\" class=\"sf-pagination-button\" data-page=\"");


            
            #line 55 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                         Write(paginate.CurrentPage - 1);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 55 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                                                      Write((paginate.CurrentPage <= 1) ? "disabled=\"disabled\"" : "");

            
            #line default
            #line hidden
WriteLiteral(" value=\"&lt;\" />\r\n");


            
            #line 56 "..\..\Signum\Views\PaginationSelector.cshtml"
            
                MinMax<int> interval = new MinMax<int>(
                    Math.Max(1, paginate.CurrentPage - 2),
                    Math.Min(paginate.CurrentPage + 2, resultTable.TotalPages.Value));

                if (interval.Min != 1)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <input type=\"button\" class=\"sf-pagination-button\" data-page=\"" +
"1\" value=\"1\" />\r\n");


            
            #line 64 "..\..\Signum\Views\PaginationSelector.cshtml"
                    if (interval.Min - 1 != 1)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>...</span>\r\n");


            
            #line 67 "..\..\Signum\Views\PaginationSelector.cshtml"
                    }
                }

                for (int i = interval.Min; i < paginate.CurrentPage; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <input type=\"button\" class=\"sf-pagination-button\" data-page=\"" +
"");


            
            #line 72 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                            Write(i);

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 72 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                                       Write(i);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 73 "..\..\Signum\Views\PaginationSelector.cshtml"
                }


            
            #line default
            #line hidden
WriteLiteral("                <span class=\"sf-pagination-strong\">");


            
            #line 75 "..\..\Signum\Views\PaginationSelector.cshtml"
                                              Write(paginate.CurrentPage.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 76 "..\..\Signum\Views\PaginationSelector.cshtml"

                for (int i = paginate.CurrentPage + 1; i <= interval.Max; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <input type=\"button\" class=\"sf-pagination-button\" data-page=\"" +
"");


            
            #line 79 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                            Write(i);

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 79 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                                       Write(i);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 80 "..\..\Signum\Views\PaginationSelector.cshtml"
                }

                if (interval.Max != resultTable.TotalPages)
                {
                    if (interval.Max + 1 != resultTable.TotalPages)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>...</span>\r\n");


            
            #line 87 "..\..\Signum\Views\PaginationSelector.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <input type=\"button\" class=\"sf-pagination-button\" data-page=\"" +
"");


            
            #line 88 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                            Write(resultTable.TotalPages);

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 88 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                                                            Write(resultTable.TotalPages);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 89 "..\..\Signum\Views\PaginationSelector.cshtml"
                }
            

            
            #line default
            #line hidden
WriteLiteral("                <input type=\"button\" class=\"sf-pagination-button\" data-page=\"");


            
            #line 91 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                         Write(paginate.CurrentPage + 1);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 91 "..\..\Signum\Views\PaginationSelector.cshtml"
                                                                                                      Write((resultTable.TotalPages <= paginate.CurrentPage) ? "disabled=\"disabled\"" : "");

            
            #line default
            #line hidden
WriteLiteral(" value=\"&gt;\" />\r\n");


            
            #line 92 "..\..\Signum\Views\PaginationSelector.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </td>\r\n</tr>");


        }
    }
}
#pragma warning restore 1591