#pragma checksum "C:\Users\Siyana\Desktop\GroceriesStoreSystem\GroceriesStoreSystem\GroceriesStoreSystem\Pages\Brands\_AllBrands.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50956f98b2274efe1e05e07e1f5ac2d4e54e62d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GroceriesStoreSystem.Pages.Brands.Pages_Brands__AllBrands), @"mvc.1.0.view", @"/Pages/Brands/_AllBrands.cshtml")]
namespace GroceriesStoreSystem.Pages.Brands
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
#line 1 "C:\Users\Siyana\Desktop\GroceriesStoreSystem\GroceriesStoreSystem\GroceriesStoreSystem\Pages\_ViewImports.cshtml"
using GroceriesStoreSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50956f98b2274efe1e05e07e1f5ac2d4e54e62d5", @"/Pages/Brands/_AllBrands.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c668d8eff79adb527f91d236396d963009bb8c25", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Brands__AllBrands : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GroceriesStoreSystem.Models.Brands>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/allrecords.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "500", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://unpkg.com/ag-grid-community/dist/ag-grid-community.min.js""></script>
<link rel=""stylesheet"" href=""https://unpkg.com/ag-grid-community/dist/styles/ag-grid.css"">
<link rel=""stylesheet"" href=""https://unpkg.com/ag-grid-community/dist/styles/ag-theme-balham.css"">

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50956f98b2274efe1e05e07e1f5ac2d4e54e62d54758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<style>

    thead input {
        width: 100%;
    }

    tbody tr:hover {
        background: lightgray !important;
        cursor: pointer;
    }

    tbody tr.selected {
        background: gray !important;
    }

    .ag-theme-balham .bigexpense-warning {
        background-color: sandybrown !important;
    }

    .ag-theme-balham .bigexpense-breach {
        background-color: lightcoral !important;
    }

    .ag-theme-balham .bigexpense-ok {
        background-color: mediumseagreen !important;
    }

    a.fas.fa-edit, a.fas.fa-info-circle {
        font-size: xx-large;
    }

    a.fas.fa-paperclip {
        font-size: large;
    }
</style>

<!-- Spinner --------------------------->
<div class=""spinner"" style=""display:none"">
    <div class=""center-div"">
        <div class=""inner-div"">
            <div class=""loader""></div>
        </div>
    </div>
</div>

