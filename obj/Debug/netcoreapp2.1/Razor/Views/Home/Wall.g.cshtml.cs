#pragma checksum "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1e5e3e308e6f2291574a8e287ed17fce39cdf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wall), @"mvc.1.0.view", @"/Views/Home/Wall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wall.cshtml", typeof(AspNetCore.Views_Home_Wall))]
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
#line 1 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\_ViewImports.cshtml"
using userdashboard;

#line default
#line hidden
#line 2 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\_ViewImports.cshtml"
using userdashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1e5e3e308e6f2291574a8e287ed17fce39cdf9", @"/Views/Home/Wall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b267ce4ed5a2f6343c33540d1999210e1d5ef7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProcessMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProcessComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 12, true);
            WriteLiteral("<h5>Welcome ");
            EndContext();
            BeginContext(26, 25, false);
#line 2 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
       Write(ViewBag.Current.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(51, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(53, 24, false);
#line 2 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                                  Write(ViewBag.Current.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(77, 18, true);
            WriteLiteral("</h5>\r\n<h6>Email: ");
            EndContext();
            BeginContext(96, 21, false);
#line 3 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
      Write(ViewBag.Current.Email);

#line default
#line hidden
            EndContext();
            BeginContext(117, 21, true);
            WriteLiteral("</h6>\r\n<h6>Username: ");
            EndContext();
            BeginContext(139, 24, false);
#line 4 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
         Write(ViewBag.Current.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(163, 24, true);
            WriteLiteral("</h6>\r\n<h6>Description: ");
            EndContext();
            BeginContext(188, 27, false);
#line 5 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
            Write(ViewBag.Current.Description);

#line default
#line hidden
            EndContext();
            BeginContext(215, 49, true);
            WriteLiteral("</h6>\r\n\r\n<h6></h6>\r\n<div class=\"jumbotron\">\r\n    ");
            EndContext();
            BeginContext(264, 486, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bfae2683ed4357b1e6c04f647f6029", async() => {
                BeginContext(334, 48, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(382, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "221a6cb8baad434a97d7fc485308cb3e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 11 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.message.content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(432, 26, true);
                WriteLiteral("\r\n            <label>Send ");
                EndContext();
                BeginContext(459, 29, false);
#line 12 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                   Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(488, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(490, 28, false);
#line 12 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                                                  Write(ViewBag.CurrentUser.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(518, 30, true);
                WriteLiteral(" message</label>\r\n            ");
                EndContext();
                BeginContext(548, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f08a307a3004797ab9dc81de542e99d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.message.content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(616, 127, true);
                WriteLiteral("\r\n        </div>\r\n         <div>\r\n            <input  class=\"btn btn-primary\" type=\"submit\" value=\"Post\">\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 20 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
  
    foreach(var Message in ViewBag.Messages)
    {
        TimeSpan duration=Message.duration;
        string time="";
        if(duration.Days>0)
        {
            time+=duration.Days.ToString()+" "+"days"+" "+duration.Hours.ToString()+" "+"hours"+" "+"ago";;
        }
        else
        {
            time+=duration.Hours.ToString()+" "+"hours"+" "+duration.Minutes.ToString()+" "+"minutes"+" "+"ago";
        }

#line default
#line hidden
            BeginContext(1197, 72, true);
            WriteLiteral("        <div>\r\n            <div class=\"jumbotron\">\r\n                <h6>");
            EndContext();
            BeginContext(1270, 14, false);
#line 35 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
               Write(Message.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 33, true);
            WriteLiteral(" wrote:</h6>\r\n                <p>");
            EndContext();
            BeginContext(1318, 15, false);
#line 36 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
              Write(Message.content);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 29, true);
            WriteLiteral("</p>\r\n                <p><em>");
            EndContext();
            BeginContext(1363, 4, false);
#line 37 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                  Write(time);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 31, true);
            WriteLiteral("</em></p>\r\n            </div>\r\n");
            EndContext();
#line 39 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
              
                foreach(var Comment in Message.comment)
                {
                    TimeSpan CommentDuration=Comment.duration;
                    string CommentTime="";
                    if(CommentDuration.Days>0)
                    {
                        CommentTime+=CommentDuration.Days.ToString()+" "+"days"+" "+CommentDuration.Hours.ToString()+" "+"hours"+" "+"ago";;
                    }
                    else
                    {
                        CommentTime+=CommentDuration.Hours.ToString()+" "+"hours"+" "+CommentDuration.Minutes.ToString()+" "+"minutes"+" "+"ago";
                    }

#line default
#line hidden
            BeginContext(2053, 71, true);
            WriteLiteral("                    <div class=\"comment\">\r\n                        <h6>");
            EndContext();
            BeginContext(2125, 14, false);
#line 53 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                       Write(Comment.Author);

#line default
#line hidden
            EndContext();
            BeginContext(2139, 41, true);
            WriteLiteral(" wrote:</h6>\r\n                        <p>");
            EndContext();
            BeginContext(2181, 15, false);
#line 54 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                      Write(Comment.content);

#line default
#line hidden
            EndContext();
            BeginContext(2196, 37, true);
            WriteLiteral("</p>\r\n                        <p><em>");
            EndContext();
            BeginContext(2234, 11, false);
#line 55 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                          Write(CommentTime);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 39, true);
            WriteLiteral("</em></p>\r\n                    </div>\r\n");
            EndContext();
#line 57 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2318, 56, true);
            WriteLiteral("             <div class=\"comment\">\r\n                    ");
            EndContext();
            BeginContext(2374, 726, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c75b7c27b1a40deb1a9d18a7ebfdb84", async() => {
                BeginContext(2444, 80, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(2524, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f854b1b164ec4ae5b06358fdc699d033", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 62 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comment.content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2574, 82, true);
                WriteLiteral("\r\n                            <label>Comment</label>\r\n                            ");
                EndContext();
                BeginContext(2656, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "933ef386917b4448bf4ec76d0508535c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 64 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comment.content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2723, 93, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(2816, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44e2ee660c2348b7bb24ff3db8ab4eec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 67 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#line 67 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
                                                                WriteLiteral(Message.MessageId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2884, 209, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            <input  class=\"btn btn-primary\" type=\"submit\" value=\"Comment\">\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3100, 42, true);
            WriteLiteral("\r\n                </div>\r\n        </div>\r\n");
            EndContext();
#line 75 "C:\Users\onsil\OneDrive\Desktop\UserDashboard\userdashboard\Views\Home\Wall.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
