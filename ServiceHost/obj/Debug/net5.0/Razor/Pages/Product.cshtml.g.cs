#pragma checksum "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Product), @"mvc.1.0.razor-page", @"/Pages/Product.cshtml")]
namespace ServiceHost.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e47", @"/Pages/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"84e67cc624686472d6ee628a8fd93a67c79f2978653a37fe57c229fa14270597", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main_img_gallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main class=""single-product default"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav>
                    <ul class=""breadcrumb"">
                        <li>
                            <i class=""fa fa-home"" aria-hidden=""true""></i>
                        </li>

                        <li>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e475579", async() => {
                WriteLiteral("<span>");
#nullable restore
#line 17 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                                                                       Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                             WriteLiteral(Model.Product.CategorySlug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <span>");
#nullable restore
#line 20 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                             Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <article class=""product"">
                    <div class=""row product_main_details"">
                        <div class=""col-lg-5 col-md-6 col-sm-12"">
                            <div class=""product-gallery default"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e478905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1170, "~/Upload/", 1170, 9, true);
#nullable restore
#line 32 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1179, Model.Product.Picture, 1179, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1208, Model.Product.PictureAlt, 1208, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1242, Model.Product.PictureTitle, 1242, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <section class=""testimonial py-3"" id=""testimonial"">
                                    <div class=""container"">
                                        <div class=""row gallery"">
                                            <div class=""col-4 col-md-3 pd""><a href=""/Theme/assets/img/product_img/single/1.jpg"" rel=""prettyPhoto[gallery1]""><img src=""/Theme/assets/img/product_img/single/1.jpg"" class=""img-thumb"" alt=""نمایشگر همیشه روشن""></a></div>
                                            <div class=""col-4 col-md-3 pd""><a href=""/Theme/assets/img/product_img/single/2.jpg"" rel=""prettyPhoto[gallery1]""><img src=""/Theme/assets/img/product_img/single/2.jpg"" class=""img-thumb"" alt=""سخت تر از همه""></a></div>
                                            <div class=""col-4 col-md-3 pd""><a href=""/Theme/assets/img/product_img/single/3.jpg"" rel=""prettyPhoto[gallery1]""><img src=""/Theme/assets/img/product_img/single/3.jpg"" class=""img-thumb"" alt=""یک دوربین در یک کلاس به تنهایی""></a></div>
       ");
            WriteLiteral(@"                                     <div class=""col-4 col-md-3 pd""><a href=""/Theme/assets/img/product_img/single/4.jpg"" rel=""prettyPhoto[gallery1]""><img src=""/Theme/assets/img/product_img/single/4.jpg"" class=""img-thumb"" alt=""حریم خصوصی""></a></div>

                                        </div>
                                    </div>
                                </section>
                            </div>
                            <ul class=""gallery-options"">
                                <li>
                                    <button class=""add-favorites favorites2""><i class=""fa fa-heart""></i></button>
                                </li>
                                <li>
                                    <button class=""favorites2"" data-toggle=""modal"" data-target=""#myModal""><i class=""fa fa-share-alt""></i></button>
                                </li>
                            </ul>
                            <!-- Modal Core -->
                            <div class=""m");
            WriteLiteral(@"odal-share modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                                            <h4 class=""modal-title"" id=""myModalLabel"">به اشتراک گذاشتن</h4>
                                        </div>

                                        <div class=""modal-footer"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e4714332", async() => {
                WriteLiteral(@"
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <p>
                                                            برای کپی آدرس در کادر زیر دابل کلیک کنید
                                                        </p>
                                                        <p class=""right-side-header shareurlvalue"" title=""کپی بعد دوبار کلیک"" id=""text"" onclick=""copyElementText(this.id)"">http://www.mysite.com/single-product.html</p>

                                                    </div>
                                                </div>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Modal Core -->
                        </div>
                        <div class=""col-lg-7 col-md-6 col-sm-12 "">


                            <h1 class=""product-title "">
                                ");
#nullable restore
#line 84 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h1>\r\n                            <hr class=\"hr-text\">\r\n                            <div class=\"row\">\r\n                                <div class=\"text-justify mx-3\">\r\n                                    <p>");
#nullable restore
#line 89 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                  Write(Model.Product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 product_main_pr"">

                                    <div class=""time_pr"">


                                        <div class=""row"">
                                            <div class=""col-12 upda"">
                                                <b>
                                                    <i class=""fa fa-calendar"" aria-hidden=""true""></i>

                                                    زمان ارسال محصول :
                                                </b>
                                                طی 3 روز کاری
                                            </div>

");
#nullable restore
#line 106 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                             if (@Model.Product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-12 col-lg-6 col-md-6\">\r\n\r\n                                                    <p>زمان باقی مانده </p>\r\n                                                    <div class=\"countdown-timer\"");
            BeginWriteAttribute("countdown", " countdown=\"", 6615, "\"", 6627, 0);
            EndWriteAttribute();
            WriteLiteral(" data-date=\"");
#nullable restore
#line 111 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                                                                    Write(Model.Product.DiscountExpireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                        <ul class=""text_countdown"">
                                                            <li data-days="""" class=""number_countdown"">0</li>
                                                            <li>روز</li>
                                                        </ul>
                                                        <ul class=""text_countdown"">
                                                            <li data-hours="""" class=""number_countdown"">0</li>
                                                            <li>ساعت</li>
                                                        </ul>
                                                        <ul class=""text_countdown"">
                                                            <li data-minutes="""" class=""number_countdown"">0</li>
                                                            <li>دقیقه</li>
                                                        </ul>
                 ");
            WriteLiteral(@"                                       <ul class=""text_countdown"">
                                                            <li data-seconds="""" class=""number_countdown"">0</li>
                                                            <li>ثانیه</li>
                                                        </ul>
                                                    </div>
                                                </div>
");
#nullable restore
#line 130 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div");
            BeginWriteAttribute("class", " class=\"", 8228, "\"", 8312, 1);
#nullable restore
#line 131 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
WriteAttributeValue("", 8236, Model.Product.HasDiscount?"col-12 col-lg-6 col-md-6 border_left":"col-12", 8236, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"price space-15\">\r\n");
#nullable restore
#line 133 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                     if (Model.Product.HasDiscount)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <del><span>");
#nullable restore
#line 135 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                              Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></del>\r\n                                                        <span class=\"discount_badge\">");
#nullable restore
#line 136 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                                                Write(Model.Product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                        <ins><span>");
#nullable restore
#line 137 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                              Write(Model.Product.PriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></ins>\r\n");
#nullable restore
#line 138 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <ins><span>");
#nullable restore
#line 141 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                              Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></ins>\r\n");
#nullable restore
#line 142 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <div class=""col-12 timer-title text--center"">

                                                    <a href=""#"" class=""btn btn-main-masai big_btn"">افزودن به سبد</a>
                                                </div>
                                            </div>
                                        </div>



                                    </div>


                                </div>
                                <div class=""col-12"">
                                    <p class=""txt_note"">
                                        <i class=""fa fa-info"" aria-hidden=""true""></i>
                                        برای کالاهای گروه موبایل، امکان برگشت کالا به دلیل انصراف از خرید تنها در صورتی مورد قبول است که کالا بدون هیچگونه استفاده و با تمامی قطعات، متعلقات و بسته‌بندی‌های اولیه خود بازگردانده شود. لازم به ذکر است که برای هر کالای موبایل، ضمانت رجیستری صادر می‌شود. در صو");
            WriteLiteral(@"رت بروز اشکال در ضمانت رجیستری، پس از انقضای مدت ۳۰ روزه، کالا می‌تواند بازگردانده شود.
                                    </p>
                                </div>

                            </div>


                        </div>

                    </div>
                </article>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 default no-padding bg_single_product"">
                    <div class=""product-tabs default"">
                        <div class=""box-tabs default"">
                            <ul class=""nav"" role=""tablist"">
                                <li class=""box-tabs-tab"">
                                    <a class=""active "" data-toggle=""tab"" href=""#desc"" role=""tab"" aria-expanded=""true"">
                                        توضیحات تکمیلی
                                    </a>
                                </li>
                                <li class=""box-tabs-tab"">");
            WriteLiteral(@"
                                    <a data-toggle=""tab"" href=""#params"" role=""tab"" aria-expanded=""false"">
                                        مشخصات محصول
                                    </a>
                                </li>
                                <li class=""box-tabs-tab"">
                                    <a data-toggle=""tab"" href=""#comments"" role=""tab"" aria-expanded=""false"">
                                        دیدگاه خریداران
                                    </a>
                                </li>
                                <li class=""box-tabs-tab"">
                                    <a data-toggle=""tab"" href=""#comments_questions"" role=""tab"" aria-expanded=""false"">
                                        پرسش و نظر
                                    </a>
                                </li>
                            </ul>
                            <div class=""card-body default"">
                                <!-- Tab panes -->
               ");
            WriteLiteral(@"                 <div class=""tab-content"">
                                    <div class=""tab-pane active"" id=""desc"" role=""tabpanel"" aria-expanded=""true"">

                                        <header class=""card-header"">
                                            <h3 class=""card-title""><span>برسی ");
#nullable restore
#line 206 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                                                         Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h3>
                                        </header>
                                        <div class=""parent-expert default"">
                                            <div class=""content-expert"">
                                                <p>");
#nullable restore
#line 210 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Product.cshtml"
                                              Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>


                                    </div>
                                    <div class=""tab-pane params"" id=""params"" role=""tabpanel"" aria-expanded=""false"">
                                        <header class=""card-header"">
                                            <h3 class=""card-title""><span>بررسی تخصصی گوشی iPhone 13 Pro Max </span></h3>
                                        </header>

                                        <div class=""col-12"">
                                            <ul class=""list-group "">
                                                <li class=""list-group-item"">رنگ: مشکی</li>
                                                <li class=""list-group-item"">بلوتوث:دارد</li>
                                                <li class=""list-group-item""> رزولوشن عکس : 12 مگاپیکسل</li>
                                                <li class=""list-group-item""> اندا");
            WriteLiteral(@"زه  : 6.1</li>

                                                <li class=""list-group-item"">قابلیت : ضد آب</li>
                                                <li class=""list-group-item""> نوع گوشی : دو گوشی</li>
                                                <li class=""list-group-item""> سیستم عامل : iOS 15</li>
                                                <li class=""list-group-item""> فناوری  : Super Retina XDR OLED</li>


                                            </ul>


                                        </div>




                                    </div>
                                    <div class=""tab-pane"" id=""comments"" role=""tabpanel"" aria-expanded=""false"">

                                        <header class=""card-header"">
                                            <h3 class=""card-title""><span>دیدگاه های دیگر کاربران</span></h3>
                                        </header>
                                        <div class=""comments_form default"">
        ");
            WriteLiteral(@"                                    <ol class=""comment-list"">
                                                <!-- #comment-## -->
                                                <li>
                                                    <div class=""comment-body"">
                                                        <div class=""comment-author"">
                                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 15409, "\"", 15415, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""assets/img/profile/1.png"" class=""avatar""><span class=""star4"">4.3</span><div class=""text-h5"">عالی وشیک</div>
                                                        </div>

                                                        <p>محصول بسیار خوبی است. صفحه‌نمایش با کیفیت فوق‌العاده، دوربین‌های با کیفیت و روانی کارکرد دستگاه همگی از ویژگی‌های مثبت این محصول هستند.</p>
                                                        <ul class=""commentul"">
                                                            <li>
                                                                25 اردیبهشت 1402


                                                            </li>
                                                            <li>
                                                                رضا صبوری
                                                            </li>
                                                        </ul>
                                                    </div>
             ");
            WriteLiteral(@"                                   </li>
                                                <li>
                                                    <div class=""comment-body"">
                                                        <div class=""comment-author"">
                                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 16766, "\"", 16772, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""assets/img/profile/2.png"" class=""avatar""><span class=""star3"">3.2</span><div class=""text-h5"">جنس ضعیف</div>
                                                        </div>

                                                        <p>
                                                            اینقد قیمتش زیاد هست که نمیشه سمتش رفت، خریدم ولی پشیمونم، بنظر من نخرید، نوکیا 1100 از این بهتره، خیلی کار باهاش هم دشوار هست.
                                                        </p>
                                                        <ul class=""commentul"">
                                                            <li>
                                                                30 اردیبهشت 1402


                                                            </li>
                                                            <li>
                                                                محمود صفایی
                                                            </li>
                       ");
            WriteLiteral(@"                                 </ul>
                                                    </div>
                                                </li>
                                            </ol>
                                        </div>

                                    </div>
                                    <div class=""tab-pane form-comment"" id=""comments_questions"" role=""tabpanel"" aria-expanded=""false"">
                                        <header class=""card-header"">
                                            <h3 class=""card-title""><span>ارسال نظر و پرسش  </span></h3>
                                        </header>

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9d66821daa4fa134e2448f89fee71fb3814e24a523cc84436ee12bddcb1e4734505", async() => {
                WriteLiteral(@"
                                            <textarea class=""form-control"" placeholder=""متن نظر و پرسش"" rows=""4""></textarea>
                                            <button class=""btn btn-main-masai"">ارسال برای تایید</button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ProductModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