<div id=""view-all"">
    <div class=""custom-container"" style=""padding-left: 1px;"">
        <a c");
            WriteLiteral(@"lass=""button"" href=""/Brand/CreateBrand"">Add new brand</a>
        <input type=""button"" class=""editButton"" value=""Export in CSV"" id=""exportCSV"" onclick=""exportCSV('Brands')"" />
        <input type=""button"" class=""editButton"" value=""Clear Filters"" id=""clearFilters"" onclick=""clearFilters()"" />
        <input type=""button"" class=""editButton"" value=""Quick Edit"" id=""editButton"" onclick=""quickEdit()"" />
        <input type=""button"" class=""editButton"" hidden=""hidden"" value=""Save Changes"" id=""saveButton"" onclick=""saveChanges()"" />
        <input type=""button"" class=""editButton"" hidden=""hidden"" value=""Refresh"" id=""cancelButton"" onclick=""cancel()"" />

        <div class=""example-header"">
            Page Size:
            <select onchange=""onPageSizeChanged()"" id=""page-size"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50956f98b2274efe1e05e07e1f5ac2d4e54e62d57732", async() => {
                WriteLiteral("20");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50956f98b2274efe1e05e07e1f5ac2d4e54e62d59214", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50956f98b2274efe1e05e07e1f5ac2d4e54e62d510386", async() => {
                WriteLiteral("500");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
            <input type=""text"" id=""filter-text-box"" title=""Search in all columns"" placeholder=""Search..."" oninput=""onFilterTextBoxChanged()"">
        </div>
        <div id=""myGrid"" style=""height: 800px;width:110%; padding: 3px; padding-left: initial;"" class=""ag-theme-balham""></div>
    </div>
</div>


<script>
    var quantityList = [];
    var brandNameList = [];
    var priceList = [];

    var getIdsOnly = [];
    var splittedDomainOwner = [];
    var userRole = """";
    var fullName = """";
    var isInAssignedList = false;
    var userEmail = """";

    var columnDefs = [
        { field: ""brandId"", headerName: ""Brand Id"" },
        { field: ""brandName"", headerName: ""Brand Name"" },
        { field: ""isActive"", headerName: ""Active"" },
        {
            field: ""action"", headerName: ""Action"", sortable: false, filter: false,
            cellRenderer: function (params) {
                return '<a title=""Edit"" style=""color:green;"" href=""/Brand/EditBrand/' + p");
            WriteLiteral(@"arams.data.brandId + '"">Edit</a>' + "" | "" +
                    '<a title=""Delete""  style=""color:red;""  href=""#"" onclick=""DeleteData(' + params.data.brandId + ')"">Delete</a>'
            }
        },
    ];

    var gridOptions = {
        columnDefs: columnDefs,
        defaultColDef: {
            width: 150,
            sortable: true,
            resizable: true,
            //  editable: true,
            filter: true,
            onCellValueChanged(params) {
                this.getIdsOnly.push(params.data.brandId);
            }
        },
        pagination: true,
        paginationPageSize: 20,
        paginationNumberFormatter: function (params) {
            return '[' + params.value.toLocaleString() + ']';
        },
        rowClassRules: {
            // row style function
            'bigexpense-warning': function (params) {
                var numExpense = params.data.Amount;
                return numExpense > 20 && numExpense <= 50;
            },
            // ");
            WriteLiteral(@"row style expression
            'bigexpense-breach': 'data.Amount > 50',
            'bigexpense-ok': 'data.Amount <=20'
        }
    };

    //set pagination selection
    function onPageSizeChanged(newPageSize) {
        var value = document.getElementById('page-size').value;
        gridOptions.api.paginationSetPageSize(Number(value));
    }

    //set styles of the rows
    gridOptions.rowStyle = { font: ""Times New Roman"" };
    gridOptions.rowHeight = 40;

    var agGridDiv = document.querySelector('#myGrid');

    new agGrid.Grid(agGridDiv, gridOptions);

    agGrid.simpleHttpRequest({
        url: '/Brand/LoadData',
    })
        .then(function (result) {
            try {
                var data = result.data;
                gridOptions.api.setRowData(data);
                gridOptions.api.paginationGoToPage(0);
            }
            catch (error) {
                console.log(error);
            }
        });

    function quickEdit() {
        if (document");
            WriteLiteral(@".getElementById(""editButton"").value == ""Quick Edit"") {

            var arrayColumns = ['brandName'];
            editColumns(arrayColumns);

            document.getElementById(""editButton"").value = ""Exit Edit Mode"";
            document.getElementById(""saveButton"").hidden = false;
            document.getElementById(""cancelButton"").hidden = false;
                       
        }
        else {
            var arrayColumns = ['brandName'];
            stopEditColumns(arrayColumns);

            document.getElementById(""editButton"").value = ""Quick Edit"";
            document.getElementById(""saveButton"").hidden = true;
            document.getElementById(""cancelButton"").hidden = true;
        }
    }

    function saveChanges(domain) {
        if (getIdsOnly.length > 0) {
            $('.spinner').css('display', 'block');
            var newRowData = [];
            gridOptions.api.forEachNode(function (node) {
                newRowData.push(node.data);
            });

         ");
            WriteLiteral(@"   $.ajax({
                type: ""POST"",
                url: ""/Brand/SaveAllChanges"",
                data: { modifiedIds: getIdsOnly, newData: newRowData },
                success: function (result) {
                    $("".spinner"").fadeOut('slow');
                    getIdsOnly = [];//clear array
                    if (result.data == ""success"") {
                        alert(""Data was successfully saved!"");
                    }
                    else {
                        alert(""Something went wrong. Data was not saved."");
                    }
                }
            });
        }
        else {
            alert(""There are no changes in data."");
        }
    }
    function cancel() {
        //gridOptions.api.refreshCells(params);
        $('.spinner').css('display', 'block');

        agGrid
            .simpleHttpRequest({
                url: '/Brand/LoadData',
            })
            .then(function (result) {
                if (result != null) {
");
            WriteLiteral(@"                    var data = result.data;
                    gridOptions.api.setRowData(data);
                    gridOptions.api.paginationGoToPage(0);
                }
                else {
                    alert(""Error: Data not found."");
                }
                $("".spinner"").fadeOut('slow');
            });
    }
     function DeleteData(id) {
        if (confirm(""Are you sure you want to delete?"")) {
            Delete(id);
        }
        else {
            return false;
        }
    }

    function Delete(id) {
        var url = '");
#nullable restore
#line 239 "C:\Users\Siyana\Desktop\GroceriesStoreSystem\GroceriesStoreSystem\GroceriesStoreSystem\Pages\Brands\_AllBrands.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + ""Brand/Delete"";

        $.post(url, { ID: id }, function (data) {
            if (data) {
                alert(""Successfully deleted!"");
                cancel();
            } else {
                alert(""Somethinf went wrong! The Delete was not successfull."");
            }
        });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GroceriesStoreSystem.Models.Brands>> Html { get; private set; }
    }
}
#pragma warning restore 1591