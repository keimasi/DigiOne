#pragma checksum "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
using _0_Framwork.Application;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"84e67cc624686472d6ee628a8fd93a67c79f2978653a37fe57c229fa14270597", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn big_btn btn-main-masai"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<main class=\"cart-page default space-top-30 text-center\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <ul class=\"order-steps\">\r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b5254", async() => {
                WriteLiteral("\r\n                            <span>سبدخرید</span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                    <li>
                        <a href=""shopping-payment.html"">
                            <span>پرداخت</span>
                        </a>
                    </li>
                    <li>
                        <a href=""successful-payment.html"">
                            <span>اتمام خرید و ارسال</span>
                        </a>
                    </li>
                </ul>
            </div>
            <div class=""cart_content col-xl-12 col-lg-12 col-md-12"">
                <header class=""card-header"">
                    <h3 class=""card-title""><span>سبد خرید شما</span></h3>
");
#nullable restore
#line 32 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                     foreach (var item in Model.CartItems.Where(x => x.IsInStock == false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning d-flex align-items-center\" role=\"alert\">\r\n                            <span>\r\n                                کالای <strong>");
#nullable restore
#line 36 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در انبار کمتر از تعداد درخواستی  موجود است.\r\n                            </span>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </header>
                <div class=""table-responsive default"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">عکس</th>
                                <th scope=""col"">نام محصول</th>
                                <th scope=""col"">قیمت واحد</th>
                                <th scope=""col"">تعداد</th>
                                <th scope=""col"">مبلغ نهایی بدون تخفیف</th>
                                <th scope=""col"">درصد تخفیف</th>
                                <th scope=""col"">مبلغ نهایی با محاسبه تخفیف</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 55 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                             foreach (var item in Model.CartItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"cart_item\">\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b9494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2572, "~/Upload/", 2572, 9, true);
#nullable restore
#line 59 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
AddHtmlAttributeValue("", 2581, item.Picture, 2581, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
AddHtmlAttributeValue("", 2601, item.Name, 2601, 10, false);

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
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b11463", async() => {
                WriteLiteral("<i class=\"fa fa-times\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                                               WriteLiteral(item.Id);

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
            WriteLiteral(@"
                                    </td>

                                    <td class=""w-25 text-justify"">
                                        <h3 class=""cart_title m-0"">
                                            <a href=""#"">
                                                ");
#nullable restore
#line 66 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                        </h3>
                                    </td>

                                    <td>
                                        <div class=""cart_price"">
                                            <ins><span>");
#nullable restore
#line 73 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>تومان</span></span></ins>\r\n                                        </div>\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        <input type=\"number\" class=\"tedad\"");
            BeginWriteAttribute("value", " value=\"", 3627, "\"", 3646, 1);
#nullable restore
#line 78 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3635, item.Count, 3635, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onchange", " onchange=\"", 3647, "\"", 3821, 11);
            WriteAttributeValue("", 3658, "changeCartItemCount(\'", 3658, 21, true);
#nullable restore
#line 78 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3679, item.Id, 3679, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3687, "\',", 3687, 2, true);
            WriteAttributeValue(" ", 3689, "\'totalItemPrice-", 3690, 17, true);
#nullable restore
#line 78 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3706, item.Id, 3706, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3714, "\',\'itemPayAmount-", 3714, 17, true);
#nullable restore
#line 78 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3731, item.Id, 3731, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3739, "\',\'discountRate-", 3739, 16, true);
#nullable restore
#line 78 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3755, item.Id, 3755, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3763, "\',\'totalAmount\',\'discountAmount\',\'amountPaid\',", 3763, 46, true);
            WriteAttributeValue(" ", 3809, "this.value)", 3810, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </td>\r\n\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 3909, "\"", 3937, 2);
            WriteAttributeValue("", 3914, "totalItemPrice-", 3914, 15, true);
#nullable restore
#line 81 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 3929, item.Id, 3929, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                                Write(item.TotalItemPrice.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>تومان</span></td>\r\n\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 4036, "\"", 4062, 2);
            WriteAttributeValue("", 4041, "discountRate-", 4041, 13, true);
#nullable restore
#line 83 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 4054, item.Id, 4054, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 84 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                   Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span>%</span>\r\n                                    </td>\r\n\r\n                                    <td class=\"price_alltd\"");
            BeginWriteAttribute("id", " id=\"", 4286, "\"", 4313, 2);
            WriteAttributeValue("", 4291, "itemPayAmount-", 4291, 14, true);
#nullable restore
#line 88 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
WriteAttributeValue("", 4305, item.Id, 4305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 89 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                   Write(item.ItemPayAmount.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span>تومان</span>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""cart-page-content col-xl-12 col-lg-12 col-md-12"">
                <div class=""row cart_details"">
                    <div class=""cart-page-aside col-xl-4 col-lg-5 col-md-5 divider_details"">
                        <table class=""table table_details"">
                            <tbody>
                                <tr>
                                    <td>قیمت کل سفارش:</td>
                                    <td id=""totalAmount"">");
#nullable restore
#line 105 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                    Write(Model.Cart.TotalAmount.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>تومان</span></td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>سود شما از خرید:</td>\r\n                                    <td id=\"discountAmount\">");
#nullable restore
#line 109 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                       Write(Model.Cart.DiscountAmount.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>تومان</span></td>\r\n                                </tr>\r\n                                <tr class=\"all\">\r\n                                    <td>مبلغ قابل پرداخت:</td>\r\n                                    <td id=\"amountPaid\">");
#nullable restore
#line 113 "C:\Users\Alireza\Desktop\DigiOne\ServiceHost\Pages\Cart.cshtml"
                                                   Write(Model.Cart.AmountPaid.ToMoney());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>تومان</span></td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td colspan=\"2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde9a0c83b1a523cf39974f0c41ab11c5de14e929d3563f8dba05edb9dcac03b21755", async() => {
                WriteLiteral(" پرداخت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</main>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        function changeCartItemCount(id, totalPriceId, itemPayAmountId, discountRateId, totalAmount, discountAmount, amountPaid, count) {
            var products = JSON.parse($.cookie(cookieName) || '[]');

            const productItemIndex = products.findIndex(x => x.id === id);
            const product = products[productItemIndex];
            product.count = count;

            var newTotalAmount = 0;
            var newDiscountAmount = 0;

            for (var item of products) {
                const priceAsNumber = parsePrice(item.price);
                newTotalAmount += priceAsNumber * parseInt(item.count);

                const discountRate = parseFloat($(`#discountRate-${item.id}`).text());
                newDiscountAmount += (priceAsNumber * parseInt(item.count) * discountRate) / 100;
            }

            var newAmountPaid = newTotalAmount - newDiscountAmount;

            const newPrice = parsePrice(product.price) * parseInt(count);
            const");
                WriteLiteral(@" discountRate = parseFloat($(`#${discountRateId}`).text());
            const calculationDiscountAmount = (newPrice * discountRate) / 100;
            const newItemPayAmount = newPrice - calculationDiscountAmount;

            updateElement(totalPriceId, newPrice);
            updateElement(itemPayAmountId, newItemPayAmount);
            updateElement(totalAmount, newTotalAmount);
            updateElement(discountAmount, newDiscountAmount);
            updateElement(amountPaid, newAmountPaid);

            $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: '/' });
            updateCart();
        }

        function updateElement(elementId, value) {
            $(`#${elementId}`).html(value.toLocaleString() + '<span> تومان</span>');
        }

        function parsePrice(priceString) {
            return parseFloat(priceString.replace(/[^0-9.]+/g, ''));
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.CartModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.CartModel>)PageContext?.ViewData;
        public ServiceHost.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591