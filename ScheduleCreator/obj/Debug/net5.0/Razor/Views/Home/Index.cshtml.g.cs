#pragma checksum "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03bfccfc8ce323e382942caade50dcce9c967664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\_ViewImports.cshtml"
using ScheduleCreator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\_ViewImports.cshtml"
using ScheduleCreator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
using ScheduleCreator.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bfccfc8ce323e382942caade50dcce9c967664", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6b7eaefe326a4dc6243562dfcf918c0b06beb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ScheduleCreator.Models.Lesson>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 8 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
     foreach (var schedule in (List<Schedule>)@ViewData["Schedules"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">");
#nullable restore
#line 11 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                             Write(schedule.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <table border=""5"" cellspacing=""0"" align=""center"">
                <tr>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <br>
                        <b>Day/Period</b>
                    </td>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <b>I<br>9:30-10:20</b>
                    </td>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <b>II<br>10:20-11:10</b>
                    </td>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <b>III<br>11:10-12:00</b>
                    </td>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <b>IV<br>12:40-1:30</b>
                    </td>
                    <td align=""center"" height=""50""
                        ");
            WriteLiteral(@"width=""100"">
                        <b>V<br>1:30-2:20</b>
                    </td>
                    <td align=""center"" height=""50""
                        width=""100"">
                        <b>VI<br>2:20-3:10</b>
                    </td>
                </tr>
");
#nullable restore
#line 44 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                 foreach (Days day in Enum.GetValues(typeof(Days)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td align=\"center\" height=\"50\">\r\n                            <b>");
#nullable restore
#line 48 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                          Write(Enum.GetName(typeof(Days), day));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 50 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.First)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 51 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.Second)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 52 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.Third)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 53 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.Fourth)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 54 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.Fifth)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td align=\"center\" height=\"50\">");
#nullable restore
#line 55 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                                                  Write(Model.FirstOrDefault(i => i.Day == day && i.Number == LessonsNumbers.Sixth)?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 60 "C:\Users\natai\Downloads\ScheduleCreator\ScheduleCreator\ScheduleCreator\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ScheduleCreator.Models.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591