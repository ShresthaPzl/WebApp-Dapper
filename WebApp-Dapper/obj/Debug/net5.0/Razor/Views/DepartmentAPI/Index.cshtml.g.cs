#pragma checksum "C:\Users\sachin.tiwari\source\repos\WebApp-Dapper\WebApp-Dapper\Views\DepartmentAPI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd39931cc9b2b36f279b62214477f3df3673fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DepartmentAPI_Index), @"mvc.1.0.view", @"/Views/DepartmentAPI/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sachin.tiwari\source\repos\WebApp-Dapper\WebApp-Dapper\Views\_ViewImports.cshtml"
using WebApp_Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachin.tiwari\source\repos\WebApp-Dapper\WebApp-Dapper\Views\_ViewImports.cshtml"
using WebApp_Dapper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd39931cc9b2b36f279b62214477f3df3673fa5", @"/Views/DepartmentAPI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c46d7397d4ef1d0865fd6ac53df4099b9c602e6f", @"/Views/_ViewImports.cshtml")]
    public class Views_DepartmentAPI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sachin.tiwari\source\repos\WebApp-Dapper\WebApp-Dapper\Views\DepartmentAPI\Index.cshtml"
  
    ViewData["Title"] = "DepartmentAPI List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Department List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd39931cc9b2b36f279b62214477f3df3673fa54436", async() => {
                WriteLiteral("New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"tblDepartment\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                S.N.\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\sachin.tiwari\source\repos\WebApp-Dapper\WebApp-Dapper\Views\DepartmentAPI\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function () {
            ShowAllDepartment();

            /* Function to fetch Department Data */
            function ShowAllDepartment() {
                $.ajax({
                    url: ""https://localhost:44372/api/DAPI/"",
                    type: ""get"",
                    contentType: ""application/Json"",
                    success: function (data) {
                        $.each(data, function (i, item) {
                            console.log(item)
                            var rows = ""<tr>"" +
                                ""<td>"" + (i + 1) + ""</td>"" +
                                ""<td>"" + item.department_Name + ""</td>"" +
                                ""<td> <a class='btn btn-secondary' href='/Department/Edit/"" + item.department_Id + ""'>Edit</a> || <a class='btn btn-danger' onclick='confirmDelete("" + item.department_Id + "")'> Delete </a ></td>""
                            ""</tr>"";
                            $('#tblDepartment tbo");
                WriteLiteral(@"dy').append(rows);


                        });
                        console.log(data);
                    }, // end of AJAX Success Function

                    failure: function (data) {
                        alert(data.responseText);
                    }, // End of AJAX failure function
                    error: function (data) {
                        alert(data.responseText);
                    } // End of AJAX error function

                });
            }
        });        

        /*to show delete confirmation dialog box*/
        function confirmDelete(itemId) {

            $('#hdnEmployeeId').val(itemId);
            $('#exampleModal').modal('show');
        }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
